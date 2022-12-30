using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35_ProductReviewMangement
{
    internal class ProductReviewFetchRecords
    {
        public static void RetrieveTop3BasedOnRating(List<ProductReview> list)
        {
            Console.WriteLine("\n Retrieve Top3 Records Based on Rating");
            var top3Records = list.OrderByDescending(p => p.Rating).Take(3).ToList();
            Program.DisplayProducts(top3Records);
        }
        public static void FetchDataBasedOnProductIdAndRating(List<ProductReview> list)
        {
            Console.WriteLine("\n Fetch Data Based On Product Id And Rating");
            List<ProductReview> result = list.Where(p => p.Rating > 3 && (p.ProductId == 1 || p.ProductId == 4 || p.ProductId == 9)).ToList();
            Program.DisplayProducts(result);
        }
    }
}
