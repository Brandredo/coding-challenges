public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        if(s1.Length > s2.Length) return false;
        if(s1 == s2) return true;

        Dictionary<char,int> freq = new Dictionary<char,int>();

        foreach(var c in s1) {
            if(!freq.ContainsKey(c)) {
                freq.Add(c,1);
                continue;
            }
            freq[c]++;
        }

        for(int i = 0; i < s2.Length - s1.Length + 1; i++) {
            

            char ch = s2[i];

            if(freq.ContainsKey(ch)) {

                string substring = s2.Substring(i,s1.Length);
                Dictionary<char,int> copyFreq = new Dictionary<char,int>(freq);

                foreach(var c in substring) {
                    if(!copyFreq.ContainsKey(c)) break;
                    copyFreq[c]--;
                    if(copyFreq[c] == 0) {
                        copyFreq.Remove(c);
                    }
                }

                if(copyFreq.Count == 0) return true;

            }

        }

        // "leeabac"
        return false;
    }
}


// for each character in s2
//     if c is in the freq dictionary then
//         create a sliding window by taking the substring from i to i+s1.Length, create a copy of the freq map and decrement each freq of the substring

// abc
// acb
// cba
// cab
// bca
// bac

// c:1,a:1,b:1
