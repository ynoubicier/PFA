using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFA.Formulaire
{
    public partial class FRM_Connexion : Form
    {
        private dbStockContext db;
        private Form frmMenu;
        //Classe connexion
        Classe.CLS_Connexion connexion = new Classe.CLS_Connexion();
        public FRM_Connexion(Form Menu)
        {
            InitializeComponent();
            this.frmMenu = Menu;
            //Initialiser la base de donnée
            db = new dbStockContext();
        }

        //Pour vérifier les champs obligatoires
        string testObligatoire()
        {
            if(txtUsername.Text == "" || txtUsername.Text == "Nom d'utilisateur")
            {
                return "Entrez votre nom d'utilisateur";
            }
            if(txtPassword.Text == "" || txtPassword.Text == "Mot de passe")
            {
                return "Entrez votre mot de passe";
            }
            return null;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            //Pour vider le textbox
            if(txtUsername.Text == "Nom d'utilisateur")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.WhiteSmoke; //Changer la couleur du texte
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            //Pour vider le textbox
            if (txtPassword.Text == "Mot de passe")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.WhiteSmoke; //Changer la couleur du texte
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Nom d'utilisateur";
                txtUsername.ForeColor = Color.Silver; //Changer la couleur du texte
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Mot de passe";
                txtPassword.UseSystemPasswordChar = true; //Désactiver passwordchar
                txtPassword.ForeColor = Color.Silver; //Changer la couleur du texte
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if(testObligatoire() == null)
            {
                if(connexion.ConnexionValide(db, txtUsername.Text, txtPassword.Text)==true)
                {
                    MessageBox.Show("Connexion réussi", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frmMenu as Frm_Menu).activerForm();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Connexion échoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(testObligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FRM_Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
