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
            // Перевірки для текстових значень
            if (string.IsNullOrWhiteSpace(ProcessorTypeTextBox.Text))
            {
                MessageBox.Show("Будь ласка, введіть тип процесора.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(ClockSpeedTextBox.Text))
            {
                MessageBox.Show("Будь ласка, введіть тактову частоту процесора.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(HardDriveCapacityTextBox.Text))
            {
                MessageBox.Show("Будь ласка, введіть об'єм жорсткого диска.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(ResolutionTextBox.Text))
            {
                MessageBox.Show("Будь ласка, введіть роздільну здатність екрану.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Перевірки для числових значень
            double screenSize, systemBlockPrice, monitorPrice, keyboardPrice, mousePrice;
            int keyCount, buttonCount;

            if (!double.TryParse(ScreenSizeTextBox.Text, out screenSize) || screenSize <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректний розмір екрану.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (screenSize < 0)
            {
                MessageBox.Show("Розмір екрану не може бути від'ємним.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(SystemBlockPriceTextBox.Text, out systemBlockPrice) || systemBlockPrice <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну ціну системного блоку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (systemBlockPrice < 0)
            {
                MessageBox.Show("Ціна системного блоку не може бути від'ємною.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(MonitorPriceTextBox.Text, out monitorPrice) || monitorPrice <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну ціну монітора.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (monitorPrice < 0)
            {
                MessageBox.Show("Ціна монітора не може бути від'ємною.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(KeyCountTextBox.Text, out keyCount) || keyCount <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну кількість клавіш.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (keyCount < 0)
            {
                MessageBox.Show("Кількість клавіш не може бути від'ємною.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(KeyboardPriceTextBox.Text, out keyboardPrice) || keyboardPrice <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну ціну клавіатури.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (keyboardPrice < 0)
            {
                MessageBox.Show("Ціна клавіатури не може бути від'ємною.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(ButtonCountTextBox.Text, out buttonCount) || buttonCount <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну кількість кнопок миші.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (buttonCount < 0)
            {
                MessageBox.Show("Кількість кнопок миші не може бути від'ємною.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(MousePriceTextBox.Text, out mousePrice) || mousePrice <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну ціну миші.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (mousePrice < 0)
            {
                MessageBox.Show("Ціна миші не може бути від'ємною.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Створюємо об'єкт комп'ютера з введеними даними
            Computer computer = new Computer
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

            // Додаємо комп'ютер до списку
            computerClassroom.AddComputer(computer);

            // Оновлюємо список комп'ютерів на формі
            UpdateComputerList();
        }

        private void ShowComputerPriceButton_Click(object sender, EventArgs e)
        {
            // Перевірка, чи існує вибраний рядок
            if (computerDataGridView.SelectedRows.Count > 0)
            {
                // Отримання індексу виділеного рядка
                int selectedIndex = computerDataGridView.SelectedRows[0].Index;

                // Отримання комп'ютера з відповідного рядка
                Computer selectedComputer = computerDataGridView.Rows[selectedIndex].DataBoundItem as Computer;

                // Перевірка, чи вдалося отримати комп'ютер
                if (selectedComputer != null)
                {
                    // Виведення ціни комп'ютера у MessageBox
                    MessageBox.Show($"Ціна комп'ютера: {selectedComputer.ComputerPrice}", "Ціна комп'ютера", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Виведення повідомлення, якщо жоден рядок не вибрано
                MessageBox.Show("Будь ласка, виберіть комп'ютер для перегляду ціни.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void TotalPriceButton_Click(object sender, EventArgs e)
        {
            // Виведення загальної ціни у MessageBox
            MessageBox.Show($"Total Price: ${computerClassroom.CalculateTotalPrice()}", "Total Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void ClearListButton_Click(object sender, EventArgs e)
        {
            // Очищаємо список комп'ютерів
            computerClassroom = new ComputerClassroom();
            UpdateComputerList();
        }

        // Додавання колонок до DataGridView
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

        // Оновлення списку комп'ютерів на формі
        private void UpdateComputerList()
        {
            // Очищення даних у DataGridView
            computerDataGridView.Rows.Clear();

            // Додавання кожного комп'ютера до DataGridView
            foreach (var computer in computerClassroom)
            {
                // Додавання рядка з даними про комп'ютер у DataGridView
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