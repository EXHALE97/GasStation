namespace Admin
{
    partial class AddNewAdminForm
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
            this.AdminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.AdminLoginTextBox = new System.Windows.Forms.TextBox();
            this.AdminLoginLabel = new System.Windows.Forms.Label();
            this.AdminPasswordLabel = new System.Windows.Forms.Label();
            this.AddAdminButton = new System.Windows.Forms.Button();
            this.CancelActionButton = new System.Windows.Forms.Button();
            this.CheckPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AdminPasswordTextBox
            // 
            this.AdminPasswordTextBox.Location = new System.Drawing.Point(100, 38);
            this.AdminPasswordTextBox.Name = "AdminPasswordTextBox";
            this.AdminPasswordTextBox.Size = new System.Drawing.Size(126, 20);
            this.AdminPasswordTextBox.TabIndex = 0;
            // 
            // AdminLoginTextBox
            // 
            this.AdminLoginTextBox.Location = new System.Drawing.Point(100, 12);
            this.AdminLoginTextBox.Name = "AdminLoginTextBox";
            this.AdminLoginTextBox.Size = new System.Drawing.Size(126, 20);
            this.AdminLoginTextBox.TabIndex = 1;
            // 
            // AdminLoginLabel
            // 
            this.AdminLoginLabel.AutoSize = true;
            this.AdminLoginLabel.Location = new System.Drawing.Point(12, 19);
            this.AdminLoginLabel.Name = "AdminLoginLabel";
            this.AdminLoginLabel.Size = new System.Drawing.Size(41, 13);
            this.AdminLoginLabel.TabIndex = 2;
            this.AdminLoginLabel.Text = "Логин:";
            // 
            // AdminPasswordLabel
            // 
            this.AdminPasswordLabel.AutoSize = true;
            this.AdminPasswordLabel.Location = new System.Drawing.Point(12, 45);
            this.AdminPasswordLabel.Name = "AdminPasswordLabel";
            this.AdminPasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.AdminPasswordLabel.TabIndex = 3;
            this.AdminPasswordLabel.Text = "Пароль:";
            // 
            // AddAdminButton
            // 
            this.AddAdminButton.Location = new System.Drawing.Point(151, 93);
            this.AddAdminButton.Name = "AddAdminButton";
            this.AddAdminButton.Size = new System.Drawing.Size(75, 23);
            this.AddAdminButton.TabIndex = 4;
            this.AddAdminButton.Text = "Добавить";
            this.AddAdminButton.UseVisualStyleBackColor = true;
            this.AddAdminButton.Click += new System.EventHandler(this.AddAdminButton_Click);
            // 
            // CancelActionButton
            // 
            this.CancelActionButton.Location = new System.Drawing.Point(70, 93);
            this.CancelActionButton.Name = "CancelActionButton";
            this.CancelActionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelActionButton.TabIndex = 5;
            this.CancelActionButton.Text = "Отмена";
            this.CancelActionButton.UseVisualStyleBackColor = true;
            this.CancelActionButton.Click += new System.EventHandler(this.CancelActionButton_Click);
            // 
            // CheckPasswordCheckBox
            // 
            this.CheckPasswordCheckBox.AutoSize = true;
            this.CheckPasswordCheckBox.Location = new System.Drawing.Point(100, 70);
            this.CheckPasswordCheckBox.Name = "CheckPasswordCheckBox";
            this.CheckPasswordCheckBox.Size = new System.Drawing.Size(114, 17);
            this.CheckPasswordCheckBox.TabIndex = 6;
            this.CheckPasswordCheckBox.Text = "Показать пароль";
            this.CheckPasswordCheckBox.UseVisualStyleBackColor = true;
            this.CheckPasswordCheckBox.CheckedChanged += new System.EventHandler(this.CheckPasswordCheckBox_CheckedChanged);
            // 
            // AddNewAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 124);
            this.Controls.Add(this.CheckPasswordCheckBox);
            this.Controls.Add(this.CancelActionButton);
            this.Controls.Add(this.AddAdminButton);
            this.Controls.Add(this.AdminPasswordLabel);
            this.Controls.Add(this.AdminLoginLabel);
            this.Controls.Add(this.AdminLoginTextBox);
            this.Controls.Add(this.AdminPasswordTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddNewAdminForm";
            this.Text = "Добавление нового администратора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdminPasswordTextBox;
        private System.Windows.Forms.TextBox AdminLoginTextBox;
        private System.Windows.Forms.Label AdminLoginLabel;
        private System.Windows.Forms.Label AdminPasswordLabel;
        private System.Windows.Forms.Button AddAdminButton;
        private System.Windows.Forms.Button CancelActionButton;
        private System.Windows.Forms.CheckBox CheckPasswordCheckBox;
    }
}