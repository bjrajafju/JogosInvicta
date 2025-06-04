namespace _08_DavidFerreira_ProjetoFinal
{
    partial class ProductPage
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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnAddToCart = new Button();
            nupQuant = new NumericUpDown();
            label1 = new Label();
            panel3 = new Panel();
            txtMainInfo = new RichTextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtDesciption = new RichTextBox();
            tabPage2 = new TabPage();
            txtInfo = new RichTextBox();
            panel5 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupQuant).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(1266, 903);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(163, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAddToCart);
            panel2.Controls.Add(nupQuant);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(txtMainInfo);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(618, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 500);
            panel2.TabIndex = 13;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Dock = DockStyle.Top;
            btnAddToCart.Location = new Point(255, 265);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(194, 68);
            btnAddToCart.TabIndex = 7;
            btnAddToCart.Text = "Adicionar Ao Carrinho";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += button1_Click;
            // 
            // nupQuant
            // 
            nupQuant.Dock = DockStyle.Left;
            nupQuant.Location = new Point(109, 265);
            nupQuant.Name = "nupQuant";
            nupQuant.Size = new Size(146, 31);
            nupQuant.TabIndex = 6;
            nupQuant.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nupQuant.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 265);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 5;
            label1.Text = "Quantidade:";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 247);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 18);
            panel3.TabIndex = 4;
            // 
            // txtMainInfo
            // 
            txtMainInfo.BackColor = Color.SkyBlue;
            txtMainInfo.Dock = DockStyle.Top;
            txtMainInfo.Location = new Point(0, 0);
            txtMainInfo.Name = "txtMainInfo";
            txtMainInfo.ReadOnly = true;
            txtMainInfo.Size = new Size(449, 247);
            txtMainInfo.TabIndex = 0;
            txtMainInfo.Text = "";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(163, 530);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(904, 343);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtDesciption);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(896, 305);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Descrição";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDesciption
            // 
            txtDesciption.BackColor = Color.White;
            txtDesciption.Dock = DockStyle.Fill;
            txtDesciption.ForeColor = SystemColors.WindowText;
            txtDesciption.Location = new Point(3, 3);
            txtDesciption.Name = "txtDesciption";
            txtDesciption.ReadOnly = true;
            txtDesciption.Size = new Size(890, 299);
            txtDesciption.TabIndex = 0;
            txtDesciption.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtInfo);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(896, 305);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Informações";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Dock = DockStyle.Fill;
            txtInfo.Location = new Point(3, 3);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(890, 299);
            txtInfo.TabIndex = 0;
            txtInfo.Text = "";
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1067, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(169, 843);
            panel5.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(30, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(133, 843);
            panel4.TabIndex = 7;
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 903);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductPage";
            Text = "ProductPage";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupQuant).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnAddToCart;
        private NumericUpDown nupQuant;
        private Label label1;
        private Panel panel3;
        private RichTextBox txtMainInfo;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private RichTextBox txtDesciption;
        private TabPage tabPage2;
        private RichTextBox txtInfo;
        private Panel panel5;
        private Panel panel4;
    }
}