using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35_ProductReviewMangement
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 25, UserId = 1, IsLike = true, Review = "good", Rating = 80 },
                new ProductReview() { ProductId = 24, UserId = 2, IsLike = false, Review = "bad", Rating = 20 },
                new ProductReview() { ProductId = 23, UserId = 3, IsLike = true, Review = "average", Rating = 50 },
                new ProductReview() { ProductId = 22, UserId = 4, IsLike = true, Review = "nice", Rating = 90 },
                new ProductReview() { ProductId = 21, UserId = 5, IsLike = false, Review = "poor", Rating = 10 },
                new ProductReview() { ProductId = 20, UserId = 6, IsLike = true, Review = "good", Rating = 80 },
                new ProductReview() { ProductId = 19, UserId = 7, IsLike = false, Review = "bad", Rating = 20 },
                new ProductReview() { ProductId = 18, UserId = 8, IsLike = true, Review = "average", Rating = 50 },
                new ProductReview() { ProductId = 17, UserId = 9, IsLike = true, Review = "nice", Rating = 90 },
                new ProductReview() { ProductId = 16, UserId = 10, IsLike = false, Review = "poor", Rating = 10 },
                new ProductReview() { ProductId = 15, UserId = 11, IsLike = true, Review = "good", Rating = 80 },
                new ProductReview() { ProductId = 14, UserId = 12, IsLike = false, Review = "bad", Rating = 20 },
                new ProductReview() { ProductId = 13, UserId = 13, IsLike = true, Review = "average", Rating = 50 },
                new ProductReview() { ProductId = 12, UserId = 14, IsLike = true, Review = "nice", Rating = 90 },
                new ProductReview() { ProductId = 11, UserId = 15, IsLike = false, Review = "poor", Rating = 10 },
                new ProductReview() { ProductId = 10, UserId = 16, IsLike = true, Review = "good", Rating = 80 },
                new ProductReview() { ProductId = 9, UserId = 17, IsLike = false, Review = "bad", Rating = 20 },
                new ProductReview() { ProductId = 8, UserId = 18, IsLike = true, Review = "average", Rating = 50 },
                new ProductReview() { ProductId = 7, UserId = 19, IsLike = true, Review = "nice", Rating = 90 },
                new ProductReview() { ProductId = 6, UserId = 20, IsLike = false, Review = "poor", Rating = 10 },
                new ProductReview() { ProductId = 5, UserId = 21, IsLike = false, Review = "poor", Rating = 10 },
                new ProductReview() { ProductId = 4, UserId = 22, IsLike = true, Review = "good", Rating = 80 },
                new ProductReview() { ProductId = 3, UserId = 23, IsLike = false, Review = "bad", Rating = 20 },
                new ProductReview() { ProductId = 2, UserId = 24, IsLike = true, Review = "average", Rating = 50 },
                new ProductReview() { ProductId = 1, UserId = 25, IsLike = true, Review = "nice", Rating = 90 },
            };
            DisplayProducts(list);
            ProductReviewFetchRecords.RetrieveTop3BasedOnRating(list);
            ProductReviewFetchRecords.FetchDataBasedOnProductIdAndRating(list);
            ProductReviewFetchRecords.CountProductIdUsingGroupBy(list);
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
