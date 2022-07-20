using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reobote.Cliente
{
    public partial class frmCadAluno : Form
    {
        Conexao conn = new Conexao();
        string sql;
        string idPais;
        string aval;
        string idAluno;
        string idServico;
        string nomePais;
        string data;
        MySqlCommand execSql;
        public string Propiedade { get; set; }
        public string addAluno { get; set; }



        public frmCadAluno()
        {
            InitializeComponent();
        }

        private void frmCadAluno_Load(object sender, EventArgs e)
        {
            this.Location = new Point(91, 120);

            if (!this.addAluno.Equals(""))
            {
                addAluno = this.addAluno;
            }

            if(addAluno == "sim")
            {
                if (!this.Propiedade.Equals(""))
                {

                    idPais = this.Propiedade;

                }
            }

            cbExibir.Text = "ATIVOS";

            ListarServico();
            ListarResponsavel();
            ListAlunos();
            
            btnEditarAluno.Enabled = false;
            btnSalvarAluno.Enabled = false;
            btnDesativarAluno.Enabled = false;
            btnCancelAluno.Enabled = false;
            btnNovoAluno.Enabled = true;
            adicionarAluno();
            FormatarDG();
            dataNasc.Text = "";

        }

        private void adicionarAluno()
        {
            if (addAluno == "sim")
            {
                Ativar();
            btnSalvarAluno.Enabled = true;
            btnNovoAluno.Enabled = false;
            btnCancelAluno.Enabled = true;
            cbExibir.Enabled = false;
            dgAlunos.Enabled = false;
            ListAlunos();
            }
            else
            {
                Desativar();
            }

        }

        private void Desativar()
        {
            txtNome.Enabled = false;
            cbStatusAluno.Enabled = false;
            cbStatusAluno.Text = "";
            cbAval.Enabled = false;
            cbAval.Text = "";
            cbPais.Enabled = false;
            cbPais.Text = "";
            cbHorario.Enabled = false;
            cbHorario.Text = "";
            cbServico.Enabled = false;
            cbServico.Text = "";
            dgNotas.Visible = false;
            btnAddAval.Visible = false;
            btnDesativarAluno.Enabled = false;
            btnCancelAluno.Enabled = false;
            btnEditarAluno.Enabled = false;
            btnNovoAluno.Enabled = true;
            btnSalvarAluno.Enabled = false;
            dataNasc.Enabled = false;
            dataNasc.Text = "";

        }

        private void Ativos()
        {
            conn.AbrirConexao();
            sql = "SELECT A.*, S.nomeServico, P.nomePais FROM aluno A INNER JOIN pais P ON P.idPais = A.idPais INNER JOIN servico S ON A.idServico = S.idServico WHERE A.statusAluno = 'ATIVO'";
            execSql = new MySqlCommand(sql, conn.conMySql);

            MySqlDataAdapter conjDados = new MySqlDataAdapter();
            conjDados.SelectCommand = execSql;

            DataTable dadosTabela = new DataTable();
            conjDados.Fill(dadosTabela);

            dgAlunos.DataSource = dadosTabela;
            conn.FecharConexao();
        }

        private void Inativos()
        {
            try
            {
                conn.AbrirConexao();
                sql = "SELECT A.*, S.nomeServico, P.nomePais FROM aluno A INNER JOIN pais P ON P.idPais = A.idPais INNER JOIN servico S ON A.idServico = S.idServico WHERE A.statusAluno = 'INATIVO'";
                execSql = new MySqlCommand(sql, conn.conMySql);

                MySqlDataAdapter conjDados = new MySqlDataAdapter();
                conjDados.SelectCommand = execSql;

                DataTable dadosTabela = new DataTable();
                conjDados.Fill(dadosTabela);

                dgAlunos.DataSource = dadosTabela;
                conn.FecharConexao();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Ativar()
        {
            txtNome.Enabled = true;
            cbStatusAluno.Enabled = true;
            cbAval.Enabled = true;
            cbPais.Enabled = true;
            cbHorario.Enabled = true;
            cbServico.Enabled = true;
            dataNasc.Enabled = true;
            dataNasc.Value = DateTime.Today;
        }

        private void VerificarExibir()
        {

            if (cbExibir.Text == "INATIVOS")
            {
                Inativos();
                btnDesativarAluno.Text = "ATIVAR";
            }

            if (cbExibir.Text == "ATIVOS")
            {
                Ativos();
                btnDesativarAluno.Text = "DESATIVAR";
            }
        }

        private void ListarServico()
        {
            cbServico.Items.Clear();
            conn.AbrirConexao();
            sql = "SELECT idServico, nomeServico FROM servico WHERE statusServico = 'ATIVO' ORDER BY nomeServico ASC";
            MySqlCommand cmd = new MySqlCommand(sql, conn.conMySql);

            MySqlDataAdapter conjDados = new MySqlDataAdapter(cmd);
            DataTable dadosTabela = new DataTable();
            conjDados.Fill(dadosTabela);

            if (dadosTabela.Rows.Count > 0)
            {
                cbServico.ValueMember = "idServico";
                cbServico.DisplayMember = "nomeServico";
                cbServico.DataSource = dadosTabela;

            }
            else
            {
                cbServico.Text = "Sem Servico Cadastrado";
            }
            conn.FecharConexao();
            
        }

        private void ListarAval()
        {

            if (aval == "NOTAS")
            {
                conn.AbrirConexao();
                sql = "SELECT D.*, A.nomeAluno, F.nomeFunc FROM disciplina D INNER JOIN aluno A ON D.idAluno = A.idAluno INNER JOIN funcionario F ON D.idFunc = F.idFunc WHERE D.idAluno = @idAluno AND A.statusAluno = 'ATIVO' AND D.disciplinaStatus = 'ATIVO' AND F.nivelFunc = 'Professor' ORDER BY A.nomeAluno";
                execSql = new MySqlCommand(sql, conn.conMySql);

                execSql.Parameters.AddWithValue("@idAluno", idAluno);

                MySqlDataAdapter conjDados = new MySqlDataAdapter();
                conjDados.SelectCommand = execSql;

                DataTable dadosTabela = new DataTable();
                conjDados.Fill(dadosTabela);

                dgNotas.DataSource = dadosTabela;

                conn.FecharConexao();

                dgNotas.Columns[0].Visible = false;
                dgNotas.Columns[1].HeaderText = "Disciplina";
                dgNotas.Columns[2].HeaderText = "Nota";
                dgNotas.Columns[3].HeaderText = "Desc";
                dgNotas.Columns[4].HeaderText = "Data";
                dgNotas.Columns[5].HeaderText = "Status";
                dgNotas.Columns[6].Visible = false;
                dgNotas.Columns[7].Visible = false;
                dgNotas.Columns[8].Visible = false;
                dgNotas.Columns[9].HeaderText = "Professor";

            }
            else
            {
                conn.AbrirConexao();
                sql = "SELECT H.* FROM habilidades H INNER JOIN aluno A ON H.idAluno = A.idAluno WHERE H.idAluno = @idAluno AND A.statusAluno = 'ATIVO' AND H.statusHabilidade = 'ATIVO' ORDER BY A.nomeAluno";
                execSql = new MySqlCommand(sql, conn.conMySql);

                execSql.Parameters.AddWithValue("@idAluno", idAluno);

                MySqlDataAdapter conjDados = new MySqlDataAdapter();
                conjDados.SelectCommand = execSql;

                DataTable dadosTabela = new DataTable();
                conjDados.Fill(dadosTabela);

                dgNotas.DataSource = dadosTabela;

                conn.FecharConexao();
                
                dgNotas.Columns[0].Visible = false;
                dgNotas.Columns[1].HeaderText = "Habilidade";
                dgNotas.Columns[2].HeaderText = "Estado";
                dgNotas.Columns[3].HeaderText = "Status";
                dgNotas.Columns[4].HeaderText = "OBS";
                dgNotas.Columns[5].Visible = false;
            }


        }

        private void ListAlunos()
        {
            conn.AbrirConexao();
            sql = "SELECT A.*, S.nomeServico, P.nomePais FROM aluno A INNER JOIN pais P ON P.idPais = A.idPais INNER JOIN servico S ON A.idServico = S.idServico WHERE A.statusAluno = 'ATIVO'";
            execSql = new MySqlCommand(sql, conn.conMySql);

            MySqlDataAdapter conjDados = new MySqlDataAdapter();
            conjDados.SelectCommand = execSql;

            DataTable dadosTabela = new DataTable();
            conjDados.Fill(dadosTabela);

            dgAlunos.DataSource = dadosTabela;
            conn.FecharConexao();
        }

        private void BuscarCpf()
        {
            conn.AbrirConexao();
            sql = "SELECT A.*, S.nomeServico, P.nomePais FROM aluno A INNER JOIN pais P ON P.idPais = A.idPais INNER JOIN servico S ON A.idServico = S.idServico WHERE A.statusAluno = 'ATIVO' AND P.cpfPais = @cpf";
            execSql = new MySqlCommand(sql, conn.conMySql);

            execSql.Parameters.AddWithValue("@cpf", txtBusca.Text);

            MySqlDataAdapter conjDados = new MySqlDataAdapter();
            conjDados.SelectCommand = execSql;

            DataTable dadosTabela = new DataTable();
            conjDados.Fill(dadosTabela);

            dgAlunos.DataSource = dadosTabela;

            conn.FecharConexao();
        }

        private void FormatarDG()
        {


            dgAlunos.Columns[0].Visible = false;
            dgAlunos.Columns[1].HeaderText = "Aluno";
            dgAlunos.Columns[2].HeaderText = "Status";
            dgAlunos.Columns[3].HeaderText = "Valor";
            dgAlunos.Columns[3].HeaderText = "Nasc";
            dgAlunos.Columns[4].HeaderText = "Cadastro";
            dgAlunos.Columns[5].HeaderText = "Turno";
            dgAlunos.Columns[6].Visible = false;
            dgAlunos.Columns[7].Visible = false;
            dgAlunos.Columns[8].HeaderText = "Avaliação";
            dgAlunos.Columns[9].HeaderText = "Serviço";
            dgAlunos.Columns[10].HeaderText = "Responsável";



        }


        private void ListarResponsavel()
        {
            if(addAluno == "sim")
            {
                conn.AbrirConexao();
                sql = "SELECT idPais, nomePais FROM pais WHERE idPais = @idPais";
                execSql = new MySqlCommand(sql, conn.conMySql);
                execSql.Parameters.AddWithValue("@idPais", idPais);

                MySqlDataReader dr = execSql.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        idPais = Convert.ToString(dr["idPais"]);
                        nomePais = Convert.ToString(dr["nomePais"]);

                    }
                }
                cbPais.Text = nomePais;



            }
            else
            {
                cbPais.Visible = true;
                cbPais.DataSource = null;
                cbPais.Items.Clear();
                conn.AbrirConexao();
                sql = "SELECT idPais, nomePais FROM pais WHERE statusPais = 'ATIVO' ORDER BY nomePais ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conn.conMySql);

                MySqlDataAdapter conjDados = new MySqlDataAdapter(cmd);
                DataTable dadosTabela = new DataTable();
                conjDados.Fill(dadosTabela);

                if (dadosTabela.Rows.Count > 0)
                {
                    cbPais.ValueMember = "idPais";
                    cbPais.DisplayMember = "nomePais";
                    cbPais.DataSource = dadosTabela;

                }
                else
                {
                    cbPais.Text = "Sem Pais Cadastrados";

                }
                conn.FecharConexao();

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgNotas.Enabled = true;
            dgNotas.Visible = true;
            cbPais.Enabled = true;
            cbHorario.Enabled = true;
            cbServico.Enabled = true;
            cbStatusAluno.Enabled = true;
            cbAval.Enabled = true;
            btnAddAval.Visible = true;


            btnEditarAluno.Enabled = true;


            btnCancelAluno.Enabled = true;
            btnDesativarAluno.Enabled = true;
            btnSalvarAluno.Enabled = false;
            btnNovoAluno.Enabled = false;

            Ativar();

            idAluno = dgAlunos.CurrentRow.Cells[0].Value.ToString();

            txtNome.Text = dgAlunos.CurrentRow.Cells[1].Value.ToString();
            cbStatusAluno.Text = dgAlunos.CurrentRow.Cells[2].Value.ToString();
            data = dgAlunos.CurrentRow.Cells[3].Value.ToString();
            if (data == "01/01/0001 00:00:00")
            {
                dataNasc.Value = DateTime.Today;
            }
            else
            {
                dataNasc.Value = Convert.ToDateTime(data);


            }
            cbHorario.Text = dgAlunos.CurrentRow.Cells[5].Value.ToString();
            idPais = dgAlunos.CurrentRow.Cells[6].Value.ToString();
            idServico = dgAlunos.CurrentRow.Cells[7].Value.ToString();
            cbAval.Text = dgAlunos.CurrentRow.Cells[8].Value.ToString();
            aval = cbAval.Text;
            cbServico.Text = dgAlunos.CurrentRow.Cells[9].Value.ToString();
            cbPais.Text = dgAlunos.CurrentRow.Cells[10].Value.ToString();



            ListarAval();
            //ListarResponsavel();
        }

        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Campo nome vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (cbStatusAluno.Text == "")
            {
                MessageBox.Show("Campo status vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbStatusAluno.Focus();
                return;
            }

            if (cbServico.Text == "")
            {
                MessageBox.Show("Campo descrição vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbServico.Focus();
                return;
            }
            if (cbPais.Text == "")
            {
                MessageBox.Show("Campo Responsável vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbPais.Focus();
                return;
            }
            if (cbHorario.Text == "")
            {
                MessageBox.Show("Campo Horário vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbHorario.Focus();
                return;
            }
            if (cbAval.Text == "")
            {
                MessageBox.Show("Campo Avaliação vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbAval.Focus();
                return;
            }

            var resposta = MessageBox.Show("Deseja Salvar esse Cadastro?", "Salvar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {

                
                try
                {
                    conn.AbrirConexao();

                    sql = "INSERT INTO aluno(nomeAluno, statusAluno, dataNascAluno, horarioAluno, idPais, idServico, notas) VALUES (@nome,@status,@nasc,@horario,@idPais,@servico,@notas)";
                    execSql = new MySqlCommand(sql, conn.conMySql);
                    execSql.Parameters.AddWithValue("@nome", txtNome.Text);
                    execSql.Parameters.AddWithValue("@status", cbStatusAluno.Text);
                    execSql.Parameters.AddWithValue("@nasc", dataNasc.Value);
                    execSql.Parameters.AddWithValue("@horario", cbHorario.Text);
                    if (addAluno == "sim")
                    {
                        execSql.Parameters.AddWithValue("@idPais", idPais);
                    }
                    else
                    {
                        execSql.Parameters.AddWithValue("@idPais", cbPais.SelectedValue);

                    }

                    execSql.Parameters.AddWithValue("@servico", cbServico.SelectedValue);
                    execSql.Parameters.AddWithValue("@notas", cbAval.Text);

                    execSql.ExecuteNonQuery();
                    conn.FecharConexao();
                    VerificarExibir();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

                MessageBox.Show("Cadastro Efetuado!", "Cadastro Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);



                txtNome.Text = "";
                cbHorario.Text = "";
                cbStatusAluno.Text = "";
                cbPais.Text = "";
                cbServico.Text = "";
                cbAval.Text = "";


                txtNome.Enabled = false;
                cbHorario.Enabled = false;
                cbStatusAluno.Enabled = false;
                cbPais.Enabled = false;
                cbServico.Enabled = false;
                cbAval.Enabled = false;
                btnSalvarAluno.Enabled = false;
                btnCancelAluno.Enabled = false;
                btnNovoAluno.Enabled = true;
                cbExibir.Enabled = true;
                dgAlunos.Enabled = true;
            }
        }

        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            Ativar();
            btnSalvarAluno.Enabled = true;
            btnNovoAluno.Enabled = false;
            btnCancelAluno.Enabled = true;
            cbExibir.Enabled = false; 
            txtBusca.Enabled = false;
            dgAlunos.Enabled = false;
            ListAlunos();
        }

        

        private void btnCancelAluno_Click(object sender, EventArgs e)
        {

            if (addAluno == "sim")
            {

                var resposta1 = MessageBox.Show("Deseja realmente cancelar este processo?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta1 == DialogResult.Yes)
                {
                    this.Hide();
                }


            }

                var resposta = MessageBox.Show("Deseja realmente cancelar este processo?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                txtNome.Text = "";
                cbHorario.Text = "";
                cbStatusAluno.Text = "";
                cbPais.Text = "";
                cbServico.Text = "";
                cbAval.Text = "";
                MessageBox.Show("Processo Cancelado", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Desativar();
                btnSalvarAluno.Enabled = false;
                btnNovoAluno.Enabled = true;
                btnCancelAluno.Enabled = false;
                txtBusca.Enabled = true;
                btnEditarAluno.Enabled = false;
                cbExibir.Enabled = true;
                dgAlunos.Enabled = true;
            }
            ListAlunos();
            Desativar();
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja salvar alterações feitas nesse registro?", "Editar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    conn.AbrirConexao();
                    sql = "UPDATE aluno SET nomeAluno=@nome,statusAluno=@status,dataNascAluno=@nasc,horarioAluno=@horario,idPais=@idPais,idServico=@servico,notas=@notas WHERE idAluno = @idAluno";
                    execSql = new MySqlCommand(sql, conn.conMySql);

                    execSql = new MySqlCommand(sql, conn.conMySql);
                    execSql.Parameters.AddWithValue("@nome", txtNome.Text);
                    execSql.Parameters.AddWithValue("@status", cbStatusAluno.Text);
                    execSql.Parameters.AddWithValue("@nasc", dataNasc.Value);
                    execSql.Parameters.AddWithValue("@horario", cbHorario.Text);
                    execSql.Parameters.AddWithValue("@idPais", idPais);
                    execSql.Parameters.AddWithValue("@servico", idServico);
                    execSql.Parameters.AddWithValue("@notas", cbAval.Text);
                    execSql.Parameters.AddWithValue("@idAluno", idAluno);

                    execSql.ExecuteNonQuery();
                    conn.FecharConexao();
                    ListAlunos();
                    VerificarExibir();
                    Desativar();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                MessageBox.Show("Serviço Atualizado com Sucesso", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            btnEditarAluno.Enabled = false;
            btnSalvarAluno.Enabled = false;
            btnDesativarAluno.Enabled = false;
            btnCancelAluno.Enabled = false;
            btnNovoAluno.Enabled = true;
            txtNome.Text = "";
            cbHorario.Text = "";
            cbStatusAluno.Text = "";
            cbPais.Text = "";
            cbServico.Text = "";
            cbAval.Text = "";
        }

        private void btnDesativarAluno_Click(object sender, EventArgs e)
        {
 
             var resposta = MessageBox.Show("Deseja alterar o Status desse registro?", "Alterar Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    conn.AbrirConexao();
                    if (cbExibir.Text == "ATIVOS")
                    {
                        sql = "UPDATE aluno SET statusAluno='INATIVO' WHERE idAluno = @idAluno";
                    }
                    else
                    {
                        sql = "UPDATE aluno SET statusAluno='ATIVO' WHERE idAluno = @idAluno";
                    }

                    execSql = new MySqlCommand(sql, conn.conMySql);

                    execSql.Parameters.AddWithValue("idAluno", idAluno);

                    execSql.ExecuteNonQuery();
                    conn.FecharConexao();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

                MessageBox.Show("Status Alterado", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            ListAlunos();
            Desativar();
            VerificarExibir();

            btnEditarAluno.Enabled = false;
            btnDesativarAluno.Enabled = false;
            btnCancelAluno.Enabled = false;
            btnNovoAluno.Enabled = true;
            txtNome.Text = "";
            cbHorario.Text = "";
            cbStatusAluno.Text = "";
            cbPais.Text = "";
            cbServico.Text = "";
            cbAval.Text = "";
        }

       

        private void btnAddAval_Click(object sender, EventArgs e)
        {
            Cliente.frmCadAval frmCadAval = new Cliente.frmCadAval();
            frmCadAval.idAluno1 = idAluno;
            frmCadAval.aval1 = aval;
            frmCadAval.ShowDialog();


        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length == 11)
            {
                BuscarCpf();

            }
            else
            {
                ListAlunos();
            }
            FormatarDG();
        }

        private void cbAval_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAval.Text == "NOTAS")
            {
                aval = "NOTAS";
                ListarAval();

            }
            else
            {
                aval = "HABILIDADES";
                ListarAval();

            }
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPais = cbPais.SelectedValue.ToString();
        }

        private void cbExibir_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarExibir();

        }

        private void cbServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            idServico = cbServico.SelectedValue.ToString();
        }
    }
}
