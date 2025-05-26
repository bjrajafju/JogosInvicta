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
            lblProductName = new RichTextBox();
            lblPrice = new RichTextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblProductName);
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(249, 435);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblProductName
            // 
            lblProductName.BorderStyle = BorderStyle.None;
            lblProductName.Dock = DockStyle.Top;
            lblProductName.Location = new Point(3, 251);
            lblProductName.Name = "lblProductName";
            lblProductName.ReadOnly = true;
            lblProductName.Size = new Size(243, 93);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "";
            // 
            // lblPrice
            // 
            lblPrice.BackColor = SystemColors.Control;
            lblPrice.BorderStyle = BorderStyle.None;
            lblPrice.Dock = DockStyle.Bottom;
            lblPrice.Location = new Point(3, 370);
            lblPrice.Margin = new Padding(3, 4, 3, 4);
            lblPrice.Name = "lblPrice";
            lblPrice.ReadOnly = true;
            lblPrice.Size = new Size(243, 61);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(3, 28);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ShopItemControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ShopItemControl";
            Size = new Size(249, 435);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox lblPrice;
        private RichTextBox lblProductName;
    }
}
    
