using System;


class Date
    {
        private int d;
        private int m;
        private int y;

        public int Day
        {

            get { return d; }

            set
            {
                if (value > 31 || value < 1)
                {

                    Console.WriteLine("Invalid day");
                }

                d = value;
            }
        }

        public int Month
        {

            get { return m; }

            set
            {
                if (value > 12 || value < 1)
                {

                    Console.WriteLine("Invalid month");
                }

                m = value;
            }
        }

        public int Year
        {

            get { return y; }

            set
            {
                if (Convert.ToString(value).Length != 4)
                {

                    Console.WriteLine("Year must be 4 digits");
                }

                y = value;
            }
        }

        public Date()
        {
            m = 1;
            d = 1;
            y = 2000;
        }

        public Date(int m, int d, int y)
        {
            Month = m;
            Day = d;
            Year = y;
        }

        public string DisplayUSFormat()
        {

            if (Month <= 12 && Month >= 1)
            {

                if (Day <= 31 && Day >= 1)
                {

                    if (Convert.ToString(Year).Length == 4)
                    {

                        return Month.ToString("D2") + "/" + Day.ToString("D2") + "/" + Year;
                    }
                }
            }
            return "Invalid date";
        }

        public static bool operator ==(Date a, Date b)
        {
            if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
            {
                return false;
            }
            if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
            {
                return false;
            }
            if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
            {
                return false;
            }
            return a.Day + a.Month + a.Year == b.Day + b.Month + b.Year;
        }
        public static bool operator !=(Date a, Date b)
        {
            if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
            {
                return false;
            }
            if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
            {
                return false;
            }
            if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
            {
                return false;
            }
            return a.Day + a.Month + a.Year != b.Day + b.Month + b.Year;
        }
        public static bool operator <(Date a, Date b)
        {
            if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
            {
                return false;
            }
            if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
            {
                return false;
            }
            if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
            {
                return false;
            }
            return a.Day + a.Month + a.Year < b.Day + b.Month + b.Year;
        }
        public static bool operator <=(Date a, Date b)
        {
            if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
            {
                return false;
            }
            if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
            {
                return false;
            }
            if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
            {
                return false;
            }
            if (a.Year <= b.Year && a.Month <= b.Month && a.Day <= b.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Date a, Date b)
        {
            if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
            {
                return false;
            }
            if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
            {
                return false;
            }
            if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
            {
                return false;
            }
            return a.Day + a.Month + a.Year > b.Day + b.Month + b.Year;
        }
        public static bool operator >=(Date a, Date b)
        {
            if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
            {
                return false;
            }
            if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
            {
                return false;
            }
            if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
            {
                return false;
            }
            if (a.Year >= b.Year && a.Month >= b.Month && a.Day >= b.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Date date &&
                   d == date.d &&
                   m == date.m &&
                   y == date.y &&
                   Day == date.Day &&
                   Month == date.Month &&
                   Year == date.Year;
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }

class Reservation
{
    Date resDate = new Date();

    private string name;
    private string time;
    private int numberOfparty;
    private string date;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }
    public string Time
    {
        get
        {
            return this.time;
        }
        set
        {
            this.time = value;
        }
    }
    public int NumberOfparty
    {
        get
        {
            return numberOfparty;
        }
        set
        {
            this.numberOfparty = value;
        }
    }
    public string Date
    {
        get { return resDate.DisplayUSFormat(); }
        set
        {
            string[] temp = value.Split('/');
            resDate.Month = Convert.ToInt32(temp[0]);
            resDate.Day = Convert.ToInt32(temp[1]);
            resDate.Year = Convert.ToInt32(temp[2]);

            date = value;
        }
    }
         
    public Reservation()
    {
        this.name = "Nathan Lewis";
        this.date = "11/28/2021";
        this.time = "12:00";
        this.numberOfparty = 5;
    }

    public Reservation(string name, string date, string time, int numberOfparty)
    {
        this.name = name;
        this.date = date;
        this.time = time;
        this.numberOfparty = numberOfparty;

        string[] temp = this.date.Split('/');
        resDate.Month = Convert.ToInt32(temp[0]);
        resDate.Day = Convert.ToInt32(temp[1]);
        resDate.Year = Convert.ToInt32(temp[2]);
    }

    public void Display()
    {
        Console.WriteLine("Reservation name: {0}\nDate: {1} Time: {2} Party of: {3}", Name, Date, Time, NumberOfparty);
    }

    public static bool operator ==(Reservation a, Reservation b)
    {
        if (a.resDate == b.resDate && a.time == b.time && a.name == b.name && a.numberOfparty == b.numberOfparty)
        {
            return true;
        }
        return false;
    }

    public static bool operator !=(Reservation a, Reservation b)
    {
        if (a.resDate != b.resDate || a.time != b.time || a.name != b.name || a.numberOfparty != b.numberOfparty)
        {
            return true;
        }
        return false;
    }

    public static bool operator >(Reservation a, Reservation b)
    {
        if (a.resDate > b.resDate)
        {
            return true;
        }   else if (a.resDate == b.resDate)
        {
            int hourA, minuteA, hourB, minuteB;
            string[] temp = a.time.Split(':');
            hourA = Convert.ToInt32(temp[0]); minuteA = Convert.ToInt32(temp[1]);
            temp = b.time.Split(':');
            hourB = Convert.ToInt32(temp[0]); minuteB = Convert.ToInt32(temp[1]);

            if (hourA > hourB)
            {
                return true;
            }   else if (hourA == hourB && minuteA > minuteB)
            {
                return true;
            }
        }
        return false;
    }

    public static bool operator <(Reservation a, Reservation b)
    {
        if (a.resDate < b.resDate)
        {
            return true;
        }   else if (a.resDate == b.resDate)
        {
            int hourA, minuteA, hourB, minuteB;
            string[] temp = a.time.Split(':');
            hourA = Convert.ToInt32(temp[0]); minuteA = Convert.ToInt32(temp[1]);
            temp = b.time.Split(':');
            hourB = Convert.ToInt32(temp[0]); minuteB = Convert.ToInt32(temp[1]);

            if (hourA < hourB)
            {
                return true;
            }
            else if (hourA == hourB && minuteA < minuteB)
            {
                return true;
            }
        }
        return false;
    }

    public static bool operator >=(Reservation a, Reservation b)
    {
        if (a.resDate > b.resDate)
        {
            return true;
        }   else if (a.resDate == b.resDate)
        {
            int hourA, minuteA, hourB, minuteB;
            string[] temp = a.time.Split(':');
            hourA = Convert.ToInt32(temp[0]); minuteA = Convert.ToInt32(temp[1]);
            temp = b.time.Split(':');
            hourB = Convert.ToInt32(temp[0]); minuteB = Convert.ToInt32(temp[1]);

            if (hourA > hourB)
            {
                return true;
            }
            else if (hourA == hourB && minuteA >= minuteB)
            {
                return true;
            }
        }
        return false;
    }

    public static bool operator <=(Reservation a, Reservation b)
    {
        if (a.resDate < b.resDate)
        {
            return true;
        }   else if (a.resDate == b.resDate)
        {
            int hourA, minuteA, hourB, minuteB;
            string[] temp = a.time.Split(':');
            hourA = Convert.ToInt32(temp[0]); minuteA = Convert.ToInt32(temp[1]);
            temp = b.time.Split(':');
            hourB = Convert.ToInt32(temp[0]); minuteB = Convert.ToInt32(temp[1]);

            if (hourA < hourB)
            {
                return true;
            }
            else if (hourA == hourB && minuteA <= minuteB)
            {
                return true;
            }
        }
        return false;
    }

    public override bool Equals(object obj)
    {
        return obj is Reservation res &&
                name == res.Name &&
                time == res.Time &&
                date == res.Date &&
                numberOfparty == res.NumberOfparty;
    }

    public override int GetHashCode()
    {
        return 1;
    }
}