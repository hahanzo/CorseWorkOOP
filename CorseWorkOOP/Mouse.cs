using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseWorkOOP
{
    [Serializable]
    internal class Mouse
    {
        private string mouseType;
        private int buttonsCount;
        private double price;

        public Mouse()
        {
            mouseType = "Unknown";
            buttonsCount = 0;
            price = 0;
        }

        public Mouse(string type, int count, double cost)
        {
            MouseType = type;
            ButtonsCount = count;
            Price = cost;
        }

        ~Mouse() { }

        public string MouseType
        {
            get => mouseType;
            set => mouseType = value;
        }

        public int ButtonsCount
        {
            get => buttonsCount;
            set => buttonsCount = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }
    }
}
