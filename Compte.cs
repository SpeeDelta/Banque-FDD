using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_FDD
{
    internal class Compte
    {
        protected List<Client> clients; // Tous les clients
        protected List<Operation> operations; // Ttes les opérations faites sur compte = Historique des opérations
        protected Banque banque;

        public Compte(Banque banque)
        {
            this.banque = banque;
            banque.AddCompte(this);
        }

        public Compte(Client client)
        {
            this.clients = new List<Client>();
            this.operations = new List<Operation>();

            clients.Add(client);
            client.AddCompte(this);
        }
        public void AddOperation(Operation operation)
        {
            operations.Add(operation);
        }
    }
}
