public class Solution {
    private bool OpenBracket(char c){
        return (c == '(' || c == '{' || c == '[');
    }
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        int length = s.Length;
        int i=0;
        while(i<length){
            if(OpenBracket(s[i])){
                stack.Push(s[i]);
            }else{
               if(stack.Count > 0){
                        char top = stack.Peek();
                    switch(s[i]){
                        case ')' : if(top != '(') return false;break;
                        case ']' : if(top != '[') return false;break;
                        case '}' : if(top != '{') return false;break;
                    }
                    stack.Pop();
                   }else{
                       return false;
               }
            }
            i++;
        }
        return stack.Count == 0;
    }
}
