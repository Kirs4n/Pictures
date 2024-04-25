using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Картинки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pictures = 52;
            int picturesInRow = 3;
            int rows;
            int remainingPictures;
            rows = pictures / picturesInRow;
            remainingPictures = pictures % picturesInRow;
            Console.WriteLine(rows);
            Console.WriteLine(remainingPictures);
        }
    }
}
