namespace _3._2._2_Super_array
{
    public class Super_array_Delegates
    {
        public delegate int IntDelegate(int[] array);
        public delegate double DoubleDelegate(int[] array);
    }

    public class Super_array
    {
        public int Sum(int[] SuperArray)
        {
            int temp = 0;
            foreach (int item in SuperArray)
            {
                temp += item;
            }
            return temp;
        }
        public double Mean(int[] SuperArray)
        {
            double result = Convert.ToDouble(SuperArray.Sum())/(SuperArray.Length);
            return result;
        }
        public int ClosestToTheMean(int[] SuperArray)
        {
            int result = 0;
            double tempMean = Math.Round(Mean(SuperArray), MidpointRounding.AwayFromZero); ;
            double min = SuperArray.Max() - tempMean;
            for (int i = 0; i < SuperArray.Length; i++)
            {
                if (SuperArray[i] - tempMean < min && SuperArray[i] - tempMean >= 0)
                {
                    result = SuperArray[i];
                    min = result - tempMean;
                }
            }
            return result;
        }


        public int MostFrequent(int[] SuperArray)
        {
            Dictionary<int, int> tempDictionary = new Dictionary<int, int>();
            for (int i = 0; i < SuperArray.Length; i++)
            {
                if (!tempDictionary.ContainsKey(SuperArray[i]))
                {
                    tempDictionary.Add(SuperArray[i], 1);
                }
                else tempDictionary[SuperArray[i]]++;
            }
            var MaxKV = (from e in tempDictionary select e.Value).Max();
            foreach (var item in tempDictionary)
            {
                if (item.Value == MaxKV)
                {
                    return item.Key;
                }
            }
            return 0;
        }


    }
}