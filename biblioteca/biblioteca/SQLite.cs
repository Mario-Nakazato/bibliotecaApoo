using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;//File
using System.Windows.Forms;//Application
using System.Data.SQLite;
using System.Data;

namespace biblioteca
{
    class SQLite
    {
        private string bancoDados;
        private string conexao;
        private SQLiteConnection conectar;

        public SQLite()
        {
            bancoDados = Application.StartupPath + @"\biblioteca.db";
            conexao = @"Data Source = " + bancoDados + "; Version = 3";
            conectar = new SQLiteConnection(conexao);
        }

        public void Conectar()//Reconstruir o banco do zero. Descontinuado no momento
        {
            if (!File.Exists(bancoDados))
            {
                SQLiteConnection.CreateFile(bancoDados);
            }

            try
            {
                conectar.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar SQLite \n" + ex);
            }
            finally
            {
                conectar.Close();
            }
        }

        public void InserirLivro(string titulo, string autor, string editora, string publicado, string quantidade, string descricao)
        {
            try
            {
                conectar.Open();
                
                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conectar;

                comando.CommandText = "INSERT INTO LIVRO (liv_titulo, liv_autor, liv_editora, liv_publicado, liv_quantidade, liv_descricao)" +
                    "VALUES " + "('" + titulo + "', '" + autor + "', '" + editora + "', '" + publicado + "', '" + quantidade + "', '" + descricao + "')";
                
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir registro SQLite " + ex.Message);
            }
            finally
            {
                conectar.Close();
            }
        }

        public void ExcluirLivro(string id)
        {
            try
            {
                conectar.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conectar;

                comando.CommandText = "DELETE FROM LIVRO WHERE liv_id = '" + id + "'";
                
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir registro SQLite " + ex.Message);
            }
            finally
            {
                conectar.Close();
            }
        }

        public DataTable ProcurarLivro(string pesquisa, string atributo)
        {
            DataTable dados = new DataTable(); ;
            try
            {
                string query = "SELECT * FROM LIVRO";

                if (atributo == "titulo")
                {
                    if (pesquisa != "")
                    {
                        query = "SELECT * FROM LIVRO WHERE liv_titulo LIKE '%" + pesquisa + "%'";
                    }
                }
                else if (atributo == "id")
                {
                    query = "SELECT * FROM LIVRO WHERE liv_id = " + pesquisa;
                }
                
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexao);

                conectar.Open();
                adaptador.Fill(dados);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir registro SQLite " + ex.Message);
            }
            finally
            {
                conectar.Close();
            }
            return dados;
        }
    }
}
