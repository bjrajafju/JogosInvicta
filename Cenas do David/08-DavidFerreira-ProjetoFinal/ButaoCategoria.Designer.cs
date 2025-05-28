namespace _08_DavidFerreira_ProjetoFinal
{
    partial class ButaoCategoria
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
            lblCategoryName = new Label();
            SuspendLayout();
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Dock = DockStyle.Fill;
            lblCategoryName.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCategoryName.ForeColor = Color.White;
            lblCategoryName.Location = new Point(0, 0);
            lblCategoryName.MaximumSize = new Size(250, 0);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Padding = new Padding(6, 10, 0, 0);
            lblCategoryName.Size = new Size(63, 31);
            lblCategoryName.TabIndex = 0;
            lblCategoryName.Text = "label1";
            lblCategoryName.Click += lblCategoryName_Click;
            // 
            // ButaoCategoria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblCategoryName);
            MaximumSize = new Size(250, 80);
            MinimumSize = new Size(250, 40);
            Name = "ButaoCategoria";
            Size = new Size(248, 45);
            Load += ButaoCategoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryName;
    }
}
