using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Livro
    {
        private string _titulo;
        private string _autor;
        private string _editora;
        private int _publicado;
        private int _quantidade;
        private string _descricao;
        public string titulo
        {
            get
            {
                return _titulo;
            }
            set
            {
                _titulo = value;
            }
        }
        public string autor
        {
            get
            {
                return _autor;
            }
            set
            {
                _autor = value;
            }
        }
        public string editora
        {
            get
            {
                return _editora;
            }
            set
            {
                _editora = value;
            }
        }
        public int publicado
        {
            get
            {
                return _publicado;
            }
            set
            {
                _publicado = value;
            }
        }
        public int quantidade
        {
            get
            {
                return _quantidade;
            }
            set
            {
                _quantidade = value;
            }
        }
        public string descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                _descricao = value;
            }
        }
    }
}
