namespace JeuNombreMystere;

public class InterractionUtilisateur
{
    public static int demanderEntierintervale(string prompt, int debut, int fin)
    {
        Console.Write(prompt);
        int nombre = 0;
        bool valid = false;
        while (!valid)
        {
            try
            {
                nombre = int.Parse(Console.ReadLine());
                if (nombre< debut || nombre>fin)
                {
                    throw new Exception("");
                }
                else
                {
                    valid = true;
                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Veuillez saisir un nombre entier entre {debut} et {fin-1}.");
            }
        }
        return nombre;
    }

    public static string continuerOuArreterProgramme(string prompt)
    {
        Console.WriteLine(prompt);
        bool valid = false;
        string reponseUtilisateur = "";
        while (!valid)
        {
            try
            {
                reponseUtilisateur = Console.ReadLine();
                // Si la réponse n'est ni "oui" ni "non", on lève une exception
                if (!(reponseUtilisateur.Equals("oui") || reponseUtilisateur.Equals("non")))
                {
                    throw new Exception("🛑Erreur, veuillez choisir 'oui' pour faire une partie et 'non' pour arrêter le programme.");
                }

                valid = true; // Si c'est "oui" ou "non", on sort de la boucle
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // Affiche le message d'erreur
            }
        }
        return reponseUtilisateur; // Retourne la réponse valide
    }

}