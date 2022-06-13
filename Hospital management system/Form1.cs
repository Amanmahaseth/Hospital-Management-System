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
namespace Hospital_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            DocNameTb.Text = "";
            PassTb.Text = "";


        }

        private void bunifuMetroTextbox1_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocNameTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter a Username and Password");

            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from DoctorTbl where DocName='"+DocNameTb.Text+"' and DocPass='"+PassTb.Text+"'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    Home H = new Home();
                    H.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or Password");

                }
                Con.Close();



                
            }
        }
    }
}
