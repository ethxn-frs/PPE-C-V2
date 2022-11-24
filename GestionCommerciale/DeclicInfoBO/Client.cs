using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclicInfoBO
{
    public class Client
    {
        private string _code;
        private string _nom;
        private int _adresse_livraison_client_num;
        private string _adresse_livraison_client_rue;
        private string _adresse_livraison_client_ville;
        private int _adresse_livraison_client_code_postal;
        private int _adresse_facturation_client_num;
        private string _adresse_facturation_client_rue;
        private string _adresse_facturation_client_ville;
        private int _adresse_facturation_client_code_postal;
        private int _telephone;
        private int _fax;
        private string _email;

        public string Code { get => _code; set => _code = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public int Adresse_livraison_client_num { get => _adresse_livraison_client_num; set => _adresse_livraison_client_num = value; }
        public string Adresse_livraison_client_rue { get => _adresse_livraison_client_rue; set => _adresse_livraison_client_rue = value; }
        public string Adresse_livraison_client_ville { get => _adresse_livraison_client_ville; set => _adresse_livraison_client_ville = value; }
        public int Adresse_livraison_client_code_postal { get => _adresse_livraison_client_code_postal; set => _adresse_livraison_client_code_postal = value; }
        public int Adresse_facturation_client_num { get => _adresse_facturation_client_num; set => _adresse_facturation_client_num = value; }
        public string Adresse_facturation_client_rue { get => _adresse_facturation_client_rue; set => _adresse_facturation_client_rue = value; }
        public string Adresse_facturation_client_ville { get => _adresse_facturation_client_ville; set => _adresse_facturation_client_ville = value; }
        public int Adresse_facturation_client_code_postal { get => _adresse_facturation_client_code_postal; set => _adresse_facturation_client_code_postal = value; }
        public int Telephone { get => _telephone; set => _telephone = value; }
        public int Fax { get => _fax; set => _fax = value; }
        public string Email { get => _email; set => _email = value; }

        public Client(string code, string nom, int adresse_livraison_client_num, string adresse_livraison_client_rue,
            string adresse_livraison_client_ville, int adresse_livraison_client_code_postal, int adresse_facturation_client_num,
            string adresse_facturation_client_rue, string adresse_facturation_client_ville, int adresse_facturation_client_code_postal,
            int telephone, int fax, string email)
        {
            Code = code;
            Nom = nom;
            Adresse_livraison_client_num = adresse_livraison_client_num;
            Adresse_livraison_client_rue = adresse_livraison_client_rue;
            Adresse_livraison_client_ville = adresse_livraison_client_ville;
            Adresse_livraison_client_code_postal = adresse_livraison_client_code_postal;
            Adresse_facturation_client_num = adresse_facturation_client_num;
            Adresse_facturation_client_rue = adresse_facturation_client_rue;
            Adresse_facturation_client_ville = adresse_facturation_client_ville;
            Adresse_facturation_client_code_postal = adresse_facturation_client_code_postal;
            Telephone = telephone;
            Fax = fax;
            Email = email;
        }

        public Client(string nom, int adresse_livraison_client_num, string adresse_livraison_client_rue,
           string adresse_livraison_client_ville, int adresse_livraison_client_code_postal, int adresse_facturation_client_num,
           string adresse_facturation_client_rue, string adresse_facturation_client_ville, int adresse_facturation_client_code_postal,
           int telephone, int fax, string email)
        {
            Nom = nom;
            Adresse_livraison_client_num = adresse_livraison_client_num;
            Adresse_livraison_client_rue = adresse_livraison_client_rue;
            Adresse_livraison_client_ville = adresse_livraison_client_ville;
            Adresse_livraison_client_code_postal = adresse_livraison_client_code_postal;
            Adresse_facturation_client_num = adresse_facturation_client_num;
            Adresse_facturation_client_rue = adresse_facturation_client_rue;
            Adresse_facturation_client_ville = adresse_facturation_client_ville;
            Adresse_facturation_client_code_postal = adresse_facturation_client_code_postal;
            Telephone = telephone;
            Fax = fax;
            Email = email;
        }
    }
}