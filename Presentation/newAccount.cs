﻿using BankingProject.Data;
using BankingProject.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingProject.Business;

namespace BankingProject
{
    public partial class newAccount : Form
    {
        private UserAccountController accController = new UserAccountController();
        decimal no;

        public newAccount()
        {
            InitializeComponent();
            var item = accController.GetAllAccounts();
            no = item.LastOrDefault().AccountNo + 1;
            txtAccNumber.Text = Convert.ToString(no);
            lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender = "";
            string m_status = "";
            if (rButtonMale.Checked)
            {
                gender = "male";
            }
            else if (rButtonFemale.Checked)
            {
                gender = "female";
            }
            if (rbtnMarried.Checked)
            {
                m_status = "married";
            }
            else if (rbtnUnmarried.Checked)
            {
                m_status = "Unmarried";
            }
            UserAccount acc = new UserAccount();
            {
                acc.AccountNo = Convert.ToDecimal(txtAccNumber.Text);
                acc.Name = txtName.Text;
                acc.Dob = dateTimePicker1.Value.ToString();
                acc.PhoneNo = txtBoxPhone.Text;
                acc.Address = txtBoxAddress.Text;
                acc.Oblast = txtBoxOblast.Text;
                acc.State = txtBoxCity.Text;
                acc.Gender = gender;
                acc.MaritialStatus = m_status;
                acc.MotherName = txtMother.Text;
                acc.FatherName = txtFather.Text;
                acc.Balance = Convert.ToDecimal(txtBal.Text);
                acc.Date = lblDate.Text;
            };
            accController.Add(acc);
            MessageBox.Show("Данните са записани!");
        }
    }
}