using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.сборщик
{
    internal class Format
    {
        string format = null;
        public string Content
        {
            get
            {
                return format;
            }
            set
            {
                for (; value != "bmp" && value != "gif" && value != "exif" && value != "jpg" && value != "png" && value != "tiff";)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Не верный формат: ");
                    Console.ForegroundColor= ConsoleColor.Green;
                    value = Console.ReadLine();
                }
                format = value;
            }
        }

    }

}
