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
            this.SupplyAmountTextBox = new System.Windows.Forms.TextBox();
            this.SupplyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SupplyTypeLabel = new System.Windows.Forms.Label();
            this.SupplyAmountLabel = new System.Windows.Forms.Label();
            this.SupplyDateLabel = new System.Windows.Forms.Label();
            this.SupplyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AddDealButton = new System.Windows.Forms.Button();
            this.CancelActionButton = new System.Windows.Forms.Button();
            this.NowCheckBox = new System.Windows.Forms.CheckBox();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.MinutesTextBox = new System.Windows.Forms.TextBox();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.StationLabel = new System.Windows.Forms.Label();
            this.StationComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SupplyAmountTextBox
            // 
            this.SupplyAmountTextBox.Location = new System.Drawing.Point(148, 69);
            this.SupplyAmountTextBox.Name = "SupplyAmountTextBox";
            this.SupplyAmountTextBox.Size = new System.Drawing.Size(146, 20);
            this.SupplyAmountTextBox.TabIndex = 1;
            this.SupplyAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SupplyAmountTextBox_KeyPress);
            // 
            // SupplyDatePicker
            // 
            this.SupplyDatePicker.Location = new System.Drawing.Point(147, 95);
            this.SupplyDatePicker.Name = "SupplyDatePicker";
            this.SupplyDatePicker.Size = new System.Drawing.Size(146, 20);
            this.SupplyDatePicker.TabIndex = 2;
            // 
            // SupplyTypeLabel
            // 
            this.SupplyTypeLabel.AutoSize = true;
            this.SupplyTypeLabel.Location = new System.Drawing.Point(9, 45);
            this.SupplyTypeLabel.Name = "SupplyTypeLabel";
            this.SupplyTypeLabel.Size = new System.Drawing.Size(67, 13);
            this.SupplyTypeLabel.TabIndex = 3;
            this.SupplyTypeLabel.Text = "Тип товара:";
            // 
            // SupplyAmountLabel
            // 
            this.SupplyAmountLabel.AutoSize = true;
            this.SupplyAmountLabel.Location = new System.Drawing.Point(9, 72);
            this.SupplyAmountLabel.Name = "SupplyAmountLabel";
            this.SupplyAmountLabel.Size = new System.Drawing.Size(110, 13);
            this.SupplyAmountLabel.TabIndex = 4;
            this.SupplyAmountLabel.Text = "Количество товара: ";
            // 
            // SupplyDateLabel
            // 
            this.SupplyDateLabel.AutoSize = true;
            this.SupplyDateLabel.Location = new System.Drawing.Point(9, 101);
            this.SupplyDateLabel.Name = "SupplyDateLabel";
            this.SupplyDateLabel.Size = new System.Drawing.Size(86, 13);
            this.SupplyDateLabel.TabIndex = 5;
            this.SupplyDateLabel.Text = "Дата поставки:";
            // 
            // SupplyTypeComboBox
            // 
            this.SupplyTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SupplyTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SupplyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplyTypeComboBox.FormattingEnabled = true;
            this.SupplyTypeComboBox.Location = new System.Drawing.Point(148, 42);
            this.SupplyTypeComboBox.Name = "SupplyTypeComboBox";
            this.SupplyTypeComboBox.Size = new System.Drawing.Size(146, 21);
            this.SupplyTypeComboBox.TabIndex = 6;
            // 
            // AddDealButton
            // 
            this.AddDealButton.Location = new System.Drawing.Point(218, 204);
            this.AddDealButton.Name = "AddDealButton";
            this.AddDealButton.Size = new System.Drawing.Size(75, 23);
            this.AddDealButton.TabIndex = 7;
            this.AddDealButton.Text = "Ок";
            this.AddDealButton.UseVisualStyleBackColor = true;
            this.AddDealButton.Click += new System.EventHandler(this.AddDealButton_Click);
            // 
            // CancelActionButton
            // 
            this.CancelActionButton.Location = new System.Drawing.Point(125, 204);
            this.CancelActionButton.Name = "CancelActionButton";
            this.CancelActionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelActionButton.TabIndex = 8;
            this.CancelActionButton.Text = "Отмена";
            this.CancelActionButton.UseVisualStyleBackColor = true;
            this.CancelActionButton.Click += new System.EventHandler(this.CancelActionButton_Click);
            // 
            // NowCheckBox
            // 
            this.NowCheckBox.AutoSize = true;
            this.NowCheckBox.Location = new System.Drawing.Point(12, 143);
            this.NowCheckBox.Name = "NowCheckBox";
            this.NowCheckBox.Size = new System.Drawing.Size(62, 17);
            this.NowCheckBox.TabIndex = 59;
            this.NowCheckBox.Text = "Сейчас";
            this.NowCheckBox.UseVisualStyleBackColor = true;
            this.NowCheckBox.CheckedChanged += new System.EventHandler(this.NowCheckBox_CheckedChanged);
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Location = new System.Drawing.Point(215, 170);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(47, 13);
            this.MinutesLabel.TabIndex = 58;
            this.MinutesLabel.Text = "Минута:";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(215, 143);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(30, 13);
            this.HoursLabel.TabIndex = 57;
            this.HoursLabel.Text = "Час:";
            // 
            // MinutesTextBox
            // 
            this.MinutesTextBox.Location = new System.Drawing.Point(268, 167);
            this.MinutesTextBox.Name = "MinutesTextBox";
            this.MinutesTextBox.Size = new System.Drawing.Size(23, 20);
            this.MinutesTextBox.TabIndex = 56;
            this.MinutesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinutesTextBox_KeyPress);
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Location = new System.Drawing.Point(268, 140);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(23, 20);
            this.HoursTextBox.TabIndex = 55;
            this.HoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoursTextBox_KeyPress);
            // 
            // StationLabel
            // 
            this.StationLabel.AutoSize = true;
            this.StationLabel.Location = new System.Drawing.Point(9, 18);
            this.StationLabel.Name = "StationLabel";
            this.StationLabel.Size = new System.Drawing.Size(52, 13);
            this.StationLabel.TabIndex = 60;
            this.StationLabel.Text = "Станция:";
            // 
            // StationComboBox
            // 
            this.StationComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.StationComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.StationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StationComboBox.FormattingEnabled = true;
            this.StationComboBox.Location = new System.Drawing.Point(148, 15);
            this.StationComboBox.Name = "StationComboBox";
            this.StationComboBox.Size = new System.Drawing.Size(145, 21);
            this.StationComboBox.TabIndex = 61;
            // 
            // AddToSupplyTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 248);
            this.Controls.Add(this.StationComboBox);
            this.Controls.Add(this.StationLabel);
            this.Controls.Add(this.NowCheckBox);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.MinutesTextBox);
            this.Controls.Add(this.HoursTextBox);
            this.Controls.Add(this.CancelActionButton);
            this.Controls.Add(this.AddDealButton);
            this.Controls.Add(this.SupplyTypeComboBox);
            this.Controls.Add(this.SupplyDateLabel);
            this.Controls.Add(this.SupplyAmountLabel);
            this.Controls.Add(this.SupplyTypeLabel);
            this.Controls.Add(this.SupplyDatePicker);
            this.Controls.Add(this.SupplyAmountTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddToSupplyTableForm";
            this.Text = "Добавление отчета о поставке топлива";
            this.Load += new System.EventHandler(this.AddToSupplyTableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SupplyAmountTextBox;
        private System.Windows.Forms.DateTimePicker SupplyDatePicker;
        private System.Windows.Forms.Label SupplyTypeLabel;
        private System.Windows.Forms.Label SupplyAmountLabel;
        private System.Windows.Forms.Label SupplyDateLabel;
        private System.Windows.Forms.ComboBox SupplyTypeComboBox;
        private System.Windows.Forms.Button AddDealButton;
        private System.Windows.Forms.Button CancelActionButton;
        private System.Windows.Forms.CheckBox NowCheckBox;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.TextBox MinutesTextBox;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.Label StationLabel;
        private System.Windows.Forms.ComboBox StationComboBox;
    }
}