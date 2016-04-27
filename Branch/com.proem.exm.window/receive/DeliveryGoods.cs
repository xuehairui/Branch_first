using Branch.com.proem.exm.window.main;
using Branch.com.proem.exm.window.receive;
using Branch.com.proem.exm.domain;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Branch.com.proem.exm.util;
using Branch.com.proem.exm.service.branch;
using log4net;
using System.Text.RegularExpressions;
using Branch.com.proem.exm.service.main;
using Branch.com.proem.exm.window.util;
using Branch.com.proem.exm.service.master;
using Branch.com.proem.exm.service;
using MySql.Data.MySqlClient;
using Branch.com.proem.exm.dao.branch;

namespace Branch.com.proem.exm.window.receive
{
    /// <summary>
    /// 收货管理
    /// </summary>
    public partial class DeliveryGoods : Form
    {
        /// <summary>
        /// 日志log
        /// </summary>
        private ILog log = LogManager.GetLogger(typeof(DeliveryGoods));
        ItemInput itemsInput = null;
        ///// <summary>
        ///// 业务员
        ///// </summary>
        //private ZcUserInfo zcUserInfo;
        ///// <summary>
        ///// 订单号
        ///// </summary>
        //private string orderNumber;
        ///// <summary>
        ///// 原始订单号
        ///// </summary>
        //private string oldOrderNumber;
        ///// <summary>
        ///// 调出分店
        ///// </summary>
        //private ZcBranchTotal branch;
        /// <summary>
        /// 选取单元格的行
        /// </summary>
        private int row = -1;
        /// <summary>
        /// 选取单元格的列
        /// </summary>
        private int column = -1;

        /// <summary>
        /// 收货标识
        /// </summary>
        private bool harvestFlag = true;

        public delegate void child_close();
        public event child_close delivery;

        public DeliveryGoods()
        {
            InitializeComponent();
        }

        private BranchMain branchMain;

        public DeliveryGoods(BranchMain branchMain)
        {
            InitializeComponent();
            this.branchMain = branchMain;
        }

        ///// <summary>
        ///// 主界面
        ///// </summary>
        //private BranchMain branchMain;

        ///// <summary>
        ///// 重载的构造函数
        ///// </summary>
        ///// <param name="branchMain"></param>
        //public DeliveryGoods(BranchMain branchMain)
        //{
        //    InitializeComponent();
        //    this.branchMain = branchMain;
        //}

        private void DeliveryGoods_Load(object sender, EventArgs e)
        {
            ////初始化当前分店
            //inNameTextBox.Text = LoginUserInfo.branchName;
            ////以下为暂时的默认数据
            //salesmanNameTextBox.Text = LoginUserInfo.name;
            //初始化当前分店
            inNameLabel.Text = LoginUserInfo.branchName;
            //以下为暂时的默认数据
            salesmanNameLabel.Text = LoginUserInfo.name;

            //itemsInput = new ItemInput(this, log);
            //itemsInput.TopLevel = false;
            //this.itemInputPanel.Controls.Add(itemsInput);
            //itemsInput.Show();

            DownloadIdentifyService service = new DownloadIdentifyService();
            ///判断亭点是否收获
            if (service.IsHarvest())
            {
                harvestFlag = false;
                ///已经已收货
                loadHarvestGoods();
                loadTotal();
            }
            else    ///未收货
            {
                loadGoods();
                initDifference();
            }



            Times times = new Times();
            times.TopLevel = false;
            this.timePanel.Controls.Add(times);
            times.Show();
            ///初始化焦点事件  将焦点放到扫描框
            numberTextBox.Focus();
        }

        /// <summary>
        /// 加载
        /// </summary>
        private void loadTotal()
        {
            int totalSum = 0;
            float totalAmount = 0;
            try
            {
                for (int i = 0; i < itemDataGridView.RowCount; i++)
                {
                    totalSum += Convert.ToInt32((itemDataGridView[8, i].Value == null || itemDataGridView[8, i].Value.ToString().Trim() == "") ? "0" : itemDataGridView[8, i].Value.ToString());
                    totalAmount += float.Parse((itemDataGridView[10, i].Value == null || itemDataGridView[10, i].Value.ToString().Trim() == "") ? "0" : itemDataGridView[10, i].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                log.Error("类型转换异常", ex);
            }
            this.totalSum.Text = totalSum.ToString();
            this.totalAmount.Text = totalAmount.ToString();
        }

        /// <summary>
        /// 初始化显示差异difference
        /// </summary>
        private void initDifference()
        {
            for (int i = 0; i < itemDataGridView.RowCount; i++)
            {
                int orderNums = Convert.ToInt32(itemDataGridView[4, i].Value);
                itemDataGridView[5, i].Value = orderNums;
                itemDataGridView[6, i].Value = 0;
            }
        }

        /// <summary>
        /// 加载收货过的商品信息列表
        /// </summary>
        private void loadHarvestGoods()
        {
            DateTime first = DateTime.Today;
            DateTime last = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 23:59:59"));
            MysqlDBHelper dbHelper = new MysqlDBHelper();
            MySqlConnection conn = null;
            string sql = "select serialNumber , name, classify, goods_unit, goods_specifications, goods_price as g_price, nums, actual_quantity, order_amount, receive_amount,sortenum  from daily_receive_goods where createTime between @first and @last ";
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = dbHelper.GetConnection();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@first", first);
                cmd.Parameters.AddWithValue("@last", last);
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds, "daily_receive_goods");
                receiveAmount.DataPropertyName = "receive_amount";
                actualQuantity.DataPropertyName = "actual_quantity";
                orderAmount.DataPropertyName = "order_amount";
                classify.DataPropertyName = "classify";
                actualQuantity.ReadOnly = true;

                itemDataGridView.DataSource = ds;
                itemDataGridView.DataMember = "daily_receive_goods";
                itemDataGridView.CurrentCell = null;//不默认选中
            }
            catch (Exception ex)
            {
                log.Error("获取当天收货后的商品信息失败", ex);
            }
            finally
            {
                cmd.Dispose();
                dbHelper.CloseConnection(conn);
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            //BranchMain branchMain = new BranchMain();
            //branchMain.Show();
            this.Close();
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            Scan scan = new Scan(this);
            scan.ShowDialog();
            //扫描
        }

        private void deliveryButton_Click(object sender, EventArgs e)
        {
            if (!harvestFlag)
            {
                MessageBox.Show("当前货物已确认收货，无法重复确认收货!", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            bool deli = false;
            bool prompt = false;
            if (itemDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("当前并无需要提交的收货单！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < itemDataGridView.Rows.Count; i++)
            {
                if (Convert.ToInt32(itemDataGridView[5, i].Value) == 0)
                {
                    deli = true;
                }

                if (Convert.ToInt32(itemDataGridView[6, i].Value) != 0)
                {
                    prompt = true;
                }
            }
            if (deli || prompt)
            {
                string sInput = "";
                DGPrompt dGPrompt = new DGPrompt();
                if (dGPrompt.ShowDialog() == DialogResult.OK)
                {//
                    sInput = dGPrompt.inputMess;
                    //MessageBox.Show(sInput);
                }
                if (!sInput.Equals("y"))
                {
                    return;
                }
            }

            List<DailyReceiveGoods> list = new List<DailyReceiveGoods>();
            //确定收货
            for (int i = 0; i < itemDataGridView.RowCount; i++)
            {
                DailyReceiveGoods obj = new DailyReceiveGoods();
                DataGridViewRow dc = itemDataGridView.Rows[i];
                obj.Id = Guid.NewGuid().ToString().Replace("-", "");
                obj.CreateTime = DateTime.Now;
                obj.UpdateTime = DateTime.Now;
                obj.SerialNumber = dc.Cells[0].Value.ToString();
                obj.Name = dc.Cells[1].Value.ToString();
                obj.Classify = dc.Cells[11].Value.ToString();
                obj.GoodsUnit = dc.Cells[10].Value.ToString();
                obj.GoodsSpecifications = dc.Cells[9].Value.ToString();
                obj.GooodsPrice = dc.Cells[2].Value.ToString();
                obj.Nums = dc.Cells[3].Value.ToString();
                obj.ActualQuantity = dc.Cells[5].Value == null ? "" : dc.Cells[5].Value.ToString();
                obj.OrderAmount = dc.Cells[7].Value.ToString();
                obj.ReceiveAmount = dc.Cells[8].Value == null ? "" : dc.Cells[8].Value.ToString();
                obj.sortenum = dc.Cells[4].Value.ToString();
                obj.Salesman = LoginUserInfo.id;
                obj.BranchId = LoginUserInfo.branchId;
                obj.receiveDate = DateTime.Now;
                list.Add(obj);
            }
            BranchDailyReceiveGoodsService branchservice = new BranchDailyReceiveGoodsService();
            //存入本地数据库
            branchservice.AddDailyReceiveGoods(list);

            //将全部订单改为待提货  
            BranchZcOrderTransitService branchZcOrderTransitService = new BranchZcOrderTransitService();
            branchZcOrderTransitService.UpdateOrderStatus(Constant.ORDER_STATUS_RECEIPT);
            //将亭点收获标识更新为true
            DownloadIdentifyService downloadService = new DownloadIdentifyService();
            downloadService.UpdateHarvestFlag(Constant.HARVEST_YES);

            List<ZcOrderTransit> tranlist = branchZcOrderTransitService.FindAll();
            ///上传数据处理
            if (PingTask.IsConnected)
            {
                //上传每日收货数据
                DailyReceiveGoodsService service = new DailyReceiveGoodsService();
                service.AddDailyReceiveGoods(list);

                ZcOrderTransitService zcOderTransitService = new ZcOrderTransitService();
                zcOderTransitService.UpdateStatus(tranlist);
            }
            else
            {
                List<UploadInfo> uploadList = new List<UploadInfo>();
                foreach (DailyReceiveGoods obj in list)
                {
                    UploadInfo uploadInfo = new UploadInfo();
                    uploadInfo.Id = obj.Id;
                    uploadInfo.CreateTime = DateTime.Now;
                    uploadInfo.UpdateTime = DateTime.Now;
                    uploadInfo.Type = Constant.DAILY_RECEIVE_GOODS;
                    uploadList.Add(uploadInfo);
                }
                foreach (ZcOrderTransit obj in tranlist)
                {
                    UploadInfo uploadInfo = new UploadInfo();
                    uploadInfo.Id = obj.Id;
                    uploadInfo.CreateTime = DateTime.Now;
                    uploadInfo.UpdateTime = DateTime.Now;
                    uploadInfo.Type = Constant.ZC_ORDER_TRANSIT_UPDATE;
                    uploadList.Add(uploadInfo);
                }

                UploadDao uploadDao = new UploadDao();
                uploadDao.AddUploadInfo(uploadList);
            }


            MessageBox.Show("收货成功！");
            this.branchMain.Show();
            this.Close();
        }

        /// <summary>
        /// 加载商品
        /// </summary>
        private void loadGoods()
        {
            string sql = "select sum(nums) as nums,name,sum(g_price*nums) as totalprice,classify_name,goods_unit,delFlag,goods_specifications,serialNumber,g_price as actualnums,goodsfile_id,goods_class_id,g_price, sortenum, address_id  from "
                + " (select a.goods_state, a.nums, b.goods_name as name ,b.goods_specifications,b.goods_unit,a.g_price,b.id as goodsfile_id,b.delFlag,b.serialNumber,c.classify_name,b.goods_class_id,b.goods_supplier_id ,e.sortenum, e.address as address_id  "
                + " from zc_order_transit_item a left join zc_goods_master b on a.goodsfile_id = b.id left join zc_classify_info c on b.goods_class_id = c.id  left join (select sum(sortenum) as sortenum, address, goods_id from zc_order_sorte group by goods_id) e on a.GOODSFILE_ID = e.goods_id  "
                + " ) as d where address_id ='" + LoginUserInfo.street + "' group by name,delFlag,classify_name,goods_unit,goods_specifications,serialNumber,g_price,goodsfile_id,goods_class_id ";
            try
            {
                MysqlDBHelper dbHelper = new MysqlDBHelper();
                DataSet ds = dbHelper.GetDataSet(sql, "zc_order_transit_item");
                itemDataGridView.AutoGenerateColumns = false;
                itemDataGridView.DataSource = ds;
                itemDataGridView.DataMember = "zc_order_transit_item";
                itemDataGridView.CurrentCell = null;//不默认选中
            }
            catch (Exception ex)
            {
                log.Error("加载订单中商品时发生错误", ex);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="num"></param>
        public void itemInput(string num)
        {
            this.itemDataGridView[4, row].Value = num;
            ////this.itemDataGridView[4, row].Value = num;
            ////this.itemDataGridView.CurrentCell = itemDataGridView[4, row]; //单元格设置可编辑状态-
            ////itemDataGridView.BeginEdit(true);
            ////itemsInput.sureflag = false;

            //if (column == 4 && row != -1)
            //{
            //    //itemDataGridView[column, row].Value = num;
            //}
            //else
            //{
            //    //string bar = numberTextBox.Text;
            //    //QueryGoods query = new QueryGoods();
            //    //int item = query.queryExistGood(bar, "", this, log);//查询后获得
            //    //if (item == 0)
            //    //{
            //    //    MessageBox.Show("商品不存在,请重新输入", "提示", MessageBoxButtons.OK);
            //    //}
            //    //else if (item == 1)
            //    //{
            //    //    numberTextBox.Text = "";
            //    //}
            //    //else if (item > 1 && item < 50)
            //    //{
            //    //    DGSGood dGSGood = new DGSGood(this, bar, "");
            //    //    dGSGood.ShowDialog();
            //    //    numberTextBox.Text = "";
            //    //}
            //    //else if (item >= 50)
            //    //{
            //    //    MessageBox.Show("匹配的商品记录数大于[50]条，请输入更多内容以减少匹配范围", "提示", MessageBoxButtons.OK);
            //    //}
            //}
            column = -1;
            row = -1;
        }

        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="num">商品份数</param>
        public void AddGoods(ZcGoodsMaster obj, string num)
        {
            DataSet ds = (DataSet)itemDataGridView.DataSource;

            bool flag = false;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i][0].ToString().Equals(obj.SerialNumber))
                {
                    string nums = itemDataGridView[4, i].Value.ToString();
                    itemDataGridView[4, i].Value = Convert.ToInt32(nums) + Convert.ToInt32(num);
                    return;
                }
                else
                {

                }
                if (itemDataGridView[0, i].Value.ToString().Equals(obj.SerialNumber))//
                {//
                    row = i;//
                    column = 5;//
                    //itemsInput.sureflag = true;//
                    flag = true;//
                    this.itemDataGridView.CurrentCell = itemDataGridView[4, row]; //单元格设置可编辑状态-
                    itemDataGridView.BeginEdit(true);
                }//
            }
            if (!flag)
            {
                MessageBox.Show("今天收货订单中没有此商品，请与总部联系");
                return;
            }
            //自动计算
            Calculate();
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
            //Calculate();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="good_id">货号</param>
        /// <param name="good_num">份数</param>
        /// <param name="good_wei">重量</param>
        public void setbar(string good_id, string good_num, string good_wei)
        {

        }

        private void itemDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            row = itemDataGridView.CurrentCell.RowIndex;
            column = itemDataGridView.CurrentCell.ColumnIndex;
            //MessageBox.Show(column + "/" + row);
            //choose = true;
        }

        private void itemCountPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// 合计金额，并计算份数差异
        /// </summary>
        private void Calculate()
        {
            int totalSum = 0;
            float totalAmount = 0;
            try
            {
                for (int i = 0; i < itemDataGridView.RowCount; i++)
                {
                    totalSum += Convert.ToInt32((itemDataGridView[5, i].Value == null || itemDataGridView[5, i].Value.ToString().Trim() == "") ? "0" : itemDataGridView[5, i].Value.ToString());
                    totalAmount += float.Parse((itemDataGridView[8, i].Value == null || itemDataGridView[8, i].Value.ToString().Trim() == "") ? "0" : itemDataGridView[8, i].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                log.Error("类型转换异常", ex);
            }
            this.totalSum.Text = totalSum.ToString();
            this.totalAmount.Text = totalAmount.ToString();
        }

        private void DeliveryGoods_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && deliveryButton.Enabled == true)
            {
                deliveryButton_Click(this, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                returnButton_Click(this, EventArgs.Empty);
            }
            if (e.Control && e.KeyCode == Keys.T)
            {
                if (itemsInput.Focused)
                {
                    this.Focus();
                }
                else
                {
                    itemsInput.Focus();

                }
            }
            if (numberTextBox.Focused && e.KeyCode == Keys.Enter)
            {
                equalButton_Click(this, EventArgs.Empty);
            }
        }

        private void itemDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //行号
            using (SolidBrush b = new SolidBrush(this.itemDataGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(Convert.ToString(e.RowIndex + 1),
                e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 5, e.RowBounds.Location.Y + 4);
            }
        }

        /// <summary>
        /// 检测输入是否为数字的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (itemDataGridView.CurrentCell.ColumnIndex == 5)
            {
                e.Control.KeyPress += new KeyPressEventHandler(checkInput);
            }
        }

        /// <summary>
        /// 检测输入输入是否是数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkInput(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl s = sender as DataGridViewTextBoxEditingControl;
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        /// <summary>
        /// 数据量变化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 5)
            {
                try
                {
                    int num = itemDataGridView.Rows[e.RowIndex].Cells[5].Value == null ? 0 : Convert.ToInt32(itemDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
                    Double price = Convert.ToDouble(itemDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    int difference = Convert.ToInt32(itemDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString()) - num;
                    itemDataGridView.Rows[e.RowIndex].Cells[6].Value = difference;
                    if (difference != 0)
                    {
                        itemDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(201, 67, 65);// Color.Red;
                    }
                    else
                    {
                        itemDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(51, 153, 255);// Color.Blue;//51,153,255
                    }
                    itemDataGridView.Rows[e.RowIndex].Cells[8].Value = Math.Round(num * price, 2).ToString("0.00");
                    Calculate();
                }
                catch (Exception ex)
                {
                    log.Error("自动计算金额错误", ex);
                }
            }
            //if (e.RowIndex != -1 && e.ColumnIndex == 5)
            //{//
            //    int cot = Convert.ToInt32(itemDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
            //    if (cot != 0)
            //    {
            //        this.itemDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            //    }
            //    else
            //    {
            //        this.itemDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Blue;
            //    }
            //}

            //if (e.RowIndex != -1 && e.ColumnIndex == 7)
            //{
            //    string a = itemDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //    if (! Regex.IsMatch(itemDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "^([0-9]{1,})$"))
            //    {
            //        MessageBox.Show("只能输入整数");
            //        itemDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
            //        return;
            //    }
            //    
            //}
        }

        private void itemDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //choose = false;
            //itemsInput.sureflag = true;
        }

        /// <summary>
        /// 显示数据格式化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (itemDataGridView.Columns[e.ColumnIndex].Name == "goods_specifications")
            {
                if (e.Value == null || e.Value.ToString() == "")
                {
                    return;
                }
                string str = e.Value.ToString();
                e.Value = str.Replace("商品规格：", "");
            }
            if (itemDataGridView.Columns[e.ColumnIndex].Name == "goods_price")
            {
                if (e.Value == null || e.Value.ToString() == "")
                {
                    return;
                }
                double price = Convert.ToDouble(e.Value.ToString());
                e.Value = price.ToString("0.00");
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "9";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "0";
        }

        private void dashButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += "-";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text += ".";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text.Length > 0)
            {
                numberTextBox.Text = numberTextBox.Text.Remove(numberTextBox.Text.Length - 1, 1);
            }
        }

        private void clearBotton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if(!harvestFlag)
            {
                ///今天已经亭长收货,无法继续
                MessageBox.Show("亭长今天已经收货，无法进行扫码!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberTextBox.Text = "";
                return;
            }
            string bar = numberTextBox.Text;
            numberTextBox.Text = "";
            string good_id = "";
            string good_wei = "";
            if (string.IsNullOrEmpty(bar) || bar.Length != 13)
            {
                MessageBox.Show("扫码的条码不正确,请重新扫码!", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (bar.Length == 13 && bar.StartsWith("28"))
            {
                good_id = bar.Substring(2, 5);
                good_wei = bar.Substring(7, 5);
            }
            else
            {
                good_id = bar;
            }
            DataSet ds = (DataSet)itemDataGridView.DataSource;
            bool flag = false;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (itemDataGridView[0, i].Value.ToString().Equals(good_id))
                {
                    row = i;//
                    column = 5;//
                    flag = true;
                    //itemDataGridView[5, i].Value = good_num;
                    this.itemDataGridView.CurrentCell = itemDataGridView[5, row]; //单元格设置可编辑状态-
                    itemDataGridView.BeginEdit(true);
                }
            }

            if (!flag)
            {
                MessageBox.Show("客户订单中没有此商品，请与客户确认", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }

        private void itemDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            numberTextBox.Focus();
        }

        private void DeliveryGoods_FormClosed(object sender, FormClosedEventArgs e)
        {
            delivery();
        }

        /// <summary>
        /// 限制条码框输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void itemDataGridView_Paint(object sender, PaintEventArgs e)
        {
            //itemDataGridView.CurrentCell = null;
            itemDataGridView.ClearSelection();
        }

    }
}