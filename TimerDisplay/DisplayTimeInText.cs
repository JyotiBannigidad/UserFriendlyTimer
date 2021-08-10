using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerDisplay
{
    public class DisplayTimeInText
    {
        int hour = 0;
        int minutes = 0;
        DateTime time = DateTime.Now;
        private readonly ConvertTime convertDisplayTime;
        private readonly StandardMessage standardMessage;

        public DisplayTimeInText()
        {
            this.convertDisplayTime = new ConvertTime();
            this.standardMessage = new StandardMessage();
        }

        public void Display()
        {
            standardMessage.StartupMessage();           
            DisplayCurrentTimeInText();
            standardMessage.PrintLine();
            standardMessage.RequestUserInput();
            DisplayUserInputTimeInText();
            standardMessage.ClosingMessage();

        }
        /// <summary>
        /// Display Current Time in Text
        /// </summary>
        private void DisplayCurrentTimeInText()
        {          
            hour = time.Hour;
            minutes = time.Minute;
            convertDisplayTime.DisplayTimeInTextFormat(hour, minutes);           
        }  
        
        /// <summary>
        /// Display user input time in text
        /// </summary>
        public void DisplayUserInputTimeInText()
        {            
            time = Convert.ToDateTime(Console.ReadLine());
            hour = time.Hour;
            minutes = time.Minute;
            convertDisplayTime.DisplayTimeInTextFormat(hour, minutes);        
        }
    }
}
