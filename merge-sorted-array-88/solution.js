/**
 * @param {number[]} nums1
 * @param {number} m
 * @param {number[]} nums2
 * @param {number} n
 * @return {void} Do not return anything, modify nums1 in-place instead.
 */
var merge = function(nums1, m, nums2, n) {
    if(nums1 && nums1.length && nums2 && nums2.length){
        var l = m-1;
        var r = nums1.length-1;
        for(var l = m-1;l>=0;l--){
            nums1[r--] = nums1[l];
            nums1[l] = 0;
        }
        r = nums1.length - m;
        l = 0;
        var k = 0;
        while(r < nums1.length && k < nums2.length){
            if(nums1[r] <= nums2[k]){
                nums1[l] = nums1[r++];
            }else{
                nums1[l] = nums2[k++];
            }
            l++;
        }
        while(r < nums1.length){
            nums1[l++] = nums1[r++];
        }
        while(k < nums2.length){
            nums1[l++] = nums2[k++];
        }
        l = m+n;
        while(l < nums1.length){
            nums1[l] = 0;
            l++;
        }
    }
};
