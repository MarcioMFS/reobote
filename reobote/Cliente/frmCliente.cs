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
    public partial class frmCliente : Form
    {

        Conexao conn = new Conexao();
        string sql;
        string idPais;
        string idAluno;
        string cpfAntigo;
        string nomeAntigo;
        string emailAntigo;
        string senhaAntiga;
        string telAntigo;
        string StatusAntigo;
        string EndAntigo;
        string BairroAntigo;
        string aval;
        bool editar = false;
        string addAluno = "nao";
        string idServico;
                MySqlCommand execSql;

   
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.Location = new Point(91, 120);
            cbExibir.SelectedIndex = 0;
            Desativar();
            ListarDados();
            FormatarDG();
            
            btnAddAluno.Visible = false;
            btnAddAluno.Enabled = false;
            cbAlunos.Visible = false;
            cbAlunos.Enabled = false;

        }

     
        private void ListarDados()
        {
                conn.AbrirConexao();
                sql = "SELECT P.*, A.nomeAluno FROM pais P INNER JOIN aluno A ON P.idAluno = A.idAluno WHERE P.statusPais = 'Ativo' ORDER BY nomePais";
                execSql = new MySqlCommand(sql, conn.conMySql);

                MySqlDataAdapter conjDados = new MySqlDataAdapter();
                conjDados.SelectCommand = execSql;

                DataTable dadosTabela = new DataTable();
                conjDados.Fill(dadosTabela);

                gridCliente.DataSource = dadosTabela;
                conn.FecharConexao();
            
           
        }

       
        

        private void Desativar()
        {
            txtNome.Enabled = false;
            cbStatus.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
            txtEnd.Enabled = false;
            txtTel.Enabled = false;
            txtCPF.Enabled = false;
            txtBairro.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnDesativar.Enabled = false;
            btnSalvar.Enabled = false;
            cbAlunos.Visible = false;
            lblAlunos.Visible = false;
            btnAddAluno.Visible = false;
            editar = false;

        }

        private void Ativar()
        {
            txtNome.Enabled = true;
            cbStatus.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
            txtEnd.Enabled = true;
            txtTel.Enabled = true;
            txtCPF.Enabled = true;
            txtBairro.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = true;
            btnDesativar.Enabled = true;
            editar = true;

        }

        private void FormatarDG()
        {
           
            
                gridCliente.Columns[0].Visible = false;
                gridCliente.Columns[1].HeaderText = "Nome do responsável";
                gridCliente.Columns[2].HeaderText = "Email";
                gridCliente.Columns[3].HeaderText = "Senha";
                gridCliente.Columns[4].HeaderText = "Status";
                gridCliente.Columns[5].HeaderText = "Data de cadastro";
                gridCliente.Columns[6].Visible = false;
                gridCliente.Columns[7].Visible = false;
                gridCliente.Columns[8].Visible = false;
                gridCliente.Columns[9].HeaderText = "Telefone";
                gridCliente.Columns[10].HeaderText = "CPF";
                gridCliente.Columns[11].HeaderText = "Aluno";
            

        }

        private void Ativos()
        {
            

          
                conn.AbrirConexao();
                sql = "SELECT P.*, A.nomeAluno FROM pais P INNER JOIN aluno A ON P.idAluno = A.idAluno WHERE P.statusPais = 'Ativo' ORDER BY nomePais";
                execSql = new MySqlCommand(sql, conn.conMySql);

                MySqlDataAdapter conjDados = new MySqlDataAdapter();
                conjDados.SelectCommand = execSql;

                DataTable dadosTabela = new DataTable();
                conjDados.Fill(dadosTabela);

                gridCliente.DataSource = dadosTabela;
                conn.FecharConexao();
            
          
        }

        private void Inativos()
        {
          
                try
                {
                    conn.AbrirConexao();
                    sql = "SELECT P.*, A.nomeAluno FROM pais P INNER JOIN aluno A ON P.idAluno = A.idAluno WHERE P.statusPais = 'Inativo' ORDER BY nomePais";
                    execSql = new MySqlCommand(sql, conn.conMySql);

                    MySqlDataAdapter conjDados = new MySqlDataAdapter();
                    conjDados.SelectCommand = execSql;

                    DataTable dadosTabela = new DataTable();
                    conjDados.Fill(dadosTabela);

                    gridCliente.DataSource = dadosTabela;
                    conn.FecharConexao();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            
           
                
            
            
        }

        

        private void VerificarExibir()
        {

            if (cbExibir.Text == "INATIVOS")
            {
                Inativos();
                btnDesativar.Text = "ATIVAR";
            }

            if (cbExibir.Text == "ATIVOS")
            {
                Ativos();
                btnDesativar.Text = "DESATIVAR";
            }
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

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Campo email vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }

            if (txtSenha.Text == "")
            {
                MessageBox.Show("Campo senha vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Focus();
                return;
            }

            if (txtEnd.Text == "")
            {
                MessageBox.Show("Campo endereço vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEnd.Focus();
                return;
            }

            if (txtBairro.Text == "")
            {
                MessageBox.Show("Campo bairro vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBairro.Focus();
                return;
            }

            if (txtTel.Text == "")
            {
                MessageBox.Show("Campo telefone vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTel.Focus();
                return;
            }

            if (txtCPF.Text == "")
            {
                MessageBox.Show("Campo CPF vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF.Focus();
                return;
            }

            var resposta1 = MessageBox.Show("Deseja Salvar Esse cadastro?", "Salvar Cadastro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta1 == DialogResult.Yes) 
            {
                sql = "SELECT * FROM pais WHERE cpfPais = @cpf";
                execSql = new MySqlCommand(sql, conn.conMySql);
                execSql.Parameters.AddWithValue("@cpf", txtCPF.Text);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = execSql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CPF já Registrado", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCPF.Text = "";
                    txtCPF.Focus();
                    return;
                }


                sql = "SELECT * FROM pais WHERE emailPais = @email";
                execSql = new MySqlCommand(sql, conn.conMySql);
                execSql.Parameters.AddWithValue("@email", txtEmail.Text);
                da.SelectCommand = execSql;
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Email já Registrado", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Text = "";
                    txtEmail.Focus();
                    return;
                }

                sql = "SELECT * FROM pais WHERE numeroFonePais = @fone";
                execSql = new MySqlCommand(sql, conn.conMySql);
                execSql.Parameters.AddWithValue("@fone", txtTel.Text);
                da.SelectCommand = execSql;
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Telefone já Registrado", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTel.Text = "";
                    txtTel.Focus();
                    return;
                }

                var resposta = MessageBox.Show("Deseja cadastrar o aluno agora?", "Cadastrar Aluno?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    addAluno = "sim";
                    idAluno = "";
                    try
                    {
                        conn.AbrirConexao();

                        sql = "INSERT INTO pais( nomePais, emailPais, senhaPais, statusPais, idAluno, enderecoPais, bairroPais, numeroFonePais, cpfPais) VALUES (@nomePais,@email,@senha,@status,@idAluno,@end,@bairro,@fone,@cpf)";
                        //@nomePais,@emailPais,@senha,@status,@idAluno,@end,@bairro,@fone,@cpf
                        execSql = new MySqlCommand(sql, conn.conMySql);
                        execSql.Parameters.AddWithValue("@nomePais", txtNome.Text);
                        execSql.Parameters.AddWithValue("@email", txtEmail.Text);
                        execSql.Parameters.AddWithValue("@senha", txtSenha.Text);
                        execSql.Parameters.AddWithValue("@status", cbStatus.Text);
                        execSql.Parameters.AddWithValue("@idAluno", idAluno);
                        execSql.Parameters.AddWithValue("@end", txtEnd.Text);
                        execSql.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        execSql.Parameters.AddWithValue("@fone", txtTel.Text);
                        execSql.Parameters.AddWithValue("@cpf", txtCPF.Text);


                        execSql.ExecuteNonQuery();
                        conn.FecharConexao();
                        VerificarExibir();
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                    

                    

                    conn.FecharConexao();

                    //Pegar ultimo id Responsável
                    conn.AbrirConexao();
                    sql = "SELECT idPais FROM pais ORDER BY idPais DESC LIMIT 1";
                    execSql = new MySqlCommand(sql, conn.conMySql);
                    MySqlDataReader dr1 = execSql.ExecuteReader();
                    if (dr1.HasRows)
                    {
                        while (dr1.Read())
                        {
                            idPais = Convert.ToString(dr1["idPais"]);
                        }
                    }
                    Cliente.frmCadAluno frmCadAluno = new Cliente.frmCadAluno();
                    frmCadAluno.Propiedade = idPais;
                    frmCadAluno.addAluno = addAluno;
                    frmCadAluno.ShowDialog();
                    conn.FecharConexao();


                    //Pegar id do Aluno Cadastrado
                    conn.AbrirConexao();
                    sql = "SELECT idAluno FROM aluno ORDER BY idAluno DESC LIMIT 1";
                    execSql = new MySqlCommand(sql, conn.conMySql);
                    MySqlDataReader dr = execSql.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idAluno = Convert.ToString(dr["idAluno"]);
                        }
                    }

                    //Adicionar Aluno Para Responsável
                    conn.AbrirConexao();
                    sql = "UPDATE pais SET idAluno=@idAluno WHERE idPais = @idPais";
                    execSql = new MySqlCommand(sql, conn.conMySql);

                    execSql.Parameters.AddWithValue("@idAluno", idAluno);
                    execSql.Parameters.AddWithValue("@idPais", idPais);

                    execSql.ExecuteNonQuery();
                    conn.FecharConexao();
                }
                else
                {
                    idAluno = "";
                    try
                    {
                        conn.AbrirConexao();

                        sql = "INSERT INTO pais( nomePais, emailPais, senhaPais, statusPais, idAluno, enderecoPais, bairroPais, numeroFonePais, cpfPais) VALUES (@nomePais,@email,@senha,@status,@idAluno,@end,@bairro,@fone,@cpf)";
                        //@nomePais,@emailPais,@senha,@status,@idAluno,@end,@bairro,@fone,@cpf
                        execSql = new MySqlCommand(sql, conn.conMySql);
                        execSql.Parameters.AddWithValue("@nomePais", txtNome.Text);
                        execSql.Parameters.AddWithValue("@email", txtEmail.Text);
                        execSql.Parameters.AddWithValue("@senha", txtSenha.Text);
                        execSql.Parameters.AddWithValue("@status", cbStatus.Text);
                        execSql.Parameters.AddWithValue("@idAluno", idAluno);
                        execSql.Parameters.AddWithValue("@end", txtEnd.Text);
                        execSql.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        execSql.Parameters.AddWithValue("@fone", txtTel.Text);
                        execSql.Parameters.AddWithValue("@cpf", txtCPF.Text);


                        execSql.ExecuteNonQuery();
                        conn.FecharConexao();
                        VerificarExibir();
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }

                    MessageBox.Show("Cadastro Efetuado!", "Cadastro Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarAlunos();
                ListarDados();
                    
                
            }

                txtNome.Text = "";
                txtEmail.Text = "";
                txtSenha.Text = "";
                txtEnd.Text = "";
                txtBairro.Text = "";
                txtTel.Text = "";
                txtCPF.Text = "";
                cbStatus.Text = "";

                txtNome.Enabled = false;
                txtEmail.Enabled = false;
                txtSenha.Enabled = false;
                txtEnd.Enabled = false;
                txtBairro.Enabled = false;
                txtTel.Enabled = false;
                txtCPF.Enabled = false;
                cbStatus.Enabled = false;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnNovo.Enabled = true;
                cbExibir.Enabled = true;
                gridCliente.Enabled = true;
            
        }

        private void ListarAlunos()
        {
           

            cbAlunos.DataSource = null;
            cbAlunos.Items.Clear();
            conn.AbrirConexao();
            sql = "SELECT P.nomePais, A.nomeAluno, A.idAluno FROM pais P INNER JOIN aluno A ON P.idPais = A.idPais WHERE A.idPais =" + idPais;
            execSql = new MySqlCommand(sql, conn.conMySql);
            MySqlCommand cmd = new MySqlCommand(sql, conn.conMySql);

            MySqlDataAdapter conjDados = new MySqlDataAdapter(cmd);
            DataTable dadosTabela = new DataTable();
            conjDados.Fill(dadosTabela);

            if (dadosTabela.Rows.Count > 0)
            {
                cbAlunos.ValueMember = "idAluno";
                cbAlunos.DisplayMember = "nomeAluno";
                cbAlunos.DataSource = dadosTabela;

            }
            else
            {
                cbAlunos.Text = "Sem Aluno Cadastrado";
            }
            conn.FecharConexao();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Ativar();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnDesativar.Enabled = false;
            btnEditar.Enabled = false;
            txtBusca.Enabled = false;
            cbExibir.Enabled = false;
            gridCliente.Enabled = false;
        }

        private void Cancelar()
        {
            var resposta = MessageBox.Show("Deseja realmente cancelar este processo?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                txtNome.Text = "";
                txtEmail.Text = "";
                txtSenha.Text = "";
                txtEnd.Text = "";
                txtBairro.Text = "";
                cbStatus.Text = "";
                txtTel.Text = "";
                txtCPF.Text = "";
                MessageBox.Show("Processo Cancelado", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Desativar();
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                cbExibir.Enabled = true;
                gridCliente.Enabled = true;
                txtBusca.Enabled = true;
                btnAddAluno.Visible = false;
                editar = false;
                btnEditar.Enabled = false;
                btnAddAluno.Enabled = false;
                cbAlunos.Visible = false;
                cbAlunos.Enabled = false;
                lblAlunos.Visible = false;
            }
}
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
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

                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Campo email vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
                    return;
                }

                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Campo senha vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Focus();
                    return;
                }

                if (txtEnd.Text == "")
                {
                    MessageBox.Show("Campo endereço vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEnd.Focus();
                    return;
                }

                if (txtBairro.Text == "")
                {
                    MessageBox.Show("Campo bairro vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBairro.Focus();
                    return;
                }

                if (txtTel.Text == "")
                {
                    MessageBox.Show("Campo telefone vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTel.Focus();
                    return;
                }

                if (txtCPF.Text == "")
                {
                    MessageBox.Show("Campo CPF vazio, preencha as informações!", "Informações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCPF.Focus();
                    return;
                }

                conn.AbrirConexao();
                if (txtCPF.Text != cpfAntigo)
                {
                    sql = "SELECT * FROM pais WHERE cpfPais = @cpf";
                    execSql = new MySqlCommand(sql, conn.conMySql);
                    execSql.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = execSql;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Usuário já Registrado", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCPF.Text = "";
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
                        sql = "UPDATE pais SET nomePais=@nomePais,emailPais=@email,senhaPais=@senha,statusPais=@status,idAluno=@idAluno,enderecoPais=@endereco,bairroPais=@bairro,numeroFonePais=@fone,cpfPais=@cpf WHERE idPais = @idPais";
                        execSql = new MySqlCommand(sql, conn.conMySql);

                        execSql.Parameters.AddWithValue("@idPais", idPais);
                        execSql.Parameters.AddWithValue("@nomePais", txtNome.Text);
                        execSql.Parameters.AddWithValue("@email", txtEmail.Text);
                        execSql.Parameters.AddWithValue("@senha", txtSenha.Text);
                        execSql.Parameters.AddWithValue("@status", cbStatus.Text);
                        execSql.Parameters.AddWithValue("@endereco", txtEnd.Text);
                        execSql.Parameters.AddWithValue("@idAluno", idAluno);
                        execSql.Parameters.AddWithValue("@end", txtEnd.Text);
                        execSql.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        execSql.Parameters.AddWithValue("@fone", txtTel.Text);
                        execSql.Parameters.AddWithValue("@cpf", txtCPF.Text);


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
            editar = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnDesativar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            txtNome.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            cbStatus.Text = "";
            txtEnd.Text = "";
            txtBairro.Text = "";
            txtTel.Text = "";
            txtCPF.Text = "";
            
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (cbStatus.Text == "ATIVO")
            {
                var resposta = MessageBox.Show("Deseja desativar esse registro?", "Desativar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        conn.AbrirConexao();

                        sql = "UPDATE pais SET statusPais='INATIVO' WHERE idPais = @idPais";
                        execSql = new MySqlCommand(sql, conn.conMySql);

                        execSql.Parameters.AddWithValue("idPais", idPais);

                        execSql.ExecuteNonQuery();
                        conn.FecharConexao();
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }

                    MessageBox.Show("Registro Desativado", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                var resposta = MessageBox.Show("Deseja Ativar esse registro?", "Ativar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    btnDesativar.Text = "Ativar";
                    try
                    {
                        conn.AbrirConexao();

                        sql = "UPDATE pais SET statusPais='ATIVO' WHERE idPais = @idPais";
                        execSql = new MySqlCommand(sql, conn.conMySql);

                        execSql.Parameters.AddWithValue("idPais", idPais);

                        execSql.ExecuteNonQuery();
                        conn.FecharConexao();
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }

                    MessageBox.Show("Registro Ativado", "Sistema Reobote", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }



            VerificarExibir();

            btnEditar.Enabled = false;
            btnDesativar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            txtNome.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            cbStatus.Text = "";
            txtEnd.Text = "";
            txtBairro.Text = "";
            txtTel.Text = "";
            txtCPF.Text = "";
            Desativar();

        }

        private void gridCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            
                
                cbAlunos.Visible = true;
                cbAlunos.Enabled = true;
                lblAlunos.Visible = true;
                btnAddAluno.Visible = true;
                btnAddAluno.Enabled = true;

            editar = true;
                btnEditar.Enabled = true;
                if (cbExibir.Text == "INATIVOS")
                {
                    btnDesativar.Enabled = true;
                }
                else
                {
                    btnDesativar.Enabled = true;
                }


                btnCancelar.Enabled = true;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = false;

                Ativar();

                idPais = gridCliente.CurrentRow.Cells[0].Value.ToString();
                cpfAntigo = gridCliente.CurrentRow.Cells[10].Value.ToString();
                nomeAntigo = gridCliente.CurrentRow.Cells[1].Value.ToString();
                senhaAntiga = gridCliente.CurrentRow.Cells[3].Value.ToString();
                StatusAntigo = gridCliente.CurrentRow.Cells[4].Value.ToString();
                EndAntigo = gridCliente.CurrentRow.Cells[7].Value.ToString();
                BairroAntigo = gridCliente.CurrentRow.Cells[8].Value.ToString();
                telAntigo = gridCliente.CurrentRow.Cells[9].Value.ToString();
                idAluno = gridCliente.CurrentRow.Cells[6].Value.ToString();



                txtNome.Text = gridCliente.CurrentRow.Cells[1].Value.ToString();
                txtEmail.Text = gridCliente.CurrentRow.Cells[2].Value.ToString();
                txtSenha.Text = gridCliente.CurrentRow.Cells[3].Value.ToString();
                cbStatus.Text = gridCliente.CurrentRow.Cells[4].Value.ToString();
            
                txtEnd.Text = gridCliente.CurrentRow.Cells[7].Value.ToString();
                txtBairro.Text = gridCliente.CurrentRow.Cells[8].Value.ToString();
                txtTel.Text = gridCliente.CurrentRow.Cells[9].Value.ToString();
                txtCPF.Text = gridCliente.CurrentRow.Cells[10].Value.ToString();
                ListarAlunos();
            
           

           
        }

        private void cbExibir_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (editar == true)
            {
                if (cpfAntigo != txtCPF.Text || nomeAntigo != txtNome.Text || emailAntigo != txtEmail.Text || senhaAntiga != txtSenha.Text || StatusAntigo != cbStatus.Text || EndAntigo != txtEnd.Text || BairroAntigo != txtBairro.Text)
                {
                    Cancelar();
                }

                VerificarExibir();

            }
            else
            {
                VerificarExibir();
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
                if (txtBusca.Text.Length == 11)
                {
                    Buscar();
                }
                else
                {
                    ListarDados();
                }
            
          
            
            
        }

        private void Buscar()
        {
                conn.AbrirConexao();
                sql = "SELECT * FROM pais WHERE cpfPais = @cpf";
                execSql = new MySqlCommand(sql, conn.conMySql);

                execSql.Parameters.AddWithValue("@cpf", txtBusca.Text);

                MySqlDataAdapter conjDados = new MySqlDataAdapter();
                conjDados.SelectCommand = execSql;

                DataTable dadosTabela = new DataTable();
                conjDados.Fill(dadosTabela);

                gridCliente.DataSource = dadosTabela;

                conn.FecharConexao();
            
           
                
            
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddAluno_Click(object sender, EventArgs e)
        {
            Cliente.frmCadAluno frmCadAluno = new Cliente.frmCadAluno();
            frmCadAluno.Propiedade = idPais;
            addAluno = "sim";
            frmCadAluno.addAluno = addAluno;
            frmCadAluno.ShowDialog();
            ListarAlunos();
            ListarDados();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbTipo.Text != "Responsáveis")
            {
                addAluno = "nao";
                Cliente.frmCadAluno frmCadAluno = new Cliente.frmCadAluno();
                frmCadAluno.addAluno = addAluno;
                frmCadAluno.ShowDialog();
                cbTipo.Text = "Responsáveis";

                txtNome.Text = "";
                txtEmail.Text = "";
                txtSenha.Text = "";
                txtEnd.Text = "";
                txtBairro.Text = "";
                cbStatus.Text = "";
                txtTel.Text = "";
                txtCPF.Text = "";
                Desativar();
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                cbExibir.Enabled = true;
                gridCliente.Enabled = true;
                btnAddAluno.Visible = false;
                editar = false;
                btnEditar.Enabled = false;
                btnAddAluno.Enabled = false;
                cbAlunos.Visible = false;
                cbAlunos.Enabled = false;
                lblAlunos.Visible = false;
            }
        }

        

        

       

        private void btnAddAval_Click(object sender, EventArgs e)
        {
            Cliente.frmCadAval frmCadAval = new Cliente.frmCadAval();
            frmCadAval.idAluno1 = idAluno;
            frmCadAval.aval1 = aval;
            frmCadAval.ShowDialog();
        }

        private void dgNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        
    }
}

