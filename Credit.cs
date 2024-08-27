using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_FDD
{
    internal class Credit : Operation
    {
        protected List<Operation> credit;
        public Credit(int id, double amont, int typeOperation, string libelle) : base(id, amont, typeOperation, libelle)
        {
            this.id = id;
            this.typeOperation = typeOperation;
            this.libelle = libelle;
            this.credit = new List<Operation>();
        }

    }
}
