namespace Mini_Keyboard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notepadTxt = new System.Windows.Forms.TextBox();
            this.wordBuilderTextBox = new System.Windows.Forms.TextBox();
            this.modeStatusLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.buttonMode = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.globalListBox = new System.Windows.Forms.ListBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.listBox9 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.listBox10 = new System.Windows.Forms.ListBox();
            this.listBox11 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxLetterLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notepadTxt
            // 
            this.notepadTxt.Location = new System.Drawing.Point(22, 34);
            this.notepadTxt.Multiline = true;
            this.notepadTxt.Name = "notepadTxt";
            this.notepadTxt.ReadOnly = true;
            this.notepadTxt.Size = new System.Drawing.Size(852, 217);
            this.notepadTxt.TabIndex = 0;
            // 
            // wordBuilderTextBox
            // 
            this.wordBuilderTextBox.Location = new System.Drawing.Point(271, 271);
            this.wordBuilderTextBox.Name = "wordBuilderTextBox";
            this.wordBuilderTextBox.ReadOnly = true;
            this.wordBuilderTextBox.Size = new System.Drawing.Size(190, 20);
            this.wordBuilderTextBox.TabIndex = 1;
            // 
            // modeStatusLbl
            // 
            this.modeStatusLbl.AutoSize = true;
            this.modeStatusLbl.Location = new System.Drawing.Point(467, 274);
            this.modeStatusLbl.Name = "modeStatusLbl";
            this.modeStatusLbl.Size = new System.Drawing.Size(58, 13);
            this.modeStatusLbl.TabIndex = 2;
            this.modeStatusLbl.Text = "Multi-Press";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(272, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "1\r\nP Q R S";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Location = new System.Drawing.Point(331, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "2\r\nT U V";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(390, 468);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "3\r\nW X Y Z";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightCoral;
            this.button6.Location = new System.Drawing.Point(390, 414);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 48);
            this.button6.TabIndex = 6;
            this.button6.Text = "6\r\nM N O";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.Location = new System.Drawing.Point(331, 414);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 48);
            this.button5.TabIndex = 7;
            this.button5.Text = "5\r\nJ K L";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Location = new System.Drawing.Point(272, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 48);
            this.button4.TabIndex = 8;
            this.button4.Text = "4\r\nG H I";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightCoral;
            this.button7.Location = new System.Drawing.Point(272, 360);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 48);
            this.button7.TabIndex = 9;
            this.button7.Text = "7\r\n.,\"\r\n";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightCoral;
            this.button8.Location = new System.Drawing.Point(331, 360);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(53, 48);
            this.button8.TabIndex = 10;
            this.button8.Text = "8\r\nA B C";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightCoral;
            this.button9.Location = new System.Drawing.Point(390, 360);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(53, 48);
            this.button9.TabIndex = 11;
            this.button9.Text = "9\r\nD E F";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Lime;
            this.button0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button0.Location = new System.Drawing.Point(331, 522);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(53, 48);
            this.button0.TabIndex = 12;
            this.button0.Text = "000\r\n[ _ ]";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightCoral;
            this.button10.Location = new System.Drawing.Point(271, 522);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(53, 48);
            this.button10.TabIndex = 13;
            this.button10.Text = "*-_";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightCoral;
            this.button11.Location = new System.Drawing.Point(390, 522);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(53, 48);
            this.button11.TabIndex = 14;
            this.button11.Text = "#\r\n0.00";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // prevButton
            // 
            this.prevButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.prevButton.Location = new System.Drawing.Point(390, 306);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(53, 48);
            this.prevButton.TabIndex = 15;
            this.prevButton.Text = "Previ-\r\nous";
            this.prevButton.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Yellow;
            this.button13.Location = new System.Drawing.Point(449, 306);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(53, 48);
            this.button13.TabIndex = 16;
            this.button13.Text = "Show\r\nPred-\r\niction";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // buttonMode
            // 
            this.buttonMode.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonMode.Location = new System.Drawing.Point(272, 306);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(53, 48);
            this.buttonMode.TabIndex = 17;
            this.buttonMode.Text = "Mode";
            this.buttonMode.UseVisualStyleBackColor = false;
            this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.nextButton.Location = new System.Drawing.Point(331, 306);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(53, 48);
            this.nextButton.TabIndex = 18;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Yellow;
            this.button14.Location = new System.Drawing.Point(449, 414);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(53, 48);
            this.button14.TabIndex = 19;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Yellow;
            this.button16.Location = new System.Drawing.Point(449, 360);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(53, 48);
            this.button16.TabIndex = 20;
            this.button16.Text = "Delete\r\nWord Builder";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Yellow;
            this.enterButton.Location = new System.Drawing.Point(449, 468);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(53, 102);
            this.enterButton.TabIndex = 21;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.onTick);
            // 
            // globalListBox
            // 
            this.globalListBox.FormattingEnabled = true;
            this.globalListBox.Location = new System.Drawing.Point(805, 196);
            this.globalListBox.Name = "globalListBox";
            this.globalListBox.Size = new System.Drawing.Size(34, 17);
            this.globalListBox.TabIndex = 22;
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "8",
            "A",
            "B",
            "C"});
            this.listBox8.Location = new System.Drawing.Point(793, 186);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(52, 30);
            this.listBox8.TabIndex = 23;
            // 
            // listBox9
            // 
            this.listBox9.FormattingEnabled = true;
            this.listBox9.Items.AddRange(new object[] {
            "d",
            "e",
            "f",
            "9",
            "D",
            "E",
            "F"});
            this.listBox9.Location = new System.Drawing.Point(795, 186);
            this.listBox9.Name = "listBox9";
            this.listBox9.Size = new System.Drawing.Size(51, 17);
            this.listBox9.TabIndex = 24;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Items.AddRange(new object[] {
            "g",
            "h",
            "i",
            "6",
            "G",
            "H",
            "I"});
            this.listBox4.Location = new System.Drawing.Point(793, 196);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(36, 17);
            this.listBox4.TabIndex = 25;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Items.AddRange(new object[] {
            "j",
            "k",
            "l",
            "5",
            "J",
            "K",
            "L"});
            this.listBox5.Location = new System.Drawing.Point(795, 196);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(34, 17);
            this.listBox5.TabIndex = 26;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Items.AddRange(new object[] {
            "m",
            "n",
            "o",
            "6",
            "M",
            "N",
            "O"});
            this.listBox6.Location = new System.Drawing.Point(797, 196);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(32, 17);
            this.listBox6.TabIndex = 27;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "p",
            "q",
            "r",
            "s",
            "1",
            "P",
            "Q",
            "R",
            "S"});
            this.listBox1.Location = new System.Drawing.Point(797, 186);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(39, 17);
            this.listBox1.TabIndex = 28;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "t",
            "u",
            "v",
            "2",
            "T",
            "U",
            "V"});
            this.listBox2.Location = new System.Drawing.Point(798, 196);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(38, 17);
            this.listBox2.TabIndex = 29;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "w",
            "x",
            "y",
            "z",
            "3",
            "W",
            "X",
            "Y",
            "Z"});
            this.listBox3.Location = new System.Drawing.Point(813, 199);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(10, 4);
            this.listBox3.TabIndex = 30;
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.Items.AddRange(new object[] {
            ".",
            "~",
            "\"",
            "7",
            "\'",
            ":",
            ";"});
            this.listBox7.Location = new System.Drawing.Point(797, 196);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(48, 17);
            this.listBox7.TabIndex = 31;
            // 
            // listBox10
            // 
            this.listBox10.FormattingEnabled = true;
            this.listBox10.Items.AddRange(new object[] {
            "*",
            "-",
            "_"});
            this.listBox10.Location = new System.Drawing.Point(805, 195);
            this.listBox10.Name = "listBox10";
            this.listBox10.Size = new System.Drawing.Size(39, 17);
            this.listBox10.TabIndex = 32;
            // 
            // listBox11
            // 
            this.listBox11.FormattingEnabled = true;
            this.listBox11.Items.AddRange(new object[] {
            "#",
            "-",
            "_"});
            this.listBox11.Location = new System.Drawing.Point(795, 195);
            this.listBox11.Name = "listBox11";
            this.listBox11.Size = new System.Drawing.Size(52, 17);
            this.listBox11.TabIndex = 33;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "Configure";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
            // 
            // listBoxLetterLbl
            // 
            this.listBoxLetterLbl.AutoSize = true;
            this.listBoxLetterLbl.Location = new System.Drawing.Point(120, 513);
            this.listBoxLetterLbl.Name = "listBoxLetterLbl";
            this.listBoxLetterLbl.Size = new System.Drawing.Size(0, 13);
            this.listBoxLetterLbl.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Current Letter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLetterLbl);
            this.Controls.Add(this.listBox11);
            this.Controls.Add(this.listBox10);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox9);
            this.Controls.Add(this.listBox8);
            this.Controls.Add(this.globalListBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.buttonMode);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modeStatusLbl);
            this.Controls.Add(this.wordBuilderTextBox);
            this.Controls.Add(this.notepadTxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minikeyboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notepadTxt;
        private System.Windows.Forms.TextBox wordBuilderTextBox;
        private System.Windows.Forms.Label modeStatusLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button buttonMode;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox globalListBox;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.ListBox listBox9;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.ListBox listBox10;
        private System.Windows.Forms.ListBox listBox11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.Label listBoxLetterLbl;
        private System.Windows.Forms.Label label1;
    }
}

