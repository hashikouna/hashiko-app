using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funcionarios.Banco_de_Dados;
using System.Data;

namespace Funcionarios
{
    public class Ligamento
    {
        Metodos metodo = new Metodos();
        //metodo para salvar
        public void Salvar(Func funcionario)
        {
            try
            {
                metodo.Salvar(funcionario);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        //metodo para listar
        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = metodo.Listar();
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable Listarlista()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = metodo.Listarlista();
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        //metodo para editar
        public void Editar(Func funcionario)
        {
            try
            {
                metodo.Editar(funcionario);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable FiltroAtivos()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = metodo.ListarAtivos();
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable FiltroFerias()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = metodo.ListarFerias();
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable FiltroAtestado()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = metodo.ListarAtestado();
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public DataTable FiltroDemitido()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = metodo.ListarDemitido();
                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
