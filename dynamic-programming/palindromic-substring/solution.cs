public class Solution {
    public int CountSubstrings(string s) {
        if(s == null || s == "")
            return 0;
        int n = s.Length;
        int [,]dp = new int [n,n];
        bool [,] p = new bool[n,n];
        for(int i=0;i<n;i++)
        {
            p[i,i] = true;
            dp[i,i] = 1;
        }
        
        for(int i=0;i<n-1;i++)
        {
            if(s[i] == s[i+1])
            {
                p[i,i+1] = true;
                dp[i,i+1] += 1;        
            }
        }
        
        for(int l=2;l<=n;l++)
        {
            for(int i=0;i<n-l+1;i++)
            {
                int j = l+i-1;
                
                if(s[i] == s[j] && p[i+1,j-1])
                {
                    p[i,j] = true;
                }
                dp[i,j] = dp[i+1,j] + dp[i,j-1] - dp[i+1,j-1];
                dp[i,j] += p[i,j] ? 1 : 0;
            }
        }
        return dp[0,n-1];
    }
}
