using Branch.com.proem.exm.util;
using Branch.com.proem.exm.window.order;
using Branch.com.proem.exm.window.receive;
using Branch.com.proem.exm.window.retreat;
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
    public partial class ItemInput : Form
    {
        private readonly ILog log = null;

        private DeliveryGoods deliveryGoods;
        private ReturnGoods returnGoods;
        private CustomerDelivery customerDelivery;

        /// <summary>
        /// 商品匹配的记录数
        /// </summary>
        private int item = 0;
        /// <summary>
        /// 当前传入的页面
        /// </summary>
        private string count = "";

        public ItemInput()
        {
            InitializeComponent();
        }

        public ItemInput(DeliveryGoods obj, ILog log)
        {
            InitializeComponent();
            this.deliveryGoods = obj;
            this.log = log;
            this.count = ParentWindow.DeliveryGoods.ToString();
        }

        public ItemInput(ReturnGoods obj, ILog log)
        {
            InitializeComponent();
            this.returnGoods = obj;
            this.log = log;
            this.count = ParentWindow.ReturnGoods.ToString();
        }

        public ItemInput(CustomerDelivery obj, ILog log)
        {
            InitializeComponent();
            this.customerDelivery = obj;
            this.log = log;
            this.count = ParentWindow.CustomerDelivery.ToString();
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

        public bool sureflag = false;

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (sureflag)
            {
                string num = numberTextBox.Text;
                if (count.Equals(ParentWindow.DeliveryGoods.ToString()))
                {
                    deliveryGoods.itemInput(num);
                }
                else if (count.Equals(ParentWindow.ReturnGoods.ToString()))
                {
                    returnGoods.itemInput(num);
                }
                else if (count.Equals(ParentWindow.CustomerDelivery.ToString()))
                {
                    customerDelivery.itemInput(num);
                }
                numberTextBox.Text = "";
                sureflag = false;
                return;
            }
            string bar = numberTextBox.Text;
            numberTextBox.Text = "";
            string good_id = null;
            string good_num = null;
            string good_wei = null;
            if (bar.Length == 18)
            {
                good_id = bar.Substring(2, 5);
                good_num = bar.Substring(7, 5);
                good_wei = bar.Substring(12, 5);
                //MessageBox.Show("good_id:" + good_id + ";good_num:" + good_num + ";good_wei:" + good_wei + ";bar:" + bar);
                
            }
            else
            {
                good_id = bar;
            }
            QueryGoods query = null;
            if (this.count.Equals(ParentWindow.DeliveryGoods.ToString()))
            {
                deliveryGoods.setbar(good_id, good_num, good_wei);
                query = new QueryGoods(deliveryGoods, good_id, "1");
            }
            else if (this.count.Equals(ParentWindow.ReturnGoods.ToString()))
            {
                query = new QueryGoods(returnGoods, good_id, "1");
            }
            else if (this.count.Equals(ParentWindow.CustomerDelivery.ToString()))
            {
                customerDelivery.setbar(good_id, good_num, good_wei);
                query = new QueryGoods(customerDelivery, good_id, "1");
            }
            item = query.queryExistGood(log);//查询后获得
            if (item == 0)
            {
                MessageBox.Show("商品不存在,请重新输入", "提示", MessageBoxButtons.OK);
            }
            else if (item == 1)
            {
                numberTextBox.Text = "";
            }
            else if (item > 1 && item < 50)
            {
                ScanGood scanGood = null;
                if (this.count.Equals(ParentWindow.DeliveryGoods.ToString()))
                {
                    scanGood = new ScanGood(deliveryGoods, good_id, "1");
                }
                else if (this.count.Equals(ParentWindow.ReturnGoods.ToString()))
                {
                    scanGood = new ScanGood(returnGoods, good_id, "1");
                }
                else if (this.count.Equals(ParentWindow.CustomerDelivery.ToString()))
                {
                    scanGood = new ScanGood(customerDelivery, good_id, "1");
                }

                scanGood.ShowDialog();
                numberTextBox.Text = "";
            }
            else if (item >= 50)
            {
                MessageBox.Show("匹配的商品记录数大于[50]条，请输入更多内容以减少匹配范围", "提示", MessageBoxButtons.OK);
            }
        }

        private void ItemInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (numberTextBox.Focused == false)
            {
                if (e.KeyCode == Keys.D1)
                {
                    oneButton_Click(this, EventArgs.Empty);
                }
                if (e.KeyCode == Keys.D2)
                {
                    twoButton_Click(this, EventArgs.Empty);
                }
                if (e.KeyCode == Keys.D3)
                {
                    threeButton_Click(this, EventArgs.Empty);
                }
                if (e.KeyCode == Keys.D4)
                {
                    fourButton_Click(this, EventArgs.Empty);
                }
                if (e.KeyCode == Keys.D5)
                {
                    fiveButton_Click(this, EventArgs.Empty);
                }
                if (e.KeyCode == Keys.D6)
                {
                    sixButton_Click(this, EventArgs.Empty);
                }
                if (e.KeyCode == Keys.D7)
                {
                    sevenButton_Click(this, EventArgs.Empty);
                }
                if (e.KeyCode == Keys.D8)
                {
                    eightButton_Click(this, EventArgs.Empty);
                }
                if (e.KeyCode == Keys.D9)
                {
                    nineButton_Click(this, EventArgs.Empty);
                }
                if (e.KeyCode == Keys.D0)
                {
                    zeroButton_Click(this, EventArgs.Empty);
                }
                if (e.KeyCode == Keys.Back)
                {
                    backButton_Click(this, EventArgs.Empty);
                }

                if ((e.KeyValue >= 'A' && e.KeyValue <= 'Z') || (e.KeyValue >= 'a' && e.KeyValue <= 'z'))
                {
                    numberTextBox.Text += e.KeyCode.ToString();
                }
                
            }
            if (e.KeyCode == Keys.Enter)
            {
                equalButton_Click(this, EventArgs.Empty);
            }
        }
    }
}