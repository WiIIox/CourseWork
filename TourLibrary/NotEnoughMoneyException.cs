using System;
using System.Collections.Generic;
using System.Text;

namespace TourLibrary
{
    public class NotEnoughMoneyException : Exception
    {
        public NotEnoughMoneyException(string message)
         : base(message)
        { }
    }
}
