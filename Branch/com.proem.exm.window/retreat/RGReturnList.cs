using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branch.com.proem.exm.window.retreat
{
    /// <summary>
    /// 打开已有退货单
    /// </summary>
    public partial class RGReturnList : Form
    {
        public RGReturnList()
        {
            InitializeComponent();
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {
            RGSupplierChoose rGSupplierChoose = new RGSupplierChoose();
            rGSupplierChoose.ShowDialog();//选择供应商
        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            RGROperatorChoose rGROperatorChoose = new RGROperatorChoose();
            rGROperatorChoose.ShowDialog();//选择操作员
        }

        private void RGReturnList_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Y)
            {
                okButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.L)
            {
                leaveButton_Click(this, EventArgs.Empty);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void queryButton_Click(object sender, EventArgs e)
        {

        }
    }
}
