using E_Commerce.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.Forms
{
    public partial class ProductsForm : Form
    {
        ProductsService productsService;
        CategoriesService categoriesService;
        int product_id;
        public ProductsForm()
        {
            InitializeComponent();
            productsService = new ProductsService(ConfigurationManager.ConnectionStrings["ECommerceDB"].ConnectionString);
            categoriesService = new CategoriesService(ConfigurationManager.ConnectionStrings["ECommerceDB"].ConnectionString);
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            dgv_Products_PF.DataSource = productsService.GetAll();
            combo_category_PF.DataSource = categoriesService.GettALL();
            combo_category_PF.DisplayMember = categoriesService.GettALL().Columns["CategoryName"].ToString();
            combo_category_PF.ValueMember = categoriesService.GettALL().Columns["CategoryId"].ToString();
        }

        private void dgv_Products_PF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            product_id = (int)dgv_Products_PF.SelectedRows[0].Cells[0].Value;
            txt_productName_PF.Text = dgv_Products_PF.SelectedRows[0].Cells[1].Value.ToString();
            num_price_PF.Value = (int)dgv_Products_PF.SelectedRows[0].Cells[2].Value;
            combo_category_PF.SelectedValue = (int)dgv_Products_PF.SelectedRows[0].Cells[3].Value;
        }

        private void btn_add_PF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_productName_PF.Text))
                MessageBox.Show("Product name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (num_price_PF.Value == 0)
                MessageBox.Show("Price is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                productsService.Add(txt_productName_PF.Text, (int)num_price_PF.Value, (int)combo_category_PF.SelectedValue);
                MessageBox.Show("Product added successfully");
                ResetView();
            }
        }

        private void btn_update_PF_Click(object sender, EventArgs e)
        {
            if (product_id != 0)
            {
                if (string.IsNullOrWhiteSpace(txt_productName_PF.Text))
                    MessageBox.Show("Product name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (num_price_PF.Value == 0)
                    MessageBox.Show("Price is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    productsService.Update(product_id, txt_productName_PF.Text, (int)num_price_PF.Value, (int)combo_category_PF.SelectedValue);
                    MessageBox.Show("Product updated successfully");
                    ResetView();
                }
            }
            else
                MessageBox.Show("Please select product");
        }

        private void btn_delete_PF_Click(object sender, EventArgs e)
        {
            if (product_id != 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this product ?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    productsService.Delete(product_id);
                    MessageBox.Show("Product deleted successfully");
                    ResetView();
                }
            }
            else
                MessageBox.Show("Please select product");
        }

        private void ResetView()
        {
            dgv_Products_PF.DataSource = productsService.GetAll();
            txt_productName_PF.Text = "";
            num_price_PF.Value = 0;
        }
    }
}
