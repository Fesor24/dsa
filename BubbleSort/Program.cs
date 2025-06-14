﻿// See https://aka.ms/new-console-template for more information
using static System.Console;

Console.WriteLine("Bubble Sort!!!");

int[] myArr = [4,2,3,9,0];
int[] sortedArr = BubbleSort(myArr);

foreach(int item in sortedArr)
    Write(item);

int[] BubbleSort(int[] myArr)
{
    // outer loop for the passes
    // minus 1 bcos, number of passes is (number of elements - 1)
    for(int i = 0; i < myArr.Length - 1; i++)
    {
        // We keep track of if there's a swap within the iterations of a pass
        bool swapped = false;
    
        // the number of iterations in a pass is (number of elements - 1)
        // we add '-i' bcos the more number of passes, the less comparison within subsequent passes...
        for(int j = 0; j < myArr.Length - 1 - i; j++)
        {
            if(myArr[j] > myArr[j + 1])
            {
                int temp = myArr[j];
                myArr[j] = myArr[j + 1];
                myArr[j + 1] = temp;
                swapped = true;
            }
        }
        
        if(!swapped) break;
    }
    
    return myArr;
}