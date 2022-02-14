namespace _3._2._2_Super_array
{
    public class Super_array
    {
        int[] SuperArray;
        public Super_array()
        {
            SuperArray = new int[0];
        }
        public Super_array(int[] value)
        {
            SuperArray = new int[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                SuperArray[i] = value[i];
            }
        }

        public int Sum()
        {
            int temp = 0;
            foreach (int item in this.SuperArray)
            {
                temp += item;
            }
            return temp;
        }
        public double Mean()
        {
            double result = Convert.ToDouble(this.SuperArray.Sum())/(this.SuperArray.Length);
            return result;
        }
        public int closestToTheMean()
        {
            int result = 0;
            double tempMean = Math.Round(Mean(), MidpointRounding.AwayFromZero); ;
            double min = this.SuperArray.Max() - tempMean;
            for (int i = 0; i < this.SuperArray.Length; i++)
            {
                if (this.SuperArray[i] - tempMean < min && this.SuperArray[i] - tempMean >= 0)
                {
                    result = this.SuperArray[i];
                    min = result - tempMean;
                }
            }
            return result;
        }


        public int MostFrequent()
        {
            Dictionary<int, int> tempDictionary = new Dictionary<int, int>();
            for (int i = 0; i < this.SuperArray.Length; i++)
            {
                if (!tempDictionary.ContainsKey(this.SuperArray[i]))
                {
                    tempDictionary.Add(this.SuperArray[i], 1);
                }
                else tempDictionary[this.SuperArray[i]]++;
            }
            var MaxKV = (from e in tempDictionary select e.Value).Max();
            foreach (var item in tempDictionary)
            {
                if (item.Value == MaxKV)
                {
                    return item.Key;
                }
            }
            //var MaxV = MaxKV.Value;
            return 0;
        }


    }
}