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
        private bool newRow;
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
                // Create new patient
                newRow = true;

                patientRow = s1989750DataSet.Patient.NewPatientRow();
                patientRow["Name"] = "";
                patientRow["PhoneNumber"] = "";
                patientRow["ContactName"] = "";
                patientRow["ContactNumber"] = "";

                s1989750DataSet.Patient.Rows.Add(patientRow);
                patientTableAdapter.Update(s1989750DataSet.Patient);

                patientID = (long) patientRow["ID"];
            }
            else
            {
                newRow = false;
            }

            // TODO: This line of code loads data into the 's1989750DataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.FillByPatient(this.s1989750DataSet.Patient, patientID);
            // TODO: This line of code loads data into the 's1989750DataSet.LabExam' table. You can move, or remove it, as needed.
            this.labExamTableAdapter.FillByPatient(this.s1989750DataSet.LabExam, patientID);
            // TODO: This line of code loads data into the 's1989750DataSet.Physician' table. You can move, or remove it, as needed.
            this.physicianTableAdapter.Fill(this.s1989750DataSet.Physician);
            // TODO: This line of code loads data into the 's1989750DataSet.Treatment' table. You can move, or remove it, as needed.
            this.treatmentTableAdapter.FillByPatient(this.s1989750DataSet.Treatment, patientID);
            // TODO: This line of code loads data into the 's1989750DataSet.SpecialDiet' table. You can move, or remove it, as needed.
            this.specialDietTableAdapter.FillByPatient(this.s1989750DataSet.SpecialDiet, patientID);
            // TODO: This line of code loads data into the 's1989750DataSet.Medication' table. You can move, or remove it, as needed.
            this.medicationTableAdapter.FillByPatient(this.s1989750DataSet.Medication, patientID);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            this.dataGridView2.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_DefaultValuesNeeded);
            this.dataGridView3.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView3_DefaultValuesNeeded);
            this.dataGridView4.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView4_DefaultValuesNeeded);

            patientRow = s1989750DataSet.Tables["Patient"].Rows[0];
            this.admitting_physician.SelectedValue = patientRow["PhysicianID"];
            label1.Text = "Patient " + patientID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
        
        private void dataGridView1_DefaultValuesNeeded(object sender,
            System.Windows.Forms.DataGridViewRowEventArgs e)
        {

            e.Row.Cells[5].Value = patientID;

        }
        private void dataGridView2_DefaultValuesNeeded(object sender,
            System.Windows.Forms.DataGridViewRowEventArgs e)
        {

            e.Row.Cells[3].Value = patientID;

        }
        private void dataGridView3_DefaultValuesNeeded(object sender,
            System.Windows.Forms.DataGridViewRowEventArgs e)
        {

            e.Row.Cells[4].Value = patientID;

        }
        private void dataGridView4_DefaultValuesNeeded(object sender,
            System.Windows.Forms.DataGridViewRowEventArgs e)
        {

            e.Row.Cells[3].Value = patientID;

        }

        private void button3_Click(object sender, EventArgs e)
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

    }
}
