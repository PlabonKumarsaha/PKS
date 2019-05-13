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
    public partial class PatientForm : Form
    {
        private int docId;
        private int apId;
        private string location;

        public PatientForm(int id,string location)
        {
            InitializeComponent();
            this.docId = id;
            this.location = location;
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value.ToLocalTime();
        }

        //
        public void InsertToDB(string name, int age, string gender, string contact, string category, string status, string description, DateTime date, TimeSpan time, int apId)
        {
            try
            {

                DataClasses1DataContext dt = new DataClasses1DataContext();
                Patient_info patient = new Patient_info();
                patient.Name = name;
                patient.Age = age;
                patient.Gender = gender;
                patient.ContactNo = contact;
                patient.Category = category;
                patient.MaritalSatus = status;
                patient.Description = description;
                patient.AppointmentDate = date;
                patient.AppointmentTime = time;
                patient.DoctorId = docId;
                patient.AppointmentId = apId;
                
                dt.Patient_infos.InsertOnSubmit(patient);
                dt.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        //button click to confirm patient appointment

        private void button1_Click(object sender, EventArgs e)
        {
            string name= "";
           // Nullable<int> i = null;
            //nullable this variable
            int age = 0;
            string contact="";
            string category="";
            string description="";
            DateTime date = dateTimePicker1.Value.ToLocalTime(); 
            TimeSpan time= dateTimePicker2.Value.TimeOfDay;
            try
            {

                if (nameTextBox.Text != "")
                {
                    name = nameTextBox.Text;
                    // break;
                }
                else if (nameTextBox.Text == "")
                {
                    MessageBox.Show("Enter your Name.");
                }

                if (ageTextBox.Text != "")
                {
                    age = Convert.ToInt32(ageTextBox.Text);
                }
                else if (ageTextBox.Text == "")
                {
                    MessageBox.Show("Enter your age.");
                    // break;
                }
                string gender = "";
                if (radioButton1.Checked)
                {
                    gender = "Male";
                }
                else if (radioButton2.Checked)
                {
                    gender = "Female";
                }
                else if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Select your gender.");
                }
                if (phoneTextBox2.Text != "")
                {
                    if (phoneTextBox2.Text.Length < 10)
                    { MessageBox.Show("Not enough digits in your number"); }

                    contact = phoneTextBox1.Text + phoneTextBox2.Text;
                }
                else if (phoneTextBox2.Text == "")
                {
                    MessageBox.Show("Enter your phone no. correctly.");
                }
                if ((string)comboBox1.SelectedItem != "")
                {
                    category = comboBox1.SelectedItem.ToString();
                }
                else if ((string)comboBox1.SelectedItem == "")
                {
                    MessageBox.Show("Enter your visit type.");
                }
                string status = "";
                if (radioButton3.Checked)
                {
                    status = "Single";
                }

                else if (radioButton4.Checked)
                {
                    status = "Married";
                }
                else if (radioButton5.Checked)
                {
                    status = "Widowed";
                }
                else if (radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false)
                {
                    MessageBox.Show("Marital status not selected");
                }

                foreach (var item in checkedListBox1.CheckedItems)
                {
                    description = description + item.ToString() + ",";
                }

                date = dateTimePicker1.Value.Date;

                time = dateTimePicker2.Value.TimeOfDay;


                Random rand1 = new Random();
                apId = rand1.Next(0100, 1000);
                //
                InsertToDB(name, age, gender, contact, category, status, description, date, time, apId);
                //MessageBox.Show(date.ToShortDateString(), time.ToString());
                MessageBox.Show("Your appointment is entered!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            nameTextBox.Clear();
            ageTextBox.Clear();
            phoneTextBox2.Clear();
           // textBox5.Clear();
            comboBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            dateTimePicker1.Value.ToLocalTime();
            dateTimePicker2.Refresh();


            }

        // Menu strip items
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fill up the patient form with valid information.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DoctorList dl = new DoctorList(location);
            dl.Visible = true;
            this.Visible = false;
        }
    }
}
