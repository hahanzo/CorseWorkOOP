using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseWorkOOP
{
    [Serializable]
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

        public string ProcessorType
        {
            get => processorType;
            set => processorType = value;
        }

        public int ClockSpeed
        {
            get => clockSpeed;
            set => clockSpeed = value;
        }

        public int HardDriveCapacity
        {
            get => hardDriveCapacity;
            set => hardDriveCapacity = value;
        }

        public bool HasCdDrive
        {
            get => hasCdDrive;
            set => hasCdDrive = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }
    }
}
