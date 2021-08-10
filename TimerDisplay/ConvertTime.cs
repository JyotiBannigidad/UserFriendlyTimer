using System;


namespace TimerDisplay
{
    public class ConvertTime
    {
        public void DisplayTimeInTextFormat(int hour, int minutes)
        {
            try
            {
                int twelveHrFormat = ConvertTo12HrFormat(hour, minutes);
                switch (minutes)
                {
                    case 0:
                        Console.WriteLine($"{Constants.TimeTextValues[twelveHrFormat]} {Constants.hourlyText}.");
                        break;
                    case 15:
                        Console.WriteLine($"{Constants.quarterPast} {Constants.TimeTextValues[twelveHrFormat]}.");
                        break;
                    case 30:
                        Console.WriteLine($"{Constants.halfHr} {Constants.TimeTextValues[twelveHrFormat]}.");
                        break;
                    case 45:
                        Console.WriteLine($"{Constants.quarterTo} {Constants.TimeTextValues[twelveHrFormat]}.");
                        break;
                    default:
                        if (minutes > 0 && minutes != 15 && minutes < 30)
                        {
                            Console.WriteLine($"{Constants.TimeTextValues[minutes]} past {Constants.TimeTextValues[twelveHrFormat]}.");
                        }
                        else if (minutes > 30 && minutes != 45 && minutes <= 59)
                        {
                            Console.WriteLine($"{Constants.TimeTextValues[60 - minutes]} to {Constants.TimeTextValues[twelveHrFormat]}.");
                        }
                        break;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception is:" + ex);
            }
        }

        private int ConvertTo12HrFormat(int hr, int min)
        {
            int twelveHrFormat = hr;
            if (hr > 12)
            {
                twelveHrFormat = hr -= 12;
            }

            if (min > 30 && min < 59)
            {
                twelveHrFormat += 1;
            }
            return twelveHrFormat;
        }
    }
}
