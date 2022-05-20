using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFA.Classe
{
    internal class CLS_Connexion
    {
        //Fonction pour vérifier la connexion
        public bool ConnexionValide(dbStockContext db, string username, string password)
        {
            Utilisateur user = new Utilisateur();//Table utilisateur
            user.username_Utilisateur = username;
            user.password_Utilisateur = password;
            if (db.Utilisateurs.SingleOrDefault(s => s.username_Utilisateur == username && s.password_Utilisateur == password) != null)//Pour vérifier si le nom d'utilisateur et le mot de passe existe
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
