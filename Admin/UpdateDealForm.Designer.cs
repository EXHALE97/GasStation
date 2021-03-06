using System;

namespace Admin
{
    partial class UpdateDealForm
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
            this.DealDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CancelActionButton = new System.Windows.Forms.Button();
            this.UpdateDealButton = new System.Windows.Forms.Button();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.DealDateLabel = new System.Windows.Forms.Label();
            this.DealPriceLabel = new System.Windows.Forms.Label();
            this.SupplyTypeAmountLabel = new System.Windows.Forms.Label();
            this.SupplyTypeLabel = new System.Windows.Forms.Label();
            this.SupplyTypeAmountTextBox = new System.Windows.Forms.TextBox();
            this.SupplyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DealPriceTextBox = new System.Windows.Forms.TextBox();
            this.CardNumberComboBox = new System.Windows.Forms.ComboBox();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.MinuteTextBox = new System.Windows.Forms.TextBox();
            this.HourTextBox = new System.Windows.Forms.TextBox();
            this.PriceWithDiscountLabel = new System.Windows.Forms.Label();
            this.PriceWithDiscountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DealDatePicker
            // 
            this.DealDatePicker.CausesValidation = false;
            this.DealDatePicker.CustomFormat = "";
            this.DealDatePicker.Location = new System.Drawing.Point(118, 156);
            this.DealDatePicker.Name = "DealDatePicker";
            this.DealDatePicker.Size = new System.Drawing.Size(135, 20);
            this.DealDatePicker.TabIndex = 41;
            // 
            // CancelActionButton
            // 
            this.CancelActionButton.Location = new System.Drawing.Point(92, 257);
            this.CancelActionButton.Name = "CancelActionButton";
            this.CancelActionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelActionButton.TabIndex = 40;
            this.CancelActionButton.Text = "Отмена";
            this.CancelActionButton.UseVisualStyleBackColor = true;
            this.CancelActionButton.Click += new System.EventHandler(this.CancelActionButton_Click);
            // 
            // UpdateDealButton
            // 
            this.UpdateDealButton.Location = new System.Drawing.Point(178, 257);
            this.UpdateDealButton.Name = "UpdateDealButton";
            this.UpdateDealButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateDealButton.TabIndex = 39;
            this.UpdateDealButton.Text = "Заменить";
            this.UpdateDealButton.UseVisualStyleBackColor = true;
            this.UpdateDealButton.Click += new System.EventHandler(this.UpdateDealButton_Click);
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.AutoSize = true;
            this.CardNumberLabel.Location = new System.Drawing.Point(15, 131);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.CardNumberLabel.TabIndex = 36;
            this.CardNumberLabel.Text = "Номер карты:";
            // 
            // DealDateLabel
            // 
            this.DealDateLabel.AutoSize = true;
            this.DealDateLabel.Location = new System.Drawing.Point(15, 162);
            this.DealDateLabel.Name = "DealDateLabel";
            this.DealDateLabel.Size = new System.Drawing.Size(75, 13);
            this.DealDateLabel.TabIndex = 35;
            this.DealDateLabel.Text = "Дата сделки:";
            // 
            // DealPriceLabel
            // 
            this.DealPriceLabel.AutoSize = true;
            this.DealPriceLabel.Location = new System.Drawing.Point(15, 77);
            this.DealPriceLabel.Name = "DealPriceLabel";
            this.DealPriceLabel.Size = new System.Drawing.Size(75, 13);
            this.DealPriceLabel.TabIndex = 34;
            this.DealPriceLabel.Text = "Цена сделки:";
            // 
            // SupplyTypeAmountLabel
            // 
            this.SupplyTypeAmountLabel.AutoSize = true;
            this.SupplyTypeAmountLabel.Location = new System.Drawing.Point(15, 51);
            this.SupplyTypeAmountLabel.Name = "SupplyTypeAmountLabel";
            this.SupplyTypeAmountLabel.Size = new System.Drawing.Size(107, 13);
            this.SupplyTypeAmountLabel.TabIndex = 33;
            this.SupplyTypeAmountLabel.Text = "Количество товара:";
            // 
            // SupplyTypeLabel
            // 
            this.SupplyTypeLabel.AutoSize = true;
            this.SupplyTypeLabel.Location = new System.Drawing.Point(15, 26);
            this.SupplyTypeLabel.Name = "SupplyTypeLabel";
            this.SupplyTypeLabel.Size = new System.Drawing.Size(41, 13);
            this.SupplyTypeLabel.TabIndex = 32;
            this.SupplyTypeLabel.Text = "Товар:";
            // 
            // SupplyTypeAmountTextBox
            // 
            this.SupplyTypeAmountTextBox.Location = new System.Drawing.Point(147, 48);
            this.SupplyTypeAmountTextBox.Name = "SupplyTypeAmountTextBox";
            this.SupplyTypeAmountTextBox.Size = new System.Drawing.Size(106, 20);
            this.SupplyTypeAmountTextBox.TabIndex = 28;
            this.SupplyTypeAmountTextBox.TextChanged += new System.EventHandler(this.SupplyTypeAmountTextBox_TextChanged);
            this.SupplyTypeAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SupplyTypeAmountTextBox_KeyPress);
            // 
            // SupplyTypeComboBox
            // 
            this.SupplyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplyTypeComboBox.FormattingEnabled = true;
            this.SupplyTypeComboBox.Location = new System.Drawing.Point(147, 23);
            this.SupplyTypeComboBox.Name = "SupplyTypeComboBox";
            this.SupplyTypeComboBox.Size = new System.Drawing.Size(106, 21);
            this.SupplyTypeComboBox.TabIndex = 43;
            this.SupplyTypeComboBox.SelectedIndexChanged +=
                new EventHandler(this.SupplyTypeComboBox_SelectedIndexChanged);
            // 
            // DealPriceTextBox
            // 
            this.DealPriceTextBox.Enabled = false;
            this.DealPriceTextBox.Location = new System.Drawing.Point(147, 74);
            this.DealPriceTextBox.Name = "DealPriceTextBox";
            this.DealPriceTextBox.Size = new System.Drawing.Size(106, 20);
            this.DealPriceTextBox.TabIndex = 44;
            this.DealPriceTextBox.TextChanged += new System.EventHandler(this.DealPriceTextBox_TextChanged);
            this.DealPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DealPriceTextBox_KeyPress);
            // 
            // CardNumberComboBox
            // 
            this.CardNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CardNumberComboBox.FormattingEnabled = true;
            this.CardNumberComboBox.Location = new System.Drawing.Point(119, 128);
            this.CardNumberComboBox.Name = "CardNumberComboBox";
            this.CardNumberComboBox.Size = new System.Drawing.Size(135, 21);
            this.CardNumberComboBox.TabIndex = 45;
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Location = new System.Drawing.Point(162, 226);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(47, 13);
            this.MinuteLabel.TabIndex = 57;
            this.MinuteLabel.Text = "Минута:";
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Location = new System.Drawing.Point(162, 200);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(30, 13);
            this.HourLabel.TabIndex = 56;
            this.HourLabel.Text = "Час:";
            // 
            // MinuteTextBox
            // 
            this.MinuteTextBox.Location = new System.Drawing.Point(230, 223);
            this.MinuteTextBox.Name = "MinuteTextBox";
            this.MinuteTextBox.Size = new System.Drawing.Size(23, 20);
            this.MinuteTextBox.TabIndex = 55;
            this.MinuteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinuteTextBox_KeyPress);
            // 
            // HourTextBox
            // 
            this.HourTextBox.Location = new System.Drawing.Point(230, 197);
            this.HourTextBox.Name = "HourTextBox";
            this.HourTextBox.Size = new System.Drawing.Size(23, 20);
            this.HourTextBox.TabIndex = 54;
            this.HourTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HourTextBox_KeyPress);
            // 
            // PriceWithDiscountLabel
            // 
            this.PriceWithDiscountLabel.AutoSize = true;
            this.PriceWithDiscountLabel.Location = new System.Drawing.Point(15, 103);
            this.PriceWithDiscountLabel.Name = "PriceWithDiscountLabel";
            this.PriceWithDiscountLabel.Size = new System.Drawing.Size(96, 13);
            this.PriceWithDiscountLabel.TabIndex = 58;
            this.PriceWithDiscountLabel.Text = "Цена со скидкой:";
            // 
            // PriceWithDiscountTextBox
            // 
            this.PriceWithDiscountTextBox.Enabled = false;
            this.PriceWithDiscountTextBox.Location = new System.Drawing.Point(147, 100);
            this.PriceWithDiscountTextBox.Name = "PriceWithDiscountTextBox";
            this.PriceWithDiscountTextBox.Size = new System.Drawing.Size(106, 20);
            this.PriceWithDiscountTextBox.TabIndex = 59;
            // 
            // UpdateDealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 292);
            this.Controls.Add(this.PriceWithDiscountTextBox);
            this.Controls.Add(this.PriceWithDiscountLabel);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.MinuteTextBox);
            this.Controls.Add(this.HourTextBox);
            this.Controls.Add(this.CardNumberComboBox);
            this.Controls.Add(this.DealPriceTextBox);
            this.Controls.Add(this.SupplyTypeComboBox);
            this.Controls.Add(this.DealDatePicker);
            this.Controls.Add(this.CancelActionButton);
            this.Controls.Add(this.UpdateDealButton);
            this.Controls.Add(this.CardNumberLabel);
            this.Controls.Add(this.DealDateLabel);
            this.Controls.Add(this.DealPriceLabel);
            this.Controls.Add(this.SupplyTypeAmountLabel);
            this.Controls.Add(this.SupplyTypeLabel);
            this.Controls.Add(this.SupplyTypeAmountTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateDealForm";
            this.Text = "Обновление данных о сделке";
            this.Load += new System.EventHandler(this.UpdateDealTableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DealDatePicker;
        private System.Windows.Forms.Button CancelActionButton;
        private System.Windows.Forms.Button UpdateDealButton;
        private System.Windows.Forms.Label CardNumberLabel;
        private System.Windows.Forms.Label DealDateLabel;
        private System.Windows.Forms.Label DealPriceLabel;
        private System.Windows.Forms.Label SupplyTypeAmountLabel;
        private System.Windows.Forms.Label SupplyTypeLabel;
        private System.Windows.Forms.TextBox SupplyTypeAmountTextBox;
        private System.Windows.Forms.ComboBox SupplyTypeComboBox;
        private System.Windows.Forms.TextBox DealPriceTextBox;
        private System.Windows.Forms.ComboBox CardNumberComboBox;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.TextBox MinuteTextBox;
        private System.Windows.Forms.TextBox HourTextBox;
        private System.Windows.Forms.Label PriceWithDiscountLabel;
        private System.Windows.Forms.TextBox PriceWithDiscountTextBox;
    }
}