using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void ListaLivrodgv(string pesquisa)//Lista livros no tabela de livros do form
        {
            livro = new Livro();
            livro.titulo = pesquisa;
            dgvBiblioteca.Rows.Clear();
            DataTable dados = biblioteca.ListarLivros(livro, "titulo");
            foreach (DataRow linha in dados.Rows)
            {
                dgvBiblioteca.Rows.Add(linha.ItemArray);
            }
            dgvBiblioteca.ClearSelection();
        }

        private void ListaEmprestimodgv(string pesquisa)//Lista emprestimos na tabela de emprestimos do form
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
            ofd.FileName = "";
            lblDisponivel.Text = "";
            ListaLivrodgv("");
            ListaEmprestimodgv("");

            //tabEmprestimo.Parent = null;
            //tabEstoque.Parent = null;

        }

        private void dgvBanco_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && tab.SelectedTab.Text == "Biblioteca")
            {
                lblTituloBiblioteca.Text = "Titulo: " + dgvBiblioteca.SelectedRows[0].Cells[1].Value.ToString();
                lblAutorBiblioteca.Text = "Autor: " + dgvBiblioteca.SelectedRows[0].Cells[2].Value.ToString();
                lblEditoraBiblioteca.Text = "Editora: " + dgvBiblioteca.SelectedRows[0].Cells[3].Value.ToString();
                lblPublicadoBiblioteca.Text = "Publicado: " + dgvBiblioteca.SelectedRows[0].Cells[4].Value.ToString();
                lblDescricaoBiblioteca.Text = "Descrição:";
                rtxDescricaoBiblioteca.Visible = true;
                rtxDescricaoBiblioteca.Text = dgvBiblioteca.SelectedRows[0].Cells[6].Value.ToString();
                if (dgvBiblioteca.SelectedRows[0].Cells[7].Value.ToString() != "")
                {
                    pbImagemBiblioteca.Image = new Bitmap(Application.StartupPath + "\\capa\\" + dgvBiblioteca.SelectedRows[0].Cells[7].Value.ToString());
                    pbImagemBiblioteca.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbImagemBiblioteca.Image = null;
                }
                if (int.Parse(dgvBiblioteca.SelectedRows[0].Cells[5].Value.ToString()) > 1)
                {
                    lblDisponivel.Text = "Disponível para empréstimo";
                    lblDisponivel.ForeColor = Color.DarkGreen;
                }
                else
                {
                    lblDisponivel.Text = "Indisponível para empréstimo";
                    lblDisponivel.ForeColor = Color.Red;
                }
                
            }
        }

        private void btnBuscaBiblioteca_Click(object sender, EventArgs e)
        {
            ListaLivrodgv(txtPesquisa.Text);
            if (tab.SelectedTab.Text == "Biblioteca" && txtPesquisa.Text != "")
            {
                lblTituloBiblioteca.Text = "Titulo: " + dgvBiblioteca.Rows[0].Cells[1].Value.ToString();
                lblAutorBiblioteca.Text = "Autor: " + dgvBiblioteca.Rows[0].Cells[2].Value.ToString();
                lblEditoraBiblioteca.Text = "Editora: " + dgvBiblioteca.Rows[0].Cells[3].Value.ToString();
                lblPublicadoBiblioteca.Text = "Publicado: " + dgvBiblioteca.Rows[0].Cells[4].Value.ToString();
                lblDescricaoBiblioteca.Text = "Descrição:";
                rtxDescricaoBiblioteca.Visible = true;
                rtxDescricaoBiblioteca.Text = dgvBiblioteca.Rows[0].Cells[6].Value.ToString();
                pbImagemBiblioteca.Image = new Bitmap(Application.StartupPath + "\\capa\\" + dgvBiblioteca.Rows[0].Cells[7].Value.ToString());
                pbImagemBiblioteca.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnLimparBiblioteca_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            lblTituloBiblioteca.Text = "";
            lblAutorBiblioteca.Text = "";
            lblEditoraBiblioteca.Text = "";
            lblPublicadoBiblioteca.Text = "";
            lblDescricaoBiblioteca.Text = "";
            rtxDescricaoBiblioteca.Visible = false;
            pbImagemBiblioteca.Image = null;
            lblDisponivel.Text = "";
            ListaLivrodgv("");
        }

        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            livro = new Livro(txtTituloEstoque.Text, txtAutorEstoque.Text, txtEditoraEstoque.Text, nudPublicadoEstoque.Value.ToString(),
                nudQuantidadeEstoque.Value.ToString(), rtxDescricaoEstoque.Text, Path.GetFileName(ofd.FileName));
            ofd.FileName = "";
            biblioteca.AdicionarLivro(livro);
            txtTituloEstoque.Text = "";
            txtAutorEstoque.Text = "";
            txtEditoraEstoque.Text = "";
            nudPublicadoEstoque.Value = 0;
            nudQuantidadeEstoque.Value = 0;
            rtxDescricaoEstoque.Text = "";
            pbImagemEstoque.Image = null;
            ListaLivrodgv("");
        }

        private void btnRemoverEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                livro = new Livro();
                livro.id = dgvBiblioteca.SelectedRows[0].Cells[0].Value.ToString();
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
            pbImagemEstoque.Image = null;
            ListaLivrodgv("");
        }

        private void btnAdicionarEmprestimo_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(dgvBiblioteca.SelectedRows[0].Cells[5].Value.ToString()) > 1)
                {
                    livro = new Livro();
                    livro.titulo = dgvBiblioteca.SelectedRows[0].Cells[0].Value.ToString();
                    DataTable dados = biblioteca.ListarLivros(livro, "id");
                    foreach (DataRow linha in dados.Rows)
                    {
                        dgvLivro.Rows.Add(linha.ItemArray);
                    }
                    dgvBiblioteca.ClearSelection();
                }
                else
                {
                     MessageBox.Show("Livro indisponivel para emprestimo!", "Falha no Emprestimo", 0, MessageBoxIcon.Warning);
                }
                
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

                DataTable dados = biblioteca.ListarEmprestimo(emprestimo, "livro");// Lista livros no livros emprestados
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

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            emprestimo = new Emprestimo();
            emprestimo.codigo = txtCodigoEmprestimo.Text;
            biblioteca.DevolverLivro(emprestimo);
            txtCodigoEmprestimo.Text = "";
            txtNomeEmprestimo.Text = "";
            dtpEmprestimo.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now;
            dgvLivro.Rows.Clear();
            ListaEmprestimodgv("");
            ListaLivrodgv("");
        }

        private void btnCapaEstoque_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = "C://Desktop";
            ofd.Title = "Select image to be upload.";
            ofd.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; .png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            ofd.FilterIndex = 1;
            
            try
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (ofd.CheckFileExists)
                    {
                        //string path = Path.GetFullPath(ofd.FileName);
                        string filename = Path.GetFileName(ofd.FileName);
                        string caminho = Application.StartupPath + "\\capa\\" + filename;

                        if (!File.Exists(caminho))
                        {
                            File.Copy(ofd.FileName, caminho);
                        }
                        pbImagemEstoque.Image = new Bitmap(ofd.FileName);
                        pbImagemEstoque.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    //MessageBox.Show("UPLOAD");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
