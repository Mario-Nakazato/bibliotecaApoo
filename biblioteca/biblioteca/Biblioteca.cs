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
            Console.WriteLine("Instancia banco");
        }

        public void AdicionarLivro(string titulo, string autor, string editora, string publicado, string quantidade, string descricao)
        {
            banco.InserirLivro(titulo, autor, editora, publicado, quantidade, descricao);
        }

        public void RemoverLivro(string id)
        {
            banco.ExcluirLivro(id);
        }

        public DataTable ListarLivros(string titulo)
        {
            return banco.ProcurarLivro(titulo);
        }
    }
}
