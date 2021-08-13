
namespace biblioteca
{
    partial class Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Autor = new System.Windows.Forms.Label();
            this.lbl_Editora = new System.Windows.Forms.Label();
            this.lbl_Publicado = new System.Windows.Forms.Label();
            this.lbl_Quantidade = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_empNome = new System.Windows.Forms.Label();
            this.lbl_empdataEmprestimo = new System.Windows.Forms.Label();
            this.lbl_empDataDevolucao = new System.Windows.Forms.Label();
            this.lbl_empLivros = new System.Windows.Forms.Label();
            this.num_Quantidade = new System.Windows.Forms.NumericUpDown();
            this.num_Publicado = new System.Windows.Forms.NumericUpDown();
            this.txb_Editora = new System.Windows.Forms.TextBox();
            this.txb_Autor = new System.Windows.Forms.TextBox();
            this.txb_Titulo = new System.Windows.Forms.TextBox();
            this.txb_Descricao = new System.Windows.Forms.RichTextBox();
            this.txb_empNome = new System.Windows.Forms.TextBox();
            this.datetime_dataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.datetime_dataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewLivrosEmprestados = new System.Windows.Forms.DataGridView();
            this.bt_EmprestarLivros = new System.Windows.Forms.Button();
            this.bt_AdicionarLivro = new System.Windows.Forms.Button();
            this.lbl_empCodigo = new System.Windows.Forms.Label();
            this.txb_empCodigo = new System.Windows.Forms.TextBox();
            this.bt_DevolverLivros = new System.Windows.Forms.Button();
            this.bt_RemoverLivro = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tbc_Geral = new System.Windows.Forms.TabControl();
            this.tbp_Biblioteca = new System.Windows.Forms.TabPage();
            this.picb_ImagemBusca = new System.Windows.Forms.PictureBox();
            this.txb_DescricaoBusca = new System.Windows.Forms.RichTextBox();
            this.lbl_TituloBusca = new System.Windows.Forms.Label();
            this.lbl_AutorBusca = new System.Windows.Forms.Label();
            this.lbl_EditorBusca = new System.Windows.Forms.Label();
            this.lbl_PublicadoBusca = new System.Windows.Forms.Label();
            this.lbl_DescricaoBusca = new System.Windows.Forms.Label();
            this.bt_LimparBusca = new System.Windows.Forms.Button();
            this.bt_BuscarLivros = new System.Windows.Forms.Button();
            this.tbp_Emprestimos = new System.Windows.Forms.TabPage();
            this.bt_RemoverEmpLivros = new System.Windows.Forms.Button();
            this.bt_AdicionarEmpLivros = new System.Windows.Forms.Button();
            this.bt_BuscarEmprestimos = new System.Windows.Forms.Button();
            this.bt_LimparEmpLivros = new System.Windows.Forms.Button();
            this.tbp_Estoque = new System.Windows.Forms.TabPage();
            this.bt_BuscarLivrosEstoque = new System.Windows.Forms.Button();
            this.bt_LimparLivroEstoque = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Publicado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivrosEmprestados)).BeginInit();
            this.tbc_Geral.SuspendLayout();
            this.tbp_Biblioteca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ImagemBusca)).BeginInit();
            this.tbp_Emprestimos.SuspendLayout();
            this.tbp_Estoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToAddRows = false;
            this.dataGridViewDados.AllowUserToDeleteRows = false;
            this.dataGridViewDados.AllowUserToResizeColumns = false;
            this.dataGridViewDados.AllowUserToResizeRows = false;
            this.dataGridViewDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDados.ColumnHeadersHeight = 30;
            this.dataGridViewDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewDados.Location = new System.Drawing.Point(740, 34);
            this.dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDados.RowHeadersVisible = false;
            this.dataGridViewDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDados.Size = new System.Drawing.Size(512, 635);
            this.dataGridViewDados.TabIndex = 1;
            this.dataGridViewDados.UseWaitCursor = true;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(170, 152);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(33, 13);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Titulo";
            // 
            // lbl_Autor
            // 
            this.lbl_Autor.AutoSize = true;
            this.lbl_Autor.Location = new System.Drawing.Point(170, 178);
            this.lbl_Autor.Name = "lbl_Autor";
            this.lbl_Autor.Size = new System.Drawing.Size(32, 13);
            this.lbl_Autor.TabIndex = 3;
            this.lbl_Autor.Text = "Autor";
            // 
            // lbl_Editora
            // 
            this.lbl_Editora.AutoSize = true;
            this.lbl_Editora.Location = new System.Drawing.Point(170, 204);
            this.lbl_Editora.Name = "lbl_Editora";
            this.lbl_Editora.Size = new System.Drawing.Size(40, 13);
            this.lbl_Editora.TabIndex = 4;
            this.lbl_Editora.Text = "Editora";
            // 
            // lbl_Publicado
            // 
            this.lbl_Publicado.AutoSize = true;
            this.lbl_Publicado.Location = new System.Drawing.Point(170, 229);
            this.lbl_Publicado.Name = "lbl_Publicado";
            this.lbl_Publicado.Size = new System.Drawing.Size(54, 13);
            this.lbl_Publicado.TabIndex = 5;
            this.lbl_Publicado.Text = "Publicado";
            // 
            // lbl_Quantidade
            // 
            this.lbl_Quantidade.AutoSize = true;
            this.lbl_Quantidade.Location = new System.Drawing.Point(324, 229);
            this.lbl_Quantidade.Name = "lbl_Quantidade";
            this.lbl_Quantidade.Size = new System.Drawing.Size(62, 13);
            this.lbl_Quantidade.TabIndex = 6;
            this.lbl_Quantidade.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Descrição";
            // 
            // lbl_empNome
            // 
            this.lbl_empNome.AutoSize = true;
            this.lbl_empNome.Location = new System.Drawing.Point(170, 183);
            this.lbl_empNome.Name = "lbl_empNome";
            this.lbl_empNome.Size = new System.Drawing.Size(35, 13);
            this.lbl_empNome.TabIndex = 8;
            this.lbl_empNome.Text = "Nome";
            // 
            // lbl_empdataEmprestimo
            // 
            this.lbl_empdataEmprestimo.AutoSize = true;
            this.lbl_empdataEmprestimo.Location = new System.Drawing.Point(170, 209);
            this.lbl_empdataEmprestimo.Name = "lbl_empdataEmprestimo";
            this.lbl_empdataEmprestimo.Size = new System.Drawing.Size(101, 13);
            this.lbl_empdataEmprestimo.TabIndex = 9;
            this.lbl_empdataEmprestimo.Text = "Data do emprestimo";
            // 
            // lbl_empDataDevolucao
            // 
            this.lbl_empDataDevolucao.AutoSize = true;
            this.lbl_empDataDevolucao.Location = new System.Drawing.Point(170, 235);
            this.lbl_empDataDevolucao.Name = "lbl_empDataDevolucao";
            this.lbl_empDataDevolucao.Size = new System.Drawing.Size(100, 13);
            this.lbl_empDataDevolucao.TabIndex = 10;
            this.lbl_empDataDevolucao.Text = "Data da Devolução";
            // 
            // lbl_empLivros
            // 
            this.lbl_empLivros.AutoSize = true;
            this.lbl_empLivros.Location = new System.Drawing.Point(170, 262);
            this.lbl_empLivros.Name = "lbl_empLivros";
            this.lbl_empLivros.Size = new System.Drawing.Size(35, 13);
            this.lbl_empLivros.TabIndex = 11;
            this.lbl_empLivros.Text = "Livros";
            // 
            // num_Quantidade
            // 
            this.num_Quantidade.Location = new System.Drawing.Point(392, 227);
            this.num_Quantidade.Name = "num_Quantidade";
            this.num_Quantidade.Size = new System.Drawing.Size(56, 20);
            this.num_Quantidade.TabIndex = 12;
            // 
            // num_Publicado
            // 
            this.num_Publicado.Location = new System.Drawing.Point(238, 227);
            this.num_Publicado.Name = "num_Publicado";
            this.num_Publicado.Size = new System.Drawing.Size(56, 20);
            this.num_Publicado.TabIndex = 13;
            // 
            // txb_Editora
            // 
            this.txb_Editora.Location = new System.Drawing.Point(238, 201);
            this.txb_Editora.Name = "txb_Editora";
            this.txb_Editora.Size = new System.Drawing.Size(210, 20);
            this.txb_Editora.TabIndex = 14;
            // 
            // txb_Autor
            // 
            this.txb_Autor.Location = new System.Drawing.Point(238, 175);
            this.txb_Autor.Name = "txb_Autor";
            this.txb_Autor.Size = new System.Drawing.Size(210, 20);
            this.txb_Autor.TabIndex = 15;
            // 
            // txb_Titulo
            // 
            this.txb_Titulo.Location = new System.Drawing.Point(238, 149);
            this.txb_Titulo.Name = "txb_Titulo";
            this.txb_Titulo.Size = new System.Drawing.Size(210, 20);
            this.txb_Titulo.TabIndex = 16;
            // 
            // txb_Descricao
            // 
            this.txb_Descricao.Location = new System.Drawing.Point(173, 273);
            this.txb_Descricao.Name = "txb_Descricao";
            this.txb_Descricao.Size = new System.Drawing.Size(356, 165);
            this.txb_Descricao.TabIndex = 17;
            this.txb_Descricao.Text = "";
            // 
            // txb_empNome
            // 
            this.txb_empNome.Location = new System.Drawing.Point(277, 180);
            this.txb_empNome.Name = "txb_empNome";
            this.txb_empNome.Size = new System.Drawing.Size(210, 20);
            this.txb_empNome.TabIndex = 18;
            // 
            // datetime_dataEmprestimo
            // 
            this.datetime_dataEmprestimo.Location = new System.Drawing.Point(277, 206);
            this.datetime_dataEmprestimo.Name = "datetime_dataEmprestimo";
            this.datetime_dataEmprestimo.Size = new System.Drawing.Size(210, 20);
            this.datetime_dataEmprestimo.TabIndex = 19;
            // 
            // datetime_dataDevolucao
            // 
            this.datetime_dataDevolucao.Location = new System.Drawing.Point(277, 235);
            this.datetime_dataDevolucao.Name = "datetime_dataDevolucao";
            this.datetime_dataDevolucao.Size = new System.Drawing.Size(211, 20);
            this.datetime_dataDevolucao.TabIndex = 20;
            // 
            // dataGridViewLivrosEmprestados
            // 
            this.dataGridViewLivrosEmprestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivrosEmprestados.Location = new System.Drawing.Point(173, 278);
            this.dataGridViewLivrosEmprestados.Name = "dataGridViewLivrosEmprestados";
            this.dataGridViewLivrosEmprestados.Size = new System.Drawing.Size(314, 165);
            this.dataGridViewLivrosEmprestados.TabIndex = 21;
            // 
            // bt_EmprestarLivros
            // 
            this.bt_EmprestarLivros.Location = new System.Drawing.Point(412, 449);
            this.bt_EmprestarLivros.Name = "bt_EmprestarLivros";
            this.bt_EmprestarLivros.Size = new System.Drawing.Size(75, 23);
            this.bt_EmprestarLivros.TabIndex = 22;
            this.bt_EmprestarLivros.Text = "Emprestar";
            this.bt_EmprestarLivros.UseVisualStyleBackColor = true;
            // 
            // bt_AdicionarLivro
            // 
            this.bt_AdicionarLivro.Location = new System.Drawing.Point(454, 444);
            this.bt_AdicionarLivro.Name = "bt_AdicionarLivro";
            this.bt_AdicionarLivro.Size = new System.Drawing.Size(75, 23);
            this.bt_AdicionarLivro.TabIndex = 23;
            this.bt_AdicionarLivro.Text = "Adicionar";
            this.bt_AdicionarLivro.UseVisualStyleBackColor = true;
            // 
            // lbl_empCodigo
            // 
            this.lbl_empCodigo.AutoSize = true;
            this.lbl_empCodigo.Location = new System.Drawing.Point(170, 157);
            this.lbl_empCodigo.Name = "lbl_empCodigo";
            this.lbl_empCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbl_empCodigo.TabIndex = 24;
            this.lbl_empCodigo.Text = "Codigo";
            // 
            // txb_empCodigo
            // 
            this.txb_empCodigo.Location = new System.Drawing.Point(277, 154);
            this.txb_empCodigo.Name = "txb_empCodigo";
            this.txb_empCodigo.Size = new System.Drawing.Size(210, 20);
            this.txb_empCodigo.TabIndex = 25;
            // 
            // bt_DevolverLivros
            // 
            this.bt_DevolverLivros.Location = new System.Drawing.Point(331, 449);
            this.bt_DevolverLivros.Name = "bt_DevolverLivros";
            this.bt_DevolverLivros.Size = new System.Drawing.Size(75, 23);
            this.bt_DevolverLivros.TabIndex = 26;
            this.bt_DevolverLivros.Text = "Devolver";
            this.bt_DevolverLivros.UseVisualStyleBackColor = true;
            // 
            // bt_RemoverLivro
            // 
            this.bt_RemoverLivro.Location = new System.Drawing.Point(373, 444);
            this.bt_RemoverLivro.Name = "bt_RemoverLivro";
            this.bt_RemoverLivro.Size = new System.Drawing.Size(75, 23);
            this.bt_RemoverLivro.TabIndex = 27;
            this.bt_RemoverLivro.Text = "Remover";
            this.bt_RemoverLivro.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(258, 96);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(210, 20);
            this.textBox6.TabIndex = 28;
            // 
            // tbc_Geral
            // 
            this.tbc_Geral.Controls.Add(this.tbp_Biblioteca);
            this.tbc_Geral.Controls.Add(this.tbp_Emprestimos);
            this.tbc_Geral.Controls.Add(this.tbp_Estoque);
            this.tbc_Geral.Location = new System.Drawing.Point(12, 12);
            this.tbc_Geral.Name = "tbc_Geral";
            this.tbc_Geral.SelectedIndex = 0;
            this.tbc_Geral.Size = new System.Drawing.Size(726, 657);
            this.tbc_Geral.TabIndex = 30;
            // 
            // tbp_Biblioteca
            // 
            this.tbp_Biblioteca.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbp_Biblioteca.Controls.Add(this.picb_ImagemBusca);
            this.tbp_Biblioteca.Controls.Add(this.txb_DescricaoBusca);
            this.tbp_Biblioteca.Controls.Add(this.lbl_TituloBusca);
            this.tbp_Biblioteca.Controls.Add(this.lbl_AutorBusca);
            this.tbp_Biblioteca.Controls.Add(this.lbl_EditorBusca);
            this.tbp_Biblioteca.Controls.Add(this.lbl_PublicadoBusca);
            this.tbp_Biblioteca.Controls.Add(this.lbl_DescricaoBusca);
            this.tbp_Biblioteca.Controls.Add(this.bt_LimparBusca);
            this.tbp_Biblioteca.Controls.Add(this.bt_BuscarLivros);
            this.tbp_Biblioteca.Controls.Add(this.textBox6);
            this.tbp_Biblioteca.Location = new System.Drawing.Point(4, 22);
            this.tbp_Biblioteca.Name = "tbp_Biblioteca";
            this.tbp_Biblioteca.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Biblioteca.Size = new System.Drawing.Size(718, 631);
            this.tbp_Biblioteca.TabIndex = 0;
            this.tbp_Biblioteca.Text = "Biblioteca";
            // 
            // picb_ImagemBusca
            // 
            this.picb_ImagemBusca.Image = global::biblioteca.Properties.Resources.CapaLivroLua;
            this.picb_ImagemBusca.Location = new System.Drawing.Point(470, 246);
            this.picb_ImagemBusca.Name = "picb_ImagemBusca";
            this.picb_ImagemBusca.Size = new System.Drawing.Size(183, 261);
            this.picb_ImagemBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb_ImagemBusca.TabIndex = 58;
            this.picb_ImagemBusca.TabStop = false;
            // 
            // txb_DescricaoBusca
            // 
            this.txb_DescricaoBusca.Location = new System.Drawing.Point(49, 352);
            this.txb_DescricaoBusca.Name = "txb_DescricaoBusca";
            this.txb_DescricaoBusca.Size = new System.Drawing.Size(356, 165);
            this.txb_DescricaoBusca.TabIndex = 57;
            this.txb_DescricaoBusca.Text = "";
            // 
            // lbl_TituloBusca
            // 
            this.lbl_TituloBusca.AutoSize = true;
            this.lbl_TituloBusca.Location = new System.Drawing.Point(46, 231);
            this.lbl_TituloBusca.Name = "lbl_TituloBusca";
            this.lbl_TituloBusca.Size = new System.Drawing.Size(33, 13);
            this.lbl_TituloBusca.TabIndex = 46;
            this.lbl_TituloBusca.Text = "Titulo";
            // 
            // lbl_AutorBusca
            // 
            this.lbl_AutorBusca.AutoSize = true;
            this.lbl_AutorBusca.Location = new System.Drawing.Point(46, 257);
            this.lbl_AutorBusca.Name = "lbl_AutorBusca";
            this.lbl_AutorBusca.Size = new System.Drawing.Size(32, 13);
            this.lbl_AutorBusca.TabIndex = 47;
            this.lbl_AutorBusca.Text = "Autor";
            // 
            // lbl_EditorBusca
            // 
            this.lbl_EditorBusca.AutoSize = true;
            this.lbl_EditorBusca.Location = new System.Drawing.Point(46, 283);
            this.lbl_EditorBusca.Name = "lbl_EditorBusca";
            this.lbl_EditorBusca.Size = new System.Drawing.Size(40, 13);
            this.lbl_EditorBusca.TabIndex = 48;
            this.lbl_EditorBusca.Text = "Editora";
            // 
            // lbl_PublicadoBusca
            // 
            this.lbl_PublicadoBusca.AutoSize = true;
            this.lbl_PublicadoBusca.Location = new System.Drawing.Point(46, 308);
            this.lbl_PublicadoBusca.Name = "lbl_PublicadoBusca";
            this.lbl_PublicadoBusca.Size = new System.Drawing.Size(54, 13);
            this.lbl_PublicadoBusca.TabIndex = 49;
            this.lbl_PublicadoBusca.Text = "Publicado";
            // 
            // lbl_DescricaoBusca
            // 
            this.lbl_DescricaoBusca.AutoSize = true;
            this.lbl_DescricaoBusca.Location = new System.Drawing.Point(46, 336);
            this.lbl_DescricaoBusca.Name = "lbl_DescricaoBusca";
            this.lbl_DescricaoBusca.Size = new System.Drawing.Size(55, 13);
            this.lbl_DescricaoBusca.TabIndex = 51;
            this.lbl_DescricaoBusca.Text = "Descrição";
            // 
            // bt_LimparBusca
            // 
            this.bt_LimparBusca.Location = new System.Drawing.Point(367, 122);
            this.bt_LimparBusca.Name = "bt_LimparBusca";
            this.bt_LimparBusca.Size = new System.Drawing.Size(75, 23);
            this.bt_LimparBusca.TabIndex = 45;
            this.bt_LimparBusca.Text = "Limpar";
            this.bt_LimparBusca.UseVisualStyleBackColor = true;
            // 
            // bt_BuscarLivros
            // 
            this.bt_BuscarLivros.Location = new System.Drawing.Point(286, 122);
            this.bt_BuscarLivros.Name = "bt_BuscarLivros";
            this.bt_BuscarLivros.Size = new System.Drawing.Size(75, 23);
            this.bt_BuscarLivros.TabIndex = 30;
            this.bt_BuscarLivros.Text = "Buscar";
            this.bt_BuscarLivros.UseVisualStyleBackColor = true;
            // 
            // tbp_Emprestimos
            // 
            this.tbp_Emprestimos.Controls.Add(this.bt_RemoverEmpLivros);
            this.tbp_Emprestimos.Controls.Add(this.bt_AdicionarEmpLivros);
            this.tbp_Emprestimos.Controls.Add(this.bt_BuscarEmprestimos);
            this.tbp_Emprestimos.Controls.Add(this.bt_LimparEmpLivros);
            this.tbp_Emprestimos.Controls.Add(this.dataGridViewLivrosEmprestados);
            this.tbp_Emprestimos.Controls.Add(this.bt_DevolverLivros);
            this.tbp_Emprestimos.Controls.Add(this.lbl_empNome);
            this.tbp_Emprestimos.Controls.Add(this.txb_empCodigo);
            this.tbp_Emprestimos.Controls.Add(this.lbl_empdataEmprestimo);
            this.tbp_Emprestimos.Controls.Add(this.lbl_empCodigo);
            this.tbp_Emprestimos.Controls.Add(this.lbl_empDataDevolucao);
            this.tbp_Emprestimos.Controls.Add(this.bt_EmprestarLivros);
            this.tbp_Emprestimos.Controls.Add(this.lbl_empLivros);
            this.tbp_Emprestimos.Controls.Add(this.txb_empNome);
            this.tbp_Emprestimos.Controls.Add(this.datetime_dataDevolucao);
            this.tbp_Emprestimos.Controls.Add(this.datetime_dataEmprestimo);
            this.tbp_Emprestimos.Location = new System.Drawing.Point(4, 22);
            this.tbp_Emprestimos.Name = "tbp_Emprestimos";
            this.tbp_Emprestimos.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Emprestimos.Size = new System.Drawing.Size(718, 631);
            this.tbp_Emprestimos.TabIndex = 1;
            this.tbp_Emprestimos.Text = "Emprestimos";
            this.tbp_Emprestimos.UseVisualStyleBackColor = true;
            // 
            // bt_RemoverEmpLivros
            // 
            this.bt_RemoverEmpLivros.Location = new System.Drawing.Point(493, 307);
            this.bt_RemoverEmpLivros.Name = "bt_RemoverEmpLivros";
            this.bt_RemoverEmpLivros.Size = new System.Drawing.Size(75, 23);
            this.bt_RemoverEmpLivros.TabIndex = 30;
            this.bt_RemoverEmpLivros.Text = "Remover";
            this.bt_RemoverEmpLivros.UseVisualStyleBackColor = true;
            // 
            // bt_AdicionarEmpLivros
            // 
            this.bt_AdicionarEmpLivros.Location = new System.Drawing.Point(493, 278);
            this.bt_AdicionarEmpLivros.Name = "bt_AdicionarEmpLivros";
            this.bt_AdicionarEmpLivros.Size = new System.Drawing.Size(75, 23);
            this.bt_AdicionarEmpLivros.TabIndex = 29;
            this.bt_AdicionarEmpLivros.Text = "Adicionar";
            this.bt_AdicionarEmpLivros.UseVisualStyleBackColor = true;
            // 
            // bt_BuscarEmprestimos
            // 
            this.bt_BuscarEmprestimos.Location = new System.Drawing.Point(493, 152);
            this.bt_BuscarEmprestimos.Name = "bt_BuscarEmprestimos";
            this.bt_BuscarEmprestimos.Size = new System.Drawing.Size(75, 23);
            this.bt_BuscarEmprestimos.TabIndex = 28;
            this.bt_BuscarEmprestimos.Text = "Buscar";
            this.bt_BuscarEmprestimos.UseVisualStyleBackColor = true;
            // 
            // bt_LimparEmpLivros
            // 
            this.bt_LimparEmpLivros.Location = new System.Drawing.Point(173, 449);
            this.bt_LimparEmpLivros.Name = "bt_LimparEmpLivros";
            this.bt_LimparEmpLivros.Size = new System.Drawing.Size(75, 23);
            this.bt_LimparEmpLivros.TabIndex = 27;
            this.bt_LimparEmpLivros.Text = "Limpar";
            this.bt_LimparEmpLivros.UseVisualStyleBackColor = true;
            // 
            // tbp_Estoque
            // 
            this.tbp_Estoque.Controls.Add(this.bt_BuscarLivrosEstoque);
            this.tbp_Estoque.Controls.Add(this.bt_LimparLivroEstoque);
            this.tbp_Estoque.Controls.Add(this.txb_Descricao);
            this.tbp_Estoque.Controls.Add(this.bt_RemoverLivro);
            this.tbp_Estoque.Controls.Add(this.lbl_Titulo);
            this.tbp_Estoque.Controls.Add(this.lbl_Autor);
            this.tbp_Estoque.Controls.Add(this.lbl_Editora);
            this.tbp_Estoque.Controls.Add(this.lbl_Publicado);
            this.tbp_Estoque.Controls.Add(this.bt_AdicionarLivro);
            this.tbp_Estoque.Controls.Add(this.lbl_Quantidade);
            this.tbp_Estoque.Controls.Add(this.label6);
            this.tbp_Estoque.Controls.Add(this.num_Quantidade);
            this.tbp_Estoque.Controls.Add(this.num_Publicado);
            this.tbp_Estoque.Controls.Add(this.txb_Editora);
            this.tbp_Estoque.Controls.Add(this.txb_Autor);
            this.tbp_Estoque.Controls.Add(this.txb_Titulo);
            this.tbp_Estoque.Location = new System.Drawing.Point(4, 22);
            this.tbp_Estoque.Name = "tbp_Estoque";
            this.tbp_Estoque.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Estoque.Size = new System.Drawing.Size(718, 631);
            this.tbp_Estoque.TabIndex = 2;
            this.tbp_Estoque.Text = "Estoque";
            this.tbp_Estoque.UseVisualStyleBackColor = true;
            // 
            // bt_BuscarLivrosEstoque
            // 
            this.bt_BuscarLivrosEstoque.Location = new System.Drawing.Point(454, 147);
            this.bt_BuscarLivrosEstoque.Name = "bt_BuscarLivrosEstoque";
            this.bt_BuscarLivrosEstoque.Size = new System.Drawing.Size(75, 23);
            this.bt_BuscarLivrosEstoque.TabIndex = 31;
            this.bt_BuscarLivrosEstoque.Text = "Buscar";
            this.bt_BuscarLivrosEstoque.UseVisualStyleBackColor = true;
            // 
            // bt_LimparLivroEstoque
            // 
            this.bt_LimparLivroEstoque.Location = new System.Drawing.Point(173, 444);
            this.bt_LimparLivroEstoque.Name = "bt_LimparLivroEstoque";
            this.bt_LimparLivroEstoque.Size = new System.Drawing.Size(75, 23);
            this.bt_LimparLivroEstoque.TabIndex = 28;
            this.bt_LimparLivroEstoque.Text = "Limpar";
            this.bt_LimparLivroEstoque.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "Título";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 40F;
            this.Column2.HeaderText = "Autor";
            this.Column2.Name = "Column2";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tbc_Geral);
            this.Controls.Add(this.dataGridViewDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Publicado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivrosEmprestados)).EndInit();
            this.tbc_Geral.ResumeLayout(false);
            this.tbp_Biblioteca.ResumeLayout(false);
            this.tbp_Biblioteca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ImagemBusca)).EndInit();
            this.tbp_Emprestimos.ResumeLayout(false);
            this.tbp_Emprestimos.PerformLayout();
            this.tbp_Estoque.ResumeLayout(false);
            this.tbp_Estoque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDados;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Autor;
        private System.Windows.Forms.Label lbl_Editora;
        private System.Windows.Forms.Label lbl_Publicado;
        private System.Windows.Forms.Label lbl_Quantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_empNome;
        private System.Windows.Forms.Label lbl_empdataEmprestimo;
        private System.Windows.Forms.Label lbl_empDataDevolucao;
        private System.Windows.Forms.Label lbl_empLivros;
        private System.Windows.Forms.NumericUpDown num_Quantidade;
        private System.Windows.Forms.NumericUpDown num_Publicado;
        private System.Windows.Forms.TextBox txb_Editora;
        private System.Windows.Forms.TextBox txb_Autor;
        private System.Windows.Forms.TextBox txb_Titulo;
        private System.Windows.Forms.RichTextBox txb_Descricao;
        private System.Windows.Forms.TextBox txb_empNome;
        private System.Windows.Forms.DateTimePicker datetime_dataEmprestimo;
        private System.Windows.Forms.DateTimePicker datetime_dataDevolucao;
        private System.Windows.Forms.DataGridView dataGridViewLivrosEmprestados;
        private System.Windows.Forms.Button bt_EmprestarLivros;
        private System.Windows.Forms.Button bt_AdicionarLivro;
        private System.Windows.Forms.Label lbl_empCodigo;
        private System.Windows.Forms.TextBox txb_empCodigo;
        private System.Windows.Forms.Button bt_DevolverLivros;
        private System.Windows.Forms.Button bt_RemoverLivro;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TabControl tbc_Geral;
        private System.Windows.Forms.TabPage tbp_Biblioteca;
        private System.Windows.Forms.TabPage tbp_Emprestimos;
        private System.Windows.Forms.Button bt_BuscarLivros;
        private System.Windows.Forms.TabPage tbp_Estoque;
        private System.Windows.Forms.Button bt_LimparBusca;
        private System.Windows.Forms.Button bt_LimparEmpLivros;
        private System.Windows.Forms.Button bt_LimparLivroEstoque;
        private System.Windows.Forms.Button bt_RemoverEmpLivros;
        private System.Windows.Forms.Button bt_AdicionarEmpLivros;
        private System.Windows.Forms.Button bt_BuscarEmprestimos;
        private System.Windows.Forms.Button bt_BuscarLivrosEstoque;
        private System.Windows.Forms.RichTextBox txb_DescricaoBusca;
        private System.Windows.Forms.Label lbl_TituloBusca;
        private System.Windows.Forms.Label lbl_AutorBusca;
        private System.Windows.Forms.Label lbl_EditorBusca;
        private System.Windows.Forms.Label lbl_PublicadoBusca;
        private System.Windows.Forms.Label lbl_DescricaoBusca;
        private System.Windows.Forms.PictureBox picb_ImagemBusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

