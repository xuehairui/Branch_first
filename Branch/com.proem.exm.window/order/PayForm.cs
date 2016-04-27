using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Branch.com.proem.exm.service.branch;
using Branch.com.proem.exm.util;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.service.master;
using WxPayAPI;
using Com.Alipay.Domain;
using Com.Alipay.Business;
using Com.Alipay;
using Branch.app_code;
using Com.Alipay.Model;
using Branch.com.proem.exm.dao.branch;

namespace Branch.com.proem.exm.window.order
{
    public partial class PayForm : Form
    {
        /// <summary>
        /// 支付信息列表
        /// </summary>
        private List<PayInfo> payList = new List<PayInfo>();

        /// <summary>
        /// 向支付信息列表添加数据
        /// </summary>
        public void AddPayInfo(PayInfo obj)
        {
            payList.Add(obj);
        }

        /// <summary>
        /// 合计金额
        /// </summary>
        public string totalAmount;

        /// <summary>
        /// 会员卡号
        /// </summary>
        public string memberCardId;

        /// <summary>
        /// 订单号
        /// </summary>
        public string orderId;

        /// <summary>
        /// 应付金额
        /// </summary>
        private float payableAmount;

        /// <summary>
        /// 已付金额
        /// </summary>
        private float paidAmount;

        /// <summary>
        /// 现金支付的金额
        /// </summary>
        private float cardpayment;

        /// <summary>
        /// 标识是部分拒收，还是直接结算
        /// 0，结算
        /// 1，部分拒收
        /// </summary>
        public int ModeFlag;

        /// <summary>
        /// 判断是否支付完成
        /// </summary>
        public bool flag;

        bool clFlag = false;

        public CustomerDelivery customerDelivery;

        public PayForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 易宝卡支付
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            CardPay cardPay = new CardPay();
            cardPay.memberCardId = memberCardId;
            cardPay.orderId = orderId;
            cardPay.payForm = this;
            cardPay.needMoney = (float.Parse(textBox4.Text) - float.Parse(textBox5.Text)).ToString();
            cardPay.ShowDialog();
        }

        /// <summary>
        /// 支付页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PayForm_Load(object sender, EventArgs e)
        {
            //cashTextbox.Focus();
            ///合计金额
            totalAmount = Convert.ToDouble(totalAmount).ToString("0.00");
            textBox1.Text = totalAmount;
            textBox2.Text = "0.00";
            ///合计-折扣
            float amount = float.Parse(this.totalAmount);
            int count = totalAmount.IndexOf(".");
            ///合计分舍去
            textBox3.Text = "0.0" + totalAmount.Substring(count + 2, 1);
            ///应付金额
            payableAmount = amount - float.Parse(textBox3.Text);
            textBox4.Text = payableAmount.ToString("0.00");
            cashTextbox.Text = payableAmount.ToString("0.00");
            ///已付金额
            paidAmount = 0;
            textBox5.Text = "0.00";
            ///找零金额
            textBox6.Text = "0.00";
        }

        /// <summary>
        /// 确定支付
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            ///1,支付信息的存储等
            ///2,调用结算界面的方法，存储信息，挪动历史订单信息
           
            
            customerDelivery.actualTotalMoney = textBox4.Text;

            if (paidAmount >= float.Parse(textBox4.Text))
            {
                flag = true;
                if (float.Parse(textBox4.Text) - this.cardpayment > 0)
                {
                    PayInfo obj = new PayInfo();
                    obj.Id = Guid.NewGuid().ToString();
                    obj.CreateTime = DateTime.Now;
                    obj.UpdateTime = DateTime.Now;
                    obj.PayAmount = (float.Parse(textBox4.Text) - this.cardpayment).ToString("0.00");
                    obj.orderId = orderId;
                    obj.salesmanId = LoginUserInfo.id;
                    obj.payDate = DateTime.Now;
                    obj.PayMode = BranchPay.money;
                    obj.MemberId = memberCardId;
                    obj.BranchId = LoginUserInfo.branchId;
                    AddPayInfo(obj);
                }
            }
            else
            {
                flag = false;
                cashTextbox.Text = (float.Parse(textBox4.Text) - paidAmount).ToString("0.00");
            }

