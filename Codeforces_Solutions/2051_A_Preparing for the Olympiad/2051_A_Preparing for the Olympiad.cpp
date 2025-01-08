#include <bits/stdc++.h>
using namespace std;
 
int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);
 
    int t;
    cin >> t;
 
    while (t--) {
        int n;
        cin >> n;
 
        vector<int> a(n), b(n);
 
        for (int i = 0; i < n; ++i) cin >> a[i];
        for (int i = 0; i < n; ++i) cin >> b[i];
 
        vector<int> dp(n + 1, 0);
 
        for (int i = 0; i < n; ++i) {
            // Fixing the incorrect expression for updating dp[i + 1]
            dp[i + 1] = max(dp[i + 1], dp[i] + a[i] - (i + 1 < n ? b[i + 1] : 0));
            dp[i + 1] = max(dp[i + 1], dp[i]);
        }
 
        cout << dp[n] << '\n';
    }
 
    return 0;
}
