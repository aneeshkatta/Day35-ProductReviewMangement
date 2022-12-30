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
            table.Rows.Add(12, 14, true, "nice", 90);
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
        public static void DisplayProductTable(DataTable table)
        {
            DataSet set = new DataSet();
            var productID = from ProductReview in table.AsEnumerable() select ProductReview.Field<string>("ProductID");
            var userId = from ProductReview in table.AsEnumerable() select ProductReview.Field<string>("UserId");
            var isLike = from ProductReview in table.AsEnumerable() select ProductReview.Field<string>("IsLike");
            var review = from ProductReview in table.AsEnumerable() select ProductReview.Field<string>("Review");
            var rating = from ProductReview in table.AsEnumerable() select ProductReview.Field<string>("Rating");
            // For each table in the DataSet, print the values of each row.

            DataRow[] rows = table.Select();

            // Print the value one column of each DataRow.
            for (int i = 0; i < rows.Length; i++)
            {
                if (i == 0)//for header
                {
                    Console.WriteLine("ProductID" + " " + "UserId" + " " + "IsLike" + " " + "Review" + " " + "ProductID" + " " + "Rating");
                }
                Console.Write(rows[i]["ProductID"] + "\t" + rows[i]["UserId"] + "\t" + rows[i]["IsLike"] + "\t" + rows[i]["Review"] + "\t" + rows[i]["ProductID"] + "\t" + rows[i]["Rating"] + "\n");
            }
        }

    }
}
