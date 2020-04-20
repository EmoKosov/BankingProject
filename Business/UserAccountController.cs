﻿using BankingProject.Data;
using BankingProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.Business
{
    public class UserAccountController
    {
        private banking_dbContext context;
        public UserAccountController(banking_dbContext cont)
        {
            this.context = cont;
        }
        public UserAccountController()
        {
            context = new banking_dbContext();
        }
        public List<UserAccount> GetAllAccounts()
        {
            return context.UserAccount.ToList();
        }
        public void Add(UserAccount userAccount)
        {
            context.UserAccount.Add(userAccount);
            context.SaveChanges();
        }
        public void Delete(decimal accNo)
        {
            UserAccount acc = context.UserAccount.First(s => s.AccountNo.Equals(accNo));
            if (acc != null)
            {
                context.UserAccount.Remove(acc);
                context.SaveChanges();
            }
        }
        public List<UserAccount> Get(decimal accNo)
        {
            var items = context.UserAccount.Where(a => a.AccountNo == accNo);
            return items.ToList();
        }
        public List<UserAccount> Get(string name)
        {
            var items = context.UserAccount.Where(a => a.Name == name);
            return items.ToList();
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}