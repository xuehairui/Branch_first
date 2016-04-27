using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using Branch.com.proem.exm.window.main;
using Branch.com.proem.exm.window.util;
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

namespace Branch.com.proem.exm.window.retreat
{
    /// <summary>
    /// 扫码退货
    /// </summary>
    public partial class ReturnGoods : Form
    {
        private readonly ILog log = LogManager.GetLogger(typeof(ReturnGoods));

        /// <summary>
        /// 选取单元格的行
        /// </summary>
        private int row = -1;
        /// <summary>
        /// 选取单元格的列
        /// </summary>
        private int column = -1;

        public ReturnGoods()
        {
            InitializeComponent();
        }

        private void ReturnGoods_Load(object sender, EventArgs e)
        {
            ItemInput itemInput = new ItemInput(this, log);
            itemInput.TopLevel = false;
            this.itemInputPanel.Controls.Add(itemInput);
            itemInput.Show();

            Times times = new Times();
            times.TopLevel = false;
            this.timePanel.Controls.Add(times);
            times.Show();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            BranchMain branchMain = new BranchMain();
            branchMain.Show();
            this.Close();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            RGReturnList rGReturnList = new RGReturnList();
            rGReturnList.ShowDialog();//打开已有单据列表-可查询
        }

        private void newBuiltButton_Click(object sender, EventArgs e)
        {
            //N
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //S
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //D
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {
            RGSupplierChoose rGSupplierChoose = new RGSupplierChoose();
            rGSupplierChoose.ShowDialog();//选择供应商
        }

        private void buyerButton_Click(object sender, EventArgs e)
        {
            RGBuyerChoose rGBuyerChoose = new RGBuyerChoose();
            rGBuyerChoose.ShowDialog();//选择采购员
        }

        private void returnIdOldButton_Click(object sender, EventArgs e)
        {
            RGReturnIdChoose rGReturnIdChoose = new RGReturnIdChoose();
            rGReturnIdChoose.ShowDialog();//选择原始单号-收货单
        }

        private void addGoodButton_Click(object sender, EventArgs e)
        {
            GoodsChoose goodsChoose = new GoodsChoose(this);
            goodsChoose.ShowDialog();//添加商品
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            Scan scan = new Scan(this);
            scan.ShowDialog();//扫描
        }

        /// <summary>
        ///  添加商品
        /// </summary>
        /// <param name="obj"></param>
        public void AddGoods(ZcGoodsMaster obj)
        {
            //DataSet ds = (DataSet)itemDataGridView.DataSource;
            //MessageBox.Show("货号为" + obj.SerialNumber + "的" + obj.GoodsName);
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    if (ds.Tables[0].Rows[i][0].ToString().Equals(obj.SerialNumber))
            //    {
            //        MessageBox.Show("货号为" + obj.SerialNumber + "的" + obj.GoodsName + "已经在第" + (i + 1) + "行，请不要重复添加!");
            //        return;
            //    }
            //}
            //ds.Tables[0].Rows.Add(obj.SerialNumber, obj.GoodsName, obj.GoodsUnit, obj.GoodsSpecifications, 0, obj.GoodsPrice, 0.00, obj.Remark, Guid.NewGuid().ToString(), obj.Id);
        }

        /// <summary>
        /// 添加商品
        /// </summary>a
        /// <param name="obj"></param>
        /// <param name="num">商品份数</param>                                                                                                                                                                                                                                                                                                                                              
        public void AddGoods(ZcGoodsMaster obj, string num)
        {
            //DataSet ds = (DataSet)itemDataGridView.DataSource;

            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    if (ds.Tables[0].Rows[i][0].ToString().ToString().Equals(obj.SerialNumber))
            //    {
            //        string nums = itemDataGridView[5, i].Value.ToString();
            //        itemDataGridView[5, i].Value = Convert.ToInt32(nums) + Convert.ToInt32(num);
            //        return;
            //    }
            //}
            //ds.Tables[0].Rows.Add(obj.SerialNumber, obj.GoodsName, obj.GoodsUnit, obj.GoodsSpecifications, num, obj.GoodsPrice, (Convert.ToInt32(num) * obj.GoodsPrice).ToString("0.00"), obj.Remark, Guid.NewGuid().ToString(), obj.Id);
            ////Calculate();
        }

        private void deleteLineButton_Click(object sender, EventArgs e)
        {
            if (itemDataGridView.RowCount == 0)
            {
                return;
            }
            DialogResult result = MessageBox.Show("确定删除吗？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            { 
                string id = itemDataGridView.SelectedRows[0].Cells[8].Value.ToString();
                DataSet ds = (DataSet)itemDataGridView.DataSource;
                ds.Tables[0].Rows.RemoveAt(itemDataGridView.SelectedRows[0].Index);
                if (!"".Equals(id))
                {
                    //BranchZcOrderTransitItemService branchService = new BranchZcOrderTransitItemService();
                    //branchService.DeleteById(id);
                }
            }
            else
            {
                return;
            }
            if (itemDataGridView.RowCount > 0)
            {
                itemDataGridView.Rows[itemDataGridView.RowCount - 1].Selected = true;
            }
        }

        private void ReturnGoods_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.O)
            {
                openButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.N)
            {
                newBuiltButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.S)
            {
                saveButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.D)
            {
                deleteButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.E)
            {
                deleteLineButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.G)
            {
                addGoodButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.P)
            {
                scanButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.Escape)
            {
                returnButton_Click(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        public void itemInput(string num)
        {
            if (column == 7 && row != -1)
            {
                itemDataGridView[column, row].Value = num;
            }
            else
            {
                //string bar = numberTextBox.Text;
                //QueryGoods query = new QueryGoods();
                //int item = query.queryExistGood(bar, "", this, log);//查询后获得
                //if (item == 0)
                //{
                //    MessageBox.Show("商品不存在,请重新输入", "提示", MessageBoxButtons.OK);
                //}
                //else if (item == 1)
                //{
                //    numberTextBox.Text = "";
                //}
                //else if (item > 1 && item < 50)
                //{
                //    DGSGood dGSGood = new DGSGood(this, bar, "");
                //    dGSGood.ShowDialog();
                //    numberTextBox.Text = "";
                //}
                //else if (item >= 50)
                //{
                //    MessageBox.Show("匹配的商品记录数大于[50]条，请输入更多内容以减少匹配范围", "提示", MessageBoxButtons.OK);
                //}
            }
            column = -1;
            row = -1;
        }
    }
}
