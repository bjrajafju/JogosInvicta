namespace _08_DavidFerreira_ProjetoFinal
{
    partial class ShoppinArea
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
            pnlProdutores = new Panel();
            cboProdutores = new ComboBox();
            panel4 = new Panel();
            pnlFranchise = new Panel();
            cboFranchise = new ComboBox();
            panel2 = new Panel();
            fpnlCategories = new FlowLayoutPanel();
            panel3 = new Panel();
            fpnlShopItems = new FlowLayoutPanel();
            checkedListBox1 = new CheckedListBox();
            panel1.SuspendLayout();
            pnlProdutores.SuspendLayout();
            pnlFranchise.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlProdutores);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pnlFranchise);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1518, 82);
            panel1.TabIndex = 0;
            // 
            // pnlProdutores
            // 
            pnlProdutores.Controls.Add(cboProdutores);
            pnlProdutores.Dock = DockStyle.Left;
            pnlProdutores.Location = new Point(286, 0);
            pnlProdutores.Margin = new Padding(4, 5, 4, 5);
            pnlProdutores.Name = "pnlProdutores";
            pnlProdutores.Padding = new Padding(14, 25, 14, 0);
            pnlProdutores.Size = new Size(634, 82);
            pnlProdutores.TabIndex = 3;
            // 
            // cboProdutores
            // 
            cboProdutores.Dock = DockStyle.Fill;
            cboProdutores.FormattingEnabled = true;
            cboProdutores.Items.AddRange(new object[] { "--Escolher Produtor--" });
            cboProdutores.Location = new Point(14, 25);
            cboProdutores.Margin = new Padding(4, 5, 4, 5);
            cboProdutores.Name = "cboProdutores";
            cboProdutores.Size = new Size(606, 33);
            cboProdutores.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(286, 82);
            panel4.TabIndex = 2;
            // 
            // pnlFranchise
            // 
            pnlFranchise.Controls.Add(cboFranchise);
            pnlFranchise.Dock = DockStyle.Right;
            pnlFranchise.Location = new Point(921, 0);
            pnlFranchise.Margin = new Padding(4, 5, 4, 5);
            pnlFranchise.Name = "pnlFranchise";
            pnlFranchise.Padding = new Padding(14, 25, 14, 0);
            pnlFranchise.Size = new Size(597, 82);
            pnlFranchise.TabIndex = 0;
            // 
            // cboFranchise
            // 
            cboFranchise.Dock = DockStyle.Fill;
            cboFranchise.FormattingEnabled = true;
            cboFranchise.Items.AddRange(new object[] { "-- Escolher Franchise--" });
            cboFranchise.Location = new Point(14, 25);
            cboFranchise.Margin = new Padding(4, 5, 4, 5);
            cboFranchise.Name = "cboFranchise";
            cboFranchise.Size = new Size(569, 33);
            cboFranchise.TabIndex = 0;
            cboFranchise.SelectedIndexChanged += cboFranchise_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(fpnlCategories);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 82);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(21, 33, 21, 50);
            panel2.Size = new Size(286, 776);
            panel2.TabIndex = 1;
            // 
            // fpnlCategories
            // 
            fpnlCategories.BackColor = SystemColors.Highlight;
            fpnlCategories.BorderStyle = BorderStyle.FixedSingle;
            fpnlCategories.Dock = DockStyle.Fill;
            fpnlCategories.ForeColor = SystemColors.Control;
            fpnlCategories.Location = new Point(21, 33);
            fpnlCategories.Margin = new Padding(4, 5, 4, 5);
            fpnlCategories.Name = "fpnlCategories";
            fpnlCategories.Size = new Size(244, 693);
            fpnlCategories.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(fpnlShopItems);
            panel3.Controls.Add(checkedListBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(286, 82);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20);
            panel3.Size = new Size(1232, 776);
            panel3.TabIndex = 2;
            // 
            // fpnlShopItems
            // 
            fpnlShopItems.AutoScroll = true;
            fpnlShopItems.Dock = DockStyle.Fill;
            fpnlShopItems.Location = new Point(20, 20);
            fpnlShopItems.Name = "fpnlShopItems";
            fpnlShopItems.Size = new Size(1192, 736);
            fpnlShopItems.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(268, 647);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(8, 4);
            checkedListBox1.TabIndex = 0;
            // 
            // ShoppinArea
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 858);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ShoppinArea";
            Text = "ShoppinArea";
            Load += ShoppinArea_Load;
            panel1.ResumeLayout(false);
            pnlProdutores.ResumeLayout(false);
            pnlFranchise.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel fpnlCategories;
        private Panel pnlFranchise;
        private ComboBox cboFranchise;
        private Panel panel3;
        private CheckedListBox checkedListBox1;
        private FlowLayoutPanel fpnlShopItems;
        private Panel pnlProdutores;
        private ComboBox cboProdutores;
        private Panel panel4;
    }
}