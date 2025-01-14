using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopassig4
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }
        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }
        public override string ToString()
        {
            return $"{Hours}h {Minutes}m {Seconds}s";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Duration other = (Duration)obj;
            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public void Display()
        {
            Console.WriteLine(ToString());
        }
    }
}
