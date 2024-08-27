using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_FDD
{
    internal class Operation
    {
        protected int id;
        protected double amount;
        protected int typeOperation; //1 = Credit (+) ; 2 = Debit (-)
        protected string libelle;
        public Operation(int id, double amount, int typeOperation, string libelle)
        {
            this.id = id;
            this.amount = amount;
            this.typeOperation = typeOperation;
            this.libelle = libelle;
        }

        public int getId() { return id; }
        public double getAmount() { return amount; }
        public int getTypeOperation() { return typeOperation; }

        internal int TypeOperation
        {
            get
            {
                return typeOperation;
            }
        }

        internal double Amount
        {
            get
            {
                return amount;
            }
        }



    }
}
