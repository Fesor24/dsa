// See https://aka.ms/new-console-template for more information

using static System.Console;

WriteLine("Arrays!!!");

int[] myArr = {1,2,3,4};

int[] myArr2 = new int[5];
myArr2[0] = 1;
myArr2[1] = 2;
myArr2[2] = 3;
myArr2[3] = 4;

// insert number 5 at index 2
int index = 2;
for(int i = myArr2.Length - 1; i > index; i--)
{
    myArr2[i] = myArr2[i - 1];
}

myArr2[index] = 5;

//foreach(int item in myArr2)
//    Write(item);







ReadLine();