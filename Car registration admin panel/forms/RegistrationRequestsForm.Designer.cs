
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationRequestsForm));
            this.backButton = new System.Windows.Forms.Button();
            this.registrationCarsRequestsDataGridView = new System.Windows.Forms.DataGridView();
            this.registerCarButton = new System.Windows.Forms.Button();
            this.deleteRequestButton = new System.Windows.Forms.Button();
            this.noDataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registrationCarsRequestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(9, 9);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(67, 26);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // registrationCarsRequestsDataGridView
            // 
            this.registrationCarsRequestsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.registrationCarsRequestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registrationCarsRequestsDataGridView.Location = new System.Drawing.Point(9, 85);
            this.registrationCarsRequestsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registrationCarsRequestsDataGridView.Name = "registrationCarsRequestsDataGridView";
            this.registrationCarsRequestsDataGridView.RowHeadersWidth = 51;
            this.registrationCarsRequestsDataGridView.RowTemplate.Height = 24;
            this.registrationCarsRequestsDataGridView.Size = new System.Drawing.Size(761, 274);
            this.registrationCarsRequestsDataGridView.TabIndex = 12;
            this.registrationCarsRequestsDataGridView.SelectionChanged += new System.EventHandler(this.selectRowHandler);
            // 
            // registerCarButton
            // 
            this.registerCarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerCarButton.Enabled = false;
            this.registerCarButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.registerCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerCarButton.Location = new System.Drawing.Point(9, 376);
            this.registerCarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerCarButton.Name = "registerCarButton";
            this.registerCarButton.Size = new System.Drawing.Size(196, 40);
            this.registerCarButton.TabIndex = 13;
            this.registerCarButton.Text = "Зарегистрировать автомобиль";
            this.registerCarButton.UseVisualStyleBackColor = true;
            this.registerCarButton.Click += new System.EventHandler(this.registerCarButton_Click);
            // 
            // deleteRequestButton
            // 
            this.deleteRequestButton.BackColor = System.Drawing.Color.Red;
            this.deleteRequestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteRequestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRequestButton.ForeColor = System.Drawing.Color.White;
            this.deleteRequestButton.Location = new System.Drawing.Point(618, 376);
            this.deleteRequestButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteRequestButton.Name = "deleteRequestButton";
            this.deleteRequestButton.Size = new System.Drawing.Size(152, 40);
            this.deleteRequestButton.TabIndex = 14;
            this.deleteRequestButton.Text = "Удалить заявку";
            this.deleteRequestButton.UseVisualStyleBackColor = false;
            this.deleteRequestButton.Click += new System.EventHandler(this.deleteRequestButton_Click);
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
            // RegistrationRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 426);
            this.Controls.Add(this.noDataLabel);
            this.Controls.Add(this.deleteRequestButton);
            this.Controls.Add(this.registerCarButton);
            this.Controls.Add(this.registrationCarsRequestsDataGridView);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistrationRequestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявки на регистрацию";
            ((System.ComponentModel.ISupportInitialize)(this.registrationCarsRequestsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView registrationCarsRequestsDataGridView;
        private System.Windows.Forms.Button registerCarButton;
        private System.Windows.Forms.Button deleteRequestButton;
        private System.Windows.Forms.Label noDataLabel;
    }
}