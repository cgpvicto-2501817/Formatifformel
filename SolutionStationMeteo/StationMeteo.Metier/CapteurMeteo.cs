namespace StationMeteo.Metier
{
    /// <summary>
    /// Classe de module de gestion Meteo.
    /// Il valide les données de temperature et d'humidité.
    /// </summary>
    public class CapteurMeteo
    {
        private string _nom;

        public CapteurMeteo(string nom)
        {
            Nom = nom;
        }

        public CapteurMeteo(string nom, int temperature, int humidite) : this(nom)
        {
            Temperature = temperature;
            Humidite = humidite;
        }

        private int _temperature;
        private int _humidite;

        /// <summary>
        /// Le nom est une variable de membre privée de la methode
        /// <Exception>Ne peut pas etre nul ou vide </Exception>
        /// <Exception>Ne doit pas contenir des chiffres</Exception>
        /// <Exception>Si une de ces conditions n'est pas respectée lance un message ARgumentException</Exception>
        /// </summary>
        public string Nom
        {
            get => _nom;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))

                    throw new ArgumentException("Ne peut pas être nul ou vide");

                bool chiffre = true;
                if (ContientDesChiffres(value) == chiffre)
                    throw new ArgumentException("Ne doit pas contenir de chiffres");

                _nom = value;
            }
        }

        /// <summary>
        /// La temperature est une variable 
        /// Elle est bornée autour de -60 et 60
        /// </summary>
        public int Temperature
        {
            get => _temperature;
            private set
            {
                int valeur = value;
                if (valeur < -60)
                    valeur = -60;

                if (valeur > 60)
                    valeur = 60;

                _temperature = valeur;
            }
        }

        /// <summary>
        /// L'humidité est une valeur membre .
        /// La valeur ne peut pas être sous 0% ou plus 100%
        /// </summary>
        public int Humidite
        {
            get => _humidite;
            private set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("La valeur ne peut pas être sous 0% ou plus 100%");
                _humidite = value;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="texte"></param>
        /// <returns></returns>
        private bool ContientDesChiffres(string texte)
        {

            foreach (char c in texte)
            {
                if (char.IsDigit(c))

                    return true;
            }
            return false;

        }


    }
}
