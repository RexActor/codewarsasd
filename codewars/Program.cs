using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            #region alphabet location
            /*
            string x = "";

            Console.WriteLine("please enter sentence");
            x = Console.ReadLine();

            char[] m;
            m = x.ToCharArray();
            string text="";
      
            foreach (var c in m)
            {
                if (c.Equals(null))
                {
                    return;
                }

                //Console.Write(char.ToUpper(c) - 64);

                int position = char.ToUpper(c) - 64;

                if (position < 0)
                {

                }
                else
                {
                    text = text + " " + position;
                }

            }
            text = text.Substring(1);
            Console.WriteLine(text);
            Console.ReadLine();
            */

            #endregion

            #region find longest/shortest word in text
            /*
            string text = "";
            Console.WriteLine("Please enter text");

            text = Console.ReadLine();


            String[] stringarray = text.Split(' ');
            int lengthOfWord = 0;
            string word = "";

            /*
            for (int i = 0; i < stringarray.Length; i++)
            {

                if (stringarray[i].Length > lengthOfWord)
                {
                    lengthOfWord = stringarray.Length;
                    word = stringarray[i].ToString();
                }
                


            }
            */
            /*
            lengthOfWord = stringarray[0].Length;
            
            foreach (var c in stringarray)
            {


                if (c.Length < lengthOfWord)
                {
                    word = c;
                    lengthOfWord = c.Length;
                }

                //Console.WriteLine($"{c}");


            }

            Console.WriteLine($"{lengthOfWord} //and// {word}");
            Console.ReadLine();
            */
            #endregion

        }
    }
}
