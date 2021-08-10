using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerDisplay
{
    public class Constants
    {

        public static readonly string[] TimeTextValues =
            {
               "zero","one","two","three","four","five","six","seven","eight","nine","ten",
               "eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen","twenty",
               "twentyone","twentytwo", "twentythree", "twentyfour","twentyfive","twentysix","twentyseven","twentyeight","twentynine","thirty"
               
            };
        

        public const string hourlyText = "\'\0o clock";
        public const string halfHr = "half past";
        public const string quarterTo = "quarter to";
        public const string quarterPast = "quarter past";
    }
}
