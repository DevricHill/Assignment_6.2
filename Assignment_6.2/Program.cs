namespace Assignment_6._2
{
    internal class Program
    {
        static void StackWithArray()
        {
            StackArray<int> stack = new StackArray<int>(5);
            stack.Push(5);
            stack.Push(43);
            stack.Push(78);

            Console.WriteLine($"Stack is pushing 5 then 43 then 78");

            Console.WriteLine($"Popping {stack.Peek()}");

            stack.Pop();

            stack.Push(47);

            Console.WriteLine("Pushing 47\n\nStack Displayed: ");
            stack.Display();
        }

 
        static int[] ProductOfArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            Dictionary<int, int> zeros = new Dictionary<int, int>();

            int total = 1;

            for(int i  = 0; i < array.Length; i++)
            {
                if( array[i] != 0)
                {
                    total *= array[i];
                }
                else
                {
                    zeros.Add(i, 0);
                }
            }

            for(int i =0; i < newArray.Length; i++)
            {
                if(zeros.Count > 1)
                {
                    newArray[i] = 0;
                }
                else if(zeros.ContainsKey(i))
                {
                    newArray[i] = total;
                }
                else if (zeros.Count == 1)
                {
                    newArray[i] = 0;
                }
                else
                {
                    newArray[i] = total / array[i];
                }


            }


            return newArray;
        }

        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        static void Print()
        {
            Console.WriteLine("Creating Custom StackArray!\n");
            StackWithArray();

            int[] array1 = { 1, 2, 3, 4 }, array2 = { -1, 1, 0, -3, 3 };

            

            Console.Write("This is a Product Array Program\n\nOriginal: ");
            PrintArray(array1);

            Console.Write("Products of Array: ");
            PrintArray(ProductOfArray(array1));

            Console.Write("\nOriginal: ");
            PrintArray(array2);

            Console.Write("Products of Array: ");
            PrintArray(ProductOfArray(array2));
        }

        static void Main(string[] args)
        {
            Print();
        }
    }
}
