using Branch.com.proem.exm.window.order;
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
    /// 现金支付
    /// </summary>
    public partial class CDBDMoney : Form
    {
        private CustomerDelivery customerDelivery;
        /// <summary>
        /// 金额合计
        /// </summary>
        private float totalAmountValue = 0;
        /// <summary>
        /// 支付的金额
        /// </summary>
        public float alreadyAmount = 0;

        public CDBDMoney()
        {
            InitializeComponent();
        }

        public CDBDMoney(CustomerDelivery obj, float totalAmountValue)
        {
            InitializeComponent();
            this.customerDelivery = obj;
            this.totalAmountValue = totalAmountValue;
        }

        private void CDBDMoney_Load(object sender, EventArgs e)
        {
            this.needTextBox.Text = totalAmountValue.ToString();
        }

        private void needTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void alreadyTextBox_TextChanged(object sender, EventArgs e)
        {
            alreadyAmount = float.Parse(alreadyTextBox.Text);
        }

        private void changeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (payTextBox.Text == "")
            {
                payTextBox.Text = "0";
                //MessageBox.Show((float.Parse(payTextBox.Text) - float.Parse(changeTextBox.Text)).ToString());
            }
            alreadyTextBox.Text = Math.Round((float.Parse(payTextBox.Text) - float.Parse(changeTextBox.Text)), 2).ToString();
            
        }
        
        private void payTextBox_TextChanged(object sender, EventArgs e)
        {
            if (payTextBox.Text == "")
            {
                payTextBox.Text = "0";
            }
            if ((float.Parse(payTextBox.Text) - float.Parse(needTextBox.Text)) > 0)
            {
                changeTextBox.Text = Math.Round((float.Parse(payTextBox.Text) - float.Parse(needTextBox.Text)), 2).ToString();
            }
            else
            {
                changeTextBox.Text = "0";
            }
            alreadyTextBox.Text = Math.Round((float.Parse(payTextBox.Text) - float.Parse(changeTextBox.Text)), 2).ToString();
        }

        private void payTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void changeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
