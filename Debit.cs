using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_FDD
{
    internal class Debit : Operation
    {
        public Debit(int id, double amount, int typeOperation, string libelle) : base(id, amount, typeOperation, libelle)
        {
            this.id = id;
            this.amount = amount;
            this.typeOperation = typeOperation;
            this.libelle = libelle;
        }
    }
}
