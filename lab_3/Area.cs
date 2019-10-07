namespace lab_3
{
    public static class Area
    {
        public static string[,] Transponation( string [,] ar)
        {
            string[,] tar = new string[ar.GetLength(0),ar.GetLength(0)];
            
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); j++)
                {
                    tar[j, i] = ar[i, j];
                }
            }
            
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); j++)
                {
                    ar[i, j] = tar[i, j];
                }
            }

            return tar;
        }
        
        //1
        public static string[,] LefDownTriangle(string[,] ar, string[,] arCopy)
        {
            
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); j++)
                {
                    if (i >= j)
                    {
                        ar[i, j] = arCopy[i, j];
                    }
                    else
                    {
                        ar[i, j] = " ";
                    }
                }
            }
            return ar;
        }
        //2
        public static string[,] RightUpTriangle(string[,] ar,string[,] arCopy)
        {
            
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); j++)
                {
                    if (i <= j)
                    {
                        ar[i, j] = arCopy[i, j];
                    }
                    else
                    {
                        ar[i, j] = " ";
                    }
                }
            }
            return ar;
            
        }
        //7
        public static string[,] LeftTriangle(string[,] ar, string[,] arCopy)
        {
           return Transponation(UpTriangle(ar, arCopy));
        }
       
        //8
        public static string[,] UpTriangle(string[,] ar, string[,] arCopy)
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); j++)
                {
                    if ((i == j && i + j < ar.GetLength(0)) || ((i < j) && (i + j < ar.GetLength(0))))
                    {
                        ar[i, j] = arCopy[i, j];
                    }
                    else
                    {
                        ar[i, j] = " ";
                    }
                }
            }
            return ar;
        }
        public static void EmptyMatrix(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    array[i, j] = "";
                }
            }
            
        }
    }
}