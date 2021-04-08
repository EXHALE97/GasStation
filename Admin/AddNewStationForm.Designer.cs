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
            this.TbStationName = new System.Windows.Forms.TextBox();
            this.TextBoxCity = new System.Windows.Forms.TextBox();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.StationNameLabel = new System.Windows.Forms.Label();
            this.StationCityLabel = new System.Windows.Forms.Label();
            this.StationAddressLabel = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.IsWorkingGroupBox = new System.Windows.Forms.GroupBox();
            this.NotWorkingRadio = new System.Windows.Forms.RadioButton();
            this.WorkingRadio = new System.Windows.Forms.RadioButton();
            this.IsWorkingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbStationName
            // 
            this.TbStationName.Location = new System.Drawing.Point(154, 12);
            this.TbStationName.Name = "TbStationName";
            this.TbStationName.Size = new System.Drawing.Size(138, 20);
            this.TbStationName.TabIndex = 0;
            this.TbStationName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOrgName_KeyPress);
            // 
            // TextBoxCity
            // 
            this.TextBoxCity.Location = new System.Drawing.Point(154, 39);
            this.TextBoxCity.Name = "TextBoxCity";
            this.TextBoxCity.Size = new System.Drawing.Size(138, 20);
            this.TextBoxCity.TabIndex = 2;
            this.TextBoxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCity_KeyPress);
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(154, 65);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(138, 20);
            this.TextBoxAddress.TabIndex = 3;
            this.TextBoxAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStreet_KeyPress);
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 154);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(136, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.StationAddressLabel);
            this.Controls.Add(this.StationCityLabel);
            this.Controls.Add(this.StationNameLabel);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.TextBoxCity);
            this.Controls.Add(this.TbStationName);
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

        private System.Windows.Forms.TextBox TbStationName;
        private System.Windows.Forms.TextBox TextBoxCity;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.Label StationNameLabel;
        private System.Windows.Forms.Label StationCityLabel;
        private System.Windows.Forms.Label StationAddressLabel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox IsWorkingGroupBox;
        private System.Windows.Forms.RadioButton NotWorkingRadio;
        private System.Windows.Forms.RadioButton WorkingRadio;
    }
}