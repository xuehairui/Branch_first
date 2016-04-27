using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Branch.com.proem.exm.service;
using Branch.com.proem.exm.window.receive;
using Branch.com.proem.exm.util;
using Branch.com.proem.exm.window.retreat;
using Branch.com.proem.exm.service.main;
using Branch.com.proem.exm.window.systemsetting;
using Branch.com.proem.exm.window.order;
using System.Threading;
using Branch.com.proem.exm.window.util;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.service.branch;
using Branch.com.proem.exm.service.master;
using Branch.com.proem.exm.window.history;

namespace Branch.com.proem.exm.window.main
{
    /// <summary>
    /// 分店系统主页面
    /// </summary>
    public partial class BranchMain : Form
    {
        public BranchMain()
        {
            InitializeComponent();
        }

        private void deliveryGoodsButton_Click(object sender, EventArgs e)
        {
            //DownloadIdentifyService service = new DownloadIdentifyService();
            /////判断亭点是否收获
            //if(service.IsHarvest())
            //{
            //    MessageBox.Show("本亭点今天已经确认收货!");
            //    return;
            //}
            DeliveryGoods deliveryGoods = new DeliveryGoods(this);
            deliveryGoods.delivery += new DeliveryGoods.child_close(this.closethis);
            deliveryGoods.Show();//收货管理
            this.Hide();
        }

        private void returnGoodsButton_Click(object sender, EventArgs e)
        {
            ReturnGoods returnGoods = new ReturnGoods();
            returnGoods.Show();//扫码退货
            this.Hide();
        }

        private void customerDeliveryButton_Click(object sender, EventArgs e)
        {
            CustomerDelivery customerDelivery = new CustomerDelivery();
            customerDelivery.customer += new CustomerDelivery.child_close(this.closethis);
            customerDelivery.Show();//CustomerDelivery客户提货
            this.Hide();
            //OrderClearing订单结算
        }

        private void returnApplicationButton_Click(object sender, EventArgs e)
        {
            //ReturnApplication退货申请
        }

        private void memberManagementButton_Click(object sender, EventArgs e)
        {
            //MemberManagement会员管理
        }

        private void systemSettingsButton_Click(object sender, EventArgs e)
        {
            SystemSettings systemSettings = new SystemSettings();
            systemSettings.Show();//SystemSettings系统设置
            this.Hide();
        }

        private void inventoryControlButton_Click(object sender, EventArgs e)
        {
            //InventoryControl库存管理
        }

        private void historyInformButton_Click(object sender, EventArgs e)
        {//ContactHeadquarters联系总部
            HistoryInform historyInform = new HistoryInform();
            historyInform.history += new HistoryInform.child_close(this.closethis);
            historyInform.Show();//HistoryInform历史信息
            this.Hide();
        }

        private void BranchMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            //DialogResult result = MessageBox.Show("确定要退出系统吗？", "提示", MessageBoxButtons.OKCancel);
            //if (result == DialogResult.OK)
            //{
            //    Application.ExitThread();
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }

        /// <summary>
        /// 页面的load方法，判断是否需要加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BranchMain_Load(object sender, EventArgs e)
        {
            DownloadData();

            Times times = new Times();
            times.TopLevel = false;
            this.timePanel.Controls.Add(times);
            times.Show();

            inNameLabel.Text = LoginUserInfo.branchName;
            salesmanNameLabel.Text = LoginUserInfo.name;

            //branchHandover = new BranchHandover();

        }

        private void DownloadData()
        {
            DownloadIdentifyService service = new DownloadIdentifyService();
            if (!service.NeedDownload())
            {
                return;
            }
            /////更新最后一次下载时间
            //service.UpdateIdentify(DateTime.Now);
            /////更新亭点收货标识
            //service.UpdateHarvestFlag(Constant.HARVEST_NO);
            DownloadData p = new DownloadData();
            p.StartPosition = FormStartPosition.CenterScreen;
            p.Show();
        }

        //BranchHandover branchHandover = null;
        /// <summary>
        /// 是否已进行交班
        /// </summary>
        //bool flag = false;

        private void handoverButton_Click(object sender, EventArgs e)
        {
            BranchHandover branchHandover = new BranchHandover();
            branchHandover.ShowDialog();
            //交班
            exchangeWork();
            //flag = branchHandover.alreadyHandover;
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            //BranchDeliverAmountInfoService service = new BranchDeliverAmountInfoService();
            //DateTime first = DateTime.Today;
            //DateTime last = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 23:59:59"));
            //if (!service.isExist(first, last, LoginUserInfo.id))
            //{
            //    bool flag = false;
            //    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            //    DialogResult dr = MessageBox.Show("当前业务员尚未进行交班,是否立刻退出？", "提示", messButton);
            //    if (dr == DialogResult.OK)
            //    {
            //        flag = true;
            //    }
            //    if (flag)
            //    {
            //        //PingTask.flag = false;
            //        //Application.Exit();
            //        System.Environment.Exit(0);
            //    }
            //}
            //else
            //{
            //    System.Environment.Exit(0);
            //}
            System.Environment.Exit(0);
        }

        protected override void CreateHandle()
        {
            if (!IsHandleCreated)
            {
                try
                {
                    base.CreateHandle();
                }
                catch { }
                finally
                {
                    if (!IsHandleCreated)
                    {
                        base.RecreateHandle();
                    }
                }
            }
        }

