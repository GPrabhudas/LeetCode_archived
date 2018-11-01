/**
 * @param {number[]} nums
 * @return {number}
 */
var pivotIndex = function(nums) {
    var sum= 0;
    var left = 0;
    for(var i=0;i<nums.length;i++){
        sum+=nums[i];
    }
    for(var i=0;i<nums.length;i++){
        sum = sum - nums[i];
        if(left == sum){
            return i;
        }
        left += nums[i];
    }
    return -1;
};
