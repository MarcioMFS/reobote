
namespace reobote.Relatorio
{
    partial class frmSelectAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectAluno));
            this.cbAluno = new System.Windows.Forms.ComboBox();
            this.lblServicos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAluno
            // 
            this.cbAluno.FormattingEnabled = true;
            this.cbAluno.Location = new System.Drawing.Point(114, 143);
            this.cbAluno.Margin = new System.Windows.Forms.Padding(6);
            this.cbAluno.Name = "cbAluno";
            this.cbAluno.Size = new System.Drawing.Size(362, 34);
            this.cbAluno.TabIndex = 33;
            // 
            // lblServicos
            // 
            this.lblServicos.AutoSize = true;
            this.lblServicos.BackColor = System.Drawing.Color.Transparent;
            this.lblServicos.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.lblServicos.ForeColor = System.Drawing.Color.Black;
            this.lblServicos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblServicos.Location = new System.Drawing.Point(29, 143);
            this.lblServicos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblServicos.Name = "lblServicos";
            this.lblServicos.Size = new System.Drawing.Size(73, 26);
            this.lblServicos.TabIndex = 32;
            this.lblServicos.Text = "Aluno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(88, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Selecione o aluno que deseja ver as notas:";
            // 
            // btnSelectAluno
            // 
            this.btnSelectAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectAluno.Location = new System.Drawing.Point(434, 225);
            this.btnSelectAluno.Name = "btnSelectAluno";
            this.btnSelectAluno.Size = new System.Drawing.Size(112, 34);
            this.btnSelectAluno.TabIndex = 45;
            this.btnSelectAluno.Text = "OK";
            this.btnSelectAluno.UseVisualStyleBackColor = true;
            this.btnSelectAluno.Click += new System.EventHandler(this.btnSelectAluno_Click);
            // 
            // frmSelectAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(558, 271);
            this.Controls.Add(this.btnSelectAluno);
            this.Controls.Add(this.cbAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblServicos);
            this.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSelectAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Aluno - Sistema Reobote";
            this.Load += new System.EventHandler(this.frmSelectAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAluno;
        private System.Windows.Forms.Label lblServicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectAluno;
    }
}