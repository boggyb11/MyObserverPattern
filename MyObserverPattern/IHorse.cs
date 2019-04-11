using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyObserverPattern
{
    //observer
    public interface IHorse
    {
        void Update(Feed feed);
    }
}
