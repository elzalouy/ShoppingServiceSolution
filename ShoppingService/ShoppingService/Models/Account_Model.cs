
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingService.Models
{
    public enum Account_Type
    {
        seller,Client
    }
    public enum Gender
    {
        Male,Female
    }
    public class Account_Model
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