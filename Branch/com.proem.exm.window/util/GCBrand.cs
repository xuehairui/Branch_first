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
    /// 品牌选择
    /// </summary>
    public partial class GCBrand : Form
    {

        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(GCBrand));

        /// <summary>
        /// 添加商品页面
        /// </summary>
        private GoodsChoose goodsChoose;

        private bool asflag = false;

        public GCBrand()
        {
            InitializeComponent();
        }

        public GCBrand(GoodsChoose obj)
        {
            InitializeComponent();
            this.goodsChoose = obj;
        }

        private void GCBrand_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from zc_classify_info a where classify_type=2 order by a.classify_level asc;";
                MysqlDBHelper dbHelper = new MysqlDBHelper();
                DataSet ds = dbHelper.GetDataSet(sql, "zc_classify_info");
                //MessageBox.Show("1", "提示", MessageBoxButtons.OK);
                TreeNode treeNode = new TreeNode();
                treeNode.Text = "商品品牌";
                treeNode.Name = "0";
                treeNode.Tag = "0";
                treeNode.ImageIndex = 0;
                treeNode.SelectedImageIndex = 0;
                brandTreeView.Nodes.Add(treeNode);
                brandTreeView.SelectedNode = brandTreeView.TopNode;
                if (ds != null)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        treeNode = new TreeNode();
                        treeNode.Text = dr["classify_name"].ToString();
                        treeNode.Name = dr["ID"].ToString();
                        treeNode.Tag = dr["parentId"].ToString();
                        treeNode.ImageIndex = 1;
                        treeNode.SelectedImageIndex = 1;
                        //判断是否为主节点
                        //MessageBox.Show(dr["classify_name"].ToString()+"/"+dr["ID"].ToString() + "/" + dr["parentId"].ToString(), "提示", MessageBoxButtons.OK);
                        if (dr["ID"].ToString() == dr["typeId"].ToString())
                        {
                            //主节点
                            brandTreeView.SelectedNode = brandTreeView.TopNode;
                        }
                        else
                        {
                            //其他节点
                            if (brandTreeView.SelectedNode.Name != dr["parentId"].ToString())
                            {
                                TreeNode[] treeNode_temp = brandTreeView.Nodes.Find(dr["parentId"].ToString(), true);
                                if (treeNode_temp.Length > 0)
                                {
                                    brandTreeView.SelectedNode = treeNode_temp[0];
                                }
                            }
                        }
                        brandTreeView.SelectedNode.Nodes.Add(treeNode);
                    }
                    brandTreeView.SelectedNode = brandTreeView.TopNode; //最顶端节点选中
                    brandTreeView.ExpandAll();
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

        private void brandTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (asflag)
            {
                //MessageBox.Show(brandTreeView.SelectedNode.Text, "提示", MessageBoxButtons.OK);
                string name = brandTreeView.SelectedNode.Text;
                string id = brandTreeView.SelectedNode.Name;
                this.goodsChoose.SetBrandname(name, id);
            }
        }

        private void brandTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (asflag)
            {
                string name = brandTreeView.SelectedNode.Text;
                string id = brandTreeView.SelectedNode.Name;
                this.goodsChoose.SetBrandname(name, id);
            }
        }
    }
}