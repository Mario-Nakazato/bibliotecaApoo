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

        public string codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                if (int.TryParse(value, out int n) && int.Parse(value) >= 0)
                {
                    _codigo = value;
                }
                else
                {
                    _codigo = "";
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
                if (value != "")
                {
                    _nomeCompleto = value;
                }
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
                if (value != "")
                {
                    _dataEmprestimo = value;
                }
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
                if (value != "")
                {
                    _dataDevolucao = value;
                }
            }
        }
    }
}
