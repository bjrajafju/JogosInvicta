using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _08_DavidFerreira_ProjetoFinal.Login;

namespace _08_DavidFerreira_ProjetoFinal
{
    public partial class Registar : Form
    {
        public event EventHandler? onSucessfulRegistry;
        public Registar()
        {
            InitializeComponent();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item.Text == "")
                {
                    MessageBox.Show("Dados Pessoais Vazios");
                    return;
                }
            }


            foreach (Control item in panel2.Controls)
            {
                if (item.Text == "" || cboPaíses.SelectedIndex < 1)
                {
                    MessageBox.Show("Dados de Localização Vazios");
                    return;
                }
            }

            if (txtCodPostal.Text.Length != 8)
            {
                MessageBox.Show("Código-Postal Inválido");
            }

            foreach (Control item in panel3.Controls)
            {
                if (item.Text == "")
                {
                    MessageBox.Show("Password Vazia");
                    return;
                }
            }

            if(!txtEmail.Text.Contains('@') && !txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("Email Inválido");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords Não Coincidem!");
                return;
            }
            else if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password Muito Curta. No Mínimo 8 caracteres.");
                return;
            }
            List<string> colunas = new List<string>();
            colunas.Add("nomeCliente");
            colunas.Add("telefoneCliente");
            colunas.Add("emailCliente");
            colunas.Add("moradaCliente");
            colunas.Add("codPostalCliente");
            colunas.Add("cidadeCliente");
            colunas.Add("IdPais");
            colunas.Add("PalavraPasse");

            List<string> values = new List<string>();
            values.Add(txtNomeUtilizador.Text);
            values.Add(txtTelefone.Text);
            values.Add(txtEmail.Text);
            values.Add(txtRua.Text);
            values.Add(txtCodPostal.Text);
            values.Add(txtCidade.Text);
            values.Add(DataManagement.retrieveStrings(GlobalVars.strProvider, "Paises", "IdPais", "Pais ='" + cboPaíses?.SelectedItem.ToString() + "'")[0][0]);
            values.Add(txtPassword.Text);
            int n = DataManagement.insertIntoDatabase(GlobalVars.strProvider, "Cliente", colunas, values);
            if (n == GlobalVars.aOk) {
                MessageBox.Show("Registo Efetuado Com Sucesso!");
                onSucessfulRegistry?.Invoke(sender, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show(n.ToString());
            }

        }

        private void Registar_Load(object sender, EventArgs e)
        {
            List<string>? list = DataManagement.mergeListListString(DataManagement.retrieveStrings(GlobalVars.strProvider, "Paises", "Pais"));
            for (int i = 0; i < list.Count; i++)
            {
                cboPaíses.Items.Add(list[i]);
            }
        }
    }
}
