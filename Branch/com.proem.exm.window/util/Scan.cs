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
    /// <summary>
    /// 选择扫描
    /// </summary>
    public partial class Scan : Form
    {

        private readonly ILog log = LogManager.GetLogger(typeof(Scan));
        private DeliveryGoods deliveryGoods;
        private ReturnGoods returnGoods;
        private CustomerDelivery customerDelivery;
        private bool textbox_focus = true;

        /// <summary>
        /// 扫描的条码
        /// </summary>
        private string bar = "";
        /// <summary>
        /// 数量
        /// </summary>
        private string num = "";
        /// <summary>
        /// 商品匹配的记录数
        /// </summary>
        private int item = 0;
        /// <summary>
        /// 当前传入的页面
        /// </summary>
        private string count = "";

        public Scan()
        {
            InitializeComponent();
        }
        
        public Scan(DeliveryGoods obj)
        {
            InitializeComponent();
            this.deliveryGoods = obj;
            this.count = ParentWindow.DeliveryGoods.ToString();
        }

        public Scan(ReturnGoods obj)
        {
            InitializeComponent();
            this.returnGoods = obj;
            this.count = ParentWindow.ReturnGoods.ToString();
        }

        public Scan(CustomerDelivery obj)
        {
            InitializeComponent();
            this.customerDelivery = obj;
            this.count = ParentWindow.CustomerDelivery.ToString();
        }

        private void Scan_Load(object sender, EventArgs e)
        {

        }

        private void barCodeTextBox_Click(object sender, EventArgs e)
        {
            textbox_focus = true;
        }

        private void numberTextBox_Click(object sender, EventArgs e)
        {
            textbox_focus = false;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                barCodeTextBox.Text += "0";
            }
            else
            {
                numberTextBox.Text += "0";
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                barCodeTextBox.Text += "1";
            }
            else
            {
                numberTextBox.Text += "1";
            }
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                barCodeTextBox.Text += "2";
            }
            else
            {
                numberTextBox.Text += "2";
            }
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                barCodeTextBox.Text += "3";
            }
            else
            {
                numberTextBox.Text += "3";
            }
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                barCodeTextBox.Text += "4";
            }
            else
            {
                numberTextBox.Text += "4";
            }
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                barCodeTextBox.Text += "5";
            }
            else
            {
                numberTextBox.Text += "5";
            }
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                barCodeTextBox.Text += "6";
            }
            else
            {
                numberTextBox.Text += "6";
            }
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                barCodeTextBox.Text += "7";
            }
            else
            {
                numberTextBox.Text += "7";
            }
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                barCodeTextBox.Text += "8";
            }
            else
            {
                numberTextBox.Text += "8";
            }
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                barCodeTextBox.Text += "9";
            }
            else
            {
                numberTextBox.Text += "9";
            }
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                barCodeTextBox.Text += ".";
            }
            else
            {
                numberTextBox.Text += ".";
            }
        }

        private void dashButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                barCodeTextBox.Text += "-";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                if (barCodeTextBox.Text.Length > 0)
                {
                    barCodeTextBox.Text = barCodeTextBox.Text.Remove(barCodeTextBox.Text.Length - 1, 1);
                }
            }
            else
            {
                if (numberTextBox.Text.Length > 0)
                {
                    numberTextBox.Text = numberTextBox.Text.Remove(numberTextBox.Text.Length - 1, 1);
                }
            }
        }

        private void sureButton_Click(object sender, EventArgs e)
        {
            if (num.StartsWith("."))//以小数点开头
            {
                numberTextBox.Text = "0" + numberTextBox.Text;
            }
            bar = barCodeTextBox.Text;
            num = numberTextBox.Text;
            if (bar.Equals(""))
            {
                barCodeTextBox.Focus();
            }
            else
            {
                QueryGoods query = null;
                if (this.count.Equals(ParentWindow.DeliveryGoods.ToString()))
                {
                    query = new QueryGoods(deliveryGoods, bar, num);
                }
                else if (this.count.Equals(ParentWindow.ReturnGoods.ToString()))
                {
                    query = new QueryGoods(returnGoods, bar, num);
                }
                else if (this.count.Equals(ParentWindow.CustomerDelivery.ToString()))
                {
                    query = new QueryGoods(customerDelivery, bar, num);
                }
                //MessageBox.Show(query.ToString());
                item = query.queryExistGood(log);//查询后获得
                if (item == 0)
                {
                    MessageBox.Show("商品不存在,请重新输入", "提示", MessageBoxButtons.OK);
                }
                else if (item == 1)
                {
                    barCodeTextBox.Text = "";
                }
                else if (item > 1 && item < 50)
                {
                    ScanGood scanGood = null;
                    if (this.count.Equals(ParentWindow.DeliveryGoods.ToString()))
                    {
                        scanGood = new ScanGood(deliveryGoods, bar, num);
                    }
                    else if (this.count.Equals(ParentWindow.ReturnGoods.ToString()))
                    {
                        scanGood = new ScanGood(returnGoods, bar, num);
                    }
                    else if (this.count.Equals(ParentWindow.CustomerDelivery.ToString()))
                    {
                        scanGood = new ScanGood(customerDelivery, bar, num);
                    }

                    scanGood.ShowDialog();
                    barCodeTextBox.Text = "";
                }
                else if (item >= 50)
                {
                    MessageBox.Show("匹配的商品记录数大于[50]条，请输入更多内容以减少匹配范围", "提示", MessageBoxButtons.OK);
                }
                barCodeTextBox.Focus();
            }
            textbox_focus = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Scan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sureButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.Escape)
            {
                cancelButton_Click(this, EventArgs.Empty);
            }
        }
    }
}