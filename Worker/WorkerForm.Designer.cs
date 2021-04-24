namespace Worker
{
    partial class WorkerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabDealTable = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshDealTableButton = new System.Windows.Forms.Button();
            this.AddDealButton = new System.Windows.Forms.Button();
            this.DealsTable = new System.Windows.Forms.DataGridView();
            this.ClientCardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyTypeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceWithoutDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceWithDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSupplyTable = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RefreshSupplyTableButton = new System.Windows.Forms.Button();
            this.AddSupplyTable = new System.Windows.Forms.Button();
            this.SuppliesTable = new System.Windows.Forms.DataGridView();
            this.SupplyStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppliesSupplyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppliesSupplyTypeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppliesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msWorker = new System.Windows.Forms.MenuStrip();
            this.smUser = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshTables = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSessionName = new System.Windows.Forms.Label();
            this.tabAdmin.SuspendLayout();
            this.tabDealTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DealsTable)).BeginInit();
            this.tabSupplyTable.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliesTable)).BeginInit();
            this.msWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabDealTable);
            this.tabAdmin.Controls.Add(this.tabSupplyTable);
            this.tabAdmin.Location = new System.Drawing.Point(12, 27);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(724, 396);
            this.tabAdmin.TabIndex = 1;
            // 
            // tabDealTable
            // 
            this.tabDealTable.Controls.Add(this.groupBox1);
            this.tabDealTable.Controls.Add(this.DealsTable);
            this.tabDealTable.Location = new System.Drawing.Point(4, 22);
            this.tabDealTable.Name = "tabDealTable";
            this.tabDealTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabDealTable.Size = new System.Drawing.Size(716, 370);
            this.tabDealTable.TabIndex = 0;
            this.tabDealTable.Text = "Список сделок";
            this.tabDealTable.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RefreshDealTableButton);
            this.groupBox1.Controls.Add(this.AddDealButton);
            this.groupBox1.Location = new System.Drawing.Point(553, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 153);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функционал";
            // 
            // RefreshDealTableButton
            // 
            this.RefreshDealTableButton.Location = new System.Drawing.Point(6, 19);
            this.RefreshDealTableButton.Name = "RefreshDealTableButton";
            this.RefreshDealTableButton.Size = new System.Drawing.Size(145, 60);
            this.RefreshDealTableButton.TabIndex = 1;
            this.RefreshDealTableButton.Text = "Обновить таблицу сделок";
            this.RefreshDealTableButton.UseVisualStyleBackColor = true;
            this.RefreshDealTableButton.Click += new System.EventHandler(this.RefreshDealTableButton_Click);
            // 
            // AddDealButton
            // 
            this.AddDealButton.Location = new System.Drawing.Point(6, 85);
            this.AddDealButton.Name = "AddDealButton";
            this.AddDealButton.Size = new System.Drawing.Size(145, 60);
            this.AddDealButton.TabIndex = 3;
            this.AddDealButton.Text = "Оформить сделку";
            this.AddDealButton.UseVisualStyleBackColor = true;
            this.AddDealButton.Click += new System.EventHandler(this.AddDealButton_Click);
            // 
            // DealsTable
            // 
            this.DealsTable.AllowUserToAddRows = false;
            this.DealsTable.AllowUserToDeleteRows = false;
            this.DealsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DealsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientCardId,
            this.ClientFullName,
            this.SupplyType,
            this.SupplyTypeAmount,
            this.PriceWithoutDiscount,
            this.DiscountAmount,
            this.PriceWithDiscount,
            this.DealDate});
            this.DealsTable.Location = new System.Drawing.Point(3, 4);
            this.DealsTable.Name = "DealsTable";
            this.DealsTable.Size = new System.Drawing.Size(544, 366);
            this.DealsTable.TabIndex = 0;
            // 
            // ClientCardId
            // 
            this.ClientCardId.HeaderText = "Карта клиента";
            this.ClientCardId.Name = "ClientCardId";
            this.ClientCardId.ReadOnly = true;
            // 
            // ClientFullName
            // 
            this.ClientFullName.HeaderText = "Покупатель";
            this.ClientFullName.Name = "ClientFullName";
            this.ClientFullName.ReadOnly = true;
            // 
            // SupplyType
            // 
            this.SupplyType.HeaderText = "Тип товара";
            this.SupplyType.Name = "SupplyType";
            this.SupplyType.ReadOnly = true;
            // 
            // SupplyTypeAmount
            // 
            this.SupplyTypeAmount.HeaderText = "Количество товара";
            this.SupplyTypeAmount.Name = "SupplyTypeAmount";
            this.SupplyTypeAmount.ReadOnly = true;
            // 
            // PriceWithoutDiscount
            // 
            this.PriceWithoutDiscount.HeaderText = "Цена без скидки";
            this.PriceWithoutDiscount.Name = "PriceWithoutDiscount";
            this.PriceWithoutDiscount.ReadOnly = true;
            this.PriceWithoutDiscount.Width = 50;
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.HeaderText = "Сумма скидки";
            this.DiscountAmount.Name = "DiscountAmount";
            this.DiscountAmount.ReadOnly = true;
            // 
            // PriceWithDiscount
            // 
            this.PriceWithDiscount.HeaderText = "Цена со скидкой";
            this.PriceWithDiscount.Name = "PriceWithDiscount";
            this.PriceWithDiscount.ReadOnly = true;
            // 
            // DealDate
            // 
            this.DealDate.HeaderText = "Дата сделки";
            this.DealDate.Name = "DealDate";
            this.DealDate.ReadOnly = true;
            this.DealDate.Width = 150;
            // 
            // tabSupplyTable
            // 
            this.tabSupplyTable.Controls.Add(this.groupBox2);
            this.tabSupplyTable.Controls.Add(this.SuppliesTable);
            this.tabSupplyTable.Location = new System.Drawing.Point(4, 22);
            this.tabSupplyTable.Name = "tabSupplyTable";
            this.tabSupplyTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabSupplyTable.Size = new System.Drawing.Size(716, 370);
            this.tabSupplyTable.TabIndex = 1;
            this.tabSupplyTable.Text = "Список поставок";
            this.tabSupplyTable.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RefreshSupplyTableButton);
            this.groupBox2.Controls.Add(this.AddSupplyTable);
            this.groupBox2.Location = new System.Drawing.Point(492, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 149);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Функционал";
            // 
            // RefreshSupplyTableButton
            // 
            this.RefreshSupplyTableButton.Location = new System.Drawing.Point(6, 19);
            this.RefreshSupplyTableButton.Name = "RefreshSupplyTableButton";
            this.RefreshSupplyTableButton.Size = new System.Drawing.Size(206, 60);
            this.RefreshSupplyTableButton.TabIndex = 2;
            this.RefreshSupplyTableButton.Text = "Обновить таблицу поставок";
            this.RefreshSupplyTableButton.UseVisualStyleBackColor = true;
            this.RefreshSupplyTableButton.Click += new System.EventHandler(this.RefreshSupplyTableButton_Click);
            // 
            // AddSupplyTable
            // 
            this.AddSupplyTable.Location = new System.Drawing.Point(6, 85);
            this.AddSupplyTable.Name = "AddSupplyTable";
            this.AddSupplyTable.Size = new System.Drawing.Size(206, 60);
            this.AddSupplyTable.TabIndex = 1;
            this.AddSupplyTable.Text = "Оформить поставку";
            this.AddSupplyTable.UseVisualStyleBackColor = true;
            this.AddSupplyTable.Click += new System.EventHandler(this.AddSupplyTable_Click);
            // 
            // SuppliesTable
            // 
            this.SuppliesTable.AllowUserToAddRows = false;
            this.SuppliesTable.AllowUserToDeleteRows = false;
            this.SuppliesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuppliesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplyStation,
            this.SuppliesSupplyType,
            this.SuppliesSupplyTypeAmount,
            this.SuppliesDate});
            this.SuppliesTable.Location = new System.Drawing.Point(3, 3);
            this.SuppliesTable.Name = "SuppliesTable";
            this.SuppliesTable.Size = new System.Drawing.Size(483, 366);
            this.SuppliesTable.TabIndex = 0;
            // 
            // SupplyStation
            // 
            this.SupplyStation.HeaderText = "Станция";
            this.SupplyStation.Name = "SupplyStation";
            this.SupplyStation.ReadOnly = true;
            this.SupplyStation.Width = 120;
            // 
            // SuppliesSupplyType
            // 
            this.SuppliesSupplyType.HeaderText = "Тип товара";
            this.SuppliesSupplyType.Name = "SuppliesSupplyType";
            this.SuppliesSupplyType.ReadOnly = true;
            // 
            // SuppliesSupplyTypeAmount
            // 
            this.SuppliesSupplyTypeAmount.HeaderText = "Количество товара";
            this.SuppliesSupplyTypeAmount.Name = "SuppliesSupplyTypeAmount";
            this.SuppliesSupplyTypeAmount.ReadOnly = true;
            // 
            // SuppliesDate
            // 
            this.SuppliesDate.HeaderText = "Дата поставки";
            this.SuppliesDate.Name = "SuppliesDate";
            this.SuppliesDate.ReadOnly = true;
            this.SuppliesDate.Width = 120;
            // 
            // msWorker
            // 
            this.msWorker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smUser});
            this.msWorker.Location = new System.Drawing.Point(0, 0);
            this.msWorker.Name = "msWorker";
            this.msWorker.Size = new System.Drawing.Size(748, 24);
            this.msWorker.TabIndex = 2;
            this.msWorker.Text = "menuStrip1";
            // 
            // smUser
            // 
            this.smUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshTables});
            this.smUser.Name = "smUser";
            this.smUser.Size = new System.Drawing.Size(96, 20);
            this.smUser.Text = "Доп. функции";
            // 
            // RefreshTables
            // 
            this.RefreshTables.Name = "RefreshTables";
            this.RefreshTables.Size = new System.Drawing.Size(179, 22);
            this.RefreshTables.Text = "Обновить таблицы";
            this.RefreshTables.Click += new System.EventHandler(this.RefreshTables_Click);
            // 
            // lbSessionName
            // 
            this.lbSessionName.AutoSize = true;
            this.lbSessionName.Location = new System.Drawing.Point(460, 9);
            this.lbSessionName.Name = "lbSessionName";
            this.lbSessionName.Size = new System.Drawing.Size(16, 13);
            this.lbSessionName.TabIndex = 5;
            this.lbSessionName.Text = "---";
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 436);
            this.Controls.Add(this.lbSessionName);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.msWorker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msWorker;
            this.MaximizeBox = false;
            this.Name = "WorkerForm";
            this.Text = "Раздел работника";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            this.tabAdmin.ResumeLayout(false);
            this.tabDealTable.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DealsTable)).EndInit();
            this.tabSupplyTable.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SuppliesTable)).EndInit();
            this.msWorker.ResumeLayout(false);
            this.msWorker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabDealTable;
        private System.Windows.Forms.Button AddDealButton;
        private System.Windows.Forms.Button RefreshDealTableButton;
        private System.Windows.Forms.DataGridView DealsTable;
        private System.Windows.Forms.TabPage tabSupplyTable;
        private System.Windows.Forms.Button AddSupplyTable;
        private System.Windows.Forms.DataGridView SuppliesTable;
        private System.Windows.Forms.MenuStrip msWorker;
        private System.Windows.Forms.ToolStripMenuItem smUser;
        private System.Windows.Forms.ToolStripMenuItem RefreshTables;
        private System.Windows.Forms.Button RefreshSupplyTableButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSessionName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientCardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyTypeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceWithoutDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceWithDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppliesSupplyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppliesSupplyTypeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppliesDate;
    }
}

