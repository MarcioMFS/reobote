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

namespace reobote.Func
{
    public partial class frmFunc : Form
    {
        //Instanciar conexao
        Conexao conn = new Conexao();
        string sql;
        string id;
        string cpfAntigo;
        MySqlCommand execSql;
        public frmFunc()
        {
            InitializeComponent();
        }

        private void frmFunc_Load(object sender, EventArgs e)
        {
            this.Location = new Point(91, 120);
            Desativar();
            ListarDados();
            cbExibir.SelectedIndex = 0;

            FormatarDG();
        }

        private void Ativos()
        {
            btnDesativar.Text = "DESATIVAR";

            conn.AbrirConexao();
            sql = "SELECT F.*, S.nomeServico FROM funcionario F INNER JOIN servico S ON F.idServico = S.idServico WHERE F.statusFunc = 'ATIVO'";
            execSql = new MySqlCommand(sql, conn.conMySql);

            MySqlDataAdapter conjDados = new MySqlDataAdapter();
            conjDados.SelectCommand = execSql;

            DataTable dadosTabela = new DataTable();
            conjDados.Fill(dadosTabela);

            gridFunc.DataSource = dadosTabela;
            conn.FecharConexao();
        }

        private void Inativos()
        {
            btnDesativar.Text = "ATIVAR";
            try
            {
                conn.AbrirConexao();
                sql = "SELECT F.*, S.nomeServico FROM funcionario F INNER JOIN servico S ON F.idServico = S.idServico WHERE F.statusFunc = 'INATIVO' ";
                execSql = new MySqlCommand(sql, conn.conMySql);

                MySqlDataAdapter conjDados = new MySqlDataAdapter();
                conjDados.SelectCommand = execSql;

                DataTable dadosTabela = new DataTable();
                conjDados.Fill(dadosTabela);

                gridFunc.DataSource = dadosTabela;
                conn.FecharConexao();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Ativar()
        {
            cbStatus.Enabled = true;
            cbServico.Enabled = true;
            txtNome.Enabled = true;
            cbNivel.Enabled = true;
            txtCpf.Enabled = true;
            txtEmail.Enabled = true;
            txtSalario.Enabled = true;
        }

        private void Desativar()
        {
            txtNome.Enabled = false;
            cbStatus.Enabled = false;
            cbNivel.Enabled = false;
            cbServico.Enabled = false;
            txtCpf.Enabled = false;
            txtEmail.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnNovo.Enabled = true;
            btnDesativar.Enabled = false;
            btnSalvar.Enabled = false;
            txtSalario.Enabled = false;

        }

        private void VerificarExibir()
        {

            if (cbExibir.Text == "INATIVOS")
            {
                Inativos();
            }

            if (cbExibir.Text == "ATIVOS")
            {
                Ativos();
            }
        }

        private void ListarDados()
        {
            conn.AbrirConexao();
            sql = "SELECT F.*, S.nomeServico FROM funcionario F INNER JOIN servico S ON F.idServico = S.idServico WHERE F.statusFunc = 'ATIVO' ";
            execSql = new MySqlCommand(sql, conn.conMySql);

            MySqlDataAdapter conjDados = new MySqlDataAdapter();
            conjDados.SelectCommand = execSql;

            DataTable dadosTabela = new DataTable();
            conjDados.Fill(dadosTabela);

            gridFunc.DataSource = dadosTabela;
            conn.FecharConexao();
        }

        private void ListarServico()
        {
            cbServico.DataSource = null;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Campo nome vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (cbStatus.Text == "")
            {
                MessageBox.Show("Campo status vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbStatus.Focus();
                return;
            }
            if (cbServico.Text == "")
            {
                MessageBox.Show("Campo Servico vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbServico.Focus();
                return;
            }
            if (txtCpf.Text == "")
            {
                MessageBox.Show("Campo CPF vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpf.Focus();
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Campo Email vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }

            var resposta = MessageBox.Show("Deseja Salvar esse Cadastro?", "Salvar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                try
                {
                    sql = "SELECT * FROM funcionario WHERE cpfFunc = @cpf";
                    execSql = new MySqlCommand(sql, conn.conMySql);
                    execSql.Parameters.AddWithValue("@cpf", txtCpf.Text);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = execSql;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Funcionario já Registrado", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCpf.Text = "";
                        txtCpf.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                

                try
                {
                    conn.AbrirConexao();

                    sql = "INSERT INTO funcionario(nomeFunc, nivelFunc, emailFunc, cpfFunc, statusFunc,salarioFunc,idServico) VALUES (@nome,@nivel,@email,@cpf,@status,@salario,@idServico)";
                    execSql = new MySqlCommand(sql, conn.conMySql);
                    execSql.Parameters.AddWithValue("@nome", txtNome.Text);
                    execSql.Parameters.AddWithValue("@nivel", cbNivel.Text);
                    execSql.Parameters.AddWithValue("@email", cbStatus.Text);
                    execSql.Parameters.AddWithValue("@cpf", txtCpf.Text);
                    execSql.Parameters.AddWithValue("@status", cbStatus.Text);
                    execSql.Parameters.AddWithValue("@salario", txtSalario.Text);
                    execSql.Parameters.AddWithValue("@idServico", cbServico.SelectedValue);

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
                cbStatus.Text = "";
                cbServico.Text = "";
                txtNome.Text = "";
                cbNivel.Text = "";
                txtCpf.Text = "";
                txtSalario.Text = "";
                txtEmail.Text = "";

                txtNome.Enabled = false;
                cbStatus.Enabled = false;
                txtBusca.Enabled = true;
                cbServico.Enabled = false;
                txtNome.Enabled = false; 
                cbNivel.Enabled = false;
                txtCpf.Enabled = false;
                txtEmail.Enabled = false;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnNovo.Enabled = true;
                cbExibir.Enabled = true;
                gridFunc.Enabled = true;
            }


        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ListarServico();
            Ativar();
            txtBusca.Enabled = false;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            cbExibir.Enabled = false;
            gridFunc.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            var resposta = MessageBox.Show("Deseja realmente cancelar este processo?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                txtNome.Text = "";
                cbStatus.Text = "";
                cbServico.Text = "";
                cbNivel.Text = "";
                txtNome.Text = "";
                cbNivel.Text = "";
                txtCpf.Text = "";
                txtEmail.Text = "";
                MessageBox.Show("Processo Cancelado", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Desativar();
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                cbExibir.Enabled = true;
                gridFunc.Enabled = true;
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Campo nome vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (cbStatus.Text == "")
            {
                MessageBox.Show("Campo status vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbStatus.Focus();
                return;
            }
            if (cbServico.Text == "")
            {
                MessageBox.Show("Campo Servico vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbServico.Focus();
                return;
            }
            if (txtCpf.Text == "")
            {
                MessageBox.Show("Campo CPF vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpf.Focus();
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Campo Email vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }

            conn.AbrirConexao();
            if (txtCpf.Text != cpfAntigo)
            {
                sql = "SELECT * FROM funcionario WHERE cpfFunc = @cpf";
                execSql = new MySqlCommand(sql, conn.conMySql);
                execSql.Parameters.AddWithValue("@cpf", txtCpf.Text);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = execSql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Funcionario já Registrado", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCpf.Text = "";
                    txtCpf.Focus();
                    return;
                }
            }
            conn.FecharConexao();

            var resposta = MessageBox.Show("Deseja salvar alterações feitas nesse registro?", "Editar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    conn.AbrirConexao();
                    sql = "UPDATE funcionario SET nomeFunc=@nome,nivelFunc=@nivel,emailFunc=@email,cpfFunc=@cpf,statusFunc=@status,salarioFunc=@salario,idServico=@idServico WHERE idFunc = @idFunc";
                    execSql = new MySqlCommand(sql, conn.conMySql);

                    execSql.Parameters.AddWithValue("@nome", txtNome.Text);
                    execSql.Parameters.AddWithValue("@nivel", cbNivel.Text);
                    execSql.Parameters.AddWithValue("@email", cbStatus.Text);
                    execSql.Parameters.AddWithValue("@cpf", txtCpf.Text);
                    execSql.Parameters.AddWithValue("@status", cbStatus.Text);
                    execSql.Parameters.AddWithValue("@salario", txtSalario.Text);
                    execSql.Parameters.AddWithValue("@idServico", cbServico.SelectedValue);

                    execSql.Parameters.AddWithValue("idFunc", id);

                    execSql.ExecuteNonQuery();
                    conn.FecharConexao();
                    VerificarExibir();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                MessageBox.Show("Serviço Atualizado com Sucesso", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            btnEditar.Enabled = false;
            btnDesativar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            txtNome.Text = "";
            cbStatus.Text = "";
            cbServico.Text = "";
            txtNome.Text = "";
            cbNivel.Text = "";
            txtCpf.Text = "";
            txtSalario.Text = "";
            txtEmail.Text = "";
            Desativar();
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {

            var resposta = MessageBox.Show("Deseja alterar o status desse registro?", "Alterar Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                try
                {
                    conn.AbrirConexao();
                    if (cbExibir.Text == "ATIVOS")
                    {
                        sql = "UPDATE funcionario SET statusFunc='INATIVO' WHERE idFunc = @idFunc";
                    }
                    else
                    {
                        sql = "UPDATE funcionario SET statusFunc='ATIVO' WHERE idFunc = @idFunc";

                    }
                    execSql = new MySqlCommand(sql, conn.conMySql);

                    execSql.Parameters.AddWithValue("idFunc", id);

                    execSql.ExecuteNonQuery();
                    conn.FecharConexao();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

                MessageBox.Show("Status Alterado", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            VerificarExibir();

            btnEditar.Enabled = false;
            btnDesativar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            txtNome.Text = "";
            cbStatus.Text = "";
            cbServico.Text = "";
            txtNome.Text = "";
            cbNivel.Text = "";
            txtSalario.Text = "";
            txtCpf.Text = "";
            txtEmail.Text = "";
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.TextLength == 11)
            {
                BuscarFunc();

            }
            else
            {
                ListarDados();
            }
        }

        private void BuscarFunc()
        {
         
            
                conn.AbrirConexao();
                sql = "SELECT F.*, S.nomeServico FROM funcionario F INNER JOIN servico S ON F.idServico = S.idServico WHERE cpfFunc = @cpf";
                execSql = new MySqlCommand(sql, conn.conMySql);

                execSql.Parameters.AddWithValue("@cpf", txtBusca.Text);

                MySqlDataAdapter conjDados = new MySqlDataAdapter();
                conjDados.SelectCommand = execSql;

                DataTable dadosTabela = new DataTable();
                conjDados.Fill(dadosTabela);

                gridFunc.DataSource = dadosTabela;

                conn.FecharConexao();
            

        }

        private void FormatarDG()
        {
            gridFunc.Columns[0].Visible = false;
            gridFunc.Columns[1].HeaderText = "Funcionario";
            gridFunc.Columns[2].HeaderText = "Nivel";
            gridFunc.Columns[3].HeaderText = "Email";
            gridFunc.Columns[4].HeaderText = "CPF";
            gridFunc.Columns[5].HeaderText = "Status";
            gridFunc.Columns[6].HeaderText = "Salario";
            gridFunc.Columns[7].Visible = false;
            gridFunc.Columns[8].Visible = false;
            gridFunc.Columns[9].HeaderText = "Serviço";
        }

        private void gridServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ListarServico();
            btnEditar.Enabled = true;
 


            btnCancelar.Enabled = true;
            btnSalvar.Enabled = false;
            btnDesativar.Enabled = true;
            btnNovo.Enabled = false;

            Ativar();

            id = gridFunc.CurrentRow.Cells[0].Value.ToString();

            txtNome.Text = gridFunc.CurrentRow.Cells[1].Value.ToString();
            cbNivel.Text = gridFunc.CurrentRow.Cells[2].Value.ToString(); 
            txtEmail.Text = gridFunc.CurrentRow.Cells[3].Value.ToString();
            txtCpf.Text = gridFunc.CurrentRow.Cells[4].Value.ToString();
            cpfAntigo = gridFunc.CurrentRow.Cells[4].Value.ToString();
            cbStatus.Text = gridFunc.CurrentRow.Cells[5].Value.ToString();
            txtSalario.Text = gridFunc.CurrentRow.Cells[6].Value.ToString();
            cbServico.Text = gridFunc.CurrentRow.Cells[9].Value.ToString();


        }

        private void cbExibir_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarExibir();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
