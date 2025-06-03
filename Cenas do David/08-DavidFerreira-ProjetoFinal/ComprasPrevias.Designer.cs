namespace _08_DavidFerreira_ProjetoFinal
{
    partial class ComprasPrevias
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
            panel3 = new Panel();
            pnlCompraItems = new Panel();
            label1 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 799);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1078, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(169, 799);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(pnlCompraItems);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(191, 20);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(30);
            panel3.Size = new Size(887, 799);
            panel3.TabIndex = 2;
            // 
            // pnlCompraItems
            // 
            pnlCompraItems.AutoScroll = true;
            pnlCompraItems.BorderStyle = BorderStyle.FixedSingle;
            pnlCompraItems.Dock = DockStyle.Fill;
            pnlCompraItems.Location = new Point(30, 105);
            pnlCompraItems.Name = "pnlCompraItems";
            pnlCompraItems.Size = new Size(827, 664);
            pnlCompraItems.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 30);
            label1.Size = new Size(317, 75);
            label1.TabIndex = 0;
            label1.Text = "As Minhas Compras";
            // 
            // ComprasPrevias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 839);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ComprasPrevias";
            Padding = new Padding(20);
            Text = "ComprasPrevias";
            Load += ComprasPrevias_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel pnlCompraItems;
    }
}