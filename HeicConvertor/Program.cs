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
                    var partial_output = file.Replace(".heic", ".jpg");
                    var fileName = partial_output.Split(new char[] { '\\' }).LastOrDefault();
                    if (!string.IsNullOrEmpty(fileName)) { image.Write(string.Concat(args[1], @"\", fileName)); }
                }
            }
            Console.ReadLine();
        }
    }
}
