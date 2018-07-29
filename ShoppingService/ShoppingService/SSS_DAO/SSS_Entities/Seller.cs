using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingService.SSS_DAO.SSS_Entities
{
    public class Seller
    {

        [Required]
        [Key]
        public int Seller_ID { get; set; }
        [Required]
        [MaxLength(128)]
        public string Seller_Name { get; set; }
        [Required]
        [EmailAddress]
        public string Seller_Email { get; set; }
        [CreditCard]
        public string Seller_CreditID { get; set; }
        public long Seller_Salary { get; set; }
        public string Seller_Country { get; set; }
        public string Seller_Address { get; set; }
        [Required]
        public virtual Account Seller_Account { get; set; }
        public SellerSales SellerSales { get; set; }
    }
}