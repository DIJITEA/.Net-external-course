namespace _1._1._5_Sum_of_numbers
{
    public class SumOfNubers
    {
        public static void Main()
        {
            Console.WriteLine("Sum of nubers");
            int sum = 0;
            int goLength = 1000;
            for (int i = 3; i < goLength; i += 3)
            {
                sum = sum + i;            
            }
            for (int j = 5; j < goLength; j += 5)
            {
                if ( j % 3 != 0)
                {
                    sum = sum + j;
                }
            }
            Console.WriteLine(sum);
        }
    }
}