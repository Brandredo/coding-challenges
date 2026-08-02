// T: O(n+m)
// S: O(n)

public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) return false;
        if(s.Length == 0 && t.Length == 0) return true;

        var chars = new Dictionary<char,int>();

        // []
        foreach(var c in s) {
            if(!chars.ContainsKey(c)) {
                chars.Add(c,1);
                continue;
            }

            chars[c]++;
        }

        foreach(var ch in t) {
            if(!chars.ContainsKey(ch)) return false;
            chars[ch]--;
            if(chars[ch] <= 0) {
                chars.Remove(ch);
            }
        }

        return chars.Count == 0;
    }
}
