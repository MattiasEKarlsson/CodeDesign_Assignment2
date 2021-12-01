using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade.FacadeApp
{
    public class FacadeApp : IFacadeApp
    {
        IWordFacade WordFacade;

        public FacadeApp(IWordFacade wordFacade)
        {
            WordFacade = wordFacade;
        }

        public void Run()
        {
            WordFacade.SaveWord("Hejsan");
            WordFacade.SaveWord("Svejsan");

            foreach (var word in WordFacade.LoadWords())
            {
                Console.WriteLine(word);
            }
        }
    }
}
