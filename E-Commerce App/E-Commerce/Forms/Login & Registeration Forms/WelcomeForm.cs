namespace E_Commerce
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm(this).Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
           this.Hide();
            new RegisterForm(this).Show();
        }
    }
}
