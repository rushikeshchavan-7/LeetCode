public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {return false;}

        var trackker = new int [26];

        for(int i = 0; i <s.Length; i++)
        {
            trackker[s[i] - 'a']++;
            trackker[t[i] - 'a']--;
        }

        for(int i = 0; i < 26; i++)
        {
            if(trackker[i]!=0) {return false;}
        }
        return true;
    }
}