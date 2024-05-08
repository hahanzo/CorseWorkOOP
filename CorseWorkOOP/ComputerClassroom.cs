using Microsoft.VisualBasic.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        public void AddRange(IEnumerable<Computer> enumerator)
        {
            computers.AddRange(enumerator);
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

        public void SaveToBinaryFile(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fs, computers);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving to binary file: {ex.Message}");
            }
        }

        public void SaveToJsonFile(string filePath)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(computers);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving to JSON file: {ex.Message}");
            }
        }

        public void LoadFromBinaryFile(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    computers = (List<Computer>)formatter.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading from binary file: {ex.Message}");
            }
        }

        public void LoadFromJsonFile(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                computers = JsonSerializer.Deserialize<List<Computer>>(jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading from JSON file: {ex.Message}");
            }
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
