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
    public partial class ViewAppointment : Form
    {
        private int idno;
        public ViewAppointment(int id)
        {
            InitializeComponent();
            this.idno = id;
            
        }

        private void DoctorHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nDSDataSet2.Patient_info' table. You can move, or remove it, as needed.
            this.patient_infoTableAdapter.Fill(this.nDSDataSet2.Patient_info);
            // TODO: This line of code loads data into the 'nDSDataSet4.Patient_info' table. You can move, or remove it, as needed.
           // this.patient_infoTableAdapter.Fill(this.nDSDataSet4.Patient_info);
            try
            {
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[10].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadAppointments(idno);

        }

        public void LoadAppointments(int id)
        {
            try
            {
                DataClasses1DataContext dt = new DataClasses1DataContext();
                var result = from c in dt.Patient_infos
                             where c.DoctorId == id
                             select c;
                List<Patient_info> patient_Infos = result.ToList();
                dataGridView1.DataSource = patient_Infos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error " + ex.Message);
            }

        }
        public void DelAppointment(int id)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                var result = from c in dc.Patient_infos
                             where c.AppointmentId == id
                             select c;
                List<Patient_info> patient_Infos = result.ToList();
                dc.Patient_infos.DeleteAllOnSubmit(patient_Infos);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.HelpLink);
            }

            LoadAppointments(idno);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataClasses1DataContext dt = new DataClasses1DataContext();
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];


                textBox1.Text = row.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.HelpLink);
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            DelAppointment(id);
            textBox1.Text = "";
        }

        
        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateDoctorForm update = new UpdateDoctorForm(idno);
            update.Visible = true;
            this.Visible = false;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Visible = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shows Doctor's appointed patients.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
