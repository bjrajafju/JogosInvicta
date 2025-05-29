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
    public partial class PerfilUtilizador : Form
    {
        int idCliente;
        string oldPass = "";

        public event EventHandler? returnHome;
        public PerfilUtilizador(int idCliente)
        {
            this.idCliente = idCliente;
            InitializeComponent();
        }

        public int IdCliente { get { return idCliente; } set { idCliente = value; } }

        public void resetPasswords()
        {
            txtConfirmNewPassword.Text = "";
            txtNewPassword.Text = "";
            txtOldPassword.Text = "";
        }

        public void resetToDefault()
        {
            List<string> strs = DataManagement.retrieveStrings(GlobalVars.strProvider, "Cliente", "*", "IdCliente = "+idCliente)[0];
            txtNomeCliente.Text = strs[1];
            txtTelefone.Text = strs[2];
            txtEmail.Text = strs[3];
            txtRua.Text = strs[4];
            txtCodPostal.Text = strs[5];
            txtCidade.Text = strs[6];
            oldPass = strs[8];
            List<string> strsPaises = DataManagement.mergeListListString(DataManagement.retrieveStrings(GlobalVars.strProvider, "Paises", "Pais"));

            for (int i = 0; i < strsPaises.Count; i++)
            {
                cboPaises.Items.Add(strsPaises[i]);
            }

            cboPaises.SelectedItem = DataManagement.retrieveStrings(GlobalVars.strProvider, "Paises", "Pais", "IdPais = " + strs[7])[0][0];

            resetPasswords();
        }

        private void PerfilUtilizador_Load(object sender, EventArgs e)
        {
            resetToDefault();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            foreach (Control item in pnlData1.Controls)
            {
                if (item.Text == "")
                {
                    MessageBox.Show("Dados Pessoais Vazios");
                    return;
                }
            }

            foreach (Control item in pnlData2.Controls)
            {
                if (item.Text == "" || cboPaises.SelectedIndex < 1)
                {
                    MessageBox.Show("Dados de Localização Vazios");
                    return;
                }
            }

            if (txtCodPostal.Text.Length != 8)
            {
                MessageBox.Show("Código-Postal Inválido");
            }


            if (!txtEmail.Text.Contains('@') && !txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("Email Inválido");
                return;
            }
            bool changedPassword = true;
            if (txtOldPassword.Text.Length != 0)
            {
                if(txtOldPassword.Text != oldPass && changedPassword)
                {
                    MessageBox.Show("A sua Password antiga não corresponde à introduzida.");
                    changedPassword = false;
                    return;
                }

                if (txtNewPassword.Text != txtConfirmNewPassword.Text && changedPassword)
                {
                    MessageBox.Show("Passwords Não Coincidem!");
                    changedPassword = false;
                    return;
                }
                else if (txtNewPassword.Text.Length < 8 && changedPassword)
                {
                    MessageBox.Show("Password Muito Curta. No Mínimo 8 caracteres.");
                    changedPassword = false;
                    return;
                }
            } else changedPassword = false;

            List<string> colunas = new List<string>();
            colunas.Add("IdCliente");
            colunas.Add("nomeCliente");
            colunas.Add("telefoneCliente");
            colunas.Add("emailCliente");
            colunas.Add("moradaCliente");
            colunas.Add("codPostalCliente");
            colunas.Add("cidadeCliente");
            colunas.Add("IdPais");
            colunas.Add("PalavraPasse");

            List<string> values = new List<string>();
            values.Add(idCliente.ToString());
            values.Add(txtNomeCliente.Text);
            values.Add(txtTelefone.Text);
            values.Add(txtEmail.Text);
            values.Add(txtRua.Text);
            values.Add(txtCodPostal.Text);
            values.Add(txtCidade.Text);
            values.Add(DataManagement.retrieveStrings(GlobalVars.strProvider, "Paises", "IdPais", "Pais ='" + cboPaises?.SelectedItem.ToString() + "'")[0][0]);
            if (changedPassword) {
                values.Add(txtNewPassword.Text);
            } else values.Add(oldPass);
            int n = DataManagement.updateDatabase(GlobalVars.strProvider, "Cliente", colunas, values);
            if (n == GlobalVars.aOk)
            {
                MessageBox.Show("Está Feito GangaLang!");
                txtConfirmNewPassword.Text = "";
                txtNewPassword.Text = "";
                txtOldPassword.Text = "";
                returnHome?.Invoke(sender, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show(n.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            returnHome?.Invoke(sender, EventArgs.Empty);
        }
    }
}
