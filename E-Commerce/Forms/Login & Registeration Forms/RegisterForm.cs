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

namespace E_Commerce
{
    public partial class RegisterForm : Form
    {
        UsersService usersService;
        Form previousForm;
        public RegisterForm(Form PreviousForm)
        {
            InitializeComponent();
            usersService = new UsersService(ConfigurationManager.ConnectionStrings["ECommerceDB"].ConnectionString);
            previousForm = PreviousForm;
        }

        private void btn_register_RF_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_userName_RF.Text) || txt_userName_RF.Text.Length < 3)
                MessageBox.Show("User Name must be at least 3 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (string.IsNullOrWhiteSpace(txt_password_RF.Text) || txt_password_RF.Text.Length < 6 || !Regex.IsMatch(txt_password_RF.Text, @"^(?=.*\d)(?=.*[A-Za-z@#$%^&+=!]).{6,}$"))
                MessageBox.Show("Password must be at least 6 characters long and contain at least one number and either a letter or special character.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (string.IsNullOrWhiteSpace(txt_email_RF.Text) || !Regex.IsMatch(txt_email_RF.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (num_age_RF.Value < 12 || num_age_RF.Value > 100)
                MessageBox.Show("Age must be a number between 12 and 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (string.IsNullOrWhiteSpace(txt_address_RF.Text) || txt_address_RF.Text.Length < 5)
                MessageBox.Show("Address must be at least 5 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                try
                {
                    usersService.Add(txt_userName_RF.Text, txt_password_RF.Text, txt_email_RF.Text, (int)num_age_RF.Value, txt_address_RF.Text);
                    MessageBox.Show("Registerd successfully");
                    this.Hide();
                    new LoginForm(this).Show();
                }
                catch
                {
                    MessageBox.Show("UserName or Email already exists", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void label_Login_RF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginForm(this).Show();
        }

        private void check_viewPass_UF_CheckedChanged(object sender, EventArgs e)
        {
            if (check_viewPass_UF.Checked)
                txt_password_RF.UseSystemPasswordChar = false;
            else
                txt_password_RF.UseSystemPasswordChar = true;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
