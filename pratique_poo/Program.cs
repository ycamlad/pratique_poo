using System;

namespace pratique_poo
{
    class Program
    {
        static void Main(string[] args)
        {

            animal mon_animal = new animal("bob",3);

          //   mon_animal.Nom = "bob";
            // mon_animal.age = 3;

            animal mon_animal2 = new animal("charlie",4);
                
            // mon_animal2.nom = "charlie";
            // mon_animal2.age = 4;

            // mon_animal.AfficheInfo();
            // mon_animal2.AfficheInfo();
            // Console.WriteLine("nom: "+mon_animal.nom+"\n"+"Age: "+mon_animal.age);
            // Console.WriteLine("nom: "+mon_animal2.nom+"\n"+"Age: "+mon_animal2.age);


            Chien le_chien = new Chien("carl", 5, 45689);
             le_chien.AfficheInfo();   
            le_chien.Aboyer();
            le_chien.courrir();

            poisson le_poisson = new poisson("fish",2,true);
            
            
             le_poisson.AfficheInfo();
            le_poisson.eau();
            
            



        }
    }
    
    
    
}