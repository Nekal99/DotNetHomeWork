public class AlarmClockArgs : EventArgs
{
    private int hour;
    private int minute;
    private int second;
    public int Hour
    { get { return hour; } set { hour = value; } }
    public int Minute
    { get { return minute; } set { minute = value; } }
    public int Second
    { get { return second; } set {  second = value; } }
}

public delegate void AlarmClockHandler(object sender,AlarmClockArgs args);

public class AlarmClock
{
    static int hour = 0;
    static int min = 0;
    static int second = 0;
    public event AlarmClockHandler? Ticking;
    public event AlarmClockHandler? Alarming;

    public void start(int setHour,int setMin ,int setSecond)
    {
        while (hour<=1)
        {
            while (min<60)
            {
                while (second < 60)
                {
                    if (Ticking != null)
                    {
                        AlarmClockArgs args = new AlarmClockArgs();
                        args.Hour = hour;
                        args.Minute = min;
                        args.Second = second;
                        Ticking(this, args);
                    }
                    Alarm(setHour, setMin, setSecond);
                    second++;
                }
                min++;
                second = 0;
            }
            hour++;
            min = 0; 
            second = 0;
        }
    }

    public void Alarm(int setHour, int setMin, int setSecond)
    {
        if(setHour<24&&setHour>=0&&setMin<60&&setMin>=0&&setSecond>=0&&setSecond<60)
        {
            if(setHour==hour&&setMin==min&&setSecond==second)
            {
                if (Alarming != null)
                {
                    AlarmClockArgs args = new AlarmClockArgs();
                    args.Hour = hour;
                    args.Minute = min;
                    args.Second = second;
                    Alarming(this, args);
                }
            }
        }
    }
}

public class UseAlarmClock
{
    static void ShowTime(object sender, AlarmClockArgs e)
    {
        Console.WriteLine(e.Hour+":"+e.Minute+":"+e.Second);
    }

    static void AlaumBing(object sender, AlarmClockArgs e)
    {
        Console.WriteLine("album bing bing ");
    }
    static void Main()
    {
        var alarmClock = new AlarmClock();
        alarmClock.Ticking += ShowTime;
        alarmClock.Alarming += AlaumBing;
        Console.WriteLine("时钟开始滴答");
        alarmClock.start(0,0,20);//参数为设置的时钟响铃时间
    }
}
