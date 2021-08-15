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

        private void Form_Load(object sender, EventArgs e)
        {
            ListarLivroBiblioteca("*");

            lblTituloBiblioteca.Text = "";
            lblAutorBiblioteca.Text = "";
            lblEditoraBiblioteca.Text = "";
            lblPublicadoBiblioteca.Text = "";
            lblDescricaoBiblioteca.Text = "";
            rtxDescricaoBiblioteca.Visible = false;
            lblDisponivel.Text = "";

            ofd.FileName = "";

            ListaEmprestimodgv("*");

            //tabBiblioteca.Parent = null;
            //tabEmprestimo.Parent = null;
            //tabEstoque.Parent = null;

        }

        private void ListarLivroBiblioteca(string pesquisa)
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

        private void ListarLivroEmprestimo(string pesquisa)
        {
            emprestimo = new Emprestimo();
            emprestimo.codigo = pesquisa;
            dgvLivro.Rows.Clear();
            //dgvEmprestimo.Rows.Clear();
            DataTable dados = biblioteca.ListarEmprestimo(emprestimo, "livro");
            foreach (DataRow linha in dados.Rows)
            {
                dgvLivro.Rows.Add(linha.ItemArray);
            }
            dgvLivro.ClearSelection();
        }

        private void dgvBanco_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && tab.SelectedTab.Text == "Biblioteca" && dgvBiblioteca.SelectedRows.Count > 0)
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
                    pbImagemBiblioteca.Image = new Bitmap(Application.StartupPath + @"\capa\" + dgvBiblioteca.SelectedRows[0].Cells[7].Value.ToString());
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
            ListarLivroBiblioteca(txtPesquisa.Text);
            if (dgvBiblioteca.Rows.Count > 0 && tab.SelectedTab.Text == "Biblioteca" && txtPesquisa.Text != "")
            {
                lblTituloBiblioteca.Text = "Titulo: " + dgvBiblioteca.Rows[0].Cells[1].Value.ToString();
                lblAutorBiblioteca.Text = "Autor: " + dgvBiblioteca.Rows[0].Cells[2].Value.ToString();
                lblEditoraBiblioteca.Text = "Editora: " + dgvBiblioteca.Rows[0].Cells[3].Value.ToString();
                lblPublicadoBiblioteca.Text = "Publicado: " + dgvBiblioteca.Rows[0].Cells[4].Value.ToString();
                lblDescricaoBiblioteca.Text = "Descrição:";
                rtxDescricaoBiblioteca.Visible = true;
                rtxDescricaoBiblioteca.Text = dgvBiblioteca.Rows[0].Cells[6].Value.ToString();
                pbImagemBiblioteca.Image = new Bitmap(Application.StartupPath + @"\capa\" + dgvBiblioteca.Rows[0].Cells[7].Value.ToString());
                pbImagemBiblioteca.SizeMode = PictureBoxSizeMode.StretchImage;

                if (dgvBiblioteca.Rows[0].Cells[7].Value.ToString() != "")
                {
                    pbImagemBiblioteca.Image = new Bitmap(Application.StartupPath + @"\capa\" + dgvBiblioteca.Rows[0].Cells[7].Value.ToString());
                    pbImagemBiblioteca.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbImagemBiblioteca.Image = null;
                }
                if (int.Parse(dgvBiblioteca.Rows[0].Cells[5].Value.ToString()) > 1)
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
            ListarLivroBiblioteca("*");
        }

        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            livro = new Livro();
            livro.titulo = txtTituloEstoque.Text;
            livro.autor = txtAutorEstoque.Text;
            livro.editora = txtEditoraEstoque.Text;
            livro.publicado = nudPublicadoEstoque.Value.ToString();
            livro.quantidade = nudQuantidadeEstoque.Value.ToString();
            livro.descricao = rtxDescricaoEstoque.Text;
            livro.capa = Path.GetFileName(ofd.FileName);

            if (!Directory.Exists(Application.StartupPath + @"\capa"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\capa");
            }
            if (!File.Exists(Application.StartupPath + @"\capa\" + livro.capa) && livro.capa != "")
            {
                File.Copy(ofd.FileName, Application.StartupPath + @"\capa\" + livro.capa);
            }

            if (biblioteca.AdicionarLivro(livro))
            {
                MessageBox.Show("Livro adicionado com sucesso!", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Livro adicionado com sucesso!", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            txtTituloEstoque.Text = "";
            txtAutorEstoque.Text = "";
            txtEditoraEstoque.Text = "";
            nudPublicadoEstoque.Value = 0;
            nudQuantidadeEstoque.Value = 0;
            rtxDescricaoEstoque.Text = "";
            pbImagemEstoque.Image = null;
            ofd.FileName = "";
            
            ListarLivroBiblioteca("*");
        }

        private void btnRemoverEstoque_Click(object sender, EventArgs e)
        {
            //try
            //{
            livro = new Livro();
            livro.id = dgvBiblioteca.SelectedRows[0].Cells[0].Value.ToString();

            if (dgvBiblioteca.SelectedRows[0].Cells[7].Value.ToString() != "")
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
                File.Delete(Application.StartupPath + @"\capa\" + dgvBiblioteca.SelectedRows[0].Cells[7].Value.ToString());
            }

            biblioteca.RemoverLivro(livro);
            ListarLivroBiblioteca("*");
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine("Erro " + ex.Message);
            //}
        }

        private void btnLimparEstoque_Click(object sender, EventArgs e)
        {
            txtTituloEstoque.Text = "";
            txtAutorEstoque.Text = "";
            txtEditoraEstoque.Text = "";
            nudPublicadoEstoque.Value = 0;
            nudQuantidadeEstoque.Value = 0;
            rtxDescricaoEstoque.Text = "";
            ofd.FileName = "";
            pbImagemEstoque.Image = null;
            ListarLivroBiblioteca("*");
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
                        string caminho = Application.StartupPath + @"\capa\" + filename;

                        pbImagemEstoque.Image = new Bitmap(ofd.FileName);
                        pbImagemEstoque.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("CapaEstoqueClick");
            }
        }

        private void btnAdicionarEmprestimo_Click(object sender, EventArgs e)
        {
            livro = new Livro();
            if (int.Parse(dgvBiblioteca.SelectedRows[0].Cells[5].Value.ToString()) > 1)
            {
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

        private void btnRemoverEmprestimo_Click(object sender, EventArgs e)
        {
            if (dgvLivro.SelectedRows.Count > 0)
            {
                dgvLivro.Rows.RemoveAt(dgvLivro.SelectedRows[0].Index);
                dgvLivro.ClearSelection();
            }
        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            emprestimo = new Emprestimo();
            
            List<string> liv = new List<string>();

            foreach (DataGridViewRow row in dgvLivro.Rows)
            {
                liv.Add(row.Cells[0].Value.ToString());
            }

            string[] livros = liv.ToArray();

            emprestimo.codigo = txtCodigoEmprestimo.Text;
            emprestimo.nomeCompleto =  txtNomeEmprestimo.Text;
            emprestimo.dataEmprestimo = dtpEmprestimo.Value.ToString();
            emprestimo.dataDevolucao = dtpDevolucao.Value.ToString();

            biblioteca.EmprestarLivro(emprestimo, livros);

            ListarLivroBiblioteca("*");

            txtCodigoEmprestimo.Text = "";
            txtNomeEmprestimo.Text = "";
            dtpEmprestimo.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now;
            dgvLivro.Rows.Clear();
            
            ListaEmprestimodgv("*");
        }

        private void btnBuscarEmprestimo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigoEmprestimo.Text, out int n))
            {
                ListaEmprestimodgv(txtCodigoEmprestimo.Text);
                if (dgvEmprestimo.Rows.Count > 0)
                {
                    txtNomeEmprestimo.Text = dgvEmprestimo.Rows[0].Cells[1].Value.ToString();
                    dtpEmprestimo.Value = Convert.ToDateTime(dgvEmprestimo.Rows[0].Cells[2].Value.ToString());
                    dtpDevolucao.Value = Convert.ToDateTime(dgvEmprestimo.Rows[0].Cells[3].Value.ToString());

                    ListarLivroEmprestimo(txtCodigoEmprestimo.Text);
                }
            }
        }

        private void btnLimparEmprestimo_Click(object sender, EventArgs e)
        {
            txtCodigoEmprestimo.Text = "";
            txtNomeEmprestimo.Text = "";
            dtpEmprestimo.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now;
            dgvLivro.Rows.Clear();
            ListaEmprestimodgv("*");
            ListarLivroBiblioteca("*");
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
            ListaEmprestimodgv("*");
            ListarLivroBiblioteca("*");
        }

    }
}
