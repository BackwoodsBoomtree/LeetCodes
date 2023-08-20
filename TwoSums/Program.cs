var test = new Solution();
int[] myNums = { 2, 5, 5, 11};
int myTarget = 10;

var myResult = test.TwoSum(myNums, myTarget);
Console.WriteLine(string.Join(", ", myResult));
Console.ReadKey();

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 1; j < nums.Length; j++)
            {
                // avoid summing the same index
                if (j != i)
                {
                    var testSum = nums[i] + nums[j];

                    if (testSum == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
        }
        return result;
    }
}