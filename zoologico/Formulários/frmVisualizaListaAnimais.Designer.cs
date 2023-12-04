namespace zoologico.Formulários
{
    partial class frmVisualizaListaAnimais
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Zoologico = new zoologico.Dados.DataSet_Zoologico();
            this.animaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animaisTableAdapter = new zoologico.Dados.DataSet_ZoologicoTableAdapters.AnimaisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Zoologico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Animais";
            reportDataSource1.Value = this.animaisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "zoologico.Relatórios.RelatorioAnimais.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Zoologico
            // 
            this.dataSet_Zoologico.DataSetName = "DataSet_Zoologico";
            this.dataSet_Zoologico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animaisBindingSource
            // 
            this.animaisBindingSource.DataMember = "Animais";
            this.animaisBindingSource.DataSource = this.dataSet_Zoologico;
            // 
            // animaisTableAdapter
            // 
            this.animaisTableAdapter.ClearBeforeFill = true;
            // 
            // FormfrmVisualizaListaAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormfrmVisualizaListaAnimais";
            this.Text = "FormfrmVisualizaListaAnimais";
            this.Load += new System.EventHandler(this.FormfrmVisualizaListaAnimais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Zoologico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Dados.DataSet_Zoologico dataSet_Zoologico;
        private System.Windows.Forms.BindingSource animaisBindingSource;
        private Dados.DataSet_ZoologicoTableAdapters.AnimaisTableAdapter animaisTableAdapter;
    }
}