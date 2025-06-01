namespace _08_DavidFerreira_ProjetoFinal
{
    partial class ShoppingCart
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
            panel2 = new Panel();
            btnFinalise = new Button();
            label1 = new Label();
            pnlCartItems = new Panel();
            button1 = new Button();
            pnlSkibidi = new Panel();
            pnlPrice = new Panel();
            lblTotalPrice = new Label();
            label2 = new Label();
            pnlSkibidi.SuspendLayout();
            pnlPrice.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 774);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1121, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 774);
            panel2.TabIndex = 1;
            // 
            // btnFinalise
            // 
            btnFinalise.Dock = DockStyle.Bottom;
            btnFinalise.Location = new Point(222, 703);
            btnFinalise.Name = "btnFinalise";
            btnFinalise.Size = new Size(899, 91);
            btnFinalise.TabIndex = 10;
            btnFinalise.Text = "Finalizar Compra";
            btnFinalise.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(222, 20);
            label1.Name = "label1";
            label1.Padding = new Padding(20);
            label1.Size = new Size(381, 85);
            label1.TabIndex = 8;
            label1.Text = "Conteúdo Do Carrinho";
            // 
            // pnlCartItems
            // 
            pnlCartItems.BorderStyle = BorderStyle.FixedSingle;
            pnlCartItems.Dock = DockStyle.Fill;
            pnlCartItems.Location = new Point(222, 105);
            pnlCartItems.Name = "pnlCartItems";
            pnlCartItems.Size = new Size(899, 492);
            pnlCartItems.TabIndex = 14;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(25, 25);
            button1.Name = "button1";
            button1.Size = new Size(269, 56);
            button1.TabIndex = 0;
            button1.Text = "Limpar Carrinho";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnlSkibidi
            // 
            pnlSkibidi.Controls.Add(button1);
            pnlSkibidi.Controls.Add(pnlPrice);
            pnlSkibidi.Dock = DockStyle.Bottom;
            pnlSkibidi.Location = new Point(222, 597);
            pnlSkibidi.Name = "pnlSkibidi";
            pnlSkibidi.Padding = new Padding(25);
            pnlSkibidi.Size = new Size(899, 106);
            pnlSkibidi.TabIndex = 13;
            // 
            // pnlPrice
            // 
            pnlPrice.Controls.Add(lblTotalPrice);
            pnlPrice.Controls.Add(label2);
            pnlPrice.Dock = DockStyle.Right;
            pnlPrice.Location = new Point(552, 25);
            pnlPrice.Name = "pnlPrice";
            pnlPrice.Size = new Size(322, 56);
            pnlPrice.TabIndex = 12;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Anchor = AnchorStyles.Right;
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(221, 16);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(59, 25);
            lblTotalPrice.TabIndex = 12;
            lblTotalPrice.Text = "label3";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(64, 16);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 11;
            label2.Text = "Preço Total:";
            // 
            // ShoppingCart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 814);
            Controls.Add(pnlCartItems);
            Controls.Add(pnlSkibidi);
            Controls.Add(btnFinalise);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShoppingCart";
            Padding = new Padding(20);
            Text = "ShoppingCart";
            pnlSkibidi.ResumeLayout(false);
            pnlPrice.ResumeLayout(false);
            pnlPrice.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnFinalise;
        private Label label1;
        private Panel pnlCartItems;
        private Button button1;
        private Panel pnlSkibidi;
        private Label label2;
        private Label lblTotalPrice;
        private Panel pnlPrice;
    }
}