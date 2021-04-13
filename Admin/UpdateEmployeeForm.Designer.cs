using System.Windows.Forms;

namespace Admin
{
    partial class UpdateEmployeeForm
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
            this.EmployeeSurNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeePositionTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeSalaryTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeSurNameLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeePositionLabel = new System.Windows.Forms.Label();
            this.EmployeeSalaryLabel = new System.Windows.Forms.Label();
            this.UpdateEmployeeButton = new System.Windows.Forms.Button();
            this.CancelUpdateButton = new System.Windows.Forms.Button();
            this.EmployeeMiddleNameLabel = new System.Windows.Forms.Label();
            this.EmployeeAddressLabel = new System.Windows.Forms.Label();
            this.EmploymentDateLabel = new System.Windows.Forms.Label();
            this.EmployeeBirthdayLabel = new System.Windows.Forms.Label();
            this.ConctractEndLabel = new System.Windows.Forms.Label();
            this.EmployeePhoneLabel = new System.Windows.Forms.Label();
            this.EmployeeCredsLabel = new System.Windows.Forms.Label();
            this.EmployeeMiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeAddressTextBox = new System.Windows.Forms.TextBox();
            this.EmployeePhoneTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeCredsComboBox = new System.Windows.Forms.ComboBox();
            this.IsWorkingGroupBox = new System.Windows.Forms.GroupBox();
            this.NotWorkingRadio = new System.Windows.Forms.RadioButton();
            this.WorkingRadio = new System.Windows.Forms.RadioButton();
            this.EmploymentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EmployeeBirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.ConctractEndPicker = new System.Windows.Forms.DateTimePicker();
            this.IsWorkingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeSurNameTextBox
            // 
            this.EmployeeSurNameTextBox.Location = new System.Drawing.Point(154, 12);
            this.EmployeeSurNameTextBox.Name = "EmployeeSurNameTextBox";
            this.EmployeeSurNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.EmployeeSurNameTextBox.TabIndex = 2;
            this.EmployeeSurNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeSurnameTextBox_KeyPress);
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(154, 38);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.EmployeeNameTextBox.TabIndex = 3;
            this.EmployeeNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeNameTextBox_KeyPress);
            // 
            // EmployeePositionTextBox
            // 
            this.EmployeePositionTextBox.Location = new System.Drawing.Point(154, 90);
            this.EmployeePositionTextBox.Name = "EmployeePositionTextBox";
            this.EmployeePositionTextBox.Size = new System.Drawing.Size(167, 20);
            this.EmployeePositionTextBox.TabIndex = 6;
            this.EmployeePositionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeePositionTextBox_KeyPress);
            // 
            // EmployeeSalaryTextBox
            // 
            this.EmployeeSalaryTextBox.Location = new System.Drawing.Point(154, 194);
            this.EmployeeSalaryTextBox.Name = "EmployeeSalaryTextBox";
            this.EmployeeSalaryTextBox.Size = new System.Drawing.Size(167, 20);
            this.EmployeeSalaryTextBox.TabIndex = 8;
            this.EmployeeSalaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeSalaryTextBox_KeyPress);
            // 
            // EmployeeSurNameLabel
            // 
            this.EmployeeSurNameLabel.AutoSize = true;
            this.EmployeeSurNameLabel.Location = new System.Drawing.Point(22, 15);
            this.EmployeeSurNameLabel.Name = "EmployeeSurNameLabel";
            this.EmployeeSurNameLabel.Size = new System.Drawing.Size(62, 13);
            this.EmployeeSurNameLabel.TabIndex = 11;
            this.EmployeeSurNameLabel.Text = "Фамилия: ";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(22, 41);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(32, 13);
            this.EmployeeNameLabel.TabIndex = 12;
            this.EmployeeNameLabel.Text = "Имя:";
            // 
            // EmployeePositionLabel
            // 
            this.EmployeePositionLabel.AutoSize = true;
            this.EmployeePositionLabel.Location = new System.Drawing.Point(22, 93);
            this.EmployeePositionLabel.Name = "EmployeePositionLabel";
            this.EmployeePositionLabel.Size = new System.Drawing.Size(68, 13);
            this.EmployeePositionLabel.TabIndex = 15;
            this.EmployeePositionLabel.Text = "Должность:";
            // 
            // EmployeeSalaryLabel
            // 
            this.EmployeeSalaryLabel.AutoSize = true;
            this.EmployeeSalaryLabel.Location = new System.Drawing.Point(22, 197);
            this.EmployeeSalaryLabel.Name = "EmployeeSalaryLabel";
            this.EmployeeSalaryLabel.Size = new System.Drawing.Size(102, 13);
            this.EmployeeSalaryLabel.TabIndex = 17;
            this.EmployeeSalaryLabel.Text = "Заработная плата:";
            // 
            // UpdateEmployeeButton
            // 
            this.UpdateEmployeeButton.Location = new System.Drawing.Point(246, 386);
            this.UpdateEmployeeButton.Name = "UpdateEmployeeButton";
            this.UpdateEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateEmployeeButton.TabIndex = 18;
            this.UpdateEmployeeButton.Text = "Заменить";
            this.UpdateEmployeeButton.UseVisualStyleBackColor = true;
            this.UpdateEmployeeButton.Click += new System.EventHandler(this.UpdateEmployeeButton_Click);
            // 
            // CancelUpdateButton
            // 
            this.CancelUpdateButton.Location = new System.Drawing.Point(154, 386);
            this.CancelUpdateButton.Name = "CancelUpdateButton";
            this.CancelUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.CancelUpdateButton.TabIndex = 19;
            this.CancelUpdateButton.Text = "Отмена";
            this.CancelUpdateButton.UseVisualStyleBackColor = true;
            this.CancelUpdateButton.Click += new System.EventHandler(this.CancelUpdateButton_Click);
            // 
            // EmployeeMiddleNameLabel
            // 
            this.EmployeeMiddleNameLabel.AutoSize = true;
            this.EmployeeMiddleNameLabel.Location = new System.Drawing.Point(22, 67);
            this.EmployeeMiddleNameLabel.Name = "EmployeeMiddleNameLabel";
            this.EmployeeMiddleNameLabel.Size = new System.Drawing.Size(57, 13);
            this.EmployeeMiddleNameLabel.TabIndex = 20;
            this.EmployeeMiddleNameLabel.Text = "Отчество:";
            // 
            // EmployeeAddressLabel
            // 
            this.EmployeeAddressLabel.AutoSize = true;
            this.EmployeeAddressLabel.Location = new System.Drawing.Point(22, 224);
            this.EmployeeAddressLabel.Name = "EmployeeAddressLabel";
            this.EmployeeAddressLabel.Size = new System.Drawing.Size(41, 13);
            this.EmployeeAddressLabel.TabIndex = 21;
            this.EmployeeAddressLabel.Text = "Адрес:";
            // 
            // EmploymentDateLabel
            // 
            this.EmploymentDateLabel.AutoSize = true;
            this.EmploymentDateLabel.Location = new System.Drawing.Point(22, 148);
            this.EmploymentDateLabel.Name = "EmploymentDateLabel";
            this.EmploymentDateLabel.Size = new System.Drawing.Size(71, 13);
            this.EmploymentDateLabel.TabIndex = 22;
            this.EmploymentDateLabel.Text = "Дата найма:";
            // 
            // EmployeeBirthdayLabel
            // 
            this.EmployeeBirthdayLabel.AutoSize = true;
            this.EmployeeBirthdayLabel.Location = new System.Drawing.Point(22, 122);
            this.EmployeeBirthdayLabel.Name = "EmployeeBirthdayLabel";
            this.EmployeeBirthdayLabel.Size = new System.Drawing.Size(89, 13);
            this.EmployeeBirthdayLabel.TabIndex = 23;
            this.EmployeeBirthdayLabel.Text = "Дата рождения:";
            // 
            // ConctractEndLabel
            // 
            this.ConctractEndLabel.AutoSize = true;
            this.ConctractEndLabel.Location = new System.Drawing.Point(22, 172);
            this.ConctractEndLabel.Name = "ConctractEndLabel";
            this.ConctractEndLabel.Size = new System.Drawing.Size(120, 13);
            this.ConctractEndLabel.TabIndex = 24;
            this.ConctractEndLabel.Text = "Окончание контракта:";
            // 
            // EmployeePhoneLabel
            // 
            this.EmployeePhoneLabel.AutoSize = true;
            this.EmployeePhoneLabel.Location = new System.Drawing.Point(22, 250);
            this.EmployeePhoneLabel.Name = "EmployeePhoneLabel";
            this.EmployeePhoneLabel.Size = new System.Drawing.Size(55, 13);
            this.EmployeePhoneLabel.TabIndex = 25;
            this.EmployeePhoneLabel.Text = "Телефон:";
            // 
            // EmployeeCredsLabel
            // 
            this.EmployeeCredsLabel.AutoSize = true;
            this.EmployeeCredsLabel.Location = new System.Drawing.Point(22, 276);
            this.EmployeeCredsLabel.Name = "EmployeeCredsLabel";
            this.EmployeeCredsLabel.Size = new System.Drawing.Size(43, 13);
            this.EmployeeCredsLabel.TabIndex = 26;
            this.EmployeeCredsLabel.Text = "Креды:";
            // 
            // EmployeeMiddleNameTextBox
            // 
            this.EmployeeMiddleNameTextBox.Location = new System.Drawing.Point(154, 64);
            this.EmployeeMiddleNameTextBox.Name = "EmployeeMiddleNameTextBox";
            this.EmployeeMiddleNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.EmployeeMiddleNameTextBox.TabIndex = 27;
            this.EmployeeMiddleNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeMiddleNameTextBox_KeyPress);
            // 
            // EmployeeAddressTextBox
            // 
            this.EmployeeAddressTextBox.Location = new System.Drawing.Point(154, 221);
            this.EmployeeAddressTextBox.Name = "EmployeeAddressTextBox";
            this.EmployeeAddressTextBox.Size = new System.Drawing.Size(167, 20);
            this.EmployeeAddressTextBox.TabIndex = 28;
            this.EmployeeAddressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeAddressTextBox_KeyPress);
            // 
            // EmployeePhoneTextBox
            // 
            this.EmployeePhoneTextBox.Location = new System.Drawing.Point(154, 247);
            this.EmployeePhoneTextBox.Name = "EmployeePhoneTextBox";
            this.EmployeePhoneTextBox.Size = new System.Drawing.Size(167, 20);
            this.EmployeePhoneTextBox.TabIndex = 29;
            this.EmployeePhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeePhoneTextBox_KeyPress);
            // 
            // EmployeeCredsComboBox
            // 
            this.EmployeeCredsComboBox.FormattingEnabled = true;
            this.EmployeeCredsComboBox.Location = new System.Drawing.Point(154, 273);
            this.EmployeeCredsComboBox.Name = "EmployeeCredsComboBox";
            this.EmployeeCredsComboBox.Size = new System.Drawing.Size(167, 21);
            this.EmployeeCredsComboBox.TabIndex = 30;
            this.EmployeeCredsComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            // 
            // IsWorkingGroupBox
            // 
            this.IsWorkingGroupBox.Controls.Add(this.NotWorkingRadio);
            this.IsWorkingGroupBox.Controls.Add(this.WorkingRadio);
            this.IsWorkingGroupBox.Location = new System.Drawing.Point(25, 300);
            this.IsWorkingGroupBox.Name = "IsWorkingGroupBox";
            this.IsWorkingGroupBox.Size = new System.Drawing.Size(296, 68);
            this.IsWorkingGroupBox.TabIndex = 31;
            this.IsWorkingGroupBox.TabStop = false;
            this.IsWorkingGroupBox.Text = "Работает:";
            // 
            // NotWorkingRadio
            // 
            this.NotWorkingRadio.AutoSize = true;
            this.NotWorkingRadio.Location = new System.Drawing.Point(246, 36);
            this.NotWorkingRadio.Name = "NotWorkingRadio";
            this.NotWorkingRadio.Size = new System.Drawing.Size(44, 17);
            this.NotWorkingRadio.TabIndex = 1;
            this.NotWorkingRadio.TabStop = true;
            this.NotWorkingRadio.Text = "Нет";
            this.NotWorkingRadio.UseVisualStyleBackColor = true;
            // 
            // WorkingRadio
            // 
            this.WorkingRadio.AutoSize = true;
            this.WorkingRadio.Location = new System.Drawing.Point(129, 36);
            this.WorkingRadio.Name = "WorkingRadio";
            this.WorkingRadio.Size = new System.Drawing.Size(40, 17);
            this.WorkingRadio.TabIndex = 0;
            this.WorkingRadio.TabStop = true;
            this.WorkingRadio.Text = "Да";
            this.WorkingRadio.UseVisualStyleBackColor = true;
            // 
            // EmploymentDatePicker
            // 
            this.EmploymentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EmploymentDatePicker.Location = new System.Drawing.Point(154, 142);
            this.EmploymentDatePicker.Name = "EmploymentDatePicker";
            this.EmploymentDatePicker.Size = new System.Drawing.Size(167, 20);
            this.EmploymentDatePicker.TabIndex = 32;
            // 
            // EmployeeBirthdayPicker
            // 
            this.EmployeeBirthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EmployeeBirthdayPicker.Location = new System.Drawing.Point(154, 116);
            this.EmployeeBirthdayPicker.Name = "EmployeeBirthdayPicker";
            this.EmployeeBirthdayPicker.Size = new System.Drawing.Size(167, 20);
            this.EmployeeBirthdayPicker.TabIndex = 33;
            // 
            // ConctractEndPicker
            // 
            this.ConctractEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ConctractEndPicker.Location = new System.Drawing.Point(154, 168);
            this.ConctractEndPicker.Name = "ConctractEndPicker";
            this.ConctractEndPicker.Size = new System.Drawing.Size(167, 20);
            this.ConctractEndPicker.TabIndex = 34;
            // 
            // UpdateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 416);
            this.Controls.Add(this.ConctractEndPicker);
            this.Controls.Add(this.EmployeeBirthdayPicker);
            this.Controls.Add(this.EmploymentDatePicker);
            this.Controls.Add(this.IsWorkingGroupBox);
            this.Controls.Add(this.EmployeeCredsComboBox);
            this.Controls.Add(this.EmployeePhoneTextBox);
            this.Controls.Add(this.EmployeeAddressTextBox);
            this.Controls.Add(this.EmployeeMiddleNameTextBox);
            this.Controls.Add(this.EmployeeCredsLabel);
            this.Controls.Add(this.EmployeePhoneLabel);
            this.Controls.Add(this.ConctractEndLabel);
            this.Controls.Add(this.EmployeeBirthdayLabel);
            this.Controls.Add(this.EmploymentDateLabel);
            this.Controls.Add(this.EmployeeAddressLabel);
            this.Controls.Add(this.EmployeeMiddleNameLabel);
            this.Controls.Add(this.CancelUpdateButton);
            this.Controls.Add(this.UpdateEmployeeButton);
            this.Controls.Add(this.EmployeeSalaryLabel);
            this.Controls.Add(this.EmployeePositionLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.EmployeeSurNameLabel);
            this.Controls.Add(this.EmployeeSalaryTextBox);
            this.Controls.Add(this.EmployeePositionTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.EmployeeSurNameTextBox);
            this.Name = "UpdateEmployeeForm";
            this.Text = "Изменение данных о сотруднике";
            this.Load += new System.EventHandler(this.UpdateEmployeeForm_Load);
            this.IsWorkingGroupBox.ResumeLayout(false);
            this.IsWorkingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EmployeeSurNameTextBox;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox EmployeePositionTextBox;
        private System.Windows.Forms.TextBox EmployeeSalaryTextBox;
        private System.Windows.Forms.Label EmployeeSurNameLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeePositionLabel;
        private System.Windows.Forms.Label EmployeeSalaryLabel;
        private System.Windows.Forms.Button UpdateEmployeeButton;
        private System.Windows.Forms.Button CancelUpdateButton;
        private System.Windows.Forms.Label EmployeeMiddleNameLabel;
        private System.Windows.Forms.Label EmployeeAddressLabel;
        private System.Windows.Forms.Label EmploymentDateLabel;
        private System.Windows.Forms.Label EmployeeBirthdayLabel;
        private System.Windows.Forms.Label ConctractEndLabel;
        private System.Windows.Forms.Label EmployeePhoneLabel;
        private System.Windows.Forms.Label EmployeeCredsLabel;
        private System.Windows.Forms.TextBox EmployeeMiddleNameTextBox;
        private System.Windows.Forms.TextBox EmployeeAddressTextBox;
        private System.Windows.Forms.TextBox EmployeePhoneTextBox;
        private System.Windows.Forms.ComboBox EmployeeCredsComboBox;
        private System.Windows.Forms.GroupBox IsWorkingGroupBox;
        private System.Windows.Forms.RadioButton NotWorkingRadio;
        private System.Windows.Forms.RadioButton WorkingRadio;
        private System.Windows.Forms.DateTimePicker EmploymentDatePicker;
        private System.Windows.Forms.DateTimePicker EmployeeBirthdayPicker;
        private System.Windows.Forms.DateTimePicker ConctractEndPicker;
    }
}