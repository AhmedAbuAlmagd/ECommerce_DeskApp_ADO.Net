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
    public partial class FavouritesForm : Form
    {
        FavoritesService favouritesService;
        ProductsService productsService;
        int user_id;
        Form previousForm;
        int product_id;
        public FavouritesForm(Form PreviousForm, int UserId)
        {
            InitializeComponent();
            favouritesService = new FavoritesService(ConfigurationManager.ConnectionStrings["ECommerceDB"].ConnectionString);
            productsService = new ProductsService(ConfigurationManager.ConnectionStrings["ECommerceDB"].ConnectionString);
            user_id = UserId;
            previousForm = PreviousForm;
        }

        private void FavouritesForm_Load(object sender, EventArgs e)
        {
            dgv_favourites_FF.DataSource = favouritesService.GetAllByUserId(user_id);
        }

        private void btn_back_from_favF_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void dgv_favourites_FF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string product_name = dgv_favourites_FF.SelectedRows[0].Cells[0].Value.ToString();
            txt_productName_FF.Text = product_name;
            product_id = (int)productsService.GetProductIdByName(product_name).Rows[0].ItemArray[0];
        }
         
        private void btn_Remove_FF_Click(object sender, EventArgs e)
        {
            if(product_id != 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    favouritesService.Delete(user_id, product_id);
                    MessageBox.Show("Item deleted successfully!");
                    dgv_favourites_FF.DataSource = favouritesService.GetAllByUserId(user_id);
                    txt_productName_FF.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please select product");
            }
          
        }
    }
}
