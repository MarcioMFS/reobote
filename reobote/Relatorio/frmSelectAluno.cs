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

namespace reobote.Relatorio
{

    public partial class frmSelectAluno : Form
    {
        Conexao conn = new Conexao();
        string sql;
        MySqlCommand execSql;
        public string idAluno { get; set; }
        public string Notas { get; set; }
        public frmSelectAluno()
        {
            InitializeComponent();
        }

        private void frmSelectAluno_Load(object sender, EventArgs e)
        {
            ListarAlunos();
        }

        private void ListarAlunos()
        {
            
                cbAluno.Items.Clear();
                conn.AbrirConexao();
                sql = "SELECT idAluno, nomeAluno, notas FROM aluno WHERE statusAluno = 'ATIVO' ORDER BY statusAluno ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conMySql);

                MySqlDataAdapter conjDados = new MySqlDataAdapter(cmd);
                DataTable dadosTabela = new DataTable();
                conjDados.Fill(dadosTabela);

                if (dadosTabela.Rows.Count > 0)
                {
                    cbAluno.ValueMember = "idAluno";
                    cbAluno.DisplayMember = "nomeAluno";
                    cbAluno.DataSource = dadosTabela;

                }
                else
                {
                    cbAluno.Text = "Sem Aluno Cadastrado";
                }

            conn.FecharConexao();

            conn.AbrirConexao();
            sql = "SELECT idAluno, notas FROM aluno WHERE idAluno = @idAluno";
            execSql = new MySqlCommand(sql, conn.conMySql);
            execSql.Parameters.AddWithValue("@idAluno", idAluno);

            MySqlDataReader dr = execSql.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Notas = Convert.ToString(dr["notas"]);

                }
            }
            conn.FecharConexao();



        }

        private void btnSelectAluno_Click(object sender, EventArgs e)
        {
            idAluno = Convert.ToString(cbAluno.SelectedValue);
            this.Hide();
        }
    }
}
