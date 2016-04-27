using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.service.branch;
using Branch.com.proem.exm.service.master;
using Branch.com.proem.exm.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WxPayAPI;

namespace Branch.com.proem.exm.window.order
{
    public partial class WxPayForm : Form
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

        public WxPayForm()
        {
            InitializeComponent();
        }

        public WxPayForm(string orderNumber, PayForm payForm, string money)
        {
            InitializeComponent();
            this.OrderNumber = orderNumber;
            this.payForm = payForm;
            this.needPayMoney = money;
        }

        private void WxPayForm_Load(object sender, EventArgs e)
        {
            ///默认焦点在二维码的输入框内
            payableTextbox.Text = float.Parse(needPayMoney).ToString("0.00");
            actualTextbox.Text = float.Parse(needPayMoney).ToString("0.00");
        }

        private void WxPayForm_KeyDown(object sender, KeyEventArgs e)
        {
            ///支付
            if(codeTextbox.Focused && !string.IsNullOrEmpty(codeTextbox.Text.Trim()) && e.KeyCode == Keys.Enter)
            {
                WxPay();
            }
        }

        private void WxPay()
        {
            string amount = actualTextbox.Text.Trim();
            if (string.IsNullOrEmpty(amount))
            {
                return;
            }
            else if (float.Parse(amount) == 0)
            {
                return;
            }
            else
            {
                amount = float.Parse(amount).ToString("0.00").Replace(".", "");
            }
            ///商品描述, 总金额 , 二维码, 订单号
            WxPayData result = MicroPay.Run(GoodsDetails, amount , codeTextbox.Text.Trim(), this.OrderNumber + "4");
            if ("SUCCESS".Equals(result.GetValue("result_code")) && "SUCCESS".Equals(result.GetValue("return_code")))
            {
                MessageBox.Show("微信支付成功!");
                PayInfo obj = new PayInfo();
                obj.Id = Guid.NewGuid().ToString();
                obj.CreateTime = DateTime.Now;
                obj.UpdateTime = DateTime.Now;
                obj.PayAmount = actualTextbox.Text.Trim();
                obj.orderId = this.OrderNumber;
                obj.salesmanId = LoginUserInfo.id;
                obj.payDate = DateTime.Now;
                obj.PayMode = BranchPay.WxPay;
                //obj.MemberId = memberCardId;
                obj.BranchId = LoginUserInfo.branchId;

                //BranchPayInfoService service = new BranchPayInfoService();
                //service.AddPayInfo(obj);
                ////上传支付信息
                //PayInfoService masterPayInfoService = new PayInfoService();
                //masterPayInfoService.AddPayInfo(obj);

                this.payForm.AddPayInfo(obj);

                payForm.AddPaidAmount(obj.PayAmount);

                clFlag = true;

                this.Close();
            }
            else if ("SUCCESS".Equals(result.GetValue("return_code")))
            {
                if (result.IsSet("err_code_des"))
                {
                    MessageBox.Show(result.GetValue("err_code_des").ToString());
                    return;
                }
                else
                {
                    MessageBox.Show("微信支付发生未知错误!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("微信支付通信失败,请检查网络!");
                return;
            }
        }

        private void WxPayForm_Activated(object sender, EventArgs e)
        {
            codeTextbox.Focus();
        }

        private void codeTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void actualTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                int count = 0;
                foreach (char c in actualTextbox.Text)
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
                if (actualTextbox.Text.IndexOf(".") > -1)
                {
                    string[] str = actualTextbox.Text.Split('.');
                    //已经有小数点2位了则取消输入
                    if (str[1].Length > 1)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        bool clFlag = false;

        private void WxPayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!clFlag)
            {
                if (MessageBox.Show("是否确定退出微信支付界面？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
