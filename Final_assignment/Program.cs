using System;
using System;

namespace Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express! Please fallow the instruction bellow.");
            Console.WriteLine("Please inter the wieght of your package here:");
            int packWieght = Convert.ToInt32(Console.ReadLine());

            if (packWieght > 50)
            {
                Console.WriteLine("Sorry, it too heavey to be shipped by Express. Have a good day.");
                //Program ends here if the package is more than 50.

            }
            else if (packWieght < 50)
            {
                Console.WriteLine("Please inter the package wiedth:");
                int packWiedht = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please inter the package hieght:");
                int packHieght = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please inter the package lenth:");
                int packLenth = Convert.ToInt32(Console.ReadLine());

                if (Convert.ToInt32(packWiedht) + Convert.ToInt32(packHieght) + Convert.ToInt32(packLenth) > 50)
                {
                    Console.WriteLine("Sorry, too big to be shipped.");
                    //Program ends here if the box dimention total is more than 50.
                }
                else
                {
                    Console.WriteLine("The Shipping fee that you should pay is:");

                    int ShippingFee = Convert.ToInt32(packWiedht) * Convert.ToInt32(packHieght) * Convert.ToInt32(packLenth) * Convert.ToInt32(packWieght) / 100;
                    Console.WriteLine(ShippingFee);


                }

                Console.WriteLine("Thank you!");
            }
            Console.ReadLine();

        }
    }
}