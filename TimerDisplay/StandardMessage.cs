using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerDisplay
{
    public class StandardMessage
    {
        public void StartupMessage()
        {
            Console.WriteLine("Display current time in Human Friendly Text.\n");
        }

        public void PrintLine()
        {
            Console.WriteLine("\n--------------------------------------------------------------\n");
            
        }
        public void RequestUserInput()
        {            
            Console.WriteLine("Display User Input in Human Friendly Text.\n\nPlease enter the time in the format HH:mm \n");
        }

        public void ClosingMessage()
        {
            Console.WriteLine("\nCompleted.");
        }
        public void DisplayCustomMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
