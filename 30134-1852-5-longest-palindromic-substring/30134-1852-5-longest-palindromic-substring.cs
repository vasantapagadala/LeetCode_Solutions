public class Solution {
    public string LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s))
            return "";
        
        int start = 0;
        int end = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int len1 = mid(s, i, i);
            int len2 = mid(s, i, i+1);
            int len = Math.Max(len1, len2);
            if (len > end - start)
            {
                start = i-(len - 1) / 2;
                end = i + len / 2;
            }
        }
        return s.Substring(start, end - start + 1);
        
    }
    
    private int mid(string s, int left, int right)
    {
        if (left > right)
            return 0;
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        return right - left - 1;
    }
}