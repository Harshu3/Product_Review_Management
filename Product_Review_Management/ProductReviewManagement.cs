using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management
{
    internal class ProductReviewManagement
    {
        public static void RetrieveTop3Products(List<ProductReview> list)
        {
            Console.WriteLine("\nRetrieve Top3 Products");
            List<ProductReview> top3Records = list.OrderByDescending(p => p.Rating).Take(3).ToList();
            Program.DisplayProducts(top3Records);
        }
    }
}