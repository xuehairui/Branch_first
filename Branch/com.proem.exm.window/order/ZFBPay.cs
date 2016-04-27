using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Alipay.Domain;
using Com.Alipay;
using Com.Alipay.Business;
using Branch.app_code;
using Com.Alipay.Model;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;

namespace Branch.com.proem.exm.window.order
{
    public partial class ZFBPay : Form
    {
        private const string GoodsDetails = "宜鲜美平台订单";

        /// <summary>
        /// 订单号
        /// </summary>
        private string OrderNumber;

        /// <summary>
        /// 支付首页
        /// </summary>
        private PayForm payForm;

        /// <summary>
        /// 还需要支付的金额
        /// </summary>
        private string needPayMoney;

        public ZFBPay()
        {
            InitializeComponent();
        }

        public ZFBPay(string orderNumber, PayForm payForm, string money)
        {
            InitializeComponent();
            this.OrderNumber = orderNumber;
            this.payForm = payForm;
            this.needPayMoney = money;
        }

        private void ZFBPay_Load(object sender, EventArgs e)
        {
            textBox3.Text = float.Parse(needPayMoney).ToString("0.00");
            WIDtotal_fee.Text = float.Parse(needPayMoney).ToString("0.00");
        }

        //private LogHelper log = new LogHelper(AppDomain.CurrentDomain.BaseDirectory + "/log/log.txt");

        IAlipayTradeService serviceClient = F2FBiz.CreateClientInstance(Config.serverUrl, Config.appId, Config.merchant_private_key, Config.version,
                             Config.sign_type, Config.alipay_public_key, Config.charset);

        string result = "";

        /// <summary>
        /// 提交支付请求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sureButton_Click(object sender, EventArgs e)
        {
            string amount = WIDtotal_fee.Text.Trim();
            if (string.IsNullOrEmpty(amount)||float.Parse(amount) == 0)
            {
                MessageBox.Show("支付金额不可为0，请重新填写");
                return;
            }

            //
            AlipayTradePayContentBuilder builder = BuildPayContent();
            string out_trade_no = builder.out_trade_no;

            AlipayF2FPayResult payResult = serviceClient.tradePay(builder);

            switch (payResult.Status)
            {
                case ResultEnum.SUCCESS:
                    DoSuccessProcess(payResult);
                    break;
                case ResultEnum.FAILED:
                    DoFailedProcess(payResult);
                    break;
                case ResultEnum.UNKNOWN:
                    result = "网络异常，请检查网络配置后，更换外部订单号重试";
                    break;
            }
            MessageBox.Show("" + result);
        }
        
        private AlipayTradePayContentBuilder BuildPayContent()
        {
            //线上联调时，请输入真实的外部订单号。
            string out_trade_no = "";
            //if (String.IsNullOrEmpty(WIDout_request_no.Text.Trim()))
            if (String.IsNullOrEmpty(OrderNumber))
            {
                out_trade_no = System.DateTime.Now.ToString("yyyyMMddHHmmss") + "0000" + (new Random()).Next(1, 10000).ToString();
            }
            else
            {
                //out_trade_no = WIDout_request_no.Text.Trim();
                out_trade_no = OrderNumber;
            }

            //扫码枪扫描到的用户手机钱包中的付款条码
            AlipayTradePayContentBuilder builder = new AlipayTradePayContentBuilder();

            builder.out_trade_no = out_trade_no;
            builder.scene = "bar_code";
            builder.auth_code = WIDdynamic_id.Text.Trim();
            builder.total_amount = WIDtotal_fee.Text.Trim();
            builder.discountable_amount = WIDtotal_fee.Text.Trim();
            builder.undiscountable_amount = "0";
            builder.operator_id = "test";
            builder.subject = "条码支付";
            builder.timeout_express = "2m";
            builder.body = "订单描述";
            builder.store_id = "test store id";    //很重要的参数，可以用作之后的营销     
            builder.seller_id = Config.pid;       //可以是具体的收款账号。

            //传入商品信息详情
            List<GoodsInfo> gList = new List<GoodsInfo>();

            GoodsInfo goods = new GoodsInfo();
            goods.goods_id = "goods id";
            goods.goods_name = "goods name";
            goods.price = "0.01";
            goods.quantity = "1";
            gList.Add(goods);
            builder.goods_detail = gList;
            //扩展参数
            //系统商接入可以填此参数用作返佣
            //ExtendParams exParam = new ExtendParams();
            //exParam.sysServiceProviderId = "20880000000000";
            //builder.extendParams = exParam;

            return builder;

        }

        /// <summary>
        /// 请添加支付成功后的处理
        /// </summary>
        private void DoSuccessProcess(AlipayF2FPayResult payResult)
        {

            //请添加支付成功后的处理
            //System.Console.WriteLine("支付成功");
            //result = payResult.response.Body;

            MessageBox.Show("支付成功!");
            PayInfo obj = new PayInfo();
            obj.Id = Guid.NewGuid().ToString();
            obj.CreateTime = DateTime.Now;
            obj.UpdateTime = DateTime.Now;
            obj.PayAmount = WIDtotal_fee.Text.Trim();
            obj.orderId = this.OrderNumber;
            obj.salesmanId = LoginUserInfo.id;
            obj.payDate = DateTime.Now;
            obj.PayMode = BranchPay.ZFBPay;
            //obj.MemberId = memberCardId;
            obj.BranchId = LoginUserInfo.branchId;

            //BranchPayInfoService service = new BranchPayInfoService();
            //service.AddPayInfo(obj);
            ////上传支付信息
            //PayInfoService masterPayInfoService = new PayInfoService();
            //masterPayInfoService.AddPayInfo(obj);

            this.payForm.AddPayInfo(obj);

            payForm.AddPaidAmount(obj.PayAmount);

            this.Close();
        }

        private void DoFailedProcess(AlipayF2FPayResult payResult)
        {
            //请添加支付失败后的处理
            //System.Console.WriteLine("支付失败");
            //result = payResult.response.Body;

            MessageBox.Show("支付失败!");
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZFBPay_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ZFBPay_KeyDown(object sender, KeyEventArgs e)
        {
            if (WIDdynamic_id.Focused && e.KeyCode == Keys.Enter)
            {
                sureButton_Click(this, e);
            }
        }

        private void ZFBPay_Activated(object sender, EventArgs e)
        {
            WIDdynamic_id.Focus();
        }

        private void WIDtotal_fee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                int count = 0;
                foreach (char c in WIDtotal_fee.Text)
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
                if (WIDtotal_fee.Text.IndexOf(".") > -1)
                {
                    string[] str = WIDtotal_fee.Text.Split('.');
                    //已经有小数点2位了则取消输入
                    if (str[1].Length > 1)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void WIDdynamic_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

    }
}

