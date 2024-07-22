using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5OOPThirdProject.Classes
{
    internal class Duration
    {
        #region Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; } 
        #endregion

        #region Methods
        public Duration(int _hours, int _minutes, int _seconds)
        {
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _seconds;
            NormalizeTime();
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
            NormalizeTime();
        }

        // Method to normalize time representation (handle overflow)
        private void NormalizeTime()
        {
            Minutes += Seconds / 60;
            Seconds %= 60;
            Hours += Minutes / 60;
            Minutes %= 60;
        }


        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Duration otherDuration = (Duration)obj;
            return Hours == otherDuration.Hours && Minutes == otherDuration.Minutes && Seconds == otherDuration.Seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            else if (Minutes > 0)
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            else
                return $"Seconds: {Seconds}";
        } 

        private int TotalSeconds
        {
            get
            {return Hours * 3600 + Minutes * 60 + Seconds;}
        }

        // Add two Durations
        public static Duration operator +(Duration duration1, Duration duration2)
        {
            int totalSeconds = duration1.TotalSeconds + duration2.TotalSeconds;
            return new Duration(totalSeconds);
        }
        // Add seconds to Duration
        public static Duration operator +(Duration D, int seconds)
        {
            int totalSeconds = D.TotalSeconds + seconds;
            return new Duration(totalSeconds);
        }
        // Add Duration to the seconds
        public static Duration operator +(int seconds, Duration D)
        {
            
            return D + seconds;
        }
        // increment Minutes by 1
        public static Duration operator ++(Duration D)
        {
            D.Minutes++;
            D.NormalizeTime();
            return D;
        }

        // decrement Minutes by 1
        public static Duration operator --(Duration D)
        {
            D.Minutes--;
            if (D.Minutes < 0)
            {
                D.Minutes += 60;
                D.Hours--;
            }
            return D;
        }
        // Subtract two Durations
        public static Duration operator -(Duration duration1, Duration duration2)
        {
            int totalSeconds = duration1.TotalSeconds - duration2.TotalSeconds;
            return new Duration(totalSeconds);
        }

        public static bool operator >(Duration duration1, Duration duration2)
        {
            return duration1.TotalSeconds > duration2.TotalSeconds;
        }

        public static bool operator <(Duration duration1, Duration duration2)
        {
            return duration1.TotalSeconds < duration2.TotalSeconds;
        }


        public static bool operator <=(Duration duration1, Duration duration2)
        {
            return !(duration1 > duration2);
        }

        public static bool operator >=(Duration duration1, Duration duration2)
        {
            return !(duration1 < duration2);
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }
        #endregion
    }
}
