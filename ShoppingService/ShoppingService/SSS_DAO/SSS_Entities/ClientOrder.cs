using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingService.SSS_DAO.SSS_Entities
{
    public class ClientOrder
    {
        [Required][Key]
        public int Order_ID { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public long OderCost { get; set; }
        [Required]
        public virtual Seller Seller { get; set; }
        [Required]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        [Required]
        public virtual Client Client { get; set; }
    }
}