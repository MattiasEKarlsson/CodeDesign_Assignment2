using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    public class WordFacade : IWordFacade
    {
        public List<Word> Words { get; set; }
        public WordFacade()
        {
            Words = new();
        }

        public void SaveWord(string input)
        {
            Words.Add(new Word { InputWord = input });
        }

        public List<string> LoadWords()
        {
            List<string> WordsList = new();
            foreach (var word in Words)
            {
                WordsList.Add($"{word.InputWord}");
            }
            return WordsList;
        }
    }
}
