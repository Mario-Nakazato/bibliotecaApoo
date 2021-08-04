
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
            this.tabp_Atendente = new System.Windows.Forms.TabPage();
            this.lb_PesLivBiblio = new System.Windows.Forms.Label();
            this.txb_Pesquisar = new System.Windows.Forms.TextBox();
            this.bt_Pesquisar = new System.Windows.Forms.Button();
            this.tb_MostrarLivros = new System.Windows.Forms.TableLayoutPanel();
            this.tabp_Bibliotecario = new System.Windows.Forms.TabPage();
            this.tbc_Geral.SuspendLayout();
            this.tabp_Leitor.SuspendLayout();
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
            this.tbc_Geral.Size = new System.Drawing.Size(800, 449);
            this.tbc_Geral.TabIndex = 0;
            // 
            // tabp_Leitor
            // 
            this.tabp_Leitor.Controls.Add(this.tb_MostrarLivros);
            this.tabp_Leitor.Controls.Add(this.bt_Pesquisar);
            this.tabp_Leitor.Controls.Add(this.txb_Pesquisar);
            this.tabp_Leitor.Controls.Add(this.lb_PesLivBiblio);
            this.tabp_Leitor.Location = new System.Drawing.Point(4, 22);
            this.tabp_Leitor.Name = "tabp_Leitor";
            this.tabp_Leitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_Leitor.Size = new System.Drawing.Size(792, 423);
            this.tabp_Leitor.TabIndex = 0;
            this.tabp_Leitor.Text = "Leitor";
            this.tabp_Leitor.UseVisualStyleBackColor = true;
            // 
            // tabp_Atendente
            // 
            this.tabp_Atendente.Location = new System.Drawing.Point(4, 22);
            this.tabp_Atendente.Name = "tabp_Atendente";
            this.tabp_Atendente.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_Atendente.Size = new System.Drawing.Size(792, 423);
            this.tabp_Atendente.TabIndex = 1;
            this.tabp_Atendente.Text = "Atendente";
            this.tabp_Atendente.UseVisualStyleBackColor = true;
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
            // txb_Pesquisar
            // 
            this.txb_Pesquisar.Location = new System.Drawing.Point(31, 54);
            this.txb_Pesquisar.Name = "txb_Pesquisar";
            this.txb_Pesquisar.Size = new System.Drawing.Size(196, 20);
            this.txb_Pesquisar.TabIndex = 1;
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
            // 
            // tb_MostrarLivros
            // 
            this.tb_MostrarLivros.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tb_MostrarLivros.ColumnCount = 2;
            this.tb_MostrarLivros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tb_MostrarLivros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tb_MostrarLivros.Location = new System.Drawing.Point(433, 29);
            this.tb_MostrarLivros.Name = "tb_MostrarLivros";
            this.tb_MostrarLivros.RowCount = 2;
            this.tb_MostrarLivros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tb_MostrarLivros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tb_MostrarLivros.Size = new System.Drawing.Size(331, 368);
            this.tb_MostrarLivros.TabIndex = 3;
            // 
            // tabp_Bibliotecario
            // 
            this.tabp_Bibliotecario.Location = new System.Drawing.Point(4, 22);
            this.tabp_Bibliotecario.Name = "tabp_Bibliotecario";
            this.tabp_Bibliotecario.Size = new System.Drawing.Size(792, 423);
            this.tabp_Bibliotecario.TabIndex = 2;
            this.tabp_Bibliotecario.Text = "Bibliotecario";
            this.tabp_Bibliotecario.UseVisualStyleBackColor = true;
            // 
            // Form_Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbc_Geral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Biblioteca";
            this.Text = "Sistema de Gerenciamento da Biblioteca";
            this.tbc_Geral.ResumeLayout(false);
            this.tabp_Leitor.ResumeLayout(false);
            this.tabp_Leitor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Geral;
        private System.Windows.Forms.TabPage tabp_Leitor;
        private System.Windows.Forms.TableLayoutPanel tb_MostrarLivros;
        private System.Windows.Forms.Button bt_Pesquisar;
        private System.Windows.Forms.TextBox txb_Pesquisar;
        private System.Windows.Forms.Label lb_PesLivBiblio;
        private System.Windows.Forms.TabPage tabp_Atendente;
        private System.Windows.Forms.TabPage tabp_Bibliotecario;
    }
}

