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

        private void ListaLivrodgv(string pesquisa)
        {
            livro = new Livro();
            livro.titulo = pesquisa;
            dgvEstoque.Rows.Clear();
            DataTable dados = biblioteca.ListarLivros(livro, "titulo");
            foreach (DataRow linha in dados.Rows)
            {
                dgvEstoque.Rows.Add(linha.ItemArray);
            }
            dgvEstoque.ClearSelection();
        }

        private void ListaEmprestimodgv(string pesquisa)
        {
            emprestimo = new Emprestimo();
            emprestimo.codigo = pesquisa;
            dgvEmprestimo.Rows.Clear();
            DataTable dados = biblioteca.ListarEmprestimo(emprestimo, "codigo");
            foreach (DataRow linha in dados.Rows)
            {
                dgvEmprestimo.Rows.Add(linha.ItemArray);
            }
            dgvEmprestimo.ClearSelection();
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
            ListaLivrodgv("");
            ListaEmprestimodgv("");
        }

        private void dgvBanco_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && tab.SelectedTab.Text == "Biblioteca")
            {
                lblTituloBiblioteca.Text = "Titulo: " + dgvEstoque.SelectedRows[0].Cells[1].Value.ToString();
                lblAutorBiblioteca.Text = "Autor: " + dgvEstoque.SelectedRows[0].Cells[2].Value.ToString();
                lblEditoraBiblioteca.Text = "Editora: " + dgvEstoque.SelectedRows[0].Cells[3].Value.ToString();
                lblPublicadoBiblioteca.Text = "Publicado: " + dgvEstoque.SelectedRows[0].Cells[4].Value.ToString();
                lblDescricaoBiblioteca.Text = "Descrição:";
                rtxDescricaoBiblioteca.Visible = true;
                rtxDescricaoBiblioteca.Text = dgvEstoque.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void btnBuscaBiblioteca_Click(object sender, EventArgs e)
        {
            ListaLivrodgv(txtPesquisaBiblioteca.Text);
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
            ListaLivrodgv("");
        }

        private void btnBuscarEstoque_Click(object sender, EventArgs e)
        {
            ListaLivrodgv(txtTituloEstoque.Text);
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
            ListaLivrodgv("");
        }

        private void btnRemoverEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                livro = new Livro();
                livro.id = dgvEstoque.SelectedRows[0].Cells[0].Value.ToString();
                biblioteca.RemoverLivro(livro);
                ListaLivrodgv("");
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
            ListaLivrodgv("");
        }

        private void btnAdicionarEmprestimo_Click(object sender, EventArgs e)
        {
            try
            {
                livro = new Livro();
                livro.titulo = dgvEstoque.SelectedRows[0].Cells[0].Value.ToString();
                DataTable dados = biblioteca.ListarLivros(livro, "id");
                foreach (DataRow linha in dados.Rows)
                {
                    dgvLivro.Rows.Add(linha.ItemArray);
                }
                dgvEstoque.ClearSelection();
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
            List<string> a = new List<string>();

            foreach (DataGridViewRow row in dgvLivro.Rows)
            {
                a.Add(row.Cells[0].Value.ToString());
            }

            string[] livros = a.ToArray();

            emprestimo = new Emprestimo(txtCodigoEmprestimo.Text, txtNomeEmprestimo.Text, dtpEmprestimo.Value.ToString(), dtpDevolucao.Value.ToString());
            biblioteca.EmprestarLivro(emprestimo, livros);
            txtCodigoEmprestimo.Text = "";
            txtNomeEmprestimo.Text = "";
            dtpEmprestimo.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now;
            dgvLivro.Rows.Clear();
            ListaEmprestimodgv("");
            ListaLivrodgv("");
        }

        private void btnBuscarEmprestimo_Click(object sender, EventArgs e)
        {
            if (txtCodigoEmprestimo.Text != "") {
                ListaEmprestimodgv(txtCodigoEmprestimo.Text);
                txtNomeEmprestimo.Text = dgvEmprestimo.Rows[0].Cells[1].Value.ToString();
                dtpEmprestimo.Value = Convert.ToDateTime(dgvEmprestimo.Rows[0].Cells[2].Value.ToString());
                dtpDevolucao.Value = Convert.ToDateTime(dgvEmprestimo.Rows[0].Cells[3].Value.ToString());
                //ListaLivrodgv(txtTituloEmprestimo.Text);

                DataTable dados = biblioteca.ListarEmprestimo(emprestimo, "livro");
                foreach (DataRow linha in dados.Rows)
                {
                    dgvLivro.Rows.Add(linha.ItemArray);
                }
                dgvLivro.ClearSelection();
            }

        }

        private void btnLimparEmprestimo_Click(object sender, EventArgs e)
        {
            txtCodigoEmprestimo.Text = "";
            txtNomeEmprestimo.Text = "";
            dtpEmprestimo.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now;
            dgvLivro.Rows.Clear();
            ListaEmprestimodgv("");
            ListaLivrodgv("");
        }
    }
}
