/*
* Student ID : 1690702756
* Name       : Lab08
* Section    : 129C
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab08
{
    internal class Program
    {
        // Step 1 : สร้าง Array
        static int[] numbers = { 12, 7, 30, 4, 19, 25, 9, 18 };
        // static int[] numbers = { 9, 18, 62, 3, 85 };
        // static int[] numbers = { 3, 40, 8, 15, 22 };
        // static int[] numbers = { -5, -2, -9 };
        static int sum;
        static float average;
        static int maximum;
        static int minimum;

        static void Main()
        {
            // Step 2 : พิมพ์ตัวเลขทุกตัว
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Number " + (i + 1) + ": " + numbers[i]);
            }
            // Step 3 : ผลรวมและค่าเฉลี่ย
            sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            average = (float)sum / numbers.Length;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            // Step 4 : ค่าสูงสุดและค่าต่ำสุด
            maximum = numbers[0];
            minimum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }
                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }
            Console.WriteLine("Maximum: " + maximum);
            Console.WriteLine("Minimum: " + minimum);
            // Step 5 : เรียงลำดับแล้วพิมพ์อีกครั้ง
            Array.Sort(numbers);
            foreach (int n in numbers)
            {
                Console.WriteLine("Sorted: " + n);
            }

        }
    }
}


