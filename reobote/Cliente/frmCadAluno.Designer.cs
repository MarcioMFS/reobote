
namespace reobote.Cliente
{
    partial class frmCadAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadAluno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.Button();
            this.cbAval = new System.Windows.Forms.ComboBox();
            this.lblAval = new System.Windows.Forms.Label();
            this.btnAddAval = new System.Windows.Forms.Button();
            this.dgNotas = new System.Windows.Forms.DataGridView();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.cbServico = new System.Windows.Forms.ComboBox();
            this.cbStatusAluno = new System.Windows.Forms.ComboBox();
            this.lblServicos = new System.Windows.Forms.Label();
            this.lblResponsa = new System.Windows.Forms.Label();
            this.lblStatusAluno = new System.Windows.Forms.Label();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgAlunos = new System.Windows.Forms.DataGridView();
            this.btnDesativarAluno = new System.Windows.Forms.Button();
            this.btnCancelAluno = new System.Windows.Forms.Button();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.btnNovoAluno = new System.Windows.Forms.Button();
            this.btnSalvarAluno = new System.Windows.Forms.Button();
            this.cbExibir = new System.Windows.Forms.ComboBox();
            this.lblExibir = new System.Windows.Forms.Label();
            this.lblBuscaCPF = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dataNasc = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            resources.ApplyResources(this.btnFechar, "btnFechar");
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // cbAval
            // 
            resources.ApplyResources(this.cbAval, "cbAval");
            this.cbAval.FormattingEnabled = true;
            this.cbAval.Items.AddRange(new object[] {
            resources.GetString("cbAval.Items"),
            resources.GetString("cbAval.Items1")});
            this.cbAval.Name = "cbAval";
            this.cbAval.SelectedIndexChanged += new System.EventHandler(this.cbAval_SelectedIndexChanged);
            // 
            // lblAval
            // 
            resources.ApplyResources(this.lblAval, "lblAval");
            this.lblAval.BackColor = System.Drawing.Color.Transparent;
            this.lblAval.ForeColor = System.Drawing.Color.Black;
            this.lblAval.Name = "lblAval";
            // 
            // btnAddAval
            // 
            resources.ApplyResources(this.btnAddAval, "btnAddAval");
            this.btnAddAval.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAval.Name = "btnAddAval";
            this.btnAddAval.UseVisualStyleBackColor = false;
            this.btnAddAval.Click += new System.EventHandler(this.btnAddAval_Click);
            // 
            // dgNotas
            // 
            resources.ApplyResources(this.dgNotas, "dgNotas");
            this.dgNotas.AllowUserToAddRows = false;
            this.dgNotas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 10.25F);
            this.dgNotas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNotas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgNotas.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgNotas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Agency FB", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgNotas.EnableHeadersVisualStyles = false;
            this.dgNotas.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgNotas.MultiSelect = false;
            this.dgNotas.Name = "dgNotas";
            this.dgNotas.ReadOnly = true;
            this.dgNotas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Agency FB", 14.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgNotas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // cbHorario
            // 
            resources.ApplyResources(this.cbHorario, "cbHorario");
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Items.AddRange(new object[] {
            resources.GetString("cbHorario.Items"),
            resources.GetString("cbHorario.Items1")});
            this.cbHorario.Name = "cbHorario";
            // 
            // cbPais
            // 
            resources.ApplyResources(this.cbPais, "cbPais");
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Name = "cbPais";
            this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPais_SelectedIndexChanged);
            // 
            // cbServico
            // 
            resources.ApplyResources(this.cbServico, "cbServico");
            this.cbServico.FormattingEnabled = true;
            this.cbServico.Name = "cbServico";
            this.cbServico.SelectedIndexChanged += new System.EventHandler(this.cbServico_SelectedIndexChanged);
            // 
            // cbStatusAluno
            // 
            resources.ApplyResources(this.cbStatusAluno, "cbStatusAluno");
            this.cbStatusAluno.FormattingEnabled = true;
            this.cbStatusAluno.Items.AddRange(new object[] {
            resources.GetString("cbStatusAluno.Items"),
            resources.GetString("cbStatusAluno.Items1")});
            this.cbStatusAluno.Name = "cbStatusAluno";
            // 
            // lblServicos
            // 
            resources.ApplyResources(this.lblServicos, "lblServicos");
            this.lblServicos.BackColor = System.Drawing.Color.Transparent;
            this.lblServicos.ForeColor = System.Drawing.Color.Black;
            this.lblServicos.Name = "lblServicos";
            // 
            // lblResponsa
            // 
            resources.ApplyResources(this.lblResponsa, "lblResponsa");
            this.lblResponsa.BackColor = System.Drawing.Color.Transparent;
            this.lblResponsa.ForeColor = System.Drawing.Color.Black;
            this.lblResponsa.Name = "lblResponsa";
            // 
            // lblStatusAluno
            // 
            resources.ApplyResources(this.lblStatusAluno, "lblStatusAluno");
            this.lblStatusAluno.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusAluno.ForeColor = System.Drawing.Color.Black;
            this.lblStatusAluno.Name = "lblStatusAluno";
            // 
            // lblNotas
            // 
            resources.ApplyResources(this.lblNotas, "lblNotas");
            this.lblNotas.BackColor = System.Drawing.Color.Transparent;
            this.lblNotas.ForeColor = System.Drawing.Color.Black;
            this.lblNotas.Name = "lblNotas";
            // 
            // lblHorario
            // 
            resources.ApplyResources(this.lblHorario, "lblHorario");
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.ForeColor = System.Drawing.Color.Black;
            this.lblHorario.Name = "lblHorario";
            // 
            // lblNome
            // 
            resources.ApplyResources(this.lblNome, "lblNome");
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Name = "lblNome";
            // 
            // txtNome
            // 
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            // 
            // dgAlunos
            // 
            resources.ApplyResources(this.dgAlunos, "dgAlunos");
            this.dgAlunos.AllowUserToAddRows = false;
            this.dgAlunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 10.25F);
            this.dgAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAlunos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgAlunos.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Agency FB", 14.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgAlunos.EnableHeadersVisualStyles = false;
            this.dgAlunos.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgAlunos.MultiSelect = false;
            this.dgAlunos.Name = "dgAlunos";
            this.dgAlunos.ReadOnly = true;
            this.dgAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Agency FB", 14.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgAlunos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlunos_CellContentClick);
            // 
            // btnDesativarAluno
            // 
            resources.ApplyResources(this.btnDesativarAluno, "btnDesativarAluno");
            this.btnDesativarAluno.Name = "btnDesativarAluno";
            this.btnDesativarAluno.UseVisualStyleBackColor = true;
            this.btnDesativarAluno.Click += new System.EventHandler(this.btnDesativarAluno_Click);
            // 
            // btnCancelAluno
            // 
            resources.ApplyResources(this.btnCancelAluno, "btnCancelAluno");
            this.btnCancelAluno.Name = "btnCancelAluno";
            this.btnCancelAluno.UseVisualStyleBackColor = true;
            this.btnCancelAluno.Click += new System.EventHandler(this.btnCancelAluno_Click);
            // 
            // btnEditarAluno
            // 
            resources.ApplyResources(this.btnEditarAluno, "btnEditarAluno");
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.UseVisualStyleBackColor = true;
            this.btnEditarAluno.Click += new System.EventHandler(this.btnEditarAluno_Click);
            // 
            // btnNovoAluno
            // 
            resources.ApplyResources(this.btnNovoAluno, "btnNovoAluno");
            this.btnNovoAluno.Name = "btnNovoAluno";
            this.btnNovoAluno.UseVisualStyleBackColor = true;
            this.btnNovoAluno.Click += new System.EventHandler(this.btnNovoAluno_Click);
            // 
            // btnSalvarAluno
            // 
            resources.ApplyResources(this.btnSalvarAluno, "btnSalvarAluno");
            this.btnSalvarAluno.Name = "btnSalvarAluno";
            this.btnSalvarAluno.UseVisualStyleBackColor = true;
            this.btnSalvarAluno.Click += new System.EventHandler(this.btnSalvarAluno_Click);
            // 
            // cbExibir
            // 
            resources.ApplyResources(this.cbExibir, "cbExibir");
            this.cbExibir.FormattingEnabled = true;
            this.cbExibir.Items.AddRange(new object[] {
            resources.GetString("cbExibir.Items"),
            resources.GetString("cbExibir.Items1")});
            this.cbExibir.Name = "cbExibir";
            this.cbExibir.SelectedIndexChanged += new System.EventHandler(this.cbExibir_SelectedIndexChanged);
            // 
            // lblExibir
            // 
            resources.ApplyResources(this.lblExibir, "lblExibir");
            this.lblExibir.BackColor = System.Drawing.Color.Transparent;
            this.lblExibir.ForeColor = System.Drawing.Color.Black;
            this.lblExibir.Name = "lblExibir";
            // 
            // lblBuscaCPF
            // 
            resources.ApplyResources(this.lblBuscaCPF, "lblBuscaCPF");
            this.lblBuscaCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscaCPF.ForeColor = System.Drawing.Color.Black;
            this.lblBuscaCPF.Name = "lblBuscaCPF";
            // 
            // txtBusca
            // 
            resources.ApplyResources(this.txtBusca, "txtBusca");
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // dataNasc
            // 
            resources.ApplyResources(this.dataNasc, "dataNasc");
            this.dataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.Value = new System.DateTime(2021, 9, 10, 0, 0, 0, 0);
            // 
            // lblData
            // 
            resources.ApplyResources(this.lblData, "lblData");
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Name = "lblData";
            // 
            // frmCadAluno
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataNasc);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblBuscaCPF);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnAddAval);
            this.Controls.Add(this.cbExibir);
            this.Controls.Add(this.lblExibir);
            this.Controls.Add(this.btnDesativarAluno);
            this.Controls.Add(this.btnCancelAluno);
            this.Controls.Add(this.btnEditarAluno);
            this.Controls.Add(this.btnNovoAluno);
            this.Controls.Add(this.btnSalvarAluno);
            this.Controls.Add(this.dgAlunos);
            this.Controls.Add(this.cbAval);
            this.Controls.Add(this.lblAval);
            this.Controls.Add(this.dgNotas);
            this.Controls.Add(this.cbHorario);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.cbServico);
            this.Controls.Add(this.cbStatusAluno);
            this.Controls.Add(this.lblServicos);
            this.Controls.Add(this.lblResponsa);
            this.Controls.Add(this.lblStatusAluno);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmCadAluno";
            this.Load += new System.EventHandler(this.frmCadAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ComboBox cbAval;
        private System.Windows.Forms.Label lblAval;
        private System.Windows.Forms.Button btnAddAval;
        private System.Windows.Forms.DataGridView dgNotas;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.ComboBox cbStatusAluno;
        private System.Windows.Forms.Label lblServicos;
        private System.Windows.Forms.Label lblResponsa;
        private System.Windows.Forms.Label lblStatusAluno;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgAlunos;
        private System.Windows.Forms.Button btnDesativarAluno;
        private System.Windows.Forms.Button btnCancelAluno;
        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.Button btnNovoAluno;
        private System.Windows.Forms.Button btnSalvarAluno;
        private System.Windows.Forms.ComboBox cbExibir;
        private System.Windows.Forms.Label lblExibir;
        private System.Windows.Forms.Label lblBuscaCPF;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DateTimePicker dataNasc;
        private System.Windows.Forms.Label lblData;
    }
}