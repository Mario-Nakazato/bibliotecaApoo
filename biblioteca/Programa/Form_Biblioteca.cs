using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Programa
{
    public partial class Form_Biblioteca : Form
    {
        Thread nt;
        public Form_Biblioteca()
        {
            InitializeComponent();
            IniciaTabela();
        }

        private void IniciaTabela()
        {
            Biblioteca bb = new Biblioteca();

            dataGridViewDados.Rows.Clear();
            try
            {
                dataGridViewDados.DataSource = bb.MostrarLivros();
            }
            catch(Exception exp)
            {
                MessageBox.Show("Erro ao conectar ao Banco de dados\nErro: " + exp);
            }
        }

        private void bt_Pesquisar_Click(object sender, EventArgs e)
        {
            Biblioteca bb = new Biblioteca();
            DataTable dt = new DataTable();

            dataGridViewDados.Rows.Clear();

            dt = bb.MostrarLivros();

            foreach (DataRow linha in dt.Rows)
            {
                dataGridViewDados.Rows.Add(linha.ItemArray);
            }
        }

        private void adicionarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nt = new Thread(nForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void nForm()
        {
            Application.Run(new Form_Adicionar());
        }
    }
}
