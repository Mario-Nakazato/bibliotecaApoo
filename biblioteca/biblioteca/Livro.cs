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
        private string _capa;

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
                if (value != "")
                {
                    _titulo = value;
                }
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
                if (value != "")
                {
                    _autor = value;
                }
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
                if (value != "")
                {
                    _editora = value;
                }
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

        public string capa
        {
            get
            {
                return _capa;
            }
            set
            {
                _capa = value;
            }
        }
    }
}
