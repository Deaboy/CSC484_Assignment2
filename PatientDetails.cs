using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC484_Assignment2
{
    public partial class PatientDetails : Form
    {
        private long patientID;
        private DataRow patientRow;

        public PatientDetails(long patientID = 0)
        {
            this.patientID = patientID;
            InitializeComponent();
        }

        private void PatientDetails_Load(object sender, EventArgs e)
        {
            if (patientID == 0)
            {
                // Create a new client with blank data
                patientRow = s1989750DataSet.Patient.NewPatientRow();
                patientRow["Name"] = "";
                patientRow["PhoneNumber"] = "";
                patientRow["ContactName"] = "";
                patientRow["ContactNumber"] = "";

                // Put new patient into database
                s1989750DataSet.Patient.Rows.Add(patientRow);
                patientTableAdapter.Update(s1989750DataSet.Patient);

                // Store the ID
                patientID = (long) patientRow["ID"];
            }

            // Load up data from database
            this.patientTableAdapter.FillByPatient(this.s1989750DataSet.Patient, patientID);
            this.physicianTableAdapter.Fill(this.s1989750DataSet.Physician);
            this.treatmentTableAdapter.FillByPatient(this.s1989750DataSet.Treatment, patientID);
            this.labExamTableAdapter.FillByPatient(this.s1989750DataSet.LabExam, patientID);
            this.medicationTableAdapter.FillByPatient(this.s1989750DataSet.Medication, patientID);
            this.specialDietTableAdapter.FillByPatient(this.s1989750DataSet.SpecialDiet, patientID);
            
            // Add listeners for default values for DataGridViews
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            this.dataGridView2.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_DefaultValuesNeeded);
            this.dataGridView3.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView3_DefaultValuesNeeded);
            this.dataGridView4.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView4_DefaultValuesNeeded);

            // Fetch the row we're currently editing
            patientRow = s1989750DataSet.Tables["Patient"].Rows[0];
            this.admitting_physician.SelectedValue = patientRow["PhysicianID"];
            label1.Text = "Patient " + patientID;

            // Explicitly hide the ID column
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView2.Columns[0].Visible = false;
            this.dataGridView3.Columns[0].Visible = false;
            this.dataGridView4.Columns[0].Visible = false;

            // If no admitting physician is set, forcibly choose first one
            if (this.admitting_physician.SelectedValue == null)
            {
                this.admitting_physician.SelectedIndex = 0;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                patientRow["Name"] = this.name.Text;
                patientRow["PhoneNumber"] = this.phone_number.Text;
                patientRow["ContactName"] = this.contact_name.Text;
                patientRow["ContactNumber"] = this.contact_phone.Text;
                patientRow["PhysicianID"] = this.admitting_physician.SelectedValue;
                patientRow.EndEdit();
                patientTableAdapter.Update(s1989750DataSet.Patient);

                this.Validate();
                medicationTableAdapter.Update(s1989750DataSet.Medication);
                treatmentTableAdapter.Update(s1989750DataSet.Treatment);
                specialDietTableAdapter.Update(s1989750DataSet.SpecialDiet);
                labExamTableAdapter.Update(s1989750DataSet.LabExam);
                
                MessageBox.Show("Update successful");
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this patient?\n"
                + "All associated medications, treatments, lab exams, and special diets will be deleted.",
                "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    patientRow.Delete();
                    patientTableAdapter.Update(s1989750DataSet.Patient);

                    MessageBox.Show("Update successful");
                    this.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }
        }

        private void dataGridView1_DefaultValuesNeeded(object sender,
            System.Windows.Forms.DataGridViewRowEventArgs e)
        {

            e.Row.Cells[1].Value = patientID;

        }
        private void dataGridView2_DefaultValuesNeeded(object sender,
            System.Windows.Forms.DataGridViewRowEventArgs e)
        {

            e.Row.Cells[1].Value = patientID;

        }
        private void dataGridView3_DefaultValuesNeeded(object sender,
            System.Windows.Forms.DataGridViewRowEventArgs e)
        {

            e.Row.Cells[1].Value = patientID;

        }
        private void dataGridView4_DefaultValuesNeeded(object sender,
            System.Windows.Forms.DataGridViewRowEventArgs e)
        {

            e.Row.Cells[1].Value = patientID;

        }
    }
}
