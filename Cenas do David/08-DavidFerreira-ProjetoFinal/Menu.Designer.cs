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
            pnlHeader.Margin = new Padding(33, 38, 33, 38);
            pnlHeader.MinimumSize = new Size(0, 148);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(17, 18, 17, 18);
            pnlHeader.Size = new Size(1711, 148);
            pnlHeader.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(btnSearch);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(611, 18);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(30);
            panel3.Size = new Size(811, 112);
            panel3.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Right;
            txtSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(207, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Pesquise Aqui";
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.Size = new Size(528, 44);
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
            btnSearch.Location = new Point(735, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(46, 52);
            btnSearch.TabIndex = 9;
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1422, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(83, 112);
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
            btnCart.Location = new Point(1505, 18);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(93, 112);
            btnCart.TabIndex = 5;
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
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
            btnAccount.Location = new Point(1598, 18);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(43, 50, 43, 50);
            btnAccount.Size = new Size(96, 112);
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
            lblAppName.Location = new Point(113, 18);
            lblAppName.Name = "lblAppName";
            lblAppName.Padding = new Padding(26, 15, 0, 0);
            lblAppName.Size = new Size(498, 85);
            lblAppName.TabIndex = 4;
            lblAppName.Text = "JOGOS INVICTA";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            lblAppName.Click += lblAppName_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.invictaLogo;
            pictureBox1.Location = new Point(17, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 940);
            panel1.Name = "panel1";
            panel1.Size = new Size(1711, 108);
            panel1.TabIndex = 2;
            // 
            // pnlAccountOptions
            // 
            pnlAccountOptions.Dock = DockStyle.Right;
            pnlAccountOptions.Location = new Point(1577, 148);
            pnlAccountOptions.Name = "pnlAccountOptions";
            pnlAccountOptions.Size = new Size(134, 792);
            pnlAccountOptions.TabIndex = 3;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1711, 1048);
            Controls.Add(pnlAccountOptions);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            IsMdiContainer = true;
            MinimumSize = new Size(1702, 1006);
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

