// See https://aka.ms/new-console-template for more information
using static System.Console;

WriteLine("Insertion Sort!!");

int[] arr = [9,0,5,9,10,20,35,2];
int[] sortedArr = InsertionSort(arr);

foreach(int item in sortedArr)
    Write($"{item}, ");

// The outer loop...the unsorted sublist
// myArr[0] is considered the sorted sublist
// [9,2,9,0]
int[] InsertionSort(int[] myArr)
{
    for(int i = 1; i < myArr.Length; i++)
    {
        int temp = myArr[i]; // temp is 2, i is 1
        int j = i - 1; // j is 0
    
        while(j >= 0 && myArr[j] > temp) //9 > 2
        {
            myArr[j + 1] = myArr[j]; //myArr[1] = myArr[0]; assign 9 to index 1
            j--;
        }
    
        // After execution of the loop, here j is -1
        // -1 + 1 = 0
        // myArr[0] = 2;
        myArr[j + 1] = temp; // myArr[1] = 2;
    }
    
    return myArr;
}