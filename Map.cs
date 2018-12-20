using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxRpg
{
    class Map 
    {
        public int Largeur;
        public int Longueur;
        public string nom;
        public Case[,] Plateau;
        //public ClassHero hero;
        
        

        public Map(int largeur, int longueur)
        {
            Largeur = largeur;
            Longueur = longueur;
            
            Plateau = new Case[largeur, longueur];
           

            


            for (int i = 0; i<largeur;i++)
            {
                for(int j =0; j<longueur;j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Plateau[0, 0] = new Case(0, 0, Case.CaseType.Ecole, "boss");
                    }
                    else if (i == 9 && j == 9)
                    {
                        Plateau[9, 9] = new Case(9, 9, Case.CaseType.Maison, "Start");
                        
                         

                    }

                    else if (j % 4 == 0)
                    {
                        Plateau[i, j] = new Case(i, j, Case.CaseType.Maison, "^^");
                    }
                    else
                    {
                        Plateau[i, j] = new Case(i, j, Case.CaseType.Gare, "train");
                    }


                    
                }
    
            
            Console.WriteLine();
            }
          

        }

        public void PrintMap(string HeroName)
        {
 
            
            for (int i = 0; i < Largeur; i++)
            {
                for (int j = 0; j < Longueur; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.Write("ECOLE ");
                    }
                    else if (i == 9 && j == 9)
                    { 

                        Console.Write(HeroName);
                           
                    }

                    else if (j % 4 == 0)
                    {
                        Console.Write("  ^^  ");
                    }
                    else
                    {
                        Console.Write("train ");
                    } 



                }


                Console.WriteLine();
            }
        }
      

    }
}