        private void BranchMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && deliveryGoodsButton.Enabled == true)
            {
                deliveryGoodsButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.F2 && returnGoodsButton.Enabled == true)
            {
                returnGoodsButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.F3 && customerDeliveryButton.Enabled == true)
            {
                customerDeliveryButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.F4 && returnApplicationButton.Enabled == true)
            {
                returnApplicationButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.F5 && memberManagementButton.Enabled == true)
            {
                memberManagementButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.F6 && systemSettingsButton.Enabled == true)
            {
                systemSettingsButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.F7 && inventoryControlButton.Enabled == true)
            {
                inventoryControlButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.F8 && historyInformButton.Enabled == true)
            {
                historyInformButton_Click(this, EventArgs.Empty);
            }
            if (e.Control && e.KeyCode == Keys.H)
            {
                handoverButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.Escape)
            {
                leaveButton_Click(this, EventArgs.Empty);
            }
            //MessageBox.Show(e.KeyCode.ToString());
        }

        /// <summary>
        /// 交班
        /// </summary>
        private void exchangeWork()
        {
            BranchPayInfoService payService = new BranchPayInfoService();
            DateTime first = DateTime.Today;
            DateTime last = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 23:59:59"));
            string sum = payService.FindAmountCashier(first, last, LoginUserInfo.id);

            DeliverAmountInfo obj = new DeliverAmountInfo();
            obj.Id = Guid.NewGuid().ToString().Replace("-", "");
            obj.CreateTime = DateTime.Now;
            obj.UpdateTime = DateTime.Now;
            obj.AmountCashier = sum;
            obj.BranchId = LoginUserInfo.branchId;
            obj.Date = DateTime.Now;
            obj.Salesman = LoginUserInfo.id;
            ///保存交班信息到本地数据库
            BranchDeliverAmountInfoService branchService = new BranchDeliverAmountInfoService();
            branchService.AddDeliverAmountInfo(obj);
            ///上传交班信息到远处服务器
            DeliverAmountInfoService service = new DeliverAmountInfoService();
            service.AddDeliverAmountInfo(obj);
        }

        public void closethis()
        {
            this.Show();
        }

        private void deliveryGoodsButton_MouseEnter(object sender, EventArgs e)
        {
            deliveryGoodsButton.BackgroundImage = Branch.Properties.Resources.mk_01_press;
        }

        private void deliveryGoodsButton_MouseLeave(object sender, EventArgs e)
        {
            deliveryGoodsButton.BackgroundImage = Branch.Properties.Resources.mk_01;
        }

        private void returnGoodsButton_MouseEnter(object sender, EventArgs e)
        {
            returnGoodsButton.BackgroundImage = Branch.Properties.Resources.mk_02_press;
        }

        private void returnGoodsButton_MouseLeave(object sender, EventArgs e)
        {
            returnGoodsButton.BackgroundImage = Branch.Properties.Resources.mk_02;
        }

        private void customerDeliveryButton_MouseEnter(object sender, EventArgs e)
        {
            customerDeliveryButton.BackgroundImage = Branch.Properties.Resources.mk_03_press;
        }

        private void customerDeliveryButton_MouseLeave(object sender, EventArgs e)
        {
            customerDeliveryButton.BackgroundImage = Branch.Properties.Resources.mk_03;
        }

        private void returnApplicationButton_MouseEnter(object sender, EventArgs e)
        {
            returnApplicationButton.BackgroundImage = Branch.Properties.Resources.mk_04_press;
        }

        private void returnApplicationButton_MouseLeave(object sender, EventArgs e)
        {
            returnApplicationButton.BackgroundImage = Branch.Properties.Resources.mk_04;
        }

        private void memberManagementButton_MouseEnter(object sender, EventArgs e)
        {
            memberManagementButton.BackgroundImage = Branch.Properties.Resources.mk_05_press;
        }

        private void memberManagementButton_MouseLeave(object sender, EventArgs e)
        {
            memberManagementButton.BackgroundImage = Branch.Properties.Resources.mk_05;
        }

        private void systemSettingsButton_MouseEnter(object sender, EventArgs e)
        {
            systemSettingsButton.BackgroundImage = Branch.Properties.Resources.mk_06_press;
        }

        private void systemSettingsButton_MouseLeave(object sender, EventArgs e)
        {
            systemSettingsButton.BackgroundImage = Branch.Properties.Resources.mk_06;
        }

        private void inventoryControlButton_MouseEnter(object sender, EventArgs e)
        {
            inventoryControlButton.BackgroundImage = Branch.Properties.Resources.mk_07_press;
        }

        private void inventoryControlButton_MouseLeave(object sender, EventArgs e)
        {
            inventoryControlButton.BackgroundImage = Branch.Properties.Resources.mk_07;
        }

        private void historyInformButton_MouseEnter(object sender, EventArgs e)
        {
            historyInformButton.BackgroundImage = Branch.Properties.Resources.mk_08_press;
        }

        private void historyInformButton_MouseLeave(object sender, EventArgs e)
        {
            historyInformButton.BackgroundImage = Branch.Properties.Resources.mk_08;
        }
    }
}
