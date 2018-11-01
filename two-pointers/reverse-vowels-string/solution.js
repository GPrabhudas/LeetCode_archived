/**
 * @param {string} s
 * @return {string}
 */
function isVowel(c){
    var arr = ['a','e','i','o','u','A','E','I','O','U'];
    return arr.indexOf(c) != -1;
    return c == "a" || c == "e" ||  c == "i" || c == "o" ||  c == "u" || c == "A" || c == "E" ||  c == "I" || c == "O" ||  c == "U";
}
var reverseVowels = function(s) {
    if(s){
        var l = 0;
        var r = s.length-1;
        var arr = s.split("");
        while(l < r){
            while(l<r && !isVowel(arr[l])){
                l++;
            }
            while(l < r && !isVowel(arr[r])){
                r--;
            }
            
            var temp = arr[r];
            arr[r] = arr[l];
            arr[l] = temp;
            l++;
            r--;
          
        }
        return arr.join("");
    }
    return "";
};
