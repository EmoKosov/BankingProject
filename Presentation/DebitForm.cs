﻿using BankingProject.Business;
using BankingProject.Data;
using BankingProject.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingProject
{
    /*
   The DebitForm code
   Contains all background services for this form
   */
    public partial class DebitForm : Form
    {
        //Initialize the required controllers and constructor
        UserAccountController accController = new UserAccountController();
        DebitController debitController = new DebitController();
        public DebitForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("В брой");
            comboBox1.Items.Add("Чек");
            lblDate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }
        //Run when "Details" button is clicked. Get information for the UserAccount by Number
        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            decimal accNo = Convert.ToDecimal(txtAccNum.Text);
            var item = accController.Get(accNo).FirstOrDefault();
            txtName.Text = item.Name;
            txtOldBalance.Text = Convert.ToString(item.Balance);
        }
        //Run when "Save" button is clicked. Get information for the detalis of UserAccount and update them with specified data
        private void btnSave_Click(object sender, EventArgs e)
        {
            Debit debit = new Debit();
            {
                debit.Date = lblDate.Text;
                debit.AccountNo = Convert.ToDecimal(txtAccNum.Text);
                debit.Name = txtName.Text;
                debit.OldBalance = Convert.ToDecimal(txtOldBalance.Text);
                debit.Mode = comboBox1.SelectedItem.ToString();
                debit.DebAmount = Convert.ToDecimal(txtDepositAmount.Text);
            }
            debitController.Add(debit);
            decimal accNo = Convert.ToDecimal(txtAccNum.Text);
            var accountReciever = accController.Get(accNo).FirstOrDefault();
            accController.MakeDebitTransaction(debit.DebAmount, accountReciever);
            MessageBox.Show($"Успешeно изтеглихте {debit.DebAmount.ToString()}лв. от сметката на {debit.Name}!");
        }
    }
}