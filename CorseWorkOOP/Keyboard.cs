using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseWorkOOP
{
    internal class Keyboard
    {
        private string keyboardType;
        private int keyCount;
        private double price;

        public Keyboard()
        {
            keyboardType = "Unknown";
            keyCount = 0;
            price = 0;
        }

        public Keyboard(string type, int count, double cost)
        {
            KeyboardType = type;
            KeyCount = count;
            Price = cost;
        }

        public string KeyboardType
        {
            get => keyboardType;
            set => keyboardType = value;
        }

        public int KeyCount
        {
            get => keyCount;
            set => keyCount = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }
    }
}
