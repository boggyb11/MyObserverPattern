using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyObserverPattern
{
    class Hay : Feed
    {
        public Hay(bool foodReady) : base(foodReady)
        {
        }
    }
}
