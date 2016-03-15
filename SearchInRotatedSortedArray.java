
 class Solution {
    public int search(int[] nums, int target) {
        int low=0,high=nums.length-1;

        while(low<=high){
            int mid = (low+high)>>1;
            if(nums[mid]<target){
                if(nums[mid]>nums[low]){
                    low=mid+1;
                }
                else if(nums[mid]<nums[low]){
                    if(target>nums[low]){
                        high=mid-1;
                    }
                    else if(target<nums[low]){
                        low=mid+1;
                    }
                    else{
                        return low;
                    }
                }
                else{
                    low=mid+1;
                }
            }
            else if(nums[mid]>target){
                if(nums[mid]>nums[low]){
                    if(target>nums[low]){
                        high=mid-1;
                    }
                    else if(target<nums[low]){
                        low=mid+1;
                    }
                    else{
                        return low;
                    }
                }
                else if(nums[mid]<nums[low]){
                    high=mid-1;
                }
                else{
                   low=mid+1;
                }
            }
            else {
                return mid;
            }

        }
        return -1;
    }
}
