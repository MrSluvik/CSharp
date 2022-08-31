using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Structure_Classes_Properties
{
    partial class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.Unicode;//для кирилиці

            Article article1 = new Article(1, "Phone", 2000.60, Article.ArticleType.Gadget);
            Article article2 = new Article(2, "Table", 1500, Article.ArticleType.Furniture);
            Article article3 = new Article(3, "T-Shirt", 50, Article.ArticleType.Clothes);

            article1.Print(); WriteLine();
            article2.Print(); WriteLine();
            article3.Print(); WriteLine();

            Client client = new Client(1, "Jackson Michael Joseph", "LA , strit Big ,hous 2", "+4027349248675", 10, 50000);
            client.Print();



            RequestItem requestItem1 = new RequestItem(article1, 2);
            RequestItem requestItem2 = new RequestItem(article2, 1);
            RequestItem requestItem3 = new RequestItem(article3, 5);

            requestItem1.Print();
            requestItem2.Print();
            requestItem3.Print();

            List<RequestItem> List1 = new List<RequestItem>();

            List1.Add(requestItem1);
            List1.Add(requestItem2);
            List1.Add(requestItem3);

            Request request = new Request(1, client, Request.PayType.Check, List1);
            request.Print();
            WriteLine();


            Program.Main5();
            WriteLine();
            Program.Main6();
            WriteLine();
            Program.Main7();

        }
    }
}
