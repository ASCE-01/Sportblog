using System.Drawing;
using System.Windows.Forms;

namespace Main
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.r_idTextBox = new System.Windows.Forms.TextBox();
            this.r_idLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.deleteTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.asyncButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.countUsers = new System.Windows.Forms.Label();
            this.userInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(189, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 267);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(189, 71);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(64, 20);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Show users";
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(66, 337);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(64, 20);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(76, 71);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(43, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "User ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(52, 92);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(91, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select, update, insert and delete users\r\n";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(70, 127);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(52, 149);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(91, 20);
            this.usernameTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(52, 198);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(91, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(52, 252);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(91, 20);
            this.passTextBox.TabIndex = 8;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(79, 180);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Email";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(69, 232);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(53, 13);
            this.passLabel.TabIndex = 10;
            this.passLabel.Text = "Password";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(66, 362);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(64, 20);
            this.insertButton.TabIndex = 11;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // r_idTextBox
            // 
            this.r_idTextBox.Location = new System.Drawing.Point(52, 302);
            this.r_idTextBox.Name = "r_idTextBox";
            this.r_idTextBox.Size = new System.Drawing.Size(91, 20);
            this.r_idTextBox.TabIndex = 12;
            // 
            // r_idLabel
            // 
            this.r_idLabel.AutoSize = true;
            this.r_idLabel.Location = new System.Drawing.Point(76, 285);
            this.r_idLabel.Name = "r_idLabel";
            this.r_idLabel.Size = new System.Drawing.Size(43, 13);
            this.r_idLabel.TabIndex = 13;
            this.r_idLabel.Text = "Role ID";
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Location = new System.Drawing.Point(189, 487);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(213, 13);
            this.deleteLabel.TabIndex = 14;
            this.deleteLabel.Text = "Enter the ID of the user you want to delete: \r\n";
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.Location = new System.Drawing.Point(388, 484);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.Size = new System.Drawing.Size(22, 20);
            this.deleteTextBox.TabIndex = 15;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(189, 507);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(64, 20);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // asyncButton
            // 
            this.asyncButton.Location = new System.Drawing.Point(517, 71);
            this.asyncButton.Name = "asyncButton";
            this.asyncButton.Size = new System.Drawing.Size(91, 20);
            this.asyncButton.TabIndex = 17;
            this.asyncButton.Text = "Count users";
            this.asyncButton.UseVisualStyleBackColor = true;
            this.asyncButton.Click += new System.EventHandler(this.asyncButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(267, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Amount of users with delay 5sec:";
            // 
            // countUsers
            // 
            this.countUsers.AutoSize = true;
            this.countUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.countUsers.Location = new System.Drawing.Point(455, 75);
            this.countUsers.Name = "countUsers";
            this.countUsers.Size = new System.Drawing.Size(0, 13);
            this.countUsers.TabIndex = 19;
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.AutoSize = true;
            this.userInfoLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userInfoLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.userInfoLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.userInfoLabel.Location = new System.Drawing.Point(686, 491);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(167, 28);
            this.userInfoLabel.TabIndex = 21;
            this.userInfoLabel.Text = "Fill users info ->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 549);
            this.Controls.Add(this.userInfoLabel);
            this.Controls.Add(this.countUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.asyncButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.deleteTextBox);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.r_idLabel);
            this.Controls.Add(this.r_idTextBox);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button selectButton;
        private Button updateButton;
        private Label idLabel;
        private TextBox idTextBox;
        private Label label1;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private TextBox emailTextBox;
        private TextBox passTextBox;
        private Label emailLabel;
        private Label passLabel;
        private Button insertButton;
        private Label r_idLabel;
        private TextBox r_idTextBox;
        private Label deleteLabel;
        private TextBox deleteTextBox;
        private Button deleteButton;
        private Button asyncButton;
        private Label label2;
        private Label countUsers;
        private Label userInfoLabel;
    }
}