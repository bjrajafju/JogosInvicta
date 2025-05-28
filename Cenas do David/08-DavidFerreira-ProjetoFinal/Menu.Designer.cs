namespace _08_DavidFerreira_ProjetoFinal
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
            panel3 = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panel2 = new Panel();
            btnCart = new Button();
            btnAccount = new Button();
            lblAppName = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pnlAccountOptions = new Panel();
            pnlHeader.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.MidnightBlue;
            pnlHeader.Controls.Add(panel3);
            pnlHeader.Controls.Add(panel2);
            pnlHeader.Controls.Add(btnCart);
            pnlHeader.Controls.Add(btnAccount);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(23);
            pnlHeader.MinimumSize = new Size(0, 89);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(12, 11, 12, 11);
            pnlHeader.Size = new Size(1198, 89);
            pnlHeader.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(btnSearch);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(415, 11);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(21, 18, 21, 18);
            panel3.Size = new Size(581, 67);
            panel3.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Right;
            txtSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(157, 18);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Pesquise Aqui";
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.Size = new Size(371, 32);
            txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(33, 101, 227);
            btnSearch.BackgroundImage = Properties.Resources.searchLogo;
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.Dock = DockStyle.Right;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = SystemColors.ControlText;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(528, 18);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(32, 31);
            btnSearch.TabIndex = 9;
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(996, 11);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(58, 67);
            panel2.TabIndex = 6;
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.Transparent;
            btnCart.BackgroundImage = Properties.Resources.cartLogo;
            btnCart.BackgroundImageLayout = ImageLayout.Stretch;
            btnCart.Dock = DockStyle.Right;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.ForeColor = Color.Transparent;
            btnCart.Location = new Point(1054, 11);
            btnCart.Margin = new Padding(2);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(65, 67);
            btnCart.TabIndex = 5;
            btnCart.UseVisualStyleBackColor = false;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.Transparent;
            btnAccount.BackgroundImage = Properties.Resources.accountLogo;
            btnAccount.BackgroundImageLayout = ImageLayout.Stretch;
            btnAccount.Dock = DockStyle.Right;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.ForeColor = Color.Transparent;
            btnAccount.Location = new Point(1119, 11);
            btnAccount.Margin = new Padding(2);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(30);
            btnAccount.Size = new Size(67, 67);
            btnAccount.TabIndex = 1;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Dock = DockStyle.Left;
            lblAppName.Font = new Font("Arial Black", 25F);
            lblAppName.ForeColor = SystemColors.ButtonFace;
            lblAppName.Location = new Point(79, 11);
            lblAppName.Margin = new Padding(2, 0, 2, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Padding = new Padding(18, 9, 0, 0);
            lblAppName.Size = new Size(336, 57);
            lblAppName.TabIndex = 4;
            lblAppName.Text = "JOGOS INVICTA";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            lblAppName.Click += lblAppName_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.invictaLogo;
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 564);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 65);
            panel1.TabIndex = 2;
            // 
            // pnlAccountOptions
            // 
            pnlAccountOptions.Dock = DockStyle.Right;
            pnlAccountOptions.Location = new Point(1104, 89);
            pnlAccountOptions.Margin = new Padding(2);
            pnlAccountOptions.Name = "pnlAccountOptions";
            pnlAccountOptions.Size = new Size(94, 475);
            pnlAccountOptions.TabIndex = 3;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1198, 629);
            Controls.Add(pnlAccountOptions);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            IsMdiContainer = true;
            Margin = new Padding(2);
            MinimumSize = new Size(1198, 626);
            Name = "Menu";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JOGOS INVICTA";
            Load += Menu_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Label lblAppName;
        private Button btnAccount;
        private Panel panel3;
        private Button btnSearch;
        private Panel panel2;
        private Button btnCart;
        private TextBox txtSearch;
        private Panel panel1;
        private Panel pnlAccountOptions;
    }
}

