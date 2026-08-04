public class Solution {
    public int LengthOfLongestSubstring(string s) {

        //HashSet<int> window = new HashSet<int>();
        Dictionary<char, int> window = new Dictionary<char, int>();

        int start = 0;
        int maxSubstring = 0;

        // "zxyzxyz"
        //        e
        //.     s
        // window: [z,x,y]

        for(int end = 0; end < s.Length; end++) {

            char c = s[end];

            if(window.ContainsKey(c) && (window[c] >= start && window[c] <= end)) {

                start = window[c] + 1; // the new start of the window should be the index where the character is + 1
                
                // while(window.Contains(c)) {
                //     window.Remove(s[start]);
                //     start++;
                // }

            }

            window[c] = end;
            maxSubstring = Math.Max(maxSubstring, end - start + 1); // 3

        }

        return maxSubstring;
    }
}
