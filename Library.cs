using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public class Library
    {
         Product[] Products = new Product[0];

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
                Products[Products.Length - 1] = product;
        }
        public int GetJournalsCount()
        {
            int count = 0;
            foreach(var item in Products)
            {
                if(item is Journal)
                {
                    count++;
                }
            }
            return count;
                
        }
        public int GetBooksCount()
        {
            int count = 0;
            foreach(var item in Products)
            {
                if(item is Book)
                {
                    count++;
                }
            }
            return count;
        }
        public Product[] GetProducts(bool isBook)
        {
            Product[] products = new Product[0];
            if (isBook)
            {
                products = GetBookProducts();
            }
            else
                products = GetJournalProducts();
            return products;

          
            

                
        }
        public Product[] GetBookProducts()
        {
            Product[] books = new Product[0];

            foreach(var item in Products)
            {
                if(item is Book)
                {
                    Array.Resize(ref Products, Products.Length + 1);
                    Products[Products.Length - 1] = item;
                }

            }
            return books;
        }
        public Product[] GetJournalProducts()
        {
            Product[] journals = new Product[0];
            foreach(var item in Products)
            {
                if(item is Journal)
                {
                    Array.Resize(ref Products, Products.Length + 1);
                    Products[Products.Length - 1] = item;
                }
            }
            return journals;
        }
         
       
    }
}
