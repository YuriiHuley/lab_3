using System;


namespace lab_3
{
    class Program
    {
        
        //2.1 max
        
       
        static void ShowArray(string[,] ar)
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                Console.WriteLine();

                for (int j = 0; j < ar.GetLength(0); j++)
                {
                    Console.Write(ar[i, j] + " ");
                }
            }
            
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int N , n, m ;
            string type, searchchar;
            bool exit = false;
            Console.Write("Enter parametr of matrix ");
            N = Convert.ToInt32(Console.ReadLine());
            string[,] array = new string[N,N];
            string[,] randomArray = new string[N,N];
            
            while (!exit)
            {
                Console.Write("Enter how to fill in the array (symbols/numbers/letters/even interval/odd inreval )  ");
                type = Console.ReadLine();

                switch (type)
                {
                    case "symbols":
                        randomArray = MyRandom.RandomCharArray(N);
                        exit = true;
                        break;
                    
                    case "numbers":
                        randomArray = MyRandom.RandomIntegerArray(N);
                        exit = true;
                        break;
                    
                    case "letters":
                        randomArray = MyRandom.RandomLettersArray(N);
                        exit = true;
                        break;
                    
                    case "even interval":
                        Console.Write("Enter first number: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter last number: ");
                        m = Convert.ToInt32(Console.ReadLine());
                        randomArray = MyRandom.IntervalEvenArray(N, n, m);
                        exit = true;
                        break;
                    
                    case "odd interval":
                        Console.Write("Enter first number: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter last number: ");
                        m = Convert.ToInt32(Console.ReadLine());
                        randomArray = MyRandom.IntervalOddArray(N, n, m);
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Error input, try again!");
                        break;      
                    }
            }
            
            while (true)
            {
                Console.Write("Enter symbol to find ");
                searchchar = Convert.ToString(Console.ReadLine());
                if (searchchar.Length > 1)
                {
                    Console.WriteLine("Error, print again!");
                }
                else
                {
                    break;
                }
            }

            Area.LefDownTriangle(array, randomArray);
            ShowArray(array); 
            Search.FindMax(array);
            Search.FindMin(array);
            Search.FindSymbol(array, searchchar);
            Area.EmptyMatrix(array);
          
            Area.RightUpTriangle(array, randomArray);
            ShowArray(array);
            Search.FindMax(array);
            Search.FindMin(array);
            Search.FindSymbol(array, searchchar);
            Area.EmptyMatrix(array);

            Area.UpTriangle(array, randomArray);
            ShowArray(array);
            Search.FindMax(array);
            Search.FindMin(array);
            Search.FindSymbol(array, searchchar);
            Area.EmptyMatrix(array);

            Area.LeftTriangle(array, randomArray);
            ShowArray(array);
            Search.FindMax(array);
            Search.FindMin(array);
            Search.FindSymbol(array, searchchar);
            Area.EmptyMatrix(array);

        }
    }
}