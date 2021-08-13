using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Emprestimo
    {
        private int _codigo;
        private string _nomeCompleto;
        private string _dataEmprestimo;
        private string _dataDevolucao;
        public int codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
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
