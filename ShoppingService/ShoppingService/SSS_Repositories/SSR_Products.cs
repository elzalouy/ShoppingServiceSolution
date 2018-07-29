using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingService.SSS_DAO.SSS_Entities;
using ShoppingService.SSS_DAO.SSS_Context;
namespace ShoppingService.SSS_Repositories
{
    public class SSR_Products
    {
        public static List<Product> GetAllProducts()
        {
            List<Product> ListOfProduct = new List<Product>();
            using (var context=new ShoppingServiceContext())
            {
                if (context.Product_Table.ToList().Any())
                {
                    ListOfProduct = context.Product_Table.ToList();
                }
            }
            return ListOfProduct;
        }
    }
}