using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.сборщик
{
    internal class Numbers
    {
        
        public int NumBres()
        {
            StringBuilder @string = new StringBuilder();

            while (true)
            {
                ConsoleKeyInfo keyPress = Console.ReadKey(true);
                char input = keyPress.KeyChar;

                if (keyPress.Key == ConsoleKey.Enter)

                {
                    if (string.IsNullOrEmpty(@string.ToString()))
                    {
                        Console.WriteLine("вы ничего не ввели ");
                        continue;
                    }
                    else
                    {
                        int Numbers = Convert.ToInt32(@string.ToString());
                        return Numbers;
                    }


                }
                if (char.IsControl(input))
                {
                    continue;
                }

                if (char.IsDigit(input))
                {
                    @string.Append(input);
                    Console.Write(input);
                    continue;
                }
            }
        }
    }
}
