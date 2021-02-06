using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.ValidationRules.FluentValidaton;
using Northwind.DataAcces.Abstract;
using Northwind.DataAcces.Concrete;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal { get; set; }

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }        
        
        public List<Product> GetAll()
        {
            return _productDal.GetAll().ToList();
        }

        public List<Product> GetProductsByCategory(int categoryID)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryID);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p=>p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Add(Product product)
        {
            ProductValidator validationRules = new ProductValidator();
            var result = validationRules.Validate(product);
            if (result.Errors.Count > 0 )
            {
                throw new ValidationException(result.Errors);
            }
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch (Exception)
            {

                throw new Exception("Delete Failed!");
            }
        }
    }
}
