using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseWorkOOP
{
    internal class Monitor
    {
        private double screenSize;
        private string resolution;
        private double price;

        public Monitor()
        {
            screenSize = 0;
            resolution = "Unknown";
            price = 0;
        }

        public Monitor(double size, string res, double cost)
        {
            ScreenSize = size;
            Resolution = res;
            Price = cost;
        }

        public double ScreenSize
        {
            get { return screenSize; }
            set { screenSize = value; }
        }

        public string Resolution
        {
            get { return resolution; }
            set { resolution = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
