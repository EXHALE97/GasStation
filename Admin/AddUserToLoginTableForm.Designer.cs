using System.Windows.Forms;

namespace Admin
{
    partial class AddUserToLoginTableForm
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
            this.CancelActionButton = new System.Windows.Forms.Button();
            this.AddCredentialsButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ClientFullNameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.CheckPassCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelActionButton
            // 
            this.CancelActionButton.Location = new System.Drawing.Point(106, 113);
            this.CancelActionButton.Name = "CancelActionButton";
            this.CancelActionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelActionButton.TabIndex = 9;
            this.CancelActionButton.Text = "Отмена";
            this.CancelActionButton.UseVisualStyleBackColor = true;
            this.CancelActionButton.Click += new System.EventHandler(this.CancelActionButton_Click);
            // 
            // AddCredentialsButton
            // 
            this.AddCredentialsButton.Location = new System.Drawing.Point(187, 113);
            this.AddCredentialsButton.Name = "AddCredentialsButton";
            this.AddCredentialsButton.Size = new System.Drawing.Size(75, 23);
            this.AddCredentialsButton.TabIndex = 8;
            this.AddCredentialsButton.Text = "Ок";
            this.AddCredentialsButton.UseVisualStyleBackColor = true;
            this.AddCredentialsButton.Click += new System.EventHandler(this.AddCredentialsButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 67);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // ClientFullNameLabel
            // 
            this.ClientFullNameLabel.AutoSize = true;
            this.ClientFullNameLabel.Location = new System.Drawing.Point(103, 15);
            this.ClientFullNameLabel.Name = "ClientFullNameLabel";
            this.ClientFullNameLabel.Size = new System.Drawing.Size(16, 13);
            this.ClientFullNameLabel.TabIndex = 6;
            this.ClientFullNameLabel.Text = "---";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(106, 64);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(156, 20);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // CheckPassCheckBox
            // 
            this.CheckPassCheckBox.AutoSize = true;
            this.CheckPassCheckBox.Location = new System.Drawing.Point(145, 90);
            this.CheckPassCheckBox.Name = "CheckPassCheckBox";
            this.CheckPassCheckBox.Size = new System.Drawing.Size(114, 17);
            this.CheckPassCheckBox.TabIndex = 10;
            this.CheckPassCheckBox.Text = "Показать пароль";
            this.CheckPassCheckBox.UseVisualStyleBackColor = true;
            this.CheckPassCheckBox.CheckedChanged += new System.EventHandler(this.CheckPassCheckBox_CheckedChanged);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(106, 38);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(156, 20);
            this.LoginTextBox.TabIndex = 11;
            this.LoginTextBox.KeyPress += new KeyPressEventHandler(this.LoginTextBox_KeyPress);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(12, 41);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(41, 13);
            this.LoginLabel.TabIndex = 12;
            this.LoginLabel.Text = "Логин:";
            // 
            // AddUserToLoginTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 148);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.CheckPassCheckBox);
            this.Controls.Add(this.CancelActionButton);
            this.Controls.Add(this.AddCredentialsButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.ClientFullNameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddUserToLoginTableForm";
            this.Text = "Активация карты покупателя";
            this.Load += new System.EventHandler(this.AddToLoginTableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelActionButton;
        private System.Windows.Forms.Button AddCredentialsButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label ClientFullNameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckBox CheckPassCheckBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;
    }
}