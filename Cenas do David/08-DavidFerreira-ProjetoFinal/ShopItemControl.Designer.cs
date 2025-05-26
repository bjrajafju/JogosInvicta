namespace _08_DavidFerreira_ProjetoFinal
{
    partial class ShopItemControl
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
            groupBox1 = new GroupBox();
            lblPrice = new RichTextBox();
            stockTextBox = new RichTextBox();
            lblProductName = new RichTextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(stockTextBox);
            groupBox1.Controls.Add(lblProductName);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(5, 5);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(261, 443);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblPrice
            // 
            lblPrice.BackColor = SystemColors.Control;
            lblPrice.BorderStyle = BorderStyle.None;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Location = new Point(3, 337);
            lblPrice.Margin = new Padding(3, 4, 3, 4);
            lblPrice.Name = "lblPrice";
            lblPrice.ReadOnly = true;
            lblPrice.Size = new Size(255, 62);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "";
            // 
            // stockTextBox
            // 
            stockTextBox.BackColor = Color.MidnightBlue;
            stockTextBox.BorderStyle = BorderStyle.None;
            stockTextBox.Dock = DockStyle.Bottom;
            stockTextBox.Location = new Point(3, 399);
            stockTextBox.Name = "stockTextBox";
            stockTextBox.ReadOnly = true;
            stockTextBox.ScrollBars = RichTextBoxScrollBars.None;
            stockTextBox.Size = new Size(255, 40);
            stockTextBox.TabIndex = 7;
            stockTextBox.Text = "";
            // 
            // lblProductName
            // 
            lblProductName.BorderStyle = BorderStyle.None;
            lblProductName.Dock = DockStyle.Top;
            lblProductName.Location = new Point(3, 251);
            lblProductName.Name = "lblProductName";
            lblProductName.ReadOnly = true;
            lblProductName.Size = new Size(255, 86);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(3, 28);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ShopItemControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ShopItemControl";
            Padding = new Padding(5);
            Size = new Size(271, 453);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RichTextBox lblProductName;
        private RichTextBox stockTextBox;
        private RichTextBox lblPrice;
    }
}
    
