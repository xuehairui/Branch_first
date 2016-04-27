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
    /// 供应商选择
    /// </summary>
    public partial class GCSupplier : Form
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(GCSupplier));
        private GoodsChoose goodsChoose;
        private bool asflag = false;

        public GCSupplier()
        {
            InitializeComponent();
        }

        public GCSupplier(GoodsChoose obj)
        {
            InitializeComponent();
            this.goodsChoose = obj;
        }

        private void GCSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from zc_provider_info order by id asc;";
                MysqlDBHelper dbHelper = new MysqlDBHelper();
                DataSet ds = dbHelper.GetDataSet(sql, "zc_provider_info");
                //MessageBox.Show("1", "提示", MessageBoxButtons.OK);
                TreeNode treeNode = new TreeNode();
                treeNode.Text = "商品供应商";
                treeNode.Name = "0";
                treeNode.ImageIndex = 0;
                treeNode.SelectedImageIndex = 0;
                supplierTreeView.Nodes.Add(treeNode);
                supplierTreeView.SelectedNode = supplierTreeView.TopNode;
                if (ds != null)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        treeNode = new TreeNode();
                        treeNode.Text = dr["provider_nickName"].ToString();
                        treeNode.Name = dr["ID"].ToString();
                        treeNode.ImageIndex = 1;
                        treeNode.SelectedImageIndex = 1;
                        supplierTreeView.SelectedNode = supplierTreeView.TopNode;
                        supplierTreeView.SelectedNode.Nodes.Add(treeNode);
                    }
                    supplierTreeView.SelectedNode = supplierTreeView.TopNode; //最顶端节点选中
                    supplierTreeView.ExpandAll();
                }
            }
            catch (Exception ex)
            {
                log.Error("绑定数据源失败", ex);
            }
            finally
            {
                asflag = true;
            }
        }

        private void supplierTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (asflag)
            {
                //MessageBox.Show(supplierTreeView.SelectedNode.Text, "提示", MessageBoxButtons.OK);
                string name = supplierTreeView.SelectedNode.Text;
                string id = supplierTreeView.SelectedNode.Name;
                this.goodsChoose.SetSuppliername(name, id);
            }
        }

        private void supplierTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (asflag)
            {
                string name = supplierTreeView.SelectedNode.Text;
                string id = supplierTreeView.SelectedNode.Name;
                this.goodsChoose.SetSuppliername(name, id);
            }
        }
    }
}