using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.service.branch;
using Branch.com.proem.exm.service.master;
using Branch.com.proem.exm.util;
using Branch.com.proem.exm.window.order;
using log4net;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branch.com.proem.exm.window.util
{
    /// <summary>
    /// 选择支付方式
    /// </summary>
    public partial class CDBDetial : Form
    {
        /// <summary>
        /// 日志log
        /// </summary>
        private ILog log = LogManager.GetLogger(typeof(CDBDetial));
        private CustomerDelivery customerDelivery;
        CDBDMoney cDBDMoney = null;
        CDBDCard cDBDCard = null;
        /// <summary>
        /// 支付方式
        /// </summary>
        private string branch = null;
        /// <summary>
        /// 金额合计
        /// </summary>
        private float totalAmountValue = 0;
        /// <summary>
        /// 输入的关键词
        /// </summary>
        private string keyStr = null;
        /// <summary>
        /// 卡内金额
        /// </summary>
        private string associator_amount = null;
        /// <summary>
        /// 会员卡号
        /// </summary>
        private string associator_cardnumber = null;
        /// <summary>
        /// 订单号
        /// </summary>
        private string orderNum = null;
        /// <summary>
        /// 支付的金额
        /// </summary>
        public float alreadyAmount = 0;
        /// <summary>
        /// 支付的总金额
        /// </summary>
        private float alreadyTotalAmount = 0;

        public delegate void childclose();
        public event childclose closefather;
        private bool flag = false;


        public CDBDetial()
        {
            InitializeComponent();
        }

        public CDBDetial(CustomerDelivery obj, String branch, float totalAmountValue, string keyStr, string orderNum)
        {
            InitializeComponent();
            this.customerDelivery = obj;
            //this.branch = branch;
            this.totalAmountValue = totalAmountValue;
            this.keyStr = keyStr;
            this.orderNum = orderNum;
            if (branch.Equals("money"))
            {
                this.Text = "现金支付";
                this.branch = BranchPay.money;
            }
            if (branch.Equals("card"))
            {
                this.Text = "会员卡支付";
                this.branch = BranchPay.card;
            }
        }

        private void CDBDetial_Load(object sender, EventArgs e)
        {
            amount();
            if (branch.Equals(BranchPay.money))
            {//
                cDBDMoney = new CDBDMoney(customerDelivery, totalAmountValue);
                cDBDMoney.TopLevel = false;
                this.cDBDetialPanel.Controls.Add(cDBDMoney);
                cDBDMoney.Show();
            }
            if (branch.Equals(BranchPay.card))
            {//
                cDBDCard = new CDBDCard(customerDelivery, totalAmountValue, associator_amount);
                cDBDCard.TopLevel = false;
                this.cDBDetialPanel.Controls.Add(cDBDCard);
                cDBDCard.Show();
            }
        }



        private string amount()
        {
            int con = 0;
            MysqlDBHelper dbHelper = new MysqlDBHelper();
            MySqlConnection conn = dbHelper.GetConnection();
            string sql = null;
            try
            {
                sql = "select f.associator_cardnumber,e.consignee,e.cansignphone,f.associator_amount "
                    + " from zc_order_transit e  "
                    + " LEFT JOIN zc_associator_info f on e.member_id = f.id "
                    + " WHERE 1=1 ";
                sql += " and f.associator_cardnumber like '%" + keyStr + "%' or e.consignee like '%" + keyStr + "%' or e.cansignphone like '%" + keyStr + "%' ";
                MySqlDataReader reader = dbHelper.GetReader(sql, conn);
                while (reader.Read())
                {
                    con += 1;
                    if (con == 1)
                    {//
                        associator_cardnumber = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                        associator_amount = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("会员明细列表绑定数据失败", ex);
            }
            finally
            {
                dbHelper.CloseConnection(conn);
            }
            return associator_amount;
        }

        private void sureButton_Click(object sender, EventArgs e)
        {
            if (branch.Equals(BranchPay.money))
            {
                alreadyAmount = cDBDMoney.alreadyAmount;
            }
            if (branch.Equals(BranchPay.card))
            {
                alreadyAmount = cDBDCard.alreadyAmount;
            }

            PayInfo payinfo = new PayInfo();
            //付款单号
            payinfo.Id = DateTime.Now.ToString("yyyyMMddHHmmss");
            payinfo.CreateTime = DateTime.Now;
            payinfo.UpdateTime = DateTime.Now;
            //付款金额
            payinfo.PayAmount = alreadyAmount.ToString();
            //订单号
            payinfo.orderId = orderNum;
            //业务员
            payinfo.salesmanId = LoginUserInfo.id;
            //付款日期
            payinfo.payDate = DateTime.Now;
            //支付方式
            payinfo.PayMode = branch;
            //分店
            payinfo.BranchId = LoginUserInfo.branchId;
            //会员卡号
            payinfo.MemberId = associator_cardnumber;
            ///保存付款信息到本地数据库
            BranchPayInfoService branchService = new BranchPayInfoService();
            branchService.AddPayInfo(payinfo);
            ///上传付款信息到远处服务器
            ///TODO  暂时未考虑断线问题
            PayInfoService service = new PayInfoService();
            service.AddPayInfo(payinfo);

            check();
            //MessageBox.Show(alreadyTotalAmount.ToString());
            if (alreadyTotalAmount == totalAmountValue)
            {
                flag = true;
            }
            MessageBox.Show("付款成功"); 
            this.Close();
        }

        private void check()
        {
            MysqlDBHelper dbHelper = new MysqlDBHelper();
            MySqlConnection conn = dbHelper.GetConnection();
            string sql = null;
            alreadyTotalAmount = 0;
            try
            {
                sql = "SELECT a.pay_mode,a.pay_amount,a.order_id FROM pay_info a WHERE a.order_id = '" + orderNum + "' ";
                MySqlDataReader reader = dbHelper.GetReader(sql, conn);
                while (reader.Read())
                {
                    alreadyTotalAmount += float.Parse(reader.IsDBNull(1) ? string.Empty : reader.GetString(1));
                }
            }
            catch (Exception ex)
            {
                log.Error("支付信息明细列表绑定数据失败", ex);
            }
            finally
            {
                dbHelper.CloseConnection(conn);
            }
        }

        private void CDBDetial_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag)
            {
                closefather();
            }
        }

    }
}
