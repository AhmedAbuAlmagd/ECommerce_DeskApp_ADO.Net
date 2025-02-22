using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_ShowUsers_AF_Click(object sender, EventArgs e)
        {
            UsersForm userForm = new UsersForm();
            userForm.TopLevel = false;
            userForm.FormBorderStyle = FormBorderStyle.None;
            userForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userForm);
            userForm.Show();
        }

        private void button2btn_ShowProducts_AF_Click(object sender, EventArgs e)
        {
            ProductsForm productForm = new ProductsForm();
            productForm.TopLevel = false;
            productForm.FormBorderStyle = FormBorderStyle.None;
            productForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(productForm);
            productForm.Show();
        }

        private void btn_ShowCategories_AF_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.TopLevel = false;
            categoriesForm.FormBorderStyle = FormBorderStyle.None;
            categoriesForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(categoriesForm);
            categoriesForm.Show();
        }

        private void btn_BackFromAF_Click(object sender, EventArgs e)
        {
            this.Close();
            new WelcomeForm().Show();
        }
    }
}
