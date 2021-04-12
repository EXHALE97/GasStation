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
            this.tabAccountingTable = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbAccountingFilterByStation = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnTableAccountingView = new System.Windows.Forms.Button();
            this.dgvViewAccounting = new System.Windows.Forms.DataGridView();
            this.stationaccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationAccountingAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelaccounttype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelaccountamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCarTable = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTableCarView = new System.Windows.Forms.Button();
            this.btnActivateCarCard = new System.Windows.Forms.Button();
            this.btnFindDealsByCar_id = new System.Windows.Forms.Button();
            this.btnCarAdd = new System.Windows.Forms.Button();
            this.dgvViewCars = new System.Windows.Forms.DataGridView();
            this.car_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carmark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStaffTable = new System.Windows.Forms.TabPage();
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
            this.EmployeeLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmploymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeContractEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeIsWorking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabStationTable = new System.Windows.Forms.TabPage();
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
            this.tabDealTable = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbDealFilterByStation = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTableDealView = new System.Windows.Forms.Button();
            this.btnDealUpdate = new System.Windows.Forms.Button();
            this.dgvViewDeal = new System.Windows.Forms.DataGridView();
            this.deal_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationDealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fueltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyercard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSupplyTable = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cbSupplyFilterByStation = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnTableSupplyView = new System.Windows.Forms.Button();
            this.dgvViewSupply = new System.Windows.Forms.DataGridView();
            this.stationSupplyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationSupply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffSupply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelSupplyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelSupplyAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.допФункцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshTables = new System.Windows.Forms.ToolStripMenuItem();
            this.dbQueryManager = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSessionName = new System.Windows.Forms.Label();
            this.tabAccountingTable.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAccounting)).BeginInit();
            this.tabCarTable.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCars)).BeginInit();
            this.tabStaffTable.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).BeginInit();
            this.tabAdmin.SuspendLayout();
            this.tabStationTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StationsTable)).BeginInit();
            this.tabDealTable.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewDeal)).BeginInit();
            this.tabSupplyTable.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSupply)).BeginInit();
            this.msAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAccountingTable
            // 
            this.tabAccountingTable.Controls.Add(this.groupBox7);
            this.tabAccountingTable.Controls.Add(this.groupBox6);
            this.tabAccountingTable.Controls.Add(this.dgvViewAccounting);
            this.tabAccountingTable.Location = new System.Drawing.Point(4, 22);
            this.tabAccountingTable.Name = "tabAccountingTable";
            this.tabAccountingTable.Size = new System.Drawing.Size(820, 462);
            this.tabAccountingTable.TabIndex = 2;
            this.tabAccountingTable.Text = "Таблица учёта";
            this.tabAccountingTable.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbAccountingFilterByStation);
            this.groupBox7.Location = new System.Drawing.Point(604, 416);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(212, 43);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Фильтр по станции";
            // 
            // cbAccountingFilterByStation
            // 
            this.cbAccountingFilterByStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountingFilterByStation.FormattingEnabled = true;
            this.cbAccountingFilterByStation.Location = new System.Drawing.Point(6, 16);
            this.cbAccountingFilterByStation.Name = "cbAccountingFilterByStation";
            this.cbAccountingFilterByStation.Size = new System.Drawing.Size(200, 21);
            this.cbAccountingFilterByStation.TabIndex = 0;
            this.cbAccountingFilterByStation.SelectedIndexChanged += new System.EventHandler(this.cbAccountingFilterByStation_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnTableAccountingView);
            this.groupBox6.Location = new System.Drawing.Point(604, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(212, 89);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Функционал";
            // 
            // btnTableAccountingView
            // 
            this.btnTableAccountingView.Location = new System.Drawing.Point(6, 19);
            this.btnTableAccountingView.Name = "btnTableAccountingView";
            this.btnTableAccountingView.Size = new System.Drawing.Size(200, 60);
            this.btnTableAccountingView.TabIndex = 4;
            this.btnTableAccountingView.Text = "Обновить таблицу учёта";
            this.btnTableAccountingView.UseVisualStyleBackColor = true;
            this.btnTableAccountingView.Click += new System.EventHandler(this.ViewAccountingTable);
            // 
            // dgvViewAccounting
            // 
            this.dgvViewAccounting.AllowUserToAddRows = false;
            this.dgvViewAccounting.AllowUserToDeleteRows = false;
            this.dgvViewAccounting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAccounting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stationaccountID,
            this.stationAccountingAdres,
            this.accountrole,
            this.fuelaccounttype,
            this.fuelaccountamount,
            this.accountdate});
            this.dgvViewAccounting.Location = new System.Drawing.Point(9, 3);
            this.dgvViewAccounting.Name = "dgvViewAccounting";
            this.dgvViewAccounting.Size = new System.Drawing.Size(595, 459);
            this.dgvViewAccounting.TabIndex = 2;
            // 
            // stationaccountID
            // 
            this.stationaccountID.HeaderText = "ID станции";
            this.stationaccountID.Name = "stationaccountID";
            this.stationaccountID.Width = 40;
            // 
            // stationAccountingAdres
            // 
            this.stationAccountingAdres.HeaderText = "Адрес станции";
            this.stationAccountingAdres.Name = "stationAccountingAdres";
            // 
            // accountrole
            // 
            this.accountrole.HeaderText = "Тип операции";
            this.accountrole.Name = "accountrole";
            this.accountrole.Width = 150;
            // 
            // fuelaccounttype
            // 
            this.fuelaccounttype.HeaderText = "Тип топлива";
            this.fuelaccounttype.Name = "fuelaccounttype";
            this.fuelaccounttype.Width = 60;
            // 
            // fuelaccountamount
            // 
            this.fuelaccountamount.HeaderText = "Количество топлива";
            this.fuelaccountamount.Name = "fuelaccountamount";
            // 
            // accountdate
            // 
            this.accountdate.HeaderText = "Дата проверки";
            this.accountdate.Name = "accountdate";
            this.accountdate.Width = 200;
            // 
            // tabCarTable
            // 
            this.tabCarTable.Controls.Add(this.groupBox3);
            this.tabCarTable.Controls.Add(this.dgvViewCars);
            this.tabCarTable.Location = new System.Drawing.Point(4, 22);
            this.tabCarTable.Name = "tabCarTable";
            this.tabCarTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarTable.Size = new System.Drawing.Size(820, 462);
            this.tabCarTable.TabIndex = 1;
            this.tabCarTable.Text = "Список покупателей";
            this.tabCarTable.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTableCarView);
            this.groupBox3.Controls.Add(this.btnActivateCarCard);
            this.groupBox3.Controls.Add(this.btnFindDealsByCar_id);
            this.groupBox3.Controls.Add(this.btnCarAdd);
            this.groupBox3.Location = new System.Drawing.Point(505, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 290);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Функционал";
            // 
            // btnTableCarView
            // 
            this.btnTableCarView.Location = new System.Drawing.Point(62, 19);
            this.btnTableCarView.Name = "btnTableCarView";
            this.btnTableCarView.Size = new System.Drawing.Size(190, 60);
            this.btnTableCarView.TabIndex = 5;
            this.btnTableCarView.Text = "Обновить список покупателей";
            this.btnTableCarView.UseVisualStyleBackColor = true;
            this.btnTableCarView.Click += new System.EventHandler(this.ViewClientTable);
            // 
            // btnActivateCarCard
            // 
            this.btnActivateCarCard.Location = new System.Drawing.Point(62, 217);
            this.btnActivateCarCard.Name = "btnActivateCarCard";
            this.btnActivateCarCard.Size = new System.Drawing.Size(190, 60);
            this.btnActivateCarCard.TabIndex = 4;
            this.btnActivateCarCard.Text = "Активировать карту покупателя";
            this.btnActivateCarCard.UseVisualStyleBackColor = true;
            this.btnActivateCarCard.Click += new System.EventHandler(this.btnActivateCarCard_Click);
            // 
            // btnFindDealsByCar_id
            // 
            this.btnFindDealsByCar_id.Location = new System.Drawing.Point(62, 85);
            this.btnFindDealsByCar_id.Name = "btnFindDealsByCar_id";
            this.btnFindDealsByCar_id.Size = new System.Drawing.Size(190, 60);
            this.btnFindDealsByCar_id.TabIndex = 2;
            this.btnFindDealsByCar_id.Text = "Обзор сделок с выбранным покупателем";
            this.btnFindDealsByCar_id.UseVisualStyleBackColor = true;
            this.btnFindDealsByCar_id.Click += new System.EventHandler(this.btnFindDeals_Click);
            // 
            // btnCarAdd
            // 
            this.btnCarAdd.Location = new System.Drawing.Point(62, 151);
            this.btnCarAdd.Name = "btnCarAdd";
            this.btnCarAdd.Size = new System.Drawing.Size(190, 60);
            this.btnCarAdd.TabIndex = 3;
            this.btnCarAdd.Text = "Добавить нового покупателя";
            this.btnCarAdd.UseVisualStyleBackColor = true;
            this.btnCarAdd.Click += new System.EventHandler(this.btnCarAdd_Click);
            // 
            // dgvViewCars
            // 
            this.dgvViewCars.AllowUserToAddRows = false;
            this.dgvViewCars.AllowUserToDeleteRows = false;
            this.dgvViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.car_id,
            this.carmark,
            this.cardnum});
            this.dgvViewCars.Location = new System.Drawing.Point(6, 3);
            this.dgvViewCars.Name = "dgvViewCars";
            this.dgvViewCars.Size = new System.Drawing.Size(493, 459);
            this.dgvViewCars.TabIndex = 1;
            // 
            // car_id
            // 
            this.car_id.HeaderText = "ID";
            this.car_id.Name = "car_id";
            this.car_id.Width = 50;
            // 
            // carmark
            // 
            this.carmark.HeaderText = "Марка автомобиля";
            this.carmark.Name = "carmark";
            this.carmark.Width = 200;
            // 
            // cardnum
            // 
            this.cardnum.HeaderText = "Номер карты";
            this.cardnum.Name = "cardnum";
            this.cardnum.Width = 200;
            // 
            // tabStaffTable
            // 
            this.tabStaffTable.Controls.Add(this.OnlyWorkingEmployeeCheckBox);
            this.tabStaffTable.Controls.Add(this.groupBox2);
            this.tabStaffTable.Controls.Add(this.EmployeeTable);
            this.tabStaffTable.Location = new System.Drawing.Point(4, 22);
            this.tabStaffTable.Name = "tabStaffTable";
            this.tabStaffTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaffTable.Size = new System.Drawing.Size(820, 462);
            this.tabStaffTable.TabIndex = 0;
            this.tabStaffTable.Text = "Список сотрудников";
            this.tabStaffTable.UseVisualStyleBackColor = true;
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
            this.EmployeeLastName,
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
            // EmployeeLastName
            // 
            this.EmployeeLastName.HeaderText = "Отчество";
            this.EmployeeLastName.Name = "EmployeeLastName";
            this.EmployeeLastName.ReadOnly = true;
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
            this.tabAdmin.Controls.Add(this.tabStationTable);
            this.tabAdmin.Controls.Add(this.tabStaffTable);
            this.tabAdmin.Controls.Add(this.tabCarTable);
            this.tabAdmin.Controls.Add(this.tabDealTable);
            this.tabAdmin.Controls.Add(this.tabAccountingTable);
            this.tabAdmin.Controls.Add(this.tabSupplyTable);
            this.tabAdmin.Location = new System.Drawing.Point(12, 29);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(828, 488);
            this.tabAdmin.TabIndex = 0;
            // 
            // tabStationTable
            // 
            this.tabStationTable.Controls.Add(this.OnlyWorkingStationsCheckBox);
            this.tabStationTable.Controls.Add(this.groupBox1);
            this.tabStationTable.Controls.Add(this.StationsTable);
            this.tabStationTable.Location = new System.Drawing.Point(4, 22);
            this.tabStationTable.Name = "tabStationTable";
            this.tabStationTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabStationTable.Size = new System.Drawing.Size(820, 462);
            this.tabStationTable.TabIndex = 4;
            this.tabStationTable.Text = "Список станций";
            this.tabStationTable.UseVisualStyleBackColor = true;
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
            // tabDealTable
            // 
            this.tabDealTable.Controls.Add(this.groupBox5);
            this.tabDealTable.Controls.Add(this.groupBox4);
            this.tabDealTable.Controls.Add(this.dgvViewDeal);
            this.tabDealTable.Location = new System.Drawing.Point(4, 22);
            this.tabDealTable.Name = "tabDealTable";
            this.tabDealTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabDealTable.Size = new System.Drawing.Size(820, 462);
            this.tabDealTable.TabIndex = 3;
            this.tabDealTable.Text = "Список сделок";
            this.tabDealTable.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbDealFilterByStation);
            this.groupBox5.Location = new System.Drawing.Point(607, 411);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(210, 48);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Фильтр по адресу станции";
            // 
            // cbDealFilterByStation
            // 
            this.cbDealFilterByStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDealFilterByStation.FormattingEnabled = true;
            this.cbDealFilterByStation.Location = new System.Drawing.Point(8, 21);
            this.cbDealFilterByStation.Name = "cbDealFilterByStation";
            this.cbDealFilterByStation.Size = new System.Drawing.Size(199, 21);
            this.cbDealFilterByStation.TabIndex = 0;
            this.cbDealFilterByStation.SelectedIndexChanged += new System.EventHandler(this.cbFilterByStation_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTableDealView);
            this.groupBox4.Controls.Add(this.btnDealUpdate);
            this.groupBox4.Location = new System.Drawing.Point(607, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 153);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Функционал";
            // 
            // btnTableDealView
            // 
            this.btnTableDealView.Location = new System.Drawing.Point(6, 19);
            this.btnTableDealView.Name = "btnTableDealView";
            this.btnTableDealView.Size = new System.Drawing.Size(190, 60);
            this.btnTableDealView.TabIndex = 3;
            this.btnTableDealView.Text = "Обновить список сделок";
            this.btnTableDealView.UseVisualStyleBackColor = true;
            this.btnTableDealView.Click += new System.EventHandler(this.ViewDealTable);
            // 
            // btnDealUpdate
            // 
            this.btnDealUpdate.Location = new System.Drawing.Point(6, 85);
            this.btnDealUpdate.Name = "btnDealUpdate";
            this.btnDealUpdate.Size = new System.Drawing.Size(190, 60);
            this.btnDealUpdate.TabIndex = 2;
            this.btnDealUpdate.Text = "Править выбранную сделку";
            this.btnDealUpdate.UseVisualStyleBackColor = true;
            this.btnDealUpdate.Click += new System.EventHandler(this.btnDealUpdate_Click);
            // 
            // dgvViewDeal
            // 
            this.dgvViewDeal.AllowUserToAddRows = false;
            this.dgvViewDeal.AllowUserToDeleteRows = false;
            this.dgvViewDeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewDeal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deal_id,
            this.stationDealName,
            this.sname,
            this.fueltype,
            this.fuelamount,
            this.dealprice,
            this.buyercard,
            this.dealdate});
            this.dgvViewDeal.Location = new System.Drawing.Point(6, 0);
            this.dgvViewDeal.Name = "dgvViewDeal";
            this.dgvViewDeal.Size = new System.Drawing.Size(595, 462);
            this.dgvViewDeal.TabIndex = 1;
            // 
            // deal_id
            // 
            this.deal_id.HeaderText = "ID";
            this.deal_id.Name = "deal_id";
            this.deal_id.Width = 40;
            // 
            // stationDealName
            // 
            this.stationDealName.HeaderText = "Адрес станции";
            this.stationDealName.Name = "stationDealName";
            // 
            // sname
            // 
            this.sname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sname.HeaderText = "ФИ сотрудника";
            this.sname.Name = "sname";
            this.sname.Width = 120;
            // 
            // fueltype
            // 
            this.fueltype.HeaderText = "Тип топлива";
            this.fueltype.Name = "fueltype";
            this.fueltype.Width = 50;
            // 
            // fuelamount
            // 
            this.fuelamount.HeaderText = "Количество топлива";
            this.fuelamount.Name = "fuelamount";
            this.fuelamount.Width = 60;
            // 
            // dealprice
            // 
            this.dealprice.HeaderText = "Сумма сделки";
            this.dealprice.Name = "dealprice";
            this.dealprice.Width = 60;
            // 
            // buyercard
            // 
            this.buyercard.HeaderText = "Покупатель";
            this.buyercard.Name = "buyercard";
            this.buyercard.Width = 80;
            // 
            // dealdate
            // 
            this.dealdate.HeaderText = "Дата сделки";
            this.dealdate.Name = "dealdate";
            this.dealdate.Width = 150;
            // 
            // tabSupplyTable
            // 
            this.tabSupplyTable.Controls.Add(this.groupBox9);
            this.tabSupplyTable.Controls.Add(this.groupBox8);
            this.tabSupplyTable.Controls.Add(this.dgvViewSupply);
            this.tabSupplyTable.Location = new System.Drawing.Point(4, 22);
            this.tabSupplyTable.Name = "tabSupplyTable";
            this.tabSupplyTable.Size = new System.Drawing.Size(820, 462);
            this.tabSupplyTable.TabIndex = 5;
            this.tabSupplyTable.Text = "Список поставок";
            this.tabSupplyTable.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cbSupplyFilterByStation);
            this.groupBox9.Location = new System.Drawing.Point(629, 417);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(188, 42);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Фильтр по станции";
            // 
            // cbSupplyFilterByStation
            // 
            this.cbSupplyFilterByStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplyFilterByStation.FormattingEnabled = true;
            this.cbSupplyFilterByStation.Location = new System.Drawing.Point(7, 15);
            this.cbSupplyFilterByStation.Name = "cbSupplyFilterByStation";
            this.cbSupplyFilterByStation.Size = new System.Drawing.Size(175, 21);
            this.cbSupplyFilterByStation.TabIndex = 2;
            this.cbSupplyFilterByStation.SelectedIndexChanged += new System.EventHandler(this.cbSupplyFilterByStation_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnTableSupplyView);
            this.groupBox8.Location = new System.Drawing.Point(663, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(154, 78);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Функционал";
            // 
            // btnTableSupplyView
            // 
            this.btnTableSupplyView.Location = new System.Drawing.Point(6, 19);
            this.btnTableSupplyView.Name = "btnTableSupplyView";
            this.btnTableSupplyView.Size = new System.Drawing.Size(140, 50);
            this.btnTableSupplyView.TabIndex = 0;
            this.btnTableSupplyView.Text = "Обновить список поставок";
            this.btnTableSupplyView.UseVisualStyleBackColor = true;
            this.btnTableSupplyView.Click += new System.EventHandler(this.ViewSuppliesTable);
            // 
            // dgvViewSupply
            // 
            this.dgvViewSupply.AllowUserToAddRows = false;
            this.dgvViewSupply.AllowUserToDeleteRows = false;
            this.dgvViewSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewSupply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stationSupplyID,
            this.stationSupply,
            this.staffSupply,
            this.fuelSupplyType,
            this.fuelSupplyAmount,
            this.SupplyDate});
            this.dgvViewSupply.Location = new System.Drawing.Point(3, 3);
            this.dgvViewSupply.Name = "dgvViewSupply";
            this.dgvViewSupply.Size = new System.Drawing.Size(625, 456);
            this.dgvViewSupply.TabIndex = 0;
            // 
            // stationSupplyID
            // 
            this.stationSupplyID.HeaderText = "ID станции";
            this.stationSupplyID.Name = "stationSupplyID";
            this.stationSupplyID.Width = 40;
            // 
            // stationSupply
            // 
            this.stationSupply.HeaderText = "Адрес станции";
            this.stationSupply.Name = "stationSupply";
            this.stationSupply.Width = 150;
            // 
            // staffSupply
            // 
            this.staffSupply.HeaderText = "ФИ сотрудника";
            this.staffSupply.Name = "staffSupply";
            this.staffSupply.Width = 150;
            // 
            // fuelSupplyType
            // 
            this.fuelSupplyType.HeaderText = "Тип топлива";
            this.fuelSupplyType.Name = "fuelSupplyType";
            this.fuelSupplyType.Width = 60;
            // 
            // fuelSupplyAmount
            // 
            this.fuelSupplyAmount.HeaderText = "Количество топлива";
            this.fuelSupplyAmount.Name = "fuelSupplyAmount";
            // 
            // SupplyDate
            // 
            this.SupplyDate.HeaderText = "Дата поставки";
            this.SupplyDate.Name = "SupplyDate";
            this.SupplyDate.Width = 150;
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
            this.dbQueryManager});
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
            this.tabAccountingTable.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAccounting)).EndInit();
            this.tabCarTable.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCars)).EndInit();
            this.tabStaffTable.ResumeLayout(false);
            this.tabStaffTable.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).EndInit();
            this.tabAdmin.ResumeLayout(false);
            this.tabStationTable.ResumeLayout(false);
            this.tabStationTable.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StationsTable)).EndInit();
            this.tabDealTable.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewDeal)).EndInit();
            this.tabSupplyTable.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSupply)).EndInit();
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
        private System.Windows.Forms.TabPage tabStaffTable;
        private System.Windows.Forms.DataGridView dgvViewCars;
        private System.Windows.Forms.Button btnFindDealsByCar_id;
        private System.Windows.Forms.Button btnCarAdd;
        private System.Windows.Forms.TabPage tabCarTable;
        private System.Windows.Forms.DataGridView dgvViewAccounting;
        private System.Windows.Forms.TabPage tabAccountingTable;
        private System.Windows.Forms.TabPage tabDealTable;
        private System.Windows.Forms.DataGridView dgvViewDeal;
        private System.Windows.Forms.Button btnDealUpdate;
        private System.Windows.Forms.TabPage tabStationTable;
        private System.Windows.Forms.DataGridView StationsTable;
        private System.Windows.Forms.Button AddNewStationButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn carmark;
        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem допФункцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewAdmin;
        private System.Windows.Forms.ToolStripMenuItem RefreshTables;
        private System.Windows.Forms.Button GiveAdminAccessButton;
        private System.Windows.Forms.Button btnActivateCarCard;
        private System.Windows.Forms.Button RefreshStationTableButton;
        private System.Windows.Forms.Button btnTableCarView;
        private System.Windows.Forms.Button btnTableDealView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbSessionName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbDealFilterByStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyercard;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn fueltype;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationDealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn deal_id;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnTableAccountingView;
        private System.Windows.Forms.ComboBox cbAccountingFilterByStation;
        private System.Windows.Forms.TabPage tabSupplyTable;
        private System.Windows.Forms.DataGridView dgvViewSupply;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnTableSupplyView;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationAccountingAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelaccountamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelaccounttype;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountrole;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationaccountID;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox cbSupplyFilterByStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelSupplyAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelSupplyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffSupply;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationSupply;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationSupplyID;
        private System.Windows.Forms.ToolStripMenuItem dbQueryManager;
        private Button CloseStationButton;
        private Button UpdateStationInfoButton;
        private CheckBox OnlyWorkingStationsCheckBox;
        private CheckBox OnlyWorkingEmployeeCheckBox;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn EmployeeConnectedCreds;
        private DataGridViewTextBoxColumn EmployeeSurname;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn EmployeeLastName;
        private DataGridViewTextBoxColumn EmployeeBirthday;
        private DataGridViewTextBoxColumn EmploymentDate;
        private DataGridViewTextBoxColumn EmployeeContractEnd;
        private DataGridViewTextBoxColumn EmployeePosition;
        private DataGridViewTextBoxColumn EmployeeSalary;
        private DataGridViewTextBoxColumn EmployeeAddress;
        private DataGridViewTextBoxColumn EmployeePhone;
        private DataGridViewTextBoxColumn EmployeeIsWorking;
        private DataGridViewTextBoxColumn StationId;
        private DataGridViewTextBoxColumn StationName;
        private DataGridViewTextBoxColumn StationCity;
        private DataGridViewTextBoxColumn StationAddress;
        private DataGridViewTextBoxColumn IsStationWorking;
    }
}

