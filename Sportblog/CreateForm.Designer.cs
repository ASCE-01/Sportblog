using System.Drawing;
using System.Windows.Forms;

namespace Main
{
    partial class CreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.createButton = new System.Windows.Forms.Button();
            this.passwordPictureBox = new System.Windows.Forms.PictureBox();
            this.usernamePictureBox = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailPictureBox = new System.Windows.Forms.PictureBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.repasswordPictureBox = new System.Windows.Forms.PictureBox();
            this.repasswordLabel = new System.Windows.Forms.Label();
            this.repasswordTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repasswordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.SpringGreen;
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.createButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createButton.Location = new System.Drawing.Point(147, 348);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(147, 28);
            this.createButton.TabIndex = 15;
            this.createButton.Text = "Create account";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // passwordPictureBox
            // 
            this.passwordPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordPictureBox.Image = global::Sportblog.Properties.Resources._lock;
            this.passwordPictureBox.Location = new System.Drawing.Point(116, 221);
            this.passwordPictureBox.Name = "passwordPictureBox";
            this.passwordPictureBox.Size = new System.Drawing.Size(24, 24);
            this.passwordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordPictureBox.TabIndex = 14;
            this.passwordPictureBox.TabStop = false;
            this.passwordPictureBox.Click += new System.EventHandler(this.passwordPictureBox_Click);
            // 
            // usernamePictureBox
            // 
            this.usernamePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.usernamePictureBox.Image = global::Sportblog.Properties.Resources.user;
            this.usernamePictureBox.Location = new System.Drawing.Point(116, 84);
            this.usernamePictureBox.Name = "usernamePictureBox";
            this.usernamePictureBox.Size = new System.Drawing.Size(24, 24);
            this.usernamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usernamePictureBox.TabIndex = 13;
            this.usernamePictureBox.TabStop = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.loginLabel.Location = new System.Drawing.Point(129, 390);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(190, 20);
            this.loginLabel.TabIndex = 12;
            this.loginLabel.Text = "Have an account? Log in";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            this.loginLabel.MouseEnter += new System.EventHandler(this.loginLabel_MouseEnter);
            this.loginLabel.MouseLeave += new System.EventHandler(this.loginLabel_MouseLeave);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Location = new System.Drawing.Point(142, 192);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(108, 26);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.Location = new System.Drawing.Point(140, 55);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(114, 26);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Username";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Montserrat", 14F);
            this.passwordTextBox.Location = new System.Drawing.Point(146, 219);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(154, 30);
            this.passwordTextBox.TabIndex = 10;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Montserrat", 14F);
            this.usernameTextBox.Location = new System.Drawing.Point(146, 84);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(154, 30);
            this.usernameTextBox.TabIndex = 9;
            // 
            // emailPictureBox
            // 
            this.emailPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.emailPictureBox.Image = global::Sportblog.Properties.Resources.email;
            this.emailPictureBox.Location = new System.Drawing.Point(116, 152);
            this.emailPictureBox.Name = "emailPictureBox";
            this.emailPictureBox.Size = new System.Drawing.Size(24, 24);
            this.emailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emailPictureBox.TabIndex = 18;
            this.emailPictureBox.TabStop = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.emailLabel.Location = new System.Drawing.Point(140, 123);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(67, 26);
            this.emailLabel.TabIndex = 16;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Montserrat", 14F);
            this.emailTextBox.Location = new System.Drawing.Point(146, 152);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(154, 30);
            this.emailTextBox.TabIndex = 17;
            // 
            // repasswordPictureBox
            // 
            this.repasswordPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.repasswordPictureBox.Image = global::Sportblog.Properties.Resources.key;
            this.repasswordPictureBox.Location = new System.Drawing.Point(116, 292);
            this.repasswordPictureBox.Name = "repasswordPictureBox";
            this.repasswordPictureBox.Size = new System.Drawing.Size(24, 24);
            this.repasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.repasswordPictureBox.TabIndex = 21;
            this.repasswordPictureBox.TabStop = false;
            this.repasswordPictureBox.Click += new System.EventHandler(this.repasswordPictureBox_Click);
            // 
            // repasswordLabel
            // 
            this.repasswordLabel.AutoSize = true;
            this.repasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.repasswordLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.repasswordLabel.Location = new System.Drawing.Point(142, 263);
            this.repasswordLabel.Name = "repasswordLabel";
            this.repasswordLabel.Size = new System.Drawing.Size(183, 26);
            this.repasswordLabel.TabIndex = 20;
            this.repasswordLabel.Text = "Repeat password";
            // 
            // repasswordTextBox
            // 
            this.repasswordTextBox.Font = new System.Drawing.Font("Montserrat", 14F);
            this.repasswordTextBox.Location = new System.Drawing.Point(146, 290);
            this.repasswordTextBox.Name = "repasswordTextBox";
            this.repasswordTextBox.PasswordChar = '*';
            this.repasswordTextBox.Size = new System.Drawing.Size(154, 30);
            this.repasswordTextBox.TabIndex = 19;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sportblog.Properties.Resources.createImg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(431, 495);
            this.Controls.Add(this.repasswordPictureBox);
            this.Controls.Add(this.repasswordLabel);
            this.Controls.Add(this.repasswordTextBox);
            this.Controls.Add(this.emailPictureBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.passwordPictureBox);
            this.Controls.Add(this.usernamePictureBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repasswordPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button createButton;
        private PictureBox passwordPictureBox;
        private PictureBox usernamePictureBox;
        private Label loginLabel;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private PictureBox emailPictureBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private PictureBox repasswordPictureBox;
        private Label repasswordLabel;
        private TextBox repasswordTextBox;
    }
}