using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awesome_light_ui_dashbard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tab_Click(object sender, EventArgs e)
        {
            ctrl21.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            lblmain.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
        }

        private void tab1_Click(object sender, EventArgs e)
        {
            ctrl11.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            lblmain.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
        }
    }
}
