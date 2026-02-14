using StationMeteo;
using StationMeteo.Metier;

namespace StationMeteo.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CapteurMeteo v = new CapteurMeteo("Capteur_Nord",12,-10);
            Console.WriteLine(v.Nom);
            Console.WriteLine(v.Temperature);
            Console.WriteLine(v.Humidite);

        }
    }
}
