namespace ConsoleApp9
{
    using System.Text;
    using System.Drawing;
    using System.Drawing.Imaging;
    internal class Program
    {
        static string Name ( string format)
        {
            var name = Console.ReadLine();
            while (File.Exists($@"C:\Users\Алекс\Pictures\{name}.{format}"))
            {
                Console.WriteLine("Фаил с таким именем уже существует, придумайте другое имя: ");
                continue;
            }
            return name;
        }
        static string Format()
        {
            var Format = Console.ReadLine().ToLower();

            while ((Format != "bmp") && (Format != "gif") && (Format != "exif") && (Format != "jpg") && (Format != "pnp") && (Format != "tiff"))
            {
                Console.WriteLine("неверный формат! Попробуйте снова: ");
                Format = Console.ReadLine().ToLower();
                continue;
            }
            return Format;
        }
        static string Path()
        {
            var path = Console.ReadLine();

            while (!File.Exists(path))
            {
                Console.WriteLine("Фаила нет, проверьте правельность указаного пути и попробуйте снова: ");
                path = Console.ReadLine();
                continue;
            }
            return path;
        }
        static int OnliNumbers()
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
        static void Main(string[] args)

        {
            
            Console.WriteLine("введите путь фаила");
            var path = Path();

            Console.WriteLine(" Укажите высоту изображения: ");
            var HeightImage = OnliNumbers();

            Console.WriteLine("\nУкажите длину изображения: ");
            var WidthImage = OnliNumbers();

            Console.WriteLine("\nУкажите формат сохраняемого фаила bmp, gif, exif, jpg, png или tiff.");
            var format = Format();

            Console.WriteLine("Назовите новый фаил: ");
            var name = Name(format);



            Image image = Image.FromFile(path);
            Bitmap image2 = new Bitmap(image, height: HeightImage, width: WidthImage);

            switch (format)
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
             
            GC.Collect();
            
            Console.ReadKey();



        }
    }
}