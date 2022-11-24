using DeclicInfoBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DeclicInfoDAL;
using System.Runtime.Remoting.Messaging;

namespace DeclicInfoBLL
{
    public class ProduitBLL
    {

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexionde la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        public static List<Produit> GetProduits()
        {
            return ProduitDAL.getProduit();
        }

        public static void DeleteProduit(string code_produit)
        {
            ProduitDAL.deleteProduit(code_produit);
        }

        public static void AddProduit(Produit unProduit)
        {
            ProduitDAL.addProduit(unProduit);
        }

        public static void EditProduit(Produit unProduit)
        {
            ProduitDAL.editProduit(unProduit);
        }
    }
}