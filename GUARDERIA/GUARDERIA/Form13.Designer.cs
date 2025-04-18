namespace GUARDERIA
{
    partial class Form13
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.datsalon2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datsalon2 = new GUARDERIA.Datsalon2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gUARDERIADataSet8 = new GUARDERIA.GUARDERIADataSet8();
            this.sALONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sALONTableAdapter = new GUARDERIA.GUARDERIADataSet8TableAdapters.SALONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datsalon2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datsalon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datsalon2BindingSource
            // 
            this.datsalon2BindingSource.DataSource = this.datsalon2;
            this.datsalon2BindingSource.Position = 0;
            // 
            // datsalon2
            // 
            this.datsalon2.DataSetName = "Datsalon2";
            this.datsalon2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Datasalon";
            reportDataSource1.Value = this.sALONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUARDERIA.Resalon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // gUARDERIADataSet8
            // 
            this.gUARDERIADataSet8.DataSetName = "GUARDERIADataSet8";
            this.gUARDERIADataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sALONBindingSource
            // 
            this.sALONBindingSource.DataMember = "SALON";
            this.sALONBindingSource.DataSource = this.gUARDERIADataSet8;
            // 
            // sALONTableAdapter
            // 
            this.sALONTableAdapter.ClearBeforeFill = true;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form13";
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datsalon2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datsalon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datsalon2BindingSource;
        private Datsalon2 datsalon2;
        private GUARDERIADataSet8 gUARDERIADataSet8;
        private System.Windows.Forms.BindingSource sALONBindingSource;
        private GUARDERIADataSet8TableAdapters.SALONTableAdapter sALONTableAdapter;
    }
}