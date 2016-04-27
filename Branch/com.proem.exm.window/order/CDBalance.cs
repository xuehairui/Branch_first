using Branch.com.proem.exm.util;
using Branch.com.proem.exm.window.util;
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

namespace Branch.com.proem.exm.window.order
{
    /// <summary>
    /// 选择支付方式
    /// </summary>
    public partial class CDBalance : Form
    {
        /// <summary>
        /// 日志log
        /// </summary>
        private ILog log = LogManager.GetLogger(typeof(CDBalance));

        private CustomerDelivery customerDelivery;
        CDBDetial cDBDetial = null;
        /// <summary>
        /// 选择的支付方式
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
        /// 订单号
        /// </summary>
        private string orderNum = null;
        /// <summary>
        /// 支付的总金额
        /// </summary>
        private float alreadyTotalAmount = 0;

        public CDBalance()
        {
            InitializeComponent();
        }

        public CDBalance(CustomerDelivery obj, float totalAmountValue, string keyStr, string orderNum)
        {
            InitializeComponent();
            this.customerDelivery = obj;
            this.totalAmountValue = totalAmountValue;
            this.keyStr = keyStr;
            this.orderNum = orderNum;
        }

        private void moneyButton_Click(object sender, EventArgs e)
        {
            //
            branch = "money";
            detial();
        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            //
            branch = "card";
            detial();
        }

        private void detial()
        {
            cDBDetial = new CDBDetial(customerDelivery, branch, totalAmountValue, keyStr, orderNum);
            cDBDetial.closefather += new CDBDetial.childclose(this.closethis);
            cDBDetial.ShowDialog();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            check();
            //MessageBox.Show(alreadyTotalAmount + "");
            //
            //CDBShow cDBShow = new CDBShow(orderNum);
            //cDBShow.ShowDialog();
            if (alreadyTotalAmount != totalAmountValue)
            {
                //MessageBox.Show(alreadyTotalAmount + "已支付" + totalAmountValue + "合计");
                MessageBox.Show("当前商品尚未完成支付");
                return;
            }
            //MessageBox.Show(alreadyTotalAmount+"alreadyTotalAmount_" + totalAmountValue+"totalAmountValue");
            MessageBox.Show("当前商品已完成支付！");
            customerDelivery.balance_data();
            customerDelivery.initData();
            customerDelivery.initNumberAndAmount();
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (alreadyTotalAmount != totalAmountValue)
            {
                if (MessageBox.Show("当前商品尚未完成支付，是否直接退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
            }
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

        public void closethis()
        {
            MessageBox.Show("当前商品已完成支付！");
            customerDelivery.balance_data();
            customerDelivery.initData();
            this.Close();
        }
    }
}