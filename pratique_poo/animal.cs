using System;

namespace pratique_poo
{
    public class animal
    {
        //Attributs
         private string nom;
        private int age;
        
        
        
        //Methode de classes
       public virtual void AfficheInfo()
        {

            Console.WriteLine("je suis "+ nom);
            Console.WriteLine("j'ai "+age+" an(s).");
            
        }

       public animal(string nom, int age)
       {
           this.nom = nom;
           this.age = age;
       }

       public string Nom
       {
           get => nom;
           set => nom = value;
       }

       public int Age
       {
           get => age;
           set => age = value;
       }
    }
}