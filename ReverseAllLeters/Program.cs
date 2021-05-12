using System;

namespace ReverseAllLeters
{
    public class Sample
    {
        public static void reverse(char[] ch)
        { 
            int a = ch.Length - 1, b = 0; 
            while (b < a)
            {
                if (!char.IsLetter(ch[b]))
                    b++;
                else if (!char.IsLetter(ch[a]))
                    a--;
                else
                {
                    char temp = ch[b];
                    ch[b] = ch[a];
                    ch[a] = temp;
                    b++;
                    a--;
                }
            }
        }
        public static void Main()
        {
            String str = "ab1c2de345f";
            char[] ArrayList = str.ToCharArray();

            Console.WriteLine("Input string: " + str);
            reverse(ArrayList);
            String reverseStr = new String(ArrayList);

            Console.WriteLine("Output string: " + reverseStr);
        }
    }
}


