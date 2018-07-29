using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingService.SSS_DAO.SSS_Entities
{
    public class Administrators
    {
        [Required]
        [Key]
        public int Admin_ID { get; set; }
        [Required]
        public string Admin_Name { get; set; }
        [Required]
        public string WorkType { get; set; }
        [Required]
        [EmailAddress]
        public string Admin_Email { get; set; }
        [CreditCard]
        public string Admin_CreditID { get; set; }
        public string Admin_Salary { get; set; }
        public string Admin_Address { get; set; }
        [Required]
        public Account Admin_Account { get; set; }
    }
}