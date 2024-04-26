﻿
namespace Car_registration_admin_panel
{
    partial class CarInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarInfoForm));
            this.carModelLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carYearLabel = new System.Windows.Forms.Label();
            this.carNumberLabel = new System.Windows.Forms.Label();
            this.carColorLabel = new System.Windows.Forms.Label();
            this.carViolationsDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.addViolationButton = new System.Windows.Forms.Button();
            this.deleteViolationButton = new System.Windows.Forms.Button();
            this.editViolationButton = new System.Windows.Forms.Button();
            this.noDataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carViolationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carModelLabel.Location = new System.Drawing.Point(443, 23);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(35, 13);
            this.carModelLabel.TabIndex = 0;
            this.carModelLabel.Text = "label1";
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(13, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(268, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Модель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(268, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Год выпуска:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(268, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Автомобильный номер:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(268, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Цвет:";
            // 
            // carYearLabel
            // 
            this.carYearLabel.AutoSize = true;
            this.carYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carYearLabel.Location = new System.Drawing.Point(443, 49);
            this.carYearLabel.Name = "carYearLabel";
            this.carYearLabel.Size = new System.Drawing.Size(35, 13);
            this.carYearLabel.TabIndex = 6;
            this.carYearLabel.Text = "label5";
            // 
            // carNumberLabel
            // 
            this.carNumberLabel.AutoSize = true;
            this.carNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carNumberLabel.Location = new System.Drawing.Point(443, 76);
            this.carNumberLabel.Name = "carNumberLabel";
            this.carNumberLabel.Size = new System.Drawing.Size(35, 13);
            this.carNumberLabel.TabIndex = 7;
            this.carNumberLabel.Text = "label6";
            // 
            // carColorLabel
            // 
            this.carColorLabel.AutoSize = true;
            this.carColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carColorLabel.Location = new System.Drawing.Point(443, 104);
            this.carColorLabel.Name = "carColorLabel";
            this.carColorLabel.Size = new System.Drawing.Size(35, 13);
            this.carColorLabel.TabIndex = 8;
            this.carColorLabel.Text = "label7";
            // 
            // carViolationsDataGridView
            // 
            this.carViolationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.carViolationsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.carViolationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carViolationsDataGridView.Location = new System.Drawing.Point(13, 163);
            this.carViolationsDataGridView.Name = "carViolationsDataGridView";
            this.carViolationsDataGridView.ReadOnly = true;
            this.carViolationsDataGridView.RowHeadersWidth = 51;
            this.carViolationsDataGridView.Size = new System.Drawing.Size(775, 251);
            this.carViolationsDataGridView.TabIndex = 1;
            this.carViolationsDataGridView.SelectionChanged += new System.EventHandler(this.selectRowHandler);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Полученные нарушения:";
            // 
            // addViolationButton
            // 
            this.addViolationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addViolationButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addViolationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addViolationButton.Location = new System.Drawing.Point(12, 423);
            this.addViolationButton.Name = "addViolationButton";
            this.addViolationButton.Size = new System.Drawing.Size(209, 37);
            this.addViolationButton.TabIndex = 11;
            this.addViolationButton.Text = "Добавить нарушение";
            this.addViolationButton.UseVisualStyleBackColor = true;
            this.addViolationButton.Click += new System.EventHandler(this.addViolationButton_Click);
            // 
            // deleteViolationButton
            // 
            this.deleteViolationButton.BackColor = System.Drawing.Color.Red;
            this.deleteViolationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteViolationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteViolationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteViolationButton.ForeColor = System.Drawing.Color.White;
            this.deleteViolationButton.Location = new System.Drawing.Point(649, 423);
            this.deleteViolationButton.Name = "deleteViolationButton";
            this.deleteViolationButton.Size = new System.Drawing.Size(139, 37);
            this.deleteViolationButton.TabIndex = 12;
            this.deleteViolationButton.Text = "Удалить нарушение";
            this.deleteViolationButton.UseVisualStyleBackColor = false;
            this.deleteViolationButton.Click += new System.EventHandler(this.deleteViolationButton_Click);
            // 
            // editViolationButton
            // 
            this.editViolationButton.BackColor = System.Drawing.Color.White;
            this.editViolationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editViolationButton.Enabled = false;
            this.editViolationButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editViolationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editViolationButton.Location = new System.Drawing.Point(227, 423);
            this.editViolationButton.Name = "editViolationButton";
            this.editViolationButton.Size = new System.Drawing.Size(222, 37);
            this.editViolationButton.TabIndex = 13;
            this.editViolationButton.Text = "Редактировать нарушение";
            this.editViolationButton.UseVisualStyleBackColor = false;
            this.editViolationButton.Click += new System.EventHandler(this.editViolationButton_Click);
            // 
            // noDataLabel
            // 
            this.noDataLabel.AutoSize = true;
            this.noDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noDataLabel.Location = new System.Drawing.Point(316, 275);
            this.noDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noDataLabel.Name = "noDataLabel";
            this.noDataLabel.Size = new System.Drawing.Size(169, 17);
            this.noDataLabel.TabIndex = 14;
            this.noDataLabel.Text = "Нарушения отсутствуют";
            // 
            // CarInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.noDataLabel);
            this.Controls.Add(this.editViolationButton);
            this.Controls.Add(this.deleteViolationButton);
            this.Controls.Add(this.addViolationButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.carViolationsDataGridView);
            this.Controls.Add(this.carColorLabel);
            this.Controls.Add(this.carNumberLabel);
            this.Controls.Add(this.carYearLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.carModelLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация об автомобиле";
            ((System.ComponentModel.ISupportInitialize)(this.carViolationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label carYearLabel;
        private System.Windows.Forms.Label carNumberLabel;
        private System.Windows.Forms.Label carColorLabel;
        private System.Windows.Forms.DataGridView carViolationsDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addViolationButton;
        private System.Windows.Forms.Button deleteViolationButton;
        private System.Windows.Forms.Button editViolationButton;
        private System.Windows.Forms.Label noDataLabel;
    }
}