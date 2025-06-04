namespace _08_DavidFerreira_ProjetoFinal
{
    partial class AccountOptionsLoggedIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnPerfil = new Button();
            button2 = new Button();
            panel2 = new Panel();
            btnLogOut = new Button();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(117, 38);
            panel1.TabIndex = 0;
            // 
            // btnPerfil
            // 
            btnPerfil.Dock = DockStyle.Top;
            btnPerfil.Location = new Point(0, 38);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(117, 48);
            btnPerfil.TabIndex = 1;
            btnPerfil.Text = "Perfil";
            btnPerfil.UseVisualStyleBackColor = true;
            btnPerfil.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 124);
            button2.Name = "button2";
            button2.Size = new Size(117, 68);
            button2.TabIndex = 3;
            button2.Text = "As minhas compras";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(117, 38);
            panel2.TabIndex = 2;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.ForeColor = Color.Red;
            btnLogOut.Location = new Point(0, 257);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(117, 43);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Sair";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLagOut_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 192);
            panel3.Name = "panel3";
            panel3.Size = new Size(117, 38);
            panel3.TabIndex = 4;
            // 
            // AccountOptionsLoggedIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(btnLogOut);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(btnPerfil);
            Controls.Add(panel1);
            MaximumSize = new Size(150, 300);
            Name = "AccountOptionsLoggedIn";
            Size = new Size(117, 300);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPerfil;
        private Button button2;
        private Panel panel2;
        private Button btnLogOut;
        private Panel panel3;
    }
}