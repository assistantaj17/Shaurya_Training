using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;

namespace SampleWinForm
{
    public partial class Form4 : Form
    {
        FileStream fs;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Empid = Convert.ToInt32(txtEmpId.Text);
                emp.Empname = txtEmpName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                fs = new FileStream(@"D:\Employee", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, emp);
                MessageBox.Show("File Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                fs = new FileStream(@"D:\Employee", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                emp = (Employee)bf.Deserialize(fs);
                txtEmpId.Text = emp.Empid.ToString();
                txtEmpName.Text = emp.Empname;
                txtSalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Empid = Convert.ToInt32(txtEmpId.Text);
                emp.Empname = txtEmpName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                fs = new FileStream(@"D:\EmployeeXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                xs.Serialize(fs, emp);
                MessageBox.Show("XML File Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                fs = new FileStream(@"D:\EmployeeXML", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                emp = (Employee)xs.Deserialize(fs);
                txtEmpId.Text = emp.Empid.ToString();
                txtEmpName.Text = emp.Empname;
                txtSalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Empid = Convert.ToInt32(txtEmpId.Text);
                emp.Empname = txtEmpName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                fs = new FileStream(@"D:\EmployeeSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, emp);
                MessageBox.Show("Soap File Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                fs = new FileStream(@"D:\EmployeeSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                emp = (Employee)sf.Deserialize(fs);
                txtEmpId.Text = emp.Empid.ToString();
                txtEmpName.Text = emp.Empname;
                txtSalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Empid = Convert.ToInt32(txtEmpId.Text);
                emp.Empname = txtEmpName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                fs = new FileStream(@"D:\EmployeeJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, emp);
                MessageBox.Show("Json File Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                fs = new FileStream(@"D:\EmployeeJson", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                emp = JsonSerializer.Deserialize<Employee>(fs);
                txtEmpId.Text = emp.Empid.ToString();
                txtEmpName.Text = emp.Empname;
                txtSalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
