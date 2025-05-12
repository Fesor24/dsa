using static System.Console;

WriteLine("Recursion!!");

int n = 4;
SubtractAndPrint(n);

ReadLine();

void SubtractAndPrint(int x)
{
    if(x > 0)
    {
        WriteLine($"Value of n is {x}");
        SubtractAndPrint(x - 1);
    }
}