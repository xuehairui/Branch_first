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
    /// 选择采购员
    /// </summary>
    public partial class RGBuyerChoose : Form
    {
        public RGBuyerChoose()
        {
            InitializeComponent();
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

        private void RGBuyerChoose_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Q)
            //{
            //    queryButton_Click(this,EventArgs.Empty);
            //}
            if (e.KeyCode == Keys.Y)
            {
                okButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.L)
            {
                leaveButton_Click(this, EventArgs.Empty);
            }
        }
    }
}
