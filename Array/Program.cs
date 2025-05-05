// See https://aka.ms/new-console-template for more information

using Array;

Console.WriteLine("Arrays!!!");

var result = TwoSums.RunOptimized();
foreach (var item in result)
{
    string res = $"{item.Key} - Values = ";
    foreach (int value in item.Value)
    {
        res += $"{value},";       
    }
    Console.WriteLine($"{res}");
}