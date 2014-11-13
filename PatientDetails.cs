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
        public PatientDetails()
        {
            InitializeComponent();
        }

        private void PatientDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's1989750DataSet.Treatment' table. You can move, or remove it, as needed.
            this.treatmentTableAdapter.Fill(this.s1989750DataSet.Treatment);
            // TODO: This line of code loads data into the 's1989750DataSet.SpecialDiet' table. You can move, or remove it, as needed.
            this.specialDietTableAdapter.Fill(this.s1989750DataSet.SpecialDiet);
            // TODO: This line of code loads data into the 's1989750DataSet.Medication' table. You can move, or remove it, as needed.
            this.medicationTableAdapter.Fill(this.s1989750DataSet.Medication);

        }
    }
}
