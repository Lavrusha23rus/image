using ConsoleApp9.сборщик;

namespace ConsoleApp9.Covector
{
    using System.Text;
    using System.Drawing;
    using System.Drawing.Imaging;
    internal class Program
    {



        static void Main(string[] args)

        {
            FormatChange formatChange = new FormatChange();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("введите путь фаила");
            formatChange.Path = Console.ReadLine();

            Console.WriteLine(" Укажите высоту изображения: ");

            formatChange.HeightImageh = formatChange.OnliNumber();


            Console.WriteLine("\nУкажите длину изображения: ");
            formatChange.WidthImageh = formatChange.OnliNumber();


            Console.WriteLine("\nУкажите формат сохраняемого фаила bmp, gif, exif, jpg, png или tiff");
            formatChange.Format = Console.ReadLine();

            Console.WriteLine("Назовите новый фаил:");
            formatChange.FileName = Console.ReadLine();

            formatChange.ProcessExecution();





            GC.Collect();

            Console.ReadKey();



        }
    }
}