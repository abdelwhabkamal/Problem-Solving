public class Solution {
    public double AngleClock(int hour, int minutes) {
        double h_angle = ((double)minutes / 60 * 30) +  (hour%12 * 30);
        double m_angle = minutes * 6;
        double res = Math.Abs(h_angle - m_angle);
        if(res < 180 ) return res;
        return 360 - res;
    }
}