using E_Commerce.BusinessLogic;
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

namespace E_Commerce.Forms
{
    public partial class CategoriesForm : Form
    {
        CategoriesService categoriesService;
        int category_id;
        public CategoriesForm()
        {
            InitializeComponent();
            categoriesService = new CategoriesService(ConfigurationManager.ConnectionStrings["ECommerceDB"].ConnectionString);
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            dgv_Categories_CF.DataSource = categoriesService.GettALL();
        }

        private void btn_add_CF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_categoryName_CF.Text))
                MessageBox.Show("Category name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                categoriesService.Add(txt_categoryName_CF.Text);
                MessageBox.Show("Category added successfully");
                dgv_Categories_CF.DataSource = categoriesService.GettALL();
                txt_categoryName_CF.Text = "";
            }
        }

        private void btn_update_CF_Click(object sender, EventArgs e)
        {
            if (category_id != 0)
            {
                if (string.IsNullOrWhiteSpace(txt_categoryName_CF.Text))
                    MessageBox.Show("Category name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    categoriesService.Update(category_id, txt_categoryName_CF.Text);
                    MessageBox.Show("Category updated successfully");
                    dgv_Categories_CF.DataSource = categoriesService.GettALL();
                    txt_categoryName_CF.Text = "";
                }
            }
            else
                MessageBox.Show("Please select category");
        }

        private void btn_delete_CF_Click(object sender, EventArgs e)
        {
            if ( category_id != 0)
            {
                categoriesService.Delete(category_id);
                MessageBox.Show("Category deleted successfully");
                dgv_Categories_CF.DataSource = categoriesService.GettALL();
                txt_categoryName_CF.Text = "";
            }
            else
                MessageBox.Show("Please select category");
        }

        private void dgv_Categories_CF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            category_id = (int)dgv_Categories_CF.SelectedRows[0].Cells[0].Value;
            txt_categoryName_CF.Text = dgv_Categories_CF.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
