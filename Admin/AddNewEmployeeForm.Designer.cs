namespace Admin
{
    partial class AddNewEmployeeForm
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
            this.EmployeeSurnameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeePositionTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeSalaryTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeSurnameLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeBirthDateLabel = new System.Windows.Forms.Label();
            this.EmployeePositionLabel = new System.Windows.Forms.Label();
            this.EmployeeSalaryLabel = new System.Windows.Forms.Label();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EmployeeAddressLabel = new System.Windows.Forms.Label();
            this.EmployeeBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EmployeeMiddleNameLabel = new System.Windows.Forms.Label();
            this.EmployeeMiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.EmploymentDateLabel = new System.Windows.Forms.Label();
            this.EmploymentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ContractEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ContractEndDateLabel = new System.Windows.Forms.Label();
            this.EmployeePhoneLabel = new System.Windows.Forms.Label();
            this.IsWorkingGroupBox = new System.Windows.Forms.GroupBox();
            this.NotWorkingCheckBox = new System.Windows.Forms.CheckBox();
            this.WorkingChechBox = new System.Windows.Forms.CheckBox();
            this.EmployeePhoneTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeAddressTextBox = new System.Windows.Forms.TextBox();
            this.IsWorkingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeSurnameTextBox
            // 
            this.EmployeeSurnameTextBox.Location = new System.Drawing.Point(154, 19);
            this.EmployeeSurnameTextBox.Name = "EmployeeSurnameTextBox";
            this.EmployeeSurnameTextBox.Size = new System.Drawing.Size(167, 20);
            this.EmployeeSurnameTextBox.TabIndex = 2;
            this.EmployeeSurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeSurnameTextBox_KeyPress);
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(154, 46);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.EmployeeNameTextBox.TabIndex = 3;
            this.EmployeeNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeNameTextBox_KeyPress);
            // 
            // EmployeePositionTextBox
            // 
            this.EmployeePositionTextBox.Location = new System.Drawing.Point(154, 98);
            this.EmployeePositionTextBox.Name = "EmployeePositionTextBox";
            this.EmployeePositionTextBox.Size = new System.Drawing.Size(167, 20);
            this.EmployeePositionTextBox.TabIndex = 6;
            this.EmployeePositionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeePositionTextBox_KeyPress);
            // 
            // EmployeeSalaryTextBox
            // 
            this.EmployeeSalaryTextBox.Location = new System.Drawing.Point(154, 202);
            this.EmployeeSalaryTextBox.Name = "EmployeeSalaryTextBox";
            this.EmployeeSalaryTextBox.Size = new System.Drawing.Size(167, 20);
            this.EmployeeSalaryTextBox.TabIndex = 8;
            this.EmployeeSalaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeSalaryTextBox_KeyPress);
            // 
            // EmployeeSurnameLabel
            // 
            this.EmployeeSurnameLabel.AutoSize = true;
            this.EmployeeSurnameLabel.Location = new System.Drawing.Point(22, 22);
            this.EmployeeSurnameLabel.Name = "EmployeeSurnameLabel";
            this.EmployeeSurnameLabel.Size = new System.Drawing.Size(59, 13);
            this.EmployeeSurnameLabel.TabIndex = 11;
            this.EmployeeSurnameLabel.Text = "Фамилия:";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(22, 49);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(32, 13);
            this.EmployeeNameLabel.TabIndex = 12;
            this.EmployeeNameLabel.Text = "Имя:";
            // 
            // EmployeeBirthDateLabel
            // 
            this.EmployeeBirthDateLabel.AutoSize = true;
            this.EmployeeBirthDateLabel.Location = new System.Drawing.Point(22, 130);
            this.EmployeeBirthDateLabel.Name = "EmployeeBirthDateLabel";
            this.EmployeeBirthDateLabel.Size = new System.Drawing.Size(89, 13);
            this.EmployeeBirthDateLabel.TabIndex = 14;
            this.EmployeeBirthDateLabel.Text = "Дата рождения:";
            // 
            // EmployeePositionLabel
            // 
            this.EmployeePositionLabel.AutoSize = true;
            this.EmployeePositionLabel.Location = new System.Drawing.Point(22, 101);
            this.EmployeePositionLabel.Name = "EmployeePositionLabel";
            this.EmployeePositionLabel.Size = new System.Drawing.Size(68, 13);
            this.EmployeePositionLabel.TabIndex = 15;
            this.EmployeePositionLabel.Text = "Должность:";
            // 
            // EmployeeSalaryLabel
            // 
            this.EmployeeSalaryLabel.AutoSize = true;
            this.EmployeeSalaryLabel.Location = new System.Drawing.Point(22, 205);
            this.EmployeeSalaryLabel.Name = "EmployeeSalaryLabel";
            this.EmployeeSalaryLabel.Size = new System.Drawing.Size(102, 13);
            this.EmployeeSalaryLabel.TabIndex = 17;
            this.EmployeeSalaryLabel.Text = "Заработная плата:";
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(246, 371);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.AddEmployeeButton.TabIndex = 18;
            this.AddEmployeeButton.Text = "Добавить";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(154, 371);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EmployeeAddressLabel
            // 
            this.EmployeeAddressLabel.AutoSize = true;
            this.EmployeeAddressLabel.Location = new System.Drawing.Point(22, 231);
            this.EmployeeAddressLabel.Name = "EmployeeAddressLabel";
            this.EmployeeAddressLabel.Size = new System.Drawing.Size(41, 13);
            this.EmployeeAddressLabel.TabIndex = 23;
            this.EmployeeAddressLabel.Text = "Адрес:";
            // 
            // EmployeeBirthDatePicker
            // 
            this.EmployeeBirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EmployeeBirthDatePicker.Location = new System.Drawing.Point(154, 124);
            this.EmployeeBirthDatePicker.Name = "EmployeeBirthDatePicker";
            this.EmployeeBirthDatePicker.Size = new System.Drawing.Size(167, 20);
            this.EmployeeBirthDatePicker.TabIndex = 24;
            // 
            // EmployeeMiddleNameLabel
            // 
            this.EmployeeMiddleNameLabel.AutoSize = true;
            this.EmployeeMiddleNameLabel.Location = new System.Drawing.Point(22, 75);
            this.EmployeeMiddleNameLabel.Name = "EmployeeMiddleNameLabel";
            this.EmployeeMiddleNameLabel.Size = new System.Drawing.Size(57, 13);
            this.EmployeeMiddleNameLabel.TabIndex = 25;
            this.EmployeeMiddleNameLabel.Text = "Отчество:";
            // 
            // EmployeeMiddleNameTextBox
            // 
            this.EmployeeMiddleNameTextBox.Location = new System.Drawing.Point(154, 72);
            this.EmployeeMiddleNameTextBox.Name = "EmployeeMiddleNameTextBox";
            this.EmployeeMiddleNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.EmployeeMiddleNameTextBox.TabIndex = 26;
            this.EmployeeMiddleNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeMiddleNameTextBox_KeyPress);
            // 
            // EmploymentDateLabel
            // 
            this.EmploymentDateLabel.AutoSize = true;
            this.EmploymentDateLabel.Location = new System.Drawing.Point(22, 156);
            this.EmploymentDateLabel.Name = "EmploymentDateLabel";
            this.EmploymentDateLabel.Size = new System.Drawing.Size(71, 13);
            this.EmploymentDateLabel.TabIndex = 28;
            this.EmploymentDateLabel.Text = "Дата найма:";
            // 
            // EmploymentDatePicker
            // 
            this.EmploymentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EmploymentDatePicker.Location = new System.Drawing.Point(154, 150);
            this.EmploymentDatePicker.Name = "EmploymentDatePicker";
            this.EmploymentDatePicker.Size = new System.Drawing.Size(167, 20);
            this.EmploymentDatePicker.TabIndex = 29;
            // 
            // ContractEndDatePicker
            // 
            this.ContractEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ContractEndDatePicker.Location = new System.Drawing.Point(154, 176);
            this.ContractEndDatePicker.Name = "ContractEndDatePicker";
            this.ContractEndDatePicker.Size = new System.Drawing.Size(167, 20);
            this.ContractEndDatePicker.TabIndex = 30;
            // 
            // ContractEndDateLabel
            // 
            this.ContractEndDateLabel.AutoSize = true;
            this.ContractEndDateLabel.Location = new System.Drawing.Point(22, 182);
            this.ContractEndDateLabel.Name = "ContractEndDateLabel";
            this.ContractEndDateLabel.Size = new System.Drawing.Size(120, 13);
            this.ContractEndDateLabel.TabIndex = 31;
            this.ContractEndDateLabel.Text = "Окончание контракта:";
            // 
            // EmployeePhoneLabel
            // 
            this.EmployeePhoneLabel.AutoSize = true;
            this.EmployeePhoneLabel.Location = new System.Drawing.Point(22, 258);
            this.EmployeePhoneLabel.Name = "EmployeePhoneLabel";
            this.EmployeePhoneLabel.Size = new System.Drawing.Size(55, 13);
            this.EmployeePhoneLabel.TabIndex = 32;
            this.EmployeePhoneLabel.Text = "Телефон:";
            // 
            // IsWorkingGroupBox
            // 
            this.IsWorkingGroupBox.Controls.Add(this.NotWorkingCheckBox);
            this.IsWorkingGroupBox.Controls.Add(this.WorkingChechBox);
            this.IsWorkingGroupBox.Location = new System.Drawing.Point(25, 289);
            this.IsWorkingGroupBox.Name = "IsWorkingGroupBox";
            this.IsWorkingGroupBox.Size = new System.Drawing.Size(296, 64);
            this.IsWorkingGroupBox.TabIndex = 34;
            this.IsWorkingGroupBox.TabStop = false;
            this.IsWorkingGroupBox.Text = "Работает:";
            // 
            // NotWorkingCheckBox
            // 
            this.NotWorkingCheckBox.AutoSize = true;
            this.NotWorkingCheckBox.Location = new System.Drawing.Point(245, 28);
            this.NotWorkingCheckBox.Name = "NotWorkingCheckBox";
            this.NotWorkingCheckBox.Size = new System.Drawing.Size(45, 17);
            this.NotWorkingCheckBox.TabIndex = 1;
            this.NotWorkingCheckBox.Text = "Нет";
            this.NotWorkingCheckBox.UseVisualStyleBackColor = true;
            // 
            // WorkingChechBox
            // 
            this.WorkingChechBox.AutoSize = true;
            this.WorkingChechBox.Location = new System.Drawing.Point(129, 28);
            this.WorkingChechBox.Name = "WorkingChechBox";
            this.WorkingChechBox.Size = new System.Drawing.Size(41, 17);
            this.WorkingChechBox.TabIndex = 0;
            this.WorkingChechBox.Text = "Да";
            this.WorkingChechBox.UseVisualStyleBackColor = true;
            // 
            // EmployeePhoneTextBox
            // 
            this.EmployeePhoneTextBox.Location = new System.Drawing.Point(154, 255);
            this.EmployeePhoneTextBox.Name = "EmployeePhoneTextBox";
            this.EmployeePhoneTextBox.Size = new System.Drawing.Size(167, 20);
            this.EmployeePhoneTextBox.TabIndex = 35;
            this.EmployeePhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeePhoneTextBox_KeyPress);
            // 
            // EmployeeAddressTextBox
            // 
            this.EmployeeAddressTextBox.Location = new System.Drawing.Point(154, 228);
            this.EmployeeAddressTextBox.Name = "EmployeeAddressTextBox";
            this.EmployeeAddressTextBox.Size = new System.Drawing.Size(167, 20);
            this.EmployeeAddressTextBox.TabIndex = 36;
            // 
            // AddNewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 400);
            this.Controls.Add(this.EmployeeAddressTextBox);
            this.Controls.Add(this.EmployeePhoneTextBox);
            this.Controls.Add(this.IsWorkingGroupBox);
            this.Controls.Add(this.EmployeePhoneLabel);
            this.Controls.Add(this.ContractEndDateLabel);
            this.Controls.Add(this.ContractEndDatePicker);
            this.Controls.Add(this.EmploymentDatePicker);
            this.Controls.Add(this.EmploymentDateLabel);
            this.Controls.Add(this.EmployeeMiddleNameTextBox);
            this.Controls.Add(this.EmployeeMiddleNameLabel);
            this.Controls.Add(this.EmployeeBirthDatePicker);
            this.Controls.Add(this.EmployeeAddressLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.EmployeeSalaryLabel);
            this.Controls.Add(this.EmployeePositionLabel);
            this.Controls.Add(this.EmployeeBirthDateLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.EmployeeSurnameLabel);
            this.Controls.Add(this.EmployeeSalaryTextBox);
            this.Controls.Add(this.EmployeePositionTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.EmployeeSurnameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddNewEmployeeForm";
            this.Text = "Добавление работника";
            this.IsWorkingGroupBox.ResumeLayout(false);
            this.IsWorkingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EmployeeSurnameTextBox;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox EmployeePositionTextBox;
        private System.Windows.Forms.TextBox EmployeeSalaryTextBox;
        private System.Windows.Forms.Label EmployeeSurnameLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeBirthDateLabel;
        private System.Windows.Forms.Label EmployeePositionLabel;
        private System.Windows.Forms.Label EmployeeSalaryLabel;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label EmployeeAddressLabel;
        private System.Windows.Forms.DateTimePicker EmployeeBirthDatePicker;
        private System.Windows.Forms.Label EmployeeMiddleNameLabel;
        private System.Windows.Forms.TextBox EmployeeMiddleNameTextBox;
        private System.Windows.Forms.Label EmploymentDateLabel;
        private System.Windows.Forms.DateTimePicker EmploymentDatePicker;
        private System.Windows.Forms.DateTimePicker ContractEndDatePicker;
        private System.Windows.Forms.Label ContractEndDateLabel;
        private System.Windows.Forms.Label EmployeePhoneLabel;
        private System.Windows.Forms.GroupBox IsWorkingGroupBox;
        private System.Windows.Forms.CheckBox NotWorkingCheckBox;
        private System.Windows.Forms.CheckBox WorkingChechBox;
        private System.Windows.Forms.TextBox EmployeePhoneTextBox;
        private System.Windows.Forms.TextBox EmployeeAddressTextBox;
    }
}