using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_DavidFerreira_ProjetoFinal
{
    public partial class Login : Form
    {
        public delegate void sucessfulLogin(object sender, StringEventArgs e);

        public event sucessfulLogin? onSucessfulLogin;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<List<string>> str = DataManagement.retrieveStrings(GlobalVars.strProvider, "Cliente", "IdCliente", "emailCliente = '" + txtNomeUtilizador.Text + "' AND PalavraPasse = '" + txtPassword.Text + "'");
             if (str.Count == 0)
            {
                MessageBox.Show("Login Inválido!");
            } else 
            {
                MessageBox.Show("Login Com Sucesso!");
                onSucessfulLogin?.Invoke(sender, new StringEventArgs(str[0][0]));
            }
            txtNomeUtilizador.Text = "";
            txtPassword.Text = "";
        }
    }
}
