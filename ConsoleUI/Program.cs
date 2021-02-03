using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var list = productManager.GetAll();
            foreach (var product in list)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}