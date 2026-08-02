public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length == 0 && t.Length == 0) return true;
        if(s.Length == 0 || t.Length == 0) return false;

        int[] freq = new int[26];

        foreach(char ch in s) {
            freq[ch % 26]++;
        }

        // [j: 0, a: 0, r: 1]

        for(int i = 0; i < t.Length; i++) {

            char ch = t[i];

            if(freq[ch % 26] <= 0) return false;

            freq[ch % 26]--;
        }

        foreach(var f in freq) {
            if(f > 0) return false;
        }

        return true;
    }
}
