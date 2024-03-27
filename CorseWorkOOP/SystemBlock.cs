using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseWorkOOP
{
    internal class SystemBlock
    {
        private string processorType;
        private int clockSpeed;
        private int hardDriveCapacity;
        private bool hasCdDrive;
        private double price;

        public SystemBlock()
        {
            processorType = "Unknown";
            clockSpeed = 0;
            hardDriveCapacity = 0;
            hasCdDrive = false;
            price = 0;
        }

        public SystemBlock(string processor, int speed, int capacity, bool hasCd, double cost)
        {
            ProcessorType = processor;
            ClockSpeed = speed;
            HardDriveCapacity = capacity;
            HasCdDrive = hasCd;
            Price = cost;
        }

        public string ProcessorType
        {
            get { return processorType; }
            set { processorType = value; }
        }

        public int ClockSpeed
        {
            get { return clockSpeed; }
            set { clockSpeed = value; }
        }

        public int HardDriveCapacity
        {
            get { return hardDriveCapacity; }
            set { hardDriveCapacity = value; }
        }

        public bool HasCdDrive
        {
            get { return hasCdDrive; }
            set { hasCdDrive = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
