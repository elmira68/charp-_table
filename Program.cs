using System;

namespace charp__table
{
    class Program
    {
        static void Main(string[] args)
        {
           int [,] myarray = new int [10,10];
          for (int i = 1; i <=10; i++)
          {
             for (int j = 1; j <=10; j++)
             {
                    // int[] arr = new int[];
                    int Result = i* j;
                Console.Write(Result.ToString() +"\t");
                // Console.Write(myarray[i,j]);
             } 
             System.Console.WriteLine();
          }
                         
           
        }
    }
}
