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

namespace reobote.Cliente
{
    public partial class frmCadAval : Form
    {

        Conexao conn = new Conexao();
        string sql;
        string idAluno;
        string aval;
        string idNota;
        string idProf;
        string idHabilidade;
        MySqlCommand execSql;
        public string idAluno1 { get; set; }
        public string aval1 { get; set; }


        public frmCadAval()
        {
            InitializeComponent();
        }

        private void frmCadAval_Load(object sender, EventArgs e)
        {

            this.Location = new Point(300, 120);

            if (!this.idAluno1.Equals(""))
            {
                idAluno = this.idAluno1;
                
            }

            


            if (!this.aval1.Equals(""))
            {
                aval = this.aval1;

            }

            Desativar();

            ListarDados();

            if (aval == "NOTAS")
            {
                lblAval.Text = "Nota: ";
                lblNome.Text = "Disciplina: ";
            }
            else
            {
                cbProf.Enabled = false;
                cbProf.Visible = false;
                lblProf.Visible = false;
                lblAval.Text = "Estado: ";
                lblNome.Text = "Habilidade: ";
            }

            dataCad.Text = "";

        }



        private void ListarDados()
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

                execSql.ExecuteNonQuery();
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
                dgNotas.Columns[6].Visible = false;
            }
        }


        

        private void ListarProf()
        {
            cbProf.DataSource = null;
            cbProf.Items.Clear();
            conn.AbrirConexao();
            sql = "SELECT * FROM funcionario WHERE nivelFunc = 'Professor' AND statusFunc = 'ATIVO'";
            MySqlCommand cmd = new MySqlCommand(sql, conn.conMySql);

            MySqlDataAdapter conjDados = new MySqlDataAdapter(cmd);
            DataTable dadosTabela = new DataTable();
            conjDados.Fill(dadosTabela);

            if (dadosTabela.Rows.Count > 0)
            {
                cbProf.ValueMember = "idFunc";
                cbProf.DisplayMember = "nomeFunc";
                cbProf.DataSource = dadosTabela;

            }
            else
            {
                cbProf.Text = "Sem Professor Cadastrado";
            }
            conn.FecharConexao();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Campo Nome vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (cbStatus.Text == "")
            {
                MessageBox.Show("Campo status vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbStatus.Focus();
                return;
            }
            if (txtAval.Text == "")
            {
                if (aval == "NOTAS")
                {
                
                    MessageBox.Show("Campo nota vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAval.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Campo Progresso vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAval.Focus();
                    return;
                }
            }


            if (aval == "NOTAS")
            {
                var resposta = MessageBox.Show("Deseja Salvar esse Cadastro de Nota?", "Salvar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        conn.AbrirConexao();

                        sql = "INSERT INTO disciplina(nomeDisciplina, notaDisciplina, dataDisciplina, obsDisciplina, disciplinaStatus, idAluno, idFunc) VALUES (@nome,@nota,@data,@obs,@status,@idAluno,@idProf)";
                        execSql = new MySqlCommand(sql, conn.conMySql);
                        execSql.Parameters.AddWithValue("@nome", txtNome.Text);
                        execSql.Parameters.AddWithValue("@nota", txtAval.Text);
                        execSql.Parameters.AddWithValue("@status", cbStatus.Text);
                        execSql.Parameters.AddWithValue("@data", dataCad.Value);
                        execSql.Parameters.AddWithValue("@obs", txtDesc.Text);
                        execSql.Parameters.AddWithValue("@idAluno", idAluno);
                        execSql.Parameters.AddWithValue("@idProf", cbProf.SelectedValue);


                        execSql.ExecuteNonQuery();
                        conn.FecharConexao();
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }

                }

            }
            else
            {
                var resposta = MessageBox.Show("Deseja Salvar esse Cadastro de Habilidade?", "Salvar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        conn.AbrirConexao();

                        sql = "INSERT INTO habilidades(nomeHabilidade, estadoHabilidade, statusHabilidade, dataHabilidade, obsHabilidade, idAluno) VALUES (@nome,@estado,@status, dataHabilidade,@obs,@idAluno)";
                        execSql = new MySqlCommand(sql, conn.conMySql);
                        execSql.Parameters.AddWithValue("@nome", txtNome.Text);
                        execSql.Parameters.AddWithValue("@estado", txtAval.Text);
                        execSql.Parameters.AddWithValue("@status", cbStatus.Text);
                        execSql.Parameters.AddWithValue("@data", dataCad.Value);
                        execSql.Parameters.AddWithValue("@obs", txtDesc.Text);
                        execSql.Parameters.AddWithValue("@idAluno", idAluno);


                        execSql.ExecuteNonQuery();
                        conn.FecharConexao();
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }

                }
            }
                MessageBox.Show("Cadastro Efetuado!", "Cadastro Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            
        }

        private void Ativar()
        {
            txtNome.Enabled = true;
            cbStatus.Enabled = true;
            txtAval.Enabled = true;
            txtDesc.Enabled = true;
            cbProf.Enabled = true;
            dataCad.Enabled = true;
            dataCad.Value = DateTime.Today;


        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Ativar();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            dgNotas.Enabled = false;
            ListarProf();
        }

        private void Desativar()
        {
            txtNome.Enabled = false;
            cbStatus.Enabled = false;
            cbProf.Enabled = false;
            dataCad.Enabled = false;
            txtAval.Enabled = false;
            txtDesc.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnDesativar.Enabled = false;
            btnSalvar.Enabled = false;

        }

        

        private void Cancelar()
        {
            var resposta = MessageBox.Show("Deseja realmente cancelar este processo?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                txtNome.Text = "";
                cbStatus.Text = "";
                cbProf.Text = "";
                txtAval.Text = "";
                txtDesc.Text = "";
                dataCad.Text = "";
                MessageBox.Show("Processo Cancelado", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Desativar();
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                dgNotas.Enabled = true;
                btnEditar.Enabled = false;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja salvar alterações feitas nesse registro?", "Editar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                if (aval == "NOTAS")
                {
                    try
                    {
                        conn.AbrirConexao();



                        sql = "UPDATE disciplina SET nomeDisciplina=@nome,notaDisciplina=@aval,dataDisciplina=@data,obsDisciplina=@obs,disciplinaStatus=@status,idAluno=@idAluno,idFunc=@idFunc WHERE idDisciplina = @idDisciplina";

                        execSql = new MySqlCommand(sql, conn.conMySql);

                        execSql.Parameters.AddWithValue("@nome", txtNome.Text);
                        execSql.Parameters.AddWithValue("@aval", txtAval.Text);
                        execSql.Parameters.AddWithValue("@status", "ATIVO");
                        execSql.Parameters.AddWithValue("@obs", txtDesc.Text);
                        execSql.Parameters.AddWithValue("@idAluno", idAluno);
                        execSql.Parameters.AddWithValue("@data", dataCad.Value);
                        execSql.Parameters.AddWithValue("@idDisciplina", idNota);
                        execSql.Parameters.AddWithValue("@idFunc", cbProf.SelectedValue);
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                    execSql.ExecuteNonQuery();
                    conn.FecharConexao();

                }
                else
                    {

                    try
                    {

                        conn.AbrirConexao();
                        sql = "UPDATE habilidades SET nomeHabilidade=@nome,estadoHabilidade=@aval,statusHabilidade=@status,obsHabilidade=@obs,idAluno=@idAluno WHERE idHabilidade = @idHabilidade";
                        execSql = new MySqlCommand(sql, conn.conMySql);

                        execSql.Parameters.AddWithValue("@nome", txtNome.Text);
                        execSql.Parameters.AddWithValue("@aval", txtAval.Text);
                        execSql.Parameters.AddWithValue("@status", cbStatus.Text);
                        execSql.Parameters.AddWithValue("@obs", txtDesc.Text);
                        execSql.Parameters.AddWithValue("@idAluno", idAluno);
                        execSql.Parameters.AddWithValue("@idHabilidade", idHabilidade);
                        execSql.ExecuteNonQuery();
                        conn.FecharConexao();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    

                }
                
                   
                    
                }
                
                MessageBox.Show("Serviço Atualizado com Sucesso", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Desativar();
            ListarDados();
            btnEditar.Enabled = false;
            btnDesativar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            txtNome.Text = "";
            cbStatus.Text = "";
            cbProf.Text = "";
            txtAval.Text = "";
            txtDesc.Text = "";
            dataCad.Text = "";
        }
        private void btnDesativar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja desativar esse registro?", "Desativar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                if (aval == "NOTAS")
                {
                    try
                {
                    conn.AbrirConexao();

                    
                        sql = "UPDATE disciplina SET disciplinaStatus='INATIVO' WHERE idDisciplina = @idAval";
                        execSql = new MySqlCommand(sql, conn.conMySql);
                        execSql.Parameters.AddWithValue("@idAval", idNota);
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                    execSql.ExecuteNonQuery();
                    conn.FecharConexao();


                }
                else
                {
                    try
                    {
                        conn.AbrirConexao();
                        sql = "UPDATE habilidades SET statusHabilidade='INATIVO' WHERE idHabilidade = @idAval";
                        execSql = new MySqlCommand(sql, conn.conMySql);
                        execSql.Parameters.AddWithValue("@idAval", idHabilidade);

                       
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                    execSql.ExecuteNonQuery();
                    conn.FecharConexao();
                }

                MessageBox.Show("Registro Desativado", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                cbStatus.Text = "";
                cbProf.Text = "";
                txtAval.Text = "";
                txtDesc.Text = "";
                dataCad.Text = "";

                btnCancelar.Enabled = false;
                btnEditar.Enabled = false;
                btnDesativar.Enabled = false;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;

                Desativar();

                ListarDados();
            }
        }




        private void dgNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (aval == "NOTAS")
            {
                idNota = dgNotas.CurrentRow.Cells[0].Value.ToString();
                ListarProf();
                cbProf.Text = dgNotas.CurrentRow.Cells[9].Value.ToString();
                idProf = dgNotas.CurrentRow.Cells[7].Value.ToString();

                txtNome.Text = dgNotas.CurrentRow.Cells[1].Value.ToString();
                txtAval.Text = dgNotas.CurrentRow.Cells[2].Value.ToString();
                txtDesc.Text = dgNotas.CurrentRow.Cells[3].Value.ToString();
                dataCad.Text = dgNotas.CurrentRow.Cells[4].Value.ToString();
                cbStatus.Text = dgNotas.CurrentRow.Cells[5].Value.ToString();
            }
            else
            {
                idHabilidade = dgNotas.CurrentRow.Cells[0].Value.ToString();

                txtNome.Text = dgNotas.CurrentRow.Cells[1].Value.ToString();
                txtAval.Text = dgNotas.CurrentRow.Cells[2].Value.ToString();
                lblAval.Text = "Estado";
                lblProf.Visible = false;
                txtDesc.Text = dgNotas.CurrentRow.Cells[4].Value.ToString();
                cbStatus.Text = dgNotas.CurrentRow.Cells[3].Value.ToString();
            }

            btnCancelar.Enabled = true;
            btnEditar.Enabled = true;
            btnDesativar.Enabled = true;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = false;
            Ativar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
