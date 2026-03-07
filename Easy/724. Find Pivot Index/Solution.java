import java.util.Arrays;

class Solution {
    public int pivotIndex(int[] nums) {
        int totalNum =Arrays.stream(nums).sum();

        int leftSum =0, rightSum=totalNum;

        for(int i =0;i<nums.length;i++){
        rightSum -= nums[i];
        if(leftSum == rightSum){
            return i;
        }
        else{
            leftSum+=nums[i];
        }

        }
        return -1;
    }
}
