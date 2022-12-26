// truncate s such that it contains only the first k words. (challenge taken from leetcode)
     public string TruncateSentence(string s, int k) {
        string ans = "";
        int count = 0;
        for (int x = 0; x<s.Length; x++) {
            if (s[x] != ' ') {
                ans = ans + s[x];
            } else {
                count++;
                if (count == k) {
                    break;
                }
                ans = ans + s[x];
            }
        }

        return ans;
     }
