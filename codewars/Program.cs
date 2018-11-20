using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    class Program
    {


        public static string CreateArraY(int numbers)
        {
            Random z = new Random();

            string text = "";

            for (int i = 1; i <= numbers; i++)
            {
                int y = z.Next(i, i * 20);
                text = $"{text} {y}";
            }

            return text;
        }
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


            #region sort array
            /*
            //String[] test = CreateArraY(20).Split(' ');

            int[] test = new int[] { 1, 5, 8,6, 20, 58, 669, 47, 2, 668, };
       

            Console.WriteLine("Before Sorting");

            foreach (var m in test)
            {
                Console.Write($"{m} ");
            }



            //Array.Sort(test, (x, y) => y.CompareTo(x));
            //test = test.OrderBy(i => i);

            Array.Sort(test,(x,y)=>y.CompareTo(x));


            Console.WriteLine();

            foreach (var c in test)
            {
                Console.Write($" {c} ");
            }

            
            Console.ReadLine();

    */
            #endregion


            string x = String.Empty;
            Console.WriteLine("enter text");
            x = Console.ReadLine();

            String[] stringArray = x.Split(' ');

            foreach (var c in stringArray)
            {
                

            }
        }


    }
}
