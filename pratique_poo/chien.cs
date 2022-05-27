using System;

namespace pratique_poo
{
    public class Chien : animal
    {
        
        //Attribut
        private int _NrTatouage;



        //Methode
        public void Aboyer()
        {

            Console.WriteLine( Nom +" jappe");
            
        }

        public void courrir()
        {

            Console.WriteLine(Nom +" cour");
            
        }


        public override void AfficheInfo()
        {
            Console.WriteLine("je m'appel " +Nom+"!");
            Console.WriteLine("j'aime japper wouf wouf!");
        }


        // Constructeur

        public Chien(string nom, int age, int nrTatouage) : base(nom, age)
        {
            _NrTatouage = nrTatouage;
        }


        public int NrTatouage
        {
            get => _NrTatouage;
            set => _NrTatouage = value;
        }
    }
}