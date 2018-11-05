using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HeicConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // args[0] = path to analyse
            foreach (var file in Directory.GetFiles(args[0], "*.heic", SearchOption.AllDirectories))
            {
                using (ImageMagick.MagickImage image = new ImageMagick.MagickImage(file))
                {
                    // I:\tmp\IMG_0935.heic
                    var output = file.Replace(".heic", ".jpg");
                    image.Write(output);
                }
            }
            Console.ReadLine();
        }
    }
}
