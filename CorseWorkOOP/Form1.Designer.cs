namespace CorseWorkOOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            computerDataGridView = new DataGridView();
            ClearListButton = new Button();
            TotalPriceButton = new Button();
            AddComputerButton = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            HasCdDriveCheckBox = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            ProcessorTypeTextBox = new TextBox();
            ClockSpeedTextBox = new TextBox();
            SystemBlockPriceTextBox = new TextBox();
            HardDriveCapacityTextBox = new TextBox();
            MousePriceTextBox = new TextBox();
            ButtonCountTextBox = new TextBox();
            MouseTypeTextBox = new TextBox();
            KeyboardPriceTextBox = new TextBox();
            KeyCountTextBox = new TextBox();
            KeyboardTypeTextBox = new TextBox();
            MonitorPriceTextBox = new TextBox();
            ScreenSizeTextBox = new TextBox();
            ResolutionTextBox = new TextBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)computerDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1288, 715);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(computerDataGridView);
            tabPage1.Controls.Add(ClearListButton);
            tabPage1.Controls.Add(TotalPriceButton);
            tabPage1.Controls.Add(AddComputerButton);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(MousePriceTextBox);
            tabPage1.Controls.Add(ButtonCountTextBox);
            tabPage1.Controls.Add(MouseTypeTextBox);
            tabPage1.Controls.Add(KeyboardPriceTextBox);
            tabPage1.Controls.Add(KeyCountTextBox);
            tabPage1.Controls.Add(KeyboardTypeTextBox);
            tabPage1.Controls.Add(MonitorPriceTextBox);
            tabPage1.Controls.Add(ScreenSizeTextBox);
            tabPage1.Controls.Add(ResolutionTextBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1280, 687);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(632, 625);
            button1.Name = "button1";
            button1.Size = new Size(159, 49);
            button1.TabIndex = 26;
            button1.Text = "Ціна комп'ютера";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ShowComputerPriceButton_Click;
            // 
            // computerDataGridView
            // 
            computerDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            computerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            computerDataGridView.Location = new Point(398, 6);
            computerDataGridView.Name = "computerDataGridView";
            computerDataGridView.RowTemplate.Height = 25;
            computerDataGridView.Size = new Size(858, 593);
            computerDataGridView.TabIndex = 25;
            // 
            // ClearListButton
            // 
            ClearListButton.Location = new Point(1097, 625);
            ClearListButton.Name = "ClearListButton";
            ClearListButton.Size = new Size(159, 49);
            ClearListButton.TabIndex = 24;
            ClearListButton.Text = "Очистити список";
            ClearListButton.UseVisualStyleBackColor = true;
            ClearListButton.Click += ClearListButton_Click;
            // 
            // TotalPriceButton
            // 
            TotalPriceButton.Location = new Point(865, 625);
            TotalPriceButton.Name = "TotalPriceButton";
            TotalPriceButton.Size = new Size(159, 49);
            TotalPriceButton.TabIndex = 23;
            TotalPriceButton.Text = "Загальна ціна";
            TotalPriceButton.UseVisualStyleBackColor = true;
            TotalPriceButton.Click += TotalPriceButton_Click;
            // 
            // AddComputerButton
            // 
            AddComputerButton.Location = new Point(398, 625);
            AddComputerButton.Name = "AddComputerButton";
            AddComputerButton.Size = new Size(159, 49);
            AddComputerButton.TabIndex = 22;
            AddComputerButton.Text = "Добавити компютер";
            AddComputerButton.UseVisualStyleBackColor = true;
            AddComputerButton.Click += AddComputerButton_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(138, 584);
            label14.Name = "label14";
            label14.Size = new Size(35, 15);
            label14.TabIndex = 21;
            label14.Text = "Ціна:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(70, 541);
            label13.Name = "label13";
            label13.Size = new Size(102, 15);
            label13.TabIndex = 20;
            label13.Text = "Кількість кнопок:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(110, 501);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 19;
            label12.Text = "Тип миші:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(137, 461);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 18;
            label11.Text = "Ціна:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(69, 420);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 17;
            label10.Text = "Кількість клавіш:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(80, 378);
            label9.Name = "label9";
            label9.Size = new Size(92, 15);
            label9.TabIndex = 13;
            label9.Text = "Тип клавіатури:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(138, 332);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 13;
            label8.Text = "Ціна:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 296);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 16;
            label7.Text = "Роздільна здатність:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(108, 256);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 13;
            label6.Text = "Діагональ:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(HasCdDriveCheckBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ProcessorTypeTextBox);
            groupBox1.Controls.Add(ClockSpeedTextBox);
            groupBox1.Controls.Add(SystemBlockPriceTextBox);
            groupBox1.Controls.Add(HardDriveCapacityTextBox);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 226);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Системний блок";
            // 
            // HasCdDriveCheckBox
            // 
            HasCdDriveCheckBox.AutoSize = true;
            HasCdDriveCheckBox.Location = new Point(167, 152);
            HasCdDriveCheckBox.Name = "HasCdDriveCheckBox";
            HasCdDriveCheckBox.Size = new Size(148, 19);
            HasCdDriveCheckBox.TabIndex = 25;
            HasCdDriveCheckBox.Text = "Наявність СD приводу";
            HasCdDriveCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 109);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 12;
            label5.Text = "Обє'м диску:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 187);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 10;
            label4.Text = "Ціна:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 64);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 8;
            label2.Text = "Тактова частота:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 25);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 7;
            label1.Text = "Тип процесора:";
            // 
            // ProcessorTypeTextBox
            // 
            ProcessorTypeTextBox.Location = new Point(167, 22);
            ProcessorTypeTextBox.Name = "ProcessorTypeTextBox";
            ProcessorTypeTextBox.Size = new Size(154, 23);
            ProcessorTypeTextBox.TabIndex = 1;
            // 
            // ClockSpeedTextBox
            // 
            ClockSpeedTextBox.Location = new Point(167, 61);
            ClockSpeedTextBox.Name = "ClockSpeedTextBox";
            ClockSpeedTextBox.Size = new Size(154, 23);
            ClockSpeedTextBox.TabIndex = 2;
            // 
            // SystemBlockPriceTextBox
            // 
            SystemBlockPriceTextBox.Location = new Point(167, 187);
            SystemBlockPriceTextBox.Name = "SystemBlockPriceTextBox";
            SystemBlockPriceTextBox.Size = new Size(154, 23);
            SystemBlockPriceTextBox.TabIndex = 5;
            // 
            // HardDriveCapacityTextBox
            // 
            HardDriveCapacityTextBox.Location = new Point(167, 106);
            HardDriveCapacityTextBox.Name = "HardDriveCapacityTextBox";
            HardDriveCapacityTextBox.Size = new Size(154, 23);
            HardDriveCapacityTextBox.TabIndex = 3;
            // 
            // MousePriceTextBox
            // 
            MousePriceTextBox.Location = new Point(179, 581);
            MousePriceTextBox.Name = "MousePriceTextBox";
            MousePriceTextBox.Size = new Size(100, 23);
            MousePriceTextBox.TabIndex = 14;
            // 
            // ButtonCountTextBox
            // 
            ButtonCountTextBox.Location = new Point(179, 538);
            ButtonCountTextBox.Name = "ButtonCountTextBox";
            ButtonCountTextBox.Size = new Size(100, 23);
            ButtonCountTextBox.TabIndex = 13;
            // 
            // MouseTypeTextBox
            // 
            MouseTypeTextBox.Location = new Point(179, 498);
            MouseTypeTextBox.Name = "MouseTypeTextBox";
            MouseTypeTextBox.Size = new Size(100, 23);
            MouseTypeTextBox.TabIndex = 12;
            // 
            // KeyboardPriceTextBox
            // 
            KeyboardPriceTextBox.Location = new Point(179, 458);
            KeyboardPriceTextBox.Name = "KeyboardPriceTextBox";
            KeyboardPriceTextBox.Size = new Size(100, 23);
            KeyboardPriceTextBox.TabIndex = 11;
            // 
            // KeyCountTextBox
            // 
            KeyCountTextBox.Location = new Point(179, 417);
            KeyCountTextBox.Name = "KeyCountTextBox";
            KeyCountTextBox.Size = new Size(100, 23);
            KeyCountTextBox.TabIndex = 10;
            // 
            // KeyboardTypeTextBox
            // 
            KeyboardTypeTextBox.Location = new Point(179, 375);
            KeyboardTypeTextBox.Name = "KeyboardTypeTextBox";
            KeyboardTypeTextBox.Size = new Size(100, 23);
            KeyboardTypeTextBox.TabIndex = 9;
            // 
            // MonitorPriceTextBox
            // 
            MonitorPriceTextBox.Location = new Point(179, 332);
            MonitorPriceTextBox.Name = "MonitorPriceTextBox";
            MonitorPriceTextBox.Size = new Size(100, 23);
            MonitorPriceTextBox.TabIndex = 8;
            // 
            // ScreenSizeTextBox
            // 
            ScreenSizeTextBox.Location = new Point(179, 253);
            ScreenSizeTextBox.Name = "ScreenSizeTextBox";
            ScreenSizeTextBox.Size = new Size(100, 23);
            ScreenSizeTextBox.TabIndex = 6;
            // 
            // ResolutionTextBox
            // 
            ResolutionTextBox.Location = new Point(179, 293);
            ResolutionTextBox.Name = "ResolutionTextBox";
            ResolutionTextBox.Size = new Size(100, 23);
            ResolutionTextBox.TabIndex = 7;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1280, 687);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 739);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)computerDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private TextBox ProcessorTypeTextBox;
        private TextBox ClockSpeedTextBox;
        private TextBox MousePriceTextBox;
        private TextBox ButtonCountTextBox;
        private TextBox MouseTypeTextBox;
        private TextBox KeyboardPriceTextBox;
        private TextBox KeyCountTextBox;
        private TextBox KeyboardTypeTextBox;
        private TextBox MonitorPriceTextBox;
        private TextBox ResolutionTextBox;
        private TextBox ScreenSizeTextBox;
        private TextBox SystemBlockPriceTextBox;
        private TextBox HardDriveCapacityTextBox;
        private Button ClearListButton;
        private Button TotalPriceButton;
        private Button AddComputerButton;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private CheckBox HasCdDriveCheckBox;
        private DataGridView computerDataGridView;
        private Button button1;
    }
}