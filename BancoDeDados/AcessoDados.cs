using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BancoDeDados
{
    class AcessoDados
    {
        try 
	{	        
		MySqlConnection conexao = new MySqlConnection("server= localhost; port=3306; user id=root; database=hashiko");
    }
	catch (global::System.Exception)
	{

		throw;
	}

    }
}
