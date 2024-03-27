using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseWorkOOP
{
    internal class Mouse
    {
        private string mouseType;
        private int buttonCount;
        private double price;

        public Mouse()
        {
            mouseType = "Unknown";
            buttonCount = 0;
            price = 0;
        }

        public Mouse(string type, int count, double cost)
        {
            MouseType = type;
            ButtonCount = count;
            Price = cost;
        }

        public string MouseType
        {
            get { return mouseType; }
            set { mouseType = value; }
        }

        public int ButtonCount
        {
            get { return buttonCount; }
            set { buttonCount = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
