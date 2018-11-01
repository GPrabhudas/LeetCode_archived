/**
 * @param {number[]} nums
 * @return {number}
 */
var firstMissingPositive = function(nums) {
    var isSize = false;
    var missing = 0;
    var length = nums.length;
    if(!length)
        return 1;
    for(var i=0;i<length;i++){
        if(nums[i] <= 0){
            nums[i] = Number.MAX_VALUE;
        }
    }
    
    for(i=0;i<length;i++){
       if(Math.abs(nums[i]) >= length){
          if(Math.abs(nums[i]) == length){
              isSize = true;
            }
        }else{
            if(nums[Math.abs(nums[i])] > 0){
                nums[Math.abs(nums[i])]*=-1;
            }
        }
    }
    
    for(i=1;i<length;i++){
        if(nums[i] > 0){
            missing = i;
            break;
        }
    }
    
    if(missing){
        return missing;
    }
    return isSize ? length+1 : length;
};
