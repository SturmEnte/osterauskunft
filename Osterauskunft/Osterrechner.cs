
namespace Osterauskunft
{
    internal class Osterrechner
    {
    
        public static int[] calculateEeasterDate(int year)
        {
            int day = 1;
            int month = 1;

            int m, n;

            if (1800 <= year && year <= 1899) 
            {
                m = 23;
                n = 4;
            } else if(1900 <= year && year <= 2099)
            {
                m = 24;
                n = 5;
            } else if(2100 <= year && year <= 2199)
            {
                m = 24;
                n = 6;
            } else
            {
                return [-1, -1];
            }

            int a = year % 19;
            int b = year % 4;
            int c = year % 7;
            int d = (19 * a + m) % 30;
            int e = (2 * b + 4 * c + 6 * d + n) % 7;

            int marchDay = (22 + e + d);
            int aprilDay = (d + e - 9);

            if(marchDay <= 31)
            {
                day = marchDay;
                month = 3;
            } else
            {
                day = aprilDay;
                month = 4;
            }

            if (month == 4 && day == 26) day = 19;
            if (month == 4 && day == 25 && d == 28 && e == 6 && a >= 10) day = 18;

            return [day, month];
        }

    }
}
