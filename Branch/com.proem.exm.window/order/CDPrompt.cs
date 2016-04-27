using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branch.com.proem.exm.window.order
{
    public partial class CDPrompt : Form
    {

        private string sInputMess = "";

        public CDPrompt()
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

        private void CDPrompt_Load(object sender, EventArgs e)
        {

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
