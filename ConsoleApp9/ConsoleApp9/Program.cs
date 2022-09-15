namespace ConsoleApp9
{
    using System.Drawing;
    using System.Drawing.Imaging;
    internal class Program
    {

        static void Main(string[] args)

        {

            Console.WriteLine("введите путь фаила");
            var path = Console.ReadLine();

            while (!File.Exists(path))
            {
                Console.WriteLine("Фаила нет, проверьте правельность указаного пути и попробуйте снова: ");
                path = Console.ReadLine();
                continue;
            }

            Console.WriteLine("укажите высоту изображения: ");
            var h = Console.ReadLine();

            while (h != null)
            {

                Console.WriteLine("Укажите высоту мзображения: ");
                h = Console.ReadLine();
                continue;
            }

            int H = Convert.ToInt32(h);

            Console.WriteLine("Укажите длину изображения: ");
            var l = Console.ReadLine();
            while (l != null)
            {
                Console.WriteLine("Укажите длину мзображения: ");
                l = Console.ReadLine();
                continue;
            }
            int L = Convert.ToInt32(l);

            Console.WriteLine("Назовите новый фаил: ");
            var name = Console.ReadLine();
            while (!File.Exists(name))
            {

            }
            Console.WriteLine("Укажите формат сохраняемого фаила bmp, gif, exif, jpg, png или tiff.");
            string Format = Console.ReadLine().ToLower();

            while ((Format != "bmp") && (Format != "gif") && (Format != "exif") && (Format != "jpg") && (Format != "pnp") && (Format != "tiff"))
            {
                Console.WriteLine("неверный формат! Попробуйте снова: ");
                Format = Console.ReadLine().ToLower();
                continue;
            }
            Image image = Image.FromFile(path);
            Bitmap image2 = new Bitmap(image, height: H, width: L);

            switch (Format)
            {
                case "bmp":
                    image2.Save($"{@"C:\Users\Алекс\Pictures\"} {name}{"."}{ImageFormat.Bmp}");
                    Console.WriteLine("Фаил сохранен C:\\Users\\Алекс\\Pictures");
                    break;
                case "gif":
                    image2.Save($"{@"C:\Users\Алекс\Pictures\"} {name}{"."}{ImageFormat.Gif}");
                    Console.WriteLine("Фаил сохранен C:\\Users\\Алекс\\Pictures");
                    break;
                case "exif":
                    image2.Save($"{@"C:\Users\Алекс\Pictures\"} {name}{"."} {ImageFormat.Exif}");
                    Console.WriteLine("Фаил сохранен C:\\Users\\Алекс\\Pictures");
                    break;
                case "jpg":
                    image2.Save($"{@"C:\Users\Алекс\Pictures\"} {name}{"."} {ImageFormat.Jpeg}");
                    Console.WriteLine("Фаил сохранен C:\\Users\\Алекс\\Pictures");
                    break;
                case "png":
                    image2.Save($"{@"C:\Users\Алекс\Pictures\"} {name}{"."} {ImageFormat.Png}");
                    Console.WriteLine("Фаил сохранен C:\\Users\\Алекс\\Pictures");
                    break;
                case "tiff":
                    image2.Save($"{@"C:\Users\Алекс\Pictures\"} {name}{"."} {ImageFormat.Tiff}");
                    Console.WriteLine("Фаил сохранен C:\\Users\\Алекс\\Pictures");
                    break;
            }
            Console.ReadKey();



        }
    }
}