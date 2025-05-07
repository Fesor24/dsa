// See https://aka.ms/new-console-template for more information
using static System.Console;

WriteLine("Binary Search!!!");

int[] myArr = {1,2,3,4,5,6,7,8,9,10};
WriteLine(BinarySearch(myArr, 5));
WriteLine(BinarySearch(myArr, 11));
WriteLine(BinarySearch(myArr, 1));

WriteLine("Binary Search Recursion!!!");
WriteLine(BinarySearchRecursion(myArr, 0, myArr.Length - 1, 5));
WriteLine(BinarySearchRecursion(myArr, 0, myArr.Length - 1, 11));
WriteLine(BinarySearchRecursion(myArr, 0, myArr.Length - 1, 1));

ReadLine();


int BinarySearch(int[] arr, int target)
{
    int left = 0;
    int right = arr.Length - 1;
        
    while(left <= right)
    {
        int mid = (left + right) / 2;
        
        if(arr[mid] == target)
            return mid;
            
        // if value at mid is less than target, we focus on the right half
        else if (arr[mid] < target)
            left = mid + 1;
        
        // else we focus on the left half
        else if (arr[mid] > target)
            right = mid - 1;
    }
       
    return -1;
}

int BinarySearchRecursion(int[] myArr, int left, int right, int target)
{
    if(left <= right)
    {
        int mid = (left + right) / 2;
        
        if(myArr[mid] == target)
            return mid;
            
        else if(target > myArr[mid])
            return BinarySearchRecursion(myArr, mid + 1, right, target);
            
        else if(target < myArr[mid])
            return BinarySearchRecursion(myArr, left, mid - 1, target);
    }
    
    return -1;
}