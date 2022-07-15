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
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form3()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write a query that needs to be fire
                string qry = "insert into Product values(@Pname,@Price)";
                //step 3 assign qry to the command
                cmd = new SqlCommand(qry, con);
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@Pname", txtName.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(txtPrice.Text));
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write a query that needs to be fire
                string qry = "update Product set PName=@PName,Price=@Price where Id=@Id";
                //step 3 assign qry to the command
                cmd = new SqlCommand(qry, con);
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@Pname", txtName.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(txtPrice.Text));
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write a query that needs to be fire
                string qry = "delete from Product where Id=@Id";
                //step 3 assign qry to the command
                cmd = new SqlCommand(qry, con);
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record Deleted");
                    txtId.Clear();
                    txtName.Clear();
                    txtPrice.Clear();
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

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Select * from Product where Id=@Id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text)); 
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtName.Text = dr["Pname"].ToString();// Pname , Price are the col names
                        txtPrice.Text = dr["Price"].ToString();
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

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Select * from Product";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    ProdGridView.DataSource = dt;
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
