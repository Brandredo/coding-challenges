public class Solution {
    public int CoinChange(int[] coins, int amount) {
        // base case amount = 0 return 0
        if(amount == 0) return 0;
        var memo = new Dictionary<int,int>();
        int min = Dp(amount, coins, memo);

        return min != int.MaxValue ? min : -1;
    }

    private int Dp(int remaining, int[] coins, Dictionary<int,int> memo) {

        if(remaining == 0) {
            return 0;
        }

        if(memo.ContainsKey(remaining)) {
            return memo[remaining];
        }

        int ans = int.MaxValue;
        foreach(var coin in coins) {
            if(remaining - coin < 0) continue;
            int res = Dp(remaining - coin, coins, memo);
            if (res != int.MaxValue) {
                ans = Math.Min(ans, 1 + res);
            }
        }

        memo[remaining] = ans;
        return ans;
    }
}