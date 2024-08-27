using System.Numerics;

namespace Banque_FDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banque banc = new Banque();
            Client c1 = new Client(1, "Dupont", "Jean");
            banc.AddClient(c1);

            Compte compte_banc = new Compte(c1);
            Courant compte_cour = new Courant(c1, 2000.0);

            Operation op1 = new Operation(1, 100, 3, "dépot 1");
            compte_banc.AddOperation(op1);

            Operation op2 = new Operation(2, 200, 3, "dépot 2");
            compte_banc.AddOperation(op2);

            Credit cd1 = new Credit(1, 100.0, 1, "Virement de tonton");
            Credit cd2 = new Credit(2, 200.0, 1, "Virement de mamie");

            //Nicolas
            Client c2 = new Client(2, "Sarkozy", "Nicolas");
            banc.AddClient(c2);
            Compte compte_banca = new Compte(c2);
            Courant compte_coura = new Courant(c2, 2000.0);
            Epargne compte_epa = new Epargne(c2, 0.02);

            Operation sal = new Operation(1, 100.0, 1, "Salaire"); //+100 courant
            compte_coura.AddOperation(sal);
            Operation voit = new Operation(2, 50.0, 2, "Plein de la Voiture"); //-50 courant
            compte_coura.AddOperation(voit);
            Operation cou_ep = new Operation(3, 20.0, 2, "De côté"); // -20 courant
            compte_coura.AddOperation(cou_ep);
            Operation ep = new Operation(4, 20.0, 1, "De côté"); // +20 epargne
            compte_epa.AddOperation(ep);
            Operation kdo = new Operation(5, 100.0, 1, "kdo de la banque"); //+ 100 épargne
            compte_epa.AddOperation(kdo);
            Operation ep_cou = new Operation(6, 20.0, 2, "enfaite non"); //-20 épargne
            compte_epa.AddOperation(ep_cou);
            Operation cou = new Operation(7, 20.0, 1, "enfaite non"); //+20 courant
            compte_coura.AddOperation(cou);
            Operation remb = new Operation(8, 200.0, 1, "Remboursement Jérémie"); //+200 courant
            compte_coura.AddOperation(remb);

            double soldeCourNicolas = compte_coura.GetSolde();
            double soldeEpNicolas = compte_epa.GetSolde();
            double decouauto = compte_coura.Getdecauto();
            double taux = compte_epa.GetTaux();
            List<Operation> ops = compte_coura.GetOperations();
            List<Operation> op = compte_epa.GetOperations();

            Console.WriteLine("Solde compte courant de Nicolas : " + soldeCourNicolas);
            Console.WriteLine("Solde compte épargne de Nicolas : " + soldeEpNicolas);




            //Jérémie
            Client c3 = new Client(2, "depain", "Jérémie");
            banc.AddClient(c2);
            Compte compte_banca2 = new Compte(c3);
            Courant compte_coura2 = new Courant(c3, 500.0);

            Operation pc = new Operation(1, 500.0, 2, "Pc"); //-500 courant
            compte_coura2.AddOperation(pc);
            Operation rem = new Operation(2, 200.0, 2, "Remboursement Nicolas"); //-200 courant
            compte_coura2.AddOperation(rem);

            double soldeCourJeremie = compte_coura2.GetSolde();

            Console.WriteLine("Solde compte courant de Jérémie : " + soldeCourJeremie);

            // Résumé Compte nicolas
            Console.WriteLine("Résumé du compte courant de Nicolas");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Solde : " + soldeCourNicolas);
            Console.WriteLine("Découvert autorisé : " + decouauto);
            Console.WriteLine("Opérations :");
            foreach (Operation operation in ops)
            {
                if (operation.TypeOperation == 1)
                {
                    double amount = operation.Amount;
                    Console.WriteLine("+" + amount);
                }
                else if (operation.TypeOperation == 2)
                {
                    double amount = operation.Amount;
                    Console.WriteLine("-" + amount);
                }
            }
            Console.WriteLine("*******************************************");

            Console.WriteLine("Résumé du compte épargne de Nicolas");
            Console.WriteLine("#######################################################");
            Console.WriteLine("Solde : " + soldeEpNicolas);
            Console.WriteLine("Taux : " + taux);
            Console.WriteLine("Opérations :");
            foreach (Operation operation in op)
            {
                if (operation.TypeOperation == 1)
                {
                    double amount = operation.Amount;
                    Console.WriteLine("+" + amount);
                }
                else if (operation.TypeOperation == 2)
                {
                    double amount = operation.Amount;
                    Console.WriteLine("-" + amount);
                }
            }
            Console.WriteLine("#######################################################");







        }
    }
}
