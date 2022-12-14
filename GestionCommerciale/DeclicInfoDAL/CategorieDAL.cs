using DeclicInfoBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace DeclicInfoDAL
{
    public class CategorieDAL
    {
        public static List<Categorie> getCategorie()
        {
            int id;
            string libellé;
            Categorie uneCategorie;

            //connexion BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Caégorie
            List<Categorie> listCategories = new List<Categorie>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT [id_categorie_produit],[nom_categorie_produit] FROM [categorie_produit]";
            SqlDataReader monReader = cmd.ExecuteReader();

            //Remplissage de la Liste
            while (monReader.Read())
            {
                id = 0;
                if (monReader["id_categorie_produit"] == DBNull.Value)
                {
                    libellé = default(string);
                }
                else
                {
                    id = (int)monReader["id_categorie_produit"];
                    libellé = monReader["nom_categorie_produit"].ToString();
                }


                uneCategorie = new Categorie(id, libellé);
                listCategories.Add(uneCategorie);

            }
            //Fermeture de la connexion 
            maConnexion.Close();
            return listCategories;
        }
    }
}