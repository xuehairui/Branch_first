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

namespace Branch.com.proem.exm.window.history
{
    /// <summary>
    /// 选择单据页面
    /// </summary>
    public partial class HIQueryList : Form
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(HIQueryList));

        //private HistoryInform historyInform;
        ///// <summary>
        ///// 输入的关键词
        ///// </summary>
        //private string keyStr = null;
        /// <summary>
        /// 订单号
        /// </summary>
        private string order_Num = null;
        private string order_Name = null;
        private string order_Phone = null;
        private string order_Card = null;
        ///// <summary>
        ///// 选取单元格的行
        ///// </summary>
        //private int row = -1;
        ///// <summary>
        ///// 选取单元格的列
        ///// </summary>
        //private int column = -1;

        public HIQueryList()
        {
            InitializeComponent();
        }

        public HIQueryList(string order_Num, string name, string phone, string card)
        {
            InitializeComponent();
            this.order_Num = order_Num;
            this.order_Name = name;
            this.order_Phone = phone;
            this.order_Card = card;
        }

        private void HIQueryList_Load(object sender, EventArgs e)
        {
            idTextBox.Text = order_Num;
            nameTextBox.Text = order_Name;
            informTextBox.Text = order_Phone;
            cardTextBox.Text = order_Card;

            string sql = "select sum(nums) as nums,name,sum(g_price*nums) as totalprice,classify_name,goods_unit,delFlag,goods_specifications,serialNumber,g_price as actualnums,goodsfile_id,goods_class_id,g_price,orderNum from "
                + " (select a.goods_state,a.name,a.nums,b.goods_specifications,b.goods_unit,a.g_price,b.id as goodsfile_id,b.delFlag,b.serialNumber,c.classify_name,b.goods_class_id,b.goods_supplier_id,e.orderNum "
                + "from zc_order_history e  "
                + "LEFT JOIN zc_associator_info f on e.member_id = f.id "
                + " LEFT JOIN zc_order_history_item a on e.id = a.order_id "
                + " left join zc_goods_master b on a.goodsfile_id = b.id "
                + " left join zc_classify_info c on b.goods_class_id = c.id "
                + " where e.orderNum='" + order_Num + "'"
                + " )as d group by name,delFlag,classify_name,goods_unit,goods_specifications,serialNumber,g_price,goodsfile_id,goods_class_id ";

            MysqlDBHelper dbHelper = new MysqlDBHelper();
            DataSet ds = dbHelper.GetDataSet(sql, "zc_order_history");
            listDataGridView.AutoGenerateColumns = false;
            listDataGridView.DataSource = ds;
            listDataGridView.DataMember = "zc_order_history";
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

        private void HIQueryList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            //if (e.KeyCode == Keys.Y || e.KeyCode == Keys.Enter)
            //{
            //    okButton_Click(this, EventArgs.Empty);
            //}
        }

        private void listDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == -1)
            //{
            //    return;
            //}
            //row = itemDataGridView.CurrentCell.RowIndex;
            //column = itemDataGridView.CurrentCell.ColumnIndex;
        }

        private void listDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (e.RowIndex != -1 && e.ColumnIndex == 7)
            {
                try
                {
                    int num = listDataGridView.Rows[e.RowIndex].Cells[7].Value == null ? 0 : Convert.ToInt32(listDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString());
                    Double price = Convert.ToDouble(listDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                    listDataGridView.Rows[e.RowIndex].Cells[10].Value = Math.Round(num * price, 2).ToString("0.00");
                }
                catch (Exception ex)
                {
                    log.Error("自动计算金额错误", ex);
                }
            }
            if (e.RowIndex != -1 && e.ColumnIndex == 7)
            {
                int cot = Convert.ToInt32(listDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString());
                if (cot != 0)
                {
                    this.listDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    this.listDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Blue;
                }
            }
        }

        private void listDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == 7)
            {
                return;
            }
            //row = itemDataGridView.CurrentCell.RowIndex;
            //column = itemDataGridView.CurrentCell.ColumnIndex;

            //for (int i = 0; i < itemDataGridView.Rows.Count; i++)
            //{
            string _selectValue = listDataGridView.Rows[e.RowIndex].Cells[0].EditedFormattedValue.ToString();
            if (_selectValue == "True")
            {
                listDataGridView.Rows[e.RowIndex].Cells[0].Value = false;
                //listDataGridView.Rows[e.RowIndex].Cells[7].Value = 0;
            }
            if (_selectValue == "False")
            {
                listDataGridView.Rows[e.RowIndex].Cells[0].Value = true;
                //int num = Convert.ToInt32(listDataGridView.Rows[e.RowIndex].Cells[5].Value);
                //listDataGridView.Rows[e.RowIndex].Cells[7].Value = num;
                this.listDataGridView.CurrentCell = listDataGridView[7, e.RowIndex];
                listDataGridView.BeginEdit(true);
            }
            //}
        }

        private void returnOrderButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("当前订单内商品是否确定退款？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            for (int i = 0; i < listDataGridView.Rows.Count; i++)
            {
                string _selectValue = listDataGridView.Rows[i].Cells[0].EditedFormattedValue.ToString();
                if (_selectValue == "False")
                {
                    listDataGridView.Rows[i].Cells[0].Value = true;
                    int num = Convert.ToInt32(listDataGridView.Rows[i].Cells[5].Value);
                    listDataGridView.Rows[i].Cells[7].Value = num;
                }
            }
            saveReturnInform();
            MessageBox.Show("退款信息已提交！");
        }

        private void returnGoodsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("所选商品是否确定退款？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            saveReturnInform();
            MessageBox.Show("退款信息已提交！");
        }

        /// <summary>
        /// 将退款信息存入数据库
        /// </summary>
        public void saveReturnInform()
        {
            //
            for (int i = 0; i < listDataGridView.Rows.Count; i++)
            {
                string _selectValue = listDataGridView.Rows[i].Cells[0].EditedFormattedValue.ToString();
                if (_selectValue == "True")
                {
                    //string product = listDataGridView[1, i].Value.ToString();
                    //string num = listDataGridView[7, i].Value.ToString();
                    //string money = listDataGridView[10, i].Value.ToString();
                    ////MessageBox.Show(product+":"+num + ":" + money);
                }
            }

            //



        }

    }
}