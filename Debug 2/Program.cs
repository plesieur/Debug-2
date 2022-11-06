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

            for (int i = 1; i <= phoneticAlphabet.Length; i++)
            {
                Console.WriteLine(phoneticAlphabet[i]);
            }
        }
    }
}
