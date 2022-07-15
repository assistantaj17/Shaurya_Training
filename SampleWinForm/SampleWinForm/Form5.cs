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
    public partial class Form5 : Form
    {
        FileStream fs;
        public Form5()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Course cos = new Course();
                cos.Cid = Convert.ToInt32(txtCourseId.Text);
                cos.Name = txtName.Text;
                cos.Fees = Convert.ToInt32(txtFees.Text);
                fs = new FileStream(@"D:\Course", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, cos);
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
                Course cos = new Course();
                fs = new FileStream(@"D:\Course", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                cos = (Course)bf.Deserialize(fs);
                txtCourseId.Text = cos.Cid.ToString();
                txtName.Text = cos.Name;
                txtFees.Text = cos.Fees.ToString();
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
                Course cos = new Course();
                cos.Cid = Convert.ToInt32(txtCourseId.Text);
                cos.Name = txtName.Text;
                cos.Fees = Convert.ToInt32(txtFees.Text);
                fs = new FileStream(@"D:\CourseXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Course));
                xs.Serialize(fs, cos);
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
                Course cos=new Course();
                fs = new FileStream(@"D:\CourseXML", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Course));
                cos = (Course)xs.Deserialize(fs);
                txtCourseId.Text = cos.Cid.ToString();
                txtName.Text = cos.Name;
                txtFees.Text = cos.Fees.ToString();
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
                Course cos=new Course();
                cos.Cid = Convert.ToInt32(txtCourseId.Text);
                cos.Name = txtName.Text;
                cos.Fees = Convert.ToInt32(txtFees.Text);
                fs = new FileStream(@"D:\CourseSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, cos);
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
                Course cos=new Course();
                fs = new FileStream(@"D:\CourseSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                cos = (Course)sf.Deserialize(fs);
                txtCourseId.Text = cos.Cid.ToString();
                txtName.Text = cos.Name;
                txtFees.Text = cos.Fees.ToString();
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
                Course cos=new Course();
                cos.Cid = Convert.ToInt32(txtCourseId.Text);
                cos.Name = txtName.Text;
                cos.Fees = Convert.ToInt32(txtFees.Text);
                fs = new FileStream(@"D:\CourseJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, cos);
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
                Course cos=new Course();
                fs = new FileStream(@"D:\CourseJson", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                cos = JsonSerializer.Deserialize<Course>(fs);
                txtCourseId.Text = cos.Cid.ToString();
                txtName.Text = cos.Name;
                txtFees.Text = cos.Fees.ToString();
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
