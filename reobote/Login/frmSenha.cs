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

namespace reobote.Login
{
    public partial class frmSenha : Form
    {

        Conexao conn = new Conexao();
        string sql;
        string idPin;
        int etapas = 0;
        MySqlCommand execSql;


        public frmSenha()
        {
            InitializeComponent();
        }

        private void frmSenha_Load(object sender, EventArgs e)
        {
            this.Location = new Point(525,225);
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (etapas == 0)
            {
                if (txtSenha.TextLength == 6)
                {
                    btnOk.Enabled = true;
                }
                else
                {
                    btnOk.Enabled = false;
                }
            }
            else
            {
                if (txtSenha.TextLength >= 4)
                {
                    btnOk.Enabled = true;
                }
                else
                {
                    btnOk.Enabled = false;

                }
            }
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           
            if (etapas == 0)
            {
             
                conn.AbrirConexao();
                sql = "SELECT * FROM pin WHERE statusPin = 'ATIVO' AND numeroPin = @numero;";
                execSql = new MySqlCommand(sql, conn.conMySql);
                execSql.Parameters.AddWithValue("@numero", txtSenha.Text);
                MySqlDataReader dr1 = execSql.ExecuteReader();
                if (dr1.HasRows)
                {
                    btnEsqueceu.Visible = false;
                    txtSenha.Text = "Senha";
                    txtSenha.PasswordChar = '*';
                    lblTitulo.Text = "Nova Senha:";
                    etapas = 1;
                    while (dr1.Read())
                    {
                        idPin = Convert.ToString(dr1["idPin"]);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Pin Inválido", "Pin Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                conn.FecharConexao();
            }  

           else
            {
                


                try
                {
                    conn.AbrirConexao();
                    sql = "UPDATE pin SET senhaAdmin=@senha WHERE idPin = @idPin";
                    execSql = new MySqlCommand(sql, conn.conMySql);
                    execSql.Parameters.AddWithValue("@idPin", idPin);
                    execSql.Parameters.AddWithValue("@senha", txtSenha.Text);
                    execSql.ExecuteNonQuery();
                    conn.FecharConexao();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

                MessageBox.Show("Alterações feitas com Sucesso", "Alterações Salvas",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void btnEsqueceu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comunique o Administrador", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
