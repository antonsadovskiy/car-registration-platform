
namespace Car_registration_admin_panel.forms
{
    partial class EditViolationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditViolationForm));
            this.violationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.state_vehicle_inspection_dbDataSet = new Car_registration_admin_panel.state_vehicle_inspection_dbDataSet();
            this.violationsTableAdapter = new Car_registration_admin_panel.state_vehicle_inspection_dbDataSetTableAdapters.violationsTableAdapter();
            this.timeOfViolationDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.violationTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.editViolationButton = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.violationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.state_vehicle_inspection_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // violationsBindingSource
            // 
            this.violationsBindingSource.DataMember = "violations";
            this.violationsBindingSource.DataSource = this.state_vehicle_inspection_dbDataSet;
            // 
            // state_vehicle_inspection_dbDataSet
            // 
            this.state_vehicle_inspection_dbDataSet.DataSetName = "state_vehicle_inspection_dbDataSet";
            this.state_vehicle_inspection_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // violationsTableAdapter
            // 
            this.violationsTableAdapter.ClearBeforeFill = true;
            // 
            // timeOfViolationDateTimePicker
            // 
            this.timeOfViolationDateTimePicker.Checked = true;
            this.timeOfViolationDateTimePicker.FillColor = System.Drawing.Color.White;
            this.timeOfViolationDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeOfViolationDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.timeOfViolationDateTimePicker.Location = new System.Drawing.Point(12, 128);
            this.timeOfViolationDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeOfViolationDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeOfViolationDateTimePicker.Name = "timeOfViolationDateTimePicker";
            this.timeOfViolationDateTimePicker.Size = new System.Drawing.Size(322, 36);
            this.timeOfViolationDateTimePicker.TabIndex = 14;
            this.timeOfViolationDateTimePicker.Value = new System.DateTime(2024, 4, 26, 17, 11, 55, 729);
            // 
            // violationTypeComboBox
            // 
            this.violationTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.violationTypeComboBox.DataSource = this.violationsBindingSource;
            this.violationTypeComboBox.DisplayMember = "violationDescription";
            this.violationTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.violationTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.violationTypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.violationTypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.violationTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.violationTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.violationTypeComboBox.ItemHeight = 30;
            this.violationTypeComboBox.Location = new System.Drawing.Point(12, 50);
            this.violationTypeComboBox.Name = "violationTypeComboBox";
            this.violationTypeComboBox.Size = new System.Drawing.Size(322, 36);
            this.violationTypeComboBox.TabIndex = 13;
            this.violationTypeComboBox.ValueMember = "violationId";
            // 
            // editViolationButton
            // 
            this.editViolationButton.BorderRadius = 2;
            this.editViolationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editViolationButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editViolationButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editViolationButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editViolationButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editViolationButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editViolationButton.ForeColor = System.Drawing.Color.White;
            this.editViolationButton.Location = new System.Drawing.Point(12, 320);
            this.editViolationButton.Name = "editViolationButton";
            this.editViolationButton.Size = new System.Drawing.Size(322, 38);
            this.editViolationButton.TabIndex = 12;
            this.editViolationButton.Text = "Добавить";
            this.editViolationButton.Click += new System.EventHandler(this.editViolationButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата нарушения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Вид нарушения";
            // 
            // EditViolationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 370);
            this.Controls.Add(this.timeOfViolationDateTimePicker);
            this.Controls.Add(this.violationTypeComboBox);
            this.Controls.Add(this.editViolationButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditViolationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование нарушения";
            this.Load += new System.EventHandler(this.EditViolationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.violationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.state_vehicle_inspection_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private state_vehicle_inspection_dbDataSet state_vehicle_inspection_dbDataSet;
        private System.Windows.Forms.BindingSource violationsBindingSource;
        private state_vehicle_inspection_dbDataSetTableAdapters.violationsTableAdapter violationsTableAdapter;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeOfViolationDateTimePicker;
        private Guna.UI2.WinForms.Guna2ComboBox violationTypeComboBox;
        private Guna.UI2.WinForms.Guna2Button editViolationButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}