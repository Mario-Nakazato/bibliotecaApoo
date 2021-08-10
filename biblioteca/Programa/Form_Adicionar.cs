using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa
{
    public partial class Form_Adicionar : Form
    {
        public Form_Adicionar()
        {
            InitializeComponent();
        }

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            Biblioteca b = new Biblioteca();
            try
            {
                b.AdicionarLivro(txb_titulo.Text, txb_autor.Text, txb_editora.Text, txb_descricao.Text, int.Parse(txb_publicado.Text), int.Parse(txb_quantidade.Text));
            }
            catch (Exception exp)
            {
                MessageBox.Show("Erro ao adicionar, por favor tente novamente. Erro: " + exp);
                txb_titulo.Text = "";
                txb_autor.Text = "";
                txb_editora.Text = "";
                txb_descricao.Text = "";
                txb_publicado.Text = "";
                txb_quantidade.Text = "";
            }
            finally
            {
                this.Close();
            }   
        }
    }
}
