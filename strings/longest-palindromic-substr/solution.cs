public class Solution {
    public string LongestPalindrome(string s) {
        if(string.IsNullOrWhiteSpace(s))
            return string.Empty;
    
       int length = s.Length;
       bool [,] table = new bool [length,length];
       int start = 0;
       int maxLength = 1;
       for(int i=0;i<length;i++){
           table[i,i] = true;
       }
       for(int i=0;i<length-1;i++){
           if(s[i] == s[i+1]){
               table[i,i+1] = true;
               maxLength = 2;
               start = i;
           }
       }
        
       for(int k=3;k<=length;k++){
          int currLength = length-k+1;
          for(int i=0;i<currLength;i++){
              int endIndex = i+k-1;
              if(table[i+1,endIndex-1] && (s[i] == s[endIndex])){
                  table[i,endIndex] = true;
                  if(k > maxLength){
                      start = i;
                      maxLength = k;
                  }
              }
          }
       }
       return s.Substring(start,maxLength);
    }
}
