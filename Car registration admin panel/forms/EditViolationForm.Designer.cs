
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.violationTypeComboBox = new System.Windows.Forms.ComboBox();
            this.violationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.state_vehicle_inspection_dbDataSet = new Car_registration_admin_panel.state_vehicle_inspection_dbDataSet();
            this.timeOfViolationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.editViolationButton = new System.Windows.Forms.Button();
            this.violationsTableAdapter = new Car_registration_admin_panel.state_vehicle_inspection_dbDataSetTableAdapters.violationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.violationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.state_vehicle_inspection_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата нарушения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вид нарушения";
            // 
            // violationTypeComboBox
            // 
            this.violationTypeComboBox.DataSource = this.violationsBindingSource;
            this.violationTypeComboBox.DisplayMember = "violationDescription";
            this.violationTypeComboBox.FormattingEnabled = true;
            this.violationTypeComboBox.Location = new System.Drawing.Point(17, 54);
            this.violationTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.violationTypeComboBox.Name = "violationTypeComboBox";
            this.violationTypeComboBox.Size = new System.Drawing.Size(427, 24);
            this.violationTypeComboBox.TabIndex = 7;
            this.violationTypeComboBox.ValueMember = "violationId";
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
            // timeOfViolationDateTimePicker
            // 
            this.timeOfViolationDateTimePicker.Location = new System.Drawing.Point(17, 143);
            this.timeOfViolationDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeOfViolationDateTimePicker.Name = "timeOfViolationDateTimePicker";
            this.timeOfViolationDateTimePicker.Size = new System.Drawing.Size(427, 22);
            this.timeOfViolationDateTimePicker.TabIndex = 6;
            // 
            // editViolationButton
            // 
            this.editViolationButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editViolationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editViolationButton.ForeColor = System.Drawing.Color.White;
            this.editViolationButton.Location = new System.Drawing.Point(13, 398);
            this.editViolationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editViolationButton.Name = "editViolationButton";
            this.editViolationButton.Size = new System.Drawing.Size(435, 44);
            this.editViolationButton.TabIndex = 5;
            this.editViolationButton.Text = "Сохранить";
            this.editViolationButton.UseVisualStyleBackColor = false;
            this.editViolationButton.Click += new System.EventHandler(this.editViolationButton_Click);
            // 
            // violationsTableAdapter
            // 
            this.violationsTableAdapter.ClearBeforeFill = true;
            // 
            // EditViolationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.violationTypeComboBox);
            this.Controls.Add(this.timeOfViolationDateTimePicker);
            this.Controls.Add(this.editViolationButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox violationTypeComboBox;
        private System.Windows.Forms.DateTimePicker timeOfViolationDateTimePicker;
        private System.Windows.Forms.Button editViolationButton;
        private state_vehicle_inspection_dbDataSet state_vehicle_inspection_dbDataSet;
        private System.Windows.Forms.BindingSource violationsBindingSource;
        private state_vehicle_inspection_dbDataSetTableAdapters.violationsTableAdapter violationsTableAdapter;
    }
}