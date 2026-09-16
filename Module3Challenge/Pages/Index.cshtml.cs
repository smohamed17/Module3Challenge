using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module3Challenge.Pages
{
    public class IndexModel : PageModel
    {
        public string HungerMessage { get; set; } = string.Empty;
        public string SoundMessage { get; set; } = string.Empty;
        public string DayMessage { get; set; } = string.Empty;

        public bool ShowResults {get; set; } = false; // you must use show results in order for it to be displayed on the webpage. 

        public void OnGet()
        {
            // This runs when the page first loads. Nothing to do yet.
        }

        public void OnPost(int hungerLevel, int dayOfWeek)
        {
            
            ShowResults = true;

           if (hungerLevel >= 8) // this will focus on the if the hunger level is above 8 
            {
                HungerMessage = "Roar! I need a big meal!";
            }

            else if (hungerLevel >= 5) // in the range between 5 and just before 8. 
            {
                HungerMessage = "Ohh ohh! I'll take some bananas.";
            }

            else // if this was anything under 5 in the hunger level. 
            {
                HungerMessage = "Slow and steady, I'll have some lettuce";
            }

            SoundMessage = (hungerLevel >= 8) ? "Listen to the Lion: Roar!" : "Listen to the Monkey: Ooh ooh!"; // the sound will be displayed on the webpage by using the tenary. 

            switch (dayOfWeek)
            { // depending on the day itself, it will display an event that will take place during the day of the week using switch statements. 
                case 7: 
                DayMessage = "Zebra's moose cake party on a Saturday ";
                break;

                case 6: 
                DayMessage = "Gorillas'dancing event on a Friday ";
                break;

                case 5: 
                DayMessage = "Swimming with the fishes on a Thursday";
                break;

                case 4: 
                DayMessage = "A drinking party with the snakes on a Wednesday";
                break;

                case 3: 
                DayMessage = "Drawing pictures with the giraffes on a Tuesday  ";
                break;

                case 2: 
                DayMessage = "A mini dj-set party from birds on a Monday";
                break;

                case 1:
                DayMessage = "Sunday morning jogging with the spiders and bees";
                break;

                default: 
                DayMessage = "No events will occur on this day.";
                break;
            }
        }
    }
}