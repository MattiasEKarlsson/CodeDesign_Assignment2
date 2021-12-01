using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter.AdapterApp
{
    public class AdapterApp : IAdapterApp
    {
        

        public void Run()
        {
            IService service = new Service();
            PrintingInts printingInts = new PrintingInts();

            printingInts.Print(service.ConvertStringToInt());
        }
    }
}
