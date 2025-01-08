public class Solution {
    public bool IsMatch(string s, string p) {
        if(p.Length == 0)
            return s.Length == 0;
        
        bool Match = s.Length != 0 && (s[0] == p[0] || p[0] == '.');
        
        if(p.Length >= 2 && p[1] == '*')
            return IsMatch(s, p.Substring(2)) || (Match && IsMatch(s.Substring(1), p));
        else
            return Match && IsMatch(s.Substring(1), p.Substring(1));                          
    }
}