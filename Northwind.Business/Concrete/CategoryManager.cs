using Northwind.Business.Abstract;
using Northwind.DataAcces.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal { get; set; }

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll().ToList();           
        }

        public List<Category> GetAll2()
        {
            List<Category> liste = new List<Category>();
            liste.AddRange(_categoryDal.GetAll().ToList());
            liste.Add(new Category { CategoryId = liste.Count + 1, CategoryName = "Hepsi" });
            return liste;
        }
    }
}
