using System;

public class Time
{
    private int hour;
    private int minute;
    public Time(int hr, int min)
    {
        hour = hr;
        minute = min;
    }
    public static explicit operator Time(string time)
    {
        char[] spaces = { ':' };
        string[] elements = time.Split(spaces);
        int hour = Convert.ToInt32(spaces[0]);
        int minute = Convert.ToInt32(spaces[1]);
        Time corrTime = new Time(hour, minute);
        return corrTime;
    }
    public static implicit operator string(Time time)
    {
        return time.hour + ":" + time.minute;
    }
}
   

