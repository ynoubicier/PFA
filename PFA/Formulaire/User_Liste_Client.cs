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
    public partial class User_Liste_Client : UserControl
    {
        private static User_Liste_Client Userclient;
        private dbStockContext db;

        public static User_Liste_Client Instance
        {
            get
            {
                if(Userclient==null)
                {
                    Userclient = new User_Liste_Client();
                }
                return Userclient;
            }
        }
        public User_Liste_Client()
        {
            InitializeComponent();
            db = new dbStockContext();
            txtRecherche.Enabled = false;
        }

        //Actualiser le datagridview
        public void actualiserDatagridview()
        {
            db = new dbStockContext();
            dgvClient.Rows.Clear();//Vider le datagridview
            foreach(var S in db.Clients)
            {
                //Ajouter les lignes dans le datagridview
                dgvClient.Rows.Add(false, S.code_Client, S.nom_Clt, S.prenom, S.adresse, S.adresseMail_Clt, S.telephone_Clt, S.lieuNaissance_Clt, S.paysResidence_Clt);
            }
        }

        //Vérifier combien de lignes sont sélectionnées
        public String SelectVerif()
        {
            int NombreLigneSelected = 0;
            for(int i=0;i<dgvClient.Rows.Count;i++)
            {
                if((bool)dgvClient.Rows[i].Cells[0].Value==true)//Si la ligne est sélectionné
                {
                    NombreLigneSelected++;//Le nombre de ligne sélectionné + 1
                }
            }
            if(NombreLigneSelected == 0)
            {
                return "Veuillez sélectionner le client que vous-voulez modifier";
            }
            if(NombreLigneSelected > 1)
            {
                return "Veuillez sélectionner un seul élément à modifier";
            }
            return null;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtRecherche.Text=="Recherche")
            {
                txtRecherche.Text = "";
                txtRecherche.ForeColor = Color.Black;
            }
        }

        private void User_Liste_Client_Load(object sender, EventArgs e)
        {
            actualiserDatagridview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Formulaire.FRM_Ajouter_Modifier_Client frmClient = new FRM_Ajouter_Modifier_Client(this);
            frmClient.ShowDialog();
        }

        public int getCode;
        private void btnModify_Click(object sender, EventArgs e)
        {
            Formulaire.FRM_Ajouter_Modifier_Client frmClient = new FRM_Ajouter_Modifier_Client(this);
            if(SelectVerif()==null)
            {
                for(int i = 0; i < dgvClient.Rows.Count; i++)
                {
                    if((bool)dgvClient.Rows[i].Cells[0].Value==true)
                    {
                        getCode = (int)dgvClient.Rows[i].Cells[1].Value;
                        frmClient.txtNomClient.Text = dgvClient.Rows[i].Cells[2].ToString();
                        frmClient.txtPrenomClient.Text = dgvClient.Rows[i].Cells[3].ToString();
                        frmClient.txtAdresseClient.Text = dgvClient.Rows[i].Cells[4].ToString();
                        frmClient.txtEmailClient.Text = dgvClient.Rows[i].Cells[5].ToString();
                        frmClient.txtTelClient.Text = dgvClient.Rows[i].Cells[6].ToString();
                        frmClient.txtVilleClient.Text = dgvClient.Rows[i].Cells[7].ToString();
                    }
                }
                frmClient.lblTitle.Text = "Modifier un client";
                frmClient.btnActualiser.Visible = false;
                frmClient.ShowDialog();
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Classe.Cls_Client client = new Classe.Cls_Client();
            //Pour supprimer tous les clients sélectionnés
            int select = 0;
            for (int i = 0; i < dgvClient.Rows.Count; i++)
            {
                if((bool)dgvClient.Rows[i].Cells[0].Value!=true)
                {
                    select++;
                }
            }
            if(select == 0)
            {
                MessageBox.Show("Aucun client sélectionné", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer ce client?", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(R == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvClient.Rows.Count; i++)
                    {
                        if ((bool)dgvClient.Rows[i].Cells[0].Value == true)
                        {
                            client.supprimer_Client(int.Parse(dgvClient.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    //Actualiser le datagridview
                    actualiserDatagridview();
                    MessageBox.Show("Supprésion réussi", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Supprésion annulé", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void comboRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRecherche.Enabled = true;
            txtRecherche.Text = "";
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listeRecherche = db.Clients.ToList();
            if(txtRecherche.Text != "")
            {
                switch(comboRecherche.Text)
                {
                    case "Nom":
                        listeRecherche = listeRecherche.Where(s => s.nom_Clt.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        //StringComparison.CurrentCultureIgnoreCase=Ignore la casse
                        //!=-1 existe dans la base de données
                        break;
                    case "Prenom":
                        listeRecherche = listeRecherche.Where(s => s.prenom.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Telephone":
                        listeRecherche = listeRecherche.Where(s => s.telephone_Clt.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Email":
                        listeRecherche = listeRecherche.Where(s => s.adresseMail_Clt.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Adresse":
                        listeRecherche = listeRecherche.Where(s => s.adresse.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Pays":
                        listeRecherche = listeRecherche.Where(s => s.paysResidence_Clt.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Ville":
                        listeRecherche = listeRecherche.Where(s => s.lieuNaissance_Clt.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                }
            }
            //Vider le datagridview
            dgvClient.Rows.Clear();
            //Ajouter listRecherche dans le datagridview client
            foreach(var l in listeRecherche)
            {
                dgvClient.Rows.Add(false, l.code_Client, l.nom_Clt, l.prenom, l.adresse, l.adresseMail_Clt, l.telephone_Clt, l.lieuNaissance_Clt, l.paysResidence_Clt);
            }
        }
    }
}
