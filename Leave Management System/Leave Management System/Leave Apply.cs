using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Leave_Management_System
{
    public partial class Leave_Apply : Form
    {
        public Leave_Apply()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NAVEEN5445;Initial Catalog=""Leave Management System"";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void Leave_Apply_Load(object sender, EventArgs e)
        {
            // Access the stored Employee ID
            int employeeId = Session.EmployeeId;

            // Print Employee ID to the console
            Console.WriteLine("Employee ID: " + Session.EmployeeId);


            // Use the employeeId to load leave details or for other operations
            LoadLeaveDetails(employeeId);
        }

         void LoadLeaveDetails(int employeeId)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                
                SqlCommand cmd = new SqlCommand("SELECT annual_Leave_balance, casual_Leave_balance, short_Leave_balance FROM Leave_balance_employee WHERE employee_id = @EmployeeId", con);
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    annualBalance.Text = reader["annual_Leave_balance"].ToString();
                    casualBalance.Text = reader["casual_Leave_balance"].ToString();
                    shortBalance.Text = reader["short_Leave_balance"].ToString();
                }
                else
                {
                    MessageBox.Show("No leave data found for this Employee ID.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching leave details: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

       

        private void LeaveBA_Click(object sender, EventArgs e)
        {

        }

        private void LeaveBC_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void NICNo_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Prompt to confirm exit
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("Select * from Leave_request ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            EmployeeReg.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int employeeId = Session.EmployeeId;

            // Validate the Employee ID input
            

            try
            {
                con.Open();

                // Create the SQL command to insert a new leave request
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Leave_request (employee_id,request_date, from_date, to_date, leave_reason, covering_person, annual_leave, Casual_leave, short_leave, status) " +
                    "VALUES (@empId,@ReqDate, @FDate, @TDate, @Reason, @CoverP, @Annual, @Casual, @Short, @status)", con);

                // Add parameters to avoid SQL injection and handle special characters correctly
                cmd.Parameters.AddWithValue("@ReqDate", ReqDate.Text);
                cmd.Parameters.AddWithValue("@FDate", FDate.Text);
                cmd.Parameters.AddWithValue("@TDate", TDate.Text);
                cmd.Parameters.AddWithValue("@Reason", Reason.Text);
                cmd.Parameters.AddWithValue("@CoverP", CoverP.Text);

                cmd.Parameters.AddWithValue("@Annual", string.IsNullOrEmpty(Annual.Text) ? (object)DBNull.Value : (object)decimal.Parse(Annual.Text));
                cmd.Parameters.AddWithValue("@Casual", string.IsNullOrEmpty(Casual.Text) ? (object)DBNull.Value : (object)decimal.Parse(Casual.Text));
                cmd.Parameters.AddWithValue("@Short", string.IsNullOrEmpty(Short.Text) ? (object)DBNull.Value : (object)decimal.Parse(Short.Text));

                cmd.Parameters.AddWithValue("@empId", employeeId);
                cmd.Parameters.AddWithValue("@status", "pending");

                SqlCommand cmd2 = new SqlCommand(
                    "UPDATE Leave_balance_employee SET " +
                       "annual_Leave_balance = ISNULL(annual_Leave_balance, 0) - ISNULL(@Annual, 0), " +
                       "casual_Leave_balance = ISNULL(casual_Leave_balance, 0) - ISNULL(@Casual, 0), " +
                       "short_Leave_balance = ISNULL(short_Leave_balance, 0) - ISNULL(@Short, 0) " +
                       "WHERE employee_id = @empID", con
                    );

                cmd2.Parameters.AddWithValue("@Annual", string.IsNullOrEmpty(Annual.Text) ? (object)DBNull.Value : (object)decimal.Parse(Annual.Text));
                cmd2.Parameters.AddWithValue("@Casual", string.IsNullOrEmpty(Casual.Text) ? (object)DBNull.Value : (object)decimal.Parse(Casual.Text));
                cmd2.Parameters.AddWithValue("@Short", string.IsNullOrEmpty(Short.Text) ? (object)DBNull.Value : (object)decimal.Parse(Short.Text));
                cmd2.Parameters.AddWithValue("@empID", employeeId);

                // Execute the command
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Data Insert Success.");
                LoadLeaveDetails(employeeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
                BindData(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {

                con.Open();

                // Get the request ID from the form
                int leaveRequestId = int.Parse(ID.Text);

                //check whether status is pending
                SqlCommand checkStatusCmd = new SqlCommand("SELECT status FROM Leave_request WHERE leave_id = @RequestId", con);
                checkStatusCmd.Parameters.AddWithValue("@RequestId", leaveRequestId);
                string status = checkStatusCmd.ExecuteScalar()?.ToString();

                if (status != "pending")
                {
                    MessageBox.Show("You can only update leave requests in pending status.");
                    return;
                }

                SqlCommand getExistingLeaveCmd = new SqlCommand("SELECT annual_leave, casual_leave, short_leave FROM Leave_request WHERE employee_id = @EmployeeId", con);

                getExistingLeaveCmd.Parameters.AddWithValue("@EmployeeId", Session.EmployeeId);
                SqlDataReader reader = getExistingLeaveCmd.ExecuteReader();

                decimal existingAnnual = 0, existingCasual = 0, existingShort = 0;

                if (reader.Read())
                {
                    existingAnnual = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                    existingCasual = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                    existingShort = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                }

                reader.Close();

                SqlCommand updateBalanceCmd = new SqlCommand(
                "UPDATE Leave_balance_employee SET " +
                "annual_Leave_balance = ISNULL(annual_Leave_balance, 0) + ISNULL(@Annual, 0), " +
                "casual_Leave_balance = ISNULL(casual_Leave_balance, 0) + ISNULL(@Casual, 0), " +
                "short_Leave_balance = ISNULL(short_Leave_balance, 0) + ISNULL(@Short, 0) " +
                "WHERE employee_id = @empID", con);

                updateBalanceCmd.Parameters.AddWithValue("@Annual", existingAnnual);
                updateBalanceCmd.Parameters.AddWithValue("@Casual", existingCasual);
                updateBalanceCmd.Parameters.AddWithValue("@Short", existingShort);
                updateBalanceCmd.Parameters.AddWithValue("@empID", Session.EmployeeId);

                // Execute the balance update command
                updateBalanceCmd.ExecuteNonQuery();

                // Delete the leave request from the database
                SqlCommand updateStatusCmd = new SqlCommand(
                "UPDATE Leave_request SET status = 'cancel' WHERE leave_id = @RequestId", con);
                updateStatusCmd.Parameters.AddWithValue("@RequestId", leaveRequestId);

                // Execute the command to update the status
                updateStatusCmd.ExecuteNonQuery(); 
                
                MessageBox.Show("Leave request Cancelled and leave balance updated successfully.");
                LoadLeaveDetails(Session.EmployeeId);


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
                BindData();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                // Get the request ID from the form
                int leaveRequestId = int.Parse(ID.Text);

                //check whether status is pending
                SqlCommand checkStatusCmd = new SqlCommand("SELECT status FROM Leave_request WHERE leave_id = @RequestId", con);
                checkStatusCmd.Parameters.AddWithValue("@RequestId", leaveRequestId);
                string status = checkStatusCmd.ExecuteScalar()?.ToString();

                if (status != "pending")
                {
                    MessageBox.Show("You can only update leave requests in pending status.");
                    return;
                }

                SqlCommand getExistingLeaveCmd = new SqlCommand("SELECT annual_leave, casual_leave, short_leave FROM Leave_request WHERE employee_id = @EmployeeId", con);

                getExistingLeaveCmd.Parameters.AddWithValue("@EmployeeId", Session.EmployeeId);
                SqlDataReader reader = getExistingLeaveCmd.ExecuteReader();

                decimal existingAnnual = 0, existingCasual = 0, existingShort = 0;

                if (reader.Read())
                {
                    existingAnnual = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                    existingCasual = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                    existingShort = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                }

                reader.Close();

                // New leave values (input from the form)
                decimal newAnnual = string.IsNullOrEmpty(Annual.Text) ? 0 : decimal.Parse(Annual.Text);
                decimal newCasual = string.IsNullOrEmpty(Casual.Text) ? 0 : decimal.Parse(Casual.Text);
                decimal newShort = string.IsNullOrEmpty(Short.Text) ? 0 : decimal.Parse(Short.Text);

                // Calculate the difference between old and new values
                decimal annualDiff = newAnnual - existingAnnual;
                decimal casualDiff = newCasual - existingCasual;
                decimal shortDiff = newShort - existingShort;

                // Update the request
                SqlCommand cmd = new SqlCommand(
                "UPDATE Leave_request SET " +
                "from_date = COALESCE(NULLIF(@FDate, ''), from_date), " +
                "to_date = COALESCE(NULLIF(@TDate, ''), to_date), " +
                "leave_reason = COALESCE(NULLIF(@Reason, ''), leave_reason), " +
                "covering_person = COALESCE(NULLIF(@CoverP, ''), covering_person), " +
                "annual_leave = COALESCE(@Annual, annual_leave), " +
                "Casual_leave = COALESCE(@Casual, Casual_leave), " +
                "short_leave = COALESCE(@Short, short_leave) " +
                "WHERE leave_id = @RequestId", con);

                // Handle potential null or empty values for each field
                cmd.Parameters.AddWithValue("@FDate", string.IsNullOrEmpty(FDate.Text) ? (object)DBNull.Value : FDate.Text);
                cmd.Parameters.AddWithValue("@TDate", string.IsNullOrEmpty(TDate.Text) ? (object)DBNull.Value : TDate.Text);
                cmd.Parameters.AddWithValue("@Reason", string.IsNullOrEmpty(Reason.Text) ? (object)DBNull.Value : Reason.Text);
                cmd.Parameters.AddWithValue("@CoverP", string.IsNullOrEmpty(CoverP.Text) ? (object)DBNull.Value : CoverP.Text);

                // Handle null values for numeric fields like annual, casual, and short leave
                cmd.Parameters.AddWithValue("@Annual", newAnnual == 0 ? (object)DBNull.Value : newAnnual);
                cmd.Parameters.AddWithValue("@Casual", newCasual == 0 ? (object)DBNull.Value : newCasual);
                cmd.Parameters.AddWithValue("@Short", newShort == 0 ? (object)DBNull.Value : newShort);

                // Add the request ID
                cmd.Parameters.AddWithValue("@RequestId", leaveRequestId);

                // Execute the update command
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand(
                "UPDATE Leave_balance_employee SET " +
                "annual_Leave_balance = ISNULL(annual_Leave_balance, 0) + CASE WHEN @Annual > 0 THEN -@Annual ELSE ABS(@Annual) END, " +
                "casual_Leave_balance = ISNULL(casual_Leave_balance, 0) + CASE WHEN @Casual > 0 THEN -@Casual ELSE ABS(@Casual) END, " +
                "short_Leave_balance = ISNULL(short_Leave_balance, 0) + CASE WHEN @Short > 0 THEN -@Short ELSE ABS(@Short) END " +
                "WHERE employee_id = @empID", con);

                cmd2.Parameters.AddWithValue("@Annual", annualDiff);
                cmd2.Parameters.AddWithValue("@Casual", casualDiff);
                cmd2.Parameters.AddWithValue("@Short", shortDiff);
                cmd2.Parameters.AddWithValue("@empID", Session.EmployeeId);

                // Execute the command for leave balance update
                cmd2.ExecuteNonQuery();

              

                MessageBox.Show("Leave request updated successfully.");
                LoadLeaveDetails(Session.EmployeeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
                this.BindData();
            }


        }

        private void EmployeeReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reason_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Select * from Leave_request where employee_id = @empId", con);
            cmd.Parameters.AddWithValue("@empId", Session.EmployeeId);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            EmployeeReg.DataSource = dt;
        }
    }
}