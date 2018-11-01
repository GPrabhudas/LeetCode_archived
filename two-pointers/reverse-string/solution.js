/**
 * @param {string} s
 * @return {string}
 */
var reverseString = function(s) {
    var rev = "";
    var length = s.length -1;
    for(var i=length;i>=0;i--){
        rev+=s[i];
    }
    return rev;
};
