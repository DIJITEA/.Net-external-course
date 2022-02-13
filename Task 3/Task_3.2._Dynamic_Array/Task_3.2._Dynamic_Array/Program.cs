using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            var people = new List<string>() { "Tom", "Bob", "Sam" };
            DynamicArray<string> test = new DynamicArray<string>(people);
            Console.WriteLine(test.Length() + " -- Length");
            test.Remove(1);

            test[0] = "Bot";

            test.testConsoleReturn();

            test.AddRange(people);

            Console.WriteLine("----------");

            test.testConsoleReturn();
            Console.WriteLine(test.Length() + " -- Length");
            Console.WriteLine(test.Capacity() + " -- Capacity");
            Console.WriteLine(test[0] + "test [0]");
        }
    }

    public class DynamicArray<T>
    {
        T[] dynamicArray;
        public T this[int index]
        {
            get { return dynamicArray[index]; }
            set { dynamicArray[index] = value; }
        }
        public DynamicArray()
        {
            dynamicArray = new T[8];
        }
        public DynamicArray(int length)
        {
            dynamicArray = new T[length];
        }
        public DynamicArray(IEnumerable<T> data)
        {
            dynamicArray = new T[data.Count()];
            foreach (T el in data)
            {
                Add(el);
            }
        }
        public void Add(T el)
        {
            int index = Length();
            if (index == this.dynamicArray.Length)
            {
                T[] tempArray = new T[this.dynamicArray.Length + 1];
                for (int i = 0; i < this.dynamicArray.Length; i++)
                {
                    tempArray[i] = this.dynamicArray[i];
                }
                this.dynamicArray = tempArray;
            } 
                
            this.dynamicArray[index] = el;  
        }
        public void AddRange(IEnumerable<T> data)
        {
            if((data.Count() + Length()) > Capacity())
            {
                T[] tempArray = this.dynamicArray;
                this.dynamicArray = new T[Length() + data.Count()];
                foreach (T el in tempArray)
                {
                    Add(el);
                }
            }
            foreach (T el in data)
            {
                Add(el);
            }
        }

        public bool Remove(int ElIndex)
        {
            if (ElIndex <0 || ElIndex >= this.dynamicArray.Length)
            { return false; }
            T[] temp = this.dynamicArray;
            T[] tempEmpty = new T[1];
            this.dynamicArray = new T[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                if (i < ElIndex || i > ElIndex) Add(temp[i]); // error if "i != ElIndex"
                else { Add(tempEmpty[0]);
                }
            }
            return true;
        }

        public int Length()
        {
            int length = 0;
            foreach (var i in  this.dynamicArray)
            {
                if (i != null)
                    length++;
            }
            return length;
        }
        public int Capacity()
        {
            return this.dynamicArray.Length;
        }

        public void testConsoleReturn()
        {
            for (int i = 0; i < this.dynamicArray.Length; i++)
            {
                Console.WriteLine(this.dynamicArray[i]);
            }
        }

    }

}