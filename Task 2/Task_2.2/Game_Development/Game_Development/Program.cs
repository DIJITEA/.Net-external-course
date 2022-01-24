using Characters;
using System;

namespace Task2_2
{
    public class Program
    {
        private static string _border = "\u2593\u2593\u2593";
        private static string _tree = " \u2663 ";
        private static string _player = " \u263B ";
        private static string _playerIsHide = "\u2663\u263B\u2663";
        private static string _emptyField = "   ";
        private static string _cyborgKiller = "(\u25ac)";
        private static string _gem = " \u2666 ";
        private static string _gemInForest = "\u2663\u2666\u2663";
        //field scale
        private static string[,] _field = new string[25 + 1, 35 + 1];
        private static int[] _fieldBorder = {_field.GetLength(0), _field.GetLength(1) };
        private static int[] _cyborgPosition;
        private static int[] _playerPosition;
        private static int[] _gemPosition;

        public static int[] playerPosition  { get{ return _playerPosition; } set{_playerPosition=value;} }
        public static int[] cyborgPosition { get { return _cyborgPosition; } set { _cyborgPosition = value; } }
        public static int[] gemPosition { get { return _gemPosition; } set { _gemPosition = value; } }
        public static void Main()
        {
            Player.setborder(_fieldBorder);
            Tree.forestGeneration();


            playerPosition = Player.playerPosition;
            cyborgPosition = Cyborg.cyborgPosition;
            gemPosition = Gem.gemPosition;


            Console.WriteLine($"\n {_border} - border ");
            Console.WriteLine($" {_tree} - tree");
            Console.WriteLine($" {_player} - you ");
            Console.WriteLine($" {_cyborgKiller} - cyborg killer");
            Console.WriteLine($" {_gem} - gem");

            Console.WriteLine("\n You need to find magic gem and save the kingdom");
            Console.WriteLine("\n Be careful! Cyborg is hunting You - John Connor \n");

            Console.WriteLine(" PRESS ENTER TO START");

            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    FieldGenerator();
                }
            } while (cki.Key == ConsoleKey.Escape);
        }

        public static void FieldGenerator()
        {
            for (int i = 0; i < _field.GetLength(0); i++)
            {

                for(int j = 0; j < _field.GetLength(1); j++)
                {
                           
                    _field[i, j] = _emptyField;
                    if (Tree.forest[i, j] == 1)
                        if (i == _playerPosition[0] && j == _playerPosition[1])
                            _field[i, j] = _playerIsHide;
                        else if (i == gemPosition[0] && j == gemPosition[1])
                            _field[i, j] = _gemInForest;
                        else
                            _field[i, j] = _tree;
                    else if (i == 0 || j == 0 || i == _fieldBorder[0] - 1 || j == _fieldBorder[1] - 1)
                        _field[i, j] = _border;
                    else if (i == _gemPosition[0]&& j == _gemPosition[1])
                        _field[i, j] = _gem;
                    //cyborg generation
                    else if (i == _cyborgPosition[0] && j == _cyborgPosition[1])
                        _field[i, j] = _cyborgKiller;
                    //player generation
                    else if (i == _playerPosition[0] && j == _playerPosition[1])
                        _field[i, j] = _player;
                     
                    Console.Write(_field[i, j]);
                }
                Console.WriteLine();
            }
            EventListner();
        }

        private static void EventListner()
        {
            cyborgPosition = Cyborg.cMove();
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.DownArrow)
                {
                    _playerPosition = Player.pMove(1);
                }
                if (cki.Key == ConsoleKey.UpArrow)
                {
                    _playerPosition = Player.pMove(2);  
                }
                if (cki.Key == ConsoleKey.RightArrow)
                {
                    _playerPosition = Player.pMove(3); 
                }
                if (cki.Key == ConsoleKey.LeftArrow)
                {
                    _playerPosition = Player.pMove(4);  
                }
                Console.Clear();
                gemPosition = Gem.gMove();
                cyborgPosition = Cyborg.cMove();
                switch (isWin())
                {
                    case 0:

                        FieldGenerator();
                        break;
                    case 1:
                        resultVoid("YOU KILL CYBORG BY MAGIC GEM");
                        break;
                    case 2:
                        resultVoid("YOU WIN");
                        break;
                    case 3:
                        resultVoid("YOU LOSE");
                        break;

                }
                
                
            } while (cki.Key == ConsoleKey.Escape);
        }

        private static int isWin()
        {
            bool pG = playerPosition[0] == gemPosition[0] && playerPosition[1] == gemPosition[1];
            bool pC = playerPosition[0] == cyborgPosition[0] && playerPosition[1] == cyborgPosition[1];

            if (pG && pC)
            {
                return 1;
            } else if(pG)
            {
                return 2;
            } else if(pC)
            {
                return 3;
            } else
                return 0;
        }
        private static void resultVoid(string result)
        {
            Console.WriteLine(result);
        }

    }

}
