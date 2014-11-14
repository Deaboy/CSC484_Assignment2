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
                s1989750DataSet.PatientRow newPatientRow;
                newPatientRow = s1989750DataSet.Patient.NewPatientRow();
                newPatientRow.Name = "";
                newPatientRow.PhoneNumber = "";
                newPatientRow.ContactName = "";
                newPatientRow.ContactNumber = "";

                s1989750DataSet.Patient.Rows.Add(newPatientRow);
                patientTableAdapter.Update(s1989750DataSet.Patient);

                patientID = newPatientRow.ID;
            }

            // TODO: This line of code loads data into the 's1989750DataSet.Admittance' table. You can move, or remove it, as needed.
            this.admittanceTableAdapter.Fill(this.s1989750DataSet.Admittance);
            // TODO: This line of code loads data into the 's1989750DataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.FillByPatient(this.s1989750DataSet.Patient, patientID);
            // TODO: This line of code loads data into the 's1989750DataSet.LabExam' table. You can move, or remove it, as needed.
            this.labExamTableAdapter.FillByPatient(this.s1989750DataSet.LabExam, patientID);
            // TODO: This line of code loads data into the 's1989750DataSet.Physician' table. You can move, or remove it, as needed.
            this.physicianTableAdapter.FillByPatient(this.s1989750DataSet.Physician, patientID);
            // TODO: This line of code loads data into the 's1989750DataSet.Treatment' table. You can move, or remove it, as needed.
            this.treatmentTableAdapter.FillByPatient(this.s1989750DataSet.Treatment, patientID);
            // TODO: This line of code loads data into the 's1989750DataSet.SpecialDiet' table. You can move, or remove it, as needed.
            this.specialDietTableAdapter.FillByPatient(this.s1989750DataSet.SpecialDiet, patientID);
            // TODO: This line of code loads data into the 's1989750DataSet.Medication' table. You can move, or remove it, as needed.
            this.medicationTableAdapter.FillByPatient(this.s1989750DataSet.Medication, patientID);

            Owner.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this.ValidateChildren();
            Owner.Visible = true;
            this.Close();
        }

    }
}
