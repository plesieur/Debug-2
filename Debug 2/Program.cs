using System;

namespace Debug_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phoneticAlphabet =  {  "Alpha", "Beta", "Charlie", "Delta", "Echo", "Foxtrot", "Golf",
                                            "Hotel","India","Juliett","Kilo","Lima","Mike","November",
                                            "Oscar","Papa","Quebec","Romeo","Sierra","Tango",
                                            "Uniform","Victor","Whiskey","X-Ray","Yankee","Zulu"};

            int[,] dataTable = new int[3, 5]
            {
                {0, 1, 2, 4, 5},
                {10, 11, 12, 14, 15},
                {20, 21, 22, 24, 25}
            };

            for (int i = 1; i <= phoneticAlphabet.Length; i++)
            {
                Console.WriteLine(phoneticAlphabet[i]);
            }
            for (int i=0;  i < 5; i++)
            {
                for (int j=0; j < 3; j++)
                {
                    Console.Write("{0} ",dataTable[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
