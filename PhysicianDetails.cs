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
    public partial class PhysicianDetails : Form
    {
        private long physicianID;

         public PhysicianDetails( long physicianID = 0 )
        {
            this.physicianID = physicianID;
            InitializeComponent();
        }

        private void PhysicianDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's1989750DataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.FillBy(this.s1989750DataSet.Patient, physicianID);
            // TODO: This line of code loads data into the 's1989750DataSet.SpecialDiet' table. You can move, or remove it, as needed.
            this.specialDietTableAdapter.Fill(this.s1989750DataSet.SpecialDiet);
            // TODO: This line of code loads data into the 's1989750DataSet.Treatment' table. You can move, or remove it, as needed.
            this.treatmentTableAdapter.FillBy(this.s1989750DataSet.Treatment, physicianID);
            // TODO: This line of code loads data into the 's1989750DataSet.Medication' table. You can move, or remove it, as needed.
            this.medicationTableAdapter.FillBy(this.s1989750DataSet.Medication, physicianID);
            // TODO: This line of code loads data into the 's1989750DataSet.LabExam' table. You can move, or remove it, as needed.
            this.labExamTableAdapter.FillBy(this.s1989750DataSet.LabExam, physicianID);
            // TODO: This line of code loads data into the 's1989750DataSet.Physician' table. You can move, or remove it, as needed.
            this.physicianTableAdapter.Fill(this.s1989750DataSet.Physician);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

    }
}
