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
        private static string bancoDados = Application.StartupPath + @"\bd_biblioteca.db";
        private static string conexao = @"Data Source = " + bancoDados + "; Version = 3";
        private SQLiteConnection conectar = new SQLiteConnection(conexao);

        public SQLite()
        {
            Conectar();
            Console.WriteLine("SQLite construtor");
        }

        public void Conectar()
        {
            Console.WriteLine("SQLite metodo Conectar");
            if (!File.Exists(bancoDados))
            {
                SQLiteConnection.CreateFile(bancoDados);
                Console.WriteLine("Criando banco de dados SQLite");
            }

            try
            {
                conectar.Open();
                Console.WriteLine("Conectado SQLite");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar SQLite \n" + ex);
            }
            finally
            {
                conectar.Close();
                Console.WriteLine("SQLite Close");
            }
        }

        public void InserirLivro(string titulo, string autor, string editora, string publicado, string quantidade, string descricao)
        {
            try
            {
                conectar.Open();
                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conectar;

                comando.CommandText = "INSERT INTO livro (liv_titulo, liv_autor, liv_editora, liv_publicado, liv_quantidade, liv_descricao)" + 
                    "VALUES " + "('" + titulo + "', '" + autor + "', '" + editora + "', '" + publicado + "', '" + quantidade + "', '" + descricao + "')";
                comando.ExecuteNonQuery();
                comando.Dispose();
                Console.WriteLine("Registro inserido SQLite");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir registro SQLite " + ex.Message);
            }
            finally
            {
                conectar.Close();
                Console.WriteLine("SQLite Close");
            }
        }

        public void ExcluirLivro(string id)
        {
            try
            {
                conectar.Open();
                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conectar;

                comando.CommandText = "DELETE FROM livro WHERE liv_codigo = '" + id + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();
                Console.WriteLine("Registro excluido SQLite");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir registro SQLite " + ex.Message);
            }
            finally
            {
                conectar.Close();
                Console.WriteLine("SQLite Close");
            }
        }

        public DataTable ProcurarLivro(string titulo)
        {
            DataTable dados = new DataTable(); ;
            try
            {
                string query = "SELECT * FROM livro";
                
                if (titulo != "")
                {
                    query = "SELECT * FROM livro WHERE liv_titulo LIKE '%" + titulo + "%'";
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
                Console.WriteLine("SQLite Close");
            }
            return dados;
        }
    }
}
