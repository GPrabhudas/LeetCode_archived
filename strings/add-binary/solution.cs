/**
 * @param {string} a
 * @param {string} b
 * @return {string}
 */
var addBinary = function(a, b) {
    if(!a && !b){
        return "0";
    }
    var res = [];
    var s = 0;
    var i = a.length -1;
    var j = b.length -1;
    while(i>=0 || j>=0 || s==1){
        s+=(i>=0 ? a[i]-'0':0);
        s+=(j>=0 ? b[j]-'0':0);
        res.push((s%2));
        s = Math.floor(s/2);
        i--;
        j--;
    }
    return res.reverse().join("");
};
