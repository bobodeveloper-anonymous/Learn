using System;

namespace Learn.ClockInMirror
{
    public class Clock
    {
        public string WhatIsTheTime(string time)
        {
            int hours = GetHours(time);
            int minutes = GetMinutes(time);


            if (IsCenter(hours, minutes))
            {
                return time;
            }

            int mirrorHours = 0;
            int mirrorMinutes = 0;




            mirrorHours = 12 - hours;
            if (HaveMinutes(minutes))
                mirrorHours -= 1;
            mirrorHours = mirrorHours <= 0 ? mirrorHours + 12 : mirrorHours;

            mirrorMinutes = (60 - minutes) % 60;

            string mirrorTime = BuildMirrorTime(mirrorHours, mirrorMinutes);

            return mirrorTime;
        }

        private bool HourOnCenter(int hours, int minutes)
        {
            return hours == 6 || hours == 12;
        }

        private bool HaveMinutes(int minutes)
        {
            return minutes != 0;
        }

        private int GetHours(string time)
        {
            return Int32.Parse(time.Split(':')[0]);
        }

        private int GetMinutes(string time)
        {
            return Int32.Parse(time.Split(':')[1]);
        }

        private bool HourOnLeft(int hours, int minutes)
        {
            if (hours > 6 && hours < 12)
                return true;
            if (hours == 6 && minutes > 0)
                return true;
            return false;
        }

        private bool HourOnRight(int hours, int minutes)
        {
            return !HourOnLeft(hours, minutes);
        }

        private bool IsCenter(int hours, int minutes)
        {
            return minutes == 0 && (hours == 6 || hours == 12);
        }

        private string BuildMirrorTime(int mirrorHour, int mirrorMinute)
        {
            return mirrorHour.ToString("D2") + ":" + mirrorMinute.ToString("D2");
        }
    }
}
