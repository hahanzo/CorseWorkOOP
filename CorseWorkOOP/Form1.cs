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

            ProcessorTypeTextBox.Text = " Intel Core i5-9400F";
            ClockSpeedTextBox.Text = "2900";
            HardDriveCapacityTextBox.Text = "500";
            HasCdDriveCheckBox.Checked = false;
            SystemBlockPriceTextBox.Text = "30000";

            ScreenSizeTextBox.Text = "23,8";
            ResolutionTextBox.Text = "1920x1080";
            MonitorPriceTextBox.Text = "4000";

            KeyboardTypeTextBox.Text = "Механічна";
            KeyCountTextBox.Text = "40";
            KeyboardPriceTextBox.Text = "2000";

            MouseTypeTextBox.Text = "Оптична";
            ButtonCountTextBox.Text = "4";
            MousePriceTextBox.Text = "1000";
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

            // Create a computer object with the entered data
            Computer computer = new Computer()
            {
                SystemBlock = new SystemBlock
                {
                    ProcessorType = ProcessorTypeTextBox.Text,
                    ClockSpeed = Convert.ToInt32(ClockSpeedTextBox.Text),
                    HardDriveCapacity = Convert.ToInt32(HardDriveCapacityTextBox.Text),
                    HasCdDrive = HasCdDriveCheckBox.Checked,
                    Price = Convert.ToDouble(SystemBlockPriceTextBox.Text)
                },
                Monitor = new Monitor
                {
                    ScreenSize = Convert.ToDouble(ScreenSizeTextBox.Text),
                    Resolution = ResolutionTextBox.Text,
                    Price = Convert.ToDouble(MonitorPriceTextBox.Text)
                },
                Keyboard = new Keyboard
                {
                    KeyboardType = KeyboardTypeTextBox.Text,
                    KeyCount = Convert.ToInt32(KeyCountTextBox.Text),
                    Price = Convert.ToDouble(KeyboardPriceTextBox.Text)
                },
                Mouse = new Mouse
                {
                    MouseType = MouseTypeTextBox.Text,
                    ButtonCount = Convert.ToInt32(ButtonCountTextBox.Text),
                    Price = Convert.ToDouble(MousePriceTextBox.Text)
                }
            };

            // Add the computer to the list
            computerClassroom.AddComputer(computer);

            // Update the computer list on the form
            UpdateComputerList();
        }

        private void ShowComputerPriceButton_Click(object sender, EventArgs e)
        {
            // Check if there is at least one row in DataGridView
            if (computerDataGridView.RowCount > 0)
            {
                // Get the current row where the focus is
                int rowIndex = computerDataGridView.CurrentCell?.RowIndex ?? -1;

                // Check if the focus is on a correct row
                if (rowIndex >= 0)
                {
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
                    MessageBox.Show("Неможливо визначити обраний рядок.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Неможливо визначити обраний рядок. Дані відсутні.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void TotalPriceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total Price: ${computerClassroom.CalculateTotalPrice()}", "Total Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void ClearListButton_Click(object sender, EventArgs e)
        {
            computerClassroom = new ComputerClassroom();
            UpdateComputerList();
        }

        // Add columns to the DataGridView
        private void InitializeDataGridView()
        {
            computerDataGridView.Columns.Add("ProcessorTypeColumn", "Processor Type");
            computerDataGridView.Columns.Add("ClockSpeedColumn", "Clock Speed");
            computerDataGridView.Columns.Add("HardDriveCapacityColumn", "Hard Drive Capacity");
            computerDataGridView.Columns.Add("HasCdDriveColumn", "Has CD Drive");
            computerDataGridView.Columns.Add("SystemBlockPriceColumn", "System Block Price");
            computerDataGridView.Columns.Add("ScreenSizeColumn", "Screen Size");
            computerDataGridView.Columns.Add("ResolutionColumn", "Resolution");
            computerDataGridView.Columns.Add("MonitorPriceColumn", "Monitor Price");
            computerDataGridView.Columns.Add("KeyboardTypeColumn", "Keyboard Type");
            computerDataGridView.Columns.Add("KeyCountColumn", "Key Count");
            computerDataGridView.Columns.Add("KeyboardPriceColumn", "Keyboard Price");
            computerDataGridView.Columns.Add("MouseTypeColumn", "Mouse Type");
            computerDataGridView.Columns.Add("ButtonCountColumn", "Button Count");
            computerDataGridView.Columns.Add("MousePriceColumn", "Mouse Price");
        }

        // Update the list of computers on the form
        private void UpdateComputerList()
        {
            computerDataGridView.Rows.Clear();

            foreach (var computer in computerClassroom)
            {
                int rowIndex = computerDataGridView.Rows.Add(
                    computer.SystemBlock.ProcessorType,
                    computer.SystemBlock.ClockSpeed,
                    computer.SystemBlock.HardDriveCapacity,
                    computer.SystemBlock.HasCdDrive ? "Yes" : "No",
                    computer.SystemBlock.Price,
                    computer.Monitor.ScreenSize,
                    computer.Monitor.Resolution,
                    computer.Monitor.Price,
                    computer.Keyboard.KeyboardType,
                    computer.Keyboard.KeyCount,
                    computer.Keyboard.Price,
                    computer.Mouse.MouseType,
                    computer.Mouse.ButtonCount,
                    computer.Mouse.Price
                );
            }
        }
    }
}