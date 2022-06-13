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
    public partial class DiagnosisForm : Form
    {
        public DiagnosisForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        void populatecombo()
        {
            string sql = "select * from PatientTbl";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatientId",typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PatientIdCb.ValueMember = "PatId";
                PatientIdCb.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        string patname;
        void fetchpatientname()
        {
            Con.Open();
            string mysql = "select * from PatientTbl where PatId=" + PatientIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                patname = dr["Patname"].ToString();
                PatientTb.Text = patname;
            }
            Con.Close();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from DiagnosisTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DiagnosisGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label7_Click(object sender, EventArgs e)        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "" || PatientIdCb.Text == "" || MedicineTb.Text == "" || DiagnosisTb.Text == "" || PatientTb.Text == "" || SymptomsTb.Text == "" )
                MessageBox.Show("No empty fill accepted");
            else
            {
                Con.Open();
                string query = "insert into DiagnosisTbl values(" + DiagId.Text + "," + PatientIdCb.SelectedValue.ToString() + ",'" + PatientTb.Text + "','" + SymptomsTb.Text + "','" + DiagnosisTb.Text + "','" + MedicineTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
               cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis successfully Added"); ;
                Con.Close();
                populate();
            }
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            populatecombo();
            populate();
        }

        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpatientname();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "")
                MessageBox.Show("Enter the Diagnosis Id");
            else
            {
                Con.Open();
                string query = "delete from DiagnosisTbl where DiagId=" + DiagId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully deleted");
                Con.Close();
                populate();

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "" || PatientIdCb.Text == "" || MedicineTb.Text == "" || DiagnosisTb.Text == "" || PatientTb.Text == "" || SymptomsTb.Text == "")
                MessageBox.Show("No empty fill accepted");
            else
            {
                Con.Open();
                string query = "update DiagnosisTbl set PatId ='" + PatientIdCb.SelectedValue.ToString() + "',PatName ='" + PatientTb.Text + "', Symptoms ='" + SymptomsTb.Text + "' , Diagnosis ='" + DiagnosisTb.Text + "',Medicines ='" +MedicineTb.Text + "' where DiagId=" + DiagId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully updated");
                Con.Close();
                populate();

            }
        } 

        private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiagId.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatientIdCb.SelectedValue = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatientTb.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            SymptomsTb.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            DiagnosisTb.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            MedicineTb.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
            Patientlbl.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Diagnosislbl.Text= DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Symptomslbl.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Medicineslbl.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PatientTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label4.Text  , new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(230));
            e.Graphics.DrawString(Patientlbl.Text +"\n" + Diagnosislbl.Text +"\n"+Symptomslbl.Text +"\n"+ Medicineslbl.Text , new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(130,150));
            e.Graphics.DrawString(label10.Text + "\n", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(230,500));

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Symptomslbl_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
   }

