#include <bits/stdc++.h>
 
using namespace std;
 
int main() {
    ios::sync_with_stdio(false);
    cin.tie(0);
 
    int t;
    cin >> t;
 
    while (t--) {
        int n, m, k;
        cin >> n >> m >> k;
 
        vector<int> a(m);
        for (auto &x : a) cin >> x;
 
        vector<int> q(k);
        for (auto &x : q) cin >> x;
 
        // إذا كان عدد العناصر المفقودة هو n
        if (k == n) {
            for (int i = 0; i < m; i++) cout << '1';
            cout << "\n";
        }
        // إذا كان عدد العناصر المفقودة هو n-1
        else if (k == n - 1) {
            int missing = 1;
 
            for (auto x : q) {
                if (x == missing) {
                    missing++;
                } else {
                    break;
                }
            }
 
            // إذا كانت قيمة missing أكبر من n، نعود إلى n
            if (missing > n) {
                missing = n;
            }
 
            // إنشاء السلسلة بناءً على القيم المدخلة
            string res;
            res.reserve(m);  // تحسين أداء الذاكرة
 
            for (auto x : a) {
                res += (x == missing) ? '1' : '0';
            }
 
            cout << res << "\n";
        }
        // إذا لم يتحقق أي من الشرطين السابقين
        else {
            for (int i = 0; i < m; i++) cout << '0';
            cout << "\n";
        }
    }
 
    return 0;
}
