using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode.Helpers
{
    public class VisualHelper
    {
        public static string DumpArray2d(int[,] ar, int spacesForNumber = 3)
        {
            return DumpArray2d(ar, ar.GetLength(1), ar.GetLength(0), spacesForNumber);
        }

        public static string DumpArray2d(int[,] ar, int width, int height, int spacesForNumber = 3)
        {
            StringBuilder sb = new StringBuilder();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    sb.Append(ar[x, y].ToString().PadLeft(spacesForNumber, ' '));
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
