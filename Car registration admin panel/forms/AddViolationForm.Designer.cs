
namespace Car_registration_admin_panel.forms
{
    partial class AddViolationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddViolationForm));
            this.violationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statevehicleinspectiondbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.state_vehicle_inspection_dbDataSet = new Car_registration_admin_panel.state_vehicle_inspection_dbDataSet();
            this.violationsTableAdapter = new Car_registration_admin_panel.state_vehicle_inspection_dbDataSetTableAdapters.violationsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addViolationButton = new Guna.UI2.WinForms.Guna2Button();
            this.violationTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timeOfViolationDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.violationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statevehicleinspectiondbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.state_vehicle_inspection_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // violationsBindingSource
            // 
            this.violationsBindingSource.DataMember = "violations";
            this.violationsBindingSource.DataSource = this.statevehicleinspectiondbDataSetBindingSource;
            // 
            // statevehicleinspectiondbDataSetBindingSource
            // 
            this.statevehicleinspectiondbDataSetBindingSource.DataSource = this.state_vehicle_inspection_dbDataSet;
            this.statevehicleinspectiondbDataSetBindingSource.Position = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вид нарушения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата нарушения";
            // 
            // addViolationButton
            // 
            this.addViolationButton.BorderRadius = 2;
            this.addViolationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addViolationButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addViolationButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addViolationButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addViolationButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addViolationButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addViolationButton.ForeColor = System.Drawing.Color.White;
            this.addViolationButton.Location = new System.Drawing.Point(12, 320);
            this.addViolationButton.Name = "addViolationButton";
            this.addViolationButton.Size = new System.Drawing.Size(322, 38);
            this.addViolationButton.TabIndex = 5;
            this.addViolationButton.Text = "Добавить";
            this.addViolationButton.Click += new System.EventHandler(this.addViolationButton_Click);
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
            this.violationTypeComboBox.Location = new System.Drawing.Point(12, 44);
            this.violationTypeComboBox.Name = "violationTypeComboBox";
            this.violationTypeComboBox.Size = new System.Drawing.Size(321, 36);
            this.violationTypeComboBox.TabIndex = 6;
            this.violationTypeComboBox.ValueMember = "violationId";
            // 
            // timeOfViolationDateTimePicker
            // 
            this.timeOfViolationDateTimePicker.Checked = true;
            this.timeOfViolationDateTimePicker.FillColor = System.Drawing.Color.White;
            this.timeOfViolationDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeOfViolationDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.timeOfViolationDateTimePicker.Location = new System.Drawing.Point(12, 116);
            this.timeOfViolationDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeOfViolationDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeOfViolationDateTimePicker.Name = "timeOfViolationDateTimePicker";
            this.timeOfViolationDateTimePicker.Size = new System.Drawing.Size(321, 36);
            this.timeOfViolationDateTimePicker.TabIndex = 7;
            this.timeOfViolationDateTimePicker.Value = new System.DateTime(2024, 4, 26, 17, 11, 55, 729);
            // 
            // AddViolationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 370);
            this.Controls.Add(this.timeOfViolationDateTimePicker);
            this.Controls.Add(this.violationTypeComboBox);
            this.Controls.Add(this.addViolationButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddViolationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нарушения";
            this.Load += new System.EventHandler(this.AddViolationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.violationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statevehicleinspectiondbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.state_vehicle_inspection_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource statevehicleinspectiondbDataSetBindingSource;
        private state_vehicle_inspection_dbDataSet state_vehicle_inspection_dbDataSet;
        private System.Windows.Forms.BindingSource violationsBindingSource;
        private state_vehicle_inspection_dbDataSetTableAdapters.violationsTableAdapter violationsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button addViolationButton;
        private Guna.UI2.WinForms.Guna2ComboBox violationTypeComboBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeOfViolationDateTimePicker;
    }
}