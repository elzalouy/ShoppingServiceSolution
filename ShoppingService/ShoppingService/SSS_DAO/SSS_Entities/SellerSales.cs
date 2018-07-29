using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingService.SSS_DAO.SSS_Entities
{
    public class SellerSales
    {
        [Key][Required]
        public int SellerSales_ID { get; set; }
        [Required]
        public virtual Seller Seller { get; set; }
        public ICollection<Product> ProductsSales { get; set; }
        public DateTime MonthDate { get; set; }
    }
}