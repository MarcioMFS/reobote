
namespace reobote.Relatorio
{
    partial class frmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.dtAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new reobote.Relatorio.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtDisciplinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtHabilidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDisciplinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHabilidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtAlunoBindingSource
            // 
            this.dtAlunoBindingSource.DataMember = "dtAluno";
            this.dtAlunoBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetHab";
            reportDataSource1.Value = this.dtHabilidadeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "reobote.Relatorio.relHabilidade.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(174, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1014, 486);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditarAluno.Location = new System.Drawing.Point(174, 538);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(112, 34);
            this.btnEditarAluno.TabIndex = 43;
            this.btnEditarAluno.Text = "Alunos";
            this.btnEditarAluno.UseVisualStyleBackColor = true;
            this.btnEditarAluno.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(292, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 43;
            this.button1.Text = "Notas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // dtDisciplinaBindingSource
            // 
            this.dtDisciplinaBindingSource.DataMember = "dtDisciplina";
            this.dtDisciplinaBindingSource.DataSource = this.DataSet1;
            // 
            // dtHabilidadeBindingSource
            // 
            this.dtHabilidadeBindingSource.DataMember = "dtHabilidade";
            this.dtHabilidadeBindingSource.DataSource = this.DataSet1;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditarAluno);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório - Sistema Reobote";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDisciplinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHabilidadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtAlunoBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dtDisciplinaBindingSource;
        private System.Windows.Forms.BindingSource dtHabilidadeBindingSource;
    }
}