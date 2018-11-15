using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace SS_Repository
{
    public enum Account_Type
    {
        Seller,Client
    }
      public enum Gender
    {
        Male,Female
    }
    public class Account
    {
        [Required]
        public Account_Type Account_Type { get; set; }
        public int Account_ID { get; set; }
        [Required]
        public string Account_UserName { get; set; }
        [Required]
        [EmailAddress]
        public string AccountEmail { get; set; }
        [Required]
        public string Account_HashPass { get; set; }
        public string Account_Profile_Photo { get; set; }
        public string Account_CoverPhoto { get; set; }
        [Required]
        public bool Validation { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public Gender Gender { get; set; }
    }
}