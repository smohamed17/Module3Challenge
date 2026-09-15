using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module3Challenge.Pages
{
    public class IndexModel : PageModel
    {
        public string HungerMessage { get; set; } = string.Empty;
        public string SoundMessage { get; set; } = string.Empty;
        public string DayMessage { get; set; } = string.Empty;

        public void OnGet()
        {
            // This runs when the page first loads. Nothing to do yet.
        }

        public void OnPost(int hungerLevel, int dayOfWeek)
        {
           if (hungerLevel >= 8)
            {
                HungerMessage = "Roar! I need a big meal!";
            }

            else if (hungerLevel >= 5)
            {
                HungerMessage = "Ohh ohh! I'll take some bananas.";
            }

            else 
            {
                HungerMessage = "Slow and steady, I'll have some lettuce";
            }

            SoundMessage = (hungerLevel >= 8) ? "Listen to the Lion: Roar!" : "Listen to the Monkey: Ooh ooh!";

            switch (dayOfWeek)
            {
                
            }
        }
    }
}