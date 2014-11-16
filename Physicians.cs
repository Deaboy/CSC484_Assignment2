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
    public partial class Physicians : Form
    {
        public Physicians()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //todo add new stuff to physician
        }

        private void Physicians_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's1989750DataSet.Physician' table. You can move, or remove it, as needed.
            this.physicianTableAdapter.Fill(this.s1989750DataSet.Physician);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
