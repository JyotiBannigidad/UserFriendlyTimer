using System;

namespace TimerDisplay
{
    public class Program
    {
        
        static void Main(string[] args)
        {            
            try
            {
                
                var displayTimeText = new DisplayTimeInText();
                displayTimeText.Display();              
            }
            catch (Exception ex)
            {                
                Console.WriteLine($"Exception occurred {ex}.");
            }            
        }

       
    }
}
