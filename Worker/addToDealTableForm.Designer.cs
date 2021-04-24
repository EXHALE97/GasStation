using System;

namespace Worker
{
    partial class AddToDealTableForm
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
            this.ClientCardComboBox = new System.Windows.Forms.ComboBox();
            this.DealDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CancelActionButton = new System.Windows.Forms.Button();
            this.AddDealButton = new System.Windows.Forms.Button();
            this.DealDateLabel = new System.Windows.Forms.Label();
            this.ClientCardLabel = new System.Windows.Forms.Label();
            this.DealPriceLabel = new System.Windows.Forms.Label();
            this.SupplyTypeAmountLabel = new System.Windows.Forms.Label();
            this.DealPriceTextBox = new System.Windows.Forms.TextBox();
            this.SupplyTypeAmountTextBox = new System.Windows.Forms.TextBox();
            this.SupplyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SupplyTypeLabel = new System.Windows.Forms.Label();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.MinutesTextBox = new System.Windows.Forms.TextBox();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.NowCheckBox = new System.Windows.Forms.CheckBox();
            this.StationLabel = new System.Windows.Forms.Label();
            this.StationComboBox = new System.Windows.Forms.ComboBox();
            this.PriceWithDiscountTextBox = new System.Windows.Forms.TextBox();
            this.DealPriceWithDiscountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientCardComboBox
            // 
            this.ClientCardComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ClientCardComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ClientCardComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientCardComboBox.FormattingEnabled = true;
            this.ClientCardComboBox.Location = new System.Drawing.Point(150, 150);
            this.ClientCardComboBox.Name = "ClientCardComboBox";
            this.ClientCardComboBox.Size = new System.Drawing.Size(123, 21);
            this.ClientCardComboBox.TabIndex = 45;
            this.ClientCardComboBox.SelectedIndexChanged += new EventHandler(this.ClientCardComboBox_SelectedIndexChanged);
            // 
            // DealDatePicker
            // 
            this.DealDatePicker.Enabled = false;
            this.DealDatePicker.Location = new System.Drawing.Point(150, 177);
            this.DealDatePicker.MaxDate = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            this.DealDatePicker.Name = "DealDatePicker";
            this.DealDatePicker.Size = new System.Drawing.Size(123, 20);
            this.DealDatePicker.TabIndex = 44;
            this.DealDatePicker.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            // 
            // CancelActionButton
            // 
            this.CancelActionButton.Location = new System.Drawing.Point(111, 276);
            this.CancelActionButton.Name = "CancelActionButton";
            this.CancelActionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelActionButton.TabIndex = 39;
            this.CancelActionButton.Text = "Отмена";
            this.CancelActionButton.UseVisualStyleBackColor = true;
            this.CancelActionButton.Click += new System.EventHandler(this.CancelActionButton_Click);
            // 
            // AddDealButton
            // 
            this.AddDealButton.Location = new System.Drawing.Point(198, 276);
            this.AddDealButton.Name = "AddDealButton";
            this.AddDealButton.Size = new System.Drawing.Size(75, 23);
            this.AddDealButton.TabIndex = 38;
            this.AddDealButton.Text = "Добавить";
            this.AddDealButton.UseVisualStyleBackColor = true;
            this.AddDealButton.Click += new System.EventHandler(this.AddDealButton_Click);
            // 
            // DealDateLabel
            // 
            this.DealDateLabel.AutoSize = true;
            this.DealDateLabel.Location = new System.Drawing.Point(12, 183);
            this.DealDateLabel.Name = "DealDateLabel";
            this.DealDateLabel.Size = new System.Drawing.Size(75, 13);
            this.DealDateLabel.TabIndex = 34;
            this.DealDateLabel.Text = "Дата сделки:";
            // 
            // ClientCardLabel
            // 
            this.ClientCardLabel.AutoSize = true;
            this.ClientCardLabel.Location = new System.Drawing.Point(12, 153);
            this.ClientCardLabel.Name = "ClientCardLabel";
            this.ClientCardLabel.Size = new System.Drawing.Size(78, 13);
            this.ClientCardLabel.TabIndex = 33;
            this.ClientCardLabel.Text = "Номер карты:";
            // 
            // DealPriceLabel
            // 
            this.DealPriceLabel.AutoSize = true;
            this.DealPriceLabel.Location = new System.Drawing.Point(12, 100);
            this.DealPriceLabel.Name = "DealPriceLabel";
            this.DealPriceLabel.Size = new System.Drawing.Size(36, 13);
            this.DealPriceLabel.TabIndex = 32;
            this.DealPriceLabel.Text = "Цена:";
            // 
            // SupplyTypeAmountLabel
            // 
            this.SupplyTypeAmountLabel.AutoSize = true;
            this.SupplyTypeAmountLabel.Location = new System.Drawing.Point(12, 74);
            this.SupplyTypeAmountLabel.Name = "SupplyTypeAmountLabel";
            this.SupplyTypeAmountLabel.Size = new System.Drawing.Size(107, 13);
            this.SupplyTypeAmountLabel.TabIndex = 31;
            this.SupplyTypeAmountLabel.Text = "Количество товара:";
            // 
            // DealPriceTextBox
            // 
            this.DealPriceTextBox.Location = new System.Drawing.Point(150, 97);
            this.DealPriceTextBox.Name = "DealPriceTextBox";
            this.DealPriceTextBox.ReadOnly = true;
            this.DealPriceTextBox.Size = new System.Drawing.Size(123, 20);
            this.DealPriceTextBox.TabIndex = 27;
            this.DealPriceTextBox.TextChanged += new System.EventHandler(this.DealPriceTextBox_TextChanged);
            // 
            // SupplyTypeAmountTextBox
            // 
            this.SupplyTypeAmountTextBox.Location = new System.Drawing.Point(150, 71);
            this.SupplyTypeAmountTextBox.Name = "SupplyTypeAmountTextBox";
            this.SupplyTypeAmountTextBox.Size = new System.Drawing.Size(123, 20);
            this.SupplyTypeAmountTextBox.TabIndex = 26;
            this.SupplyTypeAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SupplyTypeAmountTextBox_KeyPress);
            this.SupplyTypeAmountTextBox.TextChanged += new EventHandler(this.SupplyTypeAmountTextBox_TextChanged);
            // 
            // SupplyTypeComboBox
            // 
            this.SupplyTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SupplyTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SupplyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplyTypeComboBox.FormattingEnabled = true;
            this.SupplyTypeComboBox.Location = new System.Drawing.Point(150, 44);
            this.SupplyTypeComboBox.Name = "SupplyTypeComboBox";
            this.SupplyTypeComboBox.Size = new System.Drawing.Size(123, 21);
            this.SupplyTypeComboBox.TabIndex = 48;
            this.SupplyTypeComboBox.SelectedIndexChanged +=
                new EventHandler(this.SupplyTypeComboBox_SelectedIndexChanged);
            // 
            // SupplyTypeLabel
            // 
            this.SupplyTypeLabel.AutoSize = true;
            this.SupplyTypeLabel.Location = new System.Drawing.Point(12, 47);
            this.SupplyTypeLabel.Name = "SupplyTypeLabel";
            this.SupplyTypeLabel.Size = new System.Drawing.Size(67, 13);
            this.SupplyTypeLabel.TabIndex = 49;
            this.SupplyTypeLabel.Text = "Тип товара:";
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Location = new System.Drawing.Point(250, 212);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(23, 20);
            this.HoursTextBox.TabIndex = 50;
            this.HoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoursTextBox_KeyPress);
            // 
            // MinutesTextBox
            // 
            this.MinutesTextBox.Location = new System.Drawing.Point(250, 240);
            this.MinutesTextBox.Name = "MinutesTextBox";
            this.MinutesTextBox.Size = new System.Drawing.Size(23, 20);
            this.MinutesTextBox.TabIndex = 51;
            this.MinutesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinutesTextBox_KeyPress);
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(182, 215);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(30, 13);
            this.HoursLabel.TabIndex = 52;
            this.HoursLabel.Text = "Час:";
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Location = new System.Drawing.Point(182, 243);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(47, 13);
            this.MinutesLabel.TabIndex = 53;
            this.MinutesLabel.Text = "Минута:";
            // 
            // NowCheckBox
            // 
            this.NowCheckBox.AutoSize = true;
            this.NowCheckBox.Location = new System.Drawing.Point(15, 239);
            this.NowCheckBox.Name = "NowCheckBox";
            this.NowCheckBox.Size = new System.Drawing.Size(62, 17);
            this.NowCheckBox.TabIndex = 54;
            this.NowCheckBox.Text = "Сейчас";
            this.NowCheckBox.UseVisualStyleBackColor = true;
            this.NowCheckBox.CheckedChanged += new System.EventHandler(this.NowCheckBox_CheckedChanged);
            // 
            // StationLabel
            // 
            this.StationLabel.AutoSize = true;
            this.StationLabel.Location = new System.Drawing.Point(12, 20);
            this.StationLabel.Name = "StationLabel";
            this.StationLabel.Size = new System.Drawing.Size(52, 13);
            this.StationLabel.TabIndex = 55;
            this.StationLabel.Text = "Станция:";
            // 
            // StationComboBox
            // 
            this.StationComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.StationComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.StationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StationComboBox.FormattingEnabled = true;
            this.StationComboBox.Location = new System.Drawing.Point(150, 17);
            this.StationComboBox.Name = "StationComboBox";
            this.StationComboBox.Size = new System.Drawing.Size(123, 21);
            this.StationComboBox.TabIndex = 56;
            // 
            // PriceWithDiscountTextBox
            // 
            this.PriceWithDiscountTextBox.Location = new System.Drawing.Point(150, 123);
            this.PriceWithDiscountTextBox.Name = "PriceWithDiscountTextBox";
            this.PriceWithDiscountTextBox.ReadOnly = true;
            this.PriceWithDiscountTextBox.Size = new System.Drawing.Size(123, 20);
            this.PriceWithDiscountTextBox.TabIndex = 57;
            // 
            // DealPriceWithDiscountLabel
            // 
            this.DealPriceWithDiscountLabel.AutoSize = true;
            this.DealPriceWithDiscountLabel.Location = new System.Drawing.Point(12, 126);
            this.DealPriceWithDiscountLabel.Name = "DealPriceWithDiscountLabel";
            this.DealPriceWithDiscountLabel.Size = new System.Drawing.Size(96, 13);
            this.DealPriceWithDiscountLabel.TabIndex = 58;
            this.DealPriceWithDiscountLabel.Text = "Цена со скидкой:";
            // 
            // AddToDealTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 312);
            this.Controls.Add(this.DealPriceWithDiscountLabel);
            this.Controls.Add(this.PriceWithDiscountTextBox);
            this.Controls.Add(this.StationComboBox);
            this.Controls.Add(this.StationLabel);
            this.Controls.Add(this.NowCheckBox);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.MinutesTextBox);
            this.Controls.Add(this.HoursTextBox);
            this.Controls.Add(this.SupplyTypeLabel);
            this.Controls.Add(this.SupplyTypeComboBox);
            this.Controls.Add(this.ClientCardComboBox);
            this.Controls.Add(this.DealDatePicker);
            this.Controls.Add(this.CancelActionButton);
            this.Controls.Add(this.AddDealButton);
            this.Controls.Add(this.DealDateLabel);
            this.Controls.Add(this.ClientCardLabel);
            this.Controls.Add(this.DealPriceLabel);
            this.Controls.Add(this.SupplyTypeAmountLabel);
            this.Controls.Add(this.DealPriceTextBox);
            this.Controls.Add(this.SupplyTypeAmountTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddToDealTableForm";
            this.Text = "Добавление сделки";
            this.Load += new System.EventHandler(this.UpdateDealTableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClientCardComboBox;
        private System.Windows.Forms.DateTimePicker DealDatePicker;
        private System.Windows.Forms.Button CancelActionButton;
        private System.Windows.Forms.Button AddDealButton;
        private System.Windows.Forms.Label DealDateLabel;
        private System.Windows.Forms.Label ClientCardLabel;
        private System.Windows.Forms.Label DealPriceLabel;
        private System.Windows.Forms.Label SupplyTypeAmountLabel;
        private System.Windows.Forms.TextBox DealPriceTextBox;
        private System.Windows.Forms.TextBox SupplyTypeAmountTextBox;
        private System.Windows.Forms.ComboBox SupplyTypeComboBox;
        private System.Windows.Forms.Label SupplyTypeLabel;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.TextBox MinutesTextBox;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.CheckBox NowCheckBox;
        private System.Windows.Forms.Label StationLabel;
        private System.Windows.Forms.ComboBox StationComboBox;
        private System.Windows.Forms.TextBox PriceWithDiscountTextBox;
        private System.Windows.Forms.Label DealPriceWithDiscountLabel;
    }
}