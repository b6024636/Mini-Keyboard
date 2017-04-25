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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(272, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "1\r\nP Q R S";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "2\r\nT U V";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(390, 468);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "3\r\nW X Y Z";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(390, 414);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 48);
            this.button6.TabIndex = 6;
            this.button6.Text = "6\r\nM N O";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(331, 414);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 48);
            this.button5.TabIndex = 7;
            this.button5.Text = "5\r\nJ K L";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(272, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 48);
            this.button4.TabIndex = 8;
            this.button4.Text = "4\r\nG H I";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(272, 360);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 48);
            this.button7.TabIndex = 9;
            this.button7.Text = "7\r\n.,\"\r\n";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(331, 360);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(53, 48);
            this.button8.TabIndex = 10;
            this.button8.Text = "8\r\nA B C";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(390, 360);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(53, 48);
            this.button9.TabIndex = 11;
            this.button9.Text = "9\r\nD E F";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(331, 522);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(53, 48);
            this.button0.TabIndex = 12;
            this.button0.Text = "000\r\n[ _ ]";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(271, 522);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(53, 48);
            this.button10.TabIndex = 13;
            this.button10.Text = "*-_";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(390, 522);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(53, 48);
            this.button11.TabIndex = 14;
            this.button11.Text = "#\r\n0.00";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(390, 306);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(53, 48);
            this.prevButton.TabIndex = 15;
            this.prevButton.Text = "Previ-\r\nous";
            this.prevButton.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(449, 306);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(53, 48);
            this.button13.TabIndex = 16;
            this.button13.Text = "Show\r\nPred-\r\niction";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // buttonMode
            // 
            this.buttonMode.Location = new System.Drawing.Point(272, 306);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(53, 48);
            this.buttonMode.TabIndex = 17;
            this.buttonMode.Text = "Mode";
            this.buttonMode.UseVisualStyleBackColor = true;
            this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(331, 306);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(53, 48);
            this.nextButton.TabIndex = 18;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(449, 414);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(53, 48);
            this.button14.TabIndex = 19;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(449, 360);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(53, 48);
            this.button16.TabIndex = 20;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(449, 468);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(53, 102);
            this.enterButton.TabIndex = 21;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
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
            this.globalListBox.Location = new System.Drawing.Point(36, 287);
            this.globalListBox.Name = "globalListBox";
            this.globalListBox.Size = new System.Drawing.Size(82, 108);
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
            this.listBox8.Location = new System.Drawing.Point(537, 308);
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
            this.listBox9.Location = new System.Drawing.Point(537, 368);
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
            this.listBox4.Location = new System.Drawing.Point(552, 409);
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
            this.listBox5.Location = new System.Drawing.Point(539, 447);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(74, 30);
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
            this.listBox6.Location = new System.Drawing.Point(557, 492);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(86, 43);
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
            this.listBox1.Location = new System.Drawing.Point(611, 318);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(68, 56);
            this.listBox1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 591);
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
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minikeyboard";
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
    }
}

