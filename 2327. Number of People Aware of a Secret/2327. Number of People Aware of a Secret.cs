public class Solution {
    public int PeopleAwareOfSecret(int n, int delay, int forget) {
        const int MOD = 1000000007;
        int[] dp = new int[n + 1];
        dp[1] = 1; 
        
        long totalPeopleKnowing = 1; // Total number of people who currently know the secret.
        long peopleSharing = 0; // Number of people available to share the secret.
        
        for (int day = 2; day <= n; day++) {
            // People starting to share on this day.
            if (day - delay >= 1) {
                peopleSharing = (peopleSharing + dp[day - delay]) % MOD;
            }
            // People forgetting the secret on this day.
            if (day - forget >= 1) {
                peopleSharing = (peopleSharing - dp[day - forget] + MOD) % MOD;
                totalPeopleKnowing = (totalPeopleKnowing - dp[day - forget] + MOD) % MOD;
            }
            
            // Update the number of people who know the secret today.
            dp[day] = (int)peopleSharing;
            totalPeopleKnowing = (totalPeopleKnowing + dp[day]) % MOD;
        }
        
        
        return (int)totalPeopleKnowing;
    }
}