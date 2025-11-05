namespace Array_Questions_Solutions
{
    internal class Program
    {
        static void Main()
        {
            SecondLargestInArray();
        }
        // put the name of the method you want to execute in the Main method
        static void inputArray()
        {
            Console.WriteLine("Eenter any 5 Inter Values ");
            int[] nums = new int[5];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Printing Integer 5 values ");
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
        // put the name of the method you want to execute in the Main method
        public static void allsumarray()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            Console.WriteLine("Sum of all array elements is: " + sum);
        }
        // put the name of the method you want to execute in the Main method
        static void MaxArray()
        {
            int[] nums = { 10, 25, 8, 56, 12 };
            int Max = int.MinValue;
            foreach (int num in nums)
            {
                if (num > Max)
                {
                    Max = num;
                }
            }
            Console.WriteLine("Maximum value in the array is: " + Max);
        }
        // put the name of the method you want to execute in the Main method
        static void minArray()
        {
            int[] nums = { 10, 25, 8, 56, 12 };
            int Min = int.MaxValue;
            foreach (int num in nums)
            {
                if (num < Min)
                {
                    Min = num;
                }
            }
            Console.WriteLine("Minimum value in the array is: " + Min);
        }
        // put the name of the method you want to execute in the Main method
        static void positive_negativeArray()
        {
            int[] nums = { 1, -2, 3, -4, 5, -6 };
            int positive = 0;
            int negative = 0;
            foreach (int num in nums)
            {
                if (num > 0)
                {
                    positive++;
                }
                else if (num < 0)
                {
                    negative++;
                }

            }
            Console.WriteLine("Number of positive elements: " + positive);
            Console.WriteLine("Number of negative elements: " + negative);
        }
        // put the name of the method you want to execute in the Main method
        static void reverseArray()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            for (int num = nums.Length - 1; num >= 0; num--)
            {
                Console.WriteLine(nums[num]);
            }
        }
        // put the name of the method you want to execute in the Main method
        static void checkingTargetArray()
        {
            int[] nums = { 1, 5, 7, 9 };
            int target = 7;
            int Index = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    Index = i;
                    break;
                }
            }
            if (Index != -1)
            {
                Console.WriteLine("Target found at index: " + Index);
            }
            else
            {
                Console.WriteLine("Target not found in the array.");
            }
        }
        // put the name of the method you want to execute in the Main method
        static void EveneOddArray()
        {
            int[] nums = { 2, 5, 8, 11, 14 };
            int Even = 0;
            int Odd = 0;
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    Even++;
                }
                else if (!(num % 2 == 0))
                {
                    Odd++;
                }
            }
            Console.WriteLine("Number of Even elements: " + Even);
            Console.WriteLine("Number of Odd elements: " + Odd);
        }
        // put the name of the method you want to execute in the Main method
        public static void averagearray()
        {
            int[] nums = { 10, 20, 30, 40 };
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            sum = sum / nums.Length;
            Console.WriteLine("Average of all array elements is: " + sum);
        }
        // put the name of the method you want to execute in the Main method
        static void CopyoneArraytoAnother()
        {
            int[] real = { 10, 20, 30, 40, 50 };
            int [] copy = new int[real.Length];
            for (int nums= 0; nums < real.Length; nums++)
            {
                copy[nums] = real[nums];
            }
            Console.WriteLine("Real array elements: ");
            foreach (int num in real)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Copied array elements: ");
            foreach (int num in copy)
            {
                Console.WriteLine(num);
            }
        }
        // Now moves to intermediate  level array questions
        static void SecondLargestInArray()
        {

            int[] nums = { 10, 25, 8, 56, 12 };
              int max = int.MinValue;
            int smax = int.MinValue;
            for(int num = 0;num<nums.Length;num++)
            {
                if (nums[num] >max)
                {
                    smax = max;
                    max = nums[num];
                }
            }
            Console.WriteLine(smax);
        }
        




























































































































































     }
}