namespace Bakersfield_Downhole_Video
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cAMDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakersfieldDHV = new Bakersfield_Downhole_Video.BakersfieldDHV();
            this.cAM_DATATableAdapter = new Bakersfield_Downhole_Video.BakersfieldDHVTableAdapters.CAM_DATATableAdapter();
            this.cAMCOLLECTEDFORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAM_COLLECTEDFORTableAdapter = new Bakersfield_Downhole_Video.BakersfieldDHVTableAdapters.CAM_COLLECTEDFORTableAdapter();
            this.cAMDATABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bakersfieldDHV1 = new Bakersfield_Downhole_Video.BakersfieldDHV();
            this.bakersfieldDHV2 = new Bakersfield_Downhole_Video.BakersfieldDHV();
            this.cAMCOMPANYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAM_COMPANYTableAdapter = new Bakersfield_Downhole_Video.BakersfieldDHVTableAdapters.CAM_COMPANYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMDATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakersfieldDHV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMCOLLECTEDFORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMDATABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakersfieldDHV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakersfieldDHV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMCOMPANYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Information Gathered";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "http://bakersfielddhv.com/images/bdhv_logo.png";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cAMDATABindingSource
            // 
            this.cAMDATABindingSource.DataMember = "CAM_DATA";
            this.cAMDATABindingSource.DataSource = this.bakersfieldDHV;
            // 
            // bakersfieldDHV
            // 
            this.bakersfieldDHV.DataSetName = "BakersfieldDHV";
            this.bakersfieldDHV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAM_DATATableAdapter
            // 
            this.cAM_DATATableAdapter.ClearBeforeFill = true;
            // 
            // cAMCOLLECTEDFORBindingSource
            // 
            this.cAMCOLLECTEDFORBindingSource.DataMember = "CAM_COLLECTEDFOR";
            this.cAMCOLLECTEDFORBindingSource.DataSource = this.bakersfieldDHV;
            // 
            // cAM_COLLECTEDFORTableAdapter
            // 
            this.cAM_COLLECTEDFORTableAdapter.ClearBeforeFill = true;
            // 
            // cAMDATABindingSource1
            // 
            this.cAMDATABindingSource1.DataMember = "CAM_DATA";
            this.cAMDATABindingSource1.DataSource = this.bakersfieldDHV;
            // 
            // bakersfieldDHV1
            // 
            this.bakersfieldDHV1.DataSetName = "BakersfieldDHV";
            this.bakersfieldDHV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bakersfieldDHV2
            // 
            this.bakersfieldDHV2.DataSetName = "BakersfieldDHV";
            this.bakersfieldDHV2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAMCOMPANYBindingSource
            // 
            this.cAMCOMPANYBindingSource.DataMember = "CAM_COMPANY";
            this.cAMCOMPANYBindingSource.DataSource = this.bakersfieldDHV2;
            // 
            // cAM_COMPANYTableAdapter
            // 
            this.cAM_COMPANYTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(782, 736);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Bakersfield Downhole Video ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMDATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakersfieldDHV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMCOLLECTEDFORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMDATABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakersfieldDHV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakersfieldDHV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMCOMPANYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BakersfieldDHV bakersfieldDHV;
        private System.Windows.Forms.BindingSource cAMDATABindingSource;
        private BakersfieldDHVTableAdapters.CAM_DATATableAdapter cAM_DATATableAdapter;
        private System.Windows.Forms.BindingSource cAMCOLLECTEDFORBindingSource;
        private BakersfieldDHVTableAdapters.CAM_COLLECTEDFORTableAdapter cAM_COLLECTEDFORTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource cAMDATABindingSource1;
        private BakersfieldDHV bakersfieldDHV1;
        private BakersfieldDHV bakersfieldDHV2;
        private System.Windows.Forms.BindingSource cAMCOMPANYBindingSource;
        private BakersfieldDHVTableAdapters.CAM_COMPANYTableAdapter cAM_COMPANYTableAdapter;
    }
}

