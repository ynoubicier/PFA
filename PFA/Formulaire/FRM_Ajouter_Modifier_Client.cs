using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace PFA.Formulaire
{
    public partial class FRM_Ajouter_Modifier_Client : Form
    {
        private UserControl usclient;
        public FRM_Ajouter_Modifier_Client(UserControl userC)
        {
            InitializeComponent();
            this.usclient = userC;
        }

        String testObligatoire()
        {
            if(txtNomClient.Text == "" || txtNomClient.Text == "Nom du client")
            {
                return "Veuillez entrer le nom du client";
            }
            if(txtPrenomClient.Text == "" || txtPrenomClient.Text == "Prénom du client")
            {
                return "Veuillez entrer le prénom du client";
            }
            if(txtAdresseClient.Text == "" || txtAdresseClient.Text == "Adresse du client")
            {
                return "Veuillez entrer l'adresse du client";
            }
            if(txtTelClient.Text == "" || txtTelClient.Text == "Téléphone du client")
            {
                return "Veuillez entrer le numéro de téléphone du client";
            }
            if(txtEmailClient.Text == "" || txtEmailClient.Text == "Email du client")
            {
                return "Veuillez entrer l'email du client";
            }
            if(txtPaysClient.Text == "" || txtPaysClient.Text == "Pays du client")
            {
                return "Veuillez entrer le nom du pays du client";
            }
            if(txtVilleClient.Text == "" || txtVilleClient.Text == "Ville du client")
            {
                return "Veuillez entrer la ville du client";
            }
            /*if(txtDateNaissClient.Text == "" || txtDateNaissClient.Text == "Date de naissance")
            {
                return "Veuillez entrer la date de naisssance du client";
            }*/
            if(txtEmailClient.Text!="" || txtEmailClient.Text != "Email du client")
            {
                try
                {
                    new MailAddress(txtEmailClient.Text);
                }
                catch(Exception e)
                {
                    return "Email invalide";
                }
            }
            return null;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNomClient_Enter(object sender, EventArgs e)
        {
            if(txtNomClient.Text=="Nom du client")
            {
                txtNomClient.Text = "";
                txtNomClient.ForeColor = Color.White;
            }
        }

        private void txtNomClient_Leave(object sender, EventArgs e)
        {
            if (txtNomClient.Text == "")
            {
                txtNomClient.Text = "Nom du client";
                txtNomClient.ForeColor = Color.Silver;
            }
        }

        private void txtAdresseClient_Enter(object sender, EventArgs e)
        {
            if (txtAdresseClient.Text == "Adresse du client")
            {
                txtAdresseClient.Text = "";
                txtAdresseClient.ForeColor = Color.White;
            }
        }

        private void txtAdresseClient_Leave(object sender, EventArgs e)
        {
            if (txtAdresseClient.Text == "")
            {
                txtAdresseClient.Text = "Adresse du client";
                txtAdresseClient.ForeColor = Color.Silver;
            }
        }

        private void txtPaysClient_Enter(object sender, EventArgs e)
        {
            if(txtPaysClient.Text== "Pays du client")
            {
                txtPaysClient.Text = "";
                txtPaysClient.ForeColor = Color.White;
            }
        }

        private void txtPaysClient_Leave(object sender, EventArgs e)
        {
            if (txtPaysClient.Text == "")
            {
                txtPaysClient.Text = "Pays du client";
                txtPaysClient.ForeColor = Color.Silver;
            }
        }

        private void txtPrenomClient_Enter(object sender, EventArgs e)
        {
            if(txtPrenomClient.Text=="Prénom du client")
            {
                txtPrenomClient.Text = "";
                txtPrenomClient.ForeColor = Color.White;
            }
        }

        private void txtPrenomClient_Leave(object sender, EventArgs e)
        {
            if(txtPrenomClient.Text=="")
            {
                txtPrenomClient.Text = "Prénom du client";
                txtPrenomClient.ForeColor = Color.Silver;
            }
        }

        private void txtTelClient_Enter(object sender, EventArgs e)
        {
            if(txtTelClient.Text=="Téléphone du client")
            {
                txtTelClient.Text = "";
                txtTelClient.ForeColor = Color.White;
            }
        }

        private void txtTelClient_Leave(object sender, EventArgs e)
        {
            if(txtTelClient.Text=="")
            {
                txtTelClient.Text = "Téléphone du client";
                txtTelClient.ForeColor = Color.Silver;
            }
        }

        private void txtEmailClient_Enter(object sender, EventArgs e)
        {
            if(txtEmailClient.Text=="Email du client")
            {
                txtEmailClient.Text = "";
                txtEmailClient.ForeColor = Color.White;
            }
        }

        private void txtEmailClient_Leave(object sender, EventArgs e)
        {
            if(txtEmailClient.Text=="")
            {
                txtEmailClient.Text = "Email du client";
                txtEmailClient.ForeColor = Color.Silver;
            }
        }

        private void txtVilleClient_Enter(object sender, EventArgs e)
        {
            if(txtVilleClient.Text=="Ville du client")
            {
                txtVilleClient.Text = "";
                txtVilleClient.ForeColor = Color.White;
            }
        }

        private void txtVilleClient_Leave(object sender, EventArgs e)
        {
            if(txtVilleClient.Text=="")
            {
                txtVilleClient.Text = "Ville du client";
                txtVilleClient.ForeColor = Color.Silver;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTelClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if(e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if(testObligatoire()!=null)
            {
                MessageBox.Show(testObligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(lblTitle.Text == "Ajouter un client")
            {
                Classe.Cls_Client client = new Classe.Cls_Client();
                if(client.Ajouter_Client(txtNomClient.Text, txtPrenomClient.Text, txtAdresseClient.Text, txtTelClient.Text, txtPaysClient.Text, txtEmailClient.Text, txtVilleClient.Text)==true)
                {
                    MessageBox.Show("Client ajouté avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (usclient as User_Liste_Client).actualiserDatagridview();
                }
                else
                {
                    MessageBox.Show("Nom et Prénom déjà existant", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //Si lbltitle = "Modifier un client"
            {
                Classe.Cls_Client client = new Classe.Cls_Client();
                User_Liste_Client user = new User_Liste_Client();
                DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment modifier le client", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult==DialogResult.Yes)
                {
                    client.Modifier_Client(user.getCode, txtNomClient.Text, txtPrenomClient.Text, txtAdresseClient.Text, txtTelClient.Text, txtPaysClient.Text, txtEmailClient.Text, txtVilleClient.Text);
                    //Pour actualiser le datagridview
                    (usclient as User_Liste_Client).actualiserDatagridview();
                    MessageBox.Show("Client modifié avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("La modification est annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            txtNomClient.Text = "Nom de client";
            txtNomClient.ForeColor = Color.Silver;
            txtPrenomClient.Text = "Prénom du client";
            txtPrenomClient.ForeColor = Color.Silver;
            txtAdresseClient.Text = "Adresse du client";
            txtAdresseClient.ForeColor = Color.Silver;
            txtTelClient.Text = "Téléphone du client";
            txtTelClient.ForeColor = Color.Silver;
            txtEmailClient.Text = "Email du client";
            txtEmailClient.ForeColor = Color.Silver;
            txtPaysClient.Text = "Pays du client";
            txtPaysClient.ForeColor = Color.Silver;
            txtVilleClient.Text = "Ville du client";
            txtVilleClient.ForeColor = Color.Silver;
        }

        private void FRM_Ajouter_Modifier_Client_Load(object sender, EventArgs e)
        {

        }
    }
}
