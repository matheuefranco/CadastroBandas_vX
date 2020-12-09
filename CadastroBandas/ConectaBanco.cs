using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
namespace CadastroBandas
{
    class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=compServer;database=banco_bandas");
        public string mensagem;

        public DataTable lista()
        {
            MySqlCommand cmd = new MySqlCommand("listaBandas", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();// conectando com o banco
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dados = new DataTable();
                da.Fill(dados);
                return dados;
            }
            catch(MySqlException erro)
            {
                mensagem = "Erro MySQL:" + erro.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista
    }
}
