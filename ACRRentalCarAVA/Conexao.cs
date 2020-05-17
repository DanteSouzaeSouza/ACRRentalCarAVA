using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACRRentalCarAVA
{
    public class Conexao
    {

        //método para realizar a conexão com o banco de dados

        public static SqlConnection GetConnection()
        {
            //cria um objeto (varíavel cnn) do tipo SqlConnection e configura a string de conexão
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_RENTALCAR;Integrated Security=True;Pooling=False");
            //retorna uma conexão com o banco de dados quando esse método for chamado
            return cnn;

        }
    }
}
