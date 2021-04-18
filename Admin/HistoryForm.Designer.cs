using System;

namespace Admin
{
    partial class HistoryForm
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
            this.HistoryTable = new System.Windows.Forms.DataGridView();
            this.HistoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HitoryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // HistoryTable
            // 
            this.HistoryTable.AllowUserToAddRows = false;
            this.HistoryTable.AllowUserToDeleteRows = false;
            this.HistoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HistoryId,
            this.HistoryOperation,
            this.HitoryDate});
            this.HistoryTable.Location = new System.Drawing.Point(0, 0);
            this.HistoryTable.Name = "HistoryTable";
            this.HistoryTable.ReadOnly = true;
            this.HistoryTable.Size = new System.Drawing.Size(544, 449);
            this.HistoryTable.TabIndex = 0;
            // 
            // HistoryId
            // 
            this.HistoryId.HeaderText = "ID";
            this.HistoryId.Name = "HistoryId";
            this.HistoryId.ReadOnly = true;
            // 
            // HistoryOperation
            // 
            this.HistoryOperation.HeaderText = "Операция";
            this.HistoryOperation.Name = "HistoryOperation";
            this.HistoryOperation.ReadOnly = true;
            this.HistoryOperation.Width = 300;
            // 
            // HitoryDate
            // 
            this.HitoryDate.HeaderText = "Date";
            this.HitoryDate.Name = "HitoryDate";
            this.HitoryDate.ReadOnly = true;
            // 
            // ShowHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.HistoryTable);
            this.Name = "ShowHistoryForm";
            this.Text = "ShowHistoryForm";
            this.Load += new System.EventHandler(this.ShowHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView HistoryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn HitoryDate;
    }
}