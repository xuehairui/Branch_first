using Branch.com.proem.exm.window.main;
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
using MySql.Data.MySqlClient;
using Branch.com.proem.exm.window.util;
using log4net;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.service.main;
using Branch.com.proem.exm.service;
using Branch.com.proem.exm.service.master;
using Branch.com.proem.exm.service.branch;
using Branch.com.proem.exm.window.order.controller;
using System.Drawing.Printing;
using Branch.com.proem.exm.dao.branch;

namespace Branch.com.proem.exm.window.order
{
    /// <summary>
    /// 客户提货
    /// </summary>
    public partial class CustomerDelivery : Form
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(CustomerDelivery));

        /// <summary>
        /// 当前页面的工作模式
        /// 1、结算
        /// 2、退款
        /// 3、零售
        /// 定义在constant常量类中
        /// </summary>
        private string WorkMode;

        /// <summary>
        /// 待打印的商品列表
        /// </summary>
        private List<GoodsPrint> printObjectlist = new List<GoodsPrint>();


        //ItemInput itemsInput = null;

        /// <summary>
        /// 选取单元格的行
        /// </summary>
        private int row = -1;
        /// <summary>
        /// 选取单元格的列
        /// </summary>
        private int column = -1;
        /// <summary>
        /// 数量合计
        /// </summary>
        private int totalSumValue = 0;
        /// <summary>
        /// 金额合计
        /// </summary>
        private float totalAmountValue = 0;
        /// <summary>
        /// 退款数量合计
        /// </summary>
        private int returnSum = 0;
        /// <summary>
        /// 退款金额合计
        /// </summary>
        private float returnAmount = 0;

        /// <summary>
        /// 实际付款总金额
        /// </summary>
        public string actualTotalMoney;

        ///// <summary>
        ///// 输入的关键词
        ///// </summary>
        //private string keyStr = null;
        /// <summary>
        /// 订单号
        /// </summary>
        private string order_Num = null;
        /// <summary>
        /// 字符串追加
        /// </summary>
        string conditon = "where 1=1 ";

        public delegate void child_close();
        public event child_close customer;

        public CustomerDelivery()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerDelivery_Load(object sender, EventArgs e)
        {
            //inNameTextBox.Text = LoginUserInfo.branchName;
            inNameLabel.Text = LoginUserInfo.branchName;
            //salesmanNameTextBox.Text = LoginUserInfo.name;
            salesmanNameLabel.Text = LoginUserInfo.name;
            ///默认提货
            pickUp_Click(this, e);


            //itemsInput = new ItemInput(this, log);
            //itemsInput.TopLevel = false;
            //this.itemInputPanel.Controls.Add(itemsInput);
            //itemsInput.Show();


            Times times = new Times();
            times.TopLevel = false;
            this.timePanel.Controls.Add(times);
            times.Show();
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

        ///// <summary>
        ///// 客户提货完成，保存事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void saveButton_Click(object sender, EventArgs e)
        //{
        //    string cardId = this.queryTextBox.Text.ToString().Trim();
        //    string name = this.cardNameTextBox.Text.ToString().Trim();
        //    string phone = this.phoneTextBox.Text.ToString().Trim();
        //    if (cardId == "" && phone == "" && name == "")
        //    {
        //        MessageBox.Show("没有检索到用户");
        //        return;
        //    }
        //    if(itemDataGridView.DataSource == null)
        //    {
        //        MessageBox.Show("该用户今天没有任何订单需要收取");
        //    }
        //    string coniditon = " where 1=1 ";
        //    if (cardId != "")
        //    {
        //        coniditon += " and b.associator_cardnumber = '"+cardId+"' ";
        //    }
        //    if (name != "")
        //    {
        //        coniditon += " and a.consignee = '"+name+"' ";
        //    }
        //    if (phone != "")
        //    {
        //        coniditon += " and a.cansignphone ='"+phone+"' ";
        //    }
        //    string sql = "select a.id from zc_order_transit a LEFT JOIN zc_associator_info b on a.member_id = b.id "+coniditon;
        //    CustomerDeliveryService customerDeliveryService = new CustomerDeliveryService();
        //    List<string> list = customerDeliveryService.FindOrderIdBySql(sql);
        //    //将用户提货完成后的订单和订单详情 挪动到history表中
        //    customerDeliveryService.UpdateStatusAndMoveOrder(list);

        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        public void itemInput(string num)
        {
            this.itemDataGridView[4, row].Value = num;
            ////this.itemDataGridView.CurrentCell = itemDataGridView[4, row]; //单元格设置可编辑状态-
            ////itemDataGridView.BeginEdit(true);

            ////itemsInput.sureflag = false;
            //if (column == 7 && row != -1)
            //{
            //    itemDataGridView[column, row].Value = num;
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
        /// 查询数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void queryButton_Click(object sender, EventArgs e)
        {
            ///当前工作模式为提货状态
            if (WorkMode == Constant.PICK_UP_GOODS)
            {
                ///获取查询条件
                string searchString = queryTextBox.Text.ToString().Trim();
                CustomerDeliveryController controller = new CustomerDeliveryController();
                int orderCounts = controller.GetOrderCounts(searchString);
                if (orderCounts == 0)
                {
                    MessageBox.Show("暂无待客户提货的订单!");
                    return;
                }
                else if (orderCounts == 1)
                {
                    controller.GetOrderInfo(searchString, this);
                    ///直接根据orderNumber获取此订单下的商品展示
                    DataSet ds = controller.GetGoodDataSetById(id_.Text.ToString());
                    itemDataGridView.AutoGenerateColumns = false;
                    itemDataGridView.DataSource = ds;
                    itemDataGridView.DataMember = "zc_order_transit";
                    itemDataGridView.CurrentCell = null;//不默认选中
                    ///初始化显示份数差异
                    initDifference();
                }
                else
                {
                    CDQueryList cdQueryList = new CDQueryList(this, searchString, WorkMode);
                    cdQueryList.ShowDialog();
                }
                ///焦点移动到扫码框内
                numberTextBox.Focus();
            }

            ///当前工作模式为退款状态时，在状态为已完成的单据当日单据内查询
            if (WorkMode == Constant.REFUND)
            {//GetReturnOrderCounts
                ///获取查询条件
                string searchString = queryTextBox.Text.ToString().Trim();
                CustomerDeliveryController controller = new CustomerDeliveryController();
                int orderCounts = controller.GetReturnOrderCounts(searchString);
                if (orderCounts == 0)
                {
                    MessageBox.Show("该关键词下暂无已结算的订单!");
                    return;
                }
                else if (orderCounts == 1)
                {
                    controller.GetReturnOrderInfo(searchString, this);
                    ///直接根据orderNumber获取此订单下的商品展示
                    DataSet ds = controller.GetReturnGoodDataSetById(id_.Text.ToString());
                    listDataGridView.AutoGenerateColumns = false;
                    listDataGridView.DataSource = ds;
                    listDataGridView.DataMember = "zc_order_history";
                    listDataGridView.CurrentCell = null;//不默认选中
                }
                else
                {
                    CDQueryList cdQueryList = new CDQueryList(this, searchString, WorkMode);
                    cdQueryList.ShowDialog();
                }
                ///焦点移动到扫码框内
                numberTextBox.Focus();
            }
        }

        private int queryNum()
        {
            int con = 0;
            MysqlDBHelper dbHelper = new MysqlDBHelper();
            MySqlConnection conn = dbHelper.GetConnection();
            string sql = null;
            string num = null;
            string amount = null;
            string name = null;
            string phone = null;
            string card = null;
            try
            {
                //sql = "select COUNT(1) "
                sql = "select e.ORDERNUM ,e.ORDERAMOUNT,e.CONSIGNEE,e.CANSIGNPHONE,f.ASSOCIATOR_CARDNUMBER "
                    + " From zc_order_transit e "
                    + " LEFT JOIN zc_associator_info f on e.member_id = f.id "
                + conditon;
                //MessageBox.Show("sql:"+sql);

                MySqlDataReader reader = dbHelper.GetReader(sql, conn);
                while (reader.Read())
                {
                    con += 1;
                    if (con == 1)
                    {
                        num = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                        amount = reader.IsDBNull(1) ? string.Empty : reader.GetString(0);
                        name = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                        phone = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                        card = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                        //MessageBox.Show(num);
                    }
                    //alreadyTotalAmount += float.Parse(reader.IsDBNull(1) ? string.Empty : reader.GetString(1));
                }
                if (con == 1)
                {
                    order_Num = num;
                    setinform(num, amount, name, phone, card);
                }
            }
            catch (Exception ex)
            {
                log.Error("获取订单数量信息失败", ex);
            }
            finally
            {
                dbHelper.CloseConnection(conn);
            }
            return con;
        }

        private void queryOrderList()
        {
            ///当前工作模式为提货状态
            if (WorkMode == Constant.PICK_UP_GOODS)
            {
                string sql = "select sum(nums) as nums,name,sum(g_price*nums) as totalprice,classify_name,goods_unit,delFlag,goods_specifications,serialNumber,g_price as actualnums,goodsfile_id,goods_class_id,g_price,orderNum from "
                    + " (select a.goods_state,a.name,a.nums,b.goods_specifications,b.goods_unit,a.g_price,b.id as goodsfile_id,b.delFlag,b.serialNumber,c.classify_name,b.goods_class_id,b.goods_supplier_id,e.orderNum "
                    + "from zc_order_transit e  "
                    + "LEFT JOIN zc_associator_info f on e.member_id = f.id "
                    + " LEFT JOIN zc_order_transit_item a on e.id = a.order_id "
                    + " left join zc_goods_master b on a.goodsfile_id = b.id "
                    + " left join zc_classify_info c on b.goods_class_id = c.id "
                    + " where e.orderNum='" + order_Num + "'"
                    + " )as d group by name,delFlag,classify_name,goods_unit,goods_specifications,serialNumber,g_price,goodsfile_id,goods_class_id ";

                MysqlDBHelper dbHelper = new MysqlDBHelper();
                DataSet ds = dbHelper.GetDataSet(sql, "zc_order_transit");
                itemDataGridView.AutoGenerateColumns = false;
                itemDataGridView.DataSource = ds;
                itemDataGridView.DataMember = "zc_order_transit";
                itemDataGridView.CurrentCell = null;//不默认选中
                initDifference();
            }
            ///当前工作模式为退款状态
            if (WorkMode == Constant.REFUND)
            {
                string sql = "select sum(nums) as nums,name,sum(g_price*nums) as totalprice,classify_name,goods_unit,delFlag,goods_specifications,serialNumber,g_price as actualnums,goodsfile_id,goods_class_id,g_price,orderNum ,actual_nums,actual_money from "
                    + " (select a.goods_state,a.name,a.nums,b.goods_specifications,b.goods_unit,a.g_price,b.id as goodsfile_id,b.delFlag,b.serialNumber,c.classify_name,b.goods_class_id,b.goods_supplier_id,e.orderNum,a.actual_nums,a.actual_money "
                    + "from zc_order_history e  "
                    + "LEFT JOIN zc_associator_info f on e.member_id = f.id "
                    + " LEFT JOIN zc_order_history_item a on e.id = a.order_id "
                    + " left join zc_goods_master b on a.goodsfile_id = b.id "
                    + " left join zc_classify_info c on b.goods_class_id = c.id "
                    + " where e.orderNum='" + order_Num + "' and e.orderstatus not in ('" + Constant.ORDER_STATUS_ALL_REFUSE + "','" + Constant.ORDER_STATUS_ALL_REFUND + "','" + Constant.ORDER_STATUS_PART_REFUND + "')"
                    + " )as d group by name,delFlag,classify_name,goods_unit,goods_specifications,serialNumber,g_price,goodsfile_id,goods_class_id ";

                MysqlDBHelper dbHelper = new MysqlDBHelper();
                DataSet ds = dbHelper.GetDataSet(sql, "zc_order_history");
                listDataGridView.AutoGenerateColumns = false;
                listDataGridView.DataSource = ds;
                listDataGridView.DataMember = "zc_order_history";
                listDataGridView.CurrentCell = null;//不默认选中

            }
        }

        /// <summary>
        /// 初始化显示差异difference
        /// </summary>
        private void initDifference()
        {
            for (int i = 0; i < itemDataGridView.RowCount; i++)
            {
                int orderNums = Convert.ToInt32(itemDataGridView[3, i].Value == null ? "0" : itemDataGridView[3, i].Value);
                itemDataGridView[5, i].Value = orderNums;
            }
        }

        private void CustomerDelivery_KeyDown(object sender, KeyEventArgs e)
        {

            ///快捷键点击结算
            if (e.KeyCode == Keys.F1)
            {
                pickUp_Click(this, e);
            }
            ///快捷键点击退款
            if (e.KeyCode == Keys.F2)
            {
                refund_Click(this, EventArgs.Empty);
            }
            //balance_Click(object sender, EventArgs e)
            if (e.KeyCode == Keys.F3)
            {
                balance_Click(this, EventArgs.Empty);
            }
            ///查询键点击查询
            if (queryTextBox.Focused == true && e.KeyCode == Keys.Enter)
            {
                queryButton_Click(this, e);
            }else if (numberTextBox.Focused == true && e.KeyCode == Keys.Enter)
            {
                equalButton_Click(this, EventArgs.Empty);
            }


        }

        /// <summary>
        /// 提货点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pickUp_Click(object sender, EventArgs e)
        {
            itemTablePanel.Show();
            //itemCountPanel.Show();
            //listTablePanel.Hide();
            //listCountPanel.Hide();
            listPanel.Hide();
            id_.Text = "";
            name_label.Text = "";
            inform_label.Text = "";
            card_label.Text = "";
            order_Num = "";
            initNumberAndAmount();

            //清空itemDataGridView上的信息
            itemDataGridView.DataSource = null;

            balance.Enabled = true;

            ///设置当前状态为结算
            WorkMode = Constant.PICK_UP_GOODS;
            ///焦点移动到查询输入框
            queryTextBox.Focus();

            //点击后改变按键背景色
            refund.BackColor = Color.FromArgb(173, 173, 173);
            pickUp.BackColor = Color.FromArgb(96, 133, 160);
            //显示扫码框
            //scanPanel.Show();
            numberTextBox.Enabled = true;


            //判断是否有份数差异
            //bool prompt = false;
            //if (itemDataGridView.Rows.Count == 0)
            //{
            //    MessageBox.Show("当前并无需要结算的订单！");
            //    return;
            //}
            //for (int i = 0; i < itemDataGridView.Rows.Count; i++)
            //{
            //    if (Convert.ToInt32(itemDataGridView[4, i].Value) == 0)
            //    {
            //        if (MessageBox.Show("当前商品" + itemDataGridView[1, i] .Value+ "实际份数为0,是否立刻结算？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
            //        {
            //            return;
            //        }
            //    }
            //    if (Convert.ToInt32(itemDataGridView[5, i].Value) != 0)
            //    {
            //        prompt = true;
            //    }
            //}
            //if (prompt)
            //{
            //    string sInput = "";
            //    CDPrompt cDPrompt = new CDPrompt();
            //    if (cDPrompt.ShowDialog() == DialogResult.OK)
            //    {//
            //        sInput = cDPrompt.inputMess;
            //        //MessageBox.Show(sInput);
            //    }
            //    if (!sInput.Equals("y"))
            //    {
            //        return;
            //    }
            //}

            //CDBalance cDBalance = new CDBalance(this, totalAmountValue, keyStr, order_Num);
            //cDBalance.ShowDialog();
        }

        /// <summary>
        /// 获取订单号
        /// </summary>
        /// <param name="orderNum">单号</param>
        public void setOrderNum(string orderNum)
        {
            this.order_Num = orderNum;
            queryOrderList();
        }

        /// <summary>
        /// 右侧展示订单信息
        /// </summary>
        /// <param name="orderNum">单号</param>
        /// <param name="name">姓名</param>
        /// <param name="phone">电话</param>
        /// <param name="card">卡号</param>
        public void setinform(string orderNum, string order_Amount, string name, string phone, string card)
        {
            id_.Text = orderNum;
            name_label.Text = name;
            inform_label.Text = phone;
            card_label.Text = card;
            //amount_TextBox.Text = order_Amount;
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

        /// <summary>
        /// 合计
        /// </summary>
        private void Calculate()
        {
            initNumberAndAmount();
            try
            {
                for (int i = 0; i < itemDataGridView.RowCount; i++)
                {
                    totalSumValue += Convert.ToInt32((itemDataGridView[4, i].Value == null || itemDataGridView[4, i].Value.ToString().Trim() == "") ? "0" : itemDataGridView[4, i].Value.ToString());
                    totalAmountValue += float.Parse((itemDataGridView[7, i].Value == null || itemDataGridView[7, i].Value.ToString().Trim() == "") ? "0" : itemDataGridView[7, i].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                log.Error("类型转换异常", ex);
            }
            this.totalSum.Text = totalSumValue.ToString();
            this.totalAmount.Text = totalAmountValue.ToString("0.00");
        }

        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="num">商品份数</param>
        public void AddGoods(ZcGoodsMaster obj, string num)
        {
            if (itemDataGridView.DataSource == null)
            {
                MessageBox.Show("尚未读取订单数据");
                return;
            }
            DataSet ds = (DataSet)itemDataGridView.DataSource;
            //
            bool flag = false;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i][0].ToString().ToString().Equals(obj.SerialNumber))
                {
                    string nums = itemDataGridView[5, i].Value.ToString();
                    itemDataGridView[5, i].Value = Convert.ToInt32(nums) + Convert.ToInt32(num);
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
                    itemDataGridView[4, i].Value = Convert.ToInt32(itemDataGridView[4, i].Value) + 1;
                    //this.itemDataGridView.CurrentCell = itemDataGridView[4, row]; //单元格设置可编辑状态-
                    //itemDataGridView.BeginEdit(true);
                }//
            }
            if (!flag)
            {
                MessageBox.Show("客户订单中没有此商品，请与客户确认");
                return;
            }
            //自动计算
            Calculate();
        }

        /// <summary>
        /// 检测输入是否为数字的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (itemDataGridView.CurrentCell.ColumnIndex == 4)
            {
                e.Control.KeyPress -= new KeyPressEventHandler(checkInput);
                e.Control.KeyPress += new KeyPressEventHandler(checkInput);
            }
            if (itemDataGridView.CurrentCell.ColumnIndex == 7)
            {
                //7 只输入数字和点 退回
                e.Control.KeyPress -= new KeyPressEventHandler(checkInput2);
                e.Control.KeyPress += new KeyPressEventHandler(checkInput2);
            }
        }

        /// <summary>
        /// 检测输入输入是否是数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkInput2(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl s = sender as DataGridViewTextBoxEditingControl;
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
                //MessageBox.Show("数据验证");
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
            if (e.RowIndex != -1 && e.ColumnIndex == 4)
            {
                try
                {
                    initNumberAndAmount();
                    int num = itemDataGridView.Rows[e.RowIndex].Cells[4].Value == null ? 0 : Convert.ToInt32(itemDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
                    Double price = Convert.ToDouble(itemDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    itemDataGridView.Rows[e.RowIndex].Cells[5].Value = Convert.ToInt32(itemDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString()) - num;
                    //itemDataGridView.Rows[e.RowIndex].Cells[7].Value = Math.Round(num * price, 2).ToString("0.00");
                    //Calculate();
                }
                catch (Exception ex)
                {
                    log.Error("自动计算金额错误", ex);
                }
            }
            if (e.RowIndex != -1 && e.ColumnIndex == 5)
            {
                int cot = Convert.ToInt32(itemDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
                if (cot != 0)
                {
                    this.itemDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(201, 67, 65);//Color.Red;
                }
                else
                {
                    this.itemDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(51, 153, 255);//Color.Blue;
                }
            }
            ///订单金额进行了手动修改
            if (e.RowIndex != -1 && e.ColumnIndex == 7)
            {
                initNumberAndAmount();
                Calculate();
            }
        }

        private void itemDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            row = itemDataGridView.CurrentCell.RowIndex;
            column = itemDataGridView.CurrentCell.ColumnIndex;
        }

        /// <summary>
        /// 
        /// </summary>
        public void balance_data()
        {
            string orderId = itemDataGridView.SelectedRows[0].Cells[12].Value.ToString();
            BranchZcOrderTransitService transitService = new BranchZcOrderTransitService();
            BranchZcOrderTransitItemService transitItemService = new BranchZcOrderTransitItemService();
            BranchZcOrderHistoryService historyService = new BranchZcOrderHistoryService();
            BranchZcOrderHistoryItemService historyItemService = new BranchZcOrderHistoryItemService();
            ZcOrderTransit zcTransit = transitService.FindById(orderId);
            zcTransit.OrderStatus = Constant.ORDER_STATUS_FININSH;
            ZcOrderHistory history = ZcOrderHelper.Tranform(zcTransit);
            List<ZcOrderTransitItem> itemlist = transitItemService.FindByOrderId(orderId);
            List<ZcOrderHistoryItem> historylist = ZcOrderHelper.Transform(itemlist);
            historyItemService.AddZcOrderHistoryItem(historylist);
            historyService.AddZcOrderHistory(history);
            transitItemService.DeleteByOrderId(orderId);
            transitService.DeleteById(orderId);
        }

        /// <summary>
        /// 初始化份数还有金额
        /// </summary>
        public void initNumberAndAmount()
        {
            this.totalSumValue = 0;
            this.totalAmountValue = 0;
            totalSum.Text = totalSumValue.ToString("0.00");
            totalAmount.Text = totalAmountValue.ToString("0.00");
        }

        /// <summary>
        /// DatagridView 显示格式化
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

        /// <summary>
        /// 初始化数据
        /// </summary>
        public void initData()
        {
            queryTextBox.Text = "";
            card_label.Text = "";
            name_label.Text = "";
            inform_label.Text = "";
            id_.Text = "";
            totalSum.Text = "";
            totalAmount.Text = "";
            itemDataGridView.DataSource = null;
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
            numberTextBox.Text += "00";
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
            string bar = numberTextBox.Text;
            numberTextBox.Text = "";
            string good_id = "";
            string good_wei = "";
            if (string.IsNullOrEmpty(bar) || bar.Length != 13)
            {
                MessageBox.Show("扫码的条码不正确,请重新扫码!", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            float weigth = 0;
            if (bar.StartsWith("28"))
            {
                good_id = bar.Substring(2, 5);
                good_wei = bar.Substring(7, 5);
                weigth = float.Parse(good_wei.Insert(2, "."));
                good_wei = ((float.Parse(good_wei)) / 100).ToString("0.000");
            }
            else
            {
                good_id = bar;
            }
            
            //good_wei = ((float.Parse(good_wei)) / 100).ToString();


            DataSet ds = (DataSet)itemDataGridView.DataSource;
            bool flag = false;
            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("当前未选择任意订单，请先选择一条订单再进行扫码操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (itemDataGridView[0, i].Value.ToString().Equals(good_id))
                {
                    row = i;//
                    column = 5;//
                    flag = true;
                    ///价格
                    float goodsPrice = float.Parse(itemDataGridView[2, i].Value == null ? "0" : itemDataGridView[2, i].Value.ToString());
                    GoodsPrint goodsPrint = new GoodsPrint();
                    goodsPrint.SerialNumber = good_id;
                    goodsPrint.Name = itemDataGridView[1, i].Value == null ? "" : itemDataGridView[1, i].Value.ToString();
                    goodsPrint.Nums = 1;
                    goodsPrint.Price = float.Parse(itemDataGridView[2, i].Value == null ? "0" : itemDataGridView[2, i].Value.ToString());
                    goodsPrint.Unit = itemDataGridView[10, i].Value == null ? "" : itemDataGridView[10, i].Value.ToString();
                    if (bar.StartsWith("28"))
                    {
                        goodsPrint.Weight = weigth;
                    }
                    if (addOrReduceFlag == "add")
                    {
                        itemDataGridView[4, i].Value = Convert.ToInt32(itemDataGridView[4, i].Value == null ? "0" : itemDataGridView[4, i].Value.ToString()) + 1;
                        if (bar.StartsWith("28"))
                        {
                            itemDataGridView[7, i].Value = ((float.Parse(itemDataGridView[7, i].Value == null ? "0" : itemDataGridView[7, i].Value.ToString())) + goodsPrice * weigth).ToString("0.00");
                            itemDataGridView[8, i].Value = (float.Parse(itemDataGridView[8, i].Value == null ? "0" : itemDataGridView[8, i].Value.ToString()) + weigth).ToString("0.000");
                        }
                        else
                        {
                            itemDataGridView[7, i].Value = (float.Parse(itemDataGridView[7, i].Value == null ? "0" : itemDataGridView[7, i].Value.ToString()) + goodsPrice * 1).ToString("0.00");
                            itemDataGridView[8, i].Value = (float.Parse(itemDataGridView[8, i].Value == null ? "0" : itemDataGridView[8, i].Value.ToString()) + 1).ToString("0.000");
                        }
                        bool isExist = false;
                        for (int j = 0; j < printObjectlist.Count; j++)
                        {
                            GoodsPrint obj = printObjectlist[j];
                            
                            if(obj.SerialNumber.Equals(goodsPrint.SerialNumber))
                            {
                                ///存在商品
                                isExist = true;
                                ///69开头的商品，数量直接+1
                                if (obj.SerialNumber.Length != 5)
                                {
                                    obj.Nums += 1;
                                    break;
                                }
                                else ///28开头的商品，直接添加
                                {
                                    printObjectlist.Add(goodsPrint);
                                    break;
                                }
                            }
                        }
                        ///不存在   都要添加
                        if(!isExist)
                        {
                            printObjectlist.Add(goodsPrint);
                        }
                        
                    }
                    else
                    {
                        if (Convert.ToInt32(itemDataGridView[4, i].Value == null ? "0" : itemDataGridView[4, i].Value.ToString()) == 0)
                        {
                            MessageBox.Show("此商品的份数为0，无法进行减去扫码操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            addReduceButton_Click(this, EventArgs.Empty);
                            return;
                        }
                        bool isDone = false;
                        for (int j = 0; j < printObjectlist.Count; j++ )
                        {
                            GoodsPrint obj = printObjectlist[j];
                            if(goodsPrint.SerialNumber.Equals(obj.SerialNumber))
                            {
                                if (obj.SerialNumber.Length == 5)
                                {
                                    if (obj.Weight == weigth)
                                    {
                                        printObjectlist.RemoveAt(j);
                                        isDone = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    isDone = true;
                                    if (obj.Nums == 1)
                                    {
                                        printObjectlist.RemoveAt(j);
                                        break;
                                    }
                                    else
                                    {
                                        obj.Nums = obj.Nums - 1;
                                        break;
                                    }
                                }
                            }
                        }
                        if( !isDone)
                        {
                            MessageBox.Show("此商品之前未曾进行过扫码操作，无法执行减去扫码操作!", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            addReduceButton_Click(this, EventArgs.Empty);
                            return;
                        }
                        itemDataGridView[4, i].Value = Convert.ToInt32(itemDataGridView[4, i].Value == null ? "0" : itemDataGridView[4, i].Value.ToString()) - 1;
                        if (bar.StartsWith("28"))
                        {
                            itemDataGridView[7, i].Value = ((float.Parse(itemDataGridView[7, i].Value == null ? "0" : itemDataGridView[7, i].Value.ToString())) - goodsPrice * weigth).ToString("0.00");
                            itemDataGridView[8, i].Value = (float.Parse(itemDataGridView[8, i].Value == null ? "0" : itemDataGridView[8, i].Value.ToString()) - weigth).ToString("0.000");
                        }
                        else
                        {
                            itemDataGridView[7, i].Value = (float.Parse(itemDataGridView[7, i].Value == null ? "0" : itemDataGridView[7, i].Value.ToString()) - goodsPrice * 1).ToString("0.00");
                            itemDataGridView[8, i].Value = (float.Parse(itemDataGridView[8, i].Value == null ? "0" : itemDataGridView[8, i].Value.ToString()) - 1).ToString("0.000");
                        }
                        ///itemDataGridView[8, i].Value = (float.Parse(itemDataGridView[8, i].Value == null ? "0" : itemDataGridView[8, i].Value.ToString()) - weigth).ToString("0.000");
                        addReduceButton_Click(this, EventArgs.Empty);
                    }
                    Calculate();
                    //this.itemDataGridView.CurrentCell = itemDataGridView[4, row]; //单元格设置可编辑状态-
                    //itemDataGridView.BeginEdit(true);
                }
            }

            if (!flag)
            {
                MessageBox.Show("客户订单中没有此商品，请与客户确认");
                return;
            }
        }

        /// <summary>
        /// DatagridView结束编辑事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ///当前工作模式为提货状态时， 焦点在实际份数和扫码框之前切换
            if (WorkMode == Constant.PICK_UP_GOODS)
            {
                numberTextBox.Focus();
            }

        }

        private void CustomerDelivery_FormClosed(object sender, FormClosedEventArgs e)
        {
            customer();
        }

        /// <summary>
        /// 退款点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refund_Click(object sender, EventArgs e)
        {
            itemTablePanel.Hide();
            //itemCountPanel.Hide();
            //listTablePanel.Show();
            //listCountPanel.Show();
            listPanel.Show();
            //清空页面信息
            id_.Text = "";
            name_label.Text = "";
            inform_label.Text = "";
            card_label.Text = "";
            order_Num = "";
            initNumberAndAmount();
            //清空listDataGridView上的信息
            listDataGridView.DataSource = null;
            ///焦点移动到查询输入框
            queryTextBox.Focus();
            //点击后改变按键背景色
            refund.BackColor = Color.FromArgb(96, 133, 160);
            pickUp.BackColor = Color.FromArgb(173, 173, 173);
            //隐藏扫码框
            //scanPanel.Hide();
            numberTextBox.Enabled = false;

            WorkMode = Constant.REFUND;
            balance.Enabled = false;
        }

        /// <summary>
        /// 结算点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void balance_Click(object sender, EventArgs e)
        {
            if (itemDataGridView.DataSource == null)
            {
                MessageBox.Show("当前没有要结算的订单");
                return;
            }
            if (itemDataGridView.RowCount == 0)
            {
                MessageBox.Show("当前没有要结算的订单");
                return;
            }
            ///存在拒收商品标识
            bool existRefuse = false;
            ///整单商品拒收标识
            bool allRefuse = true;
            for (int i = 0; i < itemDataGridView.Rows.Count; i++)
            {
                if (Convert.ToInt32(itemDataGridView[5, i].Value) != 0)
                {
                    existRefuse = true;
                    //RefuseReason refuseReason = new RefuseReason(this, itemDataGridView[1, i].Value.ToString(), i);
                    //refuseReason.ShowDialog();
                    if (Convert.ToInt32(itemDataGridView[5, i].Value) != Convert.ToInt32(itemDataGridView[3, i].Value))
                    {
                        allRefuse = false;
                    }
                }
                else
                {
                    allRefuse = false;
                }
            }

            if (!existRefuse)
            {
                ///不存在拒收情况，直接进入结算  
                PayForm pay = new PayForm();
                pay.totalAmount = totalAmount.Text.ToString();
                pay.memberCardId = card_label.Text.ToString();
                pay.orderId = id_.Text.ToString();
                pay.ModeFlag = 0;
                pay.customerDelivery = this;
                pay.ShowDialog();
            }
            else
            {
                if (allRefuse)
                {
                    DialogResult dr = MessageBox.Show("当前客户未提取商品,是否整单拒收？", "标题", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < itemDataGridView.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(itemDataGridView[5, i].Value) != 0)
                            {
                                RefuseReason refuseReason = new RefuseReason(this, itemDataGridView[1, i].Value.ToString(), i);
                                refuseReason.ShowDialog();
                            }
                        }

                        actualTotalMoney = "0";
                        saveRefuseInform(Constant.ORDER_STATUS_ALL_REFUSE);
                        MessageBox.Show("整单拒收成功");
                        initData();
                    }
                }
                else
                {
                    ///部分拒收    
                    DialogResult dr = MessageBox.Show("当前订单中存在未收商品,是否部分拒收,结算？", "标题", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < itemDataGridView.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(itemDataGridView[5, i].Value) != 0)
                            {
                                RefuseReason refuseReason = new RefuseReason(this, itemDataGridView[1, i].Value.ToString(), i);
                                refuseReason.ShowDialog();
                            }
                        }
                        ///先结算  
                        PayForm pay = new PayForm();
                        pay.totalAmount = totalAmount.Text.ToString();
                        pay.memberCardId = card_label.Text.ToString();
                        pay.orderId = id_.Text.ToString();
                        pay.ModeFlag = 1;
                        pay.customerDelivery = this;
                        pay.ShowDialog();

                    }
                }
            }


        }


        /// <summary>
        /// 添加拒收原因
        /// </summary>
        /// <param name="index"></param>
        /// <param name="p"></param>
        public void AddRefuseReason(int index, string reason)
        {
            itemDataGridView[13, index].Value = reason;
        }

        //listDataGridView

        private void listDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //行号
            using (SolidBrush b = new SolidBrush(this.listDataGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(Convert.ToString(e.RowIndex + 1),
                e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
            }
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

            if (e.RowIndex != -1 && e.ColumnIndex == 5)
            {
                try
                {
                    int num = listDataGridView.Rows[e.RowIndex].Cells[5].Value == null ? 0 : Convert.ToInt32(listDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
                    Double price = Convert.ToDouble(listDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                    listDataGridView.Rows[e.RowIndex].Cells[7].Value = Math.Round(num * price, 2).ToString("0.00");
                }
                catch (Exception ex)
                {
                    log.Error("自动计算金额错误", ex);
                }
            }
            if (e.RowIndex != -1 && e.ColumnIndex == 5)
            {
                //int cot = Convert.ToInt32(listDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
                int cot = Convert.ToInt32(listDataGridView.Rows[e.RowIndex].Cells[5].Value == null ? 0 : Convert.ToInt32(listDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString()));
                int actualQuantity_list = listDataGridView.Rows[e.RowIndex].Cells[4].Value == null ? 0 : Convert.ToInt32(listDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
                if (cot > actualQuantity_list)
                {
                    MessageBox.Show("退款商品份数超过当前提货份数，请重新输入！");
                    listDataGridView.Rows[e.RowIndex].Cells[5].Value = 0;
                    return;
                }
                if (cot != 0)
                {
                    this.listDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(201, 67, 65);//Color.Red;
                    //this.listDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    this.listDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    //this.listDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    listDataGridView.Rows[e.RowIndex].Cells[0].Value = false;
                }
            }

            //160309
            initNumberAndAmount();
            int sum = 0;
            float amount = 0;
            try
            {
                for (int i = 0; i < listDataGridView.RowCount; i++)
                {
                    string _selectValue = listDataGridView.Rows[i].Cells[0].EditedFormattedValue.ToString();
                    if (_selectValue == "True")
                    {
                        sum += Convert.ToInt32((listDataGridView[5, i].Value == null || listDataGridView[5, i].Value.ToString().Trim() == "") ? "0" : listDataGridView[5, i].Value.ToString());
                        amount += float.Parse((listDataGridView[7, i].Value == null || listDataGridView[7, i].Value.ToString().Trim() == "") ? "0" : listDataGridView[7, i].Value.ToString());
                    }
                }
                totalSum.Text = sum.ToString();
                totalAmount.Text = amount.ToString();
            }
            catch (Exception ex)
            {
                log.Error("类型转换异常", ex);
            }
        }

        private void listDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == 5)
            {
                return;
            }
            //if (e.ColumnIndex == 14)
            //{
            //    return;
            //}
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
                this.listDataGridView.CurrentCell = listDataGridView[5, e.RowIndex];
                listDataGridView.BeginEdit(true);
            }
            //}
        }

        private void listDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (listDataGridView.CurrentCell.ColumnIndex == 5)
            {
                e.Control.KeyPress -= new KeyPressEventHandler(checkInput);
                e.Control.KeyPress += new KeyPressEventHandler(checkInput);
            }
        }

        private void listDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (listDataGridView.Columns[e.ColumnIndex].Name == "goods_specifications_list")
            {
                if (e.Value == null || e.Value.ToString() == "")
                {
                    return;
                }
                string str = e.Value.ToString();
                e.Value = str.Replace("商品规格：", "");
            }
            if (listDataGridView.Columns[e.ColumnIndex].Name == "g_price_list")
            {
                if (e.Value == null || e.Value.ToString() == "")
                {
                    return;
                }
                double price = Convert.ToDouble(e.Value.ToString());
                e.Value = price.ToString("0.00");
            }
        }

        private void returnOrderButton_Click(object sender, EventArgs e)
        {
            if (id_.Text.Equals(""))
            {
                MessageBox.Show("当前暂无需退款的订单!");
                return;
            }

            //if (MessageBox.Show("当前订单内商品是否确定退款？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
            //{
            //    return;
            //}
            for (int i = 0; i < listDataGridView.RowCount; i++)
            {
                //string _selectValue = listDataGridView.Rows[i].Cells[0].EditedFormattedValue.ToString();
                //if (_selectValue == "False")
                //{
                //listDataGridView.Rows[i].Cells[0].Value = true;
                int num = Convert.ToInt32(listDataGridView.Rows[i].Cells[4].Value);//actualQuantity_list
                listDataGridView.Rows[i].Cells[5].Value = num;
                //MessageBox.Show(listDataGridView.Rows[i].Cells[0].Value.ToString());
                //}
            }
            foreach (DataGridViewRow dr in this.listDataGridView.Rows)
            {
                dr.Cells["chooseCheckbox"].Value = true;
                //MessageBox.Show(dr.Cells["chooseCheckbox"].Value.ToString());
            }
            bool flag = refundcount();//展示退款商品份数及总金额
            if (!flag)
            {
                return;
            }

            string constant = Constant.ORDER_STATUS_ALL_REFUND;
            //判断该订单付款方式
            bool mode_flag = returnModeFlag(constant);
            if (!mode_flag)
            {
                return;
            }

            saveReturnInform(constant);
            MessageBox.Show("退款信息已提交！");
        }

        private void returnGoodsButton_Click(object sender, EventArgs e)
        {
            if (id_.Text.Equals(""))
            {
                MessageBox.Show("当前暂无需退款的订单!");
                return;
            }
            //if (MessageBox.Show("所选商品是否确定退款？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
            //{
            //    return;
            //}
            bool flag = refundcount();//展示退款商品份数及总金额
            if (!flag)
            {
                return;
            }

            string constant = Constant.ORDER_STATUS_PART_REFUND;
            //判断该订单付款方式
            bool mode_flag = returnModeFlag(constant);
            if (!mode_flag)
            {
                return;
            }

            saveReturnInform(constant);
            MessageBox.Show("退款单已提交！");
        }

        /// <summary>
        /// 退款中，现金部分直接线下退回，其余仍走审批流程
        /// </summary>
        /// <returns></returns>
        public bool returnModeFlag(string constant)
        {
            bool mode_flag = false;
            ////查询该订单现金付款金额
            BranchPayInfoService payService = new BranchPayInfoService();
            List<string> payMode = payService.FindModePayment(id_.Text.ToString());
            //MessageBox.Show(payMode.ToString());
            bool money_flag = false;//现金
            bool card_flag = false;//易宝卡
            bool WxPay_flag = false;//微信
            bool ZFBPay_flag = false;//支付宝
            foreach (string i in payMode)
            {
                if (i.Equals(BranchPay.money))
                {
                    money_flag = true;
                }
                if (i.Equals(BranchPay.card))
                {
                    card_flag = true;
                }
                if (i.Equals(BranchPay.WxPay))
                {
                    WxPay_flag = true;
                }
                if (i.Equals(BranchPay.ZFBPay))
                {
                    ZFBPay_flag = true;
                }
            }
            if (money_flag)
            {
                if (!card_flag && !WxPay_flag && !ZFBPay_flag)
                {
                    //付款方式唯一，且为现金支付
                    //线下退款
                    if (MessageBox.Show("当前订单退款方式为现金退款，是否确定退款？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        List<PayInfo> payList = new List<PayInfo>();
                        PayInfo obj = new PayInfo();
                        obj.Id = Guid.NewGuid().ToString();
                        obj.CreateTime = DateTime.Now;
                        obj.UpdateTime = DateTime.Now;
                        obj.PayAmount = (0 - returnAmount).ToString("0.00");
                        obj.orderId = id_.Text.ToString();
                        obj.salesmanId = LoginUserInfo.id;
                        obj.payDate = DateTime.Now;
                        obj.PayMode = BranchPay.money_refund;
                        obj.MemberId = card_label.Text.ToString();
                        obj.BranchId = LoginUserInfo.branchId;
                        payList.Add(obj);
                        payService.AddPayInfo(payList);

                        //上传支付信息
                        if (PingTask.IsConnected)
                        {
                            PayInfoService masterPayInfoService = new PayInfoService();
                            masterPayInfoService.AddPayInfo(payList);
                        }
                        else
                        {
                            List<UploadInfo> list = new List<UploadInfo>();
                            foreach (PayInfo i in payList)
                            {
                                UploadInfo uploadInfo = new UploadInfo();
                                uploadInfo.Id = i.Id;
                                uploadInfo.CreateTime = DateTime.Now;
                                uploadInfo.UpdateTime = DateTime.Now;
                                uploadInfo.Type = Constant.PAY_INFO;
                                list.Add(uploadInfo);
                            }
                            UploadDao uploadDao = new UploadDao();
                            uploadDao.AddUploadInfo(list);
                        }

                        //修改本地历史订单状态
                        BranchZcOrderHistoryService branchZcOrderHistoryService = new BranchZcOrderHistoryService();
                        branchZcOrderHistoryService.UpdateOrderStatusByIds(id_.Text.ToString(), constant);

                        MessageBox.Show("退款成功！");

                        //清空listDataGridView上的信息
                        listDataGridView.DataSource = null;
                        //初始化信息
                        queryTextBox.Text = "";
                        card_label.Text = "";
                        name_label.Text = "";
                        inform_label.Text = "";
                        id_.Text = "";
                        this.order_Num = null;

                        return mode_flag;
                    }
                    else
                    {
                        return mode_flag;
                    }
                }
            }
            else
            {
                if (card_flag && !WxPay_flag && !ZFBPay_flag || !card_flag && WxPay_flag && !ZFBPay_flag || !card_flag && !WxPay_flag && ZFBPay_flag)
                {
                    //付款方式唯一，且非现金支付
                    mode_flag = true;
                    return mode_flag;
                }
            }
            MessageBox.Show("当前订单为多方式支付，无法完成退款操作！");
            return mode_flag;
        }

        /// <summary>
        /// 将退款信息存入数据库
        /// </summary>
        public void saveReturnInform(string constant)
        {
            //直接将退款信息及明细存入本地
            //查询历史订单信息
            BranchZcOrderHistoryService branchZcOrderHistoryService = new BranchZcOrderHistoryService();
            ZcOrderHistory zcOrderHistory = branchZcOrderHistoryService.FindById(id_.Text.ToString());

            ////查询该订单现金付款金额
            //BranchPayInfoService payService = new BranchPayInfoService();
            //string cashPay = payService.FindCashPayment(idTextBox.Text.ToString());

            ZcOrderRefund zcOrderRefund = new ZcOrderRefund();
            zcOrderRefund.Id = Guid.NewGuid().ToString();
            zcOrderRefund.CreateTime = DateTime.Now;
            zcOrderRefund.UpdateTime = DateTime.Now;
            zcOrderRefund.Order_id = zcOrderHistory.Id;
            zcOrderRefund.Order_amount = zcOrderHistory.OrderAmount.ToString("0.00");
            zcOrderRefund.Actual_amount = (float.Parse(zcOrderHistory.ActualMoney == null ? "0" : zcOrderHistory.ActualMoney) - returnAmount).ToString("0.00");
            //zcOrderRefund.Actual_amount = (zcOrderHistory.OrderAmount - returnAmount).ToString("0.00");//实际金额
            zcOrderRefund.Order_refund_status = "1";//退款单未审批
            zcOrderRefund.Hand_date = DateTime.Now;

            //MessageBox.Show("‘ID’:" + zcOrderRefund.Id + "‘UpdateTime’:" + zcOrderRefund.UpdateTime + "‘Order_id’:" + zcOrderRefund.Order_id + "‘Order_amount’:" + zcOrderRefund.Order_amount + "‘Actual_amount’:" + zcOrderRefund.Actual_amount);


            List<ZcOrderRefundItem> refundlist = new List<ZcOrderRefundItem>();
            for (int i = 0; i < listDataGridView.RowCount; i++)
            {
                //MessageBox.Show(listDataGridView.Rows[i].Cells[0].Value.ToString());
                string _selectValue = listDataGridView.Rows[i].Cells[0].EditedFormattedValue.ToString();
                if (_selectValue == "True")
                {
                    ZcOrderRefundItem zcOrderRefundItem = new ZcOrderRefundItem();
                    zcOrderRefundItem.Id = Guid.NewGuid().ToString();
                    zcOrderRefundItem.CreateTime = DateTime.Now;
                    zcOrderRefundItem.UpdateTime = DateTime.Now;
                    zcOrderRefundItem.SerialNumber = listDataGridView[1, i].Value == null ? "" : listDataGridView[1, i].Value.ToString();
                    zcOrderRefundItem.Order_id = listDataGridView[12, i].Value == null ? "" : listDataGridView[12, i].Value.ToString();
                    zcOrderRefundItem.Order_nums = listDataGridView[4, i].Value == null ? "" : listDataGridView[4, i].Value.ToString();//实际数量
                    zcOrderRefundItem.Refund_nums = listDataGridView[5, i].Value == null ? "" : listDataGridView[5, i].Value.ToString();
                    zcOrderRefundItem.Price = listDataGridView[3, i].Value == null ? "" : listDataGridView[3, i].Value.ToString();
                    zcOrderRefundItem.Refund_amount = listDataGridView[7, i].Value == null ? "" : listDataGridView[7, i].Value.ToString();
                    zcOrderRefundItem.Salesman_id = LoginUserInfo.id;
                    //zcOrderRefundItem.Hand_date = DateTime.Now;
                    zcOrderRefundItem.Street = LoginUserInfo.street;
                    zcOrderRefundItem.GoodsFile_id = listDataGridView[13, i].Value == null ? "" : listDataGridView[13, i].Value.ToString();//商品ID
                    zcOrderRefundItem.Refund_id = zcOrderRefund.Id;
                    zcOrderRefundItem.Refund_reason = listDataGridView[14, i].Value == null ? "" : listDataGridView[14, i].Value.ToString();//退回原因
                    //MessageBox.Show("‘ID’:" + zcOrderRefundItem.Id + "‘UpdateTime’:" + zcOrderRefundItem.UpdateTime + "‘Order_id’:" + zcOrderRefundItem.Order_id + "‘Order_amount’:" + zcOrderRefundItem.Refund_nums + "‘Actual_amount’:" + zcOrderRefundItem.Refund_amount);

                    refundlist.Add(zcOrderRefundItem);
                }
            }

            //添加退款明细
            BranchZcOrderRefundService branchZcOrderRefundService = new BranchZcOrderRefundService();
            BranchZcOrderRefundItemService branchZcOrderRefundItemService = new BranchZcOrderRefundItemService();
            branchZcOrderRefundService.AddZcOrderRefund(zcOrderRefund);
            branchZcOrderRefundItemService.AddZcOrderRefundItem(refundlist);
            //修改本地历史订单状态
            branchZcOrderHistoryService.UpdateOrderStatusByIds(id_.Text.ToString(), constant);
            //
            MessageBox.Show("退款单已生成，请等待处理！");

            List<UploadInfo> uploadList = new List<UploadInfo>();
            UploadDao uploadDao = new UploadDao();
            if (PingTask.IsConnected)
            {
                //上传退款表数据
                RefundInfoService refundInfoService = new RefundInfoService();
                refundInfoService.AddZcOrderRefund(zcOrderRefund);
                refundInfoService.AddZcOrderRefundItem(refundlist);
                //上传历史表状态更新
                ZcOrderHistoryService zcOrderHistoryService = new ZcOrderHistoryService();
                zcOrderHistoryService.UpdateOrderStatusByIds(id_.Text.ToString(), constant);
            }
            else
            {
                UploadInfo obj1 = new UploadInfo();
                obj1.Id = zcOrderRefund.Id;
                obj1.CreateTime = DateTime.Now;
                obj1.UpdateTime = DateTime.Now;
                obj1.Type = Constant.ZC_ORDER_REFUND;
                uploadList.Add(obj1);
                foreach (ZcOrderRefundItem obj in refundlist)
                {
                    UploadInfo obj2 = new UploadInfo();
                    obj2.Id = obj.Id;
                    obj2.CreateTime = DateTime.Now;
                    obj2.UpdateTime = DateTime.Now;
                    obj2.Type = Constant.ZC_ORDER_REFUND_ITEM;
                    uploadList.Add(obj2);
                }
                UploadInfo obj3 = new UploadInfo();
                obj3.Id = zcOrderRefund.Id;
                obj3.CreateTime = DateTime.Now;
                obj3.UpdateTime = DateTime.Now;
                obj3.Type = Constant.ZC_ORDER_HISTORY_UPDATE;
                uploadList.Add(obj3);
                uploadDao.AddUploadInfo(uploadList);
            }


            //清空listDataGridView上的信息
            listDataGridView.DataSource = null;
            //初始化信息
            queryTextBox.Text = "";
            card_label.Text = "";
            name_label.Text = "";
            inform_label.Text = "";
            id_.Text = "";
            this.order_Num = null;
        }

        public void returnPay()
        {
            PayForm pay = new PayForm();
            pay.totalAmount = totalAmount.Text.ToString();
            pay.memberCardId = card_label.Text.ToString();
            pay.orderId = id_.Text.ToString();
            pay.ModeFlag = 0;
            pay.customerDelivery = this;
            pay.ShowDialog();
        }

        public bool refundcount()
        {
            bool flag = true;
            returnSum = 0;
            returnAmount = 0;
            initNumberAndAmount();
            try
            {
                for (int i = 0; i < listDataGridView.RowCount; i++)
                {
                    string _selectValue = listDataGridView.Rows[i].Cells[0].EditedFormattedValue.ToString();
                    if (_selectValue == "True")
                    {
                        returnSum += Convert.ToInt32((listDataGridView[5, i].Value == null || listDataGridView[5, i].Value.ToString().Trim() == "") ? "0" : listDataGridView[5, i].Value.ToString());
                        returnAmount += float.Parse((listDataGridView[7, i].Value == null || listDataGridView[7, i].Value.ToString().Trim() == "") ? "0" : listDataGridView[7, i].Value.ToString());
                    }
                }
                totalSum.Text = returnSum.ToString();
                totalAmount.Text = returnAmount.ToString();
            }
            catch (Exception ex)
            {
                log.Error("类型转换异常", ex);
            }
            if (returnSum == 0)
            {
                MessageBox.Show("当前并未选择需退款的商品，请重新选择！");
                flag = false;
                return flag;
            }
            if (MessageBox.Show("当前所选退款商品份数为：" + returnSum + "，总金额为：" + returnAmount + "，是否确定退款？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                flag = false;
            }
            return flag;
        }

        /// <summary>
        /// 保存拒收信息和明细
        /// </summary>
        public void saveRefuseInform(string orderstatus)
        {
            BranchZcOrderTransitService transitService = new BranchZcOrderTransitService();
            ZcOrderTransit tran = transitService.FindById(id_.Text.ToString());

            ZcOrderRefuse refuse = new ZcOrderRefuse();
            refuse.id = Guid.NewGuid().ToString();
            refuse.createTime = DateTime.Now;
            refuse.updateTime = DateTime.Now;
            refuse.orderId = tran.Id;
            refuse.orderAmount = tran.OrderAmount.ToString("0.00");
            refuse.actualAmount = totalAmount.Text.ToString();
            List<ZcOrderRefuseItem> list = new List<ZcOrderRefuseItem>();
            for (int i = 0; i < itemDataGridView.RowCount; i++)
            {
                string refuseNums = itemDataGridView[5, i].Value == null ? "0" : itemDataGridView[5, i].Value.ToString();
                if (refuseNums == "0")
                {
                    continue;
                }
                ZcOrderRefuseItem obj = new ZcOrderRefuseItem();
                obj.id = Guid.NewGuid().ToString();
                obj.createTime = DateTime.Now;
                obj.updateTime = DateTime.Now;
                obj.serialNumber = itemDataGridView[0, i].Value == null ? "" : itemDataGridView[0, i].Value.ToString();
                obj.orderId = itemDataGridView[12, i].Value == null ? "" : itemDataGridView[12, i].Value.ToString();
                obj.orderNums = itemDataGridView[3, i].Value == null ? "" : itemDataGridView[3, i].Value.ToString();
                obj.refuseNums = itemDataGridView[5, i].Value == null ? "0" : itemDataGridView[5, i].Value.ToString();
                obj.price = itemDataGridView[2, i].Value == null ? "0" : itemDataGridView[2, i].Value.ToString();
                obj.refuseAmount = ((float.Parse(obj.price)) * (Convert.ToInt32(obj.refuseNums))).ToString("0.00");
                obj.salesmanId = LoginUserInfo.id;
                obj.handDate = DateTime.Now;
                obj.street = LoginUserInfo.street;
                obj.goodsFileId = itemDataGridView[14, i].Value == null ? "" : itemDataGridView[14, i].Value.ToString();
                obj.refuseId = refuse.id;
                obj.refuseReason = itemDataGridView[13, i].Value == null ? "" : itemDataGridView[13, i].Value.ToString();
                list.Add(obj);
            }
            //获取原来的订单信息， 将订单状态修改为全部拒收  移动到history表中
            BranchZcOrderTransitItemService itemService = new BranchZcOrderTransitItemService();
            List<ZcOrderTransitItem> transitItemlist = itemService.FindByOrderId(tran.Id);
            tran.OrderStatus = orderstatus;
            ZcOrderHistory history = ZcOrderHelper.Tranform(tran);
            history.ActualMoney = actualTotalMoney;
            history.ActualNums = totalSum.Text;
            List<ZcOrderHistoryItem> historyItemlist = ZcOrderHelper.Transform(transitItemlist);
            for (int i = 0; i < itemDataGridView.RowCount; i++)
            {
                string goodsFileId = itemDataGridView[14, i].Value == null ? "" : itemDataGridView[14, i].Value.ToString();
                for (int j = 0; j < historyItemlist.Count; j++)
                {
                    ZcOrderHistoryItem item = historyItemlist[j];
                    if (goodsFileId.Equals(item.GoodsFileId))
                    {
                        item.actualNums = itemDataGridView[4, i].Value == null ? "0" : itemDataGridView[4, i].Value.ToString();
                        item.actualMoney = itemDataGridView[7, i].Value == null ? "" : itemDataGridView[7, i].Value.ToString();
                    }
                }
            }
            BranchZcOrderHistoryItemService historyItemService = new BranchZcOrderHistoryItemService();
            BranchZcOrderHistoryService historyService = new BranchZcOrderHistoryService();
            //本地添加history表中相关数据
            historyService.AddZcOrderHistory(history);
            historyItemService.AddZcOrderHistoryItem(historyItemlist);
            //上传history数据
            List<UploadInfo> uploadList = new List<UploadInfo>();
            if (PingTask.IsConnected)
            {
                ZcOrderHistoryService masterhistoryService = new ZcOrderHistoryService();
                ZcOrderHistoryItemService masterHistoryItemService = new ZcOrderHistoryItemService();
                masterhistoryService.AddZcOrderHistory(history);
                masterHistoryItemService.AddZcOrderHistoryItem(historyItemlist);
            }
            else
            {
                UploadInfo obj1 = new UploadInfo();
                obj1.Id = history.Id;
                obj1.CreateTime = DateTime.Now;
                obj1.UpdateTime = DateTime.Now;
                obj1.Type = Constant.ZC_ORDER_HISTORY;
                uploadList.Add(obj1);
                foreach (ZcOrderHistoryItem obj in historyItemlist)
                {
                    UploadInfo obj2 = new UploadInfo();
                    obj2.Id = obj.Id;
                    obj2.CreateTime = DateTime.Now;
                    obj2.UpdateTime = DateTime.Now;
                    obj2.Type = Constant.ZC_ORDER_HISTORY_ITEM;
                    uploadList.Add(obj2);
                }
            }


            //删除本地transit相关表数据
            itemService.DeleteByOrderId(tran.Id);
            transitService.DeleteById(tran.Id);
            //上传transit删除信息
            if (PingTask.IsConnected)
            {
                ZcOrderTransitService masterTransitService = new ZcOrderTransitService();
                ZcOrderTransitItemService masterTransitItemService = new ZcOrderTransitItemService();
                masterTransitService.DeleteByOrderId(tran.Id);
                masterTransitItemService.DeleteByOrderId(tran.Id);
            }
            else
            {
                UploadInfo obj1 = new UploadInfo();
                obj1.Id = tran.Id;
                obj1.CreateTime = DateTime.Now;
                obj1.UpdateTime = DateTime.Now;
                obj1.Type = Constant.ZC_ORDER_TRANSIT_DELETE;
                uploadList.Add(obj1);

                UploadInfo obj2 = new UploadInfo();
                obj2.Id = tran.Id;
                obj2.CreateTime = DateTime.Now;
                obj2.UpdateTime = DateTime.Now;
                obj2.Type = Constant.ZC_ORDER_TRANSIT_ITEM_DELETE;
                uploadList.Add(obj1);

            }

            ///添加拒收明细
            BranchZcOrderRefuseService refuseService = new BranchZcOrderRefuseService();
            BranchZcOrderRefuseItemService refuseItemService = new BranchZcOrderRefuseItemService();
            refuseService.AddZcOrderRefuse(refuse);
            refuseItemService.AddZcOrderRefuseItems(list);

            //上传拒收信息
            if (PingTask.IsConnected)
            {
                ZcOrderRefuseService masterRefuseService = new ZcOrderRefuseService();
                ZcOrderRefuseItemService masterRefuseItemService = new ZcOrderRefuseItemService();
                masterRefuseService.AddZcOrderRefuse(refuse);
                masterRefuseItemService.AddZcOrderRefuseItem(list);
            }
            else
            {
                UploadInfo obj1 = new UploadInfo();
                obj1.Id = refuse.id;
                obj1.CreateTime = DateTime.Now;
                obj1.UpdateTime = DateTime.Now;
                obj1.Type = Constant.ZC_ORDER_REFUSE;
                uploadList.Add(obj1);
                foreach (ZcOrderRefuseItem obj in list)
                {
                    UploadInfo obj2 = new UploadInfo();
                    obj2.Id = obj.id;
                    obj2.CreateTime = DateTime.Now;
                    obj2.UpdateTime = DateTime.Now;
                    obj2.Type = Constant.ZC_ORDER_REFUSE_ITEM;
                    uploadList.Add(obj2);
                }
            }

            UploadDao uploadDao = new UploadDao();
            uploadDao.AddUploadInfo(uploadList);
        }

        /// <summary>
        /// 全部收取，没有拒收
        /// </summary>
        public void saveAllPay(string orderstatus)
        {
            BranchZcOrderTransitService transitService = new BranchZcOrderTransitService();
            ZcOrderTransit tran = transitService.FindById(id_.Text.ToString());
            BranchZcOrderTransitItemService itemService = new BranchZcOrderTransitItemService();
            List<ZcOrderTransitItem> transitItemlist = itemService.FindByOrderId(tran.Id);
            BranchZcOrderHistoryItemService historyItemService = new BranchZcOrderHistoryItemService();
            BranchZcOrderHistoryService historyService = new BranchZcOrderHistoryService();
            tran.OrderStatus = orderstatus;
            ZcOrderHistory history = ZcOrderHelper.Tranform(tran);
            List<ZcOrderHistoryItem> historyItemlist = ZcOrderHelper.Transform(transitItemlist);
            history.ActualMoney = actualTotalMoney;
            history.ActualNums = totalSum.Text;
            for (int i = 0; i < itemDataGridView.RowCount; i++)
            {
                string goodsFileId = itemDataGridView[14, i].Value == null ? "" : itemDataGridView[14, i].Value.ToString();
                for (int j = 0; j < historyItemlist.Count; j++)
                {
                    ZcOrderHistoryItem item = historyItemlist[j];
                    if (goodsFileId.Equals(item.GoodsFileId))
                    {
                        item.actualNums = itemDataGridView[4, i].Value == null ? "0" : itemDataGridView[4, i].Value.ToString();
                        item.actualMoney = itemDataGridView[7, i].Value == null ? "" : itemDataGridView[7, i].Value.ToString();
                    }
                }
            }
            historyService.AddZcOrderHistory(history);
            historyItemService.AddZcOrderHistoryItem(historyItemlist);

            //上传history数据
            List<UploadInfo> uploadList = new List<UploadInfo>();
            if (PingTask.IsConnected)
            {
                ZcOrderHistoryService masterhistoryService = new ZcOrderHistoryService();
                ZcOrderHistoryItemService masterHistoryItemService = new ZcOrderHistoryItemService();
                masterhistoryService.AddZcOrderHistory(history);
                masterHistoryItemService.AddZcOrderHistoryItem(historyItemlist);
            }
            else
            {
                UploadInfo obj1 = new UploadInfo();
                obj1.Id = history.Id;
                obj1.CreateTime = DateTime.Now;
                obj1.UpdateTime = DateTime.Now;
                obj1.Type = Constant.ZC_ORDER_HISTORY;
                uploadList.Add(obj1);
                foreach (ZcOrderHistoryItem obj in historyItemlist)
                {
                    UploadInfo obj2 = new UploadInfo();
                    obj2.Id = obj.Id;
                    obj2.CreateTime = DateTime.Now;
                    obj2.UpdateTime = DateTime.Now;
                    obj2.Type = Constant.ZC_ORDER_HISTORY_ITEM;
                    uploadList.Add(obj2);
                }
            }

            itemService.DeleteByOrderId(tran.Id);
            transitService.DeleteById(tran.Id);
            //上传transit删除信息
            if (PingTask.IsConnected)
            {
                ZcOrderTransitService masterTransitService = new ZcOrderTransitService();
                ZcOrderTransitItemService masterTransitItemService = new ZcOrderTransitItemService();
                masterTransitService.DeleteByOrderId(tran.Id);
                masterTransitItemService.DeleteByOrderId(tran.Id);
            }
            else
            {
                UploadInfo obj1 = new UploadInfo();
                obj1.Id = tran.Id;
                obj1.CreateTime = DateTime.Now;
                obj1.UpdateTime = DateTime.Now;
                obj1.Type = Constant.ZC_ORDER_TRANSIT_DELETE;
                uploadList.Add(obj1);

                UploadInfo obj2 = new UploadInfo();
                obj2.Id = tran.Id;
                obj2.CreateTime = DateTime.Now;
                obj2.UpdateTime = DateTime.Now;
                obj2.Type = Constant.ZC_ORDER_TRANSIT_ITEM_DELETE;
                uploadList.Add(obj1);

            }
            UploadDao uploadDao = new UploadDao();
            uploadDao.AddUploadInfo(uploadList);

        }

        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 实际付款金额
        /// </summary>
        private float actualPayAmount;

        /// <summary>
        /// 打印小票
        /// </summary>
        /// <param name="p"></param>
        public void printTicket(float p)
        {
            actualPayAmount = p;

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            PrintDocument pd = new PrintDocument();
            //设置边距

            Margins margin = new Margins(5, 5, 5, 5);

            pd.DefaultPageSettings.Margins = margin;
            ////纸张设置默认

            PaperSize pageSize = new PaperSize("First custom size", getYc(60), 600);

            
            pd.DefaultPageSettings.PaperSize = pageSize;


            //打印事件设置            


            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
            try
            {
                ppd.Document = pd;

                ppd.ShowDialog();
                pd.Print();
                ///打印完成后再进行初始化数据
            }

            catch (Exception ex)
            {

                log.Error("打印出错，检查打印机是否连通", ex);
                MessageBox.Show("付款成功,打印出错,请检查打印机是否正确连接!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                initData();
            }
        }

        private int getYc(double cm)
        {

            return (int)(cm / 25.4) * 100;

        }

        public string GetPrintStr()
        {

            StringBuilder sb = new StringBuilder();

            string tou = "宜鲜美配送有限公司";

            string address = "南京市江宁区东麒路66号";

            string saleID = id_.Text;

            //string item = "品名";

            //decimal price = 25.00M;

            //int count = 5;

            //decimal total = 0.00M;

            //decimal fukuan = 500.00M;



            sb.Append("            " + tou + "     \n");

            sb.Append("-----------------------------------------------------------------\n");

            sb.Append("日期:" + DateTime.Now.ToShortDateString() + "  " + "单号:" + id_.Text + "\n");

            sb.Append("-----------------------------------------------------------------\n");

            sb.Append("品名" + "\t\t" + "单价" + "\t" + "重量/数量" + "\t" + "小计" + "\n");
            //for (int i = 0; i < itemDataGridView.RowCount; i++)
            //{
            //    int actualnums = itemDataGridView[4, i].Value == null ? 0 : Convert.ToInt32(itemDataGridView[4, i].Value);
            //    if (actualnums != 0)
            //    {
            //        string name = itemDataGridView[1, i].Value == null ? "" : itemDataGridView[1, i].Value.ToString();
            //        if (name.Length < 4)
            //        {
            //            name += "\t\t";
            //        }
            //        else if (name.Length <= 6)
            //        {
            //            name += "\t";
            //        }
            //        else
            //        {
            //            name = name.Substring(0, 6) + "... ";
            //        }
            //        string price = itemDataGridView[2, i].Value == null ? "" : itemDataGridView[2, i].Value.ToString();
            //        price = float.Parse(price).ToString("0.00");
            //        string amount = itemDataGridView[7, i].Value == null ? "" : itemDataGridView[7, i].Value.ToString();
            //        amount = float.Parse(amount).ToString("0.00");
            //        sb.Append(name + price + "\t" + actualnums + "\t" + amount + "\n");
            //    }
            //}
            for (int i = 0; i < printObjectlist.Count; i++ )
            {
                GoodsPrint obj = printObjectlist[i];
                string name = obj.Name;
                if (name.Length < 4)
                {
                    name += "\t\t";
                }
                else if (name.Length <= 6)
                {
                    name += "\t";
                }
                else
                {
                    name = name.Substring(0, 6) + "... ";
                }
                if (obj.SerialNumber.StartsWith("28"))
                {
                    sb.Append(name + obj.Price.ToString("0.00") + "\t" + obj.Weight.ToString("0.000") + obj.Unit + "\t" + (obj.Price * obj.Weight).ToString("0.00") + "\n");
                }
                else
                {
                    sb.Append(name + obj.Price.ToString("0.00") + "\t" + obj.Nums + obj.Unit + "\t" + (obj.Price*obj.Nums).ToString("0.00") + "\n");
                }
               
            }

            //for (int i = 0; i < count; i++)
            //{

            //    decimal xiaoji = (i + 1) * price;

            //    sb.Append(item + (i + 1) + "\t\t" + (i + 1) + "\t" + price + "\t" + xiaoji);

            //    total += xiaoji;



            //    if (i != (count))

            //        sb.Append("\n");

            //}



            sb.Append("-----------------------------------------------------------------\n");

            sb.Append("数量: " + totalSum.Text + "\t\t 合计: " + totalAmount.Text + "\n");

            sb.Append("实际付款金额:" + " " + actualPayAmount + "\n");

            //sb.Append("         现金找零:" + "   " + (fukuan - total) + "\n");

            sb.Append("-----------------------------------------------------------------\n");

            sb.Append("地址：" + address + "\n");

            sb.Append("电话：" + inform_label.Text + "\n");


            sb.Append("             谢谢惠顾欢迎下次光临                ");
            //log.Error(sb.ToString()+"--------->");
            return sb.ToString();

        }

        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SetInvoiceData(e.Graphics);
        }

        private void SetInvoiceData(Graphics g)
        {
            Font InvoiceFont = new Font("Arial", 7, FontStyle.Bold);
            SolidBrush GrayBrush = new SolidBrush(Color.Black);
            g.DrawString(GetPrintStr(), InvoiceFont, GrayBrush, 10, 10);
            g.Dispose();
        }

        private void itemInputButton_Click(object sender, EventArgs e)
        {
            if (itemInputPanel.Visible == true)
            {
                //MessageBox.Show("true");
                itemInputPanel.Hide();
                itemInputButton.Text = "显示按键";
            }
            else
            {
                //MessageBox.Show("false");
                itemInputPanel.Show();
                itemInputButton.Text = "隐藏按键";
            }
        }

        private string addOrReduceFlag = "add";

        private void addReduceButton_Click(object sender, EventArgs e)
        {
            if ("add".Equals(addOrReduceFlag))
            {
                addReduceButton.Text = "减（-）";
                addOrReduceFlag = "reduce";
            }
            else if ("reduce".Equals(addOrReduceFlag))
            {
                addReduceButton.Text = "加（+）";
                addOrReduceFlag = "add";
            }
        }
    }
}
