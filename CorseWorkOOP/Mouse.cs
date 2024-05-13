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

        public string MouseType
        {
            get => mouseType;
            set => mouseType = value;
        }

        public int ButtonCount
        {
            get => buttonCount;
            set => buttonCount = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }
    }
}
