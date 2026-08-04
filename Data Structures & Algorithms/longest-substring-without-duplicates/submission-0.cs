public class Solution {
    public int LengthOfLongestSubstring(string s) {

        HashSet<int> window = new HashSet<int>();
        int start = 0;
        int maxSubstring = 0;

        // "zxyzxyz"
        //        e
        //.     s
        // window: [z,x,y]

        for(int end = 0; end < s.Length; end++) {

            char c = s[end];

            if(window.Contains(c)) {

                while(window.Contains(c)) {
                    window.Remove(s[start]);
                    start++;
                }

            }

            window.Add(c);
            maxSubstring = Math.Max(maxSubstring, window.Count); // 3

        }

        return maxSubstring;
    }
}
