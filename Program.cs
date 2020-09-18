using System;
using System.Collections.Generic;

namespace Lazy
{
    public class Program
    {
        /// <summary>
        /// Lazy example
        /// Example of usecase: A program where we have 10 viewmodels. 
        /// We can "create" all the viewmodels, but they will only actually be created for real when needed
        /// and thereby splitting the workload over time and avoid a heavy start up of the program. 
        /// </summary>

        static List<Lazy<Product>> products = new List<Lazy<Product>>();

        static void Main(string[] args)
        {
            // Create the list here, but the objects are actually not created yet. 
            CreateList();

            // At this moment we are creating the FIRST object of the list. 
            // Important to notice that the object is specifically created when we call the .Value
            Console.WriteLine(products[0].Value.ID);
        }

        private static void CreateList()
        {
            // Just creating random objects
            products.Add(new Lazy<Product>(() => new Product(1, 1)));
            products.Add(new Lazy<Product>(() => new Product(2, 2)));
            products.Add(new Lazy<Product>(() => new Product(3, 3)));
            products.Add(new Lazy<Product>(() => new Product(4, 4)));
            products.Add(new Lazy<Product>(() => new Product(5, 5)));
        }
    }
}
