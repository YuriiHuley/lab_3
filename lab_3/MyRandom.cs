using System;
namespace lab_3
{
    public static class MyRandom
    {
        //1.1
        public static string[,] RandomIntegerArray(int N)
        {
            string[,] ar = new string[N, N];
            Random random = new Random();
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); j++)
                {
                    ar[i, j] = random.Next(0, 100).ToString();
                }
            }

            return ar;
        }

        //1.2.1 
        public static string[,] IntervalEvenArray(int N, int n, int m)
        {
            Random random = new Random();
            int t;
            string[,] ar = new string[N, N];

            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); j++)
                {
                   
                    while (true)
                    {
                        t = random.Next(n, m);
                        if (t % 2 == 0)
                        {
                            ar[i, j] = t.ToString();
                            break;
                        }
                    }
                }
            }

            return ar;
        }

        //1.2.2
        public static string[,] IntervalOddArray(int N, int n, int m)
        {
            Random random = new Random();
            int t;
            string[,] ar = new string[N, N];

            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); j++)
                {
                    while (true)
                    {
                        t = random.Next(n, m);
                        if (t % 2 != 0)
                        {
                            ar[i, j] = t.ToString();
                            break;
                        }
                    }
                }
            }

            return ar;
        }

        //1.3 любі символи
        public static string[,] RandomCharArray(int N)
        {
            string[,] ar = new string[N, N];
            Random random = new Random();

            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); j++)
                {
                    ar[i, j] = Convert.ToChar(random.Next(33, 47)).ToString();
                }
            }
            return ar;
        }
    

    // 1.4
        public static string[,] RandomLettersArray(int N)
        {
            string [,] ar = new string[N, N];
            Random random = new Random();
            
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); j++)
                {
                    ar[i,j] = Convert.ToChar(random.Next(97, 122)).ToString();
                }
            }

            return ar;
        }
    }
}