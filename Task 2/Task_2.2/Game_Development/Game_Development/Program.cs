using Characters;
using System;

namespace Task2_2
{
    public class Program
    {
        private static string _border = "\u2593\u2593\u2593";
        private static string _tree = " \u2663 ";
        private static string _you = " \u263B ";
        private static string _emptyField = "   ";
        private static string _cyborgKiller = "(\u25ac)";
        private static string[,] _field = new string[25 + 1, 35 + 1];
        private static int[] _fieldBorder = {_field.GetLength(0), _field.GetLength(1) };
        private static int[] _cyborgPosition;
        private static int[] _playerPosition;
        
        public static int[] playerPosition  { get{ return _playerPosition; } set{_playerPosition=value;} }
        public static int[] cyborgPosition { get { return _cyborgPosition; } set { _cyborgPosition = value; } }
        public static void Main()
        {
            Player.setborder(_fieldBorder);
 
            
            playerPosition = Player.playerPosition;
            cyborgPosition = Cyborg.cyborgPosition;
            
            
            Console.WriteLine($"{_border} - border ");
            Console.WriteLine($"{_tree} - tree");
            Console.WriteLine($"{_you} - you ");
            Console.WriteLine($"{_emptyField} - empty field ");
            Console.WriteLine($"{_cyborgKiller} - cyborg killer");

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
                    if (i == 0 || j == 0 || i == _fieldBorder[0]-1 || j == _fieldBorder[1]-1)
                        _field[i, j] = _border;
                    //cyborg generation
                    else if (i == _cyborgPosition[0] && j == _cyborgPosition[1])
                        _field[i, j] = _cyborgKiller;
                    //player generation
                    else if (i == _playerPosition[0] && j == _playerPosition[1])
                        _field[i, j] = _you;
                     
                    Console.Write(_field[i, j]);
                }
                Console.WriteLine();
            }
            EventListner();
        }

        private static void EventListner()
        {
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
                cyborgPosition = Cyborg.cMove();
                FieldGenerator();
                
            } while (cki.Key == ConsoleKey.Escape);
        }

    }

}
