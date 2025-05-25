namespace _11ITM_DavidF_JogosInvicta
{
    partial class Menu
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
            pnlHeader = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnSearch);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Controls.Add(bigLabel1);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(33, 38, 33, 38);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(17, 19, 17, 19);
            pnlHeader.Size = new Size(1531, 190);
            pnlHeader.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left;
            btnSearch.BackColor = Color.FromArgb(33, 101, 227);
            btnSearch.BackgroundImage = _08_DavidFerreira_ProjetoFinal.Properties.Resources.searchLogo;
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = SystemColors.ControlText;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(1287, 72);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(53, 53);
            btnSearch.TabIndex = 3;
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left;
            txtSearch.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(897, 72);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Pesquise Aqui";
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.Size = new Size(394, 53);
            txtSearch.TabIndex = 2;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Dock = DockStyle.Left;
            bigLabel1.Font = new Font("Arial", 25F);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(153, 19);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Padding = new Padding(22, 38, 22, 25);
            bigLabel1.Size = new Size(451, 120);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "JOGOS INVICTA";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = _08_DavidFerreira_ProjetoFinal.Properties.Resources.invictaLogo;
            pictureBox1.Location = new Point(17, 19);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 1196);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1553, 1236);
            Name = "Menu";
            Text = "Form1";
            Load += Menu_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

