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
    public partial class frmPrincipal : Form
    {
        Conexao conn = new Conexao();
        string sql;
        int dia;
        int mes;
        string ano;
        string horario;
        int idade;
        string aniversariante;
        string diaAniver;
        bool isDayofBirth;
        bool isPassedBirth;
        MySqlCommand execSql;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {


            pnlPrincipal.Location = new Point(
                           this.ClientSize.Width / 2 - pnlPrincipal.Size.Width / 2,
                           this.ClientSize.Height / 2 - pnlPrincipal.Size.Height / 2);
            pnlPrincipal.Anchor = AnchorStyles.None;

            pnlLogo.Location = new Point(
                           this.pnlPrincipal.Width / 2 - pnlLogo.Size.Width / 2,
                          3);
            pnlPrincipal.Anchor = AnchorStyles.None;

            aniversario();


        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            pnlPrincipal.Location = new Point(this.Width / 2 - pnlPrincipal.Width / 2, this.Height / 2 - pnlPrincipal.Height / 2);
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnServ_Click(object sender, EventArgs e)
        {
            frmServico frmServico = new frmServico();
            frmServico.ShowDialog();
        }

        private void btnCli_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.ShowDialog();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            Func.frmFunc frmFunc = new Func.frmFunc();
            frmFunc.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio.frmRelatorio frmRelatorio = new Relatorio.frmRelatorio();
            frmRelatorio.ShowDialog();
        }

        private void aniversario()
        {
            dia = DateTime.Today.Day;
            mes = DateTime.Today.Month;





            conn.AbrirConexao();
            sql = "SELECT *, YEAR(dataNascAluno),DAY(dataNascAluno) FROM aluno WHERE MONTH(dataNascAluno) = @mes AND statusAluno = 'ATIVO'";
            execSql = new MySqlCommand(sql, conn.conMySql);
            execSql.Parameters.AddWithValue("@mes", mes);
            MySqlDataReader dr = execSql.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aniversariante = Convert.ToString(dr["nomeAluno"]);
                    ano = Convert.ToString(dr["YEAR(dataNascAluno)"]);
                    horario = Convert.ToString(dr["horarioAluno"]);
                    diaAniver = Convert.ToString(dr["DAY(dataNascAluno)"]);
                    idade = DateTime.Today.Year - Convert.ToInt32(ano);
                    isDayofBirth = Convert.ToInt32(diaAniver) == dia;
                    isPassedBirth = Convert.ToInt32(diaAniver) < dia;


                    if (isDayofBirth == false)
                    {
                        if (isPassedBirth == false)
                        {
                            MessageBox.Show("Aniversariante do mês " + aniversariante + " faz " + idade + " anos dia " + diaAniver + "/" + mes, "Aniversariante do Mês", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }


                    conn.FecharConexao();
                }

                if (isDayofBirth)
                {
                    conn.AbrirConexao();
                    sql = "SELECT *, YEAR(dataNascAluno) FROM aluno WHERE MONTH(dataNascAluno) = @mes AND DAY(dataNascAluno) = @dia AND statusAluno = 'ATIVO'";
                    execSql = new MySqlCommand(sql, conn.conMySql);
                    execSql.Parameters.AddWithValue("@mes", mes);
                    execSql.Parameters.AddWithValue("@dia", dia);
                    MySqlDataReader dt1 = execSql.ExecuteReader();
                    if (dt1.HasRows)
                    {
                        btnAniver.Visible = true;
                        while (dt1.Read())
                        {
                            aniversariante = Convert.ToString(dt1["nomeAluno"]);
                            ano = Convert.ToString(dt1["YEAR(dataNascAluno)"]);
                            idade = DateTime.Today.Year - Convert.ToInt32(ano);
                            MessageBox.Show("O Aniversariante " + aniversariante + " Fez " + idade + " Anos Hoje", "Aniversariantes do Dia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {

                        btnAniver.Visible = false;

                    }
                }





            }
        }

        private void btnAniver_Click(object sender, EventArgs e)
        {
            aniversario();
        }

        private void btnRel_Click(object sender, EventArgs e)
        {
            Relatorio.frmRelatorio frmRel = new Relatorio.frmRelatorio();
            frmRel.ShowDialog();
        }
    }
}
