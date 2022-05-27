using System;

namespace pratique_poo
{
    public class poisson : animal
    {
        //Attribut(s)
        private bool eauFroide;
        
        
        //Constructeur(s)
        public poisson(string nom, int age, bool eauFroide) : base(nom, age)
        {
            this.eauFroide = eauFroide;
        }
        
        //Methode(s)


        public void eau()
        {
            if (eauFroide)
                Console.WriteLine(Nom+" vie dans l'eau froide");
            
            else
                Console.WriteLine(Nom+" vie dans l'eau chaude");
            
        }
    }
}