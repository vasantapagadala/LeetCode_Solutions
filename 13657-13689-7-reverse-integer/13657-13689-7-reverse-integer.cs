public class Solution {
    public int Reverse(int x) {
        int neg = 1;
        if( x < 0)
            neg = -1;
        x = x * neg;

        long result = 0;
        while ( x > 0)
        {
            result = result *10 + x % 10;
            x = x / 10; 
        }
        if(result > int.MaxValue)
            return 0;
        return (int) result * neg;
        
    }
}