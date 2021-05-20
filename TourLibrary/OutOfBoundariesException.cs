using System;
using System.Collections.Generic;
using System.Text;

namespace TourLibrary
{
    public class OutOfBoundaries : Exception
    {
        public OutOfBoundaries(string message)
         : base(message)
        { }
    }
}

