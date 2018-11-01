/**
 * @param {string} s
 * @return {boolean}
 */
function isValid(c){
    return (c >= 'a' && c <= 'z') || (c >= '0' && c<= '9');
}

var isPalindrome = function(s) {
    if(s == "")
        return true;
    s = s.toLowerCase();
    var l = 0;
    var r = s.length -1;
    while(l<r){
        while(l < r  && !isValid(s[l])){
            l++;
        }
        while(l < r && !isValid(s[r])){
            r--;
        }
        if(s[l] != s[r]){
            return false;
        }
        l++;
        r--;
    }
    return true;
};
