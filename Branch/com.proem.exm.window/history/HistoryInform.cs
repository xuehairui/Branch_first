using Branch.com.proem.exm.util;
using Branch.com.proem.exm.window.main;
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

namespace Branch.com.proem.exm.window.history
{
    public partial class HistoryInform : Form
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(HistoryInform));

        ///// <summary>
        ///// 选取单元格的行
        ///// </summary>
        //private int row = -1;
        ///// <summary>
        ///// 选取单元格的列
        ///// </summary>
        //private int column = -1;
        /// <summary>
        /// 输入的关键词
        /// </summary>
        private string keyStr = null;
        /// <summary>
        /// 订单号
        /// </summary>
        private string order_Num = null;

        public delegate void child_close();
        public event child_close history;

        public HistoryInform()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoryInform_Load(object sender, EventArgs e)
        {
            //inNameTextBox.Text = LoginUserInfo.branchName;
            inNameLabel.Text = LoginUserInfo.branchName;
            //salesmanNameTextBox.Text = LoginUserInfo.name;
            salesmanNameLabel.Text = LoginUserInfo.name;

            Times times = new Times();
            times.TopLevel = false;
            this.timePanel.Controls.Add(times);
            times.Show();

            DateTime dt = DateTime.Now;
            string date_order = dt.ToString("yyyy-MM-dd");

            queryNum();
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            queryNum();
        }

        private void listDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }

            if (listDataGridView.Columns[e.ColumnIndex].Name.Equals("orderReturnButton"))
            {
                MessageBox.Show("退货");
            }
        }

        private void listDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            //row = listDataGridView.CurrentCell.RowIndex;
            //column = listDataGridView.CurrentCell.ColumnIndex;
            order_Num = listDataGridView.CurrentRow.Cells[0].Value.ToString();
            string name = listDataGridView.CurrentRow.Cells[2].Value.ToString();
            string phone = listDataGridView.CurrentRow.Cells[3].Value.ToString();
            string card = listDataGridView.CurrentRow.Cells[4].Value.ToString();
            HIQueryList hIQueryList = new HIQueryList(order_Num, name, phone, card);
            hIQueryList.ShowDialog();
        }

        private void listDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //行号
            using (SolidBrush b = new SolidBrush(this.listDataGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(Convert.ToString(e.RowIndex + 1),
                e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
            }

            listDataGridView.RowHeadersWidth = 60;

        }

        private void HistoryInform_FormClosed(object sender, FormClosedEventArgs e)
        {
            history();
        }

        private void queryNum()
        {
            keyStr = this.queryTextBox.Text.ToString().Trim();
            try
            {
                //string sql = "select e.CONSIGNEE AS '姓名',e.CANSIGNPHONE AS '电话',f.ASSOCIATOR_CARDNUMBER AS '卡号',e.ORDERNUM as '订单号',e.ORDERAMOUNT as '金额'"
                string sql = "select e.ORDERNUM ,e.ORDERAMOUNT,e.CONSIGNEE,e.CANSIGNPHONE,f.ASSOCIATOR_CARDNUMBER "
                    + " From zc_order_history e "
                    + " LEFT JOIN zc_associator_info f on e.member_id = f.id "
                    +"where  f.associator_cardnumber like '%" + keyStr + "%' "
                    + "or e.consignee like '%" + keyStr + "%' "
                    + "or e.cansignphone like '%" + keyStr + "%' ";
                //+ " WHERE e.UPDATETIME = '" + date_order + "'";
                MysqlDBHelper dbHelper = new MysqlDBHelper();
                DataSet ds = dbHelper.GetDataSet(sql, "zc_goods_master"); ;
                listDataGridView.DataSource = ds;
                listDataGridView.DataMember = "zc_goods_master";
                
            }
            catch (Exception ex)
            {
                log.Error("加载数据源发生异常", ex);
            }
        }

        private void HistoryInform_KeyDown(object sender, KeyEventArgs e)
        {
            //if (queryTextBox.Focused)
            //{
            //    queryNum();
            //}
            if (e.KeyCode == Keys.Enter)
            {
                order_Num = listDataGridView.CurrentRow.Cells[0].Value.ToString();
                string name = listDataGridView.CurrentRow.Cells[2].Value.ToString();
                string phone = listDataGridView.CurrentRow.Cells[3].Value.ToString();
                string card = listDataGridView.CurrentRow.Cells[4].Value.ToString();
                HIQueryList hIQueryList = new HIQueryList(order_Num, name, phone, card);
                hIQueryList.ShowDialog();
            }
            if (e.KeyCode == Keys.Escape)
            {
                returnButton_Click(this, EventArgs.Empty);
            }
        }
    }
}