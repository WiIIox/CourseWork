using System;
using System.Collections.Generic;
using System.Text;

namespace TourLibrary
{
    public class LessThenZeroException : Exception
    {
        public LessThenZeroException(string message)
         : base(message)
        { }
    }
}

