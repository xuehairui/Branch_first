using Branch.com.proem.exm.service.main;
using Branch.com.proem.exm.util;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Branch.com.proem.exm.window.main
{
    public partial class SetCode : Form
    {
        /// <summary>
        /// 选取单元格的行
        /// </summary>
        private int row = -1;
        /// <summary>
        /// 选取单元格的列
        /// </summary>
        private int column = -1;
        /// <summary>
        /// 分店系统编码
        /// </summary>
        private string code;

        public SetCode()
        {
            InitializeComponent();
        }

        public SetCode(string code)
        {
            this.code = code;
            InitializeComponent();
        }

        private void SetCode_Load(object sender, EventArgs e)
        {
            OracleConnection conn = OracleUtil.OpenConn();
            OracleDataAdapter da;
            DataSet ds;
            string sql = "select branch_code,branch_name from ZC_BRANCH_TOTAL ";
            da = new OracleDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds, "ZC_BRANCH_TOTAL");
            listDataGridView.DataSource = ds.Tables[0];
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            submit();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            row = listDataGridView.CurrentCell.RowIndex;
            column = listDataGridView.CurrentCell.ColumnIndex;
        }

        private void listDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            row = listDataGridView.CurrentCell.RowIndex;
            column = listDataGridView.CurrentCell.ColumnIndex;
            submit();
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        private void submit()
        {
            string branch_code = listDataGridView.CurrentRow.Cells[0].Value.ToString();
            string branch_name = listDataGridView.CurrentRow.Cells[1].Value.ToString();
            //MessageBox.Show(code + "、" + branch_code + "、" + branch_name);


            DownloadIdentifyService identifyService = new DownloadIdentifyService();
            //将系统编码存入本地


        }

        private void listDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //行号
            using (SolidBrush b = new SolidBrush(this.listDataGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(Convert.ToString(e.RowIndex + 1),
                e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
