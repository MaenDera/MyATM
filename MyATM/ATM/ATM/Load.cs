using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start+=10;
            Myprogress.Value = start;
            procent.Text = ""+start;
            if (Myprogress.Value == 100) 
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }
    }
}
