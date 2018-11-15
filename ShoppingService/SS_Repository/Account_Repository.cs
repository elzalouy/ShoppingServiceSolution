using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
namespace SS_Repository
{
    public static class Account_Repository
    {
        public static void AddAccount(Account NewAccount)
        {
            if (NewAccount != null)
            {
                using (var context = new Context.Context())
                {
                    context.AccountSet.Add(NewAccount);
                    context.SaveChanges();
                }
            }
        }
        public static bool Check_Account(string Email)
        {
            bool check;
            using(var context=new Context.Context())
            {
                check= context.AccountSet.Where(s => s.AccountEmail == Email).Any();
            }
            return check;
        }
    }
}