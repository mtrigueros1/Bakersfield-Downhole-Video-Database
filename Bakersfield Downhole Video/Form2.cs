﻿using System;
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
    public partial class NewPanel : Form
    {
        public NewPanel()
        {
            InitializeComponent();
        }

        private void NewPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bakersfieldDHV.CAM_COMPANY' table. You can move, or remove it, as needed.
            this.cAM_COMPANYTableAdapter.Fill(this.bakersfieldDHV.CAM_COMPANY);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
