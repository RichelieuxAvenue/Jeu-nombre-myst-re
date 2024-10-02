namespace JeuNombreMystere;

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        bool is_on = true;
        while (is_on)
        {
            string continuer = InterractionUtilisateur.continuerOuArreterProgramme("Veuillez saisir 'oui' pour continuer, 'non' pour couper le programme: ");
            if (continuer == "non")
            {
                is_on = false;
                continue;
            }
            int life = 5;
            int nombreMystere = random.Next(1, 5);
            while (life>0)
            {
                Console.WriteLine($"Vous avez {life}❤️");
                int tentativeUtilisateur = InterractionUtilisateur.demanderEntierintervale("Veuillez sasir un nombre entre 1 et 10: ", 1, 11);
                if (tentativeUtilisateur == nombreMystere)
                {
                    Console.WriteLine($"🎊Félicitation vous avez gagné le nombre mystère était bien {nombreMystere}🎊");
                    break;
                }
                else
                {
                    if (tentativeUtilisateur > nombreMystere)
                    {
                        Console.WriteLine($"🛑{tentativeUtilisateur} est trop grand.😭");
                    }
                    if(tentativeUtilisateur < nombreMystere)
                    {
                        Console.WriteLine($"🛑{tentativeUtilisateur} est trop petit.😭");
                    }
                    life -= 1;
                }
            }
        }
    }
}