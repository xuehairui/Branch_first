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
    public partial class GCType : Form
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(GCType));
        private GoodsChoose goodsChoose;
        private bool asflag = false;
        int treeNodeLevel = 0;

        public GCType()
        {
            InitializeComponent();
        }

        public GCType(GoodsChoose obj)
        {
            InitializeComponent();
            this.goodsChoose = obj;
        }

        private void GCType_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from zc_classify_info a where classify_type=1 order by a.classify_level asc;";
                MysqlDBHelper dbHelper = new MysqlDBHelper();
                DataSet ds = dbHelper.GetDataSet(sql, "zc_classify_info"); ;
                //MessageBox.Show("1", "提示", MessageBoxButtons.OK);
                TreeNode treeNode = new TreeNode();
                treeNode.Text = "商品类别";
                treeNode.Name = "0";
                treeNode.Tag = "0";
                treeNode.ImageIndex = 0;
                treeNode.SelectedImageIndex = 0;
                typeTreeView.Nodes.Add(treeNode);
                typeTreeView.SelectedNode = typeTreeView.TopNode;
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
                            typeTreeView.SelectedNode = typeTreeView.TopNode;
                        }
                        else
                        {
                            //其他节点
                            if (typeTreeView.SelectedNode.Name != dr["parentId"].ToString())
                            {
                                TreeNode[] treeNode_temp = typeTreeView.Nodes.Find(dr["parentId"].ToString(), true);
                                if (treeNode_temp.Length > 0)
                                {
                                    typeTreeView.SelectedNode = treeNode_temp[0];
                                }
                            }
                        }
                        typeTreeView.SelectedNode.Nodes.Add(treeNode);
                    }
                    typeTreeView.SelectedNode = typeTreeView.TopNode; //最顶端节点选中
                    typeTreeView.TopNode = typeTreeView.Nodes[0];
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

        private void typeTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeNodeLevel = typeTreeView.SelectedNode.Level;
            if (asflag)
            {
                if (treeNodeLevel < 2)
                {
                    return;
                }
                //MessageBox.Show(typeTreeView.SelectedNode.Level.ToString());
                //MessageBox.Show(typeTreeView.SelectedNode.Text, "提示", MessageBoxButtons.OK);
                string name = typeTreeView.SelectedNode.Text;
                string id = typeTreeView.SelectedNode.Name;
                this.goodsChoose.SetTypename(name, id);
            }
        }

        bool nmcflag = true;

        private void typeTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (asflag)
            {
                if (nmcflag)
                {
                    nmcflag = false;
                    return;
                }
                if (treeNodeLevel < 2)
                {
                    return;
                }
                //MessageBox.Show(typeTreeView.SelectedNode.Text, "提示", MessageBoxButtons.OK);
                string name = typeTreeView.SelectedNode.Text;
                string id = typeTreeView.SelectedNode.Name;
                this.goodsChoose.SetTypename(name, id);
            }
        }
    }
}