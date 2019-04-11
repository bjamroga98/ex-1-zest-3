using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1_zest_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Itsy Bitsy Spider";
            string text2 = TrimSpaces(text1);
            Console.WriteLine("Before: " + text1);
            Console.WriteLine("After: " + text2);

            Console.ReadKey();

            /**********************************************/

           
           
        }
        static string TrimSpaces(string text)
        {
            // The final string to store the shortened text
            string textWithoutSpaces = "";

            for (int i = 0; i < text.Length; ++i)
            {
                //if a given char not empty , add it to the final string
                if (text[i] != ' ' && text[i] != '\t' && text[i] != '\n')
                    textWithoutSpaces += text[i];
            }
            return textWithoutSpaces;
        }
    }
}
