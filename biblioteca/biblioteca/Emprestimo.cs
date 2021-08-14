using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Emprestimo
    {
        private string _codigo;
        private string _nomeCompleto;
        private string _dataEmprestimo;
        private string _dataDevolucao;

        public Emprestimo(string codigo, string nomeCompleto, string dataEmprestimo, string dataDevolucao)
        {
            _codigo = codigo;
            _nomeCompleto = nomeCompleto;
            _dataEmprestimo = dataEmprestimo;
            _dataDevolucao = dataDevolucao;
        }

        public string codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                if (int.Parse(value) >= 0)
                {
                    _codigo = value;
                }
            }
        }
        
        public string nomeCompleto
        {
            get
            {
                return _nomeCompleto;
            }
            set
            {
                _nomeCompleto = value;
            }
        }
        
        public string dataEmprestimo
        {
            get
            {
                return _dataEmprestimo;
            }
            set
            {
                _dataEmprestimo = value;
            }
        }
        
        public string dataDevolucao
        {
            get
            {
                return _dataDevolucao;
            }
            set
            {
                _dataDevolucao = value;
            }
        }
    }
}
