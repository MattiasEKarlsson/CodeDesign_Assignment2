using System.Collections.Generic;

namespace Assignment2.Facade
{
    public interface IWordFacade
    {
        List<Word> Words { get; set; }

        List<string> LoadWords();
        void SaveWord(string input);
    }
}