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
    public partial class DoctorHome : Form
    {
        private int idno;
        public DoctorHome(int id)
        {
            InitializeComponent();
            this.idno = id;
            label2.Text = idno.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAppointment view = new ViewAppointment(idno);
            view.Visible = true;
            this.Visible = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doctor Home Page.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Visible = true;
            this.Visible = false;
            
            
        }

        private void editProfileBtn_Click(object sender, EventArgs e)
        {
            UpdateDoctorForm up = new UpdateDoctorForm(idno);
            up.Visible = true;
            this.Visible = false;
        }
    }
}
