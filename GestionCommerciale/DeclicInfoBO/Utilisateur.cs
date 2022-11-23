using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclicInfoBO
{
    public class Utilisateur
    {
        private string Nom_utilisateur;
        private string Password_utilisateur;



        public string Nom_utilisateur1 { get => Nom_utilisateur; set => Nom_utilisateur = value; }

        public string Password_utilisateur1 { get => Password_utilisateur; set => Password_utilisateur = value; }

        public Utilisateur(string nom_utilisateur, string password_utilisateur)
        {
            Nom_utilisateur = nom_utilisateur;
            Password_utilisateur = password_utilisateur;
        }
    }
}
