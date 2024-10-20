using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // adiciona a biblioteca para conexao com o banco de dados em MySQL

namespace teste
{
    class Conexao
    {
        public MySqlConnection conexao = new MySqlConnection();

        public void Conectar()
        {
            //constroi a string de conexão
            conexao.ConnectionString = @"server=127.0.0.1;user id=root; pwd='';database=financeiro";
            
            MySqlCommand query = new MySqlCommand();
            query.Connection = conexao;
            conexao.Open();
        }

        public void Desconectar()
        {
            conexao.Close();
        }               
    }
}
