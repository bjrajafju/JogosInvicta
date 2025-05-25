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
            btnAccount = new Button();
            btnCart = new Button();
            lblAppName = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            fpnlAccountOptions = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.MidnightBlue;
            pnlHeader.Controls.Add(btnAccount);
            pnlHeader.Controls.Add(btnCart);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Controls.Add(btnSearch);
            pnlHeader.Controls.Add(txtSearch);
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
            // btnAccount
            // 
            btnAccount.BackColor = Color.Transparent;
            btnAccount.BackgroundImage = _08_DavidFerreira_ProjetoFinal.Properties.Resources.accountLogo;
            btnAccount.BackgroundImageLayout = ImageLayout.Stretch;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.ForeColor = Color.Transparent;
            btnAccount.Location = new Point(1396, 15);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(43, 50, 43, 50);
            btnAccount.Size = new Size(96, 112);
            btnAccount.TabIndex = 1;
            btnAccount.UseVisualStyleBackColor = false;
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.Transparent;
            btnCart.BackgroundImage = _08_DavidFerreira_ProjetoFinal.Properties.Resources.cartLogo;
            btnCart.BackgroundImageLayout = ImageLayout.Stretch;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.ForeColor = Color.Transparent;
            btnCart.Location = new Point(1253, 32);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(73, 85);
            btnCart.TabIndex = 2;
            btnCart.UseVisualStyleBackColor = false;
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
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(33, 101, 227);
            btnSearch.BackgroundImage = _08_DavidFerreira_ProjetoFinal.Properties.Resources.searchLogo;
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = SystemColors.ControlText;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(1166, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(46, 55);
            btnSearch.TabIndex = 3;
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(774, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Pesquise Aqui";
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.Size = new Size(394, 44);
            txtSearch.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = _08_DavidFerreira_ProjetoFinal.Properties.Resources.invictaLogo;
            pictureBox1.Location = new Point(17, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 898);
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
            fpnlAccountOptions.Size = new Size(0, 750);
            fpnlAccountOptions.TabIndex = 2;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1537, 1048);
            Controls.Add(fpnlAccountOptions);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            IsMdiContainer = true;
            MinimumSize = new Size(1548, 994);
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
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private Label lblAppName;
        private Button btnCart;
        private Panel panel1;
        private Button btnAccount;
        private FlowLayoutPanel fpnlAccountOptions;
    }
}

