using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingService.SSS_DAO.SSS_Entities
{
    public class SalesNumber
    {
        [Required]
        [Key]
        public int Sale_Number_ID { get; set; }
        public int Number { get; set; }
        public long Earnings { get; set; }
        [Required]
        public DateTime MonthDate { get; set; }
        public virtual Product Product { get; set; }
        public long Loss { get; set; }
    }
}