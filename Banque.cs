using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_FDD
{
    internal class Banque
    {
        int id;
        private List<Client> clients;
        private List<Compte> comptes;
        public Banque() //Constructeur 
        {
            clients = new List<Client>();
            comptes = new List<Compte>();
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }
        public void AddCompte(Compte compte)
        {
            comptes.Add(compte);
        }

    }
}
