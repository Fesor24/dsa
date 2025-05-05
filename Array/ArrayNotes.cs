namespace Array;

public class ArrayNotes
{
    public void NoteOne()
    {
        // when we declare an array like this, a1 is this case is a null reference
        // memory for keeping elements is not allocated yet so s1 does not point to any memory location
        int[] a1;

        // in this case, a chunk of memory will be allocated for keeping 10 integer values
        a1 = new int[10];

        // multi dimension array
        int[,] multiDimArray = new int[2,3]{{1,2,3}, {8,3,1}};
        int[,] multiDimArray2 = { { 2, 3, 9 }, { 0, 9, 1 } };

        for (int i = 0; i < multiDimArray.GetLength(0); i++)
        {
            for (int j = 0; j < multiDimArray.GetLength(1); j++)
            {
                Console.WriteLine($"{multiDimArray[i, j]}");
            }
        }

        // jagged array
        int [][] jaggedArr = new int[2][];

        jaggedArr[0] = new int[3]; // first row will have 3 items
        jaggedArr[1] = new int[2]; // second row will have 2 items
    }
    

}