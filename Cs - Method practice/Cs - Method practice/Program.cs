using System;

namespace Cs___Method_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Eded: ");
            //string numStr = Console.ReadLine();
            //int num = Convert.ToInt32(numStr);

            //Console.WriteLine("Quvvet: ");
            //string powerStr = Console.ReadLine();
            //int power = Convert.ToInt32(powerStr);
 
            //Console.WriteLine(Pow(num, power));

            int[] numbers = { 10,12,13 };
            Console.WriteLine(Sum(numbers));

        }


        //- Verilmiş ədədin verilmiş qüvvətini tapan metod
        //static int Pow(int num, int power)
        //{
        //    int result = 1;
        //    for (int i = 0; i < power; i++)
        //    {
        //        result *= num;
        //    }
        //    return result;
        //}

        //- Verilmiş 3 ədəddən ən böyüyünü tapan metod
        //static int FindBiggest(int num1, int num2, int num3)
        //{
        //    if (num1 > num2)
        //    {
        //        if(num1 > num3)
        //        {
        //            return num1;
        //        }
        //        else
        //        {
        //            return num3;
        //        }
        //    }
        //    else if (num2 > num3)
        //    {
        //        return num2;
        //    }
        //    else
        //    {
        //        return num3;
        //    }
        //}

        // - Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan metod
        //static int FindBiggest(int[] numbers)
        //{
        //    int max = numbers[0];
        //    for(int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] > max)
        //        {
        //            max = numbers[i]; 
        //        }
        //    }

        //    return max;
        //}

        // - Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan metod
        static int Sum(int[] numbers)
        {
            var sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
