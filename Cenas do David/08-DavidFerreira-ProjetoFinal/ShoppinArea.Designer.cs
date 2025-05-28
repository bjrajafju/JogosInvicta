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
            btnRefresh = new Button();
            pnlFranchise = new Panel();
            cboFranchise = new ComboBox();
            panel2 = new Panel();
            fpnlCategorias = new FlowLayoutPanel();
            panel3 = new Panel();
            fpnlShopItems = new FlowLayoutPanel();
            checkedListBox1 = new CheckedListBox();
            panel1.SuspendLayout();
            pnlProdutores.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1063, 49);
            panel1.TabIndex = 0;
            // 
            // pnlProdutores
            // 
            pnlProdutores.Controls.Add(cboProdutores);
            pnlProdutores.Dock = DockStyle.Left;
            pnlProdutores.Location = new Point(200, 0);
            pnlProdutores.Name = "pnlProdutores";
            pnlProdutores.Padding = new Padding(10, 15, 10, 0);
            pnlProdutores.Size = new Size(444, 49);
            pnlProdutores.TabIndex = 3;
            // 
            // cboProdutores
            // 
            cboProdutores.Dock = DockStyle.Fill;
            cboProdutores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProdutores.FormattingEnabled = true;
            cboProdutores.Items.AddRange(new object[] { "--Escolher Produtor--" });
            cboProdutores.Location = new Point(10, 15);
            cboProdutores.Name = "cboProdutores";
            cboProdutores.Size = new Size(424, 23);
            cboProdutores.TabIndex = 0;
            cboProdutores.SelectedIndexChanged += cboProdutores_SelectedIndexChanged_1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnRefresh);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(7, 6, 7, 6);
            panel4.Size = new Size(200, 49);
            panel4.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.BackgroundImage = Properties.Resources.refreshLogo;
            btnRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefresh.Dock = DockStyle.Right;
            btnRefresh.Location = new Point(157, 6);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(36, 37);
            btnRefresh.TabIndex = 0;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Visible = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pnlFranchise
            // 
            pnlFranchise.Controls.Add(cboFranchise);
            pnlFranchise.Dock = DockStyle.Right;
            pnlFranchise.Location = new Point(645, 0);
            pnlFranchise.Name = "pnlFranchise";
            pnlFranchise.Padding = new Padding(10, 15, 10, 0);
            pnlFranchise.Size = new Size(418, 49);
            pnlFranchise.TabIndex = 0;
            // 
            // cboFranchise
            // 
            cboFranchise.Dock = DockStyle.Fill;
            cboFranchise.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFranchise.FormattingEnabled = true;
            cboFranchise.Items.AddRange(new object[] { "-- Escolher Franchise--" });
            cboFranchise.Location = new Point(10, 15);
            cboFranchise.Name = "cboFranchise";
            cboFranchise.Size = new Size(398, 23);
            cboFranchise.TabIndex = 0;
            cboFranchise.SelectedIndexChanged += cboFranchise_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(fpnlCategorias);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15, 20, 0, 30);
            panel2.Size = new Size(200, 603);
            panel2.TabIndex = 1;
            // 
            // fpnlCategorias
            // 
            fpnlCategorias.AutoScroll = true;
            fpnlCategorias.BackColor = SystemColors.Highlight;
            fpnlCategorias.BorderStyle = BorderStyle.FixedSingle;
            fpnlCategorias.Dock = DockStyle.Fill;
            fpnlCategorias.ForeColor = SystemColors.Control;
            fpnlCategorias.Location = new Point(15, 20);
            fpnlCategorias.Margin = new Padding(0);
            fpnlCategorias.Name = "fpnlCategorias";
            fpnlCategorias.Size = new Size(185, 553);
            fpnlCategorias.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(fpnlShopItems);
            panel3.Controls.Add(checkedListBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 49);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(14, 12, 14, 12);
            panel3.Size = new Size(863, 603);
            panel3.TabIndex = 2;
            // 
            // fpnlShopItems
            // 
            fpnlShopItems.AutoScroll = true;
            fpnlShopItems.BorderStyle = BorderStyle.Fixed3D;
            fpnlShopItems.Dock = DockStyle.Fill;
            fpnlShopItems.Location = new Point(14, 12);
            fpnlShopItems.Margin = new Padding(2);
            fpnlShopItems.Name = "fpnlShopItems";
            fpnlShopItems.Size = new Size(835, 579);
            fpnlShopItems.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(188, 388);
            checkedListBox1.Margin = new Padding(2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(7, 4);
            checkedListBox1.TabIndex = 0;
            // 
            // ShoppinArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 652);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShoppinArea";
            Text = "ShoppinArea";
            Load += ShoppinArea_Load;
            panel1.ResumeLayout(false);
            pnlProdutores.ResumeLayout(false);
            panel4.ResumeLayout(false);
            pnlFranchise.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel fpnlCategorias;
        private Panel pnlFranchise;
        private ComboBox cboFranchise;
        private Panel panel3;
        private CheckedListBox checkedListBox1;
        private FlowLayoutPanel fpnlShopItems;
        private Panel pnlProdutores;
        private ComboBox cboProdutores;
        private Panel panel4;
        private Button btnRefresh;
    }
}