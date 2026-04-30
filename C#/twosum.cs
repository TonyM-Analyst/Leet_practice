public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Loop through each number
        for (int i = 0; i < nums.Length; i++) {
            
            // Check every number after it
            for (int j = i + 1; j < nums.Length; j++) {
                
                // If the two numbers add up to target, return their indices
                if (nums[i] + nums[j] == target) {
                    return new int[] { i, j };
                }
            }
        }

        // If no solution is found (shouldn't happen per problem statement)
        return new int[0];
    }
}