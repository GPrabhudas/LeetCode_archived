/**
 * @param {number[]} bits
 * @return {boolean}
 */
var isOneBitCharacter = function(bits) {
    var f = true;
    var i = 0;
    while(i < bits.length){
        if(bits[i]==1 && (i+1 < bits.length)){
            i+=2;
            f=false;
        }else{
            i++;
            f=true;
        }
    }
    return f;
    //return bits.length == 1 || bits[bits.length-2] !=1;
};
