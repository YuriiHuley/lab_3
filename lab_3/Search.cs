using System;
namespace lab_3
{
    public static class Search
    {
        public static void FindMax(string[,] ar)
        {
          
            int x = default(int);
            int max = default(int);
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                if (int.TryParse(ar[i, i], out x))
                {
                    max = Convert.ToInt32(ar[i, i]);
                    break;
                }
            }
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); j++)
                {
                    if (int.TryParse(ar[i, j], out x))
                        max = Math.Max(max, Convert.ToInt32(ar[i, j]));
                }
            }
            if (max != default(int))
            Console.WriteLine("max " + max);
        }
        public static void FindMin(string[,] ar)
        {
            int x = default(int);
            int min = default(int);
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                if (int.TryParse(ar[i, i], out x))
                {
                    min = Convert.ToInt32(ar[i, i]);
                    break;
                }
            }
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); j++)
                {
                    if (int.TryParse(ar[i, j], out x))
                        min = Math.Min(min, Convert.ToInt32(ar[i, j]));
                }
            }

            if (min != default(int)) 
                Console.WriteLine("min " + min);
        }

      public static void FindSymbol(string[,] ar, string symbol)
      {
          for (int i = 0; i < ar.GetLength(0); i++)
          {
              for (int j = 0; j < ar.GetLength(0); j++)
              {
                  if (ar[i, j] == symbol)
                  {
                      symbol = ar[i, j];
                      Console.WriteLine("Symbol in : " + i + ", " + j);
                  }
              }
          }
      }
    }
}