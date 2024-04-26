
namespace Car_registration_admin_panel.forms
{
    partial class AddCarForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCarForm));
            this.ownerComboBox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.state_vehicle_inspection_dbDataSet = new Car_registration_admin_panel.state_vehicle_inspection_dbDataSet();
            this.usersTableAdapter = new Car_registration_admin_panel.state_vehicle_inspection_dbDataSetTableAdapters.usersTableAdapter();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.carYearTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carMileageTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.carColorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.carRegionCodeCombobox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.carSeriesTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.carNumberTextBox = new System.Windows.Forms.TextBox();
            this.leaveRequestButton = new System.Windows.Forms.Button();
            this.ownerFIOLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.registerCarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.state_vehicle_inspection_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ownerComboBox
            // 
            this.ownerComboBox.DataSource = this.usersBindingSource;
            this.ownerComboBox.DisplayMember = "surname";
            this.ownerComboBox.FormattingEnabled = true;
            this.ownerComboBox.Location = new System.Drawing.Point(120, 71);
            this.ownerComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ownerComboBox.Name = "ownerComboBox";
            this.ownerComboBox.Size = new System.Drawing.Size(446, 24);
            this.ownerComboBox.TabIndex = 0;
            this.ownerComboBox.ValueMember = "userId";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.state_vehicle_inspection_dbDataSet;
            // 
            // state_vehicle_inspection_dbDataSet
            // 
            this.state_vehicle_inspection_dbDataSet.DataSetName = "state_vehicle_inspection_dbDataSet";
            this.state_vehicle_inspection_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerLabel.Location = new System.Drawing.Point(16, 75);
            this.ownerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(73, 17);
            this.ownerLabel.TabIndex = 1;
            this.ownerLabel.Text = "Владелец";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Модель";
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Location = new System.Drawing.Point(120, 113);
            this.carModelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(446, 22);
            this.carModelTextBox.TabIndex = 3;
            // 
            // carYearTextBox
            // 
            this.carYearTextBox.Location = new System.Drawing.Point(120, 162);
            this.carYearTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carYearTextBox.Name = "carYearTextBox";
            this.carYearTextBox.Size = new System.Drawing.Size(446, 22);
            this.carYearTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Год выпуска";
            // 
            // carMileageTextBox
            // 
            this.carMileageTextBox.Location = new System.Drawing.Point(120, 207);
            this.carMileageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carMileageTextBox.Name = "carMileageTextBox";
            this.carMileageTextBox.Size = new System.Drawing.Size(446, 22);
            this.carMileageTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пробег";
            // 
            // carColorTextBox
            // 
            this.carColorTextBox.Location = new System.Drawing.Point(120, 252);
            this.carColorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carColorTextBox.Name = "carColorTextBox";
            this.carColorTextBox.Size = new System.Drawing.Size(446, 22);
            this.carColorTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цвет";
            // 
            // carRegionCodeCombobox
            // 
            this.carRegionCodeCombobox.Cursor = System.Windows.Forms.Cursors.Default;
            this.carRegionCodeCombobox.FormattingEnabled = true;
            this.carRegionCodeCombobox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.carRegionCodeCombobox.Location = new System.Drawing.Point(385, 334);
            this.carRegionCodeCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carRegionCodeCombobox.Name = "carRegionCodeCombobox";
            this.carRegionCodeCombobox.Size = new System.Drawing.Size(181, 24);
            this.carRegionCodeCombobox.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(381, 294);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 18);
            this.label12.TabIndex = 35;
            this.label12.Text = "Код региона";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(381, 313);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Формат ввода: 0-7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(187, 295);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 18);
            this.label10.TabIndex = 33;
            this.label10.Text = "Серия";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 314);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Формат ввода: XX";
            // 
            // carSeriesTextBox
            // 
            this.carSeriesTextBox.Location = new System.Drawing.Point(191, 334);
            this.carSeriesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carSeriesTextBox.MaxLength = 2;
            this.carSeriesTextBox.Name = "carSeriesTextBox";
            this.carSeriesTextBox.Size = new System.Drawing.Size(186, 22);
            this.carSeriesTextBox.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(16, 294);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "Номер";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 314);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Формат ввода: XXXX";
            // 
            // carNumberTextBox
            // 
            this.carNumberTextBox.Location = new System.Drawing.Point(20, 334);
            this.carNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carNumberTextBox.MaxLength = 4;
            this.carNumberTextBox.Name = "carNumberTextBox";
            this.carNumberTextBox.Size = new System.Drawing.Size(163, 22);
            this.carNumberTextBox.TabIndex = 28;
            // 
            // leaveRequestButton
            // 
            this.leaveRequestButton.Location = new System.Drawing.Point(17, 496);
            this.leaveRequestButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leaveRequestButton.Name = "leaveRequestButton";
            this.leaveRequestButton.Size = new System.Drawing.Size(549, 43);
            this.leaveRequestButton.TabIndex = 37;
            this.leaveRequestButton.Text = "Оставить заявку";
            this.leaveRequestButton.UseVisualStyleBackColor = true;
            this.leaveRequestButton.Click += new System.EventHandler(this.leaveRequestButton_Click);
            // 
            // ownerFIOLabel
            // 
            this.ownerFIOLabel.AutoSize = true;
            this.ownerFIOLabel.Location = new System.Drawing.Point(124, 75);
            this.ownerFIOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ownerFIOLabel.Name = "ownerFIOLabel";
            this.ownerFIOLabel.Size = new System.Drawing.Size(46, 17);
            this.ownerFIOLabel.TabIndex = 38;
            this.ownerFIOLabel.Text = "label5";
            // 
            // backButton
            // 
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(15, 14);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(96, 32);
            this.backButton.TabIndex = 39;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // registerCarButton
            // 
            this.registerCarButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.registerCarButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.registerCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerCarButton.ForeColor = System.Drawing.Color.White;
            this.registerCarButton.Location = new System.Drawing.Point(17, 496);
            this.registerCarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerCarButton.Name = "registerCarButton";
            this.registerCarButton.Size = new System.Drawing.Size(549, 43);
            this.registerCarButton.TabIndex = 40;
            this.registerCarButton.Text = "Зарегистрировать";
            this.registerCarButton.UseVisualStyleBackColor = false;
            this.registerCarButton.Click += new System.EventHandler(this.registerCarButton_Click);
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 554);
            this.Controls.Add(this.registerCarButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ownerFIOLabel);
            this.Controls.Add(this.leaveRequestButton);
            this.Controls.Add(this.carRegionCodeCombobox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.carSeriesTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.carNumberTextBox);
            this.Controls.Add(this.carColorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.carMileageTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carYearTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carModelTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ownerLabel);
            this.Controls.Add(this.ownerComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация нового автомобиля";
            this.Load += new System.EventHandler(this.AddCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.state_vehicle_inspection_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ownerComboBox;
        private state_vehicle_inspection_dbDataSet state_vehicle_inspection_dbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private state_vehicle_inspection_dbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox carModelTextBox;
        private System.Windows.Forms.TextBox carYearTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carMileageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox carColorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox carRegionCodeCombobox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox carSeriesTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox carNumberTextBox;
        private System.Windows.Forms.Button leaveRequestButton;
        private System.Windows.Forms.Label ownerFIOLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button registerCarButton;
    }
}