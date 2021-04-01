namespace Admin
{
    partial class DealList
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
            this.fueltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDealList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDealList
            // 
            this.dgvDealList.AllowUserToAddRows = false;
            this.dgvDealList.AllowUserToDeleteRows = false;
            this.dgvDealList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDealList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fueltype,
            this.fuelamount,
            this.dealprice,
            this.dealdate});
            this.dgvDealList.Location = new System.Drawing.Point(12, 12);
            this.dgvDealList.Name = "dgvDealList";
            this.dgvDealList.Size = new System.Drawing.Size(449, 272);
            this.dgvDealList.TabIndex = 0;
            // 
            // fueltype
            // 
            this.fueltype.HeaderText = "Тип топлива";
            this.fueltype.Name = "fueltype";
            // 
            // fuelamount
            // 
            this.fuelamount.HeaderText = "Количество топлива";
            this.fuelamount.Name = "fuelamount";
            // 
            // dealprice
            // 
            this.dealprice.HeaderText = "Цена сделки";
            this.dealprice.Name = "dealprice";
            // 
            // dealdate
            // 
            this.dealdate.HeaderText = "Дата сделки";
            this.dealdate.Name = "dealdate";
            // 
            // DealList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 299);
            this.Controls.Add(this.dgvDealList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DealList";
            this.Text = "Список сделок";
            this.Load += new System.EventHandler(this.DealListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDealList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDealList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn fueltype;
    }
}