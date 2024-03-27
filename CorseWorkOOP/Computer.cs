using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseWorkOOP
{
    internal class Computer
    {
        private SystemBlock systemBlock;
        private Monitor monitor;
        private Keyboard keyboard;
        private Mouse mouse;
        private double computerPrice;

        public Computer()
        {
            systemBlock = new SystemBlock();
            monitor = new Monitor();
            keyboard = new Keyboard();
            mouse = new Mouse();
            computerPrice = 0;
        }

        public Computer(SystemBlock sysBlock, Monitor mon, Keyboard keyb, Mouse mous)
        {
            SystemBlock = sysBlock;
            Monitor = mon;
            Keyboard = keyb;
            Mouse = mous;
            ComputerPrice = sysBlock.Price + mon.Price + keyb.Price + mous.Price;
        }

        public SystemBlock SystemBlock
        {
            get { return systemBlock; }
            set { systemBlock = value; }
        }

        public Monitor Monitor
        {
            get { return monitor; }
            set { monitor = value; }
        }

        public Keyboard Keyboard
        {
            get { return keyboard; }
            set { keyboard = value; }
        }

        public Mouse Mouse
        {
            get { return mouse; }
            set { mouse = value; }
        }

        public double ComputerPrice
        {
            get { return computerPrice; }
            set { computerPrice = value; }
        }
    }
}
