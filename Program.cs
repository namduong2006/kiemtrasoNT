using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songuyento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int number,t=0;
            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Số cần kiểm tra là: "+number);
            if (number<2) Console.WriteLine($"Số {number} không phải là số nguyên tố"); 
            if (number >=2)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        t++;
                        Console.WriteLine($"Số {number} chia hết cho "+i);
                    }
                }
                if (t == 2) Console.WriteLine($"Số {number} là số nguyên tố");
                else Console.WriteLine($"Số {number} không phải là số nguyên tố");
            }
            Console.ReadLine();

        }
    }
}
