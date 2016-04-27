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

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///商品描述, 总金额 , 二维码, 订单号
            WxPayData result = MicroPay.Run(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            if ("SUCCESS".Equals(result.GetValue("result_code")) && "SUCCESS".Equals(result.GetValue("return_code")))
            {
                MessageBox.Show("微信支付成功!");
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

        /// <summary>
        /// 退款
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            WxPayData result = Refund.Run(null, textBox4.Text, "1", "1");
            if ("SUCCESS".Equals(result.GetValue("result_code")))
            {
                MessageBox.Show("微信支付退款成功!");
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
    }
}
