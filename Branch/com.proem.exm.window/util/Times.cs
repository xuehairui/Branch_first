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
    public partial class Times : Form
    {
        public Times()
        {
            InitializeComponent();
        }

        private void Times_Load(object sender, EventArgs e)
        {
            timesTimer.Enabled = true;
        }

        private void timesTimer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            timesLabel.Text = dt.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
