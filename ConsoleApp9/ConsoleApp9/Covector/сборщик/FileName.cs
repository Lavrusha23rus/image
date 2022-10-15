using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.сборщик
{
    internal class FileName
    {
       private Format format =null;

        string filename=null;
        public FileName (Format format)
            {
            this.format = format;
            }
        public string Content
        {
            get
            {
                return filename;
            }
            set
            {
                for  (; File.Exists($@"C:\Users\Алекс\Pictures\{value}.{format.Content}");)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("фаил с таким именем уже существует! придумаете другое имя фаилу: ");
                    Console.ForegroundColor= ConsoleColor.Green;
                    value = Console.ReadLine();
                    
                }
                Console.WriteLine($"{value}.{format.Content}");
                filename = value;
            }
        }


    }
}
