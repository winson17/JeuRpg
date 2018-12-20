using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JeuxRpg
{
    class Menu
    {
        public Menu()
        {
            PrintMenu();
            int Choix = AskChoice(0, 3);
            switch(Choix)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                   Load();
                   break;
                case 2:
                    APropos();
                    break;
                case 3:
                    Quit();
                    break;

            }
        }


        public void PrintMenu()
        {
            Console.Write("=============Menu Principal============= \n" +
                "0 - Start Game \n" +
                "1 - Load Game \n" +
                "2 - A propos \n" +
                "3 - Quittez ");
            
        }

        public static int AskChoice(int min, int max)
        {
            //TODO faire le choix du joueur
            Console.WriteLine("\n choix ? :");
            int result = int.Parse( Console.ReadLine() );
            while(result > max || result <min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;


        }

        public void StartGame()
        {
            Game g = new Game();
            g.StartGame();
            g.Deplacement();



          }

        public void Load()
        {

        }

        public void APropos()
        {

        }

        public void Quit()
        {

        }
    }

}
