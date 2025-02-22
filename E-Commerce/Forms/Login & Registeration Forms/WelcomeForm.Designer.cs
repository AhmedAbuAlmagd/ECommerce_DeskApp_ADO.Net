
namespace E_Commerce
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            btn_login = new Button();
            btn_register = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(150, 238, 214);
            btn_login.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.Black;
            btn_login.Location = new Point(553, 113);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(196, 93);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.FromArgb(150, 238, 214);
            btn_register.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btn_register.ForeColor = Color.Black;
            btn_register.Location = new Point(553, 253);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(196, 93);
            btn_register.TabIndex = 1;
            btn_register.Text = "Register";
            btn_register.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(498, 466);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Name = "WelcomeForm";
            Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_login;
        private Button btn_register;
        private PictureBox pictureBox1;
    }
}
