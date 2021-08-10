
namespace Programa
{
    partial class Form_Biblioteca
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
            this.tbc_Geral = new System.Windows.Forms.TabControl();
            this.tabp_Leitor = new System.Windows.Forms.TabPage();
            this.bt_Pesquisar = new System.Windows.Forms.Button();
            this.txb_Pesquisar = new System.Windows.Forms.TextBox();
            this.lb_PesLivBiblio = new System.Windows.Forms.Label();
            this.tabp_Atendente = new System.Windows.Forms.TabPage();
            this.tabp_Bibliotecario = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesDeEmprestimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesDeLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.tbc_Geral.SuspendLayout();
            this.tabp_Leitor.SuspendLayout();
            this.tabp_Bibliotecario.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_Geral
            // 
            this.tbc_Geral.Controls.Add(this.tabp_Leitor);
            this.tbc_Geral.Controls.Add(this.tabp_Atendente);
            this.tbc_Geral.Controls.Add(this.tabp_Bibliotecario);
            this.tbc_Geral.Location = new System.Drawing.Point(1, 1);
            this.tbc_Geral.Name = "tbc_Geral";
            this.tbc_Geral.SelectedIndex = 0;
            this.tbc_Geral.Size = new System.Drawing.Size(384, 445);
            this.tbc_Geral.TabIndex = 0;
            // 
            // tabp_Leitor
            // 
            this.tabp_Leitor.Controls.Add(this.bt_Pesquisar);
            this.tabp_Leitor.Controls.Add(this.txb_Pesquisar);
            this.tabp_Leitor.Controls.Add(this.lb_PesLivBiblio);
            this.tabp_Leitor.Location = new System.Drawing.Point(4, 22);
            this.tabp_Leitor.Name = "tabp_Leitor";
            this.tabp_Leitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_Leitor.Size = new System.Drawing.Size(376, 423);
            this.tabp_Leitor.TabIndex = 0;
            this.tabp_Leitor.Text = "Leitor";
            this.tabp_Leitor.UseVisualStyleBackColor = true;
            // 
            // bt_Pesquisar
            // 
            this.bt_Pesquisar.BackgroundImage = global::Programa.Properties.Resources.search_icon;
            this.bt_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Pesquisar.Location = new System.Drawing.Point(233, 53);
            this.bt_Pesquisar.Name = "bt_Pesquisar";
            this.bt_Pesquisar.Size = new System.Drawing.Size(22, 21);
            this.bt_Pesquisar.TabIndex = 2;
            this.bt_Pesquisar.UseVisualStyleBackColor = true;
            this.bt_Pesquisar.Click += new System.EventHandler(this.bt_Pesquisar_Click);
            // 
            // txb_Pesquisar
            // 
            this.txb_Pesquisar.Location = new System.Drawing.Point(31, 54);
            this.txb_Pesquisar.Name = "txb_Pesquisar";
            this.txb_Pesquisar.Size = new System.Drawing.Size(196, 20);
            this.txb_Pesquisar.TabIndex = 1;
            // 
            // lb_PesLivBiblio
            // 
            this.lb_PesLivBiblio.AutoSize = true;
            this.lb_PesLivBiblio.Location = new System.Drawing.Point(28, 29);
            this.lb_PesLivBiblio.Name = "lb_PesLivBiblio";
            this.lb_PesLivBiblio.Size = new System.Drawing.Size(146, 13);
            this.lb_PesLivBiblio.TabIndex = 0;
            this.lb_PesLivBiblio.Text = "Pesquisar livros da biblioteca:";
            // 
            // tabp_Atendente
            // 
            this.tabp_Atendente.Location = new System.Drawing.Point(4, 22);
            this.tabp_Atendente.Name = "tabp_Atendente";
            this.tabp_Atendente.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_Atendente.Size = new System.Drawing.Size(376, 423);
            this.tabp_Atendente.TabIndex = 1;
            this.tabp_Atendente.Text = "Atendente";
            this.tabp_Atendente.UseVisualStyleBackColor = true;
            // 
            // tabp_Bibliotecario
            // 
            this.tabp_Bibliotecario.Controls.Add(this.menuStrip1);
            this.tabp_Bibliotecario.Location = new System.Drawing.Point(4, 22);
            this.tabp_Bibliotecario.Name = "tabp_Bibliotecario";
            this.tabp_Bibliotecario.Size = new System.Drawing.Size(376, 419);
            this.tabp_Bibliotecario.TabIndex = 2;
            this.tabp_Bibliotecario.Text = "Bibliotecario";
            this.tabp_Bibliotecario.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesDeEmprestimoToolStripMenuItem,
            this.opçõesDeLivroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(376, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesDeEmprestimoToolStripMenuItem
            // 
            this.opçõesDeEmprestimoToolStripMenuItem.Name = "opçõesDeEmprestimoToolStripMenuItem";
            this.opçõesDeEmprestimoToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.opçõesDeEmprestimoToolStripMenuItem.Text = "Opções de emprestimo";
            // 
            // opçõesDeLivroToolStripMenuItem
            // 
            this.opçõesDeLivroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarLivroToolStripMenuItem,
            this.removerLivroToolStripMenuItem});
            this.opçõesDeLivroToolStripMenuItem.Name = "opçõesDeLivroToolStripMenuItem";
            this.opçõesDeLivroToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.opçõesDeLivroToolStripMenuItem.Text = "Opções de livro";
            // 
            // adicionarLivroToolStripMenuItem
            // 
            this.adicionarLivroToolStripMenuItem.Name = "adicionarLivroToolStripMenuItem";
            this.adicionarLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarLivroToolStripMenuItem.Text = "Adicionar Livro";
            this.adicionarLivroToolStripMenuItem.Click += new System.EventHandler(this.adicionarLivroToolStripMenuItem_Click);
            // 
            // removerLivroToolStripMenuItem
            // 
            this.removerLivroToolStripMenuItem.Name = "removerLivroToolStripMenuItem";
            this.removerLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removerLivroToolStripMenuItem.Text = "Remover Livro";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Location = new System.Drawing.Point(403, 23);
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.Size = new System.Drawing.Size(385, 419);
            this.dataGridViewDados.TabIndex = 4;
            // 
            // Form_Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDados);
            this.Controls.Add(this.tbc_Geral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Biblioteca";
            this.Text = "Sistema de Gerenciamento da Biblioteca";
            this.tbc_Geral.ResumeLayout(false);
            this.tabp_Leitor.ResumeLayout(false);
            this.tabp_Leitor.PerformLayout();
            this.tabp_Bibliotecario.ResumeLayout(false);
            this.tabp_Bibliotecario.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Geral;
        private System.Windows.Forms.TabPage tabp_Leitor;
        private System.Windows.Forms.Button bt_Pesquisar;
        private System.Windows.Forms.TextBox txb_Pesquisar;
        private System.Windows.Forms.Label lb_PesLivBiblio;
        private System.Windows.Forms.TabPage tabp_Atendente;
        private System.Windows.Forms.TabPage tabp_Bibliotecario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesDeEmprestimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesDeLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerLivroToolStripMenuItem;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.DataGridView dataGridViewDados;
    }
}

