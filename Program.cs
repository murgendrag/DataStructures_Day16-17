using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "heater";
            string str2 = "reahet";

            Char[] ch1 = str1.ToLower().ToCharArray();
            Char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);  

            Console.WriteLine(val1);
            Console.WriteLine(val2); 

            if(val1 == val2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine(" This is not Anagram");
            }
        }
    }
}
