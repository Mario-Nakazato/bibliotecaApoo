using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    class Livro
    {
        private String titulo, autor, editora, descricao;
        private int publicado, quantidade;
        

        public void SetTitulo(String s)
        {
            this.titulo = s;
        }
        public void SetAutor(String s)
        {
            this.autor = s;
        }
        public void SetEditora(String s)
        {
            this.editora = s;
        }
        public void SetDescricao(String s)
        {
            this.descricao = s;
        }
        public void SetPublicado(int i)
        {
            this.publicado = i;
        }
        public void SetQuantidade(int i)
        {
            this.quantidade = i;
        }
        public String GetTitulo()
        {
            return titulo;
        }
        public String GetAutor()
        {
            return autor;
        }
        public String GetEditora()
        {
            return editora;
        }
        public String GetDescricao()
        {
            return descricao;
        }
        public int GetPublicado()
        {
            return publicado;
        }
        public int GetQuantidade()
        {
            return quantidade;
        }
    }
}
