using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    public  class Service : IService
    {
        ReturningStrings returnString = new ReturningStrings();
        public int ConvertStringToInt()
        {
            return Int32.Parse(returnString.ReturnString());
        }
    }
}
