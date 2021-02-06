using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers;
using Northwind.DataAcces.Concrete.EntityFramework;
using Northwind.DataAcces.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IProductService _productService = InstanceFactory.GetInstance<IProductService>();
        private ICategoryService _categoryService = InstanceFactory.GetInstance<ICategoryService>();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll2();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";

            cbxCategoryIdUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryIdUpdate.DisplayMember = "CategoryName";
            cbxCategoryIdUpdate.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((int)cbxCategory.SelectedValue != _categoryService.GetAll2().Count)
                {
                    dgwProduct.DataSource = _productService.GetProductsByCategory((int)cbxCategory.SelectedValue);
                }
                else
                {
                    tbxProductName.Text = "";
                    LoadProducts();
                }
            }
            catch
            {
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            string key = tbxProductName.Text;
            if (!String.IsNullOrEmpty(key))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(key);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = (int)cbxCategoryId.SelectedValue,
                    ProductName = tbxProductNameAdd.Text,
                    QuantityPerUnit = tbxQuantityPerUnitAdd.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
                    UnitsInStock = Convert.ToInt16(tbxUnitPriceAdd.Text)
                });

                MessageBox.Show("Added a Product");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnProductUpdated_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(cbxCategoryIdUpdate.SelectedValue),
                ProductName = tbxProductNameUpdate.Text,
                QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                UnitsInStock = Convert.ToInt16(tbxUnitsInStockUpdate.Text),
            });

            MessageBox.Show("Updated a Product");
            LoadProducts();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Delete(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                });

                MessageBox.Show("Delete a Product");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxProductNameUpdate.Text = row.Cells[2].Value.ToString();
            cbxCategoryIdUpdate.SelectedValue = row.Cells[1].Value;
            tbxQuantityPerUnitUpdate.Text = row.Cells[3].Value.ToString();
            tbxUnitPriceUpdate.Text = row.Cells[4].Value.ToString();
            tbxUnitsInStockUpdate.Text = row.Cells[5].Value.ToString();
        }
    }
}
