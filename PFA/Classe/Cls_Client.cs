using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFA.Classe
{
    internal class Cls_Client
    {
        private dbStockContext db = new dbStockContext();
        private Client C;

        //Fonction pour ajouter un client dans la base de données
        public bool Ajouter_Client(string nom_Client, string prenom_Client, string adresse_Client, string tel_Client, string email_Client, string pays_Client, string ville_Client)
        {
            C = new Client();
            C.nom_Clt = nom_Client;
            C.prenom = prenom_Client;
            C.adresse = adresse_Client;
            C.telephone_Clt = tel_Client;
            C.adresseMail_Clt = email_Client;
            C.paysResidence_Clt = pays_Client;
            C.lieuNaissance_Clt = ville_Client;
            //Vérifier si le nom et le prénom existe déjà dans la base de données
            if(db.Clients.SingleOrDefault(s=>s.nom_Clt == nom_Client && C.prenom == prenom_Client) == null)
            {
                db.Clients.Add(C);//Ajouter dans la table Client
                db.SaveChanges();//Enregistrer dans la base de données

                return true;
            }
            else
            {
                return false;
            }
        }

        //Méthode pour modifier les clients dans la base de données
        public void Modifier_Client(int code_Client, string nom_Client, string prenom_Client, string adresse_Client, string tel_Client, string email_Client, string pays_Client, string ville_Client)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s=>s.code_Client==code_Client);//Vérifier si le code du client existe
            if(C != null)//Existe
            {
                C.nom_Clt = nom_Client;
                C.prenom = prenom_Client;
                C.adresse = adresse_Client;
                C.telephone_Clt = tel_Client;
                C.adresseMail_Clt = email_Client;
                C.paysResidence_Clt = pays_Client;
                C.lieuNaissance_Clt = ville_Client;
                db.SaveChanges();//Sauvegarder les nouvelles informations dans la base de données
            }
        }

        public void supprimer_Client(int code_Client)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.code_Client == code_Client);
            if(C!=null)
            {
                db.Clients.Remove(C);
                db.SaveChanges();
            }
        }
    }
}
