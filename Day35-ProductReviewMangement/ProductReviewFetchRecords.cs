using System;
using System.Collections.Generic;
using System.Data;
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
        public static void CountProductIdUsingGroupBy(List<ProductReview> list)    
        {
            Console.WriteLine("\n Count ProductId Using GroupBy ");
            var result = list.GroupBy(p => p.ProductId).Select(p => new { Id = p.Key, count = p.Count() }).ToList();
            foreach (var obj in result)
            {
                Console.WriteLine($"ProductID:{obj.Id} Count:{obj.count}");
            }
        }
        public static void GetProductIdAndReview(List<ProductReview> list)     
        {
            Console.WriteLine("\n Get ProductId And Review ");
            var result = list.Select(p => new { Id = p.ProductId, review = p.Review }).ToList();
            foreach (var obj in result)
            {
                Console.WriteLine($"ProductID:{obj.Id} Review:{obj.review}");
            }
        }
        public static void Skip5Records(List<ProductReview> list) 
        {
            Console.WriteLine("\n Skip5Records Display remaining product reviews");
            var result = list.OrderByDescending(p => p.Rating).Skip(5).ToList();
            Program.DisplayProducts(result);
        }
      public static void AddDataToTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID");
            table.Columns.Add("UserId");
            table.Columns.Add("IsLike");
            table.Columns.Add("Review");
            table.Columns.Add("Rating");
            table.Rows.Add(25, 1, true, "good", 80);
            table.Rows.Add(24, 2, false, "bad", 20);
            table.Rows.Add(23, 4, true, "average", 50);
            table.Rows.Add(22, 4, true, "nice", 90);
            table.Rows.Add(21, 5, false, "poor", 10);
            table.Rows.Add(20, 6, true, "good", 80);
            table.Rows.Add(19, 7, false, "bad", 20);
            table.Rows.Add(18, 8, true, "average", 50);
            table.Rows.Add(17, 9, true, "nice", 90);
            table.Rows.Add(16, 10, false, "poor", 10);
            table.Rows.Add(15, 11, true, "good", 80);
            table.Rows.Add(14, 12, true, "false", 20);
            table.Rows.Add(13, 13, true, "average", 50);
            table.Rows.Add(12, 14, true, "nice",90);
            table.Rows.Add(11, 15, false, "poor", 10);
            table.Rows.Add(10, 16, true, "good", 80);
            table.Rows.Add(9, 17, false, "bad", 20);
            table.Rows.Add(8, 18, true, "average", 50);
            table.Rows.Add(7, 19, true, "nice", 90);
            table.Rows.Add(6, 20, false, "poor", 10);
            table.Rows.Add(5, 21, false, "poor", 10);
            table.Rows.Add(4, 22, true, "good", 80);
            table.Rows.Add(3, 23, false, "bad", 20);
            table.Rows.Add(2, 24, true, "average", 50);
            table.Rows.Add(1, 25, true, "nice", 90);
            DisplayProductTable(table);
      }
        public static void  DisplayProductTable(DataTable table)
        {
            var productID = from products in table.AsEnumerable() select products.Field<string>("ProductID");
            var userId = from products in table.AsEnumerable() select products.Field<string>("UserId");
            var isLike = from products in table.AsEnumerable() select products.Field<string>("IsLike");
            var review = from products in table.AsEnumerable() select products.Field<string>("Review");
            var rating = from products in table.AsEnumerable() select products.Field<string>("Rating");
        }
    }
}
