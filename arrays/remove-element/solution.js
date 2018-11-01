/**
 * @param {number[]} nums
 * @param {number} val
 * @return {number}
 */
var removeElement = function(nums, val) {
    if(nums && nums.length){
       var l = 0;
       for(var i=0;i<nums.length;i++){
           if(nums[i] != val){
               nums[l++] = nums[i];
           }
       }
       return l;
    }
    return 0;
};
