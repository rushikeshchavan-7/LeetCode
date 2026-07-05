public class Solution {
    public int Reverse(int x) {
        if (x == int.MinValue) {
            return 0;
        }
        int sign = 1;
        if (x < 0) {
            sign = -1;
            x = Math.Abs(x); 
        }
        int y = 0;           
        while (x > 0) {
            if (y > (int.MaxValue)/10) {
                return 0;
            }
            y = (y * 10) + (x % 10);
            x /= 10;
        }
        return y*sign;
    }
}