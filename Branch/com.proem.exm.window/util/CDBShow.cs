using Branch.com.proem.exm.util;
using log4net;
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
    /// 支付信息展示
    /// </summary>
    public partial class CDBShow : Form
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(CDBShow));

        /// <summary>
        /// 订单号
        /// </summary>
        private string orderNum = null;

        public CDBShow()
        {
            InitializeComponent();
        }

        public CDBShow(string orderNum)
        {
            InitializeComponent();
            this.orderNum = orderNum;
        }

        private void CDBShow_Load(object sender, EventArgs e)
        {
            string sql = "SELECT a.pay_mode,a.pay_amount,a.order_id FROM pay_info a WHERE a.order_id = '"+orderNum+"' ";
            try
            {
                MysqlDBHelper dbHelper = new MysqlDBHelper();
                DataSet ds = dbHelper.GetDataSet(sql, "pay_info");
                showDataGridView.AutoGenerateColumns = false;
                showDataGridView.DataSource = ds;
                showDataGridView.DataMember = "pay_info";
            }
            catch (Exception ex)
            {
                log.Error("支付明细列表绑定数据失败", ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //if (e.RowIndex > -1)
            //{
            //    if (showDataGridView.Rows[e.RowIndex].Cells[0].Value.Equals(BranchPay.money))
            //    {
            //        showDataGridView.Rows[e.RowIndex].Cells[0].Value = "现金支付";
            //    }
            //    if (showDataGridView.Rows[e.RowIndex].Cells[0].Value.Equals(BranchPay.card))
            //    {
            //        showDataGridView.Rows[e.RowIndex].Cells[0].Value = "会员卡支付";
            //    }
            //}
        }
    }
}
