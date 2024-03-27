using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseWorkOOP
{
    internal class ComputerClassroom : IEnumerable<Computer>, IEnumerator<Computer>
    {
        private List<Computer> computers;
        private int count;
        private int currentIndex = -1;

        public ComputerClassroom()
        {
            computers = new List<Computer>();
        }

        public ComputerClassroom(int count)
        {
            computers = new List<Computer>(count);
            this.count = count;
        }

        public void AddComputer(Computer computer)
        {
            computers.Add(computer);
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (Computer computer in computers)
            {
                totalPrice += computer.ComputerPrice;
            }
            return totalPrice;
        }

        public IEnumerator<Computer> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Computer Current => computers[currentIndex];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < computers.Count;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public void Dispose()
        {
            Reset();
        }
    }
}
