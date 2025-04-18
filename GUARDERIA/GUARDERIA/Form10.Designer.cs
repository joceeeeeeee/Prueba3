namespace GUARDERIA
{
    partial class Form10
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
            this.eXPEDATA1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPEDATA1 = new GUARDERIA.EXPEDATA();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.eXPEDATA = new GUARDERIA.EXPEDATA();
            this.eXPEDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPEDIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPEDIENTETableAdapter = new GUARDERIA.EXPEDATATableAdapters.EXPEDIENTETableAdapter();
            this.gUARDERIADataSet5 = new GUARDERIA.GUARDERIADataSet5();
            this.eXPEDIENTEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eXPEDIENTETableAdapter1 = new GUARDERIA.GUARDERIADataSet5TableAdapters.EXPEDIENTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eXPEDATA1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPEDATA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPEDATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPEDATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPEDIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPEDIENTEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // eXPEDATA1BindingSource
            // 
            this.eXPEDATA1BindingSource.DataSource = this.eXPEDATA1;
            this.eXPEDATA1BindingSource.Position = 0;
            // 
            // eXPEDATA1
            // 
            this.eXPEDATA1.DataSetName = "EXPEDATA";
            this.eXPEDATA1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DATAEXPE";
            reportDataSource1.Value = this.eXPEDIENTEBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUARDERIA.REEPOEXPE.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1225, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // eXPEDATA
            // 
            this.eXPEDATA.DataSetName = "EXPEDATA";
            this.eXPEDATA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXPEDATABindingSource
            // 
            this.eXPEDATABindingSource.DataSource = this.eXPEDATA;
            this.eXPEDATABindingSource.Position = 0;
            // 
            // eXPEDIENTEBindingSource
            // 
            this.eXPEDIENTEBindingSource.DataMember = "EXPEDIENTE";
            this.eXPEDIENTEBindingSource.DataSource = this.eXPEDATABindingSource;
            // 
            // eXPEDIENTETableAdapter
            // 
            this.eXPEDIENTETableAdapter.ClearBeforeFill = true;
            // 
            // gUARDERIADataSet5
            // 
            this.gUARDERIADataSet5.DataSetName = "GUARDERIADataSet5";
            this.gUARDERIADataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXPEDIENTEBindingSource1
            // 
            this.eXPEDIENTEBindingSource1.DataMember = "EXPEDIENTE";
            this.eXPEDIENTEBindingSource1.DataSource = this.gUARDERIADataSet5;
            // 
            // eXPEDIENTETableAdapter1
            // 
            this.eXPEDIENTETableAdapter1.ClearBeforeFill = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eXPEDATA1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPEDATA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPEDATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPEDATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPEDIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUARDERIADataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPEDIENTEBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource eXPEDATABindingSource;
        private EXPEDATA eXPEDATA;
        private System.Windows.Forms.BindingSource eXPEDIENTEBindingSource;
        private EXPEDATATableAdapters.EXPEDIENTETableAdapter eXPEDIENTETableAdapter;
        private System.Windows.Forms.BindingSource eXPEDATA1BindingSource;
        private EXPEDATA eXPEDATA1;
        private GUARDERIADataSet5 gUARDERIADataSet5;
        private System.Windows.Forms.BindingSource eXPEDIENTEBindingSource1;
        private GUARDERIADataSet5TableAdapters.EXPEDIENTETableAdapter eXPEDIENTETableAdapter1;
    }
}