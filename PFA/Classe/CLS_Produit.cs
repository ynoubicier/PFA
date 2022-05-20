using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFA.Classe
{
    internal class CLS_Produit
    {
        private dbStockContext db = new dbStockContext();
        private Produit PR;

        //Méthode ajouter produit
        public bool ajouter_Produit(int idFournisseur,int idCategorie, string nomP, string prix, int qte, byte[] imageP)
        {
            PR = new Produit();
            PR.nom_Produit = nomP;
            PR.qteEnStock = qte;
            PR.prixUnitaire = prix;
            PR.code_Fournisseur = idFournisseur;
            PR.code_Categorie = idCategorie;
            PR.image_Produit = imageP;
            //Vérifions si le produit existe déjà
            if(db.Produits.SingleOrDefault(a=>a.nom_Produit==nomP)==null)//N'existe pas
            {
                db.Produits.Add(PR);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void modifier_Produit(int idFournisseur, int idCategorie,int idP, string nomP, string prix, int qte, byte[] imageP)
        {
            PR = new Produit();
            PR = db.Produits.SingleOrDefault(s => s.code_Produit == idP);
            if(PR!=null)
            {
                PR.nom_Produit = nomP;
                PR.qteEnStock = qte;
                PR.prixUnitaire = prix;
                PR.code_Fournisseur = idFournisseur;
                PR.code_Categorie = idCategorie;
                PR.image_Produit = imageP;
                db.SaveChanges();
            }
        }
    }
}
