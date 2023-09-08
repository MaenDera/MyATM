using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maen-\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            int balance = 0;
            if (AccNametb.Text == "" || AccNumtb.Text == "" || LastNametb.Text == "" || Addresstb.Text == "" || Phonetb.Text == "" || Occupationtb.Text == "" || PINtb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into AccountTbl values('" + AccNumtb.Text + "', '" + AccNametb.Text + "', '" + LastNametb.Text + "', '" + Phonetb.Text + "', '" + Addresstb.Text + "', '" + PINtb.Text + "', '" + Educationcb.SelectedItem.ToString() + "', '" + Occupationtb.Text + "', '" + Dobdate.Value.Date + "', " + balance + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
