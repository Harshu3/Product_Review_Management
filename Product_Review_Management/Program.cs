using System;

namespace Product_Review_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management using LINQ Problem!");
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview(){ProductId = 1, UserId = 1, Review = "good", IsLike = true, Rating = 80},
                new ProductReview(){ProductId = 2, UserId = 2, Review = "bad", IsLike = false, Rating = 30},
                new ProductReview(){ProductId = 3, UserId = 4, Review = "average", IsLike = true, Rating = 50},
                new ProductReview(){ProductId = 2, UserId = 3, Review = "good", IsLike = true, Rating = 90},
                new ProductReview(){ProductId = 4, UserId = 5, Review = "bad", IsLike = false, Rating = 20},
                new ProductReview(){ProductId = 1, UserId = 6, Review = "good", IsLike = true, Rating = 80}
            };
            DisplayProducts(list);
        }

        public static void DisplayProducts(List<ProductReview> list)
        {
            foreach (ProductReview product in list)
            {
                Console.WriteLine(product);
            }
        }
    }
}