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
        public string PaTh
        {
            private get
            {
                if (File.Exists(path))
                return path;
                else
                {
                    return path;
                }

            }

            set
            {
                path = value;
            }

        }
    }
}



    ///Console.WriteLine("Фаила нет, проверьте правельность указаного пути и попробуйте снова: ");
    ///path = Console.ReadLine();






