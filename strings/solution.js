/**
 * @param {string} ransomNote
 * @param {string} magazine
 * @return {boolean}
 */
var canConstruct = function(ransomNote, magazine) {
    var text = {};
    var pat = {};
    var flag = true;
    for(var i=0;i<magazine.length;i++){
        if(text[magazine[i]]){
            text[magazine[i]]++;
        }else{
            text[magazine[i]] = 1;
        }
    }
    
    for(var i=0;i<ransomNote.length;i++){
        if(pat[ransomNote[i]]){
            pat[ransomNote[i]]++;
        }else{
            pat[ransomNote[i]] = 1;
        }
    }
      
    for(var i=0;i<ransomNote.length;i++){
        
        if(!text[ransomNote[i]] || pat[ransomNote[i]] > text[ransomNote[i]]){
            flag = false;
            break;
        }
    }
    return flag;
};
