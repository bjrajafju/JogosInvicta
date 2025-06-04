namespace _08_DavidFerreira_ProjetoFinal
{
    partial class AccountOptionsLoggedOut
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
            panel2 = new Panel();
            btnLogin = new Button();
            panel3 = new Panel();
            btnRegistar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 58);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 58);
            panel2.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Dock = DockStyle.Top;
            btnLogin.Location = new Point(0, 58);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 51);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 26);
            panel3.TabIndex = 3;
            // 
            // btnRegistar
            // 
            btnRegistar.Dock = DockStyle.Top;
            btnRegistar.Location = new Point(0, 135);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(150, 54);
            btnRegistar.TabIndex = 4;
            btnRegistar.Text = "Registar";
            btnRegistar.UseVisualStyleBackColor = true;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // AccountOptionsLoggedOut
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(btnRegistar);
            Controls.Add(panel3);
            Controls.Add(btnLogin);
            Controls.Add(panel1);
            Name = "AccountOptionsLoggedOut";
            Size = new Size(150, 299);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button btnLogin;
        private Panel panel3;
        private Button btnRegistar;
    }
}
