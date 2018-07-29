using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingService.SSS_DAO.SSS_Entities
{
    public class OrderDetails
    {
        [Key][Required]
        public int OrderDeatils_ID { get; set; }
        [Required]
        public virtual ClientOrder Order { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}