// See https://aka.ms/new-console-template for more information

using Array;
using Array.PrefixSumPattern;

Console.WriteLine("Arrays!!!");

int[] myArr = {1,2,3,4};

var result = PrefixSum.SimpleImpl(myArr);

foreach(int item in result)
    Console.WriteLine(item);

Console.ReadLine();

// Two sums
// var result = TwoSums.RunOptimized();
// foreach (var item in result)
// {
//     string res = $"{item.Key} - Values = ";
//     foreach (int value in item.Value)
//     {
//         res += $"{value},";       
//     }
//     Console.WriteLine($"{res}");
// }

// var bruteForceResult = TwoSums.RunBruteForce();
// foreach (var item in bruteForceResult)
// {
//     string res = $"{item.Key} - Values = ";
//     foreach (int value in item.Value)
//     {
//         res += $"{value},";       
//     }
//     Console.WriteLine($"{res}");
// }