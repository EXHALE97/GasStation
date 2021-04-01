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
            this.lbSessionName1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataTableView = new System.Windows.Forms.Button();
            this.dgvVievAZS = new System.Windows.Forms.DataGridView();
            this.orgname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDealUserTable = new System.Windows.Forms.TabPage();
            this.lbSessionName2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowUserDeal = new System.Windows.Forms.Button();
            this.dgvUserDeals = new System.Windows.Forms.DataGridView();
            this.fueltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabAZSTable.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVievAZS)).BeginInit();
            this.tabDealUserTable.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDeals)).BeginInit();
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
            this.tabAZSTable.Controls.Add(this.lbSessionName1);
            this.tabAZSTable.Controls.Add(this.groupBox2);
            this.tabAZSTable.Controls.Add(this.groupBox1);
            this.tabAZSTable.Controls.Add(this.dgvVievAZS);
            this.tabAZSTable.Location = new System.Drawing.Point(4, 22);
            this.tabAZSTable.Name = "tabAZSTable";
            this.tabAZSTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabAZSTable.Size = new System.Drawing.Size(644, 363);
            this.tabAZSTable.TabIndex = 0;
            this.tabAZSTable.Text = "Список всех АЗС";
            this.tabAZSTable.UseVisualStyleBackColor = true;
            // 
            // lbSessionName1
            // 
            this.lbSessionName1.AutoSize = true;
            this.lbSessionName1.Location = new System.Drawing.Point(6, 6);
            this.lbSessionName1.Name = "lbSessionName1";
            this.lbSessionName1.Size = new System.Drawing.Size(16, 13);
            this.lbSessionName1.TabIndex = 9;
            this.lbSessionName1.Text = "---";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCity);
            this.groupBox2.Controls.Add(this.tbCountry);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.lbCity);
            this.groupBox2.Controls.Add(this.lbCountry);
            this.groupBox2.Location = new System.Drawing.Point(458, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 103);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтры";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(74, 45);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 3;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(74, 19);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(100, 20);
            this.tbCountry.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(99, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(28, 48);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(40, 13);
            this.lbCity.TabIndex = 6;
            this.lbCity.Text = "Город:";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(25, 22);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(46, 13);
            this.lbCountry.TabIndex = 5;
            this.lbCountry.Text = "Страна:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataTableView);
            this.groupBox1.Location = new System.Drawing.Point(458, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 92);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функционал";
            // 
            // dataTableView
            // 
            this.dataTableView.Location = new System.Drawing.Point(9, 19);
            this.dataTableView.Name = "dataTableView";
            this.dataTableView.Size = new System.Drawing.Size(165, 58);
            this.dataTableView.TabIndex = 1;
            this.dataTableView.Text = "Обновить таблицу станций";
            this.dataTableView.UseVisualStyleBackColor = true;
            this.dataTableView.Click += new System.EventHandler(this.dataView1_Click);
            // 
            // dgvVievAZS
            // 
            this.dgvVievAZS.AllowUserToAddRows = false;
            this.dgvVievAZS.AllowUserToDeleteRows = false;
            this.dgvVievAZS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVievAZS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orgname,
            this.country,
            this.city,
            this.street});
            this.dgvVievAZS.Location = new System.Drawing.Point(3, 22);
            this.dgvVievAZS.Name = "dgvVievAZS";
            this.dgvVievAZS.Size = new System.Drawing.Size(446, 338);
            this.dgvVievAZS.TabIndex = 0;
            // 
            // orgname
            // 
            this.orgname.HeaderText = "Организация";
            this.orgname.Name = "orgname";
            // 
            // country
            // 
            this.country.HeaderText = "Страна";
            this.country.Name = "country";
            // 
            // city
            // 
            this.city.HeaderText = "Город";
            this.city.Name = "city";
            // 
            // street
            // 
            this.street.HeaderText = "Улица";
            this.street.Name = "street";
            // 
            // tabDealUserTable
            // 
            this.tabDealUserTable.Controls.Add(this.lbSessionName2);
            this.tabDealUserTable.Controls.Add(this.groupBox3);
            this.tabDealUserTable.Controls.Add(this.dgvUserDeals);
            this.tabDealUserTable.Location = new System.Drawing.Point(4, 22);
            this.tabDealUserTable.Name = "tabDealUserTable";
            this.tabDealUserTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabDealUserTable.Size = new System.Drawing.Size(644, 363);
            this.tabDealUserTable.TabIndex = 1;
            this.tabDealUserTable.Text = "Журнал сделок";
            this.tabDealUserTable.UseVisualStyleBackColor = true;
            // 
            // lbSessionName2
            // 
            this.lbSessionName2.AutoSize = true;
            this.lbSessionName2.Location = new System.Drawing.Point(6, 6);
            this.lbSessionName2.Name = "lbSessionName2";
            this.lbSessionName2.Size = new System.Drawing.Size(16, 13);
            this.lbSessionName2.TabIndex = 10;
            this.lbSessionName2.Text = "---";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowUserDeal);
            this.groupBox3.Location = new System.Drawing.Point(515, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 86);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Функционал";
            // 
            // btnShowUserDeal
            // 
            this.btnShowUserDeal.Location = new System.Drawing.Point(6, 26);
            this.btnShowUserDeal.Name = "btnShowUserDeal";
            this.btnShowUserDeal.Size = new System.Drawing.Size(112, 54);
            this.btnShowUserDeal.TabIndex = 0;
            this.btnShowUserDeal.Text = "Обновить таблицу своих сделок";
            this.btnShowUserDeal.UseVisualStyleBackColor = true;
            this.btnShowUserDeal.Click += new System.EventHandler(this.btnShowUserDeal_Click);
            // 
            // dgvUserDeals
            // 
            this.dgvUserDeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserDeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fueltype,
            this.fuelamount,
            this.dealprice,
            this.dealdate});
            this.dgvUserDeals.Location = new System.Drawing.Point(6, 22);
            this.dgvUserDeals.Name = "dgvUserDeals";
            this.dgvUserDeals.Size = new System.Drawing.Size(503, 335);
            this.dgvUserDeals.TabIndex = 0;
            // 
            // fueltype
            // 
            this.fueltype.HeaderText = "Тип топлива";
            this.fueltype.Name = "fueltype";
            this.fueltype.Width = 150;
            // 
            // fuelamount
            // 
            this.fuelamount.HeaderText = "Количество топлива";
            this.fuelamount.Name = "fuelamount";
            this.fuelamount.Width = 80;
            // 
            // dealprice
            // 
            this.dealprice.HeaderText = "Сумма сделки";
            this.dealprice.Name = "dealprice";
            this.dealprice.Width = 80;
            // 
            // dealdate
            // 
            this.dealdate.HeaderText = "Дата сделки";
            this.dealdate.Name = "dealdate";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvVievAZS)).EndInit();
            this.tabDealUserTable.ResumeLayout(false);
            this.tabDealUserTable.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDeals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAZSTable;
        private System.Windows.Forms.TabPage tabDealUserTable;
        private System.Windows.Forms.DataGridView dgvVievAZS;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgname;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.Button dataTableView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.DataGridView dgvUserDeals;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnShowUserDeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn fueltype;
        private System.Windows.Forms.Label lbSessionName1;
        private System.Windows.Forms.Label lbSessionName2;
    }
}

