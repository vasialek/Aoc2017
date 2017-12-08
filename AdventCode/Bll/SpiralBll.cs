using AdventCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode.Bll
{
    public class SpiralBll
    {
        public int CalculateDistance(int[,] ar, int destinationNumber)
        {
            var center = FindNumberInSpiral(ar, 1);
            var src = FindNumberInSpiral(ar, destinationNumber);

            return Math.Abs(center.Item2 - src.Item2) + Math.Abs(center.Item1 - src.Item1);
        }

        public int[,] GenerateSpiralMemory(int numberToReach)
        {
            int width = GetSpiralWidth(numberToReach);
            int limit = width * width;
            int[,] ar = new int[width, width];
            int x = width / 2;
            int y = width / 2;
            int n = 1;

            int dx = 1;
            int dy = 1;

            ar[x, y] = n++;
            do
            {
                // To the right ->
                for (int i = 0; n <= limit && i < dx; i++)
                {
                    ar[++x, y] = n++;
                }
                dx++;
                //Console.WriteLine(VisualHelper.DumpArray2d(ar, width, width, 4));

                // To top 
                for (int i = 1; n <= limit && i <= dy; i++)
                {
                    ar[x, --y] = n++;
                }
                dy++;
                //Console.WriteLine(VisualHelper.DumpArray2d(ar, width, width, 4));

                // To left <-
                for (int i = 0; n <= limit && i < dx; i++)
                {
                    ar[--x, y] = n++;
                }
                dx++;
                //Console.WriteLine(VisualHelper.DumpArray2d(ar, width, width, 4));

                // Down
                for (int i = 0; n <= limit && i < dy; i++)
                {
                    ar[x, ++y] = n++;
                }
                dy++;

                //Console.WriteLine(VisualHelper.DumpArray2d(ar, width, width, 4));
            } while (n < limit);

            return ar;
        }


        public Tuple<int, int> FindNumberInSpiral(int[,] ar, int number)
        {
            for (int y = 0; y < ar.GetLength(0); y++)
            {
                for (int x = 0; x < ar.GetLength(1); x++)
                {
                    if (ar[x, y] == number)
                    {
                        return new Tuple<int, int>(x, y);
                    }
                }
            }

            return null;
        }

        public int GetSpiralWidth(int numberToReach)
        {
            int w = (int)Math.Ceiling(Math.Sqrt(numberToReach));
            // Need odd width to fit in both directions
            return w % 2 == 0 ? w + 1 : w;
        }
    }
}
