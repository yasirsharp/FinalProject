using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Kulaklık",    UnitPrice = 15,     UnitsInStock = 15},
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Telefon",     UnitPrice = 500,    UnitsInStock = 35},
                new Product{ProductId = 3, CategoryId = 2, ProductName = "Laptop",      UnitPrice = 1500,   UnitsInStock = 2},
                new Product{ProductId = 4, CategoryId = 2, ProductName = "Masa",        UnitPrice = 150,    UnitsInStock = 65},
                new Product{ProductId = 5, CategoryId = 3, ProductName = "Mouse",       UnitPrice = 85,     UnitsInStock = 501}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ = Language Integrated Query
            //Lambda (p=>)
            /*
             
            foreach (var p in _products)
            {

            }

             || ||
             || ||
             || ||
             || ||
             || ||

            .SingleOrDefault(p => p.ProductId == product.ProductId)
            */
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            //_products.Where(x => x.CategoryId == 5 && x.ProductId == 15).Skip(100 * (2 - 1)).Take(100);
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p=>p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName     = product.ProductName;
            product.CategoryId              = product.CategoryId;
            product.UnitPrice               = product.UnitPrice;
            product.UnitsInStock            = product.UnitsInStock;
        }
    }
}