namespace CalculatorSD320
{
    partial class Calculator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DecimalConversion = new System.Windows.Forms.TabPage();
            this.OperatorDisplay = new System.Windows.Forms.Label();
            this.NumberDisplay = new System.Windows.Forms.Label();
            this.BinaryConversion = new System.Windows.Forms.TabPage();
            this.binDecDisplay = new System.Windows.Forms.Label();
            this.lblBinDisplay = new System.Windows.Forms.Label();
            this.LocationalConversion = new System.Windows.Forms.TabPage();
            this.ErrorTooLarge = new System.Windows.Forms.Label();
            this.lblLocDecimalDisplay = new System.Windows.Forms.Label();
            this.LocDisplay = new System.Windows.Forms.Label();
            this.btnDivide = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.PowerTwo = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.BackSpace = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.DecimalConversion.SuspendLayout();
            this.BinaryConversion.SuspendLayout();
            this.LocationalConversion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.DecimalConversion);
            this.tabControl1.Controls.Add(this.BinaryConversion);
            this.tabControl1.Controls.Add(this.LocationalConversion);
            this.tabControl1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(3, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 196);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabChange);
            // 
            // DecimalConversion
            // 
            this.DecimalConversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DecimalConversion.Controls.Add(this.OperatorDisplay);
            this.DecimalConversion.Controls.Add(this.NumberDisplay);
            this.DecimalConversion.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecimalConversion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DecimalConversion.Location = new System.Drawing.Point(4, 29);
            this.DecimalConversion.Margin = new System.Windows.Forms.Padding(0);
            this.DecimalConversion.Name = "DecimalConversion";
            this.DecimalConversion.Size = new System.Drawing.Size(312, 163);
            this.DecimalConversion.TabIndex = 0;
            this.DecimalConversion.Text = "DEC";
            // 
            // OperatorDisplay
            // 
            this.OperatorDisplay.AccessibleDescription = "This label displays the operand of the equation, if one has been selected";
            this.OperatorDisplay.AccessibleName = "Operand Display";
            this.OperatorDisplay.AutoSize = true;
            this.OperatorDisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.OperatorDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OperatorDisplay.Location = new System.Drawing.Point(0, 0);
            this.OperatorDisplay.Name = "OperatorDisplay";
            this.OperatorDisplay.Size = new System.Drawing.Size(0, 30);
            this.OperatorDisplay.TabIndex = 21;
            // 
            // NumberDisplay
            // 
            this.NumberDisplay.AccessibleDescription = "Calculator number display, displaying numbers entered, and result";
            this.NumberDisplay.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberDisplay.ForeColor = System.Drawing.Color.Gainsboro;
            this.NumberDisplay.Location = new System.Drawing.Point(2, 0);
            this.NumberDisplay.Name = "NumberDisplay";
            this.NumberDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberDisplay.Size = new System.Drawing.Size(308, 56);
            this.NumberDisplay.TabIndex = 20;
            this.NumberDisplay.Text = "0";
            this.NumberDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BinaryConversion
            // 
            this.BinaryConversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BinaryConversion.Controls.Add(this.binDecDisplay);
            this.BinaryConversion.Controls.Add(this.lblBinDisplay);
            this.BinaryConversion.ForeColor = System.Drawing.Color.Gainsboro;
            this.BinaryConversion.Location = new System.Drawing.Point(4, 29);
            this.BinaryConversion.Margin = new System.Windows.Forms.Padding(0);
            this.BinaryConversion.Name = "BinaryConversion";
            this.BinaryConversion.Size = new System.Drawing.Size(312, 163);
            this.BinaryConversion.TabIndex = 1;
            this.BinaryConversion.Text = "BIN";
            // 
            // binDecDisplay
            // 
            this.binDecDisplay.Location = new System.Drawing.Point(2, 142);
            this.binDecDisplay.Name = "binDecDisplay";
            this.binDecDisplay.Size = new System.Drawing.Size(301, 21);
            this.binDecDisplay.TabIndex = 23;
            this.binDecDisplay.Text = "0";
            this.binDecDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBinDisplay
            // 
            this.lblBinDisplay.AccessibleDescription = "Calculator number display, displaying numbers entered, and result";
            this.lblBinDisplay.AutoEllipsis = true;
            this.lblBinDisplay.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBinDisplay.Location = new System.Drawing.Point(2, 0);
            this.lblBinDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.lblBinDisplay.Name = "lblBinDisplay";
            this.lblBinDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBinDisplay.Size = new System.Drawing.Size(308, 152);
            this.lblBinDisplay.TabIndex = 22;
            this.lblBinDisplay.Text = "0";
            this.lblBinDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LocationalConversion
            // 
            this.LocationalConversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LocationalConversion.Controls.Add(this.ErrorTooLarge);
            this.LocationalConversion.Controls.Add(this.lblLocDecimalDisplay);
            this.LocationalConversion.Controls.Add(this.LocDisplay);
            this.LocationalConversion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LocationalConversion.Location = new System.Drawing.Point(4, 29);
            this.LocationalConversion.Margin = new System.Windows.Forms.Padding(0);
            this.LocationalConversion.Name = "LocationalConversion";
            this.LocationalConversion.Size = new System.Drawing.Size(312, 163);
            this.LocationalConversion.TabIndex = 2;
            this.LocationalConversion.Text = "LOC";
            // 
            // ErrorTooLarge
            // 
            this.ErrorTooLarge.AutoSize = true;
            this.ErrorTooLarge.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ErrorTooLarge.Location = new System.Drawing.Point(66, 70);
            this.ErrorTooLarge.Name = "ErrorTooLarge";
            this.ErrorTooLarge.Size = new System.Drawing.Size(178, 17);
            this.ErrorTooLarge.TabIndex = 2;
            this.ErrorTooLarge.Text = "ERROR: Number is too large.";
            this.ErrorTooLarge.Visible = false;
            // 
            // lblLocDecimalDisplay
            // 
            this.lblLocDecimalDisplay.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLocDecimalDisplay.Location = new System.Drawing.Point(2, 142);
            this.lblLocDecimalDisplay.Name = "lblLocDecimalDisplay";
            this.lblLocDecimalDisplay.Size = new System.Drawing.Size(301, 21);
            this.lblLocDecimalDisplay.TabIndex = 1;
            this.lblLocDecimalDisplay.Text = "0";
            this.lblLocDecimalDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LocDisplay
            // 
            this.LocDisplay.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocDisplay.ForeColor = System.Drawing.Color.Gainsboro;
            this.LocDisplay.Location = new System.Drawing.Point(2, 0);
            this.LocDisplay.Name = "LocDisplay";
            this.LocDisplay.Size = new System.Drawing.Size(308, 146);
            this.LocDisplay.TabIndex = 0;
            this.LocDisplay.Text = "0";
            this.LocDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDivide
            // 
            this.btnDivide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDivide.Location = new System.Drawing.Point(240, 200);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(1);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(74, 50);
            this.btnDivide.TabIndex = 19;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button18.ForeColor = System.Drawing.Color.Gainsboro;
            this.button18.Location = new System.Drawing.Point(84, 200);
            this.button18.Margin = new System.Windows.Forms.Padding(1);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(74, 50);
            this.button18.TabIndex = 18;
            this.button18.Text = "C";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button19
            // 
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button19.ForeColor = System.Drawing.Color.Gainsboro;
            this.button19.Location = new System.Drawing.Point(6, 200);
            this.button19.Margin = new System.Windows.Forms.Padding(1);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(74, 50);
            this.button19.TabIndex = 17;
            this.button19.Text = "CE";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.ClearEntry_Click);
            // 
            // PowerTwo
            // 
            this.PowerTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PowerTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PowerTwo.FlatAppearance.BorderSize = 0;
            this.PowerTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerTwo.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PowerTwo.ForeColor = System.Drawing.Color.Gainsboro;
            this.PowerTwo.Location = new System.Drawing.Point(6, 408);
            this.PowerTwo.Margin = new System.Windows.Forms.Padding(1);
            this.PowerTwo.Name = "PowerTwo";
            this.PowerTwo.Size = new System.Drawing.Size(74, 50);
            this.PowerTwo.TabIndex = 16;
            this.PowerTwo.Text = "x²";
            this.PowerTwo.UseVisualStyleBackColor = false;
            this.PowerTwo.Click += new System.EventHandler(this.ToPowerTwo);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMultiply.Location = new System.Drawing.Point(240, 252);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(1);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(74, 50);
            this.btnMultiply.TabIndex = 15;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnThree
            // 
            this.btnThree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThree.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThree.Location = new System.Drawing.Point(162, 356);
            this.btnThree.Margin = new System.Windows.Forms.Padding(1);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(74, 50);
            this.btnThree.TabIndex = 14;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.Number_Click);
            this.btnThree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnPress);
            // 
            // btnTwo
            // 
            this.btnTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTwo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTwo.Location = new System.Drawing.Point(84, 356);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(1);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(74, 50);
            this.btnTwo.TabIndex = 13;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnOne
            // 
            this.btnOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOne.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOne.Location = new System.Drawing.Point(6, 356);
            this.btnOne.Margin = new System.Windows.Forms.Padding(1);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(74, 50);
            this.btnOne.TabIndex = 12;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinus.Location = new System.Drawing.Point(240, 304);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(1);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(74, 50);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnSix
            // 
            this.btnSix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSix.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSix.Location = new System.Drawing.Point(162, 304);
            this.btnSix.Margin = new System.Windows.Forms.Padding(1);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(74, 50);
            this.btnSix.TabIndex = 10;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnFive
            // 
            this.btnFive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFive.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFive.Location = new System.Drawing.Point(84, 304);
            this.btnFive.Margin = new System.Windows.Forms.Padding(1);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(74, 50);
            this.btnFive.TabIndex = 9;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnFour
            // 
            this.btnFour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFour.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFour.Location = new System.Drawing.Point(6, 304);
            this.btnFour.Margin = new System.Windows.Forms.Padding(1);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(74, 50);
            this.btnFour.TabIndex = 8;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlus.Location = new System.Drawing.Point(240, 356);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(1);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(74, 50);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnNine
            // 
            this.btnNine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNine.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNine.Location = new System.Drawing.Point(162, 252);
            this.btnNine.Margin = new System.Windows.Forms.Padding(1);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(74, 50);
            this.btnNine.TabIndex = 6;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnEight
            // 
            this.btnEight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEight.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEight.Location = new System.Drawing.Point(84, 252);
            this.btnEight.Margin = new System.Windows.Forms.Padding(1);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(74, 50);
            this.btnEight.TabIndex = 5;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeven.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSeven.Location = new System.Drawing.Point(6, 252);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(1);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(74, 50);
            this.btnSeven.TabIndex = 4;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEquals.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEquals.Location = new System.Drawing.Point(240, 408);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(1);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(74, 50);
            this.btnEquals.TabIndex = 3;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(162, 408);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = ".";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Decimal_Click);
            this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnPress);
            // 
            // btnZero
            // 
            this.btnZero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnZero.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnZero.Location = new System.Drawing.Point(84, 408);
            this.btnZero.Margin = new System.Windows.Forms.Padding(1);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(74, 50);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.Number_Click);
            // 
            // BackSpace
            // 
            this.BackSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BackSpace.FlatAppearance.BorderSize = 0;
            this.BackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackSpace.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackSpace.ForeColor = System.Drawing.Color.Gainsboro;
            this.BackSpace.Location = new System.Drawing.Point(162, 200);
            this.BackSpace.Margin = new System.Windows.Forms.Padding(1);
            this.BackSpace.Name = "BackSpace";
            this.BackSpace.Size = new System.Drawing.Size(74, 50);
            this.BackSpace.TabIndex = 0;
            this.BackSpace.Text = "←";
            this.BackSpace.UseVisualStyleBackColor = false;
            this.BackSpace.Click += new System.EventHandler(this.RemoveLastEntry);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(319, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.BackSpace);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PowerTwo);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnFive);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(335, 500);
            this.MinimumSize = new System.Drawing.Size(335, 500);
            this.Name = "Calculator";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnPress);
            this.tabControl1.ResumeLayout(false);
            this.DecimalConversion.ResumeLayout(false);
            this.DecimalConversion.PerformLayout();
            this.BinaryConversion.ResumeLayout(false);
            this.LocationalConversion.ResumeLayout(false);
            this.LocationalConversion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage DecimalConversion;
        private TabPage BinaryConversion;
        private Button BackSpace;
        private Button btnEquals;
        private Button button3;
        private Button btnZero;
        private Button btnDivide;
        private Button button18;
        private Button button19;
        private Button PowerTwo;
        private Button btnMultiply;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnMinus;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnPlus;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Label NumberDisplay;
        private Label OperatorDisplay;
        private TabPage LocationalConversion;
        private Label lblBinDisplay;
        private Label binDecDisplay;
        private Label lblLocDecimalDisplay;
        private Label LocDisplay;
        private Label ErrorTooLarge;
    }
}