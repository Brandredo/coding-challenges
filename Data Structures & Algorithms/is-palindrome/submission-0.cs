public class Solution {
    public bool IsPalindrome(string s) {
        
        if(s.Length == 0) return true;

        int left = 0;
        int right = s.Length - 1;

        while(left <= right) {

            char l = s[left];
            char r = s[right];

            if(!char.IsLetterOrDigit(l)) {
                left++;
                continue;
            }

            if(!char.IsLetterOrDigit(r)) {
                right--;
                continue;
            }

            if(char.ToLowerInvariant(l) != char.ToLowerInvariant(r)) {
                return false;
            }

            left++;
            right--;
        }

        return true;

    }
}


// tab a!bat
//    l r

