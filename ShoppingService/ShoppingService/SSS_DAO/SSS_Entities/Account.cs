using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingService.SSS_DAO.SSS_Entities
{
    public class Account
    {
        [Required]
        public string Account_Type { get; set; }
        [Key]
        [Required]
        public int Account_ID { get; set; }
        [Required]
        public string Account_UserName { get; set; }
        [EmailAddress]
        [Required]
        public string AccountEmail { get; set; }
        [Required]
        public string Account_HashPass { get; set; }
        public string Account_Profile_Photo { get; set; }
        public string Account_CoverPhoto { get; set; }
        [Required]
        public int Account_Member_ID { get; set; }
    }
}