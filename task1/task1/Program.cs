//bu kodu men evvelceden yazmisdim amma yuklendiyi qovlugun icindeki basqa bir qovluga salanda proqram itdi ve VS-de acmaqa calisdim acmirdi silinmis oldugunu deyirdi. 

//basa dusurem gec yuklendiyine gore qiymetlendirilmeyecek amma yene de bu koda baxardiz zehmet olmasa.
using System;

namespace task1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // burda arrayi yaradan metod duzeltmek istedim amma vaxtim yox idi onsuz da esas mesele bu deyil.
            int[] num = { };

            Console.WriteLine("Length of the array : ");

            int length = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref num, length);

            Console.WriteLine("numbers : ");

            for (int i = 0; i < length; i++)
            {
                int element = Convert.ToInt32(Console.ReadLine());

                num[i] = element;
            }
            GetMin(num);
        }
        public static void GetMin(int[] num)
        {
            int count = 0;

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    count = 0;
                }
                else
                {
                    Console.WriteLine("min number : " + num[i]);
                }
            }
        }
    }
}
