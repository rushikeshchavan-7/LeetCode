public class Solution {
    public bool IsAnagram(string s, string t) {

        string sorted_s = new string(s.OrderBy(c => c).ToArray());
        string sorted_t = new string(t.OrderBy(c => c).ToArray());

        if (sorted_s != sorted_t){
            return false;
        }
        else return true;
        
    }
}