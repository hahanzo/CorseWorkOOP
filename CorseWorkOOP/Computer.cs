using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;

namespace CorseWorkOOP
{
    [Serializable]
    internal class Computer
    {
        private SystemBlock systemBlock;
        private Monitor monitor;
        private Keyboard keyboard;
        private Mouse mouse;

        public Computer()
        {
            systemBlock = new SystemBlock();
            monitor = new Monitor();
            keyboard = new Keyboard();
            mouse = new Mouse();
        }

        public SystemBlock SystemBlock
        {
            get => systemBlock;
            set => systemBlock = value;
        }

        public Monitor Monitor
        {
            get => monitor;
            set => monitor = value;
        }

        public Keyboard Keyboard
        {
            get => keyboard;
            set => keyboard = value;
        }

        public Mouse Mouse
        {
            get => mouse;
            set => mouse = value;
        }

        public double ComputerPrice => SystemBlock.Price + Monitor.Price + Keyboard.Price + Mouse.Price;
    }
}
