using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using Branch.com.proem.exm.window.retreat;
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
    /// 选择添加商品
    /// </summary>
    public partial class GoodsChoose : Form
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(GoodsChoose));
        private ReturnGoods returnGoods;

        /// <summary>
        /// GCType是否被载入
        /// </summary>
        private bool typeflag = true;
        /// <summary>
        /// GCBrand是否被载入
        /// </summary>
        private bool brandflag = true;
        /// <summary>
        /// GCSupplier是否被载入
        /// </summary>
        private bool supplierflag = true;
        /// <summary>
        /// 是否选择查询前100条数据
        /// </summary>
        private bool sizeflag = false;
        /// <summary>
        /// 商品类别name
        /// </summary>
        private string typesname = "";
        /// <summary>
        /// 商品类别id
        /// </summary>
        private string typeid = "";
        /// <summary>
        /// 商品品牌name
        /// </summary>
        private string brandname = "";
        /// <summary>
        /// 商品品牌id
        /// </summary>
        private string brandid = "";
        /// <summary>
        /// 商品供应商name
        /// </summary>
        private string suppliername = "";
        /// <summary>
        /// 商品供应商id
        /// </summary>
        private string supplierid = "";
        /// <summary>
        /// 选择的节点 1.类别2.品牌3.供应商
        /// </summary>
        private string nodeflag = "0";
        /// <summary>
        /// 当前传入的页面
        /// </summary>
        private string count = "";

        public GoodsChoose()
        {
            InitializeComponent();
        }

        public GoodsChoose(ReturnGoods obj)
        {
            InitializeComponent();
            this.returnGoods = obj;
            this.count = ParentWindow.ReturnGoods.ToString();
        }

        private void GoodsChoose_Load(object sender, EventArgs e)
        {
            if (typeflag)
            {
                GCType gCType = new GCType(this);
                gCType.TopLevel = false;
                this.goodsClassify_TypePanel.Controls.Add(gCType);
                typeflag = false;
                gCType.Show();
            }
        }

        private void typeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.goodsClassify_SupplierPanel.Hide();
            this.goodsClassify_BrandPanel.Hide();
            this.goodsClassify_TypePanel.Show();
            if (typeflag)
            {
                GCType gCType = new GCType(this);
                gCType.TopLevel = false;
                this.goodsClassify_TypePanel.Controls.Add(gCType);
                typeflag = false;
                gCType.Show();
            }
        }

        private void brandRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.goodsClassify_SupplierPanel.Hide();
            this.goodsClassify_TypePanel.Hide();
            this.goodsClassify_BrandPanel.Show();
            if (brandflag)
            {
                GCBrand gCBrand = new GCBrand(this);
                gCBrand.TopLevel = false;
                this.goodsClassify_BrandPanel.Controls.Add(gCBrand);
                brandflag = false;
                gCBrand.Show();
            }
        }

        private void supplierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.goodsClassify_BrandPanel.Hide();
            this.goodsClassify_TypePanel.Hide();
            this.goodsClassify_SupplierPanel.Show();
            if (supplierflag)
            {
                GCSupplier gCSupplier = new GCSupplier(this);
                gCSupplier.TopLevel = false;
                this.goodsClassify_SupplierPanel.Controls.Add(gCSupplier);
                supplierflag = false;
                gCSupplier.Show();
            }
        }

        /// <summary>
        /// GCType中选中的节点名称
        /// </summary>
        /// <param name="name">被选择的商品类别name</param>
        /// <param name="id">被选择的商品类别id</param>
        public void SetTypename(string name, string id)
        {
            this.typesname = name;
            this.typeid = id;
            nodeflag = "1";
            queryGoods();
        }

        /// <summary>
        /// GCBrand中选中的节点名称
        /// </summary>
        /// <param name="name">被选择的商品品牌name</param>
        /// <param name="id">被选择的商品品牌id</param>
        public void SetBrandname(string name, string id)
        {
            this.brandname = name;
            this.brandid = id;
            nodeflag = "2";
            queryGoods();
        }

        /// <summary>
        /// GCSupplier中选中的节点名称
        /// </summary>
        /// <param name="name">被选择的商品供应商name</param>
        /// <param name="id">被选择的商品供应商id</param>
        public void SetSuppliername(string name, string id)
        {
            this.suppliername = name;
            this.supplierid = id;
            nodeflag = "3";
            queryGoods();
        }

        /// <summary>
        /// 展示商品列表
        /// </summary>
        private void queryGoods()
        {
            try
            {
                string sql = "select a.SERIALNUMBER ,a.goods_name,a.goods_unit,a.goods_specifications,a.goods_price,a.remark,a.id from zc_goods_master a "
                    + "left join zc_classify_info b on a.goods_class_id = b.id "
                    + "left join zc_classify_info c on a.goods_brand_id = c.id "
                    + "left join zc_provider_info d on a.goods_supplier_id = d.id where 1=1 ";
                sql += addNodeConditions();
                sql += addTextConditions();
                sql += addSizeConditions();
                sql += ";";
                MysqlDBHelper dbHelper = new MysqlDBHelper();
                DataSet ds = dbHelper.GetDataSet(sql, "zc_goods_master");
                goodsDataGridView.DataSource = ds;
                goodsDataGridView.DataMember = "zc_goods_master";
            }
            catch (Exception ex)
            {
                log.Error("展示商品列表绑定数据失败", ex);
            }
        }

        /// <summary>
        /// 查询前100条数据
        /// </summary>
        /// <returns></returns>
        private string addSizeConditions()
        {
            string conditions = "";
            if (sizeflag)
            {
                conditions += " limit 0,100 ";
            }
            return conditions;
        }

        /// <summary>
        /// 关键词查询
        /// </summary>
        /// <returns></returns>
        private string addTextConditions()
        {
            string conditions = "";
            if (!keywordTextBox.Text.Equals(""))
            {
                conditions += " and a.SERIALNUMBER like '%" + keywordTextBox.Text + "%' or a.goods_name like '%" + keywordTextBox.Text + "%' or a.goods_unit like '%" + keywordTextBox.Text + "%' or a.goods_specifications like '%" + keywordTextBox.Text + "%' or a.goods_price like '%" + keywordTextBox.Text + "%' or a.remark like '%" + keywordTextBox.Text + "%' ";
            }
            return conditions;
        }

        /// <summary>
        /// 根据节点查询
        /// </summary>
        /// <returns></returns>
        private string addNodeConditions()
        {
            string conditions = "";
            if (nodeflag.Equals("1"))
            {
                //conditions = " and a.goods_class_id='" + this.typeid + "' ";
                //conditions = " and a.goods_class_id='" + this.typeid + "' or b.parentId ='" + this.typeid + "' ";
                conditions = " and a.goods_class_id='" + this.typeid + "' or b.parentPath like '%" + this.typeid + "%' ";
            }
            else if (nodeflag.Equals("2"))
            {
                conditions = " and a.goods_brand_id='" + this.brandid + "' ";
            }
            else if (nodeflag.Equals("3"))
            {
                conditions = " and a.goods_supplier_id='" + this.supplierid + "' ";
            }
            nodeflag = "0";
            return conditions;
        }

        private void queryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (queryCheckBox.Checked == true)
            {
                sizeflag = true;
            }
            else
            {
                sizeflag = false;
            }
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            queryGoods();
        }

        /// <summary>
        /// 将表格内的数据传入ReturnGoods页面
        /// </summary>
        private void choosegoods()
        {
            ZcGoodsMaster zcGoodsMaster = new ZcGoodsMaster();
            zcGoodsMaster.SerialNumber = goodsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            zcGoodsMaster.GoodsName = goodsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            zcGoodsMaster.GoodsUnit = goodsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            zcGoodsMaster.GoodsSpecifications = goodsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            zcGoodsMaster.GoodsPrice = float.Parse(goodsDataGridView.SelectedRows[0].Cells[4].Value.ToString());
            zcGoodsMaster.Remark = goodsDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            zcGoodsMaster.Id = goodsDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            if (this.count.Equals(ParentWindow.ReturnGoods.ToString()))
            {
                this.returnGoods.AddGoods(zcGoodsMaster);
            }
        }

        private void goodsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            choosegoods();
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            choosegoods();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            choosegoods();
            this.Close();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoodsChoose_KeyDown(object sender, KeyEventArgs e)
        {
            if (keywordTextBox.Focused == false)
            {
                if (e.KeyCode == Keys.Y)
                {
                    okButton_Click(this, EventArgs.Empty);
                }
                if (e.KeyCode == Keys.H||e.KeyCode == Keys.Enter)
                {
                    chooseButton_Click(this, EventArgs.Empty);
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    queryButton_Click(this, EventArgs.Empty);
                }

            }
            if (e.KeyCode == Keys.L || e.KeyCode == Keys.Escape)
            {
                leaveButton_Click(this, EventArgs.Empty);
            }
        }

    }
}