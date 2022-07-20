using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reobote
{
    public partial class frmLogin : Form
    {
        Conexao conn = new Conexao();
        string sql;
        MySqlCommand execSql;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {


            pnlLogin.Location = new Point(
                           this.ClientSize.Width / 2 - pnlLogin.Size.Width / 2,
                           this.ClientSize.Height / 2 - pnlLogin.Size.Height / 2);
            pnlLogin.Anchor = AnchorStyles.None;

            btnLogar.FlatAppearance.MouseOverBackColor = Color.FromArgb(138, 199, 225);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            EfetuarLogin();
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EfetuarLogin();
            }
        }

        private void EfetuarLogin()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o nome", "DADOS INCOMPLETOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }


            if (txtSenha.Text == "")
            {
                MessageBox.Show("Preencha a Senha", "DADOS INCOMPLETOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }


            conn.AbrirConexao();
            sql = "SELECT * FROM pin WHERE statusPin = 'ATIVO' AND nomeAdmin = @nome AND senhaAdmin = @senha";
            execSql = new MySqlCommand(sql, conn.conMySql);
            execSql.Parameters.AddWithValue("@nome", txtNome.Text);
            execSql.Parameters.AddWithValue("@senha", txtSenha.Text);
            MySqlDataReader dr1 = execSql.ExecuteReader();
            if (dr1.HasRows)
            {
                MessageBox.Show("Bem-vindo", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.ShowDialog();

                txtSenha.Text = "";
                txtNome.Text = "";
            }
            else
            {
                MessageBox.Show("Dados Incorretos", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }






        }

        private void AniversarianteDoDia()
        {
            conn.AbrirConexao();
            sql = "SELECT * FROM pin WHERE statusPin = 'ATIVO' AND nomeAdmin = @nome AND senhaAdmin = @senha";
            execSql = new MySqlCommand(sql, conn.conMySql);
            execSql.Parameters.AddWithValue("@nome", txtNome.Text);
            execSql.Parameters.AddWithValue("@senha", txtSenha.Text);
            MySqlDataReader dr1 = execSql.ExecuteReader();
            if (dr1.HasRows)
            {
                while (dr1.Read())
                {
                }
            }
            }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            Login.frmSenha frmSenha = new Login.frmSenha();
            frmSenha.ShowDialog();
        }
    }
}
