using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingService.SSS_DAO.SSS_Entities
{
    public class Client
    {
        [Required]
        [Key]
        public int ClientID { get; set; }
        [Required]
        [MaxLength(128)]
        public string Client_Name { get; set; }
        [EmailAddress]
        [Required]
        public string Client_Email { get; set; }
        public DateTime Client_BirthDate { get; set; }
        public DateTime Client_StartDate { get; set; }
        public virtual ICollection<ClientOrder> Client_Orders { get; set; }
        public virtual Account Client_Account { get; set; }
        public virtual ICollection<Product> Client_Bought_Products { get; set; }

        [CreditCard]
        public string Client_CreditID { get; set; }

    }
}