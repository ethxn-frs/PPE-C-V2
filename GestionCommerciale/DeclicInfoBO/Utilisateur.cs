using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclicInfoBO
{
    public class Utilisateur
    {
        private int Id_utilisateur;
        private string Nom_utilisateur;
        private string Password_utilisateur;



        public int Id_utilisateur1 { get => Id_utilisateur; set => Id_utilisateur = value; }
        public string Nom_utilisateur1 { get => Nom_utilisateur; set => Nom_utilisateur = value; }

        public string Password_utilisateur1 { get => Password_utilisateur; set => Password_utilisateur = value; }

        public Utilisateur(int id_utilisateur, string nom_utilisateur, string password_utilisateur)
        {
            Id_utilisateur = id_utilisateur;
            Nom_utilisateur = nom_utilisateur;
            Password_utilisateur = password_utilisateur;
        }
    }
}
