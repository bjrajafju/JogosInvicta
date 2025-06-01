namespace _08_DavidFerreira_ProjetoFinal
{
    partial class CartItemControlcs
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblPrice = new Label();
            btnRemoveFromCart = new Button();
            label1 = new Label();
            nupQuant = new NumericUpDown();
            lblProductName = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupQuant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(btnRemoveFromCart);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nupQuant);
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(642, 119);
            panel1.TabIndex = 1;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Right;
            lblPrice.Location = new Point(493, 20);
            lblPrice.Name = "lblPrice";
            lblPrice.Padding = new Padding(0, 20, 0, 0);
            lblPrice.Size = new Size(59, 45);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "label2";
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.BackgroundImage = Properties.Resources.trashLogo;
            btnRemoveFromCart.BackgroundImageLayout = ImageLayout.Zoom;
            btnRemoveFromCart.Dock = DockStyle.Right;
            btnRemoveFromCart.Location = new Point(552, 20);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(70, 79);
            btnRemoveFromCart.TabIndex = 4;
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 67);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 3;
            label1.Text = "Quantidade:";
            // 
            // nupQuant
            // 
            nupQuant.Location = new Point(221, 65);
            nupQuant.Name = "nupQuant";
            nupQuant.Size = new Size(86, 31);
            nupQuant.TabIndex = 2;
            nupQuant.ValueChanged += nupQuant_ValueChanged;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblProductName.Location = new Point(106, 20);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(57, 21);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "label1";
            lblProductName.Click += lblProductName_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CartItemControlcs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "CartItemControlcs";
            Size = new Size(642, 119);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupQuant).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblProductName;
        private PictureBox pictureBox1;
        private Label label1;
        private NumericUpDown nupQuant;
        private Button btnRemoveFromCart;
        private Label lblPrice;
    }
}
