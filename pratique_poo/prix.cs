namespace pratique_poo
{
    public class prix
    {
        
        string IDPRIX;
        string Description;
        double Valeur;
        double DonMinimum;
        int Qnte_Originale;
        int Qnte_Disponible;
        string IDCommanditaire;


        public prix(string idprix, string description, double valeur, double donMinimum, int qnteOriginale, int qnteDisponible, string idCommanditaire)
        {
            IDPRIX = idprix;
            Description = description;
            Valeur = valeur;
            DonMinimum = donMinimum;
            Qnte_Originale = qnteOriginale;
            Qnte_Disponible = qnteDisponible;
            IDCommanditaire = idCommanditaire;
        }

        public string Idprix
        {
            get => IDPRIX;
            set => IDPRIX = value;
        }

        public string Description1
        {
            get => Description;
            set => Description = value;
        }

        public double Valeur1
        {
            get => Valeur;
            set => Valeur = value;
        }

        public double DonMinimum1
        {
            get => DonMinimum;
            set => DonMinimum = value;
        }

        public int QnteOriginale
        {
            get => Qnte_Originale;
            set => Qnte_Originale = value;
        }

        public int QnteDisponible
        {
            get => Qnte_Disponible;
            set => Qnte_Disponible = value;
        }

        public string IdCommanditaire
        {
            get => IDCommanditaire;
            set => IDCommanditaire = value;
        }
    }
}