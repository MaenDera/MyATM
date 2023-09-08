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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
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
        int balance;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum = '" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = "Your Balance: " + dt.Rows[0][0].ToString() + " kr";
            balance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void FastCash_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        private void addtransaction100()
        {
            String TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "', '" + TrType + "', " + 100 + ", '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void addtransaction200()
        {
            String TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "', '" + TrType + "', " + 200 + ", '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void addtransaction500()
        {
            String TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "', '" + TrType + "', " + 500 + ", '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void addtransaction1000()
        {
            String TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "', '" + TrType + "', " + 1000 + ", '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void addtransaction1500()
        {
            String TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "', '" + TrType + "', " + 1500 + ", '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void addtransaction2000()
        {
            String TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "', '" + TrType + "', " + 2000 + ", '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (balance < 100) 
            {
                MessageBox.Show("Your Balance is less that 100 kr");
            }
            else
            {
                int newbalance = balance - 100;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = " + newbalance + " where AccNum = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction100();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (balance < 200)
            {
                MessageBox.Show("Your Balance is less that 200 kr");
            }
            else
            {
                int newbalance = balance - 200;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = " + newbalance + " where AccNum = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction200();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (balance < 500)
            {
                MessageBox.Show("Your Balance is less that 500 kr");
            }
            else
            {
                int newbalance = balance - 500;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = " + newbalance + " where AccNum = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction500();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (balance < 1000)
            {
                MessageBox.Show("Your Balance is less that 1000 kr");
            }
            else
            {
                int newbalance = balance - 1000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = " + newbalance + " where AccNum = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction1000();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (balance < 1500)
            {
                MessageBox.Show("Your Balance is less that 1500 kr");
            }
            else
            {
                int newbalance = balance - 1500;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = " + newbalance + " where AccNum = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction1500();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (balance < 2000)
            {
                MessageBox.Show("Your Balance is less that 2000 kr");
            }
            else
            {
                int newbalance = balance - 2000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = " + newbalance + " where AccNum = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction2000();
                    Home home = new Home();
                    home.Show();
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
