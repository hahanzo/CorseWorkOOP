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

            KeyboardTypeTextBox.Text = "��������";
            KeyCountTextBox.Text = "40";
            KeyboardPriceTextBox.Text = "2000";

            MouseTypeTextBox.Text = "�������";
            ButtonCountTextBox.Text = "4";
            MousePriceTextBox.Text = "1000";
        }

        private void AddComputerButton_Click(object sender, EventArgs e)
        {
            // �������� ��� ��������� �������
            if (string.IsNullOrWhiteSpace(ProcessorTypeTextBox.Text))
            {
                MessageBox.Show("���� �����, ������ ��� ���������.", "������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(ClockSpeedTextBox.Text))
            {
                MessageBox.Show("���� �����, ������ ������� ������� ���������.", "������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(HardDriveCapacityTextBox.Text))
            {
                MessageBox.Show("���� �����, ������ ��'�� ��������� �����.", "������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(ResolutionTextBox.Text))
            {
                MessageBox.Show("���� �����, ������ �������� �������� ������.", "������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // �������� ��� �������� �������
            double screenSize, systemBlockPrice, monitorPrice, keyboardPrice, mousePrice;
            int keyCount, buttonCount;

            if (!double.TryParse(ScreenSizeTextBox.Text, out screenSize) || screenSize <= 0)
            {
                MessageBox.Show("���� �����, ������ ��������� ����� ������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (screenSize < 0)
            {
                MessageBox.Show("����� ������ �� ���� ���� ��'�����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(SystemBlockPriceTextBox.Text, out systemBlockPrice) || systemBlockPrice <= 0)
            {
                MessageBox.Show("���� �����, ������ �������� ���� ���������� �����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (systemBlockPrice < 0)
            {
                MessageBox.Show("ֳ�� ���������� ����� �� ���� ���� ��'�����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(MonitorPriceTextBox.Text, out monitorPrice) || monitorPrice <= 0)
            {
                MessageBox.Show("���� �����, ������ �������� ���� �������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (monitorPrice < 0)
            {
                MessageBox.Show("ֳ�� ������� �� ���� ���� ��'�����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(KeyCountTextBox.Text, out keyCount) || keyCount <= 0)
            {
                MessageBox.Show("���� �����, ������ �������� ������� �����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (keyCount < 0)
            {
                MessageBox.Show("ʳ������ ����� �� ���� ���� ��'�����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(KeyboardPriceTextBox.Text, out keyboardPrice) || keyboardPrice <= 0)
            {
                MessageBox.Show("���� �����, ������ �������� ���� ���������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (keyboardPrice < 0)
            {
                MessageBox.Show("ֳ�� ��������� �� ���� ���� ��'�����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(ButtonCountTextBox.Text, out buttonCount) || buttonCount <= 0)
            {
                MessageBox.Show("���� �����, ������ �������� ������� ������ ����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (buttonCount < 0)
            {
                MessageBox.Show("ʳ������ ������ ���� �� ���� ���� ��'�����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(MousePriceTextBox.Text, out mousePrice) || mousePrice <= 0)
            {
                MessageBox.Show("���� �����, ������ �������� ���� ����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (mousePrice < 0)
            {
                MessageBox.Show("ֳ�� ���� �� ���� ���� ��'�����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ��������� ��'��� ����'����� � ��������� ������
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

            // ������ ����'���� �� ������
            computerClassroom.AddComputer(computer);

            // ��������� ������ ����'����� �� ����
            UpdateComputerList();
        }

        private void ShowComputerPriceButton_Click(object sender, EventArgs e)
        {
            // ��������, �� ���� �������� �����
            if (computerDataGridView.SelectedRows.Count > 0)
            {
                // ��������� ������� ��������� �����
                int selectedIndex = computerDataGridView.SelectedRows[0].Index;

                // ��������� ����'����� � ���������� �����
                Computer selectedComputer = computerDataGridView.Rows[selectedIndex].DataBoundItem as Computer;

                // ��������, �� ������� �������� ����'����
                if (selectedComputer != null)
                {
                    // ��������� ���� ����'����� � MessageBox
                    MessageBox.Show($"ֳ�� ����'�����: {selectedComputer.ComputerPrice}", "ֳ�� ����'�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // ��������� �����������, ���� ����� ����� �� �������
                MessageBox.Show("���� �����, ������� ����'���� ��� ��������� ����.", "������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void TotalPriceButton_Click(object sender, EventArgs e)
        {
            // ��������� �������� ���� � MessageBox
            MessageBox.Show($"Total Price: ${computerClassroom.CalculateTotalPrice()}", "Total Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void ClearListButton_Click(object sender, EventArgs e)
        {
            // ������� ������ ����'�����
            computerClassroom = new ComputerClassroom();
            UpdateComputerList();
        }

        // ��������� ������� �� DataGridView
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

        // ��������� ������ ����'����� �� ����
        private void UpdateComputerList()
        {
            // �������� ����� � DataGridView
            computerDataGridView.Rows.Clear();

            // ��������� ������� ����'����� �� DataGridView
            foreach (var computer in computerClassroom)
            {
                // ��������� ����� � ������ ��� ����'���� � DataGridView
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