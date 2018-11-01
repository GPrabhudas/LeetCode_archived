/**
 * @param {number[]} nums
 * @return {number}
 */
var thirdMax = function(nums) {
    var first,second,third;
    first = second = third = Number.NEGATIVE_INFINITY;
    for(var i=0;i<nums.length;i++){
        if(first == nums[i] || second == nums[i] || third == nums[i]){
            continue;
        }
        if(first <nums[i]){
            third = second;
            second = first;
            first = nums[i];
        }else if(second < nums[i]){
            third = second;
            second = nums[i];
        }else if(third < nums[i]){
            third = nums[i];
        }
    }
   return (third == Number.NEGATIVE_INFINITY) ? first : third;
};
