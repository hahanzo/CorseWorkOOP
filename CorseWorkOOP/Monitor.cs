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

        public double ScreenSize
        {
            get => screenSize;
            set => screenSize = value;
        }

        public string Resolution
        {
            get => resolution;
            set => resolution = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }
    }
}
