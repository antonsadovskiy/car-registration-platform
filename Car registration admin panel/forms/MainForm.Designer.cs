
namespace Car_registration_admin_panel
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.isAdminLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.searchByRegionCodeCombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchByNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchBySeriesTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.carsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clearFiltersButton = new Guna.UI2.WinForms.Guna2Button();
            this.editUserButton = new Guna.UI2.WinForms.Guna2Button();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteCarButton = new Guna.UI2.WinForms.Guna2Button();
            this.allUsersButton = new Guna.UI2.WinForms.Guna2Button();
            this.registrationRequestsButton = new Guna.UI2.WinForms.Guna2Button();
            this.openCarFormButton = new Guna.UI2.WinForms.Guna2Button();
            this.addCarButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО:";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameLabel.Location = new System.Drawing.Point(113, 17);
            this.fullnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(35, 13);
            this.fullnameLabel.TabIndex = 2;
            this.fullnameLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата рождения:";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateLabel.Location = new System.Drawing.Point(164, 35);
            this.birthDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(35, 13);
            this.birthDateLabel.TabIndex = 5;
            this.birthDateLabel.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(73, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Почта:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(116, 55);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Моб.тел.:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(68, 75);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(35, 13);
            this.phoneLabel.TabIndex = 9;
            this.phoneLabel.Text = "label5";
            // 
            // isAdminLabel
            // 
            this.isAdminLabel.AutoSize = true;
            this.isAdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isAdminLabel.Location = new System.Drawing.Point(78, 95);
            this.isAdminLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isAdminLabel.Name = "isAdminLabel";
            this.isAdminLabel.Size = new System.Drawing.Size(86, 13);
            this.isAdminLabel.TabIndex = 12;
            this.isAdminLabel.Text = "Администратор";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(12, 95);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(68, 13);
            this.statusLabel.TabIndex = 11;
            this.statusLabel.Text = "Должность:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Поиск";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 176);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Формат ввода: XXXX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 176);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Формат ввода: XX";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(329, 176);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Формат ввода: 0-7";
            // 
            // avatar
            // 
            this.avatar.Location = new System.Drawing.Point(12, 12);
            this.avatar.Margin = new System.Windows.Forms.Padding(2);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(57, 56);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 31;
            this.avatar.TabStop = false;
            // 
            // searchByRegionCodeCombobox
            // 
            this.searchByRegionCodeCombobox.BackColor = System.Drawing.Color.Transparent;
            this.searchByRegionCodeCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.searchByRegionCodeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByRegionCodeCombobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchByRegionCodeCombobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchByRegionCodeCombobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchByRegionCodeCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.searchByRegionCodeCombobox.ItemHeight = 30;
            this.searchByRegionCodeCombobox.Items.AddRange(new object[] {
            "",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.searchByRegionCodeCombobox.Location = new System.Drawing.Point(332, 192);
            this.searchByRegionCodeCombobox.Name = "searchByRegionCodeCombobox";
            this.searchByRegionCodeCombobox.Size = new System.Drawing.Size(150, 36);
            this.searchByRegionCodeCombobox.TabIndex = 35;
            this.searchByRegionCodeCombobox.SelectedValueChanged += new System.EventHandler(this.changeRegionCodeValueHandler);
            this.searchByRegionCodeCombobox.TextChanged += new System.EventHandler(this.changeRegionCodeValueHandler);
            // 
            // searchByNumberTextBox
            // 
            this.searchByNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchByNumberTextBox.DefaultText = "";
            this.searchByNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchByNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchByNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchByNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchByNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchByNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchByNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchByNumberTextBox.Location = new System.Drawing.Point(12, 192);
            this.searchByNumberTextBox.MaxLength = 4;
            this.searchByNumberTextBox.Name = "searchByNumberTextBox";
            this.searchByNumberTextBox.PasswordChar = '\0';
            this.searchByNumberTextBox.PlaceholderText = "Регистрационный номер";
            this.searchByNumberTextBox.SelectedText = "";
            this.searchByNumberTextBox.Size = new System.Drawing.Size(163, 36);
            this.searchByNumberTextBox.TabIndex = 36;
            this.searchByNumberTextBox.TextChanged += new System.EventHandler(this.changeNumberValueHandler);
            // 
            // searchBySeriesTextBox
            // 
            this.searchBySeriesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBySeriesTextBox.DefaultText = "";
            this.searchBySeriesTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBySeriesTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBySeriesTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBySeriesTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBySeriesTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBySeriesTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBySeriesTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBySeriesTextBox.Location = new System.Drawing.Point(181, 192);
            this.searchBySeriesTextBox.MaxLength = 2;
            this.searchBySeriesTextBox.Name = "searchBySeriesTextBox";
            this.searchBySeriesTextBox.PasswordChar = '\0';
            this.searchBySeriesTextBox.PlaceholderText = "Серия";
            this.searchBySeriesTextBox.SelectedText = "";
            this.searchBySeriesTextBox.Size = new System.Drawing.Size(145, 36);
            this.searchBySeriesTextBox.TabIndex = 37;
            this.searchBySeriesTextBox.TextChanged += new System.EventHandler(this.changeSeriesValueHandler);
            // 
            // carsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.carsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.carsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.carsDataGridView.ColumnHeadersHeight = 32;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.carsDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.carsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.carsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.carsDataGridView.Location = new System.Drawing.Point(12, 234);
            this.carsDataGridView.MultiSelect = false;
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.carsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.carsDataGridView.RowHeadersVisible = false;
            this.carsDataGridView.RowTemplate.Height = 26;
            this.carsDataGridView.Size = new System.Drawing.Size(775, 249);
            this.carsDataGridView.TabIndex = 38;
            this.carsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.carsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.carsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.carsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.carsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.carsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.carsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.carsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.carsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.carsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.carsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.carsDataGridView.ThemeStyle.HeaderStyle.Height = 32;
            this.carsDataGridView.ThemeStyle.ReadOnly = true;
            this.carsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.carsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.carsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.carsDataGridView.ThemeStyle.RowsStyle.Height = 26;
            this.carsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.carsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.carsDataGridView.SelectionChanged += new System.EventHandler(this.selectRowHandler);
            // 
            // clearFiltersButton
            // 
            this.clearFiltersButton.BorderRadius = 2;
            this.clearFiltersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFiltersButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearFiltersButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearFiltersButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearFiltersButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearFiltersButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearFiltersButton.ForeColor = System.Drawing.Color.White;
            this.clearFiltersButton.Image = global::Car_registration_admin_panel.Properties.Resources.clear_filters;
            this.clearFiltersButton.IndicateFocus = true;
            this.clearFiltersButton.Location = new System.Drawing.Point(488, 192);
            this.clearFiltersButton.Name = "clearFiltersButton";
            this.clearFiltersButton.Size = new System.Drawing.Size(36, 36);
            this.clearFiltersButton.TabIndex = 39;
            this.clearFiltersButton.Click += new System.EventHandler(this.clearFiltersButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.BorderRadius = 2;
            this.editUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editUserButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editUserButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editUserButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editUserButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editUserButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editUserButton.ForeColor = System.Drawing.Color.White;
            this.editUserButton.IndicateFocus = true;
            this.editUserButton.Location = new System.Drawing.Point(516, 12);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(180, 32);
            this.editUserButton.TabIndex = 40;
            this.editUserButton.Text = "Редактировать профиль";
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BorderRadius = 2;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.FillColor = System.Drawing.Color.SteelBlue;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = global::Car_registration_admin_panel.Properties.Resources.exit;
            this.exitButton.IndicateFocus = true;
            this.exitButton.Location = new System.Drawing.Point(702, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 32);
            this.exitButton.TabIndex = 43;
            this.exitButton.Text = "Выйти";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // deleteCarButton
            // 
            this.deleteCarButton.BorderRadius = 2;
            this.deleteCarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCarButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteCarButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteCarButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteCarButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteCarButton.FillColor = System.Drawing.Color.Red;
            this.deleteCarButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteCarButton.ForeColor = System.Drawing.Color.White;
            this.deleteCarButton.IndicateFocus = true;
            this.deleteCarButton.Location = new System.Drawing.Point(607, 489);
            this.deleteCarButton.Name = "deleteCarButton";
            this.deleteCarButton.Size = new System.Drawing.Size(180, 32);
            this.deleteCarButton.TabIndex = 44;
            this.deleteCarButton.Text = "Удалить автомобиль";
            this.deleteCarButton.Click += new System.EventHandler(this.deleteCarButton_Click);
            // 
            // allUsersButton
            // 
            this.allUsersButton.BorderRadius = 2;
            this.allUsersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allUsersButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.allUsersButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.allUsersButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.allUsersButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.allUsersButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.allUsersButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.allUsersButton.ForeColor = System.Drawing.Color.White;
            this.allUsersButton.IndicateFocus = true;
            this.allUsersButton.Location = new System.Drawing.Point(516, 71);
            this.allUsersButton.Name = "allUsersButton";
            this.allUsersButton.Size = new System.Drawing.Size(271, 32);
            this.allUsersButton.TabIndex = 45;
            this.allUsersButton.Text = "Все пользователи";
            this.allUsersButton.Click += new System.EventHandler(this.allUsersButton_Click);
            // 
            // registrationRequestsButton
            // 
            this.registrationRequestsButton.BorderRadius = 2;
            this.registrationRequestsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationRequestsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registrationRequestsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registrationRequestsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registrationRequestsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registrationRequestsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registrationRequestsButton.ForeColor = System.Drawing.Color.White;
            this.registrationRequestsButton.IndicateFocus = true;
            this.registrationRequestsButton.Location = new System.Drawing.Point(516, 110);
            this.registrationRequestsButton.Name = "registrationRequestsButton";
            this.registrationRequestsButton.Size = new System.Drawing.Size(271, 32);
            this.registrationRequestsButton.TabIndex = 46;
            this.registrationRequestsButton.Text = "Заявки на регистрацию";
            this.registrationRequestsButton.Click += new System.EventHandler(this.registrationRequestsButton_Click);
            // 
            // openCarFormButton
            // 
            this.openCarFormButton.BackColor = System.Drawing.Color.White;
            this.openCarFormButton.BorderRadius = 2;
            this.openCarFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openCarFormButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.openCarFormButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.openCarFormButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.openCarFormButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.openCarFormButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openCarFormButton.ForeColor = System.Drawing.Color.White;
            this.openCarFormButton.Location = new System.Drawing.Point(12, 489);
            this.openCarFormButton.Name = "openCarFormButton";
            this.openCarFormButton.Size = new System.Drawing.Size(252, 32);
            this.openCarFormButton.TabIndex = 47;
            this.openCarFormButton.Text = "Информация об автомобиле";
            this.openCarFormButton.Click += new System.EventHandler(this.openCarFormButton_Click);
            // 
            // addCarButton
            // 
            this.addCarButton.BorderRadius = 2;
            this.addCarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addCarButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addCarButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addCarButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addCarButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addCarButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addCarButton.ForeColor = System.Drawing.Color.White;
            this.addCarButton.Location = new System.Drawing.Point(270, 489);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(331, 32);
            this.addCarButton.TabIndex = 48;
            this.addCarButton.Text = "Зарегистрировать автомобиль";
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 532);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.openCarFormButton);
            this.Controls.Add(this.registrationRequestsButton);
            this.Controls.Add(this.allUsersButton);
            this.Controls.Add(this.deleteCarButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.clearFiltersButton);
            this.Controls.Add(this.carsDataGridView);
            this.Controls.Add(this.searchBySeriesTextBox);
            this.Controls.Add(this.searchByNumberTextBox);
            this.Controls.Add(this.searchByRegionCodeCombobox);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.isAdminLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация ТС в ГАИ";
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label isAdminLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox avatar;
        private Guna.UI2.WinForms.Guna2ComboBox searchByRegionCodeCombobox;
        private Guna.UI2.WinForms.Guna2TextBox searchByNumberTextBox;
        private Guna.UI2.WinForms.Guna2TextBox searchBySeriesTextBox;
        private Guna.UI2.WinForms.Guna2DataGridView carsDataGridView;
        private Guna.UI2.WinForms.Guna2Button clearFiltersButton;
        private Guna.UI2.WinForms.Guna2Button editUserButton;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private Guna.UI2.WinForms.Guna2Button deleteCarButton;
        private Guna.UI2.WinForms.Guna2Button allUsersButton;
        private Guna.UI2.WinForms.Guna2Button registrationRequestsButton;
        private Guna.UI2.WinForms.Guna2Button openCarFormButton;
        private Guna.UI2.WinForms.Guna2Button addCarButton;
    }
}

