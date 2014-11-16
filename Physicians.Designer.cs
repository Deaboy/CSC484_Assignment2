namespace CSC484_Assignment2
{
    partial class Physicians
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s1989750DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s1989750DataSet = new CSC484_Assignment2.s1989750DataSet();
            this.close = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.physicianTableAdapter = new CSC484_Assignment2.s1989750DataSetTableAdapters.PhysicianTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1989750DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1989750DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.physicianBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(560, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            this.specialityDataGridViewTextBoxColumn.DataPropertyName = "Speciality";
            this.specialityDataGridViewTextBoxColumn.HeaderText = "Speciality";
            this.specialityDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            this.specialityDataGridViewTextBoxColumn.ReadOnly = true;
            this.specialityDataGridViewTextBoxColumn.Width = 200;
            // 
            // physicianBindingSource
            // 
            this.physicianBindingSource.DataMember = "Physician";
            this.physicianBindingSource.DataSource = this.s1989750DataSetBindingSource;
            // 
            // s1989750DataSetBindingSource
            // 
            this.s1989750DataSetBindingSource.DataSource = this.s1989750DataSet;
            this.s1989750DataSetBindingSource.Position = 0;
            // 
            // s1989750DataSet
            // 
            this.s1989750DataSet.DataSetName = "s1989750DataSet";
            this.s1989750DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // close
            // 
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.close.FlatAppearance.BorderSize = 4;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.close.Location = new System.Drawing.Point(12, 326);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(497, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click on a Physician for more Information";
            // 
            // physicianTableAdapter
            // 
            this.physicianTableAdapter.ClearBeforeFill = true;
            // 
            // Physicians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Physicians";
            this.Load += new System.EventHandler(this.Physicians_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1989750DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s1989750DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource s1989750DataSetBindingSource;
        private s1989750DataSet s1989750DataSet;
        private System.Windows.Forms.BindingSource physicianBindingSource;
        private s1989750DataSetTableAdapters.PhysicianTableAdapter physicianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
    }
}