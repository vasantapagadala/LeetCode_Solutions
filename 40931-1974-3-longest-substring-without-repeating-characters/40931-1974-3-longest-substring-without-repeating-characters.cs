public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int front = 0;
        int back = 0;
        
        int maxLength = 0;
        
        HashSet<char> charSet = new HashSet<char>();
        while(back < s.Length)
        {
            if(!charSet.Contains(s[back]))
            {
                charSet.Add(s[back]);
                back++;
                maxLength = Math.Max(maxLength, (back - front));
            }
            else
            {
                charSet.Remove(s[front]);
                front++;
            }
        }
        return maxLength; 
    }
}