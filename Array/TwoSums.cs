namespace Array;

// Given an array of integers nums and an integer target,
// return indices of the two numbers such that they add up to target.
// Easy...

// skip dynammic programming...
// solve top 50 questions bloomberg...
public static class TwoSums
{
    private static readonly int[] testCase1 = [2,7,11,15];
    private static readonly int target1 = 9;
    
    private static readonly int[] testCase2 = [3,2,4];
    private static readonly int target2 = 6;
    
    private static readonly int[] testCase3 = [3,3];
    private static readonly int target3 = 6;
    
    public static Dictionary<string, int[]> RunBruteForce()
    {
        int[] answer1 = BruteForce(testCase1, target1);
        int[] answer2 = BruteForce(testCase2, target2);
        int[] answer3 = BruteForce(testCase3, target3);

        return new Dictionary<string, int[]>()
        {
            { "Test case 1", answer1 },
            { "Test case 2", answer2 },
            { "Test case 3", answer3 },
        };
    }
    
    private static int[] BruteForce(int[] nums, int target)
    {
        for(int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                    return new int[2] { i, j };
            }
        }
        
        throw new Exception("No solution found");
    }

    public static Dictionary<string, int[]> RunOptimized()
    {
        int[] answer1 = Optimized(testCase1, target1);
        int[] answer2 = Optimized(testCase2, target2);
        int[] answer3 = Optimized(testCase3, target3);

        return new Dictionary<string, int[]>()
        {
            { "Test case 1", answer1 },
            { "Test case 2", answer2 },
            { "Test case 3", answer3 },
        };
    }

    private static int[] Optimized(int[] nums, int target)
    {
        Dictionary<int, int> maps = new();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int remainder = target - nums[i];
            
            // if the remainder is in the dictionary, return the indices
            if (maps.ContainsKey(remainder))
                return new int[2] { i, maps[remainder] };
            
            // if current iteration is not in the dictionary, add it to the dictionary
            if(!maps.ContainsKey(nums[i]))
                maps.Add(nums[i], i);
        }
        
        throw new Exception("No solution found");
    }
}