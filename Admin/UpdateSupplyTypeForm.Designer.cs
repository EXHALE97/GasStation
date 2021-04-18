using System;
using System.Windows.Forms;

namespace Admin
{
    partial class UpdateSupplyTypeForm
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
            this.SupplyTypeNameLabel = new System.Windows.Forms.Label();
            this.SupplyTypePriceLabel = new System.Windows.Forms.Label();
            this.IsSellingGroupBox = new System.Windows.Forms.GroupBox();
            this.CancelActionButton = new System.Windows.Forms.Button();
            this.UpdateSupplyTpeButton = new System.Windows.Forms.Button();
            this.SellingRadio = new System.Windows.Forms.RadioButton();
            this.NotSellingRadio = new System.Windows.Forms.RadioButton();
            this.SupplyTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.SupplyTypePriceTextBox = new System.Windows.Forms.TextBox();
            this.IsSellingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SupplyTypeNameLabel
            // 
            this.SupplyTypeNameLabel.AutoSize = true;
            this.SupplyTypeNameLabel.Location = new System.Drawing.Point(12, 21);
            this.SupplyTypeNameLabel.Name = "SupplyTypeNameLabel";
            this.SupplyTypeNameLabel.Size = new System.Drawing.Size(60, 13);
            this.SupplyTypeNameLabel.TabIndex = 0;
            this.SupplyTypeNameLabel.Text = "Название:";
            // 
            // SupplyTypePriceLabel
            // 
            this.SupplyTypePriceLabel.AutoSize = true;
            this.SupplyTypePriceLabel.Location = new System.Drawing.Point(12, 48);
            this.SupplyTypePriceLabel.Name = "SupplyTypePriceLabel";
            this.SupplyTypePriceLabel.Size = new System.Drawing.Size(36, 13);
            this.SupplyTypePriceLabel.TabIndex = 1;
            this.SupplyTypePriceLabel.Text = "Цена:";
            // 
            // IsSellingGroupBox
            // 
            this.IsSellingGroupBox.Controls.Add(this.NotSellingRadio);
            this.IsSellingGroupBox.Controls.Add(this.SellingRadio);
            this.IsSellingGroupBox.Location = new System.Drawing.Point(15, 74);
            this.IsSellingGroupBox.Name = "IsSellingGroupBox";
            this.IsSellingGroupBox.Size = new System.Drawing.Size(200, 50);
            this.IsSellingGroupBox.TabIndex = 2;
            this.IsSellingGroupBox.TabStop = false;
            this.IsSellingGroupBox.Text = "В продаже";
            // 
            // CancelActionButton
            // 
            this.CancelActionButton.Location = new System.Drawing.Point(40, 130);
            this.CancelActionButton.Name = "CancelActionButton";
            this.CancelActionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelActionButton.TabIndex = 0;
            this.CancelActionButton.Text = "Отмена";
            this.CancelActionButton.UseVisualStyleBackColor = true;
            this.CancelActionButton.Click += new System.EventHandler(this.CancelActionButton_Click);
            // 
            // UpdateSupplyTpeButton
            // 
            this.UpdateSupplyTpeButton.Location = new System.Drawing.Point(121, 130);
            this.UpdateSupplyTpeButton.Name = "UpdateSupplyTpeButton";
            this.UpdateSupplyTpeButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateSupplyTpeButton.TabIndex = 3;
            this.UpdateSupplyTpeButton.Text = "Обновить";
            this.UpdateSupplyTpeButton.UseVisualStyleBackColor = true;
            this.UpdateSupplyTpeButton.Click += new System.EventHandler(this.UpdateSupplyTpeButton_Click);
            // 
            // SellingRadio
            // 
            this.SellingRadio.AutoSize = true;
            this.SellingRadio.Location = new System.Drawing.Point(66, 19);
            this.SellingRadio.Name = "SellingRadio";
            this.SellingRadio.Size = new System.Drawing.Size(40, 17);
            this.SellingRadio.TabIndex = 4;
            this.SellingRadio.TabStop = true;
            this.SellingRadio.Text = "Да";
            this.SellingRadio.UseVisualStyleBackColor = true;
            // 
            // NotSellingRadio
            // 
            this.NotSellingRadio.AutoSize = true;
            this.NotSellingRadio.Location = new System.Drawing.Point(137, 19);
            this.NotSellingRadio.Name = "NotSellingRadio";
            this.NotSellingRadio.Size = new System.Drawing.Size(44, 17);
            this.NotSellingRadio.TabIndex = 5;
            this.NotSellingRadio.TabStop = true;
            this.NotSellingRadio.Text = "Нет";
            this.NotSellingRadio.UseVisualStyleBackColor = true;
            // 
            // SupplyTypeNameTextBox
            // 
            this.SupplyTypeNameTextBox.Location = new System.Drawing.Point(81, 18);
            this.SupplyTypeNameTextBox.Name = "SupplyTypeNameTextBox";
            this.SupplyTypeNameTextBox.Size = new System.Drawing.Size(115, 20);
            this.SupplyTypeNameTextBox.TabIndex = 6;
            this.SupplyTypeNameTextBox.KeyPress += new KeyPressEventHandler(this.SupplyTypeNameTextBox_KeyPress);
            // 
            // SupplyTypePriceTextBox
            // 
            this.SupplyTypePriceTextBox.Location = new System.Drawing.Point(81, 45);
            this.SupplyTypePriceTextBox.Name = "SupplyTypePriceTextBox";
            this.SupplyTypePriceTextBox.Size = new System.Drawing.Size(115, 20);
            this.SupplyTypePriceTextBox.TabIndex = 7;
            this.SupplyTypePriceTextBox.KeyPress += new KeyPressEventHandler(this.SupplyTypePriceTextBox_KeyPress);
            // 
            // UpdateSupplyTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 166);
            this.Controls.Add(this.SupplyTypePriceTextBox);
            this.Controls.Add(this.SupplyTypeNameTextBox);
            this.Controls.Add(this.UpdateSupplyTpeButton);
            this.Controls.Add(this.CancelActionButton);
            this.Controls.Add(this.IsSellingGroupBox);
            this.Controls.Add(this.SupplyTypePriceLabel);
            this.Controls.Add(this.SupplyTypeNameLabel);
            this.Name = "UpdateSupplyTypeForm";
            this.Text = "Обновление информации о товаре";
            this.IsSellingGroupBox.ResumeLayout(false);
            this.IsSellingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new EventHandler(this.UpdateStationForm_Load);
        }

        #endregion

        private System.Windows.Forms.Label SupplyTypeNameLabel;
        private System.Windows.Forms.Label SupplyTypePriceLabel;
        private System.Windows.Forms.GroupBox IsSellingGroupBox;
        private System.Windows.Forms.RadioButton NotSellingRadio;
        private System.Windows.Forms.RadioButton SellingRadio;
        private System.Windows.Forms.Button CancelActionButton;
        private System.Windows.Forms.Button UpdateSupplyTpeButton;
        private System.Windows.Forms.TextBox SupplyTypeNameTextBox;
        private System.Windows.Forms.TextBox SupplyTypePriceTextBox;
    }
}