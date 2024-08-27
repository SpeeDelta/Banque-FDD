using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_FDD
{
    internal class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private List<Compte> comptes;

        public Client(int id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.comptes = new List<Compte>();
        }
        public void AddCompte(Compte compte)
        {
            comptes.Add(compte);
        }
    }
}
