// See https://aka.ms/new-console-template for more information

using static System.Console;

WriteLine("Arrays!!!");

/*int[] myArr = {1,2,3,4};

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

myArr2[index] = 5;*/

//foreach(int item in myArr2)
//    Write(item);



int[] myArr1 = {2,4,5,6};
int[] myArr2 = {2,3,7,8};
int[] myArr3 = new int[myArr1.Length + myArr2.Length];

int i = 0, j = 0, k = 0;

while(i < myArr1.Length && j < myArr2.Length)
{
    if(myArr1[i] == myArr2[j])
    {
        // we select only one and increment both
        myArr3[k++] = myArr1[i++];
        j++;
    }
    
    else if(myArr1[i] < myArr2[j])
    {
        myArr3[k++] = myArr1[i++];
    }
    
    else
        myArr3[k++] = myArr2[j++];
}

while(i < myArr1.Length)
    myArr3[k++] = myArr1[i++];
    
while(j < myArr2.Length)
    myArr3[k++] = myArr2[j++];


foreach(int item in myArr3)
    Write(item);



ReadLine();