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
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
        }
        public DataSet GetAllEmps()
        {
            da = new SqlDataAdapter("select * from Employee", con);
            // assign PK to the col which in the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            // emp is a table name given which is in the DataSet
            da.Fill(ds, "emp");// Fill method fire the select qry
            return ds;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp"].NewRow();
                row["Name"] = txtName.Text;
                row["Salary"] = txtSalary.Text;
                // attach the new row to the ds
                ds.Tables["emp"].Rows.Add(row);
                //update() will reflect the changes to the DB
                int result = da.Update(ds.Tables["emp"]);
                if (result == 1)
                {
                    MessageBox.Show("Success ! Recored inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    row["Name"] = txtName.Text;
                    row["Salary"] = txtSalary.Text;
                 
                    //update() will reflect the changes to the DB
                    int result = da.Update(ds.Tables["emp"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Success ! Recored Updated");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    // delete() will reflect the changes to the DB
                    row.Delete();
                    //update() will reflect the changes to the DB
                    int result = da.Update(ds.Tables["emp"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Success ! Recored Deleted");
                        txtId.Clear();
                        txtName.Clear();
                        txtSalary.Clear();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchByEmp_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    txtName.Text = row["Name"].ToString();
                    txtSalary.Text = row["Salary"].ToString();
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
        }

        private void btnShowAllEmp_Click(object sender, EventArgs e)
        {
            ds = GetAllEmps();
            EmpGridView.DataSource = ds.Tables["emp"];
        }
    }
}
