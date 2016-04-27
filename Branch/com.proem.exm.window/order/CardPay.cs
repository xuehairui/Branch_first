using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.service.branch;
using Branch.com.proem.exm.util;
using Branch.com.proem.exm.service.master;

namespace Branch.com.proem.exm.window.order
{
    public partial class CardPay : Form
    {
        /// <summary>
        /// 易宝卡号
        /// </summary>
        public string memberCardId;

        /// <summary>
        /// 订单号
        /// </summary>
        public string orderId;
        /// <summary>
        /// 应收金额
        /// </summary>
        public string needMoney;

        public PayForm payForm;

        bool clFlag = false;

        public CardPay()
        {
            InitializeComponent();
        }

        private void CardPay_Load(object sender, EventArgs e)
        {
            textBox3.Text = memberCardId;
            textBox2.Text = needMoney;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /// <summary>
        /// 确定支付
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Equals(""))
            {
                textBox4.Text = "0";
            }
            if (textBox4.Text.StartsWith("."))
            {
                textBox4.Text = "0" + textBox4.Text;
            }
            if (textBox4.Text.EndsWith("."))
            {
                textBox4.Text = textBox4.Text + "0";
            }
            PayInfo obj = new PayInfo();
            obj.Id = Guid.NewGuid().ToString();
            obj.CreateTime = DateTime.Now;
            obj.UpdateTime = DateTime.Now;
            obj.PayAmount = textBox4.Text;
            obj.orderId = orderId;
            obj.salesmanId = LoginUserInfo.id;
            obj.payDate = DateTime.Now;
            obj.PayMode = BranchPay.card;
            obj.MemberId = memberCardId;
            obj.BranchId = LoginUserInfo.branchId;

            //BranchPayInfoService service = new BranchPayInfoService();
            //service.AddPayInfo(obj);
            ////上传支付信息
            //PayInfoService masterPayInfoService = new PayInfoService();
            //masterPayInfoService.AddPayInfo(obj);

            this.payForm.AddPayInfo(obj);

            payForm.AddPaidAmount(textBox4.Text);
            clFlag = true;
            this.Close();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                int count = 0;
                foreach (char c in textBox4.Text)
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
                if (textBox4.Text.IndexOf(".") > -1)
                {
                    string[] str = textBox4.Text.Split('.');
                    //已经有小数点2位了则取消输入
                    if (str[1].Length > 1)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.IndexOf(".") > -1)
            {
                string[] str = textBox4.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            textBox4.Text += "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.IndexOf(".") > -1)
            {
                string[] str = textBox4.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            textBox4.Text += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.IndexOf(".") > -1)
            {
                string[] str = textBox4.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            textBox4.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.IndexOf(".") > -1)
            {
                string[] str = textBox4.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            textBox4.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.IndexOf(".") > -1)
            {
                string[] str = textBox4.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            textBox4.Text += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.IndexOf(".") > -1)
            {
                string[] str = textBox4.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            textBox4.Text += "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.IndexOf(".") > -1)
            {
                string[] str = textBox4.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            textBox4.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.IndexOf(".") > -1)
            {
                string[] str = textBox4.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            textBox4.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.IndexOf(".") > -1)
            {
                string[] str = textBox4.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            textBox4.Text += "9";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.IndexOf(".") > -1)
            {
                string[] str = textBox4.Text.Split('.');
                //已经有小数点2位了则取消输入
                if (str[1].Length > 1)
                {
                    return;
                }
            }
            textBox4.Text += "0";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char c in textBox4.Text)
            {
                if (c == '.')
                {
                    count++;
                }
            }
            if (count < 1)
            {
                textBox4.Text += ".";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
            {
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1, 1);
            }
        }

        private void CardPay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!clFlag)
            {
                if (MessageBox.Show("是否确定退出易宝卡支付界面？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
