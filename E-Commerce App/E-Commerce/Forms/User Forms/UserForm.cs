using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Commerce.BusinessLogic;
using E_Commerce.DataAccess;
using E_Commerce.Forms;

namespace E_Commerce
{
    public partial class UserForm : Form
    {
        ProductsService productsService;
        FavoritesService favouritesService;
        CategoriesService categoriesService;
        int User_id;
        int product_id;
        string categoryName;
        int categoryId;

        public UserForm(int user_id)
        {
            productsService = new ProductsService(ConfigurationManager.ConnectionStrings["ECommerceDB"].ConnectionString);
            favouritesService = new FavoritesService(ConfigurationManager.ConnectionStrings["ECommerceDB"].ConnectionString);
            categoriesService = new CategoriesService(ConfigurationManager.ConnectionStrings["ECommerceDB"].ConnectionString);
            User_id = user_id;
            InitializeComponent();
        }

        private void btn_viewFavourite_UF_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FavouritesForm(this, User_id).Show();
        }

        private void btn_back_from_userF_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WelcomeForm().Show();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            var products = productsService.GetAll();
            dgv_products_UF.DataSource = products;
        }

        private void dgv_products_UF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            product_id = (int)dgv_products_UF.SelectedRows[0].Cells[0].Value;

            txt_productName_UF.Text = dgv_products_UF.SelectedRows[0].Cells[1].Value.ToString();
            categoryId = (int)dgv_products_UF.SelectedRows[0].Cells[3].Value;
            categoryName = categoriesService.GetById(categoryId).Rows[0].ItemArray[1].ToString();
            txt_categoryName_UF.Text = categoryName;
            txt_price_UF.Text = dgv_products_UF.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btn_addFavourite_UF_Click(object sender, EventArgs e)
        {
            try
            {
                if (product_id == 0)
                {
                    MessageBox.Show("Please Select product");
                }
                else
                {
                    favouritesService.Add(User_id, product_id);
                    MessageBox.Show("Product added to favourites successfully");
                    txt_productName_UF.Text = txt_categoryName_UF.Text = txt_price_UF.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("You have already this product in your favourites");
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
                new WelcomeForm().Show();
            }
        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePasswordForm(this, User_id).Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
