
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
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.state_vehicle_inspection_dbDataSet = new Car_registration_admin_panel.state_vehicle_inspection_dbDataSet();
            this.usersTableAdapter = new Car_registration_admin_panel.state_vehicle_inspection_dbDataSetTableAdapters.usersTableAdapter();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ownerFIOLabel = new System.Windows.Forms.Label();
            this.registerCarButton = new Guna.UI2.WinForms.Guna2Button();
            this.leaveRequestButton = new Guna.UI2.WinForms.Guna2Button();
            this.carRegionCodeCombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.carSeriesTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.carNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.carModelTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.carYearTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.carMileageTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.carColorTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ownerComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.state_vehicle_inspection_dbDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.ownerLabel.Location = new System.Drawing.Point(12, 61);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(56, 13);
            this.ownerLabel.TabIndex = 1;
            this.ownerLabel.Text = "Владелец";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(286, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Формат ввода: 0-7";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(140, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Формат ввода: XX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Формат ввода: XXXX";
            // 
            // ownerFIOLabel
            // 
            this.ownerFIOLabel.AutoSize = true;
            this.ownerFIOLabel.Location = new System.Drawing.Point(89, 61);
            this.ownerFIOLabel.Name = "ownerFIOLabel";
            this.ownerFIOLabel.Size = new System.Drawing.Size(35, 13);
            this.ownerFIOLabel.TabIndex = 38;
            this.ownerFIOLabel.Text = "label5";
            // 
            // registerCarButton
            // 
            this.registerCarButton.BorderRadius = 2;
            this.registerCarButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerCarButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerCarButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerCarButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerCarButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.registerCarButton.ForeColor = System.Drawing.Color.White;
            this.registerCarButton.Location = new System.Drawing.Point(11, 400);
            this.registerCarButton.Name = "registerCarButton";
            this.registerCarButton.Size = new System.Drawing.Size(415, 38);
            this.registerCarButton.TabIndex = 41;
            this.registerCarButton.Text = "Зарегистрировать";
            this.registerCarButton.Click += new System.EventHandler(this.registerCarButton_Click);
            // 
            // leaveRequestButton
            // 
            this.leaveRequestButton.BorderRadius = 2;
            this.leaveRequestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leaveRequestButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.leaveRequestButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.leaveRequestButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.leaveRequestButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.leaveRequestButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.leaveRequestButton.ForeColor = System.Drawing.Color.White;
            this.leaveRequestButton.Location = new System.Drawing.Point(11, 400);
            this.leaveRequestButton.Name = "leaveRequestButton";
            this.leaveRequestButton.Size = new System.Drawing.Size(415, 38);
            this.leaveRequestButton.TabIndex = 42;
            this.leaveRequestButton.Text = "Оставить заявку";
            this.leaveRequestButton.Click += new System.EventHandler(this.leaveRequestButton_Click);
            // 
            // carRegionCodeCombobox
            // 
            this.carRegionCodeCombobox.BackColor = System.Drawing.Color.Transparent;
            this.carRegionCodeCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carRegionCodeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carRegionCodeCombobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carRegionCodeCombobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carRegionCodeCombobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.carRegionCodeCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.carRegionCodeCombobox.ItemHeight = 30;
            this.carRegionCodeCombobox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.carRegionCodeCombobox.Location = new System.Drawing.Point(289, 308);
            this.carRegionCodeCombobox.Name = "carRegionCodeCombobox";
            this.carRegionCodeCombobox.Size = new System.Drawing.Size(137, 36);
            this.carRegionCodeCombobox.TabIndex = 43;
            // 
            // carSeriesTextBox
            // 
            this.carSeriesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carSeriesTextBox.DefaultText = "";
            this.carSeriesTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.carSeriesTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.carSeriesTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carSeriesTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carSeriesTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carSeriesTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.carSeriesTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carSeriesTextBox.Location = new System.Drawing.Point(143, 308);
            this.carSeriesTextBox.MaxLength = 2;
            this.carSeriesTextBox.Name = "carSeriesTextBox";
            this.carSeriesTextBox.PasswordChar = '\0';
            this.carSeriesTextBox.PlaceholderText = "Серия";
            this.carSeriesTextBox.SelectedText = "";
            this.carSeriesTextBox.Size = new System.Drawing.Size(140, 36);
            this.carSeriesTextBox.TabIndex = 44;
            // 
            // carNumberTextBox
            // 
            this.carNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carNumberTextBox.DefaultText = "";
            this.carNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.carNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.carNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.carNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carNumberTextBox.Location = new System.Drawing.Point(11, 308);
            this.carNumberTextBox.MaxLength = 4;
            this.carNumberTextBox.Name = "carNumberTextBox";
            this.carNumberTextBox.PasswordChar = '\0';
            this.carNumberTextBox.PlaceholderText = "Номер";
            this.carNumberTextBox.SelectedText = "";
            this.carNumberTextBox.Size = new System.Drawing.Size(126, 36);
            this.carNumberTextBox.TabIndex = 45;
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carModelTextBox.DefaultText = "";
            this.carModelTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.carModelTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.carModelTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carModelTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carModelTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carModelTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.carModelTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carModelTextBox.Location = new System.Drawing.Point(11, 108);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.PasswordChar = '\0';
            this.carModelTextBox.PlaceholderText = "Модель";
            this.carModelTextBox.SelectedText = "";
            this.carModelTextBox.Size = new System.Drawing.Size(414, 35);
            this.carModelTextBox.TabIndex = 46;
            // 
            // carYearTextBox
            // 
            this.carYearTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carYearTextBox.DefaultText = "";
            this.carYearTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.carYearTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.carYearTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carYearTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carYearTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carYearTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.carYearTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carYearTextBox.Location = new System.Drawing.Point(11, 149);
            this.carYearTextBox.Name = "carYearTextBox";
            this.carYearTextBox.PasswordChar = '\0';
            this.carYearTextBox.PlaceholderText = "Год выпуска";
            this.carYearTextBox.SelectedText = "";
            this.carYearTextBox.Size = new System.Drawing.Size(414, 35);
            this.carYearTextBox.TabIndex = 47;
            // 
            // carMileageTextBox
            // 
            this.carMileageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carMileageTextBox.DefaultText = "";
            this.carMileageTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.carMileageTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.carMileageTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carMileageTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carMileageTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carMileageTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.carMileageTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carMileageTextBox.Location = new System.Drawing.Point(11, 190);
            this.carMileageTextBox.Name = "carMileageTextBox";
            this.carMileageTextBox.PasswordChar = '\0';
            this.carMileageTextBox.PlaceholderText = "Пробег";
            this.carMileageTextBox.SelectedText = "";
            this.carMileageTextBox.Size = new System.Drawing.Size(413, 35);
            this.carMileageTextBox.TabIndex = 48;
            // 
            // carColorTextBox
            // 
            this.carColorTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carColorTextBox.DefaultText = "";
            this.carColorTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.carColorTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.carColorTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carColorTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carColorTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carColorTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.carColorTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carColorTextBox.Location = new System.Drawing.Point(11, 231);
            this.carColorTextBox.Name = "carColorTextBox";
            this.carColorTextBox.PasswordChar = '\0';
            this.carColorTextBox.PlaceholderText = "Цвет";
            this.carColorTextBox.SelectedText = "";
            this.carColorTextBox.Size = new System.Drawing.Size(413, 35);
            this.carColorTextBox.TabIndex = 49;
            // 
            // ownerComboBox
            // 
            this.ownerComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ownerComboBox.DataSource = this.usersBindingSource;
            this.ownerComboBox.DisplayMember = "surname";
            this.ownerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ownerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownerComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ownerComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ownerComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ownerComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ownerComboBox.ItemHeight = 30;
            this.ownerComboBox.Location = new System.Drawing.Point(74, 50);
            this.ownerComboBox.Name = "ownerComboBox";
            this.ownerComboBox.Size = new System.Drawing.Size(350, 36);
            this.ownerComboBox.TabIndex = 50;
            this.ownerComboBox.ValueMember = "userId";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 2;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Car_registration_admin_panel.Properties.Resources.left_arrow;
            this.guna2Button1.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button1.Location = new System.Drawing.Point(11, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(70, 26);
            this.guna2Button1.TabIndex = 51;
            this.guna2Button1.Text = "Назад";
            this.guna2Button1.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ownerComboBox);
            this.Controls.Add(this.carColorTextBox);
            this.Controls.Add(this.carMileageTextBox);
            this.Controls.Add(this.carYearTextBox);
            this.Controls.Add(this.carModelTextBox);
            this.Controls.Add(this.carNumberTextBox);
            this.Controls.Add(this.carSeriesTextBox);
            this.Controls.Add(this.carRegionCodeCombobox);
            this.Controls.Add(this.leaveRequestButton);
            this.Controls.Add(this.registerCarButton);
            this.Controls.Add(this.ownerFIOLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ownerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private state_vehicle_inspection_dbDataSet state_vehicle_inspection_dbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private state_vehicle_inspection_dbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ownerFIOLabel;
        private Guna.UI2.WinForms.Guna2Button registerCarButton;
        private Guna.UI2.WinForms.Guna2Button leaveRequestButton;
        private Guna.UI2.WinForms.Guna2ComboBox carRegionCodeCombobox;
        private Guna.UI2.WinForms.Guna2TextBox carSeriesTextBox;
        private Guna.UI2.WinForms.Guna2TextBox carNumberTextBox;
        private Guna.UI2.WinForms.Guna2TextBox carModelTextBox;
        private Guna.UI2.WinForms.Guna2TextBox carYearTextBox;
        private Guna.UI2.WinForms.Guna2TextBox carMileageTextBox;
        private Guna.UI2.WinForms.Guna2TextBox carColorTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox ownerComboBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}