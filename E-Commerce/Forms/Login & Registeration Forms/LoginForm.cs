using E_Commerce.BusinessLogic;
using E_Commerce.Forms;
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

namespace E_Commerce
{
    public partial class LoginForm : Form
    {
        UsersService usersService;
        Form previousForm;
        public LoginForm(Form PreviousForm)
        {
            InitializeComponent();
            usersService = new UsersService(ConfigurationManager.ConnectionStrings["ECommerceDB"].ConnectionString);
            previousForm = PreviousForm;
        }
        int user_id;
        private void btn_login_LF_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_userName_LF.Text))
                MessageBox.Show("User name is required");

            else if (String.IsNullOrWhiteSpace(txt_password_LF.Text))
                MessageBox.Show("Password is required");
            else
            {
                try
                {
                    var user = usersService.GetByUserName(txt_userName_LF.Text, txt_password_LF.Text);
                    if (user.Rows[0].ItemArray[6].ToString() == "User")
                    {
                        user_id = (int)user.Rows[0].ItemArray[0];
                        this.Hide();
                        new UserForm(user_id).Show();
                    }
                    else if (user.Rows[0].ItemArray[6].ToString() == "Admin")
                    {
                        this.Hide();
                        new AdminForm().Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid UserName or Password");
                }

            }

        }
        private void btn_backFromLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void check_viewPass_UF_CheckedChanged(object sender, EventArgs e)
        {
            if (check_viewPass_UF.Checked)
                txt_password_LF.UseSystemPasswordChar = false;
            else
                txt_password_LF.UseSystemPasswordChar = true;
        }
    }
}
