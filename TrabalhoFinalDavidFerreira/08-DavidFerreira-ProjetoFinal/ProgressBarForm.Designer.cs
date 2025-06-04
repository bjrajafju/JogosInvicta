namespace _08_DavidFerreira_ProjetoFinal
{
    partial class ProgressBarForm
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            lblProgressIndicator = new Label();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.MediumSeaGreen;
            progressBar1.Location = new Point(32, 121);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(730, 53);
            progressBar1.TabIndex = 0;
            // 
            // lblProgressIndicator
            // 
            lblProgressIndicator.Location = new Point(32, 40);
            lblProgressIndicator.Name = "lblProgressIndicator";
            lblProgressIndicator.Size = new Size(730, 64);
            lblProgressIndicator.TabIndex = 1;
            lblProgressIndicator.Text = "label1";
            lblProgressIndicator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // ProgressBarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 221);
            Controls.Add(lblProgressIndicator);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProgressBarForm";
            Text = "OPERAÇÃO MUITO IMPORTANTE A DECORRER";
            Load += ProgressBarForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Label lblProgressIndicator;
        private System.Windows.Forms.Timer timer;
    }
}