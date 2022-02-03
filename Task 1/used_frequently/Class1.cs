namespace used_frequently
{
    public class UsedFrequently
    {
        public static int Try2Parse()
        {
            int result = 0;
            while (result == 0)
            {
                string UnparsedValue = Console.ReadLine();
                if (Int32.TryParse(UnparsedValue, out result))
                {
                    if (result > 0)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("input can only have numeric values greater than zero");
                        Console.Write("enter the value again: ");
                        result = 0;
                    }

                }
                else
                {
                    Console.WriteLine("input can only have numeric values");
                    Console.Write("enter the value again: ");

                }
            }
            return result;
        }

        public static int Try2ParseLessThenN(int n)
        {
            int result = 0;
            while (result == 0)
            {
                int rtnValue = Try2Parse();
                if (rtnValue <= n)
                {
                    result = rtnValue;
                }
                else
                {
                    Console.WriteLine("the input can't exceed the allowed value (out of range)");
                    Console.Write("enter the value again: ");
                }
            }
            return result;
        }

        public static int[] ArrayRandomize(int arrayLength)
        {
            int[] array = new int[arrayLength];

            for (int i = 0; i < array.Length; i++)
            {   
                array[i] = new Random().Next(-100, 100);
            }
            return array;
        }

        public static int[] QSort (int[] array,int minI, int maxI)
        {
            if(minI >= maxI)
            {
                return array;
            }
            int pivotI = Pivot(array, minI, maxI);

            static int Pivot(int[] array, int minI, int maxI)
            {
                int pivot = minI - 1;
                int tepm = 0;
                for (int i = minI; i <= maxI; i++)
                {
                    if (array[i] < array[maxI])
                    {
                        pivot++;

                        tepm = array[pivot];
                        array[pivot] = array[i];
                        array[i] = tepm;
                    }
                }

                pivot++;
                tepm = array[pivot];
                array[pivot] = array[maxI];
                array[maxI] = tepm;

                return pivot;
            }

            QSort(array, minI, pivotI - 1);
            QSort(array, pivotI + 1, maxI);

            return array;

        }
        
    }
}