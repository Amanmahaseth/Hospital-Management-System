using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_management_system
{
    public partial class splashform : Form
    {
        public splashform()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            MyProgressBar.Value = startpoint;
            if(MyProgressBar.Value == 100)
            {
                MyProgressBar.Value = 0;
                timer1.Stop();
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splashform_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
