using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;

namespace ConsoleApp9.сборщик
{
    internal class FormatChange
    {
        Path path = null;
        Size heightimage = null;
        Size widthimage = null;
        FileName fileName = null;
        Format format = null;
        public FormatChange()
        {
            this.path = new Path();
            this.heightimage = new Size();
            this.widthimage = new Size();
            this.format = new Format();
            this.fileName = new FileName(format);

        }
        public string Path
        {
            set { this.path.Content = value; }
        }

        public int HeightImageh
        {
            set { this.heightimage.Content = value; }
        }
        public int WidthImageh
        {
            set { this.widthimage.Content = value; }
        }
        public string Format
        {
            set { this.format.Content = value; }
        }
        public string FileName
        {
            set { this.fileName.Content = value; }
        }
       public void ProcessExecution()
        {
            Image image = Image.FromFile(path.Content);
            Bitmap image2 = new Bitmap(image, height: heightimage.Content, width: widthimage.Content);

            switch (format.Content)
            {
                case "bmp":
                    image2.Save($"{@"C:\Users\Алекс\Pictures\"}{fileName.Content}{"."}{ImageFormat.Bmp}");
                    Console.WriteLine("Фаил сохранен C:\\Users\\Алекс\\Pictures");
                    break;
                case "gif":
                    image2.Save($"{@"C:\Users\Алекс\Pictures\"}{fileName.Content}{"."}{ImageFormat.Gif}");
                    Console.WriteLine("Фаил сохранен C:\\Users\\Алекс\\Pictures");
                    break;
                case "exif":
                    image2.Save($"{@"C:\Users\Алекс\Pictures\"}{fileName.Content}{"."}{ImageFormat.Exif}");
                    Console.WriteLine("Фаил сохранен C:\\Users\\Алекс\\Pictures");
                    break;
                case "jpg":
                    image2.Save($"{@"C:\Users\Алекс\Pictures\"}{fileName.Content}{"."}{ImageFormat.Jpeg}");
                    Console.WriteLine("Фаил сохранен C:\\Users\\Алекс\\Pictures");
                    break;
                case "png":
                    image2.Save($"{@"C:\Users\Алекс\Pictures\"} {fileName.Content}{"."}{ImageFormat.Png}");
                    Console.WriteLine("Фаил сохранен C:\\Users\\Алекс\\Pictures");
                    break;
                case "tiff":
                    image2.Save($"{@"C:\Users\Алекс\Pictures\"} {fileName.Content}{"."}{ImageFormat.Tiff}");
                    Console.WriteLine("Фаил сохранен C:\\Users\\Алекс\\Pictures");
                    break;
            }

        }
        public int OnliNumber()
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
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("вы ничего не ввели ");
                        Console.ForegroundColor=ConsoleColor.Green;
                        continue;
                    }
                    else
                    {
                        int Numbers = Convert.ToInt32(@string.ToString());
                        return Numbers;

                    }


                }
                //if (keyPress.Key ==  ConsoleKey.Backspace)
                //{
                //    @string.Clear(@string);
                //    continue;
                //}
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
