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
    public partial class UpdateDoctorForm : Form
    {
        private int idno;
        public UpdateDoctorForm(int id)
        {
            InitializeComponent();
            this.idno = id;
        }

        private void UpdateDoctorForm_Load(object sender, EventArgs e)
        {
            LoadInfo(idno);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            UpdateToDB(idno);
        }

        public void LoadInfo(int id)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                var result = dc.Doctor_infos.SingleOrDefault(c => c.ID == id);

                phoneTxt.Text = result.PHONE_NO;
                emailTxt.Text = result.EMAIL;
                addresstxt.Text = result.ADDRESS;
                dateTimePicker1.Value = Convert.ToDateTime(result.START_TIME.Value);
                dateTimePicker2.Value = Convert.ToDateTime(result.END_TIME.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error", ex.Message);
            }
        }
        
        public void UpdateToDB(int id)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                var result = dc.Doctor_infos.SingleOrDefault(c => c.ID == id);
                result.PHONE_NO = phoneTxt.Text;
                result.EMAIL = emailTxt.Text;
                result.ADDRESS = addresstxt.Text;
                DateTime dt = dateTimePicker1.Value;
                TimeSpan st = dt.TimeOfDay;
                result.START_TIME = st;
                DateTime dt1 = dateTimePicker2.Value;
                TimeSpan et = dt1.TimeOfDay;
                result.END_TIME = et;
                dc.SubmitChanges();
                MessageBox.Show("Doctor Info Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed. ", ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ViewAppointment dh = new ViewAppointment(idno);
            dh.Visible = true;
            this.Visible = false;
        }
    }
}
