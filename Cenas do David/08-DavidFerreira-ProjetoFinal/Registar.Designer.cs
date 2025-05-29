namespace _08_DavidFerreira_ProjetoFinal
{
    partial class Registar
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
            txtTelefone = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtNomeUtilizador = new TextBox();
            label1 = new Label();
            label5 = new Label();
            btnRegister = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            panel2 = new Panel();
            cboPaíses = new ComboBox();
            label10 = new Label();
            txtCidade = new TextBox();
            label7 = new Label();
            txtCodPostal = new TextBox();
            label8 = new Label();
            txtRua = new TextBox();
            label9 = new Label();
            label11 = new Label();
            panel3 = new Panel();
            txtConfirmPassword = new TextBox();
            label14 = new Label();
            txtPassword = new TextBox();
            label15 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtTelefone);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNomeUtilizador);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(11, 40);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(14, 12, 14, 12);
            panel1.Size = new Size(388, 189);
            panel1.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Dock = DockStyle.Top;
            txtTelefone.Location = new Point(14, 139);
            txtTelefone.Margin = new Padding(2);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(358, 23);
            txtTelefone.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 108);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 12, 0, 0);
            label2.Size = new Size(62, 31);
            label2.TabIndex = 7;
            label2.Text = "Telefone:";
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Top;
            txtEmail.Location = new Point(14, 85);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(358, 23);
            txtEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 54);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 12, 0, 0);
            label3.Size = new Size(48, 31);
            label3.TabIndex = 5;
            label3.Text = "E-Mail";
            // 
            // txtNomeUtilizador
            // 
            txtNomeUtilizador.Dock = DockStyle.Top;
            txtNomeUtilizador.Location = new Point(14, 31);
            txtNomeUtilizador.Margin = new Padding(2);
            txtNomeUtilizador.Name = "txtNomeUtilizador";
            txtNomeUtilizador.Size = new Size(358, 23);
            txtNomeUtilizador.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 1;
            label1.Text = "Nome do Cliente";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(9, 6);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(175, 32);
            label5.TabIndex = 1;
            label5.Text = "Dados Pessoais";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.BackColor = Color.DodgerBlue;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(409, 289);
            btnRegister.Margin = new Padding(2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(389, 41);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Registar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.ForeColor = Color.Red;
            btnCancelar.Location = new Point(408, 342);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(389, 49);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(408, 6);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 32);
            label4.TabIndex = 16;
            label4.Text = "Morada";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cboPaíses);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtCidade);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtCodPostal);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtRua);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(409, 40);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(14, 12, 14, 12);
            panel2.Size = new Size(388, 235);
            panel2.TabIndex = 15;
            // 
            // cboPaíses
            // 
            cboPaíses.Dock = DockStyle.Top;
            cboPaíses.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaíses.FormattingEnabled = true;
            cboPaíses.Items.AddRange(new object[] { "---Escolher País---" });
            cboPaíses.Location = new Point(14, 193);
            cboPaíses.Margin = new Padding(2);
            cboPaíses.Name = "cboPaíses";
            cboPaíses.Size = new Size(358, 23);
            cboPaíses.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(14, 162);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 12, 0, 0);
            label10.Size = new Size(36, 31);
            label10.TabIndex = 14;
            label10.Text = "País:";
            // 
            // txtCidade
            // 
            txtCidade.Dock = DockStyle.Top;
            txtCidade.Location = new Point(14, 139);
            txtCidade.Margin = new Padding(2);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(358, 23);
            txtCidade.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 108);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 12, 0, 0);
            label7.Size = new Size(54, 31);
            label7.TabIndex = 7;
            label7.Text = "Cidade:";
            // 
            // txtCodPostal
            // 
            txtCodPostal.Dock = DockStyle.Top;
            txtCodPostal.Location = new Point(14, 85);
            txtCodPostal.Margin = new Padding(2);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(358, 23);
            txtCodPostal.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(14, 54);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 12, 0, 0);
            label8.Size = new Size(95, 31);
            label8.TabIndex = 5;
            label8.Text = "Código-Postal";
            // 
            // txtRua
            // 
            txtRua.Dock = DockStyle.Top;
            txtRua.Location = new Point(14, 31);
            txtRua.Margin = new Padding(2);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(358, 23);
            txtRua.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 12);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(32, 19);
            label9.TabIndex = 1;
            label9.Text = "Rua";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F);
            label11.Location = new Point(11, 235);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(111, 32);
            label11.TabIndex = 15;
            label11.Text = "Password";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtConfirmPassword);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label15);
            panel3.Location = new Point(11, 269);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(14, 12, 14, 12);
            panel3.Size = new Size(388, 122);
            panel3.TabIndex = 14;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Dock = DockStyle.Top;
            txtConfirmPassword.Location = new Point(14, 85);
            txtConfirmPassword.Margin = new Padding(2);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(358, 23);
            txtConfirmPassword.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Top;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(14, 54);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Padding = new Padding(0, 12, 0, 0);
            label14.Size = new Size(132, 31);
            label14.TabIndex = 5;
            label14.Text = "Confirmar Password";
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Top;
            txtPassword.Location = new Point(14, 31);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(358, 23);
            txtPassword.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Top;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(14, 12);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(67, 19);
            label15.TabIndex = 1;
            label15.Text = "Password";
            // 
            // Registar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 427);
            Controls.Add(label11);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(btnRegister);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Registar";
            Padding = new Padding(7, 6, 7, 6);
            Text = "Registar";
            Load += Registar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox txtNomeUtilizador;
        private Label label1;
        private TextBox txtTelefone;
        private Label label2;
        private TextBox txtEmail;
        private Label label5;
        private Button btnRegister;
        private Button btnCancelar;
        private Label label4;
        private Panel panel2;
        private TextBox txtCidade;
        private Label label7;
        private TextBox txtCodPostal;
        private Label label8;
        private TextBox txtRua;
        private Label label9;
        private ComboBox cboPaíses;
        private Label label10;
        private Label label11;
        private Panel panel3;
        private TextBox txtConfirmPassword;
        private Label label14;
        private TextBox txtPassword;
        private Label label15;
    }
}