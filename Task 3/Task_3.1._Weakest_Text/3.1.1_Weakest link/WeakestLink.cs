using used_frequently;

namespace _3._1._1_Weakest_link
{
    public class WeakestLink
    {
        private static string[] PersonName = { "Yui", "Mio", "Ritsu", "Tsumugi", "Azusa"};
        private static string[] PersonSurname = { "Hirasawa", "Akiyama", "Tainaka", "Kotobuki", "Nakano" };
        private static List<string> persons = new List<string>();
        private static int roundLength;
        public void Main()
        {
            Console.Clear();
            Console.Write("Circle length: ");
            roundLength = UsedFrequently.Try2Parse();
            CreateList(roundLength);
            ListLog();
            Round();
        }
        private static void CreateList(int roundLength)
        {
            
            for (int i = 0; i < roundLength; i++)
            {
                persons.Add($"{PersonName[new Random().Next(0, PersonName.Length)]} {PersonSurname[new Random().Next(0, PersonSurname.Length)]}");
            }
        }
        private static void Round()
        {
            Console.Write("\nEnter eluminated position: ");
            int OutOnPosition = UsedFrequently.Try2ParseLessThenN(roundLength) - 1;

                Console.Write("\nThe round has begun");
            while (OutOnPosition <= persons.Count-1)
            {
                Console.WriteLine($"\nBye, {persons[OutOnPosition]} {persons.Count - 1} still in the game ");
                persons.RemoveAt(OutOnPosition);

            }
            Console.WriteLine($"\nGame over\n--winners--");
            ListLog();
            Console.WriteLine("\n-----------");
            Console.WriteLine("Press ENTER to start a new Round");
                ConsoleKeyInfo cki;
                do
                {
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Enter)
                    {
                        persons.Clear();
                        WeakestLink weakestList = new WeakestLink();
                        weakestList.Main();
                    }
                } while (cki.Key != ConsoleKey.Escape);
            
        }
        private static void ListLog()
        {
            if (persons.Count != 0)
            {
                foreach (string s in persons)
                {
                    Console.Write($"\n{s}");
                }
            }   else
            {
                Console.Write("\nno one...");
            }
            Console.WriteLine();
        }

    }
}