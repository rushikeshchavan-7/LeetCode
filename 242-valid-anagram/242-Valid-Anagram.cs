public class Solution {
    public bool IsAnagram(string s, string t) {
       if (s.Length == t.Length) 
       {
          string x = String.Concat(s.OrderBy(c => c));  
          string y = String.Concat(t.OrderBy(c => c));  

            if(x==y)
            {
                return true;
            }
       }
       return false;
    }
}