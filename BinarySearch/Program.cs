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

    int mid;
        
    while(left <= right)
    {
        mid = (left + right) / 2;

        if (arr[mid] == target)
            return mid;
        
        else if (target < arr[mid])
            right = mid - 1;

        // has to be in the else, otherwise, it will be stuck in the loop forever if item is not found
        // We stop when left is greater than right
        else 
            left = mid + 1;
    }
       
    return -1;
}

// Tail recursion
// If we have to use a tail recursion, we can always use a loop since tail recursion uses the stack
int BinarySearchRecursion(int[] myArr, int left, int right, int target)
{
    if(left <= right)
    {
        int mid = (left + right) / 2;
        
        if(myArr[mid] == target)
            return mid;
            
        else if(target < myArr[mid])
            return BinarySearchRecursion(myArr, left, right - 1, target);
            
        else
            return BinarySearchRecursion(myArr, left + 1, right, target);
    }
    
    return -1;
}