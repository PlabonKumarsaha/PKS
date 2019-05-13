using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDS
{
    public partial class WelcomeGUI : Form
    {
        public WelcomeGUI()
        {
            InitializeComponent();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
          
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            //WelcomeGUI
            Login log = new Login();
            log.Visible = true;
            this.Visible = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            //patients' select a location
            SelectyourLocation sa = new SelectyourLocation();
            sa.Visible = true;
            this.Visible = false;
        }
    }
}
