public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string,List<string>> dict = new Dictionary<string, List<string>>();

        foreach(string s in strs) {

            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            string sorted = new string(arr);

            if(!dict.ContainsKey(sorted)) {
                dict.Add(sorted, new List<string>());
            }
            dict[sorted].Add(s);

        }

        List<List<string>> result = new List<List<string>>();
        foreach(var pair in dict) {
            result.Add(pair.Value);
        }

        return result;

    }
}
