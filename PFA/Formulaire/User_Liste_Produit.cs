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
    public partial class User_Liste_Produit : UserControl
    {
        private static User_Liste_Produit Userproduit;
        private dbStockContext db;

        public static User_Liste_Produit Instance
        {
            get
            {
                if (Userproduit == null)
                {
                    Userproduit = new User_Liste_Produit();
                }
                return Userproduit;
            }
        }
        public User_Liste_Produit()
        {
            InitializeComponent();
            db = new dbStockContext();
        }
        //Actualiser le datagridview produit
        public void actualiserDatagridview()
        {
            db = new dbStockContext();
            dgvProduit.Rows.Clear();
            //Pour afficher le nom du fournisseur à partir de code_Fournisseur
            Fournisseur fournisseur = new Fournisseur();
            Categorie categorie = new Categorie();
            foreach (var lis in db.Produits)
            {
                fournisseur = db.Fournisseurs.SingleOrDefault(s => s.code_Fournisseur == lis.code_Fournisseur);//Si le code_Categorie dans la table Produit = code_Categorie dans la table Categorie
                categorie = db.Categories.SingleOrDefault(s => s.code_Categorie == lis.code_Categorie);
                if(fournisseur!=null && categorie != null)
                {
                    dgvProduit.Rows.Add(false, lis.code_Produit, lis.nom_Produit, lis.prixUnitaire, fournisseur.nom_Fournisseur, categorie.nom_Categorie, lis.qteEnStock);
                }

            }
        }

        //Vérifier combien de lignes sont sélectionnées
        public String SelectVerif()
        {
            int NombreLigneSelect = 0;
            for (int i = 0; i < dgvProduit.Rows.Count; i++)
            {
                if ((bool)dgvProduit.Rows[i].Cells[0].Value == true)//Si la ligne est sélectionné
                {
                    NombreLigneSelect++;//Le nombre de ligne sélectionné + 1
                }
            }
            if (NombreLigneSelect == 0)
            {
                return "Veuillez sélectionner le produit";
            }
            if (NombreLigneSelect > 1)
            {
                return "Veuillez sélectionner un seul élément";
            }
            return null;
        }

        private void txtRecherche_Enter(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "Recherche")
            {
                txtRecherche.Text = "";
                txtRecherche.ForeColor = Color.Black;
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listeRecherche = db.Produits.ToList();
            listeRecherche = listeRecherche.Where(s => s.nom_Produit.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            //StringComparison.CurrentCultureIgnoreCase=Ignore la casse
            //!=-1 existe dans la base de données
            //Vider le datagridview
            dgvProduit.Rows.Clear();
            //Ajouter listRecherche dans le datagridview client
            Categorie categorie = new Categorie();
            Fournisseur fournisseur = new Fournisseur();
            foreach (var l in listeRecherche)
            {
                categorie = db.Categories.SingleOrDefault(s => s.code_Categorie == l.code_Categorie);
                fournisseur = db.Fournisseurs.SingleOrDefault(s => s.code_Fournisseur == l.code_Fournisseur);
                dgvProduit.Rows.Add(false, l.code_Produit, l.nom_Produit, l.code_Categorie, l.code_Fournisseur, l.prixUnitaire, categorie.nom_Categorie, fournisseur.nom_Fournisseur);
            }
        }

        private void comboRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRecherche.Enabled = true;
            txtRecherche.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Formulaire.FRM_Ajouter_Modifier_Produit frmProduit = new Formulaire.FRM_Ajouter_Modifier_Produit(this);
            frmProduit.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Formulaire.FRM_Ajouter_Modifier_Produit frmProduit = new Formulaire.FRM_Ajouter_Modifier_Produit(this);
            frmProduit.lblTitle.Text = "Modifier produit";
            frmProduit.btnActualiser.Visible = false;
            frmProduit.ShowDialog();
        }

        private void User_Liste_Produit_Load(object sender, EventArgs e)
        {
            actualiserDatagridview();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            Produit PR = new Produit();
            if(SelectVerif()!=null)
            {
                MessageBox.Show(SelectVerif(), "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0; i < dgvProduit.Rows.Count; i++)
                {
                    if((bool)dgvProduit.Rows[i].Cells[0].Value == true)
                    {
                        int MYIDSELECT = (int)dgvProduit.Rows[i].Cells[1].Value;
                        PR = db.Produits.SingleOrDefault(s => s.code_Produit == MYIDSELECT);
                        if(PR!=null)
                        {
                            FRM_Photo_Produit frmPhoto = new FRM_Photo_Produit();
                            MemoryStream MS = new MemoryStream(PR.image_Produit);
                            frmPhoto.pictureProduit.Image = Image.FromStream(MS);
                            frmPhoto.lblNomProduit.Text = dgvProduit.Rows[i].Cells[2].Value.ToString();
                            frmPhoto.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}
