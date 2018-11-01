int min(int a,int b)
{
     return a < b ? a : b;
}
int minDistance(char* x, char* y) {
    int m = strlen(x);
    int n = strlen(y);
    int i,j;
    int dp[m+1][n+1];
    for(i=0;i<=m;i++)
    {
        dp[i][0] = i;
    }
    for(i=0;i<=n;i++)
    {
        dp[0][i] = i;
    }
    for(i=1;i<=m;i++)
    {
        for(j=1;j<=n;j++)
        {
            if(x[i-1] == y[j-1])
            {
                dp[i][j] = dp[i-1][j-1];
            }
            else
            {
                dp[i][j] = 1 + min(dp[i][j-1],min(dp[i-1][j],dp[i-1][j-1]));
            }
        }
    }
    return dp[m][n];
}
