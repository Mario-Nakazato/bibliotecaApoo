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

        private void Acesso()
        {
            if (txtAcesso.Text == "3264")
            {
                tabEmprestimo.Parent = tab;
                txtAcesso.Visible = false;
                MessageBox.Show("Bem vindo! Atendente.", "Acesso", MessageBoxButtons.OK);
            }
            else if (txtAcesso.Text == "8664")
            {
                tabEmprestimo.Parent = tab;
                tabEstoque.Parent = tab;
                txtAcesso.Visible = false;
                MessageBox.Show("Bem vindo! Bibliotecario.", "Acesso", MessageBoxButtons.OK);
            }
            txtAcesso.Text = "";
        }
        
        private Image GetCopyImage(string path)
        {
            using (Image image = Image.FromFile(path))
            {
                Bitmap bitmap = new Bitmap(image);
                return bitmap;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            txtAcesso.Visible = false;
            lblBemVindo.Text = "Bem Vindo";
            lblMsg.Text = "Selecione um livro da lista";

            ListarLivroBiblioteca("*");

            lblTituloBiblioteca.Text = "";
            lblAutorBiblioteca.Text = "";
            lblEditoraBiblioteca.Text = "";
            lblPublicadoBiblioteca.Text = "";
            lblDescricaoBiblioteca.Text = "";
            rtxDescricaoBiblioteca.Visible = false;
            lblDisponivel.Text = "";

            dtpDevolucao.Value = DateTime.Now.AddDays(14);
            ListaEmprestimodgv("*");

            nudPublicadoEstoque.Value = DateTime.Now.Year;
            ofd.FileName = "";

            //tabBiblioteca.Parent = null;
            tabEmprestimo.Parent = null;
            tabEstoque.Parent = null;
            txtPesquisa.Focus();
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
                txtAcesso.Visible = false;
                lblBemVindo.Text = "";
                lblMsg.Text = "";
                lblTituloBiblioteca.Text = "Titulo: " + dgvBiblioteca.SelectedRows[0].Cells[1].Value.ToString();
                lblAutorBiblioteca.Text = "Autor: " + dgvBiblioteca.SelectedRows[0].Cells[2].Value.ToString();
                lblEditoraBiblioteca.Text = "Editora: " + dgvBiblioteca.SelectedRows[0].Cells[3].Value.ToString();
                lblPublicadoBiblioteca.Text = "Publicado: " + dgvBiblioteca.SelectedRows[0].Cells[4].Value.ToString();
                lblDescricaoBiblioteca.Text = "Descrição:";
                rtxDescricaoBiblioteca.Visible = true;
                rtxDescricaoBiblioteca.Text = dgvBiblioteca.SelectedRows[0].Cells[6].Value.ToString();
                if (dgvBiblioteca.SelectedRows[0].Cells[7].Value.ToString() != "")
                {
                    Image image = GetCopyImage(Application.StartupPath + @"\capa\" + dgvBiblioteca.SelectedRows[0].Cells[7].Value.ToString());
                    pbImagemBiblioteca.Image = image;
                    //pbImagemBiblioteca.Image = new Bitmap(Application.StartupPath + @"\capa\" + dgvBiblioteca.SelectedRows[0].Cells[7].Value.ToString());
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
            txtPesquisa.Focus();
            ListarLivroBiblioteca(txtPesquisa.Text);
            if (dgvBiblioteca.Rows.Count > 0 && tab.SelectedTab.Text == "Biblioteca" && txtPesquisa.Text != "")
            {
                txtAcesso.Visible = false;
                lblBemVindo.Text = "";
                lblMsg.Text = "";
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
            txtAcesso.Visible = false;
            lblBemVindo.Text = "Bem Vindo";
            lblMsg.Text = "Selecione um livro da lista";
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
            txtPesquisa.Focus();
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

            if (txtTituloEstoque.Text == "")
            {
                MessageBox.Show("Livro sem título.", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtAutorEstoque.Text == "")
            {
                MessageBox.Show("Livro sem autor.", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtEditoraEstoque.Text == "")
            {
                MessageBox.Show("Livro sem editora.", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
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
                    MessageBox.Show("Livro adicionado com sucesso.", "Estoque", MessageBoxButtons.OK);
                }
                else//Não é funcional?
                {
                    MessageBox.Show("Ocorreu um erro. Livro não adicionado.", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                txtTituloEstoque.Text = "";
                txtAutorEstoque.Text = "";
                txtEditoraEstoque.Text = "";
                nudPublicadoEstoque.Value = DateTime.Now.Year;
                nudQuantidadeEstoque.Value = 0;
                rtxDescricaoEstoque.Text = "";
                pbImagemEstoque.Image = null;
                ofd.FileName = "";

                ListarLivroBiblioteca("*");
            }
        }

        private void btnRemoverEstoque_Click(object sender, EventArgs e)
        {
            if (dgvBiblioteca.SelectedRows.Count > 0)
            {
                DialogResult btnClicado = MessageBox.Show("Esta ação removerá o livro. Deseja realmente remover o livro?", "Estoque", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (btnClicado == DialogResult.Yes)
                {
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
                }
            }
        }

        private void btnLimparEstoque_Click(object sender, EventArgs e)
        {
            txtTituloEstoque.Text = "";
            txtAutorEstoque.Text = "";
            txtEditoraEstoque.Text = "";
            nudPublicadoEstoque.Value = DateTime.Now.Year;
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
            if (dgvBiblioteca.SelectedRows.Count > 0)
            {
                livro = new Livro();
                if (int.Parse(dgvBiblioteca.SelectedRows[0].Cells[5].Value.ToString()) > 1)
                {

                    dgvBiblioteca.SelectedRows[0].Cells[5].Value = -1;

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
                    MessageBox.Show("Livro indisponivel para emprestimo.", "Emprestimo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
            if (dtpEmprestimo.Value >= dtpDevolucao.Value)
            {
                MessageBox.Show("Datas de emprestimo e devolução incorretas.", "Emprestimo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dgvLivro.Rows.Count <= 0)
            {
                MessageBox.Show("Sem livro(s) para emprestar.", "Emprestimo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(txtCodigoEmprestimo.Text, out int n))
            {
                MessageBox.Show("Código incorreto.", "Emprestimo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                emprestimo = new Emprestimo();

                List<string> liv = new List<string>();

                foreach (DataGridViewRow row in dgvLivro.Rows)
                {
                    liv.Add(row.Cells[0].Value.ToString());
                }

                string[] livros = liv.ToArray();

                emprestimo.codigo = txtCodigoEmprestimo.Text;
                emprestimo.nomeCompleto = txtNomeEmprestimo.Text;
                emprestimo.dataEmprestimo = dtpEmprestimo.Value.ToString();
                emprestimo.dataDevolucao = dtpDevolucao.Value.ToString();

                biblioteca.EmprestarLivro(emprestimo, livros);

                ListarLivroBiblioteca("*");

                txtCodigoEmprestimo.Text = "";
                txtNomeEmprestimo.Text = "";
                dtpEmprestimo.Value = DateTime.Now;
                dtpDevolucao.Value = DateTime.Now.AddDays(14);
                dgvLivro.Rows.Clear();

                ListaEmprestimodgv("*");
                MessageBox.Show("Emprestimo realizado.", "Emprestimo", MessageBoxButtons.OK);
            }
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
                else
                {
                    MessageBox.Show("Nada foi encontrado.", "Emprestimo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoEmprestimo.Text = "";
                    ListaEmprestimodgv("*");
                }
            }
        }

        private void btnLimparEmprestimo_Click(object sender, EventArgs e)
        {
            txtCodigoEmprestimo.Text = "";
            txtNomeEmprestimo.Text = "";
            dtpEmprestimo.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now.AddDays(14);
            dgvLivro.Rows.Clear();
            ListaEmprestimodgv("*");
            ListarLivroEmprestimo("*");
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dtpDevolucao.Value <= DateTime.Now)
            {
                MessageBox.Show("Devolução atrasada.", "Emprestimo", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }

            if (txtCodigoEmprestimo.Text == "")
            {
                MessageBox.Show("Código incorreto.", "Emprestimo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dgvLivro.Rows.Count <= 0)
            {
                MessageBox.Show("Sem livro(s) para devolver.", "Emprestimo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Devolução realizada.", "Emprestimo", MessageBoxButtons.OK);

                emprestimo = new Emprestimo();
                emprestimo.codigo = txtCodigoEmprestimo.Text;

                biblioteca.DevolverLivro(emprestimo);

                txtCodigoEmprestimo.Text = "";
                txtNomeEmprestimo.Text = "";
                dtpEmprestimo.Value = DateTime.Now;
                dtpDevolucao.Value = DateTime.Now.AddDays(biblioteca.prazo);
                dgvLivro.Rows.Clear();
                ListaEmprestimodgv("*");
                ListarLivroBiblioteca("*");
            }
        }

        private void txtAcesso_Click(object sender, EventArgs e)
        {
            Acesso();
        }

        private void txtAcesso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Acesso();
            }
        }

        private void chkAcesso_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAcesso.Checked)
            {
                tabEmprestimo.Parent = null;
                tabEstoque.Parent = null;
                txtAcesso.Visible = false;
            }
            else
            {
                txtAcesso.Visible = true;
                txtAcesso.Focus();
            }
        }

        private void tab_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                dgvBiblioteca.Columns[1].Visible = true;
                dgvBiblioteca.Columns[2].Visible = true;
                dgvBiblioteca.Columns[3].Visible = false;
                dgvBiblioteca.Columns[4].Visible = true;
                dgvBiblioteca.Columns[5].Visible = false;
            }
            else if(e.TabPageIndex == 1)
            {
                dgvBiblioteca.Columns[1].Visible = true;
                dgvBiblioteca.Columns[2].Visible = true;
                dgvBiblioteca.Columns[3].Visible = false;
                dgvBiblioteca.Columns[4].Visible = true;
                dgvBiblioteca.Columns[5].Visible = false;
            }
            else if (e.TabPageIndex == 2)
            {
                dgvBiblioteca.Columns[1].Visible = true;
                dgvBiblioteca.Columns[2].Visible = true;
                dgvBiblioteca.Columns[3].Visible = true;
                dgvBiblioteca.Columns[4].Visible = false;
                dgvBiblioteca.Columns[5].Visible = true;
            }
        }
    }
}
