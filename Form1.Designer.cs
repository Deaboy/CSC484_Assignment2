namespace CSC484_Assignment2
{
    partial class mainmenu
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
            this.close = new System.Windows.Forms.Button();
            this.physicians = new System.Windows.Forms.Button();
            this.patients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(175, 157);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 0;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.button1_Click);
            // 
            // physicians
            // 
            this.physicians.Location = new System.Drawing.Point(43, 39);
            this.physicians.Name = "physicians";
            this.physicians.Size = new System.Drawing.Size(173, 42);
            this.physicians.TabIndex = 1;
            this.physicians.Text = "Physicians";
            this.physicians.UseVisualStyleBackColor = true;
            this.physicians.Click += new System.EventHandler(this.button2_Click);
            // 
            // patients
            // 
            this.patients.Location = new System.Drawing.Point(43, 87);
            this.patients.Name = "patients";
            this.patients.Size = new System.Drawing.Size(173, 42);
            this.patients.TabIndex = 2;
            this.patients.Text = "Patients";
            this.patients.UseVisualStyleBackColor = true;
            this.patients.Click += new System.EventHandler(this.patients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose an option to get started.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patients);
            this.Controls.Add(this.physicians);
            this.Controls.Add(this.close);
            this.Name = "mainmenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button physicians;
        private System.Windows.Forms.Button patients;
        private System.Windows.Forms.Label label1;
    }
}

