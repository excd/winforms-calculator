namespace winforms_calculator {
    partial class CalculatorForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            TableLayoutPanel buttonGrid;
            Button buttonNegate;
            Button button0;
            Button buttonDecimalPoint;
            Button buttonAdd;
            Button button3;
            Button button2;
            Button button1;
            Button buttonSubtract;
            Button button6;
            Button button5;
            Button button4;
            Button buttonMultiply;
            Button button9;
            Button button8;
            Button button7;
            Button buttonDivide;
            Button buttonBackspace;
            Button buttonClear;
            Button buttonEquals;
            Button buttonClearEntry;
            Panel buttonPanel;
            MenuStrip menuStrip;
            ToolStripMenuItem fileMenuTab;
            ToolStripMenuItem exitFileMenuItem;
            ToolStripMenuItem editMenuTab;
            ToolStripMenuItem copyEditMenuItem;
            ToolStripMenuItem pasteEditMenuItem;
            ToolStripMenuItem helpMenuTab;
            ToolStripMenuItem aboutHelpMenuItem;
            calculatorDisplay = new TextBox();
            buttonGrid = new TableLayoutPanel();
            buttonNegate = new Button();
            button0 = new Button();
            buttonDecimalPoint = new Button();
            buttonAdd = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonSubtract = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            buttonMultiply = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            buttonDivide = new Button();
            buttonBackspace = new Button();
            buttonClear = new Button();
            buttonEquals = new Button();
            buttonClearEntry = new Button();
            buttonPanel = new Panel();
            menuStrip = new MenuStrip();
            fileMenuTab = new ToolStripMenuItem();
            exitFileMenuItem = new ToolStripMenuItem();
            editMenuTab = new ToolStripMenuItem();
            copyEditMenuItem = new ToolStripMenuItem();
            pasteEditMenuItem = new ToolStripMenuItem();
            helpMenuTab = new ToolStripMenuItem();
            aboutHelpMenuItem = new ToolStripMenuItem();
            buttonGrid.SuspendLayout();
            buttonPanel.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGrid
            // 
            buttonGrid.BackColor = SystemColors.Control;
            buttonGrid.ColumnCount = 4;
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonGrid.Controls.Add(buttonNegate, 2, 4);
            buttonGrid.Controls.Add(button0, 1, 4);
            buttonGrid.Controls.Add(buttonDecimalPoint, 0, 4);
            buttonGrid.Controls.Add(buttonAdd, 3, 3);
            buttonGrid.Controls.Add(button3, 2, 3);
            buttonGrid.Controls.Add(button2, 1, 3);
            buttonGrid.Controls.Add(button1, 0, 3);
            buttonGrid.Controls.Add(buttonSubtract, 3, 2);
            buttonGrid.Controls.Add(button6, 2, 2);
            buttonGrid.Controls.Add(button5, 1, 2);
            buttonGrid.Controls.Add(button4, 0, 2);
            buttonGrid.Controls.Add(buttonMultiply, 3, 1);
            buttonGrid.Controls.Add(button9, 2, 1);
            buttonGrid.Controls.Add(button8, 1, 1);
            buttonGrid.Controls.Add(button7, 0, 1);
            buttonGrid.Controls.Add(buttonDivide, 3, 0);
            buttonGrid.Controls.Add(buttonBackspace, 2, 0);
            buttonGrid.Controls.Add(buttonClear, 1, 0);
            buttonGrid.Controls.Add(buttonEquals, 3, 4);
            buttonGrid.Controls.Add(buttonClearEntry, 0, 0);
            buttonGrid.Dock = DockStyle.Fill;
            buttonGrid.Location = new Point(0, 0);
            buttonGrid.Name = "buttonGrid";
            buttonGrid.RowCount = 5;
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonGrid.Size = new Size(266, 240);
            buttonGrid.TabIndex = 2;
            // 
            // buttonNegate
            // 
            buttonNegate.BackColor = SystemColors.ButtonFace;
            buttonNegate.Dock = DockStyle.Fill;
            buttonNegate.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNegate.Location = new Point(135, 195);
            buttonNegate.Name = "buttonNegate";
            buttonNegate.Size = new Size(60, 42);
            buttonNegate.TabIndex = 19;
            buttonNegate.TabStop = false;
            buttonNegate.Text = "+/-";
            buttonNegate.UseVisualStyleBackColor = false;
            buttonNegate.Click += Negate;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ButtonHighlight;
            button0.Dock = DockStyle.Fill;
            button0.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location = new Point(69, 195);
            button0.Name = "button0";
            button0.Size = new Size(60, 42);
            button0.TabIndex = 18;
            button0.TabStop = false;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += InputNumber;
            // 
            // buttonDecimalPoint
            // 
            buttonDecimalPoint.BackColor = SystemColors.ButtonFace;
            buttonDecimalPoint.Dock = DockStyle.Fill;
            buttonDecimalPoint.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDecimalPoint.Location = new Point(3, 195);
            buttonDecimalPoint.Name = "buttonDecimalPoint";
            buttonDecimalPoint.Size = new Size(60, 42);
            buttonDecimalPoint.TabIndex = 17;
            buttonDecimalPoint.TabStop = false;
            buttonDecimalPoint.Text = ".";
            buttonDecimalPoint.UseVisualStyleBackColor = false;
            buttonDecimalPoint.Click += DecimalPoint;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ButtonFace;
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(201, 147);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(62, 42);
            buttonAdd.TabIndex = 16;
            buttonAdd.TabStop = false;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += InputOperator;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(135, 147);
            button3.Name = "button3";
            button3.Size = new Size(60, 42);
            button3.TabIndex = 15;
            button3.TabStop = false;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += InputNumber;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(69, 147);
            button2.Name = "button2";
            button2.Size = new Size(60, 42);
            button2.TabIndex = 14;
            button2.TabStop = false;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += InputNumber;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 147);
            button1.Name = "button1";
            button1.Size = new Size(60, 42);
            button1.TabIndex = 13;
            button1.TabStop = false;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += InputNumber;
            // 
            // buttonSubtract
            // 
            buttonSubtract.BackColor = SystemColors.ButtonFace;
            buttonSubtract.Dock = DockStyle.Fill;
            buttonSubtract.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubtract.Location = new Point(201, 99);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(62, 42);
            buttonSubtract.TabIndex = 12;
            buttonSubtract.TabStop = false;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = false;
            buttonSubtract.Click += InputOperator;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(135, 99);
            button6.Name = "button6";
            button6.Size = new Size(60, 42);
            button6.TabIndex = 11;
            button6.TabStop = false;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += InputNumber;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(69, 99);
            button5.Name = "button5";
            button5.Size = new Size(60, 42);
            button5.TabIndex = 10;
            button5.TabStop = false;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += InputNumber;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(3, 99);
            button4.Name = "button4";
            button4.Size = new Size(60, 42);
            button4.TabIndex = 9;
            button4.TabStop = false;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += InputNumber;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = SystemColors.ButtonFace;
            buttonMultiply.Dock = DockStyle.Fill;
            buttonMultiply.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMultiply.Location = new Point(201, 51);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(62, 42);
            buttonMultiply.TabIndex = 8;
            buttonMultiply.TabStop = false;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += InputOperator;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonHighlight;
            button9.Dock = DockStyle.Fill;
            button9.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(135, 51);
            button9.Name = "button9";
            button9.Size = new Size(60, 42);
            button9.TabIndex = 7;
            button9.TabStop = false;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += InputNumber;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonHighlight;
            button8.Dock = DockStyle.Fill;
            button8.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(69, 51);
            button8.Name = "button8";
            button8.Size = new Size(60, 42);
            button8.TabIndex = 6;
            button8.TabStop = false;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += InputNumber;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonHighlight;
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(3, 51);
            button7.Name = "button7";
            button7.Size = new Size(60, 42);
            button7.TabIndex = 5;
            button7.TabStop = false;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += InputNumber;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = SystemColors.ButtonFace;
            buttonDivide.Dock = DockStyle.Fill;
            buttonDivide.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDivide.Location = new Point(201, 3);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(62, 42);
            buttonDivide.TabIndex = 4;
            buttonDivide.TabStop = false;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += InputOperator;
            // 
            // buttonBackspace
            // 
            buttonBackspace.BackColor = SystemColors.ButtonFace;
            buttonBackspace.Dock = DockStyle.Fill;
            buttonBackspace.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBackspace.Location = new Point(135, 3);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(60, 42);
            buttonBackspace.TabIndex = 3;
            buttonBackspace.TabStop = false;
            buttonBackspace.Text = "<-";
            buttonBackspace.UseVisualStyleBackColor = false;
            buttonBackspace.Click += Backspace;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.ButtonFace;
            buttonClear.Dock = DockStyle.Fill;
            buttonClear.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(69, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(60, 42);
            buttonClear.TabIndex = 2;
            buttonClear.TabStop = false;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += ClearAll;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = SystemColors.ButtonShadow;
            buttonEquals.Dock = DockStyle.Fill;
            buttonEquals.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEquals.Location = new Point(201, 195);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(62, 42);
            buttonEquals.TabIndex = 0;
            buttonEquals.TabStop = false;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += Evaluate;
            // 
            // buttonClearEntry
            // 
            buttonClearEntry.BackColor = SystemColors.ButtonFace;
            buttonClearEntry.Dock = DockStyle.Fill;
            buttonClearEntry.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClearEntry.Location = new Point(3, 3);
            buttonClearEntry.Name = "buttonClearEntry";
            buttonClearEntry.Size = new Size(60, 42);
            buttonClearEntry.TabIndex = 1;
            buttonClearEntry.TabStop = false;
            buttonClearEntry.Text = "CE";
            buttonClearEntry.UseVisualStyleBackColor = false;
            buttonClearEntry.Click += ClearEntry;
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = SystemColors.ControlLight;
            buttonPanel.Controls.Add(buttonGrid);
            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Location = new Point(9, 72);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(266, 240);
            buttonPanel.TabIndex = 1;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.MenuBar;
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenuTab, editMenuTab, helpMenuTab });
            menuStrip.Location = new Point(9, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(266, 24);
            menuStrip.TabIndex = 2;
            // 
            // fileMenuTab
            // 
            fileMenuTab.DropDownItems.AddRange(new ToolStripItem[] { exitFileMenuItem });
            fileMenuTab.Name = "fileMenuTab";
            fileMenuTab.ShortcutKeyDisplayString = "";
            fileMenuTab.Size = new Size(37, 20);
            fileMenuTab.Text = "&File";
            // 
            // exitFileMenuItem
            // 
            exitFileMenuItem.Name = "exitFileMenuItem";
            exitFileMenuItem.Size = new Size(93, 22);
            exitFileMenuItem.Text = "E&xit";
            exitFileMenuItem.Click += ExitApplication;
            // 
            // editMenuTab
            // 
            editMenuTab.DropDownItems.AddRange(new ToolStripItem[] { copyEditMenuItem, pasteEditMenuItem });
            editMenuTab.Name = "editMenuTab";
            editMenuTab.Size = new Size(39, 20);
            editMenuTab.Text = "&Edit";
            // 
            // copyEditMenuItem
            // 
            copyEditMenuItem.ImageTransparentColor = Color.Magenta;
            copyEditMenuItem.Name = "copyEditMenuItem";
            copyEditMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyEditMenuItem.Size = new Size(144, 22);
            copyEditMenuItem.Text = "&Copy";
            copyEditMenuItem.Click += CopyDisplayText;
            // 
            // pasteEditMenuItem
            // 
            pasteEditMenuItem.ImageTransparentColor = Color.Magenta;
            pasteEditMenuItem.Name = "pasteEditMenuItem";
            pasteEditMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteEditMenuItem.Size = new Size(144, 22);
            pasteEditMenuItem.Text = "&Paste";
            pasteEditMenuItem.Click += PasteDisplayText;
            // 
            // helpMenuTab
            // 
            helpMenuTab.DropDownItems.AddRange(new ToolStripItem[] { aboutHelpMenuItem });
            helpMenuTab.Name = "helpMenuTab";
            helpMenuTab.Size = new Size(44, 20);
            helpMenuTab.Text = "&Help";
            // 
            // aboutHelpMenuItem
            // 
            aboutHelpMenuItem.Name = "aboutHelpMenuItem";
            aboutHelpMenuItem.Size = new Size(116, 22);
            aboutHelpMenuItem.Text = "&About...";
            aboutHelpMenuItem.Click += ShowAboutDialog;
            // 
            // calculatorDisplay
            // 
            calculatorDisplay.BackColor = SystemColors.ControlLightLight;
            calculatorDisplay.Enabled = false;
            calculatorDisplay.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            calculatorDisplay.Location = new Point(9, 30);
            calculatorDisplay.MaxLength = 20;
            calculatorDisplay.Name = "calculatorDisplay";
            calculatorDisplay.ReadOnly = true;
            calculatorDisplay.Size = new Size(266, 36);
            calculatorDisplay.TabIndex = 0;
            calculatorDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 321);
            Controls.Add(buttonPanel);
            Controls.Add(calculatorDisplay);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "CalculatorForm";
            Padding = new Padding(9, 0, 9, 9);
            Text = "Calculator";
            buttonGrid.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox calculatorDisplay;
        private Button buttonEquals;
        private Button buttonNegate;
        private Button button0;
        private Button buttonDecimalPoint;
        private Button buttonAdd;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonSubtract;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button buttonMultiply;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button buttonDivide;
        private Button buttonBackspace;
        private Button buttonClear;
        private Button buttonClearEntry;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenuTab;
        private ToolStripMenuItem exitFileMenuItem;
        private ToolStripMenuItem editMenuTab;
        private ToolStripMenuItem copyEditMenuItem;
        private ToolStripMenuItem pasteEditMenuItem;
        private ToolStripMenuItem helpMenuTab;
        private ToolStripMenuItem aboutHelpMenuItem;
    }
}
