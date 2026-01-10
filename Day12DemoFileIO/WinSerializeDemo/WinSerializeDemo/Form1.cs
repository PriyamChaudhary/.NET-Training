using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//For binary serialization
using System.Runtime.Serialization.Formatters.Binary;
//for xml
using System.Xml.Serialization;
//for SOAP serialization
using System.Runtime.Serialization.Formatters.Soap;

namespace WinSerializeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp1=new Employee();
            emp1.Id = Convert.ToInt32(txtEmpId.Text);
            emp1.Name = txtName.Text;
            emp1.Salary=Convert.ToInt32(txtSalary.Text);

            //Binary Serialization code below
            FileStream fs=new FileStream(@"D:\.Net\BinSerialize.bin",FileMode.OpenOrCreate,FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp1);
            
            
            foreach(Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txtBox= (TextBox)item;
                    txtBox.Clear();
                }
            }
            fs.Close();
        }

        private void btnBinDeserialization_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\.Net\BinSerialize.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();

            Employee emp1 = (Employee) bf.Deserialize(fs);
            txtEmpId.Text=emp1.Id.ToString();
            txtName.Text=emp1.Name;
            txtSalary.Text=emp1.Salary.ToString();
            fs.Close();
        }
        /// <summary>
        /// XML serialization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.Id = Convert.ToInt32(txtEmpId.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            //XML Serialization code below
            FileStream fs = new FileStream(@"D:\.Net\XMLSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs= new XmlSerializer(typeof(Employee));
            xs.Serialize(fs, emp1);
            fs.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\.Net\XMLSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));

            Employee emp1 = (Employee)xs.Deserialize(fs);
            txtEmpId.Text = emp1.Id.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();
            fs.Close();


        }

        private void btnSoapSerialization_Click(object sender, EventArgs e)
        {

            Employee emp1 = new Employee();
            emp1.Id = Convert.ToInt32(txtEmpId.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            //Binary Serialization code below
            FileStream fs = new FileStream(@"D:\.Net\SoapSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, emp1);


            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txtBox = (TextBox)item;
                    txtBox.Clear();
                }
            }
            MessageBox.Show("Record added..");
            fs.Close();

        }

        private void btnSoapDeserialization_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\.Net\SoapSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter sf = new SoapFormatter();

            Employee emp1 = (Employee)sf.Deserialize(fs);
            txtEmpId.Text = emp1.Id.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();
            fs.Close();

        }
        

        
    }
}
