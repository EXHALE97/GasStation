namespace Worker
{
    partial class AddToDealTableForm
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
            this.cbCardNum = new System.Windows.Forms.ComboBox();
            this.dealDatePick = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDealPrice = new System.Windows.Forms.TextBox();
            this.tbFuelamount = new System.Windows.Forms.TextBox();
            this.cbFuelType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.tbMinutes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkNow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbCardNum
            // 
            this.cbCardNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCardNum.FormattingEnabled = true;
            this.cbCardNum.Location = new System.Drawing.Point(150, 91);
            this.cbCardNum.Name = "cbCardNum";
            this.cbCardNum.Size = new System.Drawing.Size(123, 21);
            this.cbCardNum.TabIndex = 45;
            // 
            // dealDatePick
            // 
            this.dealDatePick.Enabled = false;
            this.dealDatePick.Location = new System.Drawing.Point(150, 118);
            this.dealDatePick.Name = "dealDatePick";
            this.dealDatePick.Size = new System.Drawing.Size(123, 20);
            this.dealDatePick.TabIndex = 44;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(111, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(198, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Дата сделки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Номер карты:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Цена сделки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Количество топлива:";
            // 
            // tbDealPrice
            // 
            this.tbDealPrice.Location = new System.Drawing.Point(150, 65);
            this.tbDealPrice.Name = "tbDealPrice";
            this.tbDealPrice.Size = new System.Drawing.Size(123, 20);
            this.tbDealPrice.TabIndex = 27;
            this.tbDealPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDealPrice_KeyPress);
            // 
            // tbFuelamount
            // 
            this.tbFuelamount.Location = new System.Drawing.Point(150, 39);
            this.tbFuelamount.Name = "tbFuelamount";
            this.tbFuelamount.Size = new System.Drawing.Size(123, 20);
            this.tbFuelamount.TabIndex = 26;
            this.tbFuelamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFuelamount_KeyPress);
            // 
            // cbFuelType
            // 
            this.cbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuelType.FormattingEnabled = true;
            this.cbFuelType.Location = new System.Drawing.Point(150, 12);
            this.cbFuelType.Name = "cbFuelType";
            this.cbFuelType.Size = new System.Drawing.Size(123, 21);
            this.cbFuelType.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Тип топлива:";
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(250, 144);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(23, 20);
            this.tbHours.TabIndex = 50;
            this.tbHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHours_KeyPress);
            // 
            // tbMinutes
            // 
            this.tbMinutes.Location = new System.Drawing.Point(250, 170);
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.Size = new System.Drawing.Size(23, 20);
            this.tbMinutes.TabIndex = 51;
            this.tbMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinutes_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Час:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Минута:";
            // 
            // checkNow
            // 
            this.checkNow.AutoSize = true;
            this.checkNow.Location = new System.Drawing.Point(24, 151);
            this.checkNow.Name = "checkNow";
            this.checkNow.Size = new System.Drawing.Size(62, 17);
            this.checkNow.TabIndex = 54;
            this.checkNow.Text = "Сейчас";
            this.checkNow.UseVisualStyleBackColor = true;
            this.checkNow.CheckedChanged += new System.EventHandler(this.checkNow_CheckedChanged);
            // 
            // AddToDealTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 238);
            this.Controls.Add(this.checkNow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMinutes);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbFuelType);
            this.Controls.Add(this.cbCardNum);
            this.Controls.Add(this.dealDatePick);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDealPrice);
            this.Controls.Add(this.tbFuelamount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddToDealTableForm";
            this.Text = "Добавление сделки";
            this.Load += new System.EventHandler(this.updateDealTableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCardNum;
        private System.Windows.Forms.DateTimePicker dealDatePick;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDealPrice;
        private System.Windows.Forms.TextBox tbFuelamount;
        private System.Windows.Forms.ComboBox cbFuelType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.TextBox tbMinutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkNow;
    }
}