public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var output = "";
        if(strs.Length == 0)   
            return output;
        
        for (int i = 0; i <= strs[0].Length-1; i++)
        {
            var x = strs[0][i];
            foreach(var s in strs)
            {
                if( i > s.Length-1 || s[i] != x)
                return output;
            }
            output += x;
        }
        return output;

    }

}