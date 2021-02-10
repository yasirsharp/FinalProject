using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    //SOLİD
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transform Object
            ProductTest();
            /*IOC*/
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var list = productManager.GetAll();
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName +" / "+ product.CategoryName);
            }
        }
    }
}