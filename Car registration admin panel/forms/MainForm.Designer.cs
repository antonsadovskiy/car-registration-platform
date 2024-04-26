
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.editUserButton = new System.Windows.Forms.Button();
            this.isAdminLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchByNumberTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.searchBySeriesTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.searchByRegionCodeCombobox = new System.Windows.Forms.ComboBox();
            this.clearFiltersButton = new System.Windows.Forms.Button();
            this.openCarFormButton = new System.Windows.Forms.Button();
            this.deleteCarButton = new System.Windows.Forms.Button();
            this.addCarButton = new System.Windows.Forms.Button();
            this.registrationRequestsButton = new System.Windows.Forms.Button();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.allUsersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Location = new System.Drawing.Point(10, 245);
            this.carsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.carsDataGridView.MultiSelect = false;
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.ReadOnly = true;
            this.carsDataGridView.RowHeadersWidth = 51;
            this.carsDataGridView.Size = new System.Drawing.Size(764, 238);
            this.carsDataGridView.TabIndex = 0;
            this.carsDataGridView.SelectionChanged += new System.EventHandler(this.selectRowHandler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО:";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameLabel.Location = new System.Drawing.Point(106, 9);
            this.fullnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(46, 17);
            this.fullnameLabel.TabIndex = 2;
            this.fullnameLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(56, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата рождения:";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateLabel.Location = new System.Drawing.Point(175, 33);
            this.birthDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(46, 17);
            this.birthDateLabel.TabIndex = 5;
            this.birthDateLabel.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Почта:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(68, 59);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 17);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Моб.тел.:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(85, 80);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(46, 17);
            this.phoneLabel.TabIndex = 9;
            this.phoneLabel.Text = "label5";
            // 
            // editUserButton
            // 
            this.editUserButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserButton.Location = new System.Drawing.Point(457, 11);
            this.editUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(202, 40);
            this.editUserButton.TabIndex = 10;
            this.editUserButton.Text = "Редактировать профиль";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // isAdminLabel
            // 
            this.isAdminLabel.AutoSize = true;
            this.isAdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isAdminLabel.Location = new System.Drawing.Point(99, 100);
            this.isAdminLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isAdminLabel.Name = "isAdminLabel";
            this.isAdminLabel.Size = new System.Drawing.Size(111, 17);
            this.isAdminLabel.TabIndex = 12;
            this.isAdminLabel.Text = "Администратор";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(10, 100);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(85, 17);
            this.statusLabel.TabIndex = 11;
            this.statusLabel.Text = "Должность:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Зарегистрированные автомобили:";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Silver;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(663, 11);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 40);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchByNumberTextBox
            // 
            this.searchByNumberTextBox.Location = new System.Drawing.Point(363, 210);
            this.searchByNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchByNumberTextBox.MaxLength = 4;
            this.searchByNumberTextBox.Name = "searchByNumberTextBox";
            this.searchByNumberTextBox.Size = new System.Drawing.Size(144, 23);
            this.searchByNumberTextBox.TabIndex = 16;
            this.searchByNumberTextBox.TextChanged += new System.EventHandler(this.changeNumberValueHandler);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(359, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Поиск";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Формат ввода: XXXX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(360, 157);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Номер";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(509, 159);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Серия";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(511, 181);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Формат ввода: XX";
            // 
            // searchBySeriesTextBox
            // 
            this.searchBySeriesTextBox.Location = new System.Drawing.Point(512, 210);
            this.searchBySeriesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBySeriesTextBox.MaxLength = 2;
            this.searchBySeriesTextBox.Name = "searchBySeriesTextBox";
            this.searchBySeriesTextBox.Size = new System.Drawing.Size(129, 23);
            this.searchBySeriesTextBox.TabIndex = 21;
            this.searchBySeriesTextBox.TextChanged += new System.EventHandler(this.changeSeriesValueHandler);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(642, 161);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "Код региона";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(642, 181);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Формат ввода: 0-7";
            // 
            // searchByRegionCodeCombobox
            // 
            this.searchByRegionCodeCombobox.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchByRegionCodeCombobox.FormattingEnabled = true;
            this.searchByRegionCodeCombobox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.searchByRegionCodeCombobox.Location = new System.Drawing.Point(645, 208);
            this.searchByRegionCodeCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.searchByRegionCodeCombobox.Name = "searchByRegionCodeCombobox";
            this.searchByRegionCodeCombobox.Size = new System.Drawing.Size(129, 25);
            this.searchByRegionCodeCombobox.TabIndex = 27;
            this.searchByRegionCodeCombobox.SelectedValueChanged += new System.EventHandler(this.changeRegionCodeValueHandler);
            this.searchByRegionCodeCombobox.TextChanged += new System.EventHandler(this.changeRegionCodeValueHandler);
            // 
            // clearFiltersButton
            // 
            this.clearFiltersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.clearFiltersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFiltersButton.Location = new System.Drawing.Point(623, 112);
            this.clearFiltersButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearFiltersButton.Name = "clearFiltersButton";
            this.clearFiltersButton.Size = new System.Drawing.Size(151, 40);
            this.clearFiltersButton.TabIndex = 28;
            this.clearFiltersButton.Text = "Очистить фильтры";
            this.clearFiltersButton.UseVisualStyleBackColor = true;
            this.clearFiltersButton.Click += new System.EventHandler(this.clearFiltersButton_Click);
            // 
            // openCarFormButton
            // 
            this.openCarFormButton.Enabled = false;
            this.openCarFormButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.openCarFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openCarFormButton.Location = new System.Drawing.Point(9, 500);
            this.openCarFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.openCarFormButton.Name = "openCarFormButton";
            this.openCarFormButton.Size = new System.Drawing.Size(221, 45);
            this.openCarFormButton.TabIndex = 29;
            this.openCarFormButton.Text = "Информация об автомобиле";
            this.openCarFormButton.UseVisualStyleBackColor = true;
            this.openCarFormButton.Click += new System.EventHandler(this.openCarFormButton_Click);
            // 
            // deleteCarButton
            // 
            this.deleteCarButton.BackColor = System.Drawing.Color.Red;
            this.deleteCarButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.deleteCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCarButton.ForeColor = System.Drawing.Color.White;
            this.deleteCarButton.Location = new System.Drawing.Point(603, 500);
            this.deleteCarButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteCarButton.Name = "deleteCarButton";
            this.deleteCarButton.Size = new System.Drawing.Size(172, 45);
            this.deleteCarButton.TabIndex = 30;
            this.deleteCarButton.Text = "Удалить автомобиль";
            this.deleteCarButton.UseVisualStyleBackColor = false;
            this.deleteCarButton.Click += new System.EventHandler(this.deleteCarButton_Click);
            // 
            // addCarButton
            // 
            this.addCarButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCarButton.Location = new System.Drawing.Point(234, 500);
            this.addCarButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(365, 45);
            this.addCarButton.TabIndex = 32;
            this.addCarButton.Text = "Зарегистрировать автомобиль";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // registrationRequestsButton
            // 
            this.registrationRequestsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.registrationRequestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationRequestsButton.Location = new System.Drawing.Point(9, 167);
            this.registrationRequestsButton.Margin = new System.Windows.Forms.Padding(2);
            this.registrationRequestsButton.Name = "registrationRequestsButton";
            this.registrationRequestsButton.Size = new System.Drawing.Size(211, 38);
            this.registrationRequestsButton.TabIndex = 33;
            this.registrationRequestsButton.Text = "Заявки на регистрацию";
            this.registrationRequestsButton.UseVisualStyleBackColor = true;
            this.registrationRequestsButton.Click += new System.EventHandler(this.registrationRequestsButton_Click);
            // 
            // avatar
            // 
            this.avatar.Location = new System.Drawing.Point(10, 10);
            this.avatar.Margin = new System.Windows.Forms.Padding(2);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(42, 41);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 31;
            this.avatar.TabStop = false;
            // 
            // allUsersButton
            // 
            this.allUsersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.allUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allUsersButton.Location = new System.Drawing.Point(9, 125);
            this.allUsersButton.Margin = new System.Windows.Forms.Padding(2);
            this.allUsersButton.Name = "allUsersButton";
            this.allUsersButton.Size = new System.Drawing.Size(211, 38);
            this.allUsersButton.TabIndex = 34;
            this.allUsersButton.Text = "Все пользователи";
            this.allUsersButton.UseVisualStyleBackColor = true;
            this.allUsersButton.Click += new System.EventHandler(this.allUsersButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 556);
            this.Controls.Add(this.allUsersButton);
            this.Controls.Add(this.registrationRequestsButton);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.deleteCarButton);
            this.Controls.Add(this.openCarFormButton);
            this.Controls.Add(this.clearFiltersButton);
            this.Controls.Add(this.searchByRegionCodeCombobox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.searchBySeriesTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchByNumberTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.isAdminLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carsDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация ТС в ГАИ";
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Label isAdminLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox searchByNumberTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchBySeriesTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox searchByRegionCodeCombobox;
        private System.Windows.Forms.Button clearFiltersButton;
        private System.Windows.Forms.Button openCarFormButton;
        private System.Windows.Forms.Button deleteCarButton;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Button registrationRequestsButton;
        private System.Windows.Forms.Button allUsersButton;
    }
}

