using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakersfield_Downhole_Video
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bakersfieldDHV2.CAM_COMPANY' table. You can move, or remove it, as needed.
            this.cAM_COMPANYTableAdapter.Fill(this.bakersfieldDHV2.CAM_COMPANY);
            // TODO: This line of code loads data into the 'bakersfieldDHV.CAM_COLLECTEDFOR' table. You can move, or remove it, as needed.
            this.cAM_COLLECTEDFORTableAdapter.Fill(this.bakersfieldDHV.CAM_COLLECTEDFOR);
            // TODO: This line of code loads data into the 'bakersfieldDHV.CAM_DATA' table. You can move, or remove it, as needed.
            this.cAM_DATATableAdapter.Fill(this.bakersfieldDHV.CAM_DATA);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            NewPanel test = new NewPanel();
            test.Show();         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
    }
}
