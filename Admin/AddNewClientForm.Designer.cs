namespace Admin
{
    partial class AddNewClientForm
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
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.ClientLastNameLabel = new System.Windows.Forms.Label();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.CancelAddButton = new System.Windows.Forms.Button();
            this.ClientMiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientMiddleNameLabel = new System.Windows.Forms.Label();
            this.ClientCardLabel = new System.Windows.Forms.Label();
            this.ClientCardComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(78, 31);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.ClientNameTextBox.TabIndex = 0;
            this.ClientNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientNameTextBox_KeyPress);
            // 
            // ClientLastNameTextBox
            // 
            this.ClientLastNameTextBox.Location = new System.Drawing.Point(78, 57);
            this.ClientLastNameTextBox.Name = "ClientLastNameTextBox";
            this.ClientLastNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.ClientLastNameTextBox.TabIndex = 1;
            this.ClientLastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientLastNameTextBox_KeyPress);
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Location = new System.Drawing.Point(12, 34);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(29, 13);
            this.ClientNameLabel.TabIndex = 2;
            this.ClientNameLabel.Text = "Имя";
            // 
            // ClientLastNameLabel
            // 
            this.ClientLastNameLabel.AutoSize = true;
            this.ClientLastNameLabel.Location = new System.Drawing.Point(12, 60);
            this.ClientLastNameLabel.Name = "ClientLastNameLabel";
            this.ClientLastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.ClientLastNameLabel.TabIndex = 3;
            this.ClientLastNameLabel.Text = "Фамилия";
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(159, 151);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(75, 23);
            this.AddClientButton.TabIndex = 7;
            this.AddClientButton.Text = "Добавить";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.Location = new System.Drawing.Point(78, 151);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAddButton.TabIndex = 8;
            this.CancelAddButton.Text = "Отмена";
            this.CancelAddButton.UseVisualStyleBackColor = true;
            this.CancelAddButton.Click += new System.EventHandler(this.CancelAddButton_Click);
            // 
            // ClientMiddleNameTextBox
            // 
            this.ClientMiddleNameTextBox.Location = new System.Drawing.Point(78, 83);
            this.ClientMiddleNameTextBox.Name = "ClientMiddleNameTextBox";
            this.ClientMiddleNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.ClientMiddleNameTextBox.TabIndex = 9;
            this.ClientMiddleNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientMiddleNameTextBox_KeyPress);
            // 
            // ClientMiddleNameLabel
            // 
            this.ClientMiddleNameLabel.AutoSize = true;
            this.ClientMiddleNameLabel.Location = new System.Drawing.Point(12, 86);
            this.ClientMiddleNameLabel.Name = "ClientMiddleNameLabel";
            this.ClientMiddleNameLabel.Size = new System.Drawing.Size(57, 13);
            this.ClientMiddleNameLabel.TabIndex = 10;
            this.ClientMiddleNameLabel.Text = "Отчество:";
            // 
            // ClientCardLabel
            // 
            this.ClientCardLabel.AutoSize = true;
            this.ClientCardLabel.Location = new System.Drawing.Point(12, 112);
            this.ClientCardLabel.Name = "ClientCardLabel";
            this.ClientCardLabel.Size = new System.Drawing.Size(40, 13);
            this.ClientCardLabel.TabIndex = 11;
            this.ClientCardLabel.Text = "Карта:";
            // 
            // ClientCardComboBox
            // 
            this.ClientCardComboBox.FormattingEnabled = true;
            this.ClientCardComboBox.Location = new System.Drawing.Point(78, 109);
            this.ClientCardComboBox.Name = "ClientCardComboBox";
            this.ClientCardComboBox.Size = new System.Drawing.Size(156, 21);
            this.ClientCardComboBox.TabIndex = 13;
            // 
            // AddNewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 188);
            this.Controls.Add(this.ClientCardComboBox);
            this.Controls.Add(this.ClientCardLabel);
            this.Controls.Add(this.ClientMiddleNameLabel);
            this.Controls.Add(this.ClientMiddleNameTextBox);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.ClientLastNameLabel);
            this.Controls.Add(this.ClientNameLabel);
            this.Controls.Add(this.ClientLastNameTextBox);
            this.Controls.Add(this.ClientNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddNewClientForm";
            this.Text = "Оформление покупателя";
            this.Load += new System.EventHandler(this.AddNewClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.TextBox ClientLastNameTextBox;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.Label ClientLastNameLabel;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Button CancelAddButton;
        private System.Windows.Forms.TextBox ClientMiddleNameTextBox;
        private System.Windows.Forms.Label ClientMiddleNameLabel;
        private System.Windows.Forms.Label ClientCardLabel;
        private System.Windows.Forms.ComboBox ClientCardComboBox;
    }
}