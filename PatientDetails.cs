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
            // TODO: This line of code loads data into the 's1989750DataSet.Patient' table. You can move, or remove it, as needed.
            if (patientID == 0) // New entry
            {
                
            }

             // TODO: This line of code loads data into the 's1989750DataSet.LabExam' table. You can move, or remove it, as needed.
            this.labExamTableAdapter.FillBy(this.s1989750DataSet.LabExam, patientID);
            // TODO: This line of code loads data into the 's1989750DataSet.Treatment' table. You can move, or remove it, as needed.
            this.treatmentTableAdapter.FillBy(this.s1989750DataSet.Treatment, patientID);
            // TODO: This line of code loads data into the 's1989750DataSet.SpecialDiet' table. You can move, or remove it, as needed.
            this.specialDietTableAdapter.FillBy(this.s1989750DataSet.SpecialDiet, patientID);
            // TODO: This line of code loads data into the 's1989750DataSet.Medication' table. You can move, or remove it, as needed.
            this.medicationTableAdapter.FillBy(this.s1989750DataSet.Medication, patientID);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Visible = true;
        }

    }
}
