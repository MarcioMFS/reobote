
namespace reobote
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblBuscaCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblExibir = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbExibir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnAddAluno = new System.Windows.Forms.Button();
            this.cbAlunos = new System.Windows.Forms.ComboBox();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.lblStatusAluno = new System.Windows.Forms.Label();
            this.lblNotas = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1139, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(33, 33);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cbStatus.Location = new System.Drawing.Point(754, 238);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(136, 34);
            this.cbStatus.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(672, 244);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 26);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(235, 103);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(74, 26);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome:";
            // 
            // lblBuscaCPF
            // 
            this.lblBuscaCPF.AutoSize = true;
            this.lblBuscaCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscaCPF.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaCPF.ForeColor = System.Drawing.Color.Black;
            this.lblBuscaCPF.Location = new System.Drawing.Point(175, 53);
            this.lblBuscaCPF.Name = "lblBuscaCPF";
            this.lblBuscaCPF.Size = new System.Drawing.Size(138, 29);
            this.lblBuscaCPF.TabIndex = 8;
            this.lblBuscaCPF.Text = "Buscar CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(319, 100);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(345, 31);
            this.txtNome.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(678, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 26);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(754, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(406, 31);
            this.txtEmail.TabIndex = 4;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(754, 147);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(406, 31);
            this.txtSenha.TabIndex = 4;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(672, 152);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(76, 26);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha:";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(319, 147);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(345, 31);
            this.txtEnd.TabIndex = 4;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblEnd.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.Black;
            this.lblEnd.Location = new System.Drawing.Point(166, 154);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(108, 26);
            this.lblEnd.TabIndex = 7;
            this.lblEnd.Text = "Endereço:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(319, 194);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(345, 31);
            this.txtBairro.TabIndex = 4;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.Black;
            this.lblBairro.Location = new System.Drawing.Point(200, 204);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(74, 26);
            this.lblBairro.TabIndex = 7;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblExibir
            // 
            this.lblExibir.AutoSize = true;
            this.lblExibir.BackColor = System.Drawing.Color.Transparent;
            this.lblExibir.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibir.ForeColor = System.Drawing.Color.Black;
            this.lblExibir.Location = new System.Drawing.Point(174, 6);
            this.lblExibir.Name = "lblExibir";
            this.lblExibir.Size = new System.Drawing.Size(54, 34);
            this.lblExibir.TabIndex = 6;
            this.lblExibir.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Responsáveis",
            "Alunos"});
            this.cbTipo.Location = new System.Drawing.Point(248, 6);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(165, 34);
            this.cbTipo.TabIndex = 9;
            this.cbTipo.Text = "Responsáveis";
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // gridCliente
            // 
            this.gridCliente.AllowUserToAddRows = false;
            this.gridCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridCliente.BackgroundColor = System.Drawing.Color.LightGray;
            this.gridCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCliente.ColumnHeadersHeight = 30;
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCliente.EnableHeadersVisualStyles = false;
            this.gridCliente.GridColor = System.Drawing.Color.DodgerBlue;
            this.gridCliente.Location = new System.Drawing.Point(258, 328);
            this.gridCliente.MultiSelect = false;
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.ReadOnly = true;
            this.gridCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCliente.Size = new System.Drawing.Size(902, 171);
            this.gridCliente.TabIndex = 10;
            this.gridCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCliente_CellClick);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(258, 515);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(132, 34);
            this.btnDesativar.TabIndex = 11;
            this.btnDesativar.Text = "DESATIVAR";
            this.btnDesativar.UseVisualStyleBackColor = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(652, 515);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 34);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(465, 515);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 34);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(861, 515);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(112, 34);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(1048, 515);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 34);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbExibir
            // 
            this.cbExibir.FormattingEnabled = true;
            this.cbExibir.Items.AddRange(new object[] {
            "ATIVOS",
            "INATIVOS"});
            this.cbExibir.Location = new System.Drawing.Point(329, 288);
            this.cbExibir.Name = "cbExibir";
            this.cbExibir.Size = new System.Drawing.Size(136, 34);
            this.cbExibir.TabIndex = 17;
            this.cbExibir.SelectedIndexChanged += new System.EventHandler(this.cbExibir_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(253, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Exibir:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(754, 194);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(406, 31);
            this.txtTel.TabIndex = 4;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.Black;
            this.lblTel.Location = new System.Drawing.Point(706, 199);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(42, 26);
            this.lblTel.TabIndex = 7;
            this.lblTel.Text = "Tel:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.Black;
            this.lblCPF.Location = new System.Drawing.Point(200, 246);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(56, 26);
            this.lblCPF.TabIndex = 7;
            this.lblCPF.Text = "CPF:";
            // 
            // btnAddAluno
            // 
            this.btnAddAluno.Location = new System.Drawing.Point(976, 288);
            this.btnAddAluno.Name = "btnAddAluno";
            this.btnAddAluno.Size = new System.Drawing.Size(184, 34);
            this.btnAddAluno.TabIndex = 18;
            this.btnAddAluno.Text = "Adicionar Aluno";
            this.btnAddAluno.UseVisualStyleBackColor = true;
            this.btnAddAluno.Visible = false;
            this.btnAddAluno.Click += new System.EventHandler(this.btnAddAluno_Click);
            // 
            // cbAlunos
            // 
            this.cbAlunos.FormattingEnabled = true;
            this.cbAlunos.Location = new System.Drawing.Point(754, 288);
            this.cbAlunos.Name = "cbAlunos";
            this.cbAlunos.Size = new System.Drawing.Size(216, 34);
            this.cbAlunos.TabIndex = 19;
            this.cbAlunos.Visible = false;
            // 
            // lblAlunos
            // 
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.BackColor = System.Drawing.Color.Transparent;
            this.lblAlunos.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlunos.ForeColor = System.Drawing.Color.Black;
            this.lblAlunos.Location = new System.Drawing.Point(577, 294);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(172, 26);
            this.lblAlunos.TabIndex = 6;
            this.lblAlunos.Text = "Responsável por:";
            this.lblAlunos.Visible = false;
            // 
            // lblStatusAluno
            // 
            this.lblStatusAluno.AutoSize = true;
            this.lblStatusAluno.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusAluno.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusAluno.ForeColor = System.Drawing.Color.Black;
            this.lblStatusAluno.Location = new System.Drawing.Point(672, 103);
            this.lblStatusAluno.Name = "lblStatusAluno";
            this.lblStatusAluno.Size = new System.Drawing.Size(77, 26);
            this.lblStatusAluno.TabIndex = 6;
            this.lblStatusAluno.Text = "Status:";
            this.lblStatusAluno.Visible = false;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.BackColor = System.Drawing.Color.Transparent;
            this.lblNotas.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.ForeColor = System.Drawing.Color.Black;
            this.lblNotas.Location = new System.Drawing.Point(678, 154);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(71, 26);
            this.lblNotas.TabIndex = 7;
            this.lblNotas.Text = "Notas:";
            this.lblNotas.Visible = false;
            // 
            // txtCPF
            // 
            this.txtCPF.Culture = new System.Globalization.CultureInfo("");
            this.txtCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCPF.Location = new System.Drawing.Point(319, 239);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(345, 31);
            this.txtCPF.TabIndex = 20;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(319, 53);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(841, 31);
            this.txtBusca.TabIndex = 5;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.cbAlunos);
            this.Controls.Add(this.btnAddAluno);
            this.Controls.Add(this.cbExibir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gridCliente);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblExibir);
            this.Controls.Add(this.lblStatusAluno);
            this.Controls.Add(this.lblAlunos);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblBuscaCPF);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnFechar);
            this.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCliente";
            this.Text = "Cliente - Sistema Reobote";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblBuscaCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblExibir;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbExibir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnAddAluno;
        private System.Windows.Forms.ComboBox cbAlunos;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Label lblStatusAluno;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TextBox txtBusca;
    }
}