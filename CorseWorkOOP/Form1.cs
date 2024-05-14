using System.Data;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CorseWorkOOP
{
    public partial class Form1 : Form
    {
        private ComputerClassroom computerClassroom;

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();

            computerClassroom = new ComputerClassroom();
        }

        // Add columns to the DataGridView
        private void InitializeDataGridView()
        {
            computerDataGridView.Columns.Add("System Block", "Системний блок");
            computerDataGridView.Columns.Add("Monitor", "Монітор");
            computerDataGridView.Columns.Add("Kyeboard", "Клавіатура");
            computerDataGridView.Columns.Add("Mouse", "Миша");
        }

        // Update the list of computers on the form
        private void UpdateComputerList()
        {
            computerDataGridView.Rows.Clear();

            foreach (var computer in computerClassroom)
            {
                    computerDataGridView.Rows.Add(
                    computer.SystemBlock.ProcessorType + "," +
                    computer.SystemBlock.ClockSpeed + "," +
                    computer.SystemBlock.HardDriveCapacity + "," +
                    (computer.SystemBlock.HasCdDrive ? "Yes" : "No") + ",$" +
                    computer.SystemBlock.Price,
                    computer.Monitor.ScreenSize + "," +
                    computer.Monitor.Resolution + ",$" +
                    computer.Monitor.Price,
                    computer.Keyboard.KeyboardType + "," +
                    computer.Keyboard.KeyCount + ",$" +
                    computer.Keyboard.Price,
                    computer.Mouse.MouseType + "," +
                    computer.Mouse.ButtonsCount + ",$" +
                    computer.Mouse.Price
                );
            }
        }

        private void AddComputerButton_Click(object sender, EventArgs e)
        {
            // Checks for text values
            if (string.IsNullOrWhiteSpace(ProcessorTypeTextBox.Text))
            {
                MessageBox.Show("Будь ласка, введіть тип процесора.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(ResolutionTextBox.Text))
            {
                MessageBox.Show("Будь ласка, введіть роздільну здатність екрану.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Checks for numerical values
            double screenSize, systemBlockPrice, monitorPrice, keyboardPrice, mousePrice;
            int clockSpeed, hardDriveCapacity, keyCount, buttonCount;

            if (!int.TryParse(ClockSpeedTextBox.Text, out clockSpeed) || clockSpeed <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну (додатне число) тактову частоту процесора.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(HardDriveCapacityTextBox.Text, out hardDriveCapacity) || hardDriveCapacity <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректний (додатне число) об'єм жорсткого диска.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(ScreenSizeTextBox.Text, out screenSize) || screenSize <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректний (додатне число) розмір екрану.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(SystemBlockPriceTextBox.Text, out systemBlockPrice) || systemBlockPrice <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну (додатне число) ціну системного блоку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(MonitorPriceTextBox.Text, out monitorPrice) || monitorPrice <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну (додатне число) ціну монітора.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(KeyCountTextBox.Text, out keyCount) || keyCount <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну (додатне число) кількість клавіш.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(KeyboardPriceTextBox.Text, out keyboardPrice) || keyboardPrice <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну (додатне число) ціну клавіатури.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(ButtonCountTextBox.Text, out buttonCount) || buttonCount <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну (додатне число) кількість кнопок миші.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(MousePriceTextBox.Text, out mousePrice) || mousePrice <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну (додатне число) ціну миші.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create separate objects for each component
            SystemBlock systemBlock = new SystemBlock
            {
                ProcessorType = ProcessorTypeTextBox.Text,
                ClockSpeed = Convert.ToInt32(ClockSpeedTextBox.Text),
                HardDriveCapacity = Convert.ToInt32(HardDriveCapacityTextBox.Text),
                HasCdDrive = HasCdDriveCheckBox.Checked,
                Price = Convert.ToDouble(SystemBlockPriceTextBox.Text)
            };

            Monitor monitor = new Monitor
            {
                ScreenSize = Convert.ToDouble(ScreenSizeTextBox.Text),
                Resolution = ResolutionTextBox.Text,
                Price = Convert.ToDouble(MonitorPriceTextBox.Text)
            };

            Keyboard keyboard = new Keyboard
            {
                KeyboardType = KeyboardTypeTextBox.Text,
                KeyCount = Convert.ToInt32(KeyCountTextBox.Text),
                Price = Convert.ToDouble(KeyboardPriceTextBox.Text)
            };

            Mouse mouse = new Mouse
            {
                MouseType = MouseTypeTextBox.Text,
                ButtonsCount = Convert.ToInt32(ButtonCountTextBox.Text),
                Price = Convert.ToDouble(MousePriceTextBox.Text)
            };

            // Create a computer object using aggregation
            Computer computer = new Computer(systemBlock, monitor, keyboard, mouse);

            // Add the computer to the list
            computerClassroom.AddComputer(computer);

            // Update the computer list on the form
            UpdateComputerList();
        }

        private void DeleteComputerButton_Click(object sender, EventArgs e)
        {
            if (computerDataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = computerDataGridView.SelectedCells[0].RowIndex;

                computerClassroom.RomoveByIndex(rowIndex);

                UpdateComputerList();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void ShowComputerPriceButton_Click(object sender, EventArgs e)
        {
            // Check if there is at least one row in DataGridView
            if (computerDataGridView.RowCount > 1)
            {
                // Get the current row where the focus is
                int rowIndex = computerDataGridView.CurrentCell.RowIndex;

                // Get the Computer object from the list at the specified index
                Computer selectedComputer = computerClassroom.ElementAtOrDefault(rowIndex);

                // Check if successfully retrieved a Computer object
                if (selectedComputer != null)
                {
                    MessageBox.Show($"Ціна комп'ютера: {selectedComputer.ComputerPrice}", "Ціна комп'ютера", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Неможливо визначити ціну комп'ютера для обраної клітинки.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Неможливо визначити обраний рядок. Дані відсутні.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TotalPriceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Загальна ціна: ${computerClassroom.CalculateTotalPrice()}", "Загальна ціна", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            computerClassroom.Computers.Clear();
            UpdateComputerList();
        }

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Binary files (*.bin)|*.bin|JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                string fileExtension = Path.GetExtension(saveFileDialog1.FileName);

                try
                {
                    if (fileExtension.Equals(".bin", StringComparison.OrdinalIgnoreCase))
                        computerClassroom.SaveToBinaryFile(filePath);
                    else
                        computerClassroom.SaveToJsonFile(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при зберіганні колекції: {ex.Message}");
                }
            }
        }

        private void DeserialzeButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Binary files (*.bin)|*.bin|JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            ComputerClassroom deserializeComp = new ComputerClassroom();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

                string fileExtension = Path.GetExtension(selectedFileName);
                try
                {
                    if (fileExtension.Equals(".bin", StringComparison.OrdinalIgnoreCase))
                    {
                        deserializeComp.LoadFromBinaryFile(selectedFileName);
                    }
                    else if (fileExtension.Equals(".json", StringComparison.OrdinalIgnoreCase))
                    {
                        deserializeComp.LoadFromJsonFile(selectedFileName);
                    }
                    else
                    {
                        MessageBox.Show("Не пітримуємий формат файлу.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка загрузки колекції: {ex.Message}");
                }

                computerClassroom.AddRange(deserializeComp);
            }

            UpdateComputerList();
        }
    }
}