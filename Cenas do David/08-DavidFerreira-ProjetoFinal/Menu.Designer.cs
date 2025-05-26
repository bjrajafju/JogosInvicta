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
            fpnlAccountOptions = new FlowLayoutPanel();
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
            pnlHeader.Size = new Size(1537, 148);
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
            panel3.Size = new Size(637, 112);
            panel3.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Right;
            txtSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(33, 30);
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
            btnSearch.Location = new Point(561, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(46, 52);
            btnSearch.TabIndex = 9;
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1248, 18);
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
            btnCart.Location = new Point(1331, 18);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(93, 112);
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
            btnAccount.Location = new Point(1424, 18);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(43, 50, 43, 50);
            btnAccount.Size = new Size(96, 112);
            btnAccount.TabIndex = 1;
            btnAccount.UseVisualStyleBackColor = false;
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
            panel1.Location = new Point(0, 994);
            panel1.Name = "panel1";
            panel1.Size = new Size(1537, 150);
            panel1.TabIndex = 1;
            // 
            // fpnlAccountOptions
            // 
            fpnlAccountOptions.Dock = DockStyle.Right;
            fpnlAccountOptions.Location = new Point(1537, 148);
            fpnlAccountOptions.Margin = new Padding(4, 5, 4, 5);
            fpnlAccountOptions.Name = "fpnlAccountOptions";
            fpnlAccountOptions.Padding = new Padding(0, 0, 0, 83);
            fpnlAccountOptions.Size = new Size(0, 846);
            fpnlAccountOptions.TabIndex = 2;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1537, 1144);
            Controls.Add(fpnlAccountOptions);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            IsMdiContainer = true;
            MinimumSize = new Size(1548, 1200);
            Name = "Menu";
            Text = "Form1";
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
        private Panel panel1;
        private Button btnAccount;
        private FlowLayoutPanel fpnlAccountOptions;
        private Panel panel3;
        private Button btnSearch;
        private Panel panel2;
        private Button btnCart;
        private TextBox txtSearch;
    }
}

