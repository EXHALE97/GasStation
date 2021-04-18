using System.Windows.Forms;

namespace Admin
{
    partial class AdminForm
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
            this.WarehouseTableTab = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.WhFilterByStation = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.RefreshWarehouseInfoButton = new System.Windows.Forms.Button();
            this.WarehouseTable = new System.Windows.Forms.DataGridView();
            this.WarehouseStationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseStationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseSupplyTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseSupplyTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseSupplyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientTableTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UpdateClientTableButton = new System.Windows.Forms.Button();
            this.ActivateClientCardButton = new System.Windows.Forms.Button();
            this.FindDealsByClientButton = new System.Windows.Forms.Button();
            this.AddNewClientButton = new System.Windows.Forms.Button();
            this.ClientTable = new System.Windows.Forms.DataGridView();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CredId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTableTab = new System.Windows.Forms.TabPage();
            this.OnlyWorkingEmployeeCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddNewEmployee = new System.Windows.Forms.Button();
            this.RefreshEmployeeTable = new System.Windows.Forms.Button();
            this.GiveAdminAccessButton = new System.Windows.Forms.Button();
            this.UpdateEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.EmployeeTable = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeConnectedCreds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmploymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeContractEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeIsWorking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.StationTableTab = new System.Windows.Forms.TabPage();
            this.OnlyWorkingStationsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CloseStationButton = new System.Windows.Forms.Button();
            this.UpdateStationInfoButton = new System.Windows.Forms.Button();
            this.RefreshStationTableButton = new System.Windows.Forms.Button();
            this.AddNewStationButton = new System.Windows.Forms.Button();
            this.StationsTable = new System.Windows.Forms.DataGridView();
            this.StationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsStationWorking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealTableTab = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DealFilterByStation = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DealTableRefreshButton = new System.Windows.Forms.Button();
            this.DealUpdateButton = new System.Windows.Forms.Button();
            this.DealTable = new System.Windows.Forms.DataGridView();
            this.DealId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientCardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyTypeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealFinalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceWithoutDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyTableTab = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.SupplyFilterByStation = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.RefreshSupplyTableButton = new System.Windows.Forms.Button();
            this.SuppliesTable = new System.Windows.Forms.DataGridView();
            this.SupplyStationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyStationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSupplyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelSupplyAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTableTab = new System.Windows.Forms.TabPage();
            this.ProductTableFunc = new System.Windows.Forms.GroupBox();
            this.DeleteSupplyTypeButton = new System.Windows.Forms.Button();
            this.UpdateSupplyTypeButton = new System.Windows.Forms.Button();
            this.RefreshSupplyTypeTableButton = new System.Windows.Forms.Button();
            this.SupplyTypeTable = new System.Windows.Forms.DataGridView();
            this.SupplyTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyTypePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSupplyTypeSelling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.допФункцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshTables = new System.Windows.Forms.ToolStripMenuItem();
            this.dbQueryManager = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSessionName = new System.Windows.Forms.Label();
            this.WarehouseTableTab.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseTable)).BeginInit();
            this.ClientTableTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientTable)).BeginInit();
            this.EmployeeTableTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).BeginInit();
            this.tabAdmin.SuspendLayout();
            this.StationTableTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StationsTable)).BeginInit();
            this.DealTableTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DealTable)).BeginInit();
            this.SupplyTableTab.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliesTable)).BeginInit();
            this.ProductTableTab.SuspendLayout();
            this.ProductTableFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyTypeTable)).BeginInit();
            this.msAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // WarehouseTableTab
            // 
            this.WarehouseTableTab.Controls.Add(this.groupBox7);
            this.WarehouseTableTab.Controls.Add(this.groupBox6);
            this.WarehouseTableTab.Controls.Add(this.WarehouseTable);
            this.WarehouseTableTab.Location = new System.Drawing.Point(4, 22);
            this.WarehouseTableTab.Name = "WarehouseTableTab";
            this.WarehouseTableTab.Size = new System.Drawing.Size(820, 462);
            this.WarehouseTableTab.TabIndex = 2;
            this.WarehouseTableTab.Text = "Склад";
            this.WarehouseTableTab.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.WhFilterByStation);
            this.groupBox7.Location = new System.Drawing.Point(604, 416);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(212, 43);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Фильтр по станции";
            // 
            // WhFilterByStation
            // 
            this.WhFilterByStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WhFilterByStation.FormattingEnabled = true;
            this.WhFilterByStation.Location = new System.Drawing.Point(6, 16);
            this.WhFilterByStation.Name = "WhFilterByStation";
            this.WhFilterByStation.Size = new System.Drawing.Size(200, 21);
            this.WhFilterByStation.TabIndex = 0;
            this.WhFilterByStation.SelectedIndexChanged += new System.EventHandler(this.WhFilterByStation_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.RefreshWarehouseInfoButton);
            this.groupBox6.Location = new System.Drawing.Point(604, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(212, 89);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Функционал";
            // 
            // RefreshWarehouseInfoButton
            // 
            this.RefreshWarehouseInfoButton.Location = new System.Drawing.Point(6, 19);
            this.RefreshWarehouseInfoButton.Name = "RefreshWarehouseInfoButton";
            this.RefreshWarehouseInfoButton.Size = new System.Drawing.Size(200, 60);
            this.RefreshWarehouseInfoButton.TabIndex = 4;
            this.RefreshWarehouseInfoButton.Text = "Обновить";
            this.RefreshWarehouseInfoButton.UseVisualStyleBackColor = true;
            this.RefreshWarehouseInfoButton.Click += new System.EventHandler(this.RefreshWarehouseInfoButton_Click);
            // 
            // WarehouseTable
            // 
            this.WarehouseTable.AllowUserToAddRows = false;
            this.WarehouseTable.AllowUserToDeleteRows = false;
            this.WarehouseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehouseTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WarehouseStationId,
            this.WarehouseStationName,
            this.WarehouseSupplyTypeId,
            this.WarehouseSupplyTypeName,
            this.WarehouseSupplyCount});
            this.WarehouseTable.Location = new System.Drawing.Point(9, 3);
            this.WarehouseTable.Name = "WarehouseTable";
            this.WarehouseTable.Size = new System.Drawing.Size(589, 459);
            this.WarehouseTable.TabIndex = 2;
            // 
            // WarehouseStationId
            // 
            this.WarehouseStationId.HeaderText = "ID станции";
            this.WarehouseStationId.Name = "WarehouseStationId";
            this.WarehouseStationId.Width = 60;
            // 
            // WarehouseStationName
            // 
            this.WarehouseStationName.HeaderText = "Наименование станции";
            this.WarehouseStationName.Name = "WarehouseStationName";
            this.WarehouseStationName.ReadOnly = true;
            this.WarehouseStationName.Width = 155;
            // 
            // WarehouseSupplyTypeId
            // 
            this.WarehouseSupplyTypeId.HeaderText = "ID товара";
            this.WarehouseSupplyTypeId.Name = "WarehouseSupplyTypeId";
            this.WarehouseSupplyTypeId.ReadOnly = true;
            this.WarehouseSupplyTypeId.Width = 60;
            // 
            // WarehouseSupplyTypeName
            // 
            this.WarehouseSupplyTypeName.HeaderText = "Наименование товара";
            this.WarehouseSupplyTypeName.Name = "WarehouseSupplyTypeName";
            this.WarehouseSupplyTypeName.ReadOnly = true;
            this.WarehouseSupplyTypeName.Width = 150;
            // 
            // WarehouseSupplyCount
            // 
            this.WarehouseSupplyCount.HeaderText = "Количество товара";
            this.WarehouseSupplyCount.Name = "WarehouseSupplyCount";
            this.WarehouseSupplyCount.ReadOnly = true;
            this.WarehouseSupplyCount.Width = 120;
            // 
            // ClientTableTab
            // 
            this.ClientTableTab.Controls.Add(this.groupBox3);
            this.ClientTableTab.Controls.Add(this.ClientTable);
            this.ClientTableTab.Location = new System.Drawing.Point(4, 22);
            this.ClientTableTab.Name = "ClientTableTab";
            this.ClientTableTab.Padding = new System.Windows.Forms.Padding(3);
            this.ClientTableTab.Size = new System.Drawing.Size(820, 462);
            this.ClientTableTab.TabIndex = 1;
            this.ClientTableTab.Text = "Список покупателей";
            this.ClientTableTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UpdateClientTableButton);
            this.groupBox3.Controls.Add(this.ActivateClientCardButton);
            this.groupBox3.Controls.Add(this.FindDealsByClientButton);
            this.groupBox3.Controls.Add(this.AddNewClientButton);
            this.groupBox3.Location = new System.Drawing.Point(505, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 290);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Функционал";
            // 
            // UpdateClientTableButton
            // 
            this.UpdateClientTableButton.Location = new System.Drawing.Point(62, 19);
            this.UpdateClientTableButton.Name = "UpdateClientTableButton";
            this.UpdateClientTableButton.Size = new System.Drawing.Size(190, 60);
            this.UpdateClientTableButton.TabIndex = 5;
            this.UpdateClientTableButton.Text = "Обновить список покупателей";
            this.UpdateClientTableButton.UseVisualStyleBackColor = true;
            this.UpdateClientTableButton.Click += new System.EventHandler(this.UpdateClientTableButton_Click);
            // 
            // ActivateClientCardButton
            // 
            this.ActivateClientCardButton.Location = new System.Drawing.Point(62, 217);
            this.ActivateClientCardButton.Name = "ActivateClientCardButton";
            this.ActivateClientCardButton.Size = new System.Drawing.Size(190, 60);
            this.ActivateClientCardButton.TabIndex = 4;
            this.ActivateClientCardButton.Text = "Активировать карту покупателя";
            this.ActivateClientCardButton.UseVisualStyleBackColor = true;
            this.ActivateClientCardButton.Click += new System.EventHandler(this.ActivateClientCardButton_Click);
            // 
            // FindDealsByClientButton
            // 
            this.FindDealsByClientButton.Location = new System.Drawing.Point(62, 85);
            this.FindDealsByClientButton.Name = "FindDealsByClientButton";
            this.FindDealsByClientButton.Size = new System.Drawing.Size(190, 60);
            this.FindDealsByClientButton.TabIndex = 2;
            this.FindDealsByClientButton.Text = "Обзор сделок с выбранным покупателем";
            this.FindDealsByClientButton.UseVisualStyleBackColor = true;
            this.FindDealsByClientButton.Click += new System.EventHandler(this.FindDealsByClientButton_Click);
            // 
            // AddNewClientButton
            // 
            this.AddNewClientButton.Location = new System.Drawing.Point(62, 151);
            this.AddNewClientButton.Name = "AddNewClientButton";
            this.AddNewClientButton.Size = new System.Drawing.Size(190, 60);
            this.AddNewClientButton.TabIndex = 3;
            this.AddNewClientButton.Text = "Добавить нового покупателя";
            this.AddNewClientButton.UseVisualStyleBackColor = true;
            this.AddNewClientButton.Click += new System.EventHandler(this.AddNewClientButton_Click);
            // 
            // ClientTable
            // 
            this.ClientTable.AllowUserToAddRows = false;
            this.ClientTable.AllowUserToDeleteRows = false;
            this.ClientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.ClientFirstName,
            this.ClientLastName,
            this.ClientMiddleName,
            this.CardId,
            this.DiscountPercent,
            this.ActivationDate,
            this.CredId});
            this.ClientTable.Location = new System.Drawing.Point(6, 3);
            this.ClientTable.Name = "ClientTable";
            this.ClientTable.Size = new System.Drawing.Size(493, 459);
            this.ClientTable.TabIndex = 1;
            // 
            // ClientId
            // 
            this.ClientId.HeaderText = "ID";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            this.ClientId.Width = 50;
            // 
            // ClientFirstName
            // 
            this.ClientFirstName.HeaderText = "Имя";
            this.ClientFirstName.Name = "ClientFirstName";
            this.ClientFirstName.ReadOnly = true;
            // 
            // ClientLastName
            // 
            this.ClientLastName.HeaderText = "Фамилия";
            this.ClientLastName.Name = "ClientLastName";
            this.ClientLastName.ReadOnly = true;
            // 
            // ClientMiddleName
            // 
            this.ClientMiddleName.HeaderText = "Отчество";
            this.ClientMiddleName.Name = "ClientMiddleName";
            this.ClientMiddleName.ReadOnly = true;
            // 
            // CardId
            // 
            this.CardId.HeaderText = "Карта клиента";
            this.CardId.Name = "CardId";
            this.CardId.ReadOnly = true;
            // 
            // DiscountPercent
            // 
            this.DiscountPercent.HeaderText = "Скидка";
            this.DiscountPercent.Name = "DiscountPercent";
            this.DiscountPercent.ReadOnly = true;
            // 
            // ActivationDate
            // 
            this.ActivationDate.HeaderText = "Дата активации";
            this.ActivationDate.Name = "ActivationDate";
            this.ActivationDate.ReadOnly = true;
            // 
            // CredId
            // 
            this.CredId.HeaderText = "Креды";
            this.CredId.Name = "CredId";
            this.CredId.ReadOnly = true;
            // 
            // EmployeeTableTab
            // 
            this.EmployeeTableTab.Controls.Add(this.OnlyWorkingEmployeeCheckBox);
            this.EmployeeTableTab.Controls.Add(this.groupBox2);
            this.EmployeeTableTab.Controls.Add(this.EmployeeTable);
            this.EmployeeTableTab.Location = new System.Drawing.Point(4, 22);
            this.EmployeeTableTab.Name = "EmployeeTableTab";
            this.EmployeeTableTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTableTab.Size = new System.Drawing.Size(820, 462);
            this.EmployeeTableTab.TabIndex = 0;
            this.EmployeeTableTab.Text = "Список сотрудников";
            this.EmployeeTableTab.UseVisualStyleBackColor = true;
            // 
            // OnlyWorkingEmployeeCheckBox
            // 
            this.OnlyWorkingEmployeeCheckBox.AutoSize = true;
            this.OnlyWorkingEmployeeCheckBox.Location = new System.Drawing.Point(584, 423);
            this.OnlyWorkingEmployeeCheckBox.Name = "OnlyWorkingEmployeeCheckBox";
            this.OnlyWorkingEmployeeCheckBox.Size = new System.Drawing.Size(191, 17);
            this.OnlyWorkingEmployeeCheckBox.TabIndex = 6;
            this.OnlyWorkingEmployeeCheckBox.Text = "Только работающие сотрудники";
            this.OnlyWorkingEmployeeCheckBox.UseVisualStyleBackColor = true;
            this.OnlyWorkingEmployeeCheckBox.CheckedChanged += new System.EventHandler(this.OnlyWorkingEmployeeCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddNewEmployee);
            this.groupBox2.Controls.Add(this.RefreshEmployeeTable);
            this.groupBox2.Controls.Add(this.GiveAdminAccessButton);
            this.groupBox2.Controls.Add(this.UpdateEmployeeButton);
            this.groupBox2.Controls.Add(this.DeleteEmployeeButton);
            this.groupBox2.Location = new System.Drawing.Point(536, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 358);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Функционал";
            // 
            // AddNewEmployee
            // 
            this.AddNewEmployee.Location = new System.Drawing.Point(48, 88);
            this.AddNewEmployee.Name = "AddNewEmployee";
            this.AddNewEmployee.Size = new System.Drawing.Size(190, 60);
            this.AddNewEmployee.TabIndex = 3;
            this.AddNewEmployee.Text = "Добавить нового сотрудника";
            this.AddNewEmployee.UseVisualStyleBackColor = true;
            this.AddNewEmployee.Click += new System.EventHandler(this.AddNewEmployee_Click);
            // 
            // RefreshEmployeeTable
            // 
            this.RefreshEmployeeTable.Location = new System.Drawing.Point(48, 19);
            this.RefreshEmployeeTable.Name = "RefreshEmployeeTable";
            this.RefreshEmployeeTable.Size = new System.Drawing.Size(190, 60);
            this.RefreshEmployeeTable.TabIndex = 1;
            this.RefreshEmployeeTable.Text = "Обновить список персонала";
            this.RefreshEmployeeTable.UseVisualStyleBackColor = true;
            this.RefreshEmployeeTable.Click += new System.EventHandler(this.RefreshEmployeeTable_Click);
            // 
            // GiveAdminAccessButton
            // 
            this.GiveAdminAccessButton.Location = new System.Drawing.Point(48, 286);
            this.GiveAdminAccessButton.Name = "GiveAdminAccessButton";
            this.GiveAdminAccessButton.Size = new System.Drawing.Size(190, 60);
            this.GiveAdminAccessButton.TabIndex = 4;
            this.GiveAdminAccessButton.Text = "Дать выбранному сотруднику права доступа к системе учета";
            this.GiveAdminAccessButton.UseVisualStyleBackColor = true;
            this.GiveAdminAccessButton.Click += new System.EventHandler(this.GiveAdminAccessButton_Click);
            // 
            // UpdateEmployeeButton
            // 
            this.UpdateEmployeeButton.Location = new System.Drawing.Point(48, 154);
            this.UpdateEmployeeButton.Name = "UpdateEmployeeButton";
            this.UpdateEmployeeButton.Size = new System.Drawing.Size(190, 60);
            this.UpdateEmployeeButton.TabIndex = 2;
            this.UpdateEmployeeButton.Text = "Править личные данные сотрудника";
            this.UpdateEmployeeButton.UseVisualStyleBackColor = true;
            this.UpdateEmployeeButton.Click += new System.EventHandler(this.UpdateEmployeeButton_Click);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(48, 220);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(190, 60);
            this.DeleteEmployeeButton.TabIndex = 3;
            this.DeleteEmployeeButton.Text = " Уволить выбранного сотрудника";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // EmployeeTable
            // 
            this.EmployeeTable.AllowUserToAddRows = false;
            this.EmployeeTable.AllowUserToDeleteRows = false;
            this.EmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.EmployeeConnectedCreds,
            this.EmployeeSurname,
            this.EmployeeName,
            this.EmployeeMiddleName,
            this.EmployeeBirthday,
            this.EmploymentDate,
            this.EmployeeContractEnd,
            this.EmployeePosition,
            this.EmployeeSalary,
            this.EmployeeAddress,
            this.EmployeePhone,
            this.EmployeeIsWorking});
            this.EmployeeTable.Location = new System.Drawing.Point(0, 3);
            this.EmployeeTable.Name = "EmployeeTable";
            this.EmployeeTable.Size = new System.Drawing.Size(530, 459);
            this.EmployeeTable.TabIndex = 0;
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "ID";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Width = 40;
            // 
            // EmployeeConnectedCreds
            // 
            this.EmployeeConnectedCreds.HeaderText = "Креды";
            this.EmployeeConnectedCreds.Name = "EmployeeConnectedCreds";
            this.EmployeeConnectedCreds.ReadOnly = true;
            // 
            // EmployeeSurname
            // 
            this.EmployeeSurname.HeaderText = "Фамилия";
            this.EmployeeSurname.Name = "EmployeeSurname";
            this.EmployeeSurname.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Имя";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // EmployeeMiddleName
            // 
            this.EmployeeMiddleName.HeaderText = "Отчество";
            this.EmployeeMiddleName.Name = "EmployeeMiddleName";
            this.EmployeeMiddleName.ReadOnly = true;
            // 
            // EmployeeBirthday
            // 
            this.EmployeeBirthday.HeaderText = "Дата рождения";
            this.EmployeeBirthday.Name = "EmployeeBirthday";
            this.EmployeeBirthday.ReadOnly = true;
            // 
            // EmploymentDate
            // 
            this.EmploymentDate.HeaderText = "Дата найма";
            this.EmploymentDate.Name = "EmploymentDate";
            this.EmploymentDate.ReadOnly = true;
            // 
            // EmployeeContractEnd
            // 
            this.EmployeeContractEnd.HeaderText = "Дата окончания контакта";
            this.EmployeeContractEnd.Name = "EmployeeContractEnd";
            this.EmployeeContractEnd.ReadOnly = true;
            // 
            // EmployeePosition
            // 
            this.EmployeePosition.HeaderText = "Должность";
            this.EmployeePosition.Name = "EmployeePosition";
            this.EmployeePosition.ReadOnly = true;
            // 
            // EmployeeSalary
            // 
            this.EmployeeSalary.HeaderText = "Зарплата";
            this.EmployeeSalary.Name = "EmployeeSalary";
            this.EmployeeSalary.ReadOnly = true;
            this.EmployeeSalary.Width = 80;
            // 
            // EmployeeAddress
            // 
            this.EmployeeAddress.HeaderText = "Адрес";
            this.EmployeeAddress.Name = "EmployeeAddress";
            this.EmployeeAddress.ReadOnly = true;
            // 
            // EmployeePhone
            // 
            this.EmployeePhone.HeaderText = "Телефон";
            this.EmployeePhone.Name = "EmployeePhone";
            this.EmployeePhone.ReadOnly = true;
            // 
            // EmployeeIsWorking
            // 
            this.EmployeeIsWorking.HeaderText = "Работает";
            this.EmployeeIsWorking.Name = "EmployeeIsWorking";
            this.EmployeeIsWorking.ReadOnly = true;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.StationTableTab);
            this.tabAdmin.Controls.Add(this.EmployeeTableTab);
            this.tabAdmin.Controls.Add(this.ClientTableTab);
            this.tabAdmin.Controls.Add(this.DealTableTab);
            this.tabAdmin.Controls.Add(this.SupplyTableTab);
            this.tabAdmin.Controls.Add(this.WarehouseTableTab);
            this.tabAdmin.Controls.Add(this.ProductTableTab);
            this.tabAdmin.Location = new System.Drawing.Point(12, 29);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(828, 488);
            this.tabAdmin.TabIndex = 0;
            // 
            // StationTableTab
            // 
            this.StationTableTab.Controls.Add(this.OnlyWorkingStationsCheckBox);
            this.StationTableTab.Controls.Add(this.groupBox1);
            this.StationTableTab.Controls.Add(this.StationsTable);
            this.StationTableTab.Location = new System.Drawing.Point(4, 22);
            this.StationTableTab.Name = "StationTableTab";
            this.StationTableTab.Padding = new System.Windows.Forms.Padding(3);
            this.StationTableTab.Size = new System.Drawing.Size(820, 462);
            this.StationTableTab.TabIndex = 4;
            this.StationTableTab.Text = "Список станций";
            this.StationTableTab.UseVisualStyleBackColor = true;
            // 
            // OnlyWorkingStationsCheckBox
            // 
            this.OnlyWorkingStationsCheckBox.AutoSize = true;
            this.OnlyWorkingStationsCheckBox.Location = new System.Drawing.Point(592, 430);
            this.OnlyWorkingStationsCheckBox.Name = "OnlyWorkingStationsCheckBox";
            this.OnlyWorkingStationsCheckBox.Size = new System.Drawing.Size(174, 17);
            this.OnlyWorkingStationsCheckBox.TabIndex = 3;
            this.OnlyWorkingStationsCheckBox.Text = "Только работающие станции";
            this.OnlyWorkingStationsCheckBox.UseVisualStyleBackColor = true;
            this.OnlyWorkingStationsCheckBox.CheckedChanged += new System.EventHandler(this.OnlyWorkingStationsCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CloseStationButton);
            this.groupBox1.Controls.Add(this.UpdateStationInfoButton);
            this.groupBox1.Controls.Add(this.RefreshStationTableButton);
            this.groupBox1.Controls.Add(this.AddNewStationButton);
            this.groupBox1.Location = new System.Drawing.Point(554, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 295);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функционал";
            // 
            // CloseStationButton
            // 
            this.CloseStationButton.Location = new System.Drawing.Point(38, 217);
            this.CloseStationButton.Name = "CloseStationButton";
            this.CloseStationButton.Size = new System.Drawing.Size(190, 60);
            this.CloseStationButton.TabIndex = 5;
            this.CloseStationButton.Text = "Закрыть станцию";
            this.CloseStationButton.UseVisualStyleBackColor = true;
            // 
            // UpdateStationInfoButton
            // 
            this.UpdateStationInfoButton.Location = new System.Drawing.Point(38, 151);
            this.UpdateStationInfoButton.Name = "UpdateStationInfoButton";
            this.UpdateStationInfoButton.Size = new System.Drawing.Size(190, 60);
            this.UpdateStationInfoButton.TabIndex = 4;
            this.UpdateStationInfoButton.Text = "Править информацию о станции";
            this.UpdateStationInfoButton.UseVisualStyleBackColor = true;
            this.UpdateStationInfoButton.Click += new System.EventHandler(this.UpdateStationInfoButton_Click);
            // 
            // RefreshStationTableButton
            // 
            this.RefreshStationTableButton.Location = new System.Drawing.Point(38, 19);
            this.RefreshStationTableButton.Name = "RefreshStationTableButton";
            this.RefreshStationTableButton.Size = new System.Drawing.Size(190, 60);
            this.RefreshStationTableButton.TabIndex = 3;
            this.RefreshStationTableButton.Text = "Обновить список станций";
            this.RefreshStationTableButton.UseVisualStyleBackColor = true;
            this.RefreshStationTableButton.Click += new System.EventHandler(this.RefreshStationTableButton_Click);
            // 
            // AddNewStationButton
            // 
            this.AddNewStationButton.Location = new System.Drawing.Point(38, 85);
            this.AddNewStationButton.Name = "AddNewStationButton";
            this.AddNewStationButton.Size = new System.Drawing.Size(190, 60);
            this.AddNewStationButton.TabIndex = 2;
            this.AddNewStationButton.Text = "Добавить новую станцию";
            this.AddNewStationButton.UseVisualStyleBackColor = true;
            this.AddNewStationButton.Click += new System.EventHandler(this.AddNewStationButton_Click);
            // 
            // StationsTable
            // 
            this.StationsTable.AllowUserToAddRows = false;
            this.StationsTable.AllowUserToDeleteRows = false;
            this.StationsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StationsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationId,
            this.StationName,
            this.StationCity,
            this.StationAddress,
            this.IsStationWorking});
            this.StationsTable.Location = new System.Drawing.Point(3, 3);
            this.StationsTable.Name = "StationsTable";
            this.StationsTable.Size = new System.Drawing.Size(545, 456);
            this.StationsTable.TabIndex = 1;
            // 
            // StationId
            // 
            this.StationId.HeaderText = "ID";
            this.StationId.Name = "StationId";
            this.StationId.ReadOnly = true;
            // 
            // StationName
            // 
            this.StationName.HeaderText = "Название";
            this.StationName.Name = "StationName";
            this.StationName.ReadOnly = true;
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
            // 
            // IsStationWorking
            // 
            this.IsStationWorking.HeaderText = "Работает";
            this.IsStationWorking.Name = "IsStationWorking";
            this.IsStationWorking.ReadOnly = true;
            // 
            // DealTableTab
            // 
            this.DealTableTab.Controls.Add(this.groupBox5);
            this.DealTableTab.Controls.Add(this.groupBox4);
            this.DealTableTab.Controls.Add(this.DealTable);
            this.DealTableTab.Location = new System.Drawing.Point(4, 22);
            this.DealTableTab.Name = "DealTableTab";
            this.DealTableTab.Padding = new System.Windows.Forms.Padding(3);
            this.DealTableTab.Size = new System.Drawing.Size(820, 462);
            this.DealTableTab.TabIndex = 3;
            this.DealTableTab.Text = "Список сделок";
            this.DealTableTab.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DealFilterByStation);
            this.groupBox5.Location = new System.Drawing.Point(607, 411);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(210, 48);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Фильтр по станции";
            // 
            // DealFilterByStation
            // 
            this.DealFilterByStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DealFilterByStation.FormattingEnabled = true;
            this.DealFilterByStation.Location = new System.Drawing.Point(8, 21);
            this.DealFilterByStation.Name = "DealFilterByStation";
            this.DealFilterByStation.Size = new System.Drawing.Size(199, 21);
            this.DealFilterByStation.TabIndex = 0;
            this.DealFilterByStation.SelectedIndexChanged += new System.EventHandler(this.FilterByStation_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DealTableRefreshButton);
            this.groupBox4.Controls.Add(this.DealUpdateButton);
            this.groupBox4.Location = new System.Drawing.Point(607, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 153);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Функционал";
            // 
            // DealTableRefreshButton
            // 
            this.DealTableRefreshButton.Location = new System.Drawing.Point(6, 19);
            this.DealTableRefreshButton.Name = "DealTableRefreshButton";
            this.DealTableRefreshButton.Size = new System.Drawing.Size(190, 60);
            this.DealTableRefreshButton.TabIndex = 3;
            this.DealTableRefreshButton.Text = "Обновить список сделок";
            this.DealTableRefreshButton.UseVisualStyleBackColor = true;
            this.DealTableRefreshButton.Click += new System.EventHandler(this.DealTableRefreshButton_Click);
            // 
            // DealUpdateButton
            // 
            this.DealUpdateButton.Location = new System.Drawing.Point(6, 85);
            this.DealUpdateButton.Name = "DealUpdateButton";
            this.DealUpdateButton.Size = new System.Drawing.Size(190, 60);
            this.DealUpdateButton.TabIndex = 2;
            this.DealUpdateButton.Text = "Править выбранную сделку";
            this.DealUpdateButton.UseVisualStyleBackColor = true;
            this.DealUpdateButton.Click += new System.EventHandler(this.DealUpdateButton_Click);
            // 
            // DealTable
            // 
            this.DealTable.AllowUserToAddRows = false;
            this.DealTable.AllowUserToDeleteRows = false;
            this.DealTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DealTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DealId,
            this.ClientCardId,
            this.ClientName,
            this.EmployeeFullName,
            this.StationFullName,
            this.SupplyType,
            this.SupplyTypeAmount,
            this.DealFinalPrice,
            this.DealDiscount,
            this.PriceWithoutDiscount,
            this.DealDate});
            this.DealTable.Location = new System.Drawing.Point(-4, 0);
            this.DealTable.Name = "DealTable";
            this.DealTable.Size = new System.Drawing.Size(595, 462);
            this.DealTable.TabIndex = 1;
            // 
            // DealId
            // 
            this.DealId.HeaderText = "ID";
            this.DealId.Name = "DealId";
            this.DealId.ReadOnly = true;
            this.DealId.Width = 40;
            // 
            // ClientCardId
            // 
            this.ClientCardId.HeaderText = "Карта клиента";
            this.ClientCardId.Name = "ClientCardId";
            this.ClientCardId.ReadOnly = true;
            this.ClientCardId.Width = 50;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "Покупатель";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // EmployeeFullName
            // 
            this.EmployeeFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmployeeFullName.HeaderText = "Сотрудник";
            this.EmployeeFullName.Name = "EmployeeFullName";
            this.EmployeeFullName.ReadOnly = true;
            // 
            // StationFullName
            // 
            this.StationFullName.HeaderText = "Станция";
            this.StationFullName.Name = "StationFullName";
            // 
            // SupplyType
            // 
            this.SupplyType.HeaderText = "Товар";
            this.SupplyType.Name = "SupplyType";
            this.SupplyType.Width = 50;
            // 
            // SupplyTypeAmount
            // 
            this.SupplyTypeAmount.HeaderText = "Количество товара";
            this.SupplyTypeAmount.Name = "SupplyTypeAmount";
            this.SupplyTypeAmount.Width = 50;
            // 
            // DealFinalPrice
            // 
            this.DealFinalPrice.HeaderText = "Сумма сделки";
            this.DealFinalPrice.Name = "DealFinalPrice";
            this.DealFinalPrice.Width = 50;
            // 
            // DealDiscount
            // 
            this.DealDiscount.HeaderText = "Скидка";
            this.DealDiscount.Name = "DealDiscount";
            this.DealDiscount.ReadOnly = true;
            this.DealDiscount.Width = 50;
            // 
            // PriceWithoutDiscount
            // 
            this.PriceWithoutDiscount.HeaderText = "Цена без скидки";
            this.PriceWithoutDiscount.Name = "PriceWithoutDiscount";
            this.PriceWithoutDiscount.ReadOnly = true;
            this.PriceWithoutDiscount.Width = 50;
            // 
            // DealDate
            // 
            this.DealDate.HeaderText = "Дата сделки";
            this.DealDate.Name = "DealDate";
            this.DealDate.Width = 150;
            // 
            // SupplyTableTab
            // 
            this.SupplyTableTab.Controls.Add(this.groupBox9);
            this.SupplyTableTab.Controls.Add(this.groupBox8);
            this.SupplyTableTab.Controls.Add(this.SuppliesTable);
            this.SupplyTableTab.Location = new System.Drawing.Point(4, 22);
            this.SupplyTableTab.Name = "SupplyTableTab";
            this.SupplyTableTab.Size = new System.Drawing.Size(820, 462);
            this.SupplyTableTab.TabIndex = 5;
            this.SupplyTableTab.Text = "Список поставок";
            this.SupplyTableTab.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.SupplyFilterByStation);
            this.groupBox9.Location = new System.Drawing.Point(629, 417);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(188, 42);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Фильтр по станции";
            // 
            // SupplyFilterByStation
            // 
            this.SupplyFilterByStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplyFilterByStation.FormattingEnabled = true;
            this.SupplyFilterByStation.Location = new System.Drawing.Point(7, 15);
            this.SupplyFilterByStation.Name = "SupplyFilterByStation";
            this.SupplyFilterByStation.Size = new System.Drawing.Size(175, 21);
            this.SupplyFilterByStation.TabIndex = 2;
            this.SupplyFilterByStation.SelectedIndexChanged += new System.EventHandler(this.SupplyFilterByStation_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.RefreshSupplyTableButton);
            this.groupBox8.Location = new System.Drawing.Point(636, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(181, 84);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Функционал";
            // 
            // RefreshSupplyTableButton
            // 
            this.RefreshSupplyTableButton.Location = new System.Drawing.Point(21, 19);
            this.RefreshSupplyTableButton.Name = "RefreshSupplyTableButton";
            this.RefreshSupplyTableButton.Size = new System.Drawing.Size(140, 50);
            this.RefreshSupplyTableButton.TabIndex = 0;
            this.RefreshSupplyTableButton.Text = "Обновить список поставок";
            this.RefreshSupplyTableButton.UseVisualStyleBackColor = true;
            this.RefreshSupplyTableButton.Click += new System.EventHandler(this.RefreshSupplyTableButton_Click);
            // 
            // SuppliesTable
            // 
            this.SuppliesTable.AllowUserToAddRows = false;
            this.SuppliesTable.AllowUserToDeleteRows = false;
            this.SuppliesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuppliesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplyStationId,
            this.SupplyStationName,
            this.SupplyEmployee,
            this.ProductId,
            this.ProductSupplyType,
            this.fuelSupplyAmount,
            this.SupplyDate});
            this.SuppliesTable.Location = new System.Drawing.Point(3, 3);
            this.SuppliesTable.Name = "SuppliesTable";
            this.SuppliesTable.Size = new System.Drawing.Size(625, 456);
            this.SuppliesTable.TabIndex = 0;
            // 
            // SupplyStationId
            // 
            this.SupplyStationId.HeaderText = "ID станции";
            this.SupplyStationId.Name = "SupplyStationId";
            this.SupplyStationId.ReadOnly = true;
            this.SupplyStationId.Width = 40;
            // 
            // SupplyStationName
            // 
            this.SupplyStationName.HeaderText = "Название станции";
            this.SupplyStationName.Name = "SupplyStationName";
            this.SupplyStationName.ReadOnly = true;
            this.SupplyStationName.Width = 150;
            // 
            // SupplyEmployee
            // 
            this.SupplyEmployee.HeaderText = "Сотрудник";
            this.SupplyEmployee.Name = "SupplyEmployee";
            this.SupplyEmployee.ReadOnly = true;
            this.SupplyEmployee.Width = 150;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "ID товара";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 50;
            // 
            // ProductSupplyType
            // 
            this.ProductSupplyType.HeaderText = "Тип товара";
            this.ProductSupplyType.Name = "ProductSupplyType";
            this.ProductSupplyType.ReadOnly = true;
            this.ProductSupplyType.Width = 60;
            // 
            // fuelSupplyAmount
            // 
            this.fuelSupplyAmount.HeaderText = "Количество товара";
            this.fuelSupplyAmount.Name = "fuelSupplyAmount";
            // 
            // SupplyDate
            // 
            this.SupplyDate.HeaderText = "Дата поставки";
            this.SupplyDate.Name = "SupplyDate";
            this.SupplyDate.ReadOnly = true;
            this.SupplyDate.Width = 150;
            // 
            // ProductTableTab
            // 
            this.ProductTableTab.Controls.Add(this.ProductTableFunc);
            this.ProductTableTab.Controls.Add(this.SupplyTypeTable);
            this.ProductTableTab.Location = new System.Drawing.Point(4, 22);
            this.ProductTableTab.Name = "ProductTableTab";
            this.ProductTableTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductTableTab.Size = new System.Drawing.Size(820, 462);
            this.ProductTableTab.TabIndex = 6;
            this.ProductTableTab.Text = "Товары";
            this.ProductTableTab.UseVisualStyleBackColor = true;
            // 
            // ProductTableFunc
            // 
            this.ProductTableFunc.Controls.Add(this.DeleteSupplyTypeButton);
            this.ProductTableFunc.Controls.Add(this.UpdateSupplyTypeButton);
            this.ProductTableFunc.Controls.Add(this.RefreshSupplyTypeTableButton);
            this.ProductTableFunc.Location = new System.Drawing.Point(546, 3);
            this.ProductTableFunc.Name = "ProductTableFunc";
            this.ProductTableFunc.Size = new System.Drawing.Size(268, 208);
            this.ProductTableFunc.TabIndex = 1;
            this.ProductTableFunc.TabStop = false;
            this.ProductTableFunc.Text = "Функционал";
            // 
            // DeleteSupplyTypeButton
            // 
            this.DeleteSupplyTypeButton.Location = new System.Drawing.Point(45, 139);
            this.DeleteSupplyTypeButton.Name = "DeleteSupplyTypeButton";
            this.DeleteSupplyTypeButton.Size = new System.Drawing.Size(176, 54);
            this.DeleteSupplyTypeButton.TabIndex = 2;
            this.DeleteSupplyTypeButton.Text = "Снять с продажи";
            this.DeleteSupplyTypeButton.UseVisualStyleBackColor = true;
            this.DeleteSupplyTypeButton.Click += new System.EventHandler(this.DeleteSupplyTypeButton_Click);
            // 
            // UpdateSupplyTypeButton
            // 
            this.UpdateSupplyTypeButton.Location = new System.Drawing.Point(45, 79);
            this.UpdateSupplyTypeButton.Name = "UpdateSupplyTypeButton";
            this.UpdateSupplyTypeButton.Size = new System.Drawing.Size(176, 54);
            this.UpdateSupplyTypeButton.TabIndex = 1;
            this.UpdateSupplyTypeButton.Text = "Изменить информацию о товаре";
            this.UpdateSupplyTypeButton.UseVisualStyleBackColor = true;
            this.UpdateSupplyTypeButton.Click += new System.EventHandler(this.UpdateSupplyTypeButton_Click);
            // 
            // RefreshSupplyTypeTableButton
            // 
            this.RefreshSupplyTypeTableButton.Location = new System.Drawing.Point(45, 19);
            this.RefreshSupplyTypeTableButton.Name = "RefreshSupplyTypeTableButton";
            this.RefreshSupplyTypeTableButton.Size = new System.Drawing.Size(176, 54);
            this.RefreshSupplyTypeTableButton.TabIndex = 0;
            this.RefreshSupplyTypeTableButton.Text = "Обновить таблицу";
            this.RefreshSupplyTypeTableButton.UseVisualStyleBackColor = true;
            this.RefreshSupplyTypeTableButton.Click += new System.EventHandler(this.RefreshSupplyTypeTableButton_Click);
            // 
            // SupplyTypeTable
            // 
            this.SupplyTypeTable.AllowUserToAddRows = false;
            this.SupplyTypeTable.AllowUserToDeleteRows = false;
            this.SupplyTypeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplyTypeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplyTypeId,
            this.SupplyTypeName,
            this.SupplyTypePrice,
            this.IsSupplyTypeSelling});
            this.SupplyTypeTable.Location = new System.Drawing.Point(-4, 0);
            this.SupplyTypeTable.Name = "SupplyTypeTable";
            this.SupplyTypeTable.Size = new System.Drawing.Size(544, 462);
            this.SupplyTypeTable.TabIndex = 0;
            // 
            // SupplyTypeId
            // 
            this.SupplyTypeId.HeaderText = "ID";
            this.SupplyTypeId.Name = "SupplyTypeId";
            this.SupplyTypeId.ReadOnly = true;
            // 
            // SupplyTypeName
            // 
            this.SupplyTypeName.HeaderText = "Наименование";
            this.SupplyTypeName.Name = "SupplyTypeName";
            this.SupplyTypeName.ReadOnly = true;
            this.SupplyTypeName.Width = 200;
            // 
            // SupplyTypePrice
            // 
            this.SupplyTypePrice.HeaderText = "Цена";
            this.SupplyTypePrice.Name = "SupplyTypePrice";
            this.SupplyTypePrice.ReadOnly = true;
            // 
            // IsSupplyTypeSelling
            // 
            this.IsSupplyTypeSelling.HeaderText = "В продаже";
            this.IsSupplyTypeSelling.Name = "IsSupplyTypeSelling";
            this.IsSupplyTypeSelling.ReadOnly = true;
            // 
            // msAdmin
            // 
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.допФункцииToolStripMenuItem});
            this.msAdmin.Location = new System.Drawing.Point(0, 0);
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(851, 24);
            this.msAdmin.TabIndex = 1;
            this.msAdmin.Text = "Доп. функции";
            // 
            // допФункцииToolStripMenuItem
            // 
            this.допФункцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewAdmin,
            this.RefreshTables,
            this.dbQueryManager,
            this.HistoryToolStripMenuItem});
            this.допФункцииToolStripMenuItem.Name = "допФункцииToolStripMenuItem";
            this.допФункцииToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.допФункцииToolStripMenuItem.Text = "Доп. функции";
            // 
            // AddNewAdmin
            // 
            this.AddNewAdmin.Name = "AddNewAdmin";
            this.AddNewAdmin.Size = new System.Drawing.Size(220, 22);
            this.AddNewAdmin.Text = "Добавить администратора";
            this.AddNewAdmin.Click += new System.EventHandler(this.AddNewAdmin_Click);
            // 
            // RefreshTables
            // 
            this.RefreshTables.Name = "RefreshTables";
            this.RefreshTables.Size = new System.Drawing.Size(220, 22);
            this.RefreshTables.Text = "Обновить таблицы";
            this.RefreshTables.Click += new System.EventHandler(this.RefreshTables_Click);
            // 
            // dbQueryManager
            // 
            this.dbQueryManager.Name = "dbQueryManager";
            this.dbQueryManager.Size = new System.Drawing.Size(220, 22);
            this.dbQueryManager.Text = "Запрос к базе данных";
            // 
            // HistoryToolStripMenuItem
            // 
            this.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem";
            this.HistoryToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.HistoryToolStripMenuItem.Text = "Журнал операций";
            this.HistoryToolStripMenuItem.Click += new System.EventHandler(this.HistoryToolStripMenuItem_Click);
            // 
            // lbSessionName
            // 
            this.lbSessionName.AutoSize = true;
            this.lbSessionName.Location = new System.Drawing.Point(748, 9);
            this.lbSessionName.Name = "lbSessionName";
            this.lbSessionName.Size = new System.Drawing.Size(78, 13);
            this.lbSessionName.TabIndex = 3;
            this.lbSessionName.Text = "Сессия: admin";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 522);
            this.Controls.Add(this.lbSessionName);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.msAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msAdmin;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Раздел администратора";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.WarehouseTableTab.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseTable)).EndInit();
            this.ClientTableTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientTable)).EndInit();
            this.EmployeeTableTab.ResumeLayout(false);
            this.EmployeeTableTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).EndInit();
            this.tabAdmin.ResumeLayout(false);
            this.StationTableTab.ResumeLayout(false);
            this.StationTableTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StationsTable)).EndInit();
            this.DealTableTab.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DealTable)).EndInit();
            this.SupplyTableTab.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SuppliesTable)).EndInit();
            this.ProductTableTab.ResumeLayout(false);
            this.ProductTableFunc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SupplyTypeTable)).EndInit();
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.DataGridView EmployeeTable;
        private System.Windows.Forms.Button RefreshEmployeeTable;
        private System.Windows.Forms.Button UpdateEmployeeButton;
        private System.Windows.Forms.Button AddNewEmployee;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.TabPage EmployeeTableTab;
        private System.Windows.Forms.DataGridView ClientTable;
        private System.Windows.Forms.Button FindDealsByClientButton;
        private System.Windows.Forms.Button AddNewClientButton;
        private System.Windows.Forms.TabPage ClientTableTab;
        private System.Windows.Forms.DataGridView WarehouseTable;
        private System.Windows.Forms.TabPage WarehouseTableTab;
        private System.Windows.Forms.TabPage DealTableTab;
        private System.Windows.Forms.DataGridView DealTable;
        private System.Windows.Forms.Button DealUpdateButton;
        private System.Windows.Forms.TabPage StationTableTab;
        private System.Windows.Forms.DataGridView StationsTable;
        private System.Windows.Forms.Button AddNewStationButton;
        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem допФункцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewAdmin;
        private System.Windows.Forms.ToolStripMenuItem RefreshTables;
        private System.Windows.Forms.Button GiveAdminAccessButton;
        private System.Windows.Forms.Button ActivateClientCardButton;
        private System.Windows.Forms.Button RefreshStationTableButton;
        private System.Windows.Forms.Button UpdateClientTableButton;
        private System.Windows.Forms.Button DealTableRefreshButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbSessionName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox DealFilterByStation;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button RefreshWarehouseInfoButton;
        private System.Windows.Forms.ComboBox WhFilterByStation;
        private System.Windows.Forms.TabPage SupplyTableTab;
        private System.Windows.Forms.DataGridView SuppliesTable;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button RefreshSupplyTableButton;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox SupplyFilterByStation;
        private System.Windows.Forms.ToolStripMenuItem dbQueryManager;
        private Button CloseStationButton;
        private Button UpdateStationInfoButton;
        private CheckBox OnlyWorkingStationsCheckBox;
        private CheckBox OnlyWorkingEmployeeCheckBox;
        private DataGridViewTextBoxColumn StationId;
        private DataGridViewTextBoxColumn StationName;
        private DataGridViewTextBoxColumn StationCity;
        private DataGridViewTextBoxColumn StationAddress;
        private DataGridViewTextBoxColumn IsStationWorking;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn EmployeeConnectedCreds;
        private DataGridViewTextBoxColumn EmployeeSurname;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn EmployeeMiddleName;
        private DataGridViewTextBoxColumn EmployeeBirthday;
        private DataGridViewTextBoxColumn EmploymentDate;
        private DataGridViewTextBoxColumn EmployeeContractEnd;
        private DataGridViewTextBoxColumn EmployeePosition;
        private DataGridViewTextBoxColumn EmployeeSalary;
        private DataGridViewTextBoxColumn EmployeeAddress;
        private DataGridViewTextBoxColumn EmployeePhone;
        private DataGridViewTextBoxColumn EmployeeIsWorking;
        private DataGridViewTextBoxColumn ClientId;
        private DataGridViewTextBoxColumn ClientFirstName;
        private DataGridViewTextBoxColumn ClientLastName;
        private DataGridViewTextBoxColumn ClientMiddleName;
        private DataGridViewTextBoxColumn CardId;
        private DataGridViewTextBoxColumn DiscountPercent;
        private DataGridViewTextBoxColumn ActivationDate;
        private DataGridViewTextBoxColumn CredId;
        private DataGridViewTextBoxColumn DealId;
        private DataGridViewTextBoxColumn ClientCardId;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn EmployeeFullName;
        private DataGridViewTextBoxColumn StationFullName;
        private DataGridViewTextBoxColumn SupplyType;
        private DataGridViewTextBoxColumn SupplyTypeAmount;
        private DataGridViewTextBoxColumn DealFinalPrice;
        private DataGridViewTextBoxColumn DealDiscount;
        private DataGridViewTextBoxColumn PriceWithoutDiscount;
        private DataGridViewTextBoxColumn DealDate;
        private ToolStripMenuItem HistoryToolStripMenuItem;
        private DataGridViewTextBoxColumn SupplyStationId;
        private DataGridViewTextBoxColumn SupplyStationName;
        private DataGridViewTextBoxColumn SupplyEmployee;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductSupplyType;
        private DataGridViewTextBoxColumn fuelSupplyAmount;
        private DataGridViewTextBoxColumn SupplyDate;
        private TabPage ProductTableTab;
        private GroupBox ProductTableFunc;
        private Button DeleteSupplyTypeButton;
        private Button UpdateSupplyTypeButton;
        private Button RefreshSupplyTypeTableButton;
        private DataGridView SupplyTypeTable;
        private DataGridViewTextBoxColumn SupplyTypeId;
        private DataGridViewTextBoxColumn SupplyTypeName;
        private DataGridViewTextBoxColumn SupplyTypePrice;
        private DataGridViewTextBoxColumn IsSupplyTypeSelling;
        private DataGridViewTextBoxColumn WarehouseStationId;
        private DataGridViewTextBoxColumn WarehouseStationName;
        private DataGridViewTextBoxColumn WarehouseSupplyTypeId;
        private DataGridViewTextBoxColumn WarehouseSupplyTypeName;
        private DataGridViewTextBoxColumn WarehouseSupplyCount;
    }
}

