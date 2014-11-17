namespace CSC484_Assignment2
{
    partial class PhysicianDetails
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
            this.name_label = new System.Windows.Forms.Label();
            this.PhysicianName = new System.Windows.Forms.TextBox();
            this.physicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s1989750DataSet = new CSC484_Assignment2.s1989750DataSet();
            this.speciality_label = new System.Windows.Forms.Label();
            this.Specialty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PhysicianTabs = new System.Windows.Forms.TabControl();
            this.tabDetails = new System.Windows.Forms.TabPage();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabTreatments = new System.Windows.Forms.TabPage();
            this.dataGridViewTreatments = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.medicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.physicianTableAdapter = new CSC484_Assignment2.s1989750DataSetTableAdapters.PhysicianTableAdapter();
            this.labExamTableAdapter = new CSC484_Assignment2.s1989750DataSetTableAdapters.LabExamTableAdapter();
            this.medicationTableAdapter = new CSC484_Assignment2.s1989750DataSetTableAdapters.MedicationTableAdapter();
            this.patientTableAdapter = new CSC484_Assignment2.s1989750DataSetTableAdapters.PatientTableAdapter();
            this.treatmentTableAdapter = new CSC484_Assignment2.s1989750DataSetTableAdapters.TreatmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.physicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1989750DataSet)).BeginInit();
            this.PhysicianTabs.SuspendLayout();
            this.tabDetails.SuspendLayout();
            this.tabPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.tabTreatments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(0, 12);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // PhysicianName
            // 
            this.PhysicianName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.physicianBindingSource, "Name", true));
            this.PhysicianName.Location = new System.Drawing.Point(3, 28);
            this.PhysicianName.Name = "PhysicianName";
            this.PhysicianName.Size = new System.Drawing.Size(300, 20);
            this.PhysicianName.TabIndex = 1;
            // 
            // physicianBindingSource
            // 
            this.physicianBindingSource.DataMember = "Physician";
            this.physicianBindingSource.DataSource = this.s1989750DataSet;
            // 
            // s1989750DataSet
            // 
            this.s1989750DataSet.DataSetName = "s1989750DataSet";
            this.s1989750DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // speciality_label
            // 
            this.speciality_label.AutoSize = true;
            this.speciality_label.Location = new System.Drawing.Point(0, 62);
            this.speciality_label.Name = "speciality_label";
            this.speciality_label.Size = new System.Drawing.Size(50, 13);
            this.speciality_label.TabIndex = 2;
            this.speciality_label.Text = "Specialty";
            // 
            // Specialty
            // 
            this.Specialty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.physicianBindingSource, "Specialty", true));
            this.Specialty.Location = new System.Drawing.Point(3, 78);
            this.Specialty.Name = "Specialty";
            this.Specialty.Size = new System.Drawing.Size(300, 20);
            this.Specialty.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Physician ID";
            // 
            // PhysicianTabs
            // 
            this.PhysicianTabs.Controls.Add(this.tabDetails);
            this.PhysicianTabs.Controls.Add(this.tabPatients);
            this.PhysicianTabs.Controls.Add(this.tabTreatments);
            this.PhysicianTabs.Location = new System.Drawing.Point(0, 40);
            this.PhysicianTabs.Margin = new System.Windows.Forms.Padding(0);
            this.PhysicianTabs.Name = "PhysicianTabs";
            this.PhysicianTabs.SelectedIndex = 0;
            this.PhysicianTabs.Size = new System.Drawing.Size(585, 323);
            this.PhysicianTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.PhysicianTabs.TabIndex = 8;
            // 
            // tabDetails
            // 
            this.tabDetails.Controls.Add(this.name_label);
            this.tabDetails.Controls.Add(this.PhysicianName);
            this.tabDetails.Controls.Add(this.speciality_label);
            this.tabDetails.Controls.Add(this.Specialty);
            this.tabDetails.Location = new System.Drawing.Point(4, 22);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetails.Size = new System.Drawing.Size(577, 297);
            this.tabDetails.TabIndex = 0;
            this.tabDetails.Text = "Details";
            this.tabDetails.UseVisualStyleBackColor = true;
            // 
            // tabPatients
            // 
            this.tabPatients.Controls.Add(this.dataGridViewPatients);
            this.tabPatients.Location = new System.Drawing.Point(4, 22);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatients.Size = new System.Drawing.Size(577, 297);
            this.tabPatients.TabIndex = 1;
            this.tabPatients.Text = "Patients";
            this.tabPatients.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.AutoGenerateColumns = false;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.nameDataGridViewTextBoxColumn1,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn});
            this.dataGridViewPatients.DataSource = this.patientBindingSource;
            this.dataGridViewPatients.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPatients.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewPatients.MultiSelect = false;
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(574, 294);
            this.dataGridViewPatients.TabIndex = 0;
            this.dataGridViewPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_CellContentClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PhysicianID";
            this.dataGridViewTextBoxColumn6.HeaderText = "PhysicianID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            this.contactNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.s1989750DataSet;
            // 
            // tabTreatments
            // 
            this.tabTreatments.Controls.Add(this.dataGridViewTreatments);
            this.tabTreatments.Location = new System.Drawing.Point(4, 22);
            this.tabTreatments.Name = "tabTreatments";
            this.tabTreatments.Padding = new System.Windows.Forms.Padding(3);
            this.tabTreatments.Size = new System.Drawing.Size(577, 297);
            this.tabTreatments.TabIndex = 2;
            this.tabTreatments.Text = "Treatments";
            this.tabTreatments.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTreatments
            // 
            this.dataGridViewTreatments.AutoGenerateColumns = false;
            this.dataGridViewTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTreatments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.nameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.dataGridViewTreatments.DataSource = this.treatmentBindingSource;
            this.dataGridViewTreatments.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTreatments.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewTreatments.Name = "dataGridViewTreatments";
            this.dataGridViewTreatments.Size = new System.Drawing.Size(574, 294);
            this.dataGridViewTreatments.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhysicianID";
            this.dataGridViewTextBoxColumn4.HeaderText = "PhysicianID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Treatment";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PatientID";
            this.dataGridViewTextBoxColumn3.HeaderText = "PatientID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // treatmentBindingSource
            // 
            this.treatmentBindingSource.DataMember = "Treatment";
            this.treatmentBindingSource.DataSource = this.s1989750DataSet;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(497, 376);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 9;
            this.Save.Text = "OK";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Cancel.Location = new System.Drawing.Point(12, 376);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // medicationBindingSource
            // 
            this.medicationBindingSource.DataMember = "Medication";
            this.medicationBindingSource.DataSource = this.s1989750DataSet;
            // 
            // physicianTableAdapter
            // 
            this.physicianTableAdapter.ClearBeforeFill = true;
            // 
            // labExamTableAdapter
            // 
            this.labExamTableAdapter.ClearBeforeFill = true;
            // 
            // medicationTableAdapter
            // 
            this.medicationTableAdapter.ClearBeforeFill = true;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // treatmentTableAdapter
            // 
            this.treatmentTableAdapter.ClearBeforeFill = true;
            // 
            // PhysicianDetails
            // 
            this.AcceptButton = this.Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.PhysicianTabs);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "PhysicianDetails";
            this.Text = "Physician Details";
            this.Load += new System.EventHandler(this.PhysicianDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.physicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1989750DataSet)).EndInit();
            this.PhysicianTabs.ResumeLayout(false);
            this.tabDetails.ResumeLayout(false);
            this.tabDetails.PerformLayout();
            this.tabPatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.tabTreatments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox PhysicianName;
        private System.Windows.Forms.Label speciality_label;
        private System.Windows.Forms.TextBox Specialty;
        private System.Windows.Forms.Label label1;
        private s1989750DataSet s1989750DataSet;
        private System.Windows.Forms.BindingSource physicianBindingSource;
        private s1989750DataSetTableAdapters.PhysicianTableAdapter physicianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicianIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl PhysicianTabs;
        private System.Windows.Forms.TabPage tabDetails;
        private System.Windows.Forms.TabPage tabPatients;
        private System.Windows.Forms.TabPage tabTreatments;
        private s1989750DataSetTableAdapters.LabExamTableAdapter labExamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicianIDDataGridViewTextBoxColumn1;
        private s1989750DataSetTableAdapters.MedicationTableAdapter medicationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicianIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicianIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource medicationBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private s1989750DataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewTreatments;
        private System.Windows.Forms.BindingSource treatmentBindingSource;
        private s1989750DataSetTableAdapters.TreatmentTableAdapter treatmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
    }
}