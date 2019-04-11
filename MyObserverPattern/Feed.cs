using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyObserverPattern
{
    //Subject class

    public class Feed
    {
        private bool _foodReady;
        private List<IHorse> _horses = new List<IHorse>();

        public bool FoodReady
        {
            get => _foodReady;
            set
            {
                _foodReady = value;
                Notify();
            }
        }

        public Feed(bool foodReady)
        {
            FoodReady = foodReady;
        }

        public void Add(IHorse horse)
        {
            _horses.Add(horse);
        }

        public void Remove(IHorse horse)
        {
            _horses.Remove(horse);
        }

        public void Notify()
        {
            foreach (var horse in _horses)
            {
                horse.Update(this);
            }
            Console.WriteLine("");
        }
    }
}
