public class Solution {
    public int LongestPalindromeSubseq(string str) {
        if(str == null || str == "")
        {
            return 0;
        }
        int [,] dp = new int [str.Length,str.Length];
        for(int i=0;i<str.Length;i++)
        {
            dp[i,i] = 1;
        }
        
        for(int l=2;l<=str.Length;l++)
        {
            for(int i=0;i<str.Length-l+1;i++)
            {
                int j = i + l - 1;
                if(str[i] == str[j] && l==2)
                {
                    dp[i,j] = 2;
                }
                else if(str[i] == str[j])
                {
                    dp[i,j] = 2 + dp[i+1,j-1];
                }
                else
                {
                    dp[i,j] = max(dp[i,j-1],dp[i+1,j]);    
                }
            }
        }
        return dp[0,str.Length-1];
    }
    
    private int max(int a,int b)
    {
        return a > b ? a : b;
    }
  }
