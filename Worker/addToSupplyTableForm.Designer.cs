namespace Worker
{
    partial class AddToSupplyTableForm
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
            this.tbFuelAmount = new System.Windows.Forms.TextBox();
            this.supplyDateTimePick = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFuelType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkNow = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMinutes = new System.Windows.Forms.TextBox();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFuelAmount
            // 
            this.tbFuelAmount.Location = new System.Drawing.Point(148, 38);
            this.tbFuelAmount.Name = "tbFuelAmount";
            this.tbFuelAmount.Size = new System.Drawing.Size(146, 20);
            this.tbFuelAmount.TabIndex = 1;
            this.tbFuelAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFuelAmount_KeyPress);
            // 
            // supplyDateTimePick
            // 
            this.supplyDateTimePick.Enabled = false;
            this.supplyDateTimePick.Location = new System.Drawing.Point(148, 63);
            this.supplyDateTimePick.Name = "supplyDateTimePick";
            this.supplyDateTimePick.Size = new System.Drawing.Size(146, 20);
            this.supplyDateTimePick.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип тоалива:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество топлива: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата подвоза:";
            // 
            // cbFuelType
            // 
            this.cbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuelType.FormattingEnabled = true;
            this.cbFuelType.Location = new System.Drawing.Point(148, 11);
            this.cbFuelType.Name = "cbFuelType";
            this.cbFuelType.Size = new System.Drawing.Size(146, 21);
            this.cbFuelType.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(218, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ок";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(125, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkNow
            // 
            this.checkNow.AutoSize = true;
            this.checkNow.Location = new System.Drawing.Point(15, 99);
            this.checkNow.Name = "checkNow";
            this.checkNow.Size = new System.Drawing.Size(62, 17);
            this.checkNow.TabIndex = 59;
            this.checkNow.Text = "Сейчас";
            this.checkNow.UseVisualStyleBackColor = true;
            this.checkNow.CheckedChanged += new System.EventHandler(this.checkNow_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Минута:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Час:";
            // 
            // tbMinutes
            // 
            this.tbMinutes.Location = new System.Drawing.Point(270, 118);
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.Size = new System.Drawing.Size(23, 20);
            this.tbMinutes.TabIndex = 56;
            this.tbMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinutes_KeyPress);
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(270, 92);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(23, 20);
            this.tbHours.TabIndex = 55;
            this.tbHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHours_KeyPress);
            // 
            // AddToSupplyTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 191);
            this.Controls.Add(this.checkNow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMinutes);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbFuelType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supplyDateTimePick);
            this.Controls.Add(this.tbFuelAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddToSupplyTableForm";
            this.Text = "Добавление отчета о поставке топлива";
            this.Load += new System.EventHandler(this.addToSupplyTableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFuelAmount;
        private System.Windows.Forms.DateTimePicker supplyDateTimePick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFuelType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkNow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMinutes;
        private System.Windows.Forms.TextBox tbHours;
    }
}