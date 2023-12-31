﻿using System;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Operation operations = new Operation();
            list.Add(new Product()
            {
                ProductID = 1,
                UserID = 1,
                Rating = 5,
                Review = "Good",
                isLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 2,
                UserID = 1,
                Rating = 3,
                Review = "Average",
                isLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 3,
                UserID = 1,
                Rating = 1,
                Review = "Bad",
                isLike = false,
            });
            list.Add(new Product()
            {
                ProductID = 4,
                UserID = 2,
                Rating = 4,
                Review = "Good",
                isLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 5,
                UserID = 2,
                Rating = 2,
                Review = "Bad",
                isLike = false,
            });
            list.Add(new Product()
            {
                ProductID = 6,
                UserID = 3,
                Rating = 5,
                Review = "Good",
                isLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 7,
                UserID = 4,
                Rating = 4,
                Review = "Good",
                isLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 8,
                UserID = 4,
                Rating = 3,
                Review = "Average",
                isLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 9,
                UserID = 5,
                Rating = 2,
                Review = "Bad",
                isLike = false,
            });
            list.Add(new Product()
            {
                ProductID = 10,
                UserID = 6,
                Rating = 3,
                Review = "Average",
                isLike = false,
            });
            list.Add(new Product()
            {
                ProductID = 11,
                UserID = 6,
                Rating = 5,
                Review = "Good",
                isLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 12,
                UserID = 7,
                Rating = 2,
                Review = "Bad",
                isLike = false,
            });
            list.Add(new Product()
            {
                ProductID = 13,
                UserID = 7,
                Rating = 5,
                Review = "Good",
                isLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 14,
                UserID = 8,
                Rating = 4,
                Review = "Good",
                isLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 15,
                UserID = 8,
                Rating = 1,
                Review = "Bad",
                isLike = false,
            });
            //operations.Display(list);
            //operations.RetrieveTopRecords(list);
            //operations.RetrieveAllRecordsWithCondition(list);
            //operations.UsingGroupBy(list);
            //operations.RetrieveProductIdAndReview(list);
            //operations.SkipTopRecords(list);
            //operations.AddDataToDataTable(list);
            //operations.RetreiveRecordsFromDataTable(list);
            //operations.AvgRating(list);
            //operations.RetreiveUsingReview(list);
            operations.RetreiveUsingRating(list);
        }
    }
}
