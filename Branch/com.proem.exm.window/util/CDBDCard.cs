using Branch.com.proem.exm.util;
using Branch.com.proem.exm.window.order;
using MySql.Data.MySqlClient;
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
    /// 会员卡支付
    /// </summary>
    public partial class CDBDCard : Form
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
        /// <summary>
        /// 卡内金额
        /// </summary>
        private string associator_amount = null;

        public CDBDCard()
        {
            InitializeComponent();
        }

        public CDBDCard(CustomerDelivery obj, float totalAmountValue, string associator_amount)
        {
            InitializeComponent();
            this.customerDelivery = obj;
            this.totalAmountValue = totalAmountValue;
            this.associator_amount = associator_amount;
        }

        private void CDBDCard_Load(object sender, EventArgs e)
        {
            this.needTextBox.Text = totalAmountValue.ToString();
            this.cardsumTextBox.Text = associator_amount;
            if (totalAmountValue > float.Parse(associator_amount))
            {
                alreadyTextBox.Text = cardsumTextBox.Text;
            }
            else
            {
                alreadyTextBox.Text = needTextBox.Text;
            }
        }

        private void alreadyTextBox_TextChanged(object sender, EventArgs e)
        {
            alreadyAmount = float.Parse(alreadyTextBox.Text);
        }

        private void alreadyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
