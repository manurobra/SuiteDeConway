namespace SuiteDeConway
{
    public class Program
    {
        static void Main(string[] args)
        {
            (int nbDepart, int nbLignes) = ChoixUtilisateur();

            Console.WriteLine();

            Console.WriteLine("-------------------");
            Console.WriteLine($"La ligne n°{nbLignes} se présente comme suit:");
            Console.WriteLine(SuiteDeConway(nbDepart, nbLignes));

            Console.ReadLine();
        }

        static (int, int) ChoixUtilisateur()
        {
            int nbDepart;
            int nbLignes;

            Console.WriteLine("Veuillez entrer le nombre qui démarera la suite de Conway:");
            while (!int.TryParse(Console.ReadLine(), out nbDepart))
            {
                Console.WriteLine("Le format n'est pas correct!");
            }

            Console.WriteLine("Veuillez entrer le nombre de la ligne à afficher:");
            while (!int.TryParse(Console.ReadLine(), out nbLignes))
            {
                Console.WriteLine("Le format n'est pas correct!");
            }

            return (nbDepart, nbLignes);
        }

        static string SuiteDeConway(int premierNombre, int ligne)
        {
            ligne--;
            int i;
            int iti;
            char temp1;
            string ligneChoisie = premierNombre.ToString();

            while (ligne > 0)
            {
                i = 0;
                string tempSuite = "";

                while (i < ligneChoisie.Length)
                {
                    iti = 0;
                    temp1 = ligneChoisie[i];
                    iti++;
                    while (i < (ligneChoisie.Length - 1) && temp1 == ligneChoisie[i + 1])
                    {
                        iti++;
                        i++;
                    }
                    tempSuite += iti;
                    tempSuite += temp1;
                    i++;
                }

                ligneChoisie = tempSuite;
                //peut être activé pour une verification des lignes 2 à n
                //Console.WriteLine(ligneChoisie);

                ligne--;
            }

            return ligneChoisie;
        }
    }
}