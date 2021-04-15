namespace Admin
{
    partial class DealListForClientForm
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
            this.dgvDealList = new System.Windows.Forms.DataGridView();
            this.DealFuelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealFuelAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealFullPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceWithDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfDeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDealList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDealList
            // 
            this.dgvDealList.AllowUserToAddRows = false;
            this.dgvDealList.AllowUserToDeleteRows = false;
            this.dgvDealList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDealList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DealFuelType,
            this.DealFuelAmount,
            this.DealFullPrice,
            this.DealDiscount,
            this.PriceWithDiscount,
            this.DateOfDeal});
            this.dgvDealList.Location = new System.Drawing.Point(12, 12);
            this.dgvDealList.Name = "dgvDealList";
            this.dgvDealList.Size = new System.Drawing.Size(449, 272);
            this.dgvDealList.TabIndex = 0;
            // 
            // DealFuelType
            // 
            this.DealFuelType.HeaderText = "Тип топлива";
            this.DealFuelType.Name = "DealFuelType";
            // 
            // DealFuelAmount
            // 
            this.DealFuelAmount.HeaderText = "Количество топлива";
            this.DealFuelAmount.Name = "DealFuelAmount";
            // 
            // DealFullPrice
            // 
            this.DealFullPrice.HeaderText = "Цена сделки";
            this.DealFullPrice.Name = "DealFullPrice";
            // 
            // DealDiscount
            // 
            this.DealDiscount.HeaderText = "Скидка";
            this.DealDiscount.Name = "DealDiscount";
            this.DealDiscount.ReadOnly = true;
            // 
            // PriceWithDiscount
            // 
            this.PriceWithDiscount.HeaderText = "Цена со скидкой";
            this.PriceWithDiscount.Name = "PriceWithDiscount";
            this.PriceWithDiscount.ReadOnly = true;
            // 
            // DateOfDeal
            // 
            this.DateOfDeal.HeaderText = "Дата сделки";
            this.DateOfDeal.Name = "DateOfDeal";
            // 
            // DealListForClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 299);
            this.Controls.Add(this.dgvDealList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DealListForClientForm";
            this.Text = "Список сделок";
            this.Load += new System.EventHandler(this.DealListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDealList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDealList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealFuelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealFuelAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealFullPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceWithDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfDeal;
    }
}