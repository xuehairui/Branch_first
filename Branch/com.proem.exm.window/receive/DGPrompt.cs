using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branch.com.proem.exm.window.receive
{
    public partial class DGPrompt : Form
    {

        private string sInputMess = "";

        public DGPrompt()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 进行传值的属性方法
        /// </summary>
        public string inputMess
        {
            get { return sInputMess; }
            set { this.sInputMess = value; }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.inputMess = this.inputTextBox.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
