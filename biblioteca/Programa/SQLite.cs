using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace Programa
{
    class SQLite
    {
        public void InserirLivro(Livro l)
        {
            string bancoDados = Application.StartupPath + @"\bd_biblioteca.db";
            string conexao = @"Data Source = " + bancoDados + "; Version = 3";

            SQLiteConnection conectar = new SQLiteConnection(conexao);

            conectar.Open();
            SQLiteCommand comando = new SQLiteCommand();

            comando.Connection = conectar;
            comando.CommandText = "INSERT INTO livro VALUES " +
                "(" + l.GetTitulo() + ", '" + l.GetAutor() + "', '" + l.GetEditora()+ "', '"+ l.GetPublicado()+"', '" + l.GetQuantidade()+"', '"+ l.GetDescricao()+ "')";
            comando.ExecuteNonQuery();
            comando.Dispose();

            conectar.Close();
        }
        public DataTable Procurar(DataTable dt)
        {

            string bancoDados = Application.StartupPath + @"\bd_biblioteca.db";
            string conexao = @"Data Source = " + bancoDados + "; Version = 3";

            SQLiteConnection conectar = new SQLiteConnection(conexao);

            string query = "SELECT liv_titulo AS 'Titulo', liv_autor AS 'Autor' FROM livro;";

            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexao);

            conectar.Open();

            adaptador.Fill(dt);

            conectar.Close();

            return dt;
        }
        public void PrintStartupPath()
        {
            string bancoDados = Application.StartupPath + @"\bd_biblioteca.db";
            string conexao = @"Data Source = " + bancoDados + "; Version = 3";

            MessageBox.Show(conexao);
        }
    }
}
