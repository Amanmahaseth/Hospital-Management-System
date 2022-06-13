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
    public partial class Patientform : Form
    {
       
        public Patientform()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string query = "select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "" || PatName.Text == "" || PatAdd.Text == "" || PatCon.Text == "" || PatAge.Text == "" || MajorDis.Text =="" || GenderCb.SelectedItem ==null || BloodCb.SelectedItem == null)
                MessageBox.Show("No empty fill accepted");
            else
            {
                Con.Open();
                string query = "insert into PatientTbl values(" + PatId.Text + ",'" + PatName.Text + "','" + PatAdd.Text + "','" + PatCon.Text + "','" + PatAge.Text + "','" + GenderCb.SelectedItem.ToString() +"','"+BloodCb.SelectedItem.ToString()+"','"+MajorDis.Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient successfully Added"); ;
                Con.Close();
                populate();
            }
        }
        
        private void Patientform_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void PatId_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MajorDis_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void PatAdd_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "")
                MessageBox.Show("Enter the Patient Id");
            else
            {
                Con.Open();
                string query = "delete from PatientTbl where PatId=" + PatId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully deleted");
                Con.Close();
                populate();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (PatId.Text == "" || PatName.Text == "" || PatAdd.Text == "" || PatCon.Text == "" || PatAge.Text == "" || MajorDis.Text == "" || GenderCb.SelectedItem == null || BloodCb.SelectedItem == null)
                MessageBox.Show("No empty fill accepted");
            else
            {
                Con.Open();
                string query = "update PatientTbl set PatName ='" + PatName.Text + "',PatAdd ='" + PatAdd.Text + "', PatCon ='" + PatCon.Text + "' , PatAge ='" + PatAge.Text + "', PatGender ='" + GenderCb.SelectedItem.ToString() + "', PatBG ='" + BloodCb.SelectedItem.ToString() + "' , PatDisease ='" + MajorDis.Text + "' where PatId=" + PatId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully updated");
                Con.Close();
                populate();

            }

        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientGV.SelectedRows[0].Cells[1].Value.ToString();
            PatAdd.Text = PatientGV.SelectedRows[0].Cells[2].Value.ToString();
            PatCon.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = PatientGV.SelectedRows[0].Cells[4].Value.ToString();
            MajorDis.Text = PatientGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
