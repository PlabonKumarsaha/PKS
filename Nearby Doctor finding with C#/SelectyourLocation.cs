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
    public partial class SelectyourLocation : Form
    {
        public string gettext;
        public SelectyourLocation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                gettext = comboBox1.SelectedItem.ToString();
                DoctorList dl = new DoctorList(gettext);

                this.Visible = false;
                dl.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select one Area!!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WelcomeGUI wl = new WelcomeGUI();
            wl.Visible = true;
            this.Visible = false;
   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Patient,Select your area to find doctor");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
