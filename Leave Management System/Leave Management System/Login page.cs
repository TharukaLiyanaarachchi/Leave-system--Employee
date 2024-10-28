using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Leave_Management_System
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NAVEEN5445;Initial Catalog=""Leave Management System"";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            EmployeeUser.Clear();
            PW.Clear();


            EmployeeUser.Focus();
            PW.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            String username, password;

            username = EmployeeUser.Text;
            password = PW.Text;

            try
            {
                String query = "SELECT * FROM Login_Employee_Leave WHERE username = '" + EmployeeUser.Text + "'AND password = '" + PW.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    int employeeId = Convert.ToInt32(dataTable.Rows[0]["employee_id"]);
                    Session.EmployeeId = employeeId;

                    username = EmployeeUser.Text;
                    password = PW.Text;

                    //page that needed to be load next
                    Leave_Apply form2 = new Leave_Apply();
                    form2.ShowDialog();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EmployeeUser.Clear();
                    PW.Clear();

                    // to focus username 
                    EmployeeUser.Focus();
                    PW.Focus();


                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void EmployeeNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void EmployeeNo_Click(object sender, EventArgs e)
        {

        }
    }
}
