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
    public partial class frmRelatorio : Form
    {
        Conexao conn = new Conexao();
        string sql;
        string idAluno;
        string notas;
        string Notas;
        MySqlCommand execSql;

        
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
        }

        private void ListarAlunos()
        {
            conn.AbrirConexao();
            sql = "SELECT A.*, S.nomeServico, P.nomePais FROM aluno A INNER JOIN pais P ON P.idPais = A.idPais INNER JOIN servico S ON A.idServico = S.idServico WHERE A.statusAluno = 'ATIVO'";
            execSql = new MySqlCommand(sql, conn.conMySql);

            MySqlDataAdapter conjDados = new MySqlDataAdapter();
            conjDados.SelectCommand = execSql;

            DataSet dadosTabela = new DataSet();
            dadosTabela.Clear();
            conjDados.Fill(dadosTabela);
            dadosTabela.Tables[0].TableName = "dtAluno";
            dtAlunoBindingSource.DataSource = dadosTabela;
            
            conn.FecharConexao();
        }


        private void ListarNotas()
        {

            if (Notas == "Notas")
            {
                conn.AbrirConexao();
                sql = "SELECT * FROM disciplina D INNER JOIN aluno A ON A.idAluno = D.idAluno WHERE D.disciplinaStatus = 'ATIVO' and A.idAluno = @idAluno";
                execSql = new MySqlCommand(sql, conn.conMySql);
                execSql.Parameters.AddWithValue("@idAluno", idAluno);

                MySqlDataAdapter conjDados = new MySqlDataAdapter();
                conjDados.SelectCommand = execSql;

                DataSet dadosTabela = new DataSet();
                dadosTabela.Clear();
                conjDados.Fill(dadosTabela);
                dadosTabela.Tables[0].TableName = "dtDisciplina";
                dtDisciplinaBindingSource.DataSource = dadosTabela;

                conn.FecharConexao();
            }
            else
            {
                conn.AbrirConexao();
                sql = "SELECT * FROM habilidades H INNER JOIN aluno A ON A.idAluno = H.idAluno WHERE H.statusHabilidade = 'ATIVO' and A.idAluno = @idAluno";
                execSql = new MySqlCommand(sql, conn.conMySql);
                execSql.Parameters.AddWithValue("@idAluno", idAluno);

                MySqlDataAdapter conjDados = new MySqlDataAdapter();
                conjDados.SelectCommand = execSql;

                DataSet dadosTabela = new DataSet();
                dadosTabela.Clear();
                conjDados.Fill(dadosTabela);
                dadosTabela.Tables[0].TableName = "dtHabilidade";
                dtHabilidadeBindingSource.DataSource = dadosTabela;
                conn.FecharConexao();
            }
            
        }

 

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            ListarAlunos();
            this.reportViewer1.RefreshReport();
        }



        private void btnNotas_Click(object sender, EventArgs e)
        {
            Relatorio.frmSelectAluno Select = new Relatorio.frmSelectAluno();
            Select.idAluno = idAluno;
            Select.Notas = Notas;

            Select.ShowDialog();
            ListarNotas();
            this.reportViewer1.RefreshReport();

        }

 
    }
}
