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
    public partial class frmServico : Form
    {

        //Instanciar conexao
        Conexao conn = new Conexao();
        string sql;
        string id;
        string nomeAntigo;
        MySqlCommand execSql;

        public frmServico()
        {
            InitializeComponent();
        }

        private void frmServico_Load(object sender, EventArgs e)
        {

            cbExibir.SelectedIndex = 0;
            this.Location = new Point(91, 120);
            Desativar();
 
            FormatarDG();
        }

        private void Ativos()
        {
            conn.AbrirConexao();
            sql = "SELECT * FROM servico WHERE statusServico = 'Ativo' ORDER BY nomeServico";
            execSql = new MySqlCommand(sql, conn.conMySql);

            MySqlDataAdapter conjDados = new MySqlDataAdapter();
            conjDados.SelectCommand = execSql;

            DataTable dadosTabela = new DataTable();
            conjDados.Fill(dadosTabela);

            gridServico.DataSource = dadosTabela;
            conn.FecharConexao();
        }

        private void Inativos()
        {
            try
            {
                conn.AbrirConexao();
                sql = "SELECT * FROM servico WHERE statusServico = 'Inativo' ORDER BY nomeServico";
                execSql = new MySqlCommand(sql, conn.conMySql);

                MySqlDataAdapter conjDados = new MySqlDataAdapter();
                conjDados.SelectCommand = execSql;

                DataTable dadosTabela = new DataTable();
                conjDados.Fill(dadosTabela);

                gridServico.DataSource = dadosTabela;
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
            cbStatus.Enabled = true;
            txtDesc.Enabled = true;
        }

        private void Desativar()
        {
            txtNome.Enabled = false;
            cbStatus.Enabled = false;
            txtDesc.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnDesativar.Enabled = false;
            btnSalvar.Enabled = false;

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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Ativar();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            cbExibir.Enabled = false;
            gridServico.Enabled = false;
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

            if (txtDesc.Text == "")
            {
                MessageBox.Show("Campo descrição vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDesc.Focus();
                return;
            }

            var resposta = MessageBox.Show("Deseja Salvar esse Cadastro?", "Salvar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                try
                {
                    conn.AbrirConexao();

                    sql = "INSERT INTO servico(nomeServico, descricaoServico, statusServico) VALUES (@nome,@desc,@status)";
                    execSql = new MySqlCommand(sql, conn.conMySql);
                    execSql.Parameters.AddWithValue("@nome", txtNome.Text);
                    execSql.Parameters.AddWithValue("@desc", txtDesc.Text) ;
                    execSql.Parameters.AddWithValue("@status", cbStatus.Text);

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
                txtDesc.Text = "";
                cbStatus.Text = "";

                txtNome.Enabled = false;
                txtDesc.Enabled = false;
                cbStatus.Enabled = false;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnNovo.Enabled = true;
                cbExibir.Enabled = true;
                gridServico.Enabled = true;

                Desativar();
            }


           


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            

            var resposta = MessageBox.Show("Deseja realmente cancelar este processo?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resposta == DialogResult.Yes)
            {
                txtNome.Text = "";
                txtDesc.Text = "";
                cbStatus.Text = "";
                MessageBox.Show("Processo Cancelado", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Desativar();
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                cbExibir.Enabled = true;
                gridServico.Enabled = true;
            }



        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            BuscarServico();
        }

        private void BuscarServico()
        {
            if (cbExibir.Text == "ATIVOS")
            {
                conn.AbrirConexao();
                sql = "SELECT * FROM servico WHERE nomeServico LIKE @nomeServico AND statusServico = 'ATIVO'";
                execSql = new MySqlCommand(sql, conn.conMySql);
                execSql.Parameters.AddWithValue("@nomeServico", "%" + txtBusca.Text + "%");

                MySqlDataAdapter conjDados = new MySqlDataAdapter();
                conjDados.SelectCommand = execSql;

                DataTable dadosTabela = new DataTable();
                conjDados.Fill(dadosTabela);

                gridServico.DataSource = dadosTabela;

                conn.FecharConexao();
            }

            if (cbExibir.Text == "INATIVOS")
            {
                conn.AbrirConexao();
                sql = "SELECT * FROM servico WHERE nomeServico LIKE @nomeServico AND statusServico = 'INATIVO'";
                execSql = new MySqlCommand(sql, conn.conMySql);

                execSql.Parameters.AddWithValue("@nomeServico", "%" + txtBusca.Text + "%");

                MySqlDataAdapter conjDados = new MySqlDataAdapter();
                conjDados.SelectCommand = execSql;

                DataTable dadosTabela = new DataTable();
                conjDados.Fill(dadosTabela);

                gridServico.DataSource = dadosTabela;

                conn.FecharConexao();
            }




        }

        private void FormatarDG()
        {
            gridServico.Columns[0].Visible = false;
            gridServico.Columns[1].HeaderText = "Serviço";
            gridServico.Columns[2].HeaderText = "Descrição";
            gridServico.Columns[3].HeaderText = "Status";
            gridServico.Columns[4].HeaderText = "Data de Criação";
        }

        private void gridServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btnEditar.Enabled = true;
            if (cbExibir.Text == "INATIVOS")
            {
                btnDesativar.Enabled = false;
            }
            else
            {
                btnDesativar.Enabled = true;
            }

            
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = false;

            Ativar();

            id = gridServico.CurrentRow.Cells[0].Value.ToString();
            nomeAntigo = gridServico.CurrentRow.Cells[1].Value.ToString();

            txtNome.Text = gridServico.CurrentRow.Cells[1].Value.ToString();
            txtDesc.Text = gridServico.CurrentRow.Cells[2].Value.ToString();
            cbStatus.Text = gridServico.CurrentRow.Cells[3].Value.ToString();




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

            if (txtDesc.Text == "")
            {
                MessageBox.Show("Campo descrição vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDesc.Focus();
                return;
            }

            conn.AbrirConexao();
            if (txtNome.Text != nomeAntigo)
            {
                sql = "SELECT * FROM servico WHERE nomeServico = @nome";
                execSql = new MySqlCommand(sql, conn.conMySql);
                execSql.Parameters.AddWithValue("@nome", txtNome.Text);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = execSql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Serviço já Registrado", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Text = "";
                    txtNome.Focus();
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
                    sql = "UPDATE servico SET nomeServico=@nome,descricaoServico=@desc,statusServico=@status WHERE idServico = @id";
                    execSql = new MySqlCommand(sql, conn.conMySql);

                    execSql.Parameters.AddWithValue("@nome", txtNome.Text);
                    execSql.Parameters.AddWithValue("@desc", txtDesc.Text);
                    execSql.Parameters.AddWithValue("@status", cbStatus.Text);

                    execSql.Parameters.AddWithValue("id", id);

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
            txtDesc.Text = "";
            cbStatus.Text = "";
            Desativar();
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja desativar esse registro?", "Desativar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                try
                {
                    conn.AbrirConexao();

                    sql = "UPDATE servico SET statusServico='INATIVO' WHERE idServico = @id";
                    execSql = new MySqlCommand(sql, conn.conMySql);

                    execSql.Parameters.AddWithValue("id", id);

                    execSql.ExecuteNonQuery();
                    conn.FecharConexao();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

                MessageBox.Show("Registro Desativado", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            

            VerificarExibir();

            btnEditar.Enabled = false;
            btnDesativar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            txtNome.Text = "";
            txtDesc.Text = "";
            cbStatus.Text = "";
            Desativar();
        }

        private void cbExibir_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarExibir();
        }

    }
}
