
namespace Car_registration_admin_panel.forms
{
    partial class RegistrationRequestsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationRequestsForm));
            this.noDataLabel = new System.Windows.Forms.Label();
            this.registerCarButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteRequestButton = new Guna.UI2.WinForms.Guna2Button();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.registrationCarsRequestsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.registrationCarsRequestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // noDataLabel
            // 
            this.noDataLabel.AutoSize = true;
            this.noDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noDataLabel.Location = new System.Drawing.Point(312, 211);
            this.noDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noDataLabel.Name = "noDataLabel";
            this.noDataLabel.Size = new System.Drawing.Size(140, 17);
            this.noDataLabel.TabIndex = 15;
            this.noDataLabel.Text = "Заявки отсутствуют";
            // 
            // registerCarButton
            // 
            this.registerCarButton.BackColor = System.Drawing.Color.White;
            this.registerCarButton.BorderRadius = 2;
            this.registerCarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerCarButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerCarButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerCarButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerCarButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerCarButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registerCarButton.ForeColor = System.Drawing.Color.White;
            this.registerCarButton.Location = new System.Drawing.Point(12, 382);
            this.registerCarButton.Name = "registerCarButton";
            this.registerCarButton.Size = new System.Drawing.Size(252, 32);
            this.registerCarButton.TabIndex = 49;
            this.registerCarButton.Text = "Зарегистрировать автомобиль";
            this.registerCarButton.Click += new System.EventHandler(this.registerCarButton_Click);
            // 
            // deleteRequestButton
            // 
            this.deleteRequestButton.BorderRadius = 2;
            this.deleteRequestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteRequestButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteRequestButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteRequestButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteRequestButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteRequestButton.FillColor = System.Drawing.Color.Red;
            this.deleteRequestButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteRequestButton.ForeColor = System.Drawing.Color.White;
            this.deleteRequestButton.IndicateFocus = true;
            this.deleteRequestButton.Location = new System.Drawing.Point(587, 382);
            this.deleteRequestButton.Name = "deleteRequestButton";
            this.deleteRequestButton.Size = new System.Drawing.Size(180, 32);
            this.deleteRequestButton.TabIndex = 48;
            this.deleteRequestButton.Text = "Удалить заявку";
            this.deleteRequestButton.Click += new System.EventHandler(this.deleteRequestButton_Click);
            // 
            // backButton
            // 
            this.backButton.BorderRadius = 2;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Image = global::Car_registration_admin_panel.Properties.Resources.left_arrow;
            this.backButton.ImageSize = new System.Drawing.Size(15, 15);
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 26);
            this.backButton.TabIndex = 54;
            this.backButton.Text = "Назад";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // registrationCarsRequestsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.registrationCarsRequestsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registrationCarsRequestsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.registrationCarsRequestsDataGridView.ColumnHeadersHeight = 32;
            this.registrationCarsRequestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.registrationCarsRequestsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.registrationCarsRequestsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.registrationCarsRequestsDataGridView.Location = new System.Drawing.Point(12, 95);
            this.registrationCarsRequestsDataGridView.Name = "registrationCarsRequestsDataGridView";
            this.registrationCarsRequestsDataGridView.RowHeadersVisible = false;
            this.registrationCarsRequestsDataGridView.RowTemplate.Height = 26;
            this.registrationCarsRequestsDataGridView.Size = new System.Drawing.Size(755, 281);
            this.registrationCarsRequestsDataGridView.TabIndex = 55;
            this.registrationCarsRequestsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.registrationCarsRequestsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.registrationCarsRequestsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.registrationCarsRequestsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.registrationCarsRequestsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.registrationCarsRequestsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.registrationCarsRequestsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.registrationCarsRequestsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.registrationCarsRequestsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.registrationCarsRequestsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationCarsRequestsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.registrationCarsRequestsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.registrationCarsRequestsDataGridView.ThemeStyle.HeaderStyle.Height = 32;
            this.registrationCarsRequestsDataGridView.ThemeStyle.ReadOnly = false;
            this.registrationCarsRequestsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.registrationCarsRequestsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.registrationCarsRequestsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationCarsRequestsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.registrationCarsRequestsDataGridView.ThemeStyle.RowsStyle.Height = 26;
            this.registrationCarsRequestsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.registrationCarsRequestsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.registrationCarsRequestsDataGridView.SelectionChanged += new System.EventHandler(this.selectRowHandler);
            // 
            // RegistrationRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 426);
            this.Controls.Add(this.registrationCarsRequestsDataGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.registerCarButton);
            this.Controls.Add(this.deleteRequestButton);
            this.Controls.Add(this.noDataLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrationRequestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявки на регистрацию";
            ((System.ComponentModel.ISupportInitialize)(this.registrationCarsRequestsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label noDataLabel;
        private Guna.UI2.WinForms.Guna2Button registerCarButton;
        private Guna.UI2.WinForms.Guna2Button deleteRequestButton;
        private Guna.UI2.WinForms.Guna2Button backButton;
        private Guna.UI2.WinForms.Guna2DataGridView registrationCarsRequestsDataGridView;
    }
}