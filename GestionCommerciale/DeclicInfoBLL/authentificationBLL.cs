using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeclicInfoBO;
using DeclicInfoDAL;

namespace DeclicInfoBLL
{
    public class authentificationBLL
    {

        public static Utilisateur GetUtilisateur(Utilisateur unUtilisateur)
        {
            return authentificationDAL.GetUtilisateur(unUtilisateur);
            
        }
        public static void SetChaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
    }
}
