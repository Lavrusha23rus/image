using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.сборщик
{
    class Path
    {
        string path = null;
        public string Content
        {
            get
            {return path;}

            set
            {
                for (; !File.Exists(value);)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Не верный путь");
                    Console.ForegroundColor= ConsoleColor.Green;
                    value = Console.ReadLine();
                }
                path = value;
            }
        }
    }
}



///Console.WriteLine("Фаила нет, проверьте правельность указаного пути и попробуйте снова: ");
///path = Console.ReadLine();






