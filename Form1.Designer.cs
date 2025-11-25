namespace UartMiniScreen
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
            PortLable = new Label();
            TXLable = new Label();
            RXLable = new Label();
            comboBox1 = new ComboBox();
            RateLable = new Label();
            comboBox2 = new ComboBox();
            ConnectButton = new Button();
            TXTextBox = new TextBox();
            TXButton = new Button();
            RXTextBox = new TextBox();
            LogWindow = new RichTextBox();
            StatusLable = new Label();
            StatusLable2 = new Label();
            ClearLogButton = new Button();
            AutoScrollCheckBox = new CheckBox();
            PingLed = new Label();
            ParityComboBox = new ComboBox();
            StopBitsComboBox = new ComboBox();
            ParityLable = new Label();
            label3 = new Label();
            DataBitsLabel = new Label();
            DataBitsComboBox = new ComboBox();
            TestCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // PortLable
            // 
            PortLable.AutoSize = true;
            PortLable.Location = new Point(11, 23);
            PortLable.Name = "PortLable";
            PortLable.Size = new Size(35, 20);
            PortLable.TabIndex = 0;
            PortLable.Text = "Port";
            // 
            // TXLable
            // 
            TXLable.AutoSize = true;
            TXLable.Location = new Point(11, 265);
            TXLable.Name = "TXLable";
            TXLable.Size = new Size(62, 20);
            TXLable.TabIndex = 1;
            TXLable.Text = "TX Field";
            // 
            // RXLable
            // 
            RXLable.AutoSize = true;
            RXLable.Location = new Point(11, 323);
            RXLable.Name = "RXLable";
            RXLable.Size = new Size(63, 20);
            RXLable.TabIndex = 2;
            RXLable.Text = "RX Field";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(90, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // RateLable
            // 
            RateLable.AutoSize = true;
            RateLable.Location = new Point(11, 65);
            RateLable.Name = "RateLable";
            RateLable.Size = new Size(39, 20);
            RateLable.TabIndex = 4;
            RateLable.Text = "Rate";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(90, 62);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 5;
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new Point(211, 168);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(94, 29);
            ConnectButton.TabIndex = 6;
            ConnectButton.Text = "Connect ";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // TXTextBox
            // 
            TXTextBox.Location = new Point(78, 262);
            TXTextBox.Name = "TXTextBox";
            TXTextBox.Size = new Size(125, 27);
            TXTextBox.TabIndex = 7;
            // 
            // TXButton
            // 
            TXButton.Location = new Point(268, 261);
            TXButton.Name = "TXButton";
            TXButton.Size = new Size(94, 29);
            TXButton.TabIndex = 8;
            TXButton.Text = "Send Text";
            TXButton.UseVisualStyleBackColor = true;
            TXButton.Click += TXButton_Click;
            // 
            // RXTextBox
            // 
            RXTextBox.Location = new Point(78, 320);
            RXTextBox.Name = "RXTextBox";
            RXTextBox.Size = new Size(125, 27);
            RXTextBox.TabIndex = 9;
            // 
            // LogWindow
            // 
            LogWindow.Location = new Point(11, 371);
            LogWindow.Name = "LogWindow";
            LogWindow.Size = new Size(458, 110);
            LogWindow.TabIndex = 10;
            LogWindow.Text = "";
            // 
            // StatusLable
            // 
            StatusLable.AutoSize = true;
            StatusLable.Location = new Point(342, 105);
            StatusLable.Name = "StatusLable";
            StatusLable.Size = new Size(49, 20);
            StatusLable.TabIndex = 11;
            StatusLable.Text = "Status";
            // 
            // StatusLable2
            // 
            StatusLable2.AutoSize = true;
            StatusLable2.BackColor = Color.AliceBlue;
            StatusLable2.ForeColor = Color.Red;
            StatusLable2.Location = new Point(397, 105);
            StatusLable2.Name = "StatusLable2";
            StatusLable2.Size = new Size(95, 20);
            StatusLable2.TabIndex = 12;
            StatusLable2.Text = "Disconected ";
            // 
            // ClearLogButton
            // 
            ClearLogButton.Location = new Point(12, 487);
            ClearLogButton.Name = "ClearLogButton";
            ClearLogButton.Size = new Size(94, 29);
            ClearLogButton.TabIndex = 13;
            ClearLogButton.Text = "Clear Log";
            ClearLogButton.UseVisualStyleBackColor = true;
            ClearLogButton.Click += ClearLogButton_Click;
            // 
            // AutoScrollCheckBox
            // 
            AutoScrollCheckBox.AutoSize = true;
            AutoScrollCheckBox.Location = new Point(347, 492);
            AutoScrollCheckBox.Name = "AutoScrollCheckBox";
            AutoScrollCheckBox.Size = new Size(104, 24);
            AutoScrollCheckBox.TabIndex = 14;
            AutoScrollCheckBox.Text = "Auto Scroll";
            AutoScrollCheckBox.UseVisualStyleBackColor = true;
            AutoScrollCheckBox.CheckedChanged += AutoScrollCheckBox_CheckedChanged;
            // 
            // PingLed
            // 
            PingLed.AutoSize = true;
            PingLed.ForeColor = SystemColors.ActiveBorder;
            PingLed.Location = new Point(211, 323);
            PingLed.Name = "PingLed";
            PingLed.Size = new Size(18, 20);
            PingLed.TabIndex = 15;
            PingLed.Text = "●";
            PingLed.Click += label1_Click;
            // 
            // ParityComboBox
            // 
            ParityComboBox.FormattingEnabled = true;
            ParityComboBox.Location = new Point(342, 20);
            ParityComboBox.Name = "ParityComboBox";
            ParityComboBox.Size = new Size(151, 28);
            ParityComboBox.TabIndex = 16;
            // 
            // StopBitsComboBox
            // 
            StopBitsComboBox.FormattingEnabled = true;
            StopBitsComboBox.Location = new Point(342, 62);
            StopBitsComboBox.Name = "StopBitsComboBox";
            StopBitsComboBox.Size = new Size(151, 28);
            StopBitsComboBox.TabIndex = 17;
            // 
            // ParityLable
            // 
            ParityLable.AutoSize = true;
            ParityLable.Location = new Point(268, 23);
            ParityLable.Name = "ParityLable";
            ParityLable.Size = new Size(45, 20);
            ParityLable.TabIndex = 18;
            ParityLable.Text = "Parity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 65);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 19;
            label3.Text = "Stop Bits";
            // 
            // DataBitsLabel
            // 
            DataBitsLabel.AutoSize = true;
            DataBitsLabel.Location = new Point(11, 105);
            DataBitsLabel.Name = "DataBitsLabel";
            DataBitsLabel.Size = new Size(73, 20);
            DataBitsLabel.TabIndex = 20;
            DataBitsLabel.Text = "Data Bits ";
            // 
            // DataBitsComboBox
            // 
            DataBitsComboBox.FormattingEnabled = true;
            DataBitsComboBox.Location = new Point(90, 102);
            DataBitsComboBox.Name = "DataBitsComboBox";
            DataBitsComboBox.Size = new Size(151, 28);
            DataBitsComboBox.TabIndex = 21;
            // 
            // TestCheckBox
            // 
            TestCheckBox.AutoSize = true;
            TestCheckBox.Location = new Point(391, 265);
            TestCheckBox.Name = "TestCheckBox";
            TestCheckBox.Size = new Size(100, 24);
            TestCheckBox.TabIndex = 22;
            TestCheckBox.Text = "Test Mode";
            TestCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 519);
            Controls.Add(TestCheckBox);
            Controls.Add(DataBitsComboBox);
            Controls.Add(DataBitsLabel);
            Controls.Add(label3);
            Controls.Add(ParityLable);
            Controls.Add(StopBitsComboBox);
            Controls.Add(ParityComboBox);
            Controls.Add(PingLed);
            Controls.Add(AutoScrollCheckBox);
            Controls.Add(ClearLogButton);
            Controls.Add(StatusLable2);
            Controls.Add(StatusLable);
            Controls.Add(LogWindow);
            Controls.Add(RXTextBox);
            Controls.Add(TXButton);
            Controls.Add(TXTextBox);
            Controls.Add(ConnectButton);
            Controls.Add(comboBox2);
            Controls.Add(RateLable);
            Controls.Add(comboBox1);
            Controls.Add(RXLable);
            Controls.Add(TXLable);
            Controls.Add(PortLable);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PortLable;
        private Label TXLable;
        private Label RXLable;
        private ComboBox comboBox1;
        private Label RateLable;
        private ComboBox comboBox2;
        private Button ConnectButton;
        private TextBox TXTextBox;
        private Button TXButton;
        private TextBox RXTextBox;
        private RichTextBox LogWindow;
        private Label StatusLable;
        private Label StatusLable2;
        private Button ClearLogButton;
        private CheckBox AutoScrollCheckBox;
        private Label PingLed;
        private ComboBox ParityComboBox;
        private ComboBox StopBitsComboBox;
        private Label ParityLable;
        private Label label3;
        private Label DataBitsLabel;
        private ComboBox DataBitsComboBox;
        private CheckBox TestCheckBox;
    }
}
