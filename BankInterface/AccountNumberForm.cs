﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankInterface
{
    public partial class AccountNumberForm : Form
    {
        public AccountNumberForm()
        {
            InitializeComponent();
        }

        private void accountPad1_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("1");
        }

        private void accountPad2_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("2");
        }

        private void accountPad3_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("3");
        }

        private void accountPad4_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("4");
        }

        private void accountPad5_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("5");
        }

        private void accountPad6_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("6");
        }

        private void accountPad7_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("7");
        }

        private void accountPad8_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("8");
        }

        private void accountPad9_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("9");
        }

        private void accountPad0_Click(object sender, EventArgs e)
        {
            accountNumberBox.AppendText("0");
        }

        private void accountPadOK_Click(object sender, EventArgs e)
        {
            if (String.Equals(accountNumberBox.Text, "1234567890", StringComparison.Ordinal))
            {
                //hides the current form and opens the pin form
                this.Hide();

                foreach (Form pinNumberForm in Application.OpenForms)
                {
                    if (pinNumberForm is PinNumberForm)
                    {
                        pinNumberForm.Show();
                        return;
                    }
                }

                PinNumberForm f2 = new PinNumberForm();
                f2.Show();
            }

            else
            {
                MessageBox.Show("Invalid Account Number");
            }

        }
        private void accountPadClear_Click(object sender, EventArgs e)
        {
            accountNumberBox.Text = "";
        }

        private void accountBackspace_Click(object sender, EventArgs e)
        {
            if(accountNumberBox.Text.Length >0)
            accountNumberBox.Text = accountNumberBox.Text.Remove((accountNumberBox.Text.Length - 1), 1);//remove 1 char from account text box
        }
    }
}
