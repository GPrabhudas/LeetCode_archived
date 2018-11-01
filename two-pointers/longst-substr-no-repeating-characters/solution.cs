public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrWhiteSpace(s))
            return 0;
        
        int [] visited = new int [256];
        for(int i=0;i<256;i++){
            visited[i] = -1;
        }
        int length = s.Length;
        int curlen = 1;
        int maxlen = int.MinValue;
        
        visited[(s[0])] = 0;
        
        for(int i=1;i<length;i++){
            int prevIndex = visited[(s[i])];
            if(prevIndex == -1 || (i-curlen) > prevIndex){
                curlen++;
            }else{
                if(maxlen < curlen)
                    maxlen = curlen;
                curlen = i-prevIndex;
            }
            visited[(s[i])] = i;
        }
        if(maxlen < curlen)
            maxlen = curlen;
        return maxlen;
    }
}
