using System;
using System.Collections.Generic;
using System.Text;

namespace TestingTaskJustMobi
{
    class Converter
    {
        public int ConvertNumber()
        {
            bool isConverted = false;
            int number;

            do
            {
                if (isConverted == false)
                {
                    Console.WriteLine("Введите число:");
                }

                isConverted = Int32.TryParse(Console.ReadLine(), out number);

            }
            while (isConverted == false);

            return number;
        }
    }
}
