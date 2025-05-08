// See https://aka.ms/new-console-template for more information
using static System.Console;

WriteLine("Selection Sort!!");

int[] unsortedArr = [4,2,3,9,0,1,11,90,100,46];
int[] sortedArr = SelectionSort(unsortedArr);

foreach(int item in sortedArr)
    Write($"{item}, ");

int[] SelectionSort(int[] myArr)
{
    for(int i = 0; i < myArr.Length - 1; i++)
    {
        int min = i;
        
        for(int j = i + 1; j < myArr.Length; j++)
        {
            if(myArr[min] > myArr[j])
            {
                min = j;
            }
        }
        
        if(min != i)
        {
            int temp = myArr[i];
            myArr[i] = myArr[min];
            myArr[min] = temp;
        }
    }
    
    return myArr;
}