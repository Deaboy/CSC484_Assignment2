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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's1989750DataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.s1989750DataSet.Patient);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            long patientID = Int64.Parse(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            PatientDetails patientDetails = new PatientDetails(patientID);
            patientDetails.ShowDialog(this);
            patientDetails.Dispose();
            this.patientTableAdapter.Fill(this.s1989750DataSet.Patient);
        }

        private void addnew_Click(object sender, EventArgs e)
        {
            PatientDetails patientDetails = new PatientDetails();
            patientDetails.ShowDialog(this);
            patientDetails.Dispose();
            this.patientTableAdapter.Fill(this.s1989750DataSet.Patient);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
