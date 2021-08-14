using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Livro
    {
        private string _id;
        private string _titulo;
        private string _autor;
        private string _editora;
        private string _publicado;
        private string _quantidade;
        private string _descricao;

        public Livro()
        {
        }

        public Livro(string titulo, string autor, string editora, string publicacao, string quantidade, string descricao)
        {
            _id = id;
            _titulo = titulo;
            _autor = autor;
            _editora = editora;
            _publicado = publicacao;
            _quantidade = quantidade;
            _descricao = descricao;
        }

        public Livro(string id, string titulo, string autor, string editora, string publicacao, string quantidade, string descricao)
        {
            _id = id;
            _titulo = titulo;
            _autor = autor;
            _editora = editora;
            _publicado = publicacao;
            _quantidade = quantidade;
            _descricao = descricao;
        }

        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                if (int.Parse(value) > 0)
                {
                    _id = value;
                }
            }
        }
        
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
        
        public string publicado
        {
            get
            {
                return _publicado;
            }
            set
            {
                if (int.Parse(value) > 0)
                {
                    _publicado = value;
                }
            }
        }
        
        public string quantidade
        {
            get
            {
                return _quantidade;
            }
            set
            {
                if (int.Parse(value) >= 0)
                {
                    _quantidade = value;
                }
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
