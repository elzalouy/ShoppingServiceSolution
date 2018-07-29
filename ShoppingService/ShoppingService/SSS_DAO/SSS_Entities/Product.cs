using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingService.SSS_DAO.SSS_Entities
{
    public class Product
    {

        [Required]
        public string Product_Name { get; set; }
        [Key]
        [Required]
        public int Product_ID { get; set; }
        [Required]
        public long Product_UnitPrice { get; set; }
        [Required]
        public long Product_WholeSalePrice { get; set; }
        [Required]
        public string Product_Type { get; set; }
        [Required]
        public string Product_Image { get; set; }
        public ICollection<SalesNumber> Sales_Num_Monthly { get; set; }

    }
}