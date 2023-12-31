﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();
        }
        //public static string AccNumber;
        private void Home_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Account Number: " + Login.AccNumber;
            //AccNumber = Login.AccNumber;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            this.Hide(); 
            balance.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePIN changePIN = new ChangePIN();
            changePIN.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FastCash fastCash = new FastCash();
            fastCash.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Statement statement = new Statement();
            statement.Show();
            this.Hide();
        }
    }
}
