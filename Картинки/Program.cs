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
            int inRow;
            int remainingPictures;
            inRow = 52 / 3;
            remainingPictures = 52 % 3;
            Console.WriteLine(inRow);
            Console.WriteLine(remainingPictures);


        }
    }
}
