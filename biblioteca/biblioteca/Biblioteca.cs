using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Biblioteca
    {
        private SQLite banco;
        
        public Biblioteca()
        {
            banco = new SQLite();
        }

        public void AdicionarLivro(Livro livro)
        {
            banco.InserirLivro(livro.titulo, livro.autor, livro.editora, livro.publicado, livro.quantidade, livro.descricao);
        }

        public void RemoverLivro(Livro livro)
        {
            banco.ExcluirLivro(livro.id);
        }

        public DataTable ListarLivros(Livro livro, string pesquisa)
        {
            return banco.ProcurarLivro(livro.titulo, pesquisa);
        }
    }
}
