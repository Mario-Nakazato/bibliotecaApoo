using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    No data grid somente titulo, autor e publicado
*/

namespace biblioteca
{
    public partial class Form : System.Windows.Forms.Form
    {

        Biblioteca biblioteca;
        Livro livro;
        Emprestimo emprestimo;

        public Form()
        {
            InitializeComponent();
            biblioteca = new Biblioteca();
        }

        private void Listadgv(string pesquisa)
        {
            livro = new Livro();
            livro.titulo = pesquisa;
            dgvBanco.Rows.Clear();
            DataTable dados = biblioteca.ListarLivros(livro, "titulo");
            foreach (DataRow linha in dados.Rows)
            {
                dgvBanco.Rows.Add(linha.ItemArray);
                Console.WriteLine(linha.ItemArray.Length);
                Console.WriteLine(dados.Rows);
            }
            dgvBanco.ClearSelection();
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

        private void dgvBanco_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && tab.SelectedTab.Text == "Biblioteca")
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

        private void btnBuscarEstoque_Click(object sender, EventArgs e)
        {
            Listadgv(txtTituloEstoque.Text);
        }

        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            livro = new Livro(txtTituloEstoque.Text, txtAutorEstoque.Text, txtEditoraEstoque.Text, nudPublicadoEstoque.Value.ToString(), nudQuantidadeEstoque.Value.ToString(), rtxDescricaoEstoque.Text);
            biblioteca.AdicionarLivro(livro);
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
                livro = new Livro();
                livro.id = dgvBanco.SelectedRows[0].Cells[0].Value.ToString();
                biblioteca.RemoverLivro(livro);
                Listadgv("");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Erro " + ex.Message);
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

        private void btnAdicionarEmprestimo_Click(object sender, EventArgs e)
        {
            try
            {
                livro = new Livro();
                livro.titulo = dgvBanco.SelectedRows[0].Cells[0].Value.ToString();
                DataTable dados = biblioteca.ListarLivros(livro, "id");
                foreach (DataRow linha in dados.Rows)
                {
                    dgvLivro.Rows.Add(linha.ItemArray);
                }
                dgvBanco.ClearSelection();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Erro " + ex.Message);
            }
        }

        private void btnRemoverEmprestimo_Click(object sender, EventArgs e)
        {
            try
            {
                dgvLivro.Rows.RemoveAt(dgvLivro.SelectedRows[0].Index);
                dgvLivro.ClearSelection();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Erro " + ex.Message);
            }
        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            livro = new Livro();
            //livro.titulo = dgvBanco.SelectedRows[0].Cells[0].Value.ToString();
            //emprestimo = new Emprestimo(txtCodigoEmprestimo.Text, txtNomeEmprestimo.Text, dtpEmprestimo.Value.ToString(), dtpDevolucao.Value.ToString(), );
            //biblioteca.EmprestarLivro(emprestimo);
            txtCodigoEmprestimo.Text = "";
            txtNomeEmprestimo.Text = "";
            dtpEmprestimo.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now;
            dgvLivro.Rows.Clear();
            Listadgv("");
        }
    }
}
