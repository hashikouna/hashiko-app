using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Funcionarios
{
    public class AcessoDados
    {
        string conecta = "server=localhost; port=3306; User Id=root; database=hashiko";
        protected MySqlConnection conexao = null;

        //metodo para conectar no banco de dados
        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Open();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        //metodo para fechar o banco de dados
        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
