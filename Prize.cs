using System;

namespace Quest
{
    public class Prize
    {
        private string _text { get; set; }

        public Prize(string text)
        {
            _text = text;
        }

        public void ShowPrize(Adventurer theAdventurer)
        {
            if (theAdventurer.Awesomeness > 0)
            {
                for (int i = 0; i < theAdventurer.Awesomeness; i++)
                {
                    Console.WriteLine($"{_text}");
                }
            }
            else
            {
                Console.WriteLine("Oh, sorry you suck.");
            }
        }
    }
}