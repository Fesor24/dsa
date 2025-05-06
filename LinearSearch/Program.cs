// See https://aka.ms/new-console-template for more information
using static System.Console;

WriteLine("Hello, World!");

WriteLine(LinearSearch([3, 2, 1, 0], 3));
WriteLine(LinearSearch([3, 2, 1, 0], 99));
WriteLine(LinearSearch([3, 2, 1, 0], 0));


int LinearSearch(int[] myArr, int searchNumber)
{
    for(int i = 0; i <myArr.Length; i++)
    {
        if(myArr[i] == searchNumber)
            return i;
    }

    return -1;
}