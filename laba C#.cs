using System;

class Program
{
    static void Main(string[] args)
    {
        string[] ProductNames = { "apple", "coffee", "tea", "bread" };
        int[] Prices = { 25, 45, 30, 20 };
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Product: " + ProductNames[i] + " Price: " + Prices[i] + " uah");
        }
    }
}

