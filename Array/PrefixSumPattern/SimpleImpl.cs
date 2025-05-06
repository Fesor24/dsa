namespace Array.PrefixSumPattern;

internal partial class PrefixSum 
{
    public static int[] SimpleImpl(int[] arr)
    {
        int[] prefixSum = new int[arr.Length];

        prefixSum[0] = arr[0];

        for(int i = 1; i < arr.Length; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + arr[i];
        }

        return prefixSum;
    }
}
