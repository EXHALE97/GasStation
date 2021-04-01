namespace Admin
{
    partial class UpdateDealTableForm
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
            this.dealDatePick = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFuelamount = new System.Windows.Forms.TextBox();
            this.cbFuelType = new System.Windows.Forms.ComboBox();
            this.tbDealprice = new System.Windows.Forms.TextBox();
            this.cbCardNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMinutes = new System.Windows.Forms.TextBox();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dealDatePick
            // 
            this.dealDatePick.CausesValidation = false;
            this.dealDatePick.CustomFormat = "";
            this.dealDatePick.Enabled = false;
            this.dealDatePick.Location = new System.Drawing.Point(118, 127);
            this.dealDatePick.Name = "dealDatePick";
            this.dealDatePick.Size = new System.Drawing.Size(135, 20);
            this.dealDatePick.TabIndex = 41;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(88, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(178, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Заменить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Номер карты:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Дата сделки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Цена сделки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Количество топлива:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Тип топлива: ";
            // 
            // tbFuelamount
            // 
            this.tbFuelamount.Location = new System.Drawing.Point(147, 48);
            this.tbFuelamount.Name = "tbFuelamount";
            this.tbFuelamount.Size = new System.Drawing.Size(106, 20);
            this.tbFuelamount.TabIndex = 28;
            this.tbFuelamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFuelamount_KeyPress);
            // 
            // cbFuelType
            // 
            this.cbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuelType.FormattingEnabled = true;
            this.cbFuelType.Location = new System.Drawing.Point(147, 23);
            this.cbFuelType.Name = "cbFuelType";
            this.cbFuelType.Size = new System.Drawing.Size(106, 21);
            this.cbFuelType.TabIndex = 43;
            // 
            // tbDealprice
            // 
            this.tbDealprice.Location = new System.Drawing.Point(147, 74);
            this.tbDealprice.Name = "tbDealprice";
            this.tbDealprice.Size = new System.Drawing.Size(106, 20);
            this.tbDealprice.TabIndex = 44;
            this.tbDealprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDealprice_KeyPress);
            // 
            // cbCardNum
            // 
            this.cbCardNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCardNum.FormattingEnabled = true;
            this.cbCardNum.Location = new System.Drawing.Point(118, 100);
            this.cbCardNum.Name = "cbCardNum";
            this.cbCardNum.Size = new System.Drawing.Size(135, 21);
            this.cbCardNum.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Минута:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Час:";
            // 
            // tbMinutes
            // 
            this.tbMinutes.Location = new System.Drawing.Point(230, 181);
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.Size = new System.Drawing.Size(23, 20);
            this.tbMinutes.TabIndex = 55;
            this.tbMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinutes_KeyPress);
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(230, 155);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(23, 20);
            this.tbHours.TabIndex = 54;
            this.tbHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHours_KeyPress);
            // 
            // UpdateDealTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 256);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMinutes);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.cbCardNum);
            this.Controls.Add(this.tbDealprice);
            this.Controls.Add(this.cbFuelType);
            this.Controls.Add(this.dealDatePick);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFuelamount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateDealTableForm";
            this.Text = "Обновление данных о сделке";
            this.Load += new System.EventHandler(this.updateDealTableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dealDatePick;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFuelamount;
        private System.Windows.Forms.ComboBox cbFuelType;
        private System.Windows.Forms.TextBox tbDealprice;
        private System.Windows.Forms.ComboBox cbCardNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMinutes;
        private System.Windows.Forms.TextBox tbHours;
    }
}