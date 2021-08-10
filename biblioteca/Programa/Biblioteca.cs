using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Programa
{
    class Biblioteca
    {
        public void AdicionarLivro(String titulo, String autor, String editora, String descricao, int publicado, int quantidade)
        {
            Livro l = new Livro();
            SQLite banco = new SQLite();

            l.SetTitulo(titulo);
            l.SetAutor(autor);
            l.SetEditora(editora);
            l.SetDescricao(descricao);
            l.SetPublicado(publicado);
            l.SetQuantidade(quantidade);
            banco.PrintStartupPath();
            banco.InserirLivro(l);
        }
        public DataTable MostrarLivros()
        {
            SQLite banco = new SQLite();
            DataTable dt = new DataTable();

            dt = banco.Procurar(dt);
            return dt;
        }
    }
}
