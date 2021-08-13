using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class Form : System.Windows.Forms.Form
    {

        Biblioteca biblioteca;
        public Form()
        {
            InitializeComponent();
            biblioteca = new Biblioteca();
            Console.WriteLine("Instancia biblioteca");
        }

        private void Listadgv(string pesquisa)
        {
            dgvBanco.Rows.Clear();
            DataTable dados = biblioteca.ListarLivros(pesquisa);
            foreach (DataRow linha in dados.Rows)
            {
                dgvBanco.Rows.Add(linha.ItemArray);
            }
            dgvBanco.Rows[0].Selected = false;
        }
        private void btnBuscarEstoque_Click(object sender, EventArgs e)
        {
            Listadgv(txtTituloEstoque.Text);
        }

        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            biblioteca.AdicionarLivro(txtTituloEstoque.Text, txtAutorEstoque.Text, txtEditoraEstoque.Text, nudPublicadoEstoque.Value.ToString(), nudQuantidadeEstoque.Value.ToString(), rtxDescricaoEstoque.Text);
            txtTituloEstoque.Text = "";
            txtAutorEstoque.Text = "";
            txtEditoraEstoque.Text = "";
            nudPublicadoEstoque.Value = 0;
            nudQuantidadeEstoque.Value = 0;
            rtxDescricaoEstoque.Text = "";
            Listadgv("");
        }

        private void btnRemoverEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                biblioteca.RemoverLivro(dgvBanco.SelectedRows[0].Cells[0].Value.ToString());
                Listadgv("");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                //MessageBox.Show("Impossivel remover");
                Console.WriteLine("Erro ao inserir registro SQLite " + ex.Message);
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            lblTituloBiblioteca.Text = "";
            lblAutorBiblioteca.Text = "";
            lblEditoraBiblioteca.Text = "";
            lblPublicadoBiblioteca.Text = "";
            lblDescricaoBiblioteca.Text = "";
            rtxDescricaoBiblioteca.Visible = false;
            //Imagem invisivel
            Listadgv("");
        }

        private void btnBuscaBiblioteca_Click(object sender, EventArgs e)
        {
            Listadgv(txtPesquisaBiblioteca.Text);
        }

        private void btnLimparBiblioteca_Click(object sender, EventArgs e)
        {
            txtPesquisaBiblioteca.Text = "";
            lblTituloBiblioteca.Text = "";
            lblAutorBiblioteca.Text = "";
            lblEditoraBiblioteca.Text = "";
            lblPublicadoBiblioteca.Text = "";
            lblDescricaoBiblioteca.Text = "";
            rtxDescricaoBiblioteca.Visible = false;
            Listadgv("");
        }

        private void dgvBanco_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (tab.SelectedTab.Text == "Biblioteca")
            {
                lblTituloBiblioteca.Text = "Titulo: " + dgvBanco.SelectedRows[0].Cells[1].Value.ToString();
                lblAutorBiblioteca.Text = "Autor: " + dgvBanco.SelectedRows[0].Cells[2].Value.ToString();
                lblEditoraBiblioteca.Text = "Editora: " + dgvBanco.SelectedRows[0].Cells[3].Value.ToString();
                lblPublicadoBiblioteca.Text = "Publicado: " + dgvBanco.SelectedRows[0].Cells[4].Value.ToString();
                lblDescricaoBiblioteca.Text = "Descrição:";
                rtxDescricaoBiblioteca.Visible = true;
                rtxDescricaoBiblioteca.Text = dgvBanco.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void btnLimparEstoque_Click(object sender, EventArgs e)
        {
            txtTituloEstoque.Text = "";
            txtAutorEstoque.Text = "";
            txtEditoraEstoque.Text = "";
            nudPublicadoEstoque.Value = 0;
            nudQuantidadeEstoque.Value = 0;
            rtxDescricaoEstoque.Text = "";
            Listadgv("");
        }
    }
}
