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
            this.btnTableView = new System.Windows.Forms.Button();
            this.btnAddDeal = new System.Windows.Forms.Button();
            this.dgvVievDeal = new System.Windows.Forms.DataGridView();
            this.fueltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSupplyTable = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSupplyUpdate = new System.Windows.Forms.Button();
            this.btnAddSupply = new System.Windows.Forms.Button();
            this.dgvViewSupply = new System.Windows.Forms.DataGridView();
            this.msWorker = new System.Windows.Forms.MenuStrip();
            this.smUser = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshTables = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSessionName = new System.Windows.Forms.Label();
            this.supplystaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelsupplytype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelsupplyamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelsupplydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAdmin.SuspendLayout();
            this.tabDealTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVievDeal)).BeginInit();
            this.tabSupplyTable.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSupply)).BeginInit();
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
            this.tabDealTable.Controls.Add(this.dgvVievDeal);
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
            this.groupBox1.Controls.Add(this.btnTableView);
            this.groupBox1.Controls.Add(this.btnAddDeal);
            this.groupBox1.Location = new System.Drawing.Point(553, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 153);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функционал";
            // 
            // btnTableView
            // 
            this.btnTableView.Location = new System.Drawing.Point(6, 19);
            this.btnTableView.Name = "btnTableView";
            this.btnTableView.Size = new System.Drawing.Size(145, 60);
            this.btnTableView.TabIndex = 1;
            this.btnTableView.Text = "Обновить таблицу сделок";
            this.btnTableView.UseVisualStyleBackColor = true;
            // 
            // btnAddDeal
            // 
            this.btnAddDeal.Location = new System.Drawing.Point(6, 85);
            this.btnAddDeal.Name = "btnAddDeal";
            this.btnAddDeal.Size = new System.Drawing.Size(145, 60);
            this.btnAddDeal.TabIndex = 3;
            this.btnAddDeal.Text = "Оформить сделку";
            this.btnAddDeal.UseVisualStyleBackColor = true;
            this.btnAddDeal.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvVievDeal
            // 
            this.dgvVievDeal.AllowUserToAddRows = false;
            this.dgvVievDeal.AllowUserToDeleteRows = false;
            this.dgvVievDeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVievDeal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fueltype,
            this.fuelamount,
            this.dealprice,
            this.cardnum,
            this.dealdate});
            this.dgvVievDeal.Location = new System.Drawing.Point(3, 4);
            this.dgvVievDeal.Name = "dgvVievDeal";
            this.dgvVievDeal.Size = new System.Drawing.Size(544, 366);
            this.dgvVievDeal.TabIndex = 0;
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
            this.dealprice.HeaderText = "Сумма сделки";
            this.dealprice.Name = "dealprice";
            this.dealprice.Width = 50;
            // 
            // cardnum
            // 
            this.cardnum.HeaderText = "Покупатель";
            this.cardnum.Name = "cardnum";
            // 
            // dealdate
            // 
            this.dealdate.HeaderText = "Дата сделки";
            this.dealdate.Name = "dealdate";
            this.dealdate.Width = 150;
            // 
            // tabSupplyTable
            // 
            this.tabSupplyTable.Controls.Add(this.groupBox2);
            this.tabSupplyTable.Controls.Add(this.dgvViewSupply);
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
            this.groupBox2.Controls.Add(this.btnSupplyUpdate);
            this.groupBox2.Controls.Add(this.btnAddSupply);
            this.groupBox2.Location = new System.Drawing.Point(492, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 149);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Функционал";
            // 
            // btnSupplyUpdate
            // 
            this.btnSupplyUpdate.Location = new System.Drawing.Point(6, 19);
            this.btnSupplyUpdate.Name = "btnSupplyUpdate";
            this.btnSupplyUpdate.Size = new System.Drawing.Size(206, 60);
            this.btnSupplyUpdate.TabIndex = 2;
            this.btnSupplyUpdate.Text = "Обновить таблицу подвоза";
            this.btnSupplyUpdate.UseVisualStyleBackColor = true;
            this.btnSupplyUpdate.Click += new System.EventHandler(this.btnSupplyUpdate_Click);
            // 
            // btnAddSupply
            // 
            this.btnAddSupply.Location = new System.Drawing.Point(6, 85);
            this.btnAddSupply.Name = "btnAddSupply";
            this.btnAddSupply.Size = new System.Drawing.Size(206, 60);
            this.btnAddSupply.TabIndex = 1;
            this.btnAddSupply.Text = "Оформить поставку";
            this.btnAddSupply.UseVisualStyleBackColor = true;
            this.btnAddSupply.Click += new System.EventHandler(this.btnAddSupply_Click);
            // 
            // dgvViewSupply
            // 
            this.dgvViewSupply.AllowUserToAddRows = false;
            this.dgvViewSupply.AllowUserToDeleteRows = false;
            this.dgvViewSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewSupply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplystaff,
            this.fuelsupplytype,
            this.fuelsupplyamount,
            this.fuelsupplydate});
            this.dgvViewSupply.Location = new System.Drawing.Point(3, 3);
            this.dgvViewSupply.Name = "dgvViewSupply";
            this.dgvViewSupply.Size = new System.Drawing.Size(483, 366);
            this.dgvViewSupply.TabIndex = 0;
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
            this.RefreshTables.Click += new System.EventHandler(this.RefreshTables_Click_1);
            // 
            // lbSessionName
            // 
            this.lbSessionName.AutoSize = true;
            this.lbSessionName.Location = new System.Drawing.Point(572, 9);
            this.lbSessionName.Name = "lbSessionName";
            this.lbSessionName.Size = new System.Drawing.Size(16, 13);
            this.lbSessionName.TabIndex = 5;
            this.lbSessionName.Text = "---";
            // 
            // supplystaff
            // 
            this.supplystaff.HeaderText = "Сотрудник-оператор";
            this.supplystaff.Name = "supplystaff";
            this.supplystaff.Width = 120;
            // 
            // fuelsupplytype
            // 
            this.fuelsupplytype.HeaderText = "Тип топлива";
            this.fuelsupplytype.Name = "fuelsupplytype";
            // 
            // fuelsupplyamount
            // 
            this.fuelsupplyamount.HeaderText = "Количество топлива";
            this.fuelsupplyamount.Name = "fuelsupplyamount";
            // 
            // fuelsupplydate
            // 
            this.fuelsupplydate.HeaderText = "Дата подвоза";
            this.fuelsupplydate.Name = "fuelsupplydate";
            this.fuelsupplydate.Width = 120;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvVievDeal)).EndInit();
            this.tabSupplyTable.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSupply)).EndInit();
            this.msWorker.ResumeLayout(false);
            this.msWorker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabDealTable;
        private System.Windows.Forms.Button btnAddDeal;
        private System.Windows.Forms.Button btnTableView;
        private System.Windows.Forms.DataGridView dgvVievDeal;
        private System.Windows.Forms.TabPage tabSupplyTable;
        private System.Windows.Forms.Button btnAddSupply;
        private System.Windows.Forms.DataGridView dgvViewSupply;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn fueltype;
        private System.Windows.Forms.MenuStrip msWorker;
        private System.Windows.Forms.ToolStripMenuItem smUser;
        private System.Windows.Forms.ToolStripMenuItem RefreshTables;
        private System.Windows.Forms.Button btnSupplyUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSessionName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelsupplydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelsupplyamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelsupplytype;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplystaff;
    }
}

