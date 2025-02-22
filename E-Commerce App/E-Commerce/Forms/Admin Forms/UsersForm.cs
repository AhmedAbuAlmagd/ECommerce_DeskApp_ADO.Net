using E_Commerce.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.Forms
{
    public partial class UsersForm : Form
    {
        UsersService usersService;
        int user_id;
        public UsersForm()
        {
            InitializeComponent();
            usersService = new UsersService(ConfigurationManager.ConnectionStrings["ECommerceDB"].ConnectionString);
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            dgv_Users_UF.DataSource = usersService.GetAll();
            dgv_Users_UF.Columns["Password"].Visible = false;

            combo_Role_UF.DataSource = usersService.GetRoles();
            combo_Role_UF.DisplayMember = "Role";
        }


        private void dgv_Users_UF_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            user_id = (int)dgv_Users_UF.SelectedRows[0].Cells[0].Value;
            txt_userName_UF.Text = dgv_Users_UF.SelectedRows[0].Cells[1].Value.ToString();
            txt_email_UF.Text = dgv_Users_UF.SelectedRows[0].Cells[2].Value.ToString();
            txt_password_UF.Text = dgv_Users_UF.SelectedRows[0].Cells[3].Value.ToString();
            num_age_UF.Value = (int)dgv_Users_UF.SelectedRows[0].Cells[4].Value;
            txt_address_UF.Text = dgv_Users_UF.SelectedRows[0].Cells[5].Value.ToString();
            combo_Role_UF.Text = dgv_Users_UF.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void check_viewPass_UF_CheckedChanged(object sender, EventArgs e)
        {
            if (check_viewPass_UF.Checked)
                txt_password_UF.UseSystemPasswordChar = false;
            else
                txt_password_UF.UseSystemPasswordChar = true;
        }

        private void btn_add_UF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_userName_UF.Text) || txt_userName_UF.Text.Length < 3)
                MessageBox.Show("User Name must be at least 3 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (string.IsNullOrWhiteSpace(txt_password_UF.Text) || txt_password_UF.Text.Length < 6 || !Regex.IsMatch(txt_password_UF.Text, @"^(?=.*\d)(?=.*[A-Za-z@#$%^&+=!]).{6,}$"))
                MessageBox.Show("Password must be at least 6 characters long and contain at least one number and either a letter or special character.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (string.IsNullOrWhiteSpace(txt_email_UF.Text) || !Regex.IsMatch(txt_email_UF.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (num_age_UF.Value < 12 || num_age_UF.Value > 100)
                MessageBox.Show("Age must be a number between 12 and 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (string.IsNullOrWhiteSpace(txt_address_UF.Text) || txt_address_UF.Text.Length < 5)
                MessageBox.Show("Address must be at least 5 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                try
                {
                    usersService.Add(txt_userName_UF.Text, txt_password_UF.Text, txt_email_UF.Text, (int)num_age_UF.Value, txt_address_UF.Text, combo_Role_UF.SelectedText);
                    MessageBox.Show("User added successfully");
                    ResetView();
                }
                catch
                {
                    MessageBox.Show("UserName or Email already exists", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_update_UF_Click(object sender, EventArgs e)
        {
            if (user_id != 0)
            {
                if (string.IsNullOrWhiteSpace(txt_userName_UF.Text) || txt_userName_UF.Text.Length < 3)
                    MessageBox.Show("User Name must be at least 3 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else if (string.IsNullOrWhiteSpace(txt_password_UF.Text) || txt_password_UF.Text.Length < 6 || !Regex.IsMatch(txt_password_UF.Text, @"^(?=.*\d)(?=.*[A-Za-z@#$%^&+=!]).{6,}$"))
                    MessageBox.Show("Password must be at least 6 characters long and contain at least one number and either a letter or special character.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else if (string.IsNullOrWhiteSpace(txt_email_UF.Text) || !Regex.IsMatch(txt_email_UF.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else if (num_age_UF.Value < 12 || num_age_UF.Value > 100)
                    MessageBox.Show("Age must be a number between 12 and 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else if (string.IsNullOrWhiteSpace(txt_address_UF.Text) || txt_address_UF.Text.Length < 5)
                    MessageBox.Show("Address must be at least 5 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else
                {
                    try
                    {
                        usersService.Update(user_id, txt_userName_UF.Text, txt_password_UF.Text, txt_email_UF.Text, (int)num_age_UF.Value, txt_address_UF.Text, combo_Role_UF.Text);
                        MessageBox.Show("User Updated successfully");
                        ResetView();
                    }
                    catch
                    {
                        MessageBox.Show("UserName or Email already exists", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
                MessageBox.Show("Please select User");

        }

        private void btn_delete_UF_Click(object sender, EventArgs e)
        {
            if (user_id != 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this user ?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    usersService.Delete(user_id);
                    MessageBox.Show("User deleted successfully!");
                    ResetView();
                    
                }
            }
            else
                MessageBox.Show("Please select User");
        }

        private void ResetView()
        {
            dgv_Users_UF.DataSource = usersService.GetAll();
            dgv_Users_UF.Columns["Password"].Visible = false;
            txt_userName_UF.Text = txt_email_UF.Text = txt_password_UF.Text = txt_address_UF.Text = "";
            num_age_UF.Value = 0;
        }
    }
}
