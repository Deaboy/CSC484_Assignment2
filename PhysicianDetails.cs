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
        public PhysicianDetails()
        {
            InitializeComponent();
        }

        private void PhysicianDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's1989750DataSet.Medication' table. You can move, or remove it, as needed.
            this.medicationTableAdapter.Fill(this.s1989750DataSet.Medication);
            // TODO: This line of code loads data into the 's1989750DataSet.LabExam' table. You can move, or remove it, as needed.
            this.labExamTableAdapter.Fill(this.s1989750DataSet.LabExam);
            // TODO: This line of code loads data into the 's1989750DataSet.Physician' table. You can move, or remove it, as needed.
            this.physicianTableAdapter.Fill(this.s1989750DataSet.Physician);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
