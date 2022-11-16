using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclicInfoBO
{
    public class Produit
    {
        private string _code;
        private string _libellé;
        private string _catégorie;
        private string _prixht;

        public string Code { get => _code; set => _code = value; }
        public string Libellé { get => _libellé; set => _libellé = value; }
        public string Catégorie { get => _catégorie; set => _catégorie = value; }
        public string Prixht { get => _prixht; set => _prixht = value; }


        public Produit(string code, string libellé, string catégorie, string prixht)
        {
            _code = code;
            _libellé = libellé;
            _catégorie = catégorie;
            _prixht = prixht;
        }
    }
}

