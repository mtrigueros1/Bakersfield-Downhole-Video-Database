namespace Bakersfield_Downhole_Video
{
    partial class NewPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cAMCOMPANYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakersfieldDHV = new Bakersfield_Downhole_Video.BakersfieldDHV();
            this.cAM_COMPANYTableAdapter = new Bakersfield_Downhole_Video.BakersfieldDHVTableAdapters.CAM_COMPANYTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cAMCOMPANYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakersfieldDHV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cAMCOMPANYBindingSource
            // 
            this.cAMCOMPANYBindingSource.DataMember = "CAM_COMPANY";
            this.cAMCOMPANYBindingSource.DataSource = this.bakersfieldDHV;
            // 
            // bakersfieldDHV
            // 
            this.bakersfieldDHV.DataSetName = "BakersfieldDHV";
            this.bakersfieldDHV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAM_COMPANYTableAdapter
            // 
            this.cAM_COMPANYTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNAMEDataGridViewTextBoxColumn,
            this.cONAMEDataGridViewTextBoxColumn,
            this.cITYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cAMCOMPANYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // cNAMEDataGridViewTextBoxColumn
            // 
            this.cNAMEDataGridViewTextBoxColumn.DataPropertyName = "CNAME";
            this.cNAMEDataGridViewTextBoxColumn.HeaderText = "CNAME";
            this.cNAMEDataGridViewTextBoxColumn.Name = "cNAMEDataGridViewTextBoxColumn";
            // 
            // cONAMEDataGridViewTextBoxColumn
            // 
            this.cONAMEDataGridViewTextBoxColumn.DataPropertyName = "CONAME";
            this.cONAMEDataGridViewTextBoxColumn.HeaderText = "CONAME";
            this.cONAMEDataGridViewTextBoxColumn.Name = "cONAMEDataGridViewTextBoxColumn";
            // 
            // cITYDataGridViewTextBoxColumn
            // 
            this.cITYDataGridViewTextBoxColumn.DataPropertyName = "CITY";
            this.cITYDataGridViewTextBoxColumn.HeaderText = "CITY";
            this.cITYDataGridViewTextBoxColumn.Name = "cITYDataGridViewTextBoxColumn";
            // 
            // NewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 470);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NewPanel";
            this.Text = "Daily Report";
            this.Load += new System.EventHandler(this.NewPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cAMCOMPANYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakersfieldDHV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BakersfieldDHV bakersfieldDHV;
        private System.Windows.Forms.BindingSource cAMCOMPANYBindingSource;
        private BakersfieldDHVTableAdapters.CAM_COMPANYTableAdapter cAM_COMPANYTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITYDataGridViewTextBoxColumn;
    }
}