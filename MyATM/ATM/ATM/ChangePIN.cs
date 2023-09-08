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


namespace ATM
{
    public partial class ChangePIN : Form
    {
        public ChangePIN()
        {
            InitializeComponent();
        }

        private void ChangePIN_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maen-\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Pin1tb.Text == "" || Pin2tb.Text == "")
            {
                MessageBox.Show("Enter New PIN Code");
            }
            else if(Pin1tb.Text != Pin2tb.Text)
            {
                MessageBox.Show("PIN Code Doesn't Match");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set PIN = " + Pin1tb.Text + " where AccNum = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN Code Has Been Changed");
                    Con.Close();
                    Login log= new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
