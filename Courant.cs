using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_FDD
{
    internal class Courant : Compte
    {
        protected double dec_auto;
        public Courant(Client client, double dec_auto) : base(client)
        {
            this.dec_auto = dec_auto;
        }
        public List<Operation> GetOperations()
        {
            return operations;
        }
        public double Getdecauto()
        {
            return this.dec_auto;
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
            return solde;
        }
    }
}
