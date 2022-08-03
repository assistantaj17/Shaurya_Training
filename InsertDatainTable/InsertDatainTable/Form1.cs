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
using System.Configuration;

namespace InsertDatainTable
{
    public partial class Form1 : Form
    {
        // private readonly object ConfigurationManager;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
                                    
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write a query that needs to be fire
                string qry = "insert into Employee (Fname,Mname,Lname,Gender,DOB,Address,City,Pincode,Mobileno) values(@Fname,@Mname,@Lname,@Gender,@DOB,@Address,@City,@Pincode,@Mobileno)";
                //step 3 assign qry to the command
                cmd = new SqlCommand(qry, con);
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@Fname", txtFname.Text);
                cmd.Parameters.AddWithValue("@Mname", txtMname.Text);
                cmd.Parameters.AddWithValue("@Lname", txtLname.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(txtDOB.Text));
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@Pincode", Convert.ToDouble(txtPincode.Text));
                cmd.Parameters.AddWithValue("@Mobileno", Convert.ToDouble(txtMobileno.Text));
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                
                cmd = new SqlCommand("SP_Insert_Employee", con);
                
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@Fname", txtFname.Text);
                cmd.Parameters.AddWithValue("@Mname", txtMname.Text);
                cmd.Parameters.AddWithValue("@Lname", txtLname.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(txtDOB.Text));
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@Pincode", Convert.ToDouble(txtPincode.Text));
                cmd.Parameters.AddWithValue("@Mobileno", Convert.ToDouble(txtMobileno.Text));
                
                con.Open();
                
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                cmd = new SqlCommand("SP_Delete_Employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mobileno", Convert.ToInt32(txtMobileno.Text));
                
                con.Open();
                
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record Deleted");
                    txtFname.Clear();
                    txtMname.Clear();
                    txtLname.Clear();
                    txtGender.Clear();
                    txtDOB.Clear();
                    txtCity.Clear();
                    txtAddress.Clear();
                    txtPincode.Clear();
                    txtMobileno.Clear();
                  
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                cmd = new SqlCommand("SP_Update_Employee", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Fname", txtFname.Text);
                cmd.Parameters.AddWithValue("@Mname", txtMname.Text);
                cmd.Parameters.AddWithValue("@Lname", txtLname.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(txtDOB.Text));
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@Pincode", Convert.ToDouble(txtPincode.Text));
                cmd.Parameters.AddWithValue("@Mobileno", Convert.ToInt32(txtMobileno.Text));
                

                con.Open();
                
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

        private void btnShowallrecord_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SP_SelectAll_Employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
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
    }
}
