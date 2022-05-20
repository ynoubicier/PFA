using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PFA.Formulaire
{
    public partial class FRM_Ajouter_Modifier_Produit : Form
    {
        private dbStockContext db;
        private UserControl userProduit;
        public FRM_Ajouter_Modifier_Produit(UserControl User)
        {
            InitializeComponent();
            db = new dbStockContext();
            this.userProduit = User;
            //Affcher les fournisseurs dans combobox fournisseurq
            comboFournisseur.DataSource = db.Fournisseurs.ToList();
            //Pour filtrer seulement les noms des fournisseurs
            comboFournisseur.DisplayMember = "nom_Fournisseur";
            comboFournisseur.ValueMember = "code_Fournisseur";
            //Affcher les catégories dans combobox categories
            comboCategorie.DataSource = db.Categories.ToList();
            //Pour filtrer seulement les noms des catégories
            comboCategorie.DisplayMember = "nom_Categorie";
            comboCategorie.ValueMember = "code_Categorie";
        }

        //Les champs obligatoires
        string testObligatoire()
        {
            if(txtNomProduit.Text == "" || txtNomProduit.Text == "Nom du produit")
            {
                return "Entrez le libellé du produit";
            }
            if(txtQte.Text == "" || txtQte.Text == "Quantité")
            {
                return "Veuillez spécifier la quantité du produit";
            }
            if(txtPrice.Text == "" || txtPrice.Text == "Prix")
            {
                return "Veuillez spécifier le prix du produit";
            }
            if(comboFournisseur.Text == "")
            {
                return "Veuillez sélectionner le fournisseur du produit";
            }
            if(comboCategorie.Text == "")
            {
                return "Veuillez sélectionner la catégorie du produit";
            }
            if(picProduit.Image == null)
            {
                return "Veuillez insérer l'image du produit";
            }
            return null;
        }

        private void txtNomProduit_Enter(object sender, EventArgs e)
        {
            if(txtNomProduit.Text == "Nom du produit")
            {
                txtNomProduit.Text = "";
                txtNomProduit.ForeColor = Color.White;
            }
        }

        private void txtNomProduit_Leave(object sender, EventArgs e)
        {
            if(txtNomProduit.Text == "")
            {
                txtNomProduit.Text = "Nom du produit";
                txtNomProduit.ForeColor = Color.Silver;
            }
        }

        private void txtQte_Enter(object sender, EventArgs e)
        {
            if(txtQte.Text == "Quantité")
            {
                txtQte.Text = "";
                txtQte.ForeColor = Color.White;
            }
        }

        private void txtQte_Leave(object sender, EventArgs e)
        {
            if(txtQte.Text == "")
            {
                txtQte.Text = "Quantité";
                txtQte.ForeColor = Color.Silver;
            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if(txtPrice.Text == "Prix")
            {
                txtPrice.Text = "";
                txtPrice.ForeColor = Color.White;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if(txtPrice.Text == "")
            {
                txtPrice.Text = "Prix";
                txtPrice.ForeColor = Color.Silver;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            //Afficher le fichier image
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "|*.JPG;*.JPEG;*PNG;*.GIF;*.BMP";
            if(OP.ShowDialog() == DialogResult.OK)
            {
                picProduit.Image = Image.FromFile(OP.FileName);
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            //Vider le formulaire
            comboFournisseur.Text = "";
            comboCategorie.Text = "";
            txtNomProduit.Text = "Nom du produit";
            txtNomProduit.ForeColor = Color.Silver;
            txtQte.Text = "Quantité";
            txtQte.ForeColor = Color.Silver;
            txtPrice.Text = "Prix";
            txtPrice.ForeColor = Color.Silver;
            picProduit.Image = null;
        }

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        public int IDProduit;
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if(testObligatoire() != null)
            {
                MessageBox.Show(testObligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(lblTitle.Text == "Ajouter produit")
                {
                    Classe.CLS_Produit clProduit = new Classe.CLS_Produit();
                    //Convertir image en format byte
                    //Ajouter System.IO
                    MemoryStream MR = new MemoryStream();
                    picProduit.Image.Save(MR, picProduit.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();
                    if(clProduit.ajouter_Produit(Convert.ToInt32(comboFournisseur.SelectedValue), Convert.ToInt32(comboCategorie.SelectedValue), txtNomProduit.Text, txtPrice.Text, int.Parse(txtQte.Text), byteimageP) == true)
                    {
                        MessageBox.Show("Produit ajouter avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userProduit as User_Liste_Produit).actualiserDatagridview();
                    }
                    else
                    {
                        MessageBox.Show("Ce produit existe déja", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MemoryStream MR = new MemoryStream();
                    picProduit.Image.Save(MR, picProduit.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();
                    Classe.CLS_Produit clProduit = new Classe.CLS_Produit();
                    DialogResult RS = MessageBox.Show("Voulez-vous vraiment modifier ce produit", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (RS == DialogResult.Yes)
                    {
                        clProduit.modifier_Produit(IDProduit, Convert.ToInt32(comboFournisseur.SelectedValue), Convert.ToInt32(comboCategorie.SelectedValue), txtNomProduit.Text, txtPrice.Text, int.Parse(txtQte.Text), byteimageP);
                        (userProduit as User_Liste_Produit).actualiserDatagridview();
                    }
                }
            }
        }
    }
}
