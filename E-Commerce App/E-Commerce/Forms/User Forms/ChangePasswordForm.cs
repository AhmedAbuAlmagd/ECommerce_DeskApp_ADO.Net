using E_Commerce.BusinessLogic;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ChangePasswordForm : Form
    {
        Form previousForm;
        int user_id;
        UsersService usersService;
        public ChangePasswordForm(Form PreviousForm, int User_id)
        {
            InitializeComponent();
            usersService = new UsersService(ConfigurationManager.ConnectionStrings["ECommerceDB"].ConnectionString);
            previousForm = PreviousForm;
            user_id = User_id;
        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            var user = usersService.GetById(user_id);
            if (String.IsNullOrWhiteSpace(txt_oldPass.Text) || String.IsNullOrWhiteSpace(txt_newPass.Text) || String.IsNullOrWhiteSpace(txt_confirmPass.Text))
                MessageBox.Show("Please fill All fields");
            else
            {
                if (txt_oldPass.Text == user.Rows[0].ItemArray[3].ToString() && txt_newPass.Text == txt_confirmPass.Text)
                {
                    var result = MessageBox.Show("Are you sure you want to change your password?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        usersService.UpdatePassword(user_id, txt_newPass.Text);
                        MessageBox.Show("Password Changed Successfully");
                        this.Close();
                        previousForm.Show();
                    }
                }
                else if (txt_oldPass.Text != user.Rows[0].ItemArray[3].ToString())
                {
                    MessageBox.Show("Your old Password is wrong");
                }
                else
                {
                    MessageBox.Show("Please confirm your new password correctly");
                }
            }
        }

        private void btn_back_PassF_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void check_viewPass_UF_CheckedChanged(object sender, EventArgs e)
        {
            if (check_viewPass_UF.Checked)
                txt_oldPass.UseSystemPasswordChar = false;
            else
                txt_oldPass.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_viewPass_UF.Checked)
                txt_newPass.UseSystemPasswordChar = false;
            else
                txt_newPass.UseSystemPasswordChar = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (check_viewPass_UF.Checked)
                txt_confirmPass.UseSystemPasswordChar = false;
            else
                txt_confirmPass.UseSystemPasswordChar = true;
        }
    }
}
