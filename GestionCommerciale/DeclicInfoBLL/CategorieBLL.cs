using DeclicInfoDAL;
using DeclicInfoBO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclicInfoBLL
{
    public class CategorieBLL
    {
        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexionde la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        public static List<Categorie> getCategories()
        {
            return CategorieDAL.getCategorie();
        }
    }
}