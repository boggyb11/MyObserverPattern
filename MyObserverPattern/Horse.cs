using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyObserverPattern
{
    public class Horse : IHorse
    {
        private string _name;
        private Feed _feed;

        public Feed Feed { get => _feed; set => _feed = value; }

        public Horse(string name)
        {
            _name = name;
        }

        public void Update(Feed feed)
        {
            Console.WriteLine($"Notified {_name} the status of the hay: {feed.FoodReady}"); 
        }
    }
}
