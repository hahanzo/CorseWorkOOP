using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorseWorkOOP
{
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

        /*public Computer(SystemBlock sysBlock, Monitor mon, Keyboard keyb, Mouse mous)
        {
            SystemBlock = sysBlock;
            Monitor = mon;
            Keyboard = keyb;
            Mouse = mous;
        }*/

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
