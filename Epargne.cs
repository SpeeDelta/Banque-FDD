using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_FDD
{
    internal class Epargne : Compte
    {
        protected double taux;
        public Epargne(Client client, double taux) : base(client)
        {
            this.taux = taux;
        }
        public double GetTaux()
        {
            return taux;
        }
        public List<Operation> GetOperations()
        {
            return operations;
        }

        public double GetSolde()
        {
            double solde = 0;
            foreach (Operation operation in operations)
            {
                if (operation.TypeOperation == 1)
                {
                    solde = solde + operation.Amount;
                }
                else if (operation.TypeOperation == 2)
                {
                    solde = solde - operation.Amount;
                }
                else
                {
                    Console.WriteLine("Les chiffres sont pas bons");
                }
            }
            double interets = solde * taux;
            solde = solde + interets;
            return solde;
        }

    }
}
