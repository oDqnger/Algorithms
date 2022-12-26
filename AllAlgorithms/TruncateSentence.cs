// truncate s such that it contains only the first k words. (challenge taken from leetcode)
     public string TruncateSentence(string s, int k) {
        string ans = ""; // stores an empty var called ans (string)
        int count = 0; // stores an empty var called count (int)
        for (int x = 0; x<s.Length; x++) { // goes through the string
            if (s[x] != ' ') { // checks to see if there is an empty string
                ans = ans + s[x]; // adds s[x] to ans.
            } else { // if it hits a space, it means that it has gone through one word, so in that case we want to increment the count var
                count++; 
                if (count == k) { // we check to see if count == k (which is how much we need to trucate to)
                    break; // we break the loop once it does
                }
                ans = ans + s[x]; // adds a space to s[x]
            }
        }

        return ans;
     }
