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
        Cliente Customer;
        string oldPass = "";

        public event EventHandler? returnHome;
        public event EventHandler? deleteAccount;
        public PerfilUtilizador(ref Cliente c)
        {
            InitializeComponent();
            resetToDefault(ref c);
        }

        public Cliente Cliente { get { return Customer; } set { Customer = value; } }

        public void resetPasswords()
        {
            txtConfirmNewPassword.Text = "";
            txtNewPassword.Text = "";
            txtOldPassword.Text = "";
        }

        public void resetToDefault(ref Cliente c)
        {
            Customer = c;
            txtCidade.Text = c.Cidade;
            txtCodPostal.Text = c.CodPostal;
            txtEmail.Text = c.Email;
            txtNomeCliente.Text = c.NomeCliente;
            txtRua.Text = c.Address;
            txtTelefone.Text = c.Telefone;
            List<string> strsPaises = DataManagement.retrieveSingleColumn(GlobalVars.strProvider, "Paises", "Pais");

            for (int i = 0; i < strsPaises.Count; i++)
            {
                cboPaises.Items.Add(strsPaises[i]);
            }

            cboPaises.SelectedItem = Customer.Pais.NomePais;

            resetPasswords();
        }

        private void PerfilUtilizador_Load(object sender, EventArgs e)
        {

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
                if (item.Text == "" || cboPaises.SelectedIndex < 0)
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
                if (txtOldPassword.Text != oldPass && changedPassword)
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
            }
            else changedPassword = false;

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
            values.Add(Customer.Id.ToString());
            values.Add(txtNomeCliente.Text);
            values.Add(txtTelefone.Text);
            values.Add(txtEmail.Text);
            values.Add(txtRua.Text);
            values.Add(txtCodPostal.Text);
            values.Add(txtCidade.Text);
            values.Add(DataManagement.retrieveStrings(GlobalVars.strProvider, "Paises", "IdPais", "Pais ='" + cboPaises?.SelectedItem.ToString() + "'")[0][0]);
            if (changedPassword)
            {
                values.Add(txtNewPassword.Text);
            }
            else values.Add(oldPass);
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

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("A sua conta será eliminada. Tem a certeza?", "Atenção!", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            if (MessageBox.Show("Tem mesmo a certeza? Esta ação é irrecurperável", "Atenção!", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            if(MessageBox.Show("Ficamos triste de o ver ir embora. As suas encomendas em progresso serão canceladas.", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deleteAccount?.Invoke(sender, EventArgs.Empty);
            }
        }
    }
}
