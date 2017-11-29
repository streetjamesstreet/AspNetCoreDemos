﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreDemos.Models
{
	public class ProductService : IDisposable
    {
        private SampleEntitiesDataContext entities;

        public ProductService(SampleEntitiesDataContext entities)
        {
            this.entities = entities;
        }

        public IEnumerable<ProductViewModel> Read()
        {
            var categories = entities.Categories.ToList();

            return entities.Products.ToList().Select(product => {
                var category = categories.First(c => product.CategoryID == c.CategoryID);

                return new ProductViewModel
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    UnitPrice = product.UnitPrice.HasValue ? product.UnitPrice.Value : default(decimal),
                    UnitsInStock = product.UnitsInStock.HasValue ? product.UnitsInStock.Value : default(int),
                    QuantityPerUnit = product.QuantityPerUnit,
                    Discontinued = product.Discontinued,
                    UnitsOnOrder = product.UnitsOnOrder.HasValue ? product.UnitsOnOrder.Value : default(int),
                    CategoryID = product.CategoryID,
                    Category = new CategoryViewModel()
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName
                    },
                    LastSupply = DateTime.Today
                };
            });
        }

        public void Create(ProductViewModel product)
        {
            var entity = new Product();

            entity.ProductName = product.ProductName;
            entity.UnitPrice = product.UnitPrice;
            entity.UnitsInStock = (short)product.UnitsInStock;
            entity.Discontinued = product.Discontinued;
            entity.CategoryID = product.CategoryID;

            if (entity.CategoryID == null)
            {
                entity.CategoryID = 1;
            }

            if (product.Category != null)
            {
                entity.CategoryID = product.Category.CategoryID;
            }

            entities.Products.Add(entity);
            entities.SaveChanges();

            product.ProductID = (int)entity.ProductID;
        }

        public void Update(ProductViewModel product)
        {
            var entity = new Product();

            entity.ProductID = product.ProductID;
            entity.ProductName = product.ProductName;
            entity.UnitPrice = product.UnitPrice;
            entity.UnitsInStock = (short)product.UnitsInStock;
            entity.Discontinued = product.Discontinued;
            entity.CategoryID = product.CategoryID;

            if (product.Category != null)
            {
                entity.CategoryID = product.Category.CategoryID;
            }

            entities.Products.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Destroy(ProductViewModel product)
        {
            var entity = new Product();

            entity.ProductID = product.ProductID;
			
            entities.Products.Attach(entity);

            entities.Products.Remove(entity);

            var orderDetails = entities.OrderDetails.Where(pd => pd.ProductID == entity.ProductID);

            foreach (var orderDetail in orderDetails)
            {
                entities.OrderDetails.Remove(orderDetail);
            }

            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }
    }
}