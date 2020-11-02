using System;

namespace odev_3hafta_uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            // x=20,y=13 ve z=42 için aşağıdaki mantıksal ifadelerin doğru veya yanlış olduklarını ekrana yazınız.

            int x = 20, y = 13 , z = 42;
           
            if (23 == 55 && 76 > 45 && 5 < 12)
            {
               Console.WriteLine("Sonuç Doğrudur");
            } else Console.WriteLine("Sonuç Yanlıştır");
            //////////////////////////////////////////////////////  
            if (23 >= 55 && 45!=18)
            {
                Console.WriteLine("Sonuç Doğrudur");
            }
            else Console.WriteLine("Sonuç Yanlıştır");
            /////////////////////////////////////////////////////
            if (23 == 55 && 76 > 45 && 5 < 12)
            {
                Console.WriteLine("Sonuç Doğrudur");
            }
            else Console.WriteLine("Sonuç Yanlıştır");
            ////////////////////////////////////////////////////
            if (x>y&&z==y&&z<x)
            {
                Console.WriteLine("Sonuç Doğrudur");
            }
            else Console.WriteLine("Sonuç Yanlıştır");
            ////////////////////////////////////////////////////
            if (z>x&&y<x)
            {
                Console.WriteLine("Sonuç Doğrudur");
            }
            else Console.WriteLine("Sonuç Yanlıştır");
            ///////////////////////////////////////////////////
            if (x!=z||y<=z)
            {
                Console.WriteLine("Sonuç Doğrudur");
            }
            else Console.WriteLine("Sonuç Yanlıştır");
            Console.ReadKey();
        }
    }
}
