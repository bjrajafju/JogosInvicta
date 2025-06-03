using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace _08_DavidFerreira_ProjetoFinal
{
    public partial class ProgressBarForm : Form
    {
        public ProgressBarForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        double time = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 2)
            {
                lblProgressIndicator.Text = "A Estabelecer Conexão com o seu banco";
                time += 0.1;
            }
            else if (progressBar1.Value < 10)
            {
                lblProgressIndicator.Text = "A Verificar Dados";
                time += 0.3;
            }
            else if (progressBar1.Value < 25)
            {
                lblProgressIndicator.Text = "A vender os teus dados aos chinocas";
                time += 1;
            }
            else if (progressBar1.Value < 50)
            {
                lblProgressIndicator.Text = "A sacar dinheiro da tua conta";
                time += 2;
            }
            else if (progressBar1.Value < 52)
            {
                lblProgressIndicator.Text = "A descansar... Já fizemos muito";
                time += 0.05;
            }
            else if (progressBar1.Value < 65)
            {
                lblProgressIndicator.Text = "A Arranjar Aprovação...";
                time += 0.5;
            }
            else if (progressBar1.Value < 75)
            {
                lblProgressIndicator.Text = "I'd Like to be...";
                time += 0.8;
            }
            else if (progressBar1.Value < 80)
            {
                lblProgressIndicator.Text = "Under The Sea";
                time += 0.9;
            }
            else if (progressBar1.Value < 100)
            {
                lblProgressIndicator.Text = "A acabar a operação...";
                time += 1.5;
            }

            if (Math.Round(time) == 100)
            {
                progressBar1.Value = 100;
                timer.Stop();
                MessageBox.Show("Pagamento Efetuado!");
                DialogResult = DialogResult.OK;
                this.Close();
            } 

            if (Math.Round(time, 1) == Math.Round(time))
            {
                progressBar1.Value = (int)time;
            } 

        }
        private void ProgressBarForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
