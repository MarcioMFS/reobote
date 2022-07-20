using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reobote
{
    class Conexao
    {
        string conn = "SERVER=localhost;DATABASE=reobote;UID=root;PWD=;PORT=3306;SslMode=none;convert zero datetime= True";
        public MySqlConnection conMySql = null;

        public void AbrirConexao()
        {
            try
            {
                conMySql = new MySqlConnection(conn);
                conMySql.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void FecharConexao()
        {
            try
            {
                conMySql = new MySqlConnection(conn);
                conMySql.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
