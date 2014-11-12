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
            this.Name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Specialty = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.s1989750DataSet = new CSC484_Assignment2.s1989750DataSet();
            this.physicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.physicianTableAdapter = new CSC484_Assignment2.s1989750DataSetTableAdapters.PhysicianTableAdapter();
            this.fkadmittancephysicianidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admittanceTableAdapter = new CSC484_Assignment2.s1989750DataSetTableAdapters.AdmittanceTableAdapter();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicianIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhysicianTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fklabexamphysicianidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labExamTableAdapter = new CSC484_Assignment2.s1989750DataSetTableAdapters.LabExamTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicianIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.fkmedicationphysicianidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicationTableAdapter = new CSC484_Assignment2.s1989750DataSetTableAdapters.MedicationTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicianIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicianIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1989750DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkadmittancephysicianidBindingSource)).BeginInit();
            this.PhysicianTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fklabexamphysicianidBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkmedicationphysicianidBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(6, 3);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Specialty
            // 
            this.Specialty.AutoSize = true;
            this.Specialty.Location = new System.Drawing.Point(6, 48);
            this.Specialty.Name = "Specialty";
            this.Specialty.Size = new System.Drawing.Size(50, 13);
            this.Specialty.TabIndex = 2;
            this.Specialty.Text = "Specialty";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.physicianIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fkadmittancephysicianidBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // s1989750DataSet
            // 
            this.s1989750DataSet.DataSetName = "s1989750DataSet";
            this.s1989750DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // physicianBindingSource
            // 
            this.physicianBindingSource.DataMember = "Physician";
            this.physicianBindingSource.DataSource = this.s1989750DataSet;
            // 
            // physicianTableAdapter
            // 
            this.physicianTableAdapter.ClearBeforeFill = true;
            // 
            // fkadmittancephysicianidBindingSource
            // 
            this.fkadmittancephysicianidBindingSource.DataMember = "fk_admittance_physicianid";
            this.fkadmittancephysicianidBindingSource.DataSource = this.physicianBindingSource;
            // 
            // admittanceTableAdapter
            // 
            this.admittanceTableAdapter.ClearBeforeFill = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // physicianIDDataGridViewTextBoxColumn
            // 
            this.physicianIDDataGridViewTextBoxColumn.DataPropertyName = "PhysicianID";
            this.physicianIDDataGridViewTextBoxColumn.HeaderText = "PhysicianID";
            this.physicianIDDataGridViewTextBoxColumn.Name = "physicianIDDataGridViewTextBoxColumn";
            this.physicianIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PhysicianTabs
            // 
            this.PhysicianTabs.Controls.Add(this.tabPage1);
            this.PhysicianTabs.Controls.Add(this.tabPage2);
            this.PhysicianTabs.Controls.Add(this.tabPage3);
            this.PhysicianTabs.Controls.Add(this.tabPage4);
            this.PhysicianTabs.Controls.Add(this.tabPage5);
            this.PhysicianTabs.Location = new System.Drawing.Point(17, 40);
            this.PhysicianTabs.Name = "PhysicianTabs";
            this.PhysicianTabs.SelectedIndex = 0;
            this.PhysicianTabs.Size = new System.Drawing.Size(544, 310);
            this.PhysicianTabs.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Name);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.Specialty);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(474, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(536, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(536, 284);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn1,
            this.physicianIDDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.fklabexamphysicianidBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-31, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(544, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // fklabexamphysicianidBindingSource
            // 
            this.fklabexamphysicianidBindingSource.DataMember = "fk_labexam_physicianid";
            this.fklabexamphysicianidBindingSource.DataSource = this.physicianBindingSource;
            // 
            // labExamTableAdapter
            // 
            this.labExamTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientIDDataGridViewTextBoxColumn1
            // 
            this.patientIDDataGridViewTextBoxColumn1.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn1.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn1.Name = "patientIDDataGridViewTextBoxColumn1";
            this.patientIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // physicianIDDataGridViewTextBoxColumn1
            // 
            this.physicianIDDataGridViewTextBoxColumn1.DataPropertyName = "PhysicianID";
            this.physicianIDDataGridViewTextBoxColumn1.HeaderText = "PhysicianID";
            this.physicianIDDataGridViewTextBoxColumn1.Name = "physicianIDDataGridViewTextBoxColumn1";
            this.physicianIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(536, 284);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.drugDataGridViewTextBoxColumn,
            this.dosageDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn2,
            this.physicianIDDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.fkmedicationphysicianidBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(7, 7);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(746, 150);
            this.dataGridView3.TabIndex = 0;
            // 
            // fkmedicationphysicianidBindingSource
            // 
            this.fkmedicationphysicianidBindingSource.DataMember = "fk_medication_physicianid";
            this.fkmedicationphysicianidBindingSource.DataSource = this.physicianBindingSource;
            // 
            // medicationTableAdapter
            // 
            this.medicationTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // drugDataGridViewTextBoxColumn
            // 
            this.drugDataGridViewTextBoxColumn.DataPropertyName = "Drug";
            this.drugDataGridViewTextBoxColumn.HeaderText = "Drug";
            this.drugDataGridViewTextBoxColumn.Name = "drugDataGridViewTextBoxColumn";
            // 
            // dosageDataGridViewTextBoxColumn
            // 
            this.dosageDataGridViewTextBoxColumn.DataPropertyName = "Dosage";
            this.dosageDataGridViewTextBoxColumn.HeaderText = "Dosage";
            this.dosageDataGridViewTextBoxColumn.Name = "dosageDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn2
            // 
            this.patientIDDataGridViewTextBoxColumn2.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn2.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn2.Name = "patientIDDataGridViewTextBoxColumn2";
            // 
            // physicianIDDataGridViewTextBoxColumn2
            // 
            this.physicianIDDataGridViewTextBoxColumn2.DataPropertyName = "PhysicianID";
            this.physicianIDDataGridViewTextBoxColumn2.HeaderText = "PhysicianID";
            this.physicianIDDataGridViewTextBoxColumn2.Name = "physicianIDDataGridViewTextBoxColumn2";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(536, 284);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.drugDataGridViewTextBoxColumn1,
            this.dosageDataGridViewTextBoxColumn1,
            this.startDateDataGridViewTextBoxColumn1,
            this.endDateDataGridViewTextBoxColumn1,
            this.patientIDDataGridViewTextBoxColumn3,
            this.physicianIDDataGridViewTextBoxColumn3});
            this.dataGridView4.DataSource = this.fkmedicationphysicianidBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(7, 7);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(743, 150);
            this.dataGridView4.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // drugDataGridViewTextBoxColumn1
            // 
            this.drugDataGridViewTextBoxColumn1.DataPropertyName = "Drug";
            this.drugDataGridViewTextBoxColumn1.HeaderText = "Drug";
            this.drugDataGridViewTextBoxColumn1.Name = "drugDataGridViewTextBoxColumn1";
            // 
            // dosageDataGridViewTextBoxColumn1
            // 
            this.dosageDataGridViewTextBoxColumn1.DataPropertyName = "Dosage";
            this.dosageDataGridViewTextBoxColumn1.HeaderText = "Dosage";
            this.dosageDataGridViewTextBoxColumn1.Name = "dosageDataGridViewTextBoxColumn1";
            // 
            // startDateDataGridViewTextBoxColumn1
            // 
            this.startDateDataGridViewTextBoxColumn1.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn1.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn1.Name = "startDateDataGridViewTextBoxColumn1";
            // 
            // endDateDataGridViewTextBoxColumn1
            // 
            this.endDateDataGridViewTextBoxColumn1.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn1.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn1.Name = "endDateDataGridViewTextBoxColumn1";
            // 
            // patientIDDataGridViewTextBoxColumn3
            // 
            this.patientIDDataGridViewTextBoxColumn3.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn3.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn3.Name = "patientIDDataGridViewTextBoxColumn3";
            // 
            // physicianIDDataGridViewTextBoxColumn3
            // 
            this.physicianIDDataGridViewTextBoxColumn3.DataPropertyName = "PhysicianID";
            this.physicianIDDataGridViewTextBoxColumn3.HeaderText = "PhysicianID";
            this.physicianIDDataGridViewTextBoxColumn3.Name = "physicianIDDataGridViewTextBoxColumn3";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(21, 353);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Cancle
            // 
            this.Cancle.Location = new System.Drawing.Point(410, 352);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(75, 23);
            this.Cancle.TabIndex = 10;
            this.Cancle.Text = "Cancle";
            this.Cancle.UseVisualStyleBackColor = true;
            // 
            // PhysicianDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 392);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.PhysicianTabs);
            this.Controls.Add(this.label1);
            this.Name = "PhysicianDetails";
            this.Text = "PhysicianDetails";
            this.Load += new System.EventHandler(this.PhysicianDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1989750DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkadmittancephysicianidBindingSource)).EndInit();
            this.PhysicianTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fklabexamphysicianidBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkmedicationphysicianidBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Specialty;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private s1989750DataSet s1989750DataSet;
        private System.Windows.Forms.BindingSource physicianBindingSource;
        private s1989750DataSetTableAdapters.PhysicianTableAdapter physicianTableAdapter;
        private System.Windows.Forms.BindingSource fkadmittancephysicianidBindingSource;
        private s1989750DataSetTableAdapters.AdmittanceTableAdapter admittanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicianIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl PhysicianTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fklabexamphysicianidBindingSource;
        private s1989750DataSetTableAdapters.LabExamTableAdapter labExamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicianIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource fkmedicationphysicianidBindingSource;
        private s1989750DataSetTableAdapters.MedicationTableAdapter medicationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicianIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicianIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancle;
    }
}