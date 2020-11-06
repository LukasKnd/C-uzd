
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[,,] { { { 1,2}, { 3,4} }, { { 5,6}, { 7,8} } };
            printArr(arr);
        }

        static void printArr(System.Array arr)
        {
            List<int> index = new List<int>();
            for (int i = 0; i < arr.Rank; i++)
            {
                index.Add(0);
            }

            printArrHelper(arr, index, 0);


        }

        static void printArrHelper(System.Array arr, List<int> curIndex, int level) 
        {
            for(int i = 0; i <= arr.GetUpperBound(level); i++)
            {
                curIndex[level] = i;

                if(level < curIndex.Count - 1)
                {
                    printArrHelper(arr, curIndex, level + 1);
                } else
                {
                    Console.Write("(");
                    for(int j = 0; j < curIndex.Count; j++)
                    {
                        if(j == curIndex.Count - 1)
                        {
                            Console.Write(curIndex[j] + ") : ");
                        } else
                        {
                            Console.Write(curIndex[j] + ", ");
                        }
                    }
                   
                    Console.Write(arr.GetValue(curIndex.ToArray()));
                    Console.WriteLine();
                }

            }
        }

        

    }
}
