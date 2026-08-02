public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        
        List<List<int>> result = new List<List<int>>();
        if(nums.Length < 3) return result;
        Array.Sort(nums);

        for(int i = 0; i < nums.Length; i++) {

            // check duplicates (prev)
            if(i > 0 && nums[i] == nums[i-1]) continue;

            int j = i + 1;
            int k = nums.Length - 1;
            
            while(j < k) {
                int sum = nums[i] + nums[j] + nums[k];

                if(sum == 0) {
                    result.Add(new List<int> { nums[i], nums[j], nums[k] });
                    j++;
                    k--;
                    while(j < k && nums[j] == nums[j-1]) j++;
                    while(j < k && nums[k] == nums[k+1]) k--;
                } else if(sum < 0) {
                    j++;
                    while(j < k && nums[j] == nums[j-1]) j++;
                } else {
                    k--;
                    while(j < k && nums[k] == nums[k+1]) k--;
                }
                

            }

        }

        return result;
    }
}


// [-1,0,1,2,-1,-4]
// [-4,-1,-1,0,1,2]