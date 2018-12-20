using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxRpg
{
    class Game
    {
        public ClassHero hero;
        

        public Map plateau;
       


        public Game()
        {
           
        }

        public void StartGame()
        {
            
            Console.WriteLine("Choissiez votre genre ");
            Console.Write(
               "\n0 - Garçon \n" +
               "1 -Fille \n" +
               "2 -Transgenre \n" +
               "3 -RETOUR MENU PRINCIPAL");
            int choix = Menu.AskChoice(0, 3);

            switch (choix)
            {
                case 0:
                    Console.WriteLine("vous avez chosis Garçon etes-vous sur de votre choix ? ");
                    Console.WriteLine(" 0/ OUI  " +
                        "1/ NON ");
                    int choix1 = Menu.AskChoice(0, 1);
                    switch (choix1)
                    {
                        case 0:
                            Console.WriteLine("Choissiez votre pseudo ");
                            string a = Console.ReadLine();
                            hero = new Garcon(a);
                            Console.WriteLine("bonjour ! " +hero.Name + 
                                " Vous etes un jeune etudiant et votre mission est d'arrivé au plus vite a votre ecole. " +
                                "ATTENTION : Vous allez rencontrer des problemes bonne chance a vous ! ");
                           
                            Map plateau = new Map(10, 10);
                            plateau.PrintMap(hero.Name);

                            ;
                            break;
                        case 1:
                            StartGame();
                            break;
                    }
                    break;

                case 1:
                    Console.WriteLine("vous avez chosis fille etes-vous sur de votre choix ? ");
                    Console.WriteLine(" 0/ OUI  " +
                        "1/ NON ");
                    int choix2 = Menu.AskChoice(0, 1);
                    switch(choix2)
                    {
                        case 0:
                            Console.WriteLine("Choissiez votre pseudo ");
                            string a = Console.ReadLine();
                            ClassHero hero = new fille(a);
                            Console.WriteLine("bonjour ! " + hero.Name +
                                " Vous etes une jeune etudiante et votre mission est d'arrivé au plus vite a votre ecole. " +
                                "ATTENTION : Vous allez rencontrer des problemes bonne chance a vous ! ");
                            Map plateau = new Map(10, 10);
                            plateau.PrintMap(hero.Name);

                            Console.WriteLine(plateau);
                         
                            break;
                        case 1:
                            StartGame();
                            break;
                            


                    }
                    break;

                case 2:
               
                    Console.WriteLine("vous avez chosis Transgenre etes-vous sur de votre choix ? ");
                    
                    Console.WriteLine(" 0/ OUI  " +
                        "1/ NON ");
                    int choix3 = Menu.AskChoice(0, 1);

                    switch (choix3)
                    {
                        case 0:
                            Console.WriteLine("Choissiez votre pseudo ");
                            string a = Console.ReadLine();
                            ClassHero hero = new Trans(a);
                            Console.WriteLine("bonjour ! " + hero.Name +
                                " Vous etes un jeune etudiant(e) et votre mission est d'arrivé au plus vite a votre ecole. " +
                                "ATTENTION : Vous allez rencontrer des problemes bonne chance a vous ! ");
                            Map plateau = new Map(10, 10);
                            plateau.PrintMap(hero.Name);

                            Console.WriteLine(plateau);
                            
                            ;
                            break;
                        case 1:
                            StartGame();
                            break;
                    }
                    break;
                case 3:
                    Menu menu = new Menu();
                    Console.WriteLine(menu);
                    break;
            }

        }

    
        public void Deplacement()
        {
            int x = 9;
            int y = 9;
            int Largeur = 10;
            int Longueur = 10;
           
            while (x > 0 && y > 0)
            {
                ClassHero.Position = new Case[x, y];
                printChoix();

               int Choix = Menu.AskChoice(0, 4);
                
                 for (int i = 0; i < Largeur; i++)
                    {
                    for (int j = 0; j < Longueur; j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            Console.Write("ECOLE ");
                        }
                        else if (i == x && j == y)
                        {
                            switch (Choix)
                            {
                                case 0 :
                                    x--;
                                    y=9;
                                   
                                    
                                    
                                    break;
                                case 1:
                                    
                                    y++;
                                   
                                    break;
                                case 2 :
                                    x++;
                                                                       
                                    break;
                                case 3:
                                    x = x;
                                    y--;
                                    
                                    break;
                           

                            }
                              Console.Write(hero.Name);   

                         
                           
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


            //TODO Recuperer la case
            //TODO Tester le contenu de la case
            //TODO peut être lancer un combat..

        }
        public static void printChoix()
        {
            Console.WriteLine("chosir un deplacement");
            Console.WriteLine("0/ Nord \n" +
                "1/ EST \n" +
                "2/ SUD \n" +
                "3/ OUEST ");



        }

    }
}
