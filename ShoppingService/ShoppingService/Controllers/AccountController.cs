using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingService.Models;
using SS_Repository;

namespace ShoppingService.Controllers
{
    public class AccountController : Controller
    {
        Account CurrentAccount = new Account();
        [HttpGet]
        public ActionResult NewAccount()
        {
            Account_Model account = new Account_Model();
            return View(account);
        }
        [HttpPost]
        public ActionResult NewAccount(Account_Model Account)
        {
            if (ModelState.IsValid)
            {
                if (CurrentAccount == null && Account!=null)
                {
                    if (Account_Repository.Check_Account(Account.AccountEmail))
                    {
                        CurrentAccount.AccountEmail = Account.AccountEmail;
                        CurrentAccount.Account_CoverPhoto = null;
                        CurrentAccount.Account_HashPass = Account.Account_HashPass;
                        CurrentAccount.Account_Profile_Photo = null;
                        CurrentAccount.Account_Type = Account.Account_Type == ShoppingService.Models.Account_Type.seller ?
                            SS_Repository.Account_Type.Seller:
                            SS_Repository.Account_Type.Client;
                        CurrentAccount.Account_UserName = Account.Account_UserName;
                        CurrentAccount.BirthDate = Account.BirthDate;
                        CurrentAccount.Gender = Account.Gender==Models.Gender.Male ? SS_Repository.Gender.Male:SS_Repository.Gender.Female;
                        Account_Repository.AddAccount(CurrentAccount);
                    }
                }
            }
            return RedirectToAction("MyAccount",Account);
        }
        public ActionResult MyAccount(Account_Model Account)
        {
            return View(Account);
        }
    }
}