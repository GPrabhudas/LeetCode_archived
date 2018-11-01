public class Solution {
    private string LongetCommonPrefixCompute(string str1,string str2){
     int length1 = str1.Length;
     int length2 = str2.Length;
     StringBuilder sb = new StringBuilder("");
     for(int i=0,j=0;i<length1 && j<length2;i++,j++){
        if(str1[i] != str2[j])
            break;
        sb.Append(str1[i]);
     }
     return sb.ToString();
    }
    private string LongetCommonPrefixUtil(string [] str,int low,int high){
     if(high == low)
         return str[low];
     if(low < high){
         int mid = low + (high - low)/2;
         string str1 = LongetCommonPrefixUtil(str,low,mid);
         string str2 = LongetCommonPrefixUtil(str,mid+1,high);
         return LongetCommonPrefixCompute(str1,str2);
     }
        return string.Empty;
    }
    public string LongestCommonPrefix(string[] strs) {
        int low = 0,high = strs.Length;
        string res = LongetCommonPrefixUtil(strs,low,high-1);
        return res;
    }
}
