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
            button1 = new Button();
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
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(21, 18, 21, 18);
            panel1.Size = new Size(886, 542);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(114, 18);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(nupQuant);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(txtMainInfo);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(433, 18);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 300);
            panel2.TabIndex = 13;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(174, 161);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(140, 41);
            button1.TabIndex = 7;
            button1.Text = "Adicionar Ao Carrinho";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nupQuant
            // 
            nupQuant.Dock = DockStyle.Left;
            nupQuant.Location = new Point(72, 161);
            nupQuant.Margin = new Padding(2, 2, 2, 2);
            nupQuant.Name = "nupQuant";
            nupQuant.Size = new Size(102, 23);
            nupQuant.TabIndex = 6;
            nupQuant.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nupQuant.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 161);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 5;
            label1.Text = "Quantidade:";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 150);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(314, 11);
            panel3.TabIndex = 4;
            // 
            // txtMainInfo
            // 
            txtMainInfo.BackColor = Color.SkyBlue;
            txtMainInfo.Dock = DockStyle.Top;
            txtMainInfo.Location = new Point(0, 0);
            txtMainInfo.Margin = new Padding(2, 2, 2, 2);
            txtMainInfo.Name = "txtMainInfo";
            txtMainInfo.ReadOnly = true;
            txtMainInfo.Size = new Size(314, 150);
            txtMainInfo.TabIndex = 0;
            txtMainInfo.Text = "";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(114, 318);
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(633, 206);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtDesciption);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(625, 178);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Descrição";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDesciption
            // 
            txtDesciption.BackColor = Color.White;
            txtDesciption.Dock = DockStyle.Fill;
            txtDesciption.ForeColor = SystemColors.WindowText;
            txtDesciption.Location = new Point(2, 2);
            txtDesciption.Margin = new Padding(2, 2, 2, 2);
            txtDesciption.Name = "txtDesciption";
            txtDesciption.ReadOnly = true;
            txtDesciption.Size = new Size(621, 174);
            txtDesciption.TabIndex = 0;
            txtDesciption.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtInfo);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(625, 178);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Informações";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Dock = DockStyle.Fill;
            txtInfo.Location = new Point(2, 2);
            txtInfo.Margin = new Padding(2, 2, 2, 2);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(621, 174);
            txtInfo.TabIndex = 0;
            txtInfo.Text = "";
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(747, 18);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(118, 506);
            panel5.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(21, 18);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(93, 506);
            panel4.TabIndex = 7;
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 542);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
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
        private Button button1;
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