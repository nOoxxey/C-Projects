﻿namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bal = int.Parse(Console.ReadLine());
            int withdraw = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            if (withdraw < bal)
            {
                Console.WriteLine("The withdraw was successful.");
            }
            else if (withdraw > limit) 
            {
                Console.WriteLine("The limit was exceeded.");
            }
            else if (withdraw > bal)
            {
                Console.WriteLine("Insufficient availability.");
            }
        
        
        
        
        }


    }
}