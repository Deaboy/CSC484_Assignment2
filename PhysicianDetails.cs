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
        private DataRow physicianRow;

        public PhysicianDetails(long physicianID = 0)
        {
            this.physicianID = physicianID;
            InitializeComponent();
        }

        private void PhysicianDetails_Load(object sender, EventArgs e)
        {
            if (physicianID == 0)
            {
                // Create new patient
                physicianRow = s1989750DataSet.Physician.NewPhysicianRow();
                physicianRow["Name"] = "";
                physicianRow["Specialty"] = "";

                s1989750DataSet.Physician.Rows.Add(physicianRow);
                physicianTableAdapter.Update(s1989750DataSet.Physician);

                physicianID = (long)physicianRow["ID"];
            }

            this.treatmentTableAdapter.FillByPhysician(this.s1989750DataSet.Treatment, physicianID);
            this.patientTableAdapter.FillByPhysician(this.s1989750DataSet.Patient, physicianID);
            this.physicianTableAdapter.FillByPhysician(this.s1989750DataSet.Physician, physicianID);

            this.dataGridViewPatients.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewPatients_DefaultValuesNeeded);
            this.dataGridViewTreatments.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewTreatments_DefaultValuesNeeded);
            
            physicianRow = s1989750DataSet.Tables["Physician"].Rows[0];
            label1.Text = "Physician " + physicianID;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                physicianRow["Name"] = this.PhysicianName.Text;
                physicianRow["Specialty"] = this.Specialty.Text;
                physicianRow.EndEdit();
                physicianTableAdapter.Update(s1989750DataSet.Physician);

                this.Validate();
                this.treatmentTableAdapter.Update(s1989750DataSet.Treatment);

                MessageBox.Show("Update successful");
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewPatients_DefaultValuesNeeded(object sender,
            System.Windows.Forms.DataGridViewRowEventArgs e)
        {

            e.Row.Cells[1].Value = physicianID;

        }

        private void dataGridViewTreatments_DefaultValuesNeeded(object sender,
            System.Windows.Forms.DataGridViewRowEventArgs e)
        {

            e.Row.Cells[1].Value = physicianID;

        }

        private void dataGridViewPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            long patientID = Int64.Parse(this.dataGridViewPatients.Rows[e.RowIndex].Cells[0].Value.ToString());
            PatientDetails patientDetails = new PatientDetails(patientID);
            patientDetails.ShowDialog(this);
            patientDetails.Dispose();
            this.patientTableAdapter.FillByPhysician(this.s1989750DataSet.Patient, physicianID);
        }
    }
}
