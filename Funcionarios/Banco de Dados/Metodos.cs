using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Funcionarios.Banco_de_Dados;
using System.Data;

namespace Funcionarios.Banco_de_Dados
{
    public class Metodos : AcessoDados
    {
        MySqlCommand comando = null;

        public void Salvar(Func funcionario)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO officials (name, lastname, cpf, sex, birth_day, email, phone, street, number, district, city, state, zipcode, situation) VALUES (@nome, @sobrenome, @cpf, @sexo, @nascimento, @email, @celular, @rua, @numero, @bairro, @cidade, @estado, @cep, @situacao)", conexao);
                comando.Parameters.AddWithValue("@nome", funcionario.name);
                comando.Parameters.AddWithValue("@sobrenome", funcionario.lastname);
                comando.Parameters.AddWithValue("@cpf", funcionario.cpf);
                comando.Parameters.AddWithValue("@sexo", funcionario.sex);
                comando.Parameters.AddWithValue("@nascimento", funcionario.birth_day);
                comando.Parameters.AddWithValue("@email", funcionario.email);
                comando.Parameters.AddWithValue("@celular", funcionario.phone);
                comando.Parameters.AddWithValue("@rua", funcionario.street);
                comando.Parameters.AddWithValue("@numero", funcionario.number);
                comando.Parameters.AddWithValue("@bairro", funcionario.district);
                comando.Parameters.AddWithValue("@cidade", funcionario.city);
                comando.Parameters.AddWithValue("@estado", funcionario.state);
                comando.Parameters.AddWithValue("@cep", funcionario.zipcode);
                comando.Parameters.AddWithValue("@situacao", funcionario.situation);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        //listar danco de dados
        public DataTable Listar()
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT * FROM officials ORDER BY id", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public DataTable Listarlista()
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT id, name, lastname, cpf, sex, birth_day, email, phone, street, number, district, city, state, zipcode FROM officials ORDER BY id", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        //metodo editar
        public void Editar(Func funcionario)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("UPDATE officials SET name= @nome, lastname= @sobrenome, cpf= @cpf , sex= @sexo, birth_day= @nascimento, email= @email, phone= @celular, street= @rua, number= @numero, district= @bairro, city= @cidade, state= @estado, zipcode= @cep, situation= @situacao WHERE id= @id", conexao);
                comando.Parameters.AddWithValue("@id", funcionario.id);
                comando.Parameters.AddWithValue("@nome", funcionario.name);
                comando.Parameters.AddWithValue("@sobrenome", funcionario.lastname);
                comando.Parameters.AddWithValue("@cpf", funcionario.cpf);
                comando.Parameters.AddWithValue("@sexo", funcionario.sex);
                comando.Parameters.AddWithValue("@nascimento", funcionario.birth_day);
                comando.Parameters.AddWithValue("@email", funcionario.email);
                comando.Parameters.AddWithValue("@celular", funcionario.phone);
                comando.Parameters.AddWithValue("@rua", funcionario.street);
                comando.Parameters.AddWithValue("@numero", funcionario.number);
                comando.Parameters.AddWithValue("@bairro", funcionario.district);
                comando.Parameters.AddWithValue("@cidade", funcionario.city);
                comando.Parameters.AddWithValue("@estado", funcionario.state);
                comando.Parameters.AddWithValue("@cep", funcionario.zipcode);
                comando.Parameters.AddWithValue("@situacao", funcionario.situation);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public DataTable ListarAtivos()
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT id, name, lastname, cpf, sex, birth_day, email, phone, street, number, district, city, state, zipcode FROM officials WHERE situation = 'ativo'", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public DataTable ListarFerias()
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT id, name, lastname, cpf, sex, birth_day, email, phone, street, number, district, city, state, zipcode FROM officials WHERE situation = 'ferias'", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public DataTable ListarAtestado()
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT id, name, lastname, cpf, sex, birth_day, email, phone, street, number, district, city, state, zipcode FROM officials WHERE situation = 'atestado'", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        public DataTable ListarDemitido()
        {
            try
            { 
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT id, name, lastname, cpf, sex, birth_day, email, phone, street, number, district, city, state, zipcode FROM officials WHERE situation = 'demitido'", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
