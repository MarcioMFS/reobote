
namespace reobote.Func
{
    partial class frmFunc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFunc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridFunc = new System.Windows.Forms.DataGridView();
            this.cbExibir = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblFunc = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.cbServico = new System.Windows.Forms.ComboBox();
            this.lblServicos = new System.Windows.Forms.Label();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFunc
            // 
            this.gridFunc.AllowUserToAddRows = false;
            this.gridFunc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridFunc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFunc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridFunc.BackgroundColor = System.Drawing.Color.LightGray;
            this.gridFunc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFunc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.gridFunc, "gridFunc");
            this.gridFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridFunc.EnableHeadersVisualStyles = false;
            this.gridFunc.GridColor = System.Drawing.Color.DodgerBlue;
            this.gridFunc.MultiSelect = false;
            this.gridFunc.Name = "gridFunc";
            this.gridFunc.ReadOnly = true;
            this.gridFunc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 14.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFunc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridServico_CellContentClick);
            // 
            // cbExibir
            // 
            this.cbExibir.FormattingEnabled = true;
            this.cbExibir.Items.AddRange(new object[] {
            resources.GetString("cbExibir.Items"),
            resources.GetString("cbExibir.Items1")});
            resources.ApplyResources(this.cbExibir, "cbExibir");
            this.cbExibir.Name = "cbExibir";
            this.cbExibir.SelectedIndexChanged += new System.EventHandler(this.cbExibir_SelectedIndexChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            resources.GetString("cbStatus.Items"),
            resources.GetString("cbStatus.Items1")});
            resources.ApplyResources(this.cbStatus, "cbStatus");
            this.cbStatus.Name = "cbStatus";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Name = "lblStatus";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // lblNome
            // 
            resources.ApplyResources(this.lblNome, "lblNome");
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Name = "lblNome";
            // 
            // lblFunc
            // 
            resources.ApplyResources(this.lblFunc, "lblFunc");
            this.lblFunc.BackColor = System.Drawing.Color.Transparent;
            this.lblFunc.ForeColor = System.Drawing.Color.Black;
            this.lblFunc.Name = "lblFunc";
            // 
            // txtNome
            // 
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnFechar, "btnFechar");
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // txtCpf
            // 
            this.txtCpf.Culture = new System.Globalization.CultureInfo("");
            this.txtCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            resources.ApplyResources(this.txtCpf, "txtCpf");
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbServico
            // 
            this.cbServico.FormattingEnabled = true;
            resources.ApplyResources(this.cbServico, "cbServico");
            this.cbServico.Name = "cbServico";
            // 
            // lblServicos
            // 
            resources.ApplyResources(this.lblServicos, "lblServicos");
            this.lblServicos.BackColor = System.Drawing.Color.Transparent;
            this.lblServicos.ForeColor = System.Drawing.Color.Black;
            this.lblServicos.Name = "lblServicos";
            // 
            // btnDesativar
            // 
            resources.ApplyResources(this.btnDesativar, "btnDesativar");
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.UseVisualStyleBackColor = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            resources.ApplyResources(this.btnEditar, "btnEditar");
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            resources.ApplyResources(this.btnNovo, "btnNovo");
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            resources.ApplyResources(this.btnSalvar, "btnSalvar");
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbNivel
            // 
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            resources.GetString("cbNivel.Items"),
            resources.GetString("cbNivel.Items1"),
            resources.GetString("cbNivel.Items2"),
            resources.GetString("cbNivel.Items3")});
            resources.ApplyResources(this.cbNivel, "cbNivel");
            this.cbNivel.Name = "cbNivel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // txtBusca
            // 
            resources.ApplyResources(this.txtBusca, "txtBusca");
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // txtSalario
            // 
            resources.ApplyResources(this.txtSalario, "txtSalario");
            this.txtSalario.Name = "txtSalario";
            // 
            // lblSalario
            // 
            resources.ApplyResources(this.lblSalario, "lblSalario");
            this.lblSalario.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario.ForeColor = System.Drawing.Color.Black;
            this.lblSalario.Name = "lblSalario";
            // 
            // frmFunc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbNivel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbServico);
            this.Controls.Add(this.lblServicos);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.gridFunc);
            this.Controls.Add(this.cbExibir);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblFunc);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFunc";
            this.Load += new System.EventHandler(this.frmFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridFunc;
        private System.Windows.Forms.ComboBox cbExibir;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.Label lblServicos;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
    }
}