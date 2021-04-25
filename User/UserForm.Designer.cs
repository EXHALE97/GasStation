using System;

namespace User
{
    partial class UserForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAZSTable = new System.Windows.Forms.TabPage();
            this.SessionNameStations = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshStationTable = new System.Windows.Forms.Button();
            this.StationsTable = new System.Windows.Forms.DataGridView();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDealUserTable = new System.Windows.Forms.TabPage();
            this.SessionNameDeal = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RefreshDealTable = new System.Windows.Forms.Button();
            this.DealTable = new System.Windows.Forms.DataGridView();
            this.fueltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabAZSTable.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StationsTable)).BeginInit();
            this.tabDealUserTable.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DealTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAZSTable);
            this.tabControl1.Controls.Add(this.tabDealUserTable);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 389);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAZSTable
            // 
            this.tabAZSTable.Controls.Add(this.SessionNameStations);
            this.tabAZSTable.Controls.Add(this.groupBox2);
            this.tabAZSTable.Controls.Add(this.groupBox1);
            this.tabAZSTable.Controls.Add(this.StationsTable);
            this.tabAZSTable.Location = new System.Drawing.Point(4, 22);
            this.tabAZSTable.Name = "tabAZSTable";
            this.tabAZSTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabAZSTable.Size = new System.Drawing.Size(644, 363);
            this.tabAZSTable.TabIndex = 0;
            this.tabAZSTable.Text = "Список всех АЗС";
            this.tabAZSTable.UseVisualStyleBackColor = true;
            // 
            // SessionNameStations
            // 
            this.SessionNameStations.AutoSize = true;
            this.SessionNameStations.Location = new System.Drawing.Point(6, 6);
            this.SessionNameStations.Name = "SessionNameStations";
            this.SessionNameStations.Size = new System.Drawing.Size(16, 13);
            this.SessionNameStations.TabIndex = 9;
            this.SessionNameStations.Text = "---";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CityComboBox);
            this.groupBox2.Controls.Add(this.CityLabel);
            this.groupBox2.Location = new System.Drawing.Point(458, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 63);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтры";
            // 
            // CityComboBox
            // 
            this.CityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(53, 19);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(121, 21);
            this.CityComboBox.TabIndex = 6;
            this.CityComboBox.SelectedIndexChanged += new System.EventHandler(this.CityComboBox_SelectedIndexChanged);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(6, 22);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(40, 13);
            this.CityLabel.TabIndex = 5;
            this.CityLabel.Text = "Город:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RefreshStationTable);
            this.groupBox1.Location = new System.Drawing.Point(458, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 92);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функционал";
            // 
            // RefreshStationTable
            // 
            this.RefreshStationTable.Location = new System.Drawing.Point(9, 19);
            this.RefreshStationTable.Name = "RefreshStationTable";
            this.RefreshStationTable.Size = new System.Drawing.Size(165, 58);
            this.RefreshStationTable.TabIndex = 1;
            this.RefreshStationTable.Text = "Обновить таблицу станций";
            this.RefreshStationTable.UseVisualStyleBackColor = true;
            this.RefreshStationTable.Click += new System.EventHandler(this.RefreshStationTable_Click);
            // 
            // StationsTable
            // 
            this.StationsTable.AllowUserToAddRows = false;
            this.StationsTable.AllowUserToDeleteRows = false;
            this.StationsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StationsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationName,
            this.StationCity,
            this.StationAddress});
            this.StationsTable.Location = new System.Drawing.Point(3, 22);
            this.StationsTable.Name = "StationsTable";
            this.StationsTable.Size = new System.Drawing.Size(446, 338);
            this.StationsTable.TabIndex = 0;
            // 
            // StationName
            // 
            this.StationName.HeaderText = "Название";
            this.StationName.Name = "StationName";
            // 
            // StationCity
            // 
            this.StationCity.HeaderText = "Город";
            this.StationCity.Name = "StationCity";
            this.StationCity.ReadOnly = true;
            // 
            // StationAddress
            // 
            this.StationAddress.HeaderText = "Адрес";
            this.StationAddress.Name = "StationAddress";
            this.StationAddress.ReadOnly = true;
            this.StationAddress.Width = 200;
            // 
            // tabDealUserTable
            // 
            this.tabDealUserTable.Controls.Add(this.SessionNameDeal);
            this.tabDealUserTable.Controls.Add(this.groupBox3);
            this.tabDealUserTable.Controls.Add(this.DealTable);
            this.tabDealUserTable.Location = new System.Drawing.Point(4, 22);
            this.tabDealUserTable.Name = "tabDealUserTable";
            this.tabDealUserTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabDealUserTable.Size = new System.Drawing.Size(644, 363);
            this.tabDealUserTable.TabIndex = 1;
            this.tabDealUserTable.Text = "Журнал сделок";
            this.tabDealUserTable.UseVisualStyleBackColor = true;
            // 
            // SessionNameDeal
            // 
            this.SessionNameDeal.AutoSize = true;
            this.SessionNameDeal.Location = new System.Drawing.Point(6, 6);
            this.SessionNameDeal.Name = "SessionNameDeal";
            this.SessionNameDeal.Size = new System.Drawing.Size(16, 13);
            this.SessionNameDeal.TabIndex = 10;
            this.SessionNameDeal.Text = "---";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RefreshDealTable);
            this.groupBox3.Location = new System.Drawing.Point(515, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 86);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Функционал";
            // 
            // RefreshDealTable
            // 
            this.RefreshDealTable.Location = new System.Drawing.Point(6, 26);
            this.RefreshDealTable.Name = "RefreshDealTable";
            this.RefreshDealTable.Size = new System.Drawing.Size(112, 54);
            this.RefreshDealTable.TabIndex = 0;
            this.RefreshDealTable.Text = "Обновить таблицу своих сделок";
            this.RefreshDealTable.UseVisualStyleBackColor = true;
            this.RefreshDealTable.Click += new System.EventHandler(this.RefreshDealTable_Click);
            // 
            // DealTable
            // 
            this.DealTable.AllowUserToAddRows = false;
            this.DealTable.AllowUserToDeleteRows = false;
            this.DealTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DealTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fueltype,
            this.fuelamount,
            this.dealprice,
            this.dealdate});
            this.DealTable.Location = new System.Drawing.Point(6, 22);
            this.DealTable.Name = "DealTable";
            this.DealTable.Size = new System.Drawing.Size(503, 335);
            this.DealTable.TabIndex = 0;
            // 
            // fueltype
            // 
            this.fueltype.HeaderText = "Тип товара";
            this.fueltype.Name = "fueltype";
            this.fueltype.ReadOnly = true;
            this.fueltype.Width = 150;
            // 
            // fuelamount
            // 
            this.fuelamount.HeaderText = "Количество товара";
            this.fuelamount.Name = "fuelamount";
            this.fuelamount.ReadOnly = true;
            this.fuelamount.Width = 80;
            // 
            // dealprice
            // 
            this.dealprice.HeaderText = "Сумма сделки";
            this.dealprice.Name = "dealprice";
            this.dealprice.ReadOnly = true;
            this.dealprice.Width = 80;
            // 
            // dealdate
            // 
            this.dealdate.HeaderText = "Дата сделки";
            this.dealdate.Name = "dealdate";
            this.dealdate.ReadOnly = true;
            this.dealdate.Width = 150;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 413);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "Раздел пользователя";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAZSTable.ResumeLayout(false);
            this.tabAZSTable.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StationsTable)).EndInit();
            this.tabDealUserTable.ResumeLayout(false);
            this.tabDealUserTable.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DealTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAZSTable;
        private System.Windows.Forms.TabPage tabDealUserTable;
        private System.Windows.Forms.DataGridView StationsTable;
        private System.Windows.Forms.Button RefreshStationTable;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.DataGridView DealTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RefreshDealTable;
        private System.Windows.Forms.Label SessionNameStations;
        private System.Windows.Forms.Label SessionNameDeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn fueltype;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealdate;
        private System.Windows.Forms.ComboBox CityComboBox;
    }
}

