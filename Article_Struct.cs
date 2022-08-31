using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Structure_Classes_Properties
{

    struct Article
    {
        private int codeProduct;
        private string nameProduct;
        public double priceProduct;
        private ArticleType articleType;
        public enum ArticleType
        {
            Foods, Clothes, Furniture, Gadget
        }
        public Article(int codeProduct, string nameProduct, double priceProduct, ArticleType articleType)
        {
            this.codeProduct = codeProduct;
            this.nameProduct = nameProduct;
            this.priceProduct = priceProduct;
            this.articleType = articleType;
        }

        public void Print()
        {
            WriteLine($"код товара :{codeProduct}  \nназвание товара: { nameProduct}  \nценa товара: { priceProduct} \nтип товарa:{ articleType}");
        }
        public void PrintProduct()
        {
            WriteLine($"название товара: { nameProduct}");
        }
    }
}
