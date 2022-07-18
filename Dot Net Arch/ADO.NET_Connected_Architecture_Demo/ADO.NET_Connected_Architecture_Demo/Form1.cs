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


namespace ADO.NET_Connected_Architecture_Demo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            //step1
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write a query that needs to be fire
                string qry = "update Employee set Name=@Name,Salary=@Salary where Id=@ID";
                //step 3 assign qry to the command
                cmd = new SqlCommand(qry, con);
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@name", EmpName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(EmpSalary.Text));
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(EmployeeID.Text));
                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write a query that needs to be fire
                string qry = "insert into Employee values(@name,@salary)";
                //step 3 assign qry to the command
                cmd = new SqlCommand(qry, con);
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@name", EmpName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(EmpSalary.Text));
                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearchByEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Select * from Employee where Id=@ID";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(EmployeeID.Text)); con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EmpName.Text = dr["Name"].ToString();// Name , Salary are the col names
                        EmpSalary.Text = dr["Salary"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write a query that needs to be fire
                string qry = "delete from Employee where Id=@ID";
                //step 3 assign qry to the command
                cmd = new SqlCommand(qry, con);
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(EmployeeID.Text));
                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record Deleted");
                    EmployeeID.Clear();
                    EmpName.Clear();
                    EmpSalary.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShowAllEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Select * from Employee";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    EmpGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSaveusingSP_Click(object sender, EventArgs e)
        {
            try
            {
                
                //step 3 assign qry to the command
                cmd = new SqlCommand("SP_Insert_Employee", con);
                // need to add the following code to tell to command that execute the SP(Stored Procedure)
                cmd.CommandType = CommandType.StoredProcedure;
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@name", EmpName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(EmpSalary.Text));
                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record inserted using SP");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }

}
    


