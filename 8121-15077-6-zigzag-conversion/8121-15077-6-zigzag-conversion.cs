public class Solution {
    public string Convert(string s, int numRows) {
        
        if (numRows == 1)
            return s;
        
        StringBuilder obj = new StringBuilder();
        int n = s.Length;
        int fullLen = 2 * numRows - 2;
        
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j + i < n; j += fullLen)
            {
                obj.Append(s[j+i]);
                if(i != 0 && i != numRows - 1 && j + fullLen - i < n)
                    obj.Append(s[j + fullLen - i]);              
            }
        }
        return obj.ToString();
    }
}