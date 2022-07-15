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
    public partial class Form4 : Form
    {
        SqlDataReader dr;
        SqlCommand cmd;
        SqlConnection con;
        public Form4()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Student values (@Sname,@Percantage)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Sname", txtName.Text);
                cmd.Parameters.AddWithValue("@Percantage", txtPercentage.Text);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success! Record Inserted");
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
                string qry = "Update Student set Sname=@Sname,Percantage=@Percantage where Rollno=@Rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Sname", txtName.Text);
                cmd.Parameters.AddWithValue("@Percantage", txtPercentage.Text);
                cmd.Parameters.AddWithValue("@Rollno", txtRollno.Text);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record Updated");
                }
            }
            catch(Exception ex)
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
                string qry = "delete from Student where Rollno=@Rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Rollno", Convert.ToInt32(txtRollno.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record Deleted");
                    txtName.Clear();
                    txtPercentage.Clear();
                    txtRollno.Clear();
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

        private void btnSearchRollNo_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Select * from Student where Rollno=@Rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Rollno", Convert.ToInt32(txtRollno.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtName.Text = dr["Sname"].ToString();
                        txtPercentage.Text = dr["Percantage"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch(Exception ex)
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
                string qry = "Select * from Student";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    StudentGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Record Not Found");
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
