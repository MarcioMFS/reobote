
namespace reobote.Login
{
    partial class frmSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSenha));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnEsqueceu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(12, 126);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(131, 26);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Digite o PIN:";
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(17, 198);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(128, 37);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(17, 162);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(277, 30);
            this.txtSenha.TabIndex = 17;
            this.txtSenha.Click += new System.EventHandler(this.txtSenha_Click);
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(17, 162);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(277, 30);
            this.txtNome.TabIndex = 17;
            this.txtNome.Click += new System.EventHandler(this.txtNome_Click);
            this.txtNome.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(261, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(33, 33);
            this.btnFechar.TabIndex = 20;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnEsqueceu
            // 
            this.btnEsqueceu.BackColor = System.Drawing.Color.Transparent;
            this.btnEsqueceu.FlatAppearance.BorderSize = 0;
            this.btnEsqueceu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsqueceu.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsqueceu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEsqueceu.Location = new System.Drawing.Point(206, 198);
            this.btnEsqueceu.Name = "btnEsqueceu";
            this.btnEsqueceu.Size = new System.Drawing.Size(88, 26);
            this.btnEsqueceu.TabIndex = 19;
            this.btnEsqueceu.Text = "Esqueceu o Pin?";
            this.btnEsqueceu.UseVisualStyleBackColor = false;
            this.btnEsqueceu.Click += new System.EventHandler(this.btnEsqueceu_Click);
            // 
            // frmSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(306, 374);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnEsqueceu);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSenha";
            this.Text = "Alterar Senha - Sistema Reobote";
            this.Load += new System.EventHandler(this.frmSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnEsqueceu;
    }
}