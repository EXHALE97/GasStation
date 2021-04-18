using System.Windows.Forms;

namespace Admin
{
    partial class UpdateStationForm
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
            this.StationNameLabel = new System.Windows.Forms.Label();
            this.StationCityLabel = new System.Windows.Forms.Label();
            this.StationAddressLabel = new System.Windows.Forms.Label();
            this.IsWorkingGroupBox = new System.Windows.Forms.GroupBox();
            this.WorkingRadio = new System.Windows.Forms.RadioButton();
            this.NotWorkingRadio = new System.Windows.Forms.RadioButton();
            this.StationNameTextBox = new System.Windows.Forms.TextBox();
            this.StationCityTextBox = new System.Windows.Forms.TextBox();
            this.StationAddressTextBox = new System.Windows.Forms.TextBox();
            this.CancelActionButton = new System.Windows.Forms.Button();
            this.UpdateStationButton = new System.Windows.Forms.Button();
            this.IsWorkingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StationNameLabel
            // 
            this.StationNameLabel.AutoSize = true;
            this.StationNameLabel.Location = new System.Drawing.Point(12, 15);
            this.StationNameLabel.Name = "StationNameLabel";
            this.StationNameLabel.Size = new System.Drawing.Size(60, 13);
            this.StationNameLabel.TabIndex = 0;
            this.StationNameLabel.Text = "Название:";
            // 
            // StationCityLabel
            // 
            this.StationCityLabel.AutoSize = true;
            this.StationCityLabel.Location = new System.Drawing.Point(12, 41);
            this.StationCityLabel.Name = "StationCityLabel";
            this.StationCityLabel.Size = new System.Drawing.Size(40, 13);
            this.StationCityLabel.TabIndex = 1;
            this.StationCityLabel.Text = "Город:";
            // 
            // StationAddressLabel
            // 
            this.StationAddressLabel.AutoSize = true;
            this.StationAddressLabel.Location = new System.Drawing.Point(12, 67);
            this.StationAddressLabel.Name = "StationAddressLabel";
            this.StationAddressLabel.Size = new System.Drawing.Size(41, 13);
            this.StationAddressLabel.TabIndex = 2;
            this.StationAddressLabel.Text = "Адрес:";
            // 
            // IsWorkingGroupBox
            // 
            this.IsWorkingGroupBox.Controls.Add(this.NotWorkingRadio);
            this.IsWorkingGroupBox.Controls.Add(this.WorkingRadio);
            this.IsWorkingGroupBox.Location = new System.Drawing.Point(15, 99);
            this.IsWorkingGroupBox.Name = "IsWorkingGroupBox";
            this.IsWorkingGroupBox.Size = new System.Drawing.Size(212, 59);
            this.IsWorkingGroupBox.TabIndex = 3;
            this.IsWorkingGroupBox.TabStop = false;
            this.IsWorkingGroupBox.Text = "Работает:";
            // 
            // WorkingRadio
            // 
            this.WorkingRadio.AutoSize = true;
            this.WorkingRadio.Location = new System.Drawing.Point(73, 29);
            this.WorkingRadio.Name = "WorkingRadio";
            this.WorkingRadio.Size = new System.Drawing.Size(40, 17);
            this.WorkingRadio.TabIndex = 0;
            this.WorkingRadio.TabStop = true;
            this.WorkingRadio.Text = "Да";
            this.WorkingRadio.UseVisualStyleBackColor = true;
            // 
            // NotWorkingRadio
            // 
            this.NotWorkingRadio.AutoSize = true;
            this.NotWorkingRadio.Location = new System.Drawing.Point(162, 29);
            this.NotWorkingRadio.Name = "NotWorkingRadio";
            this.NotWorkingRadio.Size = new System.Drawing.Size(44, 17);
            this.NotWorkingRadio.TabIndex = 1;
            this.NotWorkingRadio.TabStop = true;
            this.NotWorkingRadio.Text = "Нет";
            this.NotWorkingRadio.UseVisualStyleBackColor = true;
            // 
            // StationNameTextBox
            // 
            this.StationNameTextBox.Location = new System.Drawing.Point(88, 12);
            this.StationNameTextBox.Name = "StationNameTextBox";
            this.StationNameTextBox.Size = new System.Drawing.Size(139, 20);
            this.StationNameTextBox.TabIndex = 2;
            this.StationNameTextBox.KeyPress += new KeyPressEventHandler(this.StationNameTextBox_KeyPress);
            // 
            // StationCityTextBox
            // 
            this.StationCityTextBox.Location = new System.Drawing.Point(88, 38);
            this.StationCityTextBox.Name = "StationCityTextBox";
            this.StationCityTextBox.Size = new System.Drawing.Size(139, 20);
            this.StationCityTextBox.TabIndex = 4;
            this.StationCityTextBox.KeyPress += new KeyPressEventHandler(this.CityTextBox_KeyPress);
            // 
            // StationAddressTextBox
            // 
            this.StationAddressTextBox.Location = new System.Drawing.Point(88, 64);
            this.StationAddressTextBox.Name = "StationAddressTextBox";
            this.StationAddressTextBox.Size = new System.Drawing.Size(139, 20);
            this.StationAddressTextBox.TabIndex = 5;
            this.StationAddressTextBox.KeyPress += new KeyPressEventHandler(this.AddressTextBox_KeyPress);
            // 
            // CancelActionButton
            // 
            this.CancelActionButton.Location = new System.Drawing.Point(72, 173);
            this.CancelActionButton.Name = "CancelActionButton";
            this.CancelActionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelActionButton.TabIndex = 6;
            this.CancelActionButton.Text = "Отмена";
            this.CancelActionButton.UseVisualStyleBackColor = true;
            this.CancelActionButton.Click += new System.EventHandler(this.CancelActionButton_Click);
            // 
            // UpdateStationButton
            // 
            this.UpdateStationButton.Location = new System.Drawing.Point(153, 173);
            this.UpdateStationButton.Name = "UpdateStationButton";
            this.UpdateStationButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateStationButton.TabIndex = 7;
            this.UpdateStationButton.Text = "ОК";
            this.UpdateStationButton.UseVisualStyleBackColor = true;
            this.UpdateStationButton.Click += new System.EventHandler(this.UpdateStationButton_Click);
            // 
            // UpdateStationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 210);
            this.Controls.Add(this.UpdateStationButton);
            this.Controls.Add(this.CancelActionButton);
            this.Controls.Add(this.StationAddressTextBox);
            this.Controls.Add(this.StationCityTextBox);
            this.Controls.Add(this.StationNameTextBox);
            this.Controls.Add(this.IsWorkingGroupBox);
            this.Controls.Add(this.StationAddressLabel);
            this.Controls.Add(this.StationCityLabel);
            this.Controls.Add(this.StationNameLabel);
            this.Name = "UpdateStationForm";
            this.Text = "Обновление информации о станции";
            this.IsWorkingGroupBox.ResumeLayout(false);
            this.IsWorkingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.UpdateStationForm_Load);
        }

        #endregion

        private System.Windows.Forms.Label StationNameLabel;
        private System.Windows.Forms.Label StationCityLabel;
        private System.Windows.Forms.Label StationAddressLabel;
        private System.Windows.Forms.GroupBox IsWorkingGroupBox;
        private System.Windows.Forms.RadioButton NotWorkingRadio;
        private System.Windows.Forms.RadioButton WorkingRadio;
        private System.Windows.Forms.TextBox StationNameTextBox;
        private System.Windows.Forms.TextBox StationCityTextBox;
        private System.Windows.Forms.TextBox StationAddressTextBox;
        private System.Windows.Forms.Button CancelActionButton;
        private System.Windows.Forms.Button UpdateStationButton;
    }
}