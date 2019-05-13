using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace NDS
{
    public partial class DoctorList : Form
    {
       public bool flag = false;
       // public SelectyourLocation Sl { get; set; }
        public string location;
        private int id;
        private int getId;
        public DoctorList(string gettext )
        {
            InitializeComponent();
            location = gettext.ToString();
            

        }

        private void DoctorList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nDSDataSet5.Doctor_info' table. You can move, or remove it, as needed.
            this.doctor_infoTableAdapter.Fill(this.nDSDataSet5.Doctor_info);
            // TODO: This line of code loads data into the 'nDSDataSet.Doctor_info' table. You can move, or remove it, as needed.
            //this.doctor_infoTableAdapter.Fill(this.nDSDataSet.Doctor_info);
            
            try
            {
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;

            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            LoadDoctor(location);

        }

        

        public void LoadDoctor ( string location )
        {
            try
            {
                DataClasses1DataContext dt = new DataClasses1DataContext();
                var result = from Doctor_info in dt.Doctor_infos
                             where Doctor_info.LOCATION == location
                             select Doctor_info;
                List<Doctor_info> doctor_Infos = result.ToList();
                dataGridView1.DataSource = doctor_Infos;
            }

            catch (Exception ex)
            {
                MessageBox.Show("There is an error " + ex.Message);
            }


        }

        // Grid view cell click to select a doctor
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                getId = Convert.ToInt32(row.Cells[0].Value);
                string time1 = row.Cells[8].Value.ToString();
                string time2 = row.Cells[9].Value.ToString();
                aTimetextBox.Text = time1 + "-" + time2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //button click to view next form
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                id = getId;
                PatientForm patientForm = new PatientForm(id,location);
                patientForm.Visible = true;
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("You have not selected any doctor.");
            }
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Frame shows you about all the doctors of your selected area");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            SelectyourLocation sl = new SelectyourLocation();
            sl.Visible = true;
            this.Visible = false;
        }
    }
}
