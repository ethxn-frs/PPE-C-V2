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
    public class ProduitDAL
    {
        public static List<Produit> getProduit()
        {
            string code;
            string libellé;
            int prixht;
            int id_categorie;
            string libellé_categorie;
            Categorie uneCategorie;
            Produit unProduit;

            //connexion BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Produit> Inventaire = new List<Produit>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "select code_produit, libelle_produit, prixht_produit, nom_categorie_produit, dbo.categorie_produit.id_categorie_produit from produit inner join dbo.categorie_produit on dbo.produit.id_categorie_produit = dbo.categorie_produit.id_categorie_produit";
            SqlDataReader monReader = cmd.ExecuteReader();

            //SqlCommand sql = new SqlCommand();
            //sql.Connection = maConnexion;
            //sql.CommandText = "Select * from categorie_produit";
            //SqlDataReader mondReader = sql.ExecuteReader();


            //Remplissage de la Liste
            while (monReader.Read())
            {
                code = monReader["code_produit"].ToString();
                libellé = monReader["libelle_produit"].ToString();
                prixht = (int)monReader["prixht_produit"];
                id_categorie = (int)monReader["id_categorie_produit"];

                libellé_categorie = monReader["nom_categorie_produit"].ToString();

                uneCategorie = new Categorie(id_categorie, libellé_categorie);

                unProduit = new Produit(code, libellé, uneCategorie, prixht);
                Inventaire.Add(unProduit);

            }

            //Fermeture de la connexion 
            maConnexion.Close();
            return Inventaire;
        }

        public static void deleteProduit(string code_produit)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@code_produit", code_produit));
            cmd.CommandText = "DELETE FROM produit WHERE code_produit = @code_produit";
            SqlDataReader monReader = cmd.ExecuteReader();
            maConnexion.Close();

        }

        public static void addProduit(Produit unProduit)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@libellé_produit", unProduit.Libellé));
            cmd.Parameters.Add(new SqlParameter("@catégorie_produit", unProduit.categorie.Id));
            cmd.Parameters.Add(new SqlParameter("@prixht", unProduit.Prixht));
            cmd.CommandText = "INSERT INTO produit (libelle_produit, id_categorie_produit, prixht_produit) VALUES(@libellé_produit, @catégorie_produit, @prixht)";
            cmd.ExecuteNonQuery();
        }

        public static void editProduit(Produit unProduit)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@code_produit", unProduit.Code));
            cmd.Parameters.Add(new SqlParameter("@libellé_produit", unProduit.Libellé));
            cmd.Parameters.Add(new SqlParameter("@catégorie_produit", unProduit.categorie.Id));
            cmd.Parameters.Add(new SqlParameter("@prixht", unProduit.Prixht));
            cmd.CommandText = " Update produit Set libelle_produit = @libellé_produit, id_categorie_produit = @catégorie_produit, prixht_produit = @prixht where id_categorie_produit = @catégorie_produit";
            cmd.ExecuteNonQuery();
        }
    }
}
