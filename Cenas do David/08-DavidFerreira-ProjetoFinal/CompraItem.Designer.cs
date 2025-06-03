namespace _08_DavidFerreira_ProjetoFinal
{
    partial class CompraItem
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
            pnlSubItems = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            lblStatus = new Label();
            lblDate = new Label();
            label2 = new Label();
            lblID = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSubItems
            // 
            pnlSubItems.AutoSize = true;
            pnlSubItems.Dock = DockStyle.Bottom;
            pnlSubItems.Location = new Point(0, 81);
            pnlSubItems.Name = "pnlSubItems";
            pnlSubItems.Size = new Size(799, 0);
            pnlSubItems.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(799, 68);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(516, 20);
            label3.Name = "label3";
            label3.Size = new Size(204, 25);
            label3.TabIndex = 6;
            label3.Text = "Estado da Encomenda:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Right;
            lblStatus.Location = new Point(720, 20);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(59, 25);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "label4";
            lblStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.None;
            lblDate.AutoSize = true;
            lblDate.Location = new Point(460, 20);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(59, 25);
            lblDate.TabIndex = 3;
            lblDate.Text = "label3";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(280, 20);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 0, 0, 0);
            label2.Size = new Size(180, 25);
            label2.TabIndex = 2;
            label2.Text = "Data de Operação:";
            // 
            // lblID
            // 
            lblID.Dock = DockStyle.Left;
            lblID.ImageAlign = ContentAlignment.MiddleLeft;
            lblID.Location = new Point(153, 20);
            lblID.Name = "lblID";
            lblID.Size = new Size(90, 28);
            lblID.TabIndex = 1;
            lblID.Text = "label2";
            lblID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 0;
            label1.Text = "ID de Compra:";
            // 
            // CompraItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Controls.Add(pnlSubItems);
            Name = "CompraItem";
            Size = new Size(799, 81);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlSubItems;
        private Panel panel1;
        private Label lblID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblStatus;
        private Label lblDate;
    }
}
