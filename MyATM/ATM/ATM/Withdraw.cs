using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maen-\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        int balance;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum = '" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = "Your Balance: "+dt.Rows[0][0].ToString() + " kr";
            balance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void addtransaction()
        {
            String TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "', '" + TrType + "', " + Withdrawtb.Text + ", '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully");
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
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

        private void Withdraw_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void Balancelbl_Click(object sender, EventArgs e)
        {

        }
        int newbalance;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Withdrawtb.Text == "")
            {
                MessageBox.Show("Enter How much You Want to Withdraw");
            }
            else if (Convert.ToInt32(Withdrawtb.Text) <= 0)
            {
                MessageBox.Show("Enter a Vaild Amount");
            }
            else if (Convert.ToInt32(Withdrawtb.Text) > balance)
            {
                MessageBox.Show("Balance Can't Be Negative");
            }
            else
            {
                try
                {
                    newbalance = balance - Convert.ToInt32(Withdrawtb.Text);
                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl set Balance = " + newbalance + " where AccNum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Success Withdraw");
                        Con.Close();
                        addtransaction();
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