            if (flag)
            {
                BranchPayInfoService payService = new BranchPayInfoService();

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
                    foreach(PayInfo obj in payList)
                    {
                        UploadInfo uploadInfo = new UploadInfo();
                        uploadInfo.Id = obj.Id;
                        uploadInfo.CreateTime = DateTime.Now;
                        uploadInfo.UpdateTime = DateTime.Now;
                        uploadInfo.Type = Constant.PAY_INFO;
                        list.Add(uploadInfo);
                    }
                    UploadDao uploadDao = new UploadDao();
                    uploadDao.AddUploadInfo(list);
                }
                

                MessageBox.Show("支付完成!");
                if (ModeFlag == 1)
                {
                    customerDelivery.saveRefuseInform(Constant.ORDER_STATUS_PART_REFUSE);
                }
                else
                {
                    customerDelivery.saveAllPay(Constant.ORDER_STATUS_FININSH);
                }
                clFlag = true;
                ///打印小票的代码
                ///start

                ///付款金额， 
                customerDelivery.printTicket(float.Parse(textBox4.Text));
                ///stop
                this.Close();
            }
            else
            {
                MessageBox.Show("支付尚未完成!", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }

        /// <summary>
        /// 取消支付
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            //if (paidAmount < payableAmount)
            //{
            //    DialogResult dr = MessageBox.Show("当前支付未完成,确定取消支付?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            //    if (dr == DialogResult.Yes)
            //    {
            //        this.Close();
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}
            this.Close();
        }

        /// <summary>
        /// 折让金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_CursorChanged(object sender, EventArgs e)
        {
            float discount = float.Parse(textBox2.Text);
            float amount = float.Parse(totalAmount) - discount;
            int count = amount.ToString("0.00").IndexOf(".");
            ///合计分舍去
            textBox3.Text = "0.0" + totalAmount.Substring(count + 1, 1);
            ///应付金额
            payableAmount = amount - float.Parse(textBox3.Text);
        }

        /// <summary>
        /// 其他支付完成后，修改已支付
        /// </summary>
        /// <param name="p"></param>
        public void AddPaidAmount(string p)
        {
            this.cardpayment += float.Parse(p);
            paidAmount += float.Parse(p);
            textBox5.Text = paidAmount.ToString("0.00");
            if (paidAmount >= float.Parse(textBox4.Text))
            {
                button3_Click(this, EventArgs.Empty);
            }
            else 
            {
                cashTextbox.Text = (float.Parse(textBox4.Text) - paidAmount).ToString("0.00");    
            }
        }

        private void PayForm_KeyDown(object sender, KeyEventArgs e)
        {
            ///输入完现金后按enter
            if(cashTextbox.Focused == true && e.KeyCode == Keys.Enter)
            {
                equalButton_Click(this, EventArgs.Empty);
            }
        }

        private void PayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(paidAmount.ToString());
        }

        private void cashTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                int count = 0;
                foreach (char c in cashTextbox.Text)
                {
                    if (c == '.')
                    {
                        count++;
                    }
                }
                if (!(count < 1))
                {
                    e.Handled = true;
                }
            }
            if (e.KeyChar != '\b')
            {
                if (cashTextbox.Text.IndexOf(".") > -1)
                {
                    string[] str = cashTextbox.Text.Split('.');
                    //已经有小数点2位了则取消输入
                    if (str[1].Length > 1)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (float.Parse(textBox5.Text) > float.Parse(textBox4.Text))
            {
                cashTextbox.ReadOnly = true;
                button2.Enabled = false;
                itemInputPanel.Enabled = false;
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            //bool flag = true;
            //if (cashTextbox.Text.IndexOf(".") > -1)
            //{
            //    string[] str = cashTextbox.Text.Split('.');
            //    //已经有小数点2位了则取消输入
            //    if (str[1].Length > 1)
            //    {
            //        flag = false;
            //    }
            //}
            //if (!flag)
            //{
            //    return;
            //}
            if (cashTextbox.Text.IndexOf(".") > -1)
            {
                string[] str = cashTextbox.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            cashTextbox.Text += "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (cashTextbox.Text.IndexOf(".") > -1)
            {
                string[] str = cashTextbox.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            cashTextbox.Text += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (cashTextbox.Text.IndexOf(".") > -1)
            {
                string[] str = cashTextbox.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            cashTextbox.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (cashTextbox.Text.IndexOf(".") > -1)
            {
                string[] str = cashTextbox.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            cashTextbox.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (cashTextbox.Text.IndexOf(".") > -1)
            {
                string[] str = cashTextbox.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            cashTextbox.Text += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (cashTextbox.Text.IndexOf(".") > -1)
            {
                string[] str = cashTextbox.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            cashTextbox.Text += "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (cashTextbox.Text.IndexOf(".") > -1)
            {
                string[] str = cashTextbox.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            cashTextbox.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (cashTextbox.Text.IndexOf(".") > -1)
            {
                string[] str = cashTextbox.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            cashTextbox.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (cashTextbox.Text.IndexOf(".") > -1)
            {
                string[] str = cashTextbox.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            cashTextbox.Text += "9";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (cashTextbox.Text.IndexOf(".") > -1)
            {
                string[] str = cashTextbox.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            cashTextbox.Text += "0";
        }

        private void zeroZeroButton_Click(object sender, EventArgs e)
        {
            if (cashTextbox.Text.IndexOf(".") > -1)
            {
                string[] str = cashTextbox.Text.Split('.');
                //已经有小数1位了则取消输入
                if (str[1].Length > 0)
                {
                    return;
                }
            }
            cashTextbox.Text += "00";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char c in cashTextbox.Text)
            {
                if (c == '.')
                {
                    count++;
                }
            }
            if (count < 1)
            {
                cashTextbox.Text += ".";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (cashTextbox.Text.Length > 0)
            {
                cashTextbox.Text = cashTextbox.Text.Remove(cashTextbox.Text.Length - 1, 1);
            }
        }

        private void clearBotton_Click(object sender, EventArgs e)
        {
            cashTextbox.Text = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (cashTextbox.Text.Equals(""))
            {
                cashTextbox.Text = "0";
            }
            if (cashTextbox.Text.StartsWith("."))
            {
                cashTextbox.Text = "0" + cashTextbox.Text;
            }
            if (cashTextbox.Text.EndsWith("."))
            {
                cashTextbox.Text = cashTextbox.Text + "0";
            }
            float change = float.Parse(cashTextbox.Text) - float.Parse(textBox4.Text);
            if (change > 100)
            {//
                MessageBox.Show("找零金额不得大于100！");
                return;
            }

            float cash = float.Parse(cashTextbox.Text);

            

            //this.cardpayment = paidAmount;
            paidAmount += cash;
            textBox5.Text = paidAmount.ToString("0.00");
            //if (paidAmount >= payableAmount)
            if (paidAmount >= float.Parse(textBox4.Text))
            {
                //textBox6.Text = (paidAmount - payableAmount).ToString("0.00");
                textBox6.Text = (paidAmount - float.Parse(textBox4.Text)).ToString("0.00");
                flag = true;
                button3_Click(this, EventArgs.Empty);
                cashTextbox.Text = "0.00";
            }
            else
            {
                flag = false;
                cashTextbox.Text = (float.Parse(textBox4.Text) - paidAmount).ToString("0.00");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = (float.Parse(textBox1.Text) - float.Parse(textBox2.Text)).ToString("0.00");
        }

        private void PayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!clFlag)
            {
                if (MessageBox.Show("是否确定退出支付界面？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                { 
                    ///退出付款之前，需要进行退款
                    ///1现金返还
                    ///2易宝支付返还
                    ///3微信支付返还
                    foreach(PayInfo obj in payList)
                    {
                        if(obj.PayMode == BranchPay.WxPay)
                        {
                            string amount = float.Parse(obj.PayAmount).ToString("0.00").Replace(".", "");
                            WxPayData result = Refund.Run(null, obj.orderId + "4", amount, amount);
                            if ("SUCCESS".Equals(result.GetValue("result_code")))
                            {
                                //MessageBox.Show("微信支付退款成功!");
                            }
                            else
                            {
                                if (result.IsSet("err_code_des"))
                                {
                                    MessageBox.Show(result.GetValue("err_code_des").ToString());
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("未知错误!");
                                    return;
                                }

                            }
                        }
                        if (obj.PayMode == BranchPay.ZFBPay)
                        {
                            string amount = float.Parse(obj.PayAmount).ToString("0.00").Replace(".", "");
                            string id = obj.orderId;
                            ZFBPayRefund(amount,id);
                        }
                    }
                }
            }
        }


        string result = "";
        IAlipayTradeService serviceClient = F2FBiz.CreateClientInstance(Config.serverUrl, Config.appId, Config.merchant_private_key, Config.version,
                             Config.sign_type, Config.alipay_public_key, Config.charset);

        private void ZFBPayRefund(string amount,string id)
        {
            AlipayTradeRefundContentBuilder builder = BuildContent(amount, id);
            AlipayF2FRefundResult refundResult = serviceClient.tradeRefund(builder);

            switch (refundResult.Status)
            {
                case ResultEnum.SUCCESS:
                    DoSuccessProcess(refundResult);
                    break;
                case ResultEnum.FAILED:
                    DoFailedProcess(refundResult);
                    break;
                case ResultEnum.UNKNOWN:
                    //if (refundResult.response == null)
                    //{
                    //    result = "配置或网络异常，请检查";
                    //}
                    //else
                    //{
                    //    result = "系统异常，请走人工退款流程";
                    //}
                    break;
            }

            MessageBox.Show("" + result);
        }

        private AlipayTradeRefundContentBuilder BuildContent(string amount, string id)
        {

            AlipayTradeRefundContentBuilder builder = new AlipayTradeRefundContentBuilder();
            ////支付宝交易号与商户网站订单号不能同时为空
            //builder.out_trade_no = WIDout_trade_no.Text.Trim();
            builder.out_trade_no = id;
            //退款请求单号保持唯一性。
            builder.out_request_no = id;
            //退款金额
            builder.refund_amount = amount;
            builder.refund_reason = "refund reason";

            return builder;
        }

        private void DoSuccessProcess(AlipayF2FRefundResult refundResult)
        {
            //请添加退款成功后的处理

        }

        private void DoFailedProcess(AlipayF2FRefundResult refundResult)
        {
            //请添加退款失败后的处理

        }

        /// <summary>
        /// 微信支付
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wxPayButton_Click(object sender, EventArgs e)
        {
            if(! PingTask.IsConnected)
            {
                MessageBox.Show("当前网络不通,无法进行微信支付,请使用现金支付", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string needMoney = (float.Parse(textBox4.Text) - float.Parse(textBox5.Text)).ToString();
            WxPayForm wxPayForm = new WxPayForm(orderId, this, needMoney);
            wxPayForm.ShowDialog();
        }

        /// <summary>
        /// 支付宝支付
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZFBPayButton_Click(object sender, EventArgs e)
        {
            if(! PingTask.IsConnected)
            {
                MessageBox.Show("当前网络不通,无法进行支付宝支付,请使用现金支付", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string needMoney = (float.Parse(textBox4.Text) - float.Parse(textBox5.Text)).ToString();
            //ZFBPay zFBPay = new ZFBPay();
            ZFBPay zFBPay = new ZFBPay(orderId, this, needMoney);
            zFBPay.ShowDialog();
        }

        /// <summary>
        /// 初始化焦点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PayForm_Activated(object sender, EventArgs e)
        {
            cashTextbox.Focus();
        }
    }
}
 