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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            password_field.PasswordChar = '*';
            password_field.MaxLength = 8;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != null)
            {

                string id = idTextBox.Text;
                string password = password_field.Text;
                if (this.LoginConfirmation(id, password))
                {
                    this.Visible = false;
                    MessageBox.Show("Login Successful");

                    DoctorHome dh = new DoctorHome(Convert.ToInt32(id));
                    dh.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }
            else if (idTextBox.Text == null)
            {
                MessageBox.Show("ID field is empty");
            }

        }

        private bool LoginConfirmation(string id, string password)
        {
            try
            {
                int idno = Convert.ToInt32(id);

                DataClasses1DataContext dc = new DataClasses1DataContext();
                /*var result = from u in dc.Login_infos
                             where u.ID.Equals(idno) &&
                             u.PASSWORD.Equals(password)
                             select u;
                if (result !=null)
                {
                    return true;
                }
                            
                            
                return false;
                            */
                var result1 = dc.Login_infos.SingleOrDefault(s => s.ID == idno).PASSWORD;
                
                Console.WriteLine(result1 + " " + password);


                //string tbpassword = result2.ToString();
                if (result1 == password)
                {
                    return true;
                }
                else return false;
            }
            catch ( Exception ex)
            {
                MessageBox.Show( ex.Message);
                return false;
            }

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
