using System.Windows.Forms;

namespace Admin
{
    partial class AddWorkerToLoginTableForm
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
            this.UserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.UserPasswordLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelActionButton = new System.Windows.Forms.Button();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.UserLoginTextBox = new System.Windows.Forms.TextBox();
            this.UserLoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserPasswordTextBox
            // 
            this.UserPasswordTextBox.Location = new System.Drawing.Point(96, 56);
            this.UserPasswordTextBox.Name = "UserPasswordTextBox";
            this.UserPasswordTextBox.Size = new System.Drawing.Size(156, 20);
            this.UserPasswordTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(93, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(16, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "---";
            // 
            // UserPasswordLabel
            // 
            this.UserPasswordLabel.AutoSize = true;
            this.UserPasswordLabel.Location = new System.Drawing.Point(12, 59);
            this.UserPasswordLabel.Name = "UserPasswordLabel";
            this.UserPasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.UserPasswordLabel.TabIndex = 2;
            this.UserPasswordLabel.Text = "Пароль:";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(177, 105);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelActionButton
            // 
            this.CancelActionButton.Location = new System.Drawing.Point(96, 105);
            this.CancelActionButton.Name = "CancelActionButton";
            this.CancelActionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelActionButton.TabIndex = 4;
            this.CancelActionButton.Text = "Отмена";
            this.CancelActionButton.UseVisualStyleBackColor = true;
            this.CancelActionButton.Click += new System.EventHandler(this.CancelActionButton_Click);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(135, 82);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(114, 17);
            this.ShowPasswordCheckBox.TabIndex = 5;
            this.ShowPasswordCheckBox.Text = "Показать пароль";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // UserLoginTextBox
            // 
            this.UserLoginTextBox.Location = new System.Drawing.Point(96, 30);
            this.UserLoginTextBox.Name = "UserLoginTextBox";
            this.UserLoginTextBox.Size = new System.Drawing.Size(156, 20);
            this.UserLoginTextBox.TabIndex = 6;
            this.UserLoginTextBox.KeyPress += new KeyPressEventHandler(this.LoginTextBox_KeyPress);
            // 
            // UserLoginLabel
            // 
            this.UserLoginLabel.AutoSize = true;
            this.UserLoginLabel.Location = new System.Drawing.Point(12, 33);
            this.UserLoginLabel.Name = "UserLoginLabel";
            this.UserLoginLabel.Size = new System.Drawing.Size(41, 13);
            this.UserLoginLabel.TabIndex = 7;
            this.UserLoginLabel.Text = "Логин:";
            // 
            // AddWorkerToLoginTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 140);
            this.Controls.Add(this.UserLoginLabel);
            this.Controls.Add(this.UserLoginTextBox);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.CancelActionButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.UserPasswordLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.UserPasswordTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddWorkerToLoginTableForm";
            this.Text = "Добавление работника в систему";
            this.Load += new System.EventHandler(this.AddToLoginTableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserPasswordTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label UserPasswordLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelActionButton;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.TextBox UserLoginTextBox;
        private System.Windows.Forms.Label UserLoginLabel;
    }
}