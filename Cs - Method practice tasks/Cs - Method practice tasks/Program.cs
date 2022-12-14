using System;
using System.Reflection;

namespace Cs___Method_practice_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            int[] numbers = { 12, 26, 45 };
            Console.WriteLine(FindBiggest(numbers));
            #endregion


            #region Task4
            //Console.WriteLine("Yazini daxil edin: ");
            //string text = Console.ReadLine();
            //char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //Console.WriteLine(HasNum(digits, text));
            #endregion



            #region Task 5
            //string[] texts = { "Ram1l", "T0fiq", "Abbas", "N4rm7n" };
            //Console.WriteLine(CountNum(digits, texts));
            #endregion

        }

        //- Verilmiş ədədlər siyahısındaki ən böyük ədədin yerləşdiyi index-i qaytaran metod
        static int FindBiggest(int[] numbers)
        {
            int max = numbers[0];
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    index = i;
                }
            }
            return index;
        }

        //- Verilmiş yazılar siyahısındaki(string array) verilmiş yazının yerləşdiyi indexi qaytaran metod.Əgər verilmiş string array-de verilmiş string dəyər yoxdursa -1 qaytarsın
        //- Verilmiş ədədlər siyahısındaki ədədlərin yalnız müsbət olanlarından ibarət yeni bir array qaytaran metod.Yəni metodu işə salın { 4,-5,3,-2,6}ədədlərindən ibarət array göndərsəm metod geriyə {4,3,6} ədədlərindən ibarət array qaytarmalıdır
        //- Verilmiş yazıda rəqəm olub olmadığını qaytaran metod
        static bool HasNum(char[] digits, string text)
        {
           bool hasDigit = false;
           for(int i = 0; i < text.Length;i++)
            {
                for(int j = 0; j < digits.Length; j++)
                {
                    if (text[i] == digits[j])
                    {
                        hasDigit = true;
                        break;
                    }
                }
            } 
           return hasDigit;
        }

        //- Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
        static int CountNum(char[] digits, string[] texts)
        {
            int count = 0;
            for (int i = 0; i < texts.Length; i++)
            {
                for (int j = 0; j < digits.Length; j++)
                {
                    for (int n = 0; n < texts[i].Length; n++)
                    {
                        if (texts[i][n] == digits[j])
                        {
                            count++;
                            break;
                        }
                    }
                    
                }
            }
            return count;
        }
    }
}
