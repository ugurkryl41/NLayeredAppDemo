using Northwind.DataAcces.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAcces.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product> {
                new Product{
                    ProductId=1, CategoryId=1, ProductName="Kalem", QuantityPerUnit="1x6", UnitPrice=3500, UnitsInStock=45
                }
            };
            return products;
        }
        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }    

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
