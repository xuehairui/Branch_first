using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using Branch.com.proem.exm.window.order;
using Branch.com.proem.exm.window.receive;
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
    /// 扫描>商品选择
    /// </summary>
    public partial class ScanGood : Form
    {
        private readonly ILog log = LogManager.GetLogger(typeof(ScanGood));
        private DeliveryGoods deliveryGoods;
        private ReturnGoods returnGoods;
        private CustomerDelivery customerDelivery;
        /// <summary>
        /// 扫描的条码
        /// </summary>
        private string bar = "";
        /// <summary>
        /// 数量
        /// </summary>
        private string num = "";
        /// <summary>
        /// 当前传入的页面
        /// </summary>
        private string count = "";

        public ScanGood()
        {
            InitializeComponent();
        }

        public ScanGood(DeliveryGoods obj, string bar, string num)
        {
            InitializeComponent(); 
            this.deliveryGoods = obj;
            this.bar = bar;
            this.num = num;
            this.count = ParentWindow.DeliveryGoods.ToString();
            if (num.Equals(""))
            {
                this.num = "1";
            }
        }

        public ScanGood(ReturnGoods obj, string bar, string num)
        {
            InitializeComponent();
            this.returnGoods = obj;
            this.bar = bar;
            this.num = num;
            this.count = ParentWindow.ReturnGoods.ToString();
            if (num.Equals(""))
            {
                this.num = "1";
            }
        }

        public ScanGood(CustomerDelivery obj, string bar, string num)
        {
            InitializeComponent();
            this.customerDelivery = obj;
            this.bar = bar;
            this.num = num;
            this.count = ParentWindow.CustomerDelivery.ToString();
            if (num.Equals(""))
            {
                this.num = "1";
            }
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

        private void ScanGood_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select a.SERIALNUMBER ,a.goods_name,a.goods_unit,a.goods_specifications,a.goods_price,a.remark,a.id from zc_goods_master a "
                    + "left join zc_classify_info b on a.goods_class_id = b.id "
                    + "left join zc_classify_info c on a.goods_brand_id = c.id "
                    + "left join zc_provider_info d on a.goods_supplier_id = d.id where 1=1 ";
                if (this.count.Equals(ParentWindow.CustomerDelivery.ToString()) || this.count.Equals(ParentWindow.DeliveryGoods.ToString()))
                {
                    sql += " and a.SERIALNUMBER like '%" + bar + "%'";
                }
                else
                {
                    sql += " and a.SERIALNUMBER like '%" + bar + "%' or a.goods_name like '%" + bar + "%' or a.goods_unit like '%" + bar + "%' or a.goods_specifications like '%" + bar + "%' or a.goods_price like '%" + bar + "%' or a.remark like '%" + bar + "%' ";
                }
                sql += ";";
                MysqlDBHelper dbHelper = new MysqlDBHelper();
                DataSet ds = dbHelper.GetDataSet(sql, "zc_goods_master"); ;
                goodsDataGridView.DataSource = ds;
                goodsDataGridView.DataMember = "zc_goods_master";
            }
            catch (Exception ex)
            {
                log.Error("加载数据源发生异常", ex);
            }
        }

        /// <summary>
        /// 将表格内的数据传入页面
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

            if (this.count.Equals(ParentWindow.DeliveryGoods.ToString()))
            {
                this.deliveryGoods.AddGoods(zcGoodsMaster, num);
            }
            else if (this.count.Equals(ParentWindow.ReturnGoods.ToString()))
            {
                this.returnGoods.AddGoods(zcGoodsMaster, num);
            }
            else if (this.count.Equals(ParentWindow.CustomerDelivery.ToString()))
            {
                this.customerDelivery.AddGoods(zcGoodsMaster, num);
            }
        }

        private void goodsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            choosegoods();
            this.Close();
        }

        private void ScanGood_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Y || e.KeyCode == Keys.Enter)
            {
                okButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.L || e.KeyCode == Keys.Escape)
            {
                leaveButton_Click(this, EventArgs.Empty);
            }
        }
    }
}