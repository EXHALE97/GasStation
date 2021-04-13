namespace Admin
{
    partial class AddNewStationForm
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
            this.StationNameTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.StationNameLabel = new System.Windows.Forms.Label();
            this.StationCityLabel = new System.Windows.Forms.Label();
            this.StationAddressLabel = new System.Windows.Forms.Label();
            this.AddStationButton = new System.Windows.Forms.Button();
            this.CancelAddingButton = new System.Windows.Forms.Button();
            this.IsWorkingGroupBox = new System.Windows.Forms.GroupBox();
            this.NotWorkingRadio = new System.Windows.Forms.RadioButton();
            this.WorkingRadio = new System.Windows.Forms.RadioButton();
            this.IsWorkingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StationNameTextBox
            // 
            this.StationNameTextBox.Location = new System.Drawing.Point(154, 12);
            this.StationNameTextBox.Name = "StationNameTextBox";
            this.StationNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.StationNameTextBox.TabIndex = 0;
            this.StationNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StationNameTextBox_KeyPress);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(154, 39);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(138, 20);
            this.CityTextBox.TabIndex = 2;
            this.CityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityTextBox_KeyPress);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(154, 65);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(138, 20);
            this.AddressTextBox.TabIndex = 3;
            this.AddressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressTextBox_KeyPress);
            // 
            // StationNameLabel
            // 
            this.StationNameLabel.AutoSize = true;
            this.StationNameLabel.Location = new System.Drawing.Point(12, 15);
            this.StationNameLabel.Name = "StationNameLabel";
            this.StationNameLabel.Size = new System.Drawing.Size(60, 13);
            this.StationNameLabel.TabIndex = 5;
            this.StationNameLabel.Text = "Название:";
            // 
            // StationCityLabel
            // 
            this.StationCityLabel.AutoSize = true;
            this.StationCityLabel.Location = new System.Drawing.Point(12, 42);
            this.StationCityLabel.Name = "StationCityLabel";
            this.StationCityLabel.Size = new System.Drawing.Size(43, 13);
            this.StationCityLabel.TabIndex = 7;
            this.StationCityLabel.Text = "Город: ";
            // 
            // StationAddressLabel
            // 
            this.StationAddressLabel.AutoSize = true;
            this.StationAddressLabel.Location = new System.Drawing.Point(12, 68);
            this.StationAddressLabel.Name = "StationAddressLabel";
            this.StationAddressLabel.Size = new System.Drawing.Size(44, 13);
            this.StationAddressLabel.TabIndex = 8;
            this.StationAddressLabel.Text = "Адрес: ";
            // 
            // AddStationButton
            // 
            this.AddStationButton.Location = new System.Drawing.Point(217, 154);
            this.AddStationButton.Name = "AddStationButton";
            this.AddStationButton.Size = new System.Drawing.Size(75, 23);
            this.AddStationButton.TabIndex = 10;
            this.AddStationButton.Text = "Добавить";
            this.AddStationButton.UseVisualStyleBackColor = true;
            this.AddStationButton.Click += new System.EventHandler(this.AddStationButton_Click);
            // 
            // CancelAddingButton
            // 
            this.CancelAddingButton.Location = new System.Drawing.Point(136, 154);
            this.CancelAddingButton.Name = "CancelAddingButton";
            this.CancelAddingButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAddingButton.TabIndex = 11;
            this.CancelAddingButton.Text = "Отменить";
            this.CancelAddingButton.UseVisualStyleBackColor = true;
            this.CancelAddingButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IsWorkingGroupBox
            // 
            this.IsWorkingGroupBox.Controls.Add(this.NotWorkingRadio);
            this.IsWorkingGroupBox.Controls.Add(this.WorkingRadio);
            this.IsWorkingGroupBox.Location = new System.Drawing.Point(11, 91);
            this.IsWorkingGroupBox.Name = "IsWorkingGroupBox";
            this.IsWorkingGroupBox.Size = new System.Drawing.Size(281, 45);
            this.IsWorkingGroupBox.TabIndex = 12;
            this.IsWorkingGroupBox.TabStop = false;
            this.IsWorkingGroupBox.Text = "Работает:";
            // 
            // NotWorkingRadio
            // 
            this.NotWorkingRadio.AutoSize = true;
            this.NotWorkingRadio.Location = new System.Drawing.Point(125, 19);
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
            this.WorkingRadio.Location = new System.Drawing.Point(6, 19);
            this.WorkingRadio.Name = "WorkingRadio";
            this.WorkingRadio.Size = new System.Drawing.Size(40, 17);
            this.WorkingRadio.TabIndex = 0;
            this.WorkingRadio.TabStop = true;
            this.WorkingRadio.Text = "Да";
            this.WorkingRadio.UseVisualStyleBackColor = true;
            // 
            // AddNewStationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 186);
            this.Controls.Add(this.IsWorkingGroupBox);
            this.Controls.Add(this.CancelAddingButton);
            this.Controls.Add(this.AddStationButton);
            this.Controls.Add(this.StationAddressLabel);
            this.Controls.Add(this.StationCityLabel);
            this.Controls.Add(this.StationNameLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.StationNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddNewStationForm";
            this.Text = "Добавлении станции";
            this.IsWorkingGroupBox.ResumeLayout(false);
            this.IsWorkingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StationNameTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label StationNameLabel;
        private System.Windows.Forms.Label StationCityLabel;
        private System.Windows.Forms.Label StationAddressLabel;
        private System.Windows.Forms.Button AddStationButton;
        private System.Windows.Forms.Button CancelAddingButton;
        private System.Windows.Forms.GroupBox IsWorkingGroupBox;
        private System.Windows.Forms.RadioButton NotWorkingRadio;
        private System.Windows.Forms.RadioButton WorkingRadio;
    }
}