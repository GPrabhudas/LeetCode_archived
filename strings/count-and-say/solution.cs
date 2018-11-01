public class Solution {
    private StringBuilder CountAndSayUtil(StringBuilder res,int n){
        if(n<=0)
            return res;
        int length = res.Length,i=0;
        StringBuilder temp = new StringBuilder();
        while(i < length){
            int count =0;
            char c = res[i];
            while(i < length && c == res[i]){
                count++;
                i++;
            }
            temp.Append(count).Append(c);
        }
        return CountAndSayUtil(temp,n-1);
    }
    public string CountAndSay(int n) {
       
        StringBuilder res = new StringBuilder("1");
        res = CountAndSayUtil(res,n-1);
        return res.ToString();
    }
}
