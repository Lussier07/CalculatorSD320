using System.Text;

namespace CalculatorSD320
{
    public enum NumType
    {
        Decimal,
        Binary,
        Locational
    }
    public partial class Calculator : Form
    {
        public float StoredNumber { get; set; } = 0;
        public string DisplayOperand { get; set; } = "";
        public string StoredOperator { get; set; } = "";
        public string DisplayOperator { get; set; } = "";
        public string PreviousOperator { get; set; } = string.Empty;
        public float Result { get; set; }
        public bool DisplayClear { get; set; } = true;
        public NumType NumType { get; set; } = NumType.Decimal; 

        public Calculator()
        {
            InitializeComponent();
        }

        // Key Press Directing to Logic

        private void BtnPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Enter:
                case '=':
                    EqualsPress();
                    break;

                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    NumberPress(e.KeyChar.ToString());
                    break;

                case '.':
                    DecimalPress(e.KeyChar.ToString());
                    break;

                case '+':
                case '-':
                case '*':
                case '/':
                    OperationPress(e.KeyChar.ToString());
                    break;

                case (char)Keys.Back:
                    RemoveLastEntered();
                    break;

            }
        }

        // Click Events Directing to Logic

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            NumberPress(btn.Text);
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            EqualsPress();
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            OperationPress(btn.Text);
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            DecimalPress(btn.Text);
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            DisplayOperand = "";
            NumberDisplay.Text = "0";
            lblBinDisplay.Text = "0";
            binDecDisplay.Text = "0";
            LocDisplay.Text = "0";
            lblLocDecimalDisplay.Text = "0";
            DisplayClear = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            StoredNumber = 0;
            DisplayOperand = "";
            NumberDisplay.Text = "0";
            StoredOperator = "";
            OperatorDisplay.Text = "";
            Result = 0;

            lblBinDisplay.Text = "0";
            binDecDisplay.Text = "0";

            lblLocDecimalDisplay.Text = "0";
            LocDisplay.Text = "0";
            ErrorTooLarge.Visible = false;
        }

        private void RemoveLastEntered()
        {
            if (NumberDisplay.Text.Length >= 1)
            {
                NumberDisplay.Text = NumberDisplay.Text.Remove(NumberDisplay.Text.Length - 1);
                DisplayOperand = NumberDisplay.Text;
                if (NumType == NumType.Binary)
                    ToBinary();
                if (NumType == NumType.Locational)
                    ToLocational();
            }

            if (DisplayOperand == "0" || DisplayOperand == "")
            {
                NumberDisplay.Text = "0";
                DisplayOperand = "0";
                DisplayClear = true;
            }

            if (ErrorTooLarge.Visible)
            {
                ErrorTooLarge.Visible = false;
            }
        }

        // Logic Methods

        private void NumberPress(string btn)
        {
            if (DisplayClear)
            {
                if (NumberDisplay.Text != "")
                {
                    StoredNumber = float.Parse(NumberDisplay.Text);
                }
                NumberDisplay.Text = "";
                DisplayOperand = "";
                DisplayClear = false;
            }

            if (DisplayOperand.Length < 10)
            {
                DisplayOperand += btn;
                NumberDisplay.Text = DisplayOperand;
            }

            if (NumType == NumType.Binary)
            {
                ToBinary();
            }

            if (NumType == NumType.Locational)
            {
                ToLocational();
            }
        }

        public void DecimalPress(string value)
        {
            if (value == "." && !DisplayOperand.Contains('.'))
            {
                if (DisplayOperand == "0" || DisplayOperand == "")
                {
                    DisplayOperand = "0";
                    DisplayOperand += ".";
                }

                if (DisplayOperand != "0" && DisplayOperand.Last() != '.')
                {
                    DisplayOperand += ".";
                }
            }

            DisplayClear = false;
            NumberDisplay.Text = DisplayOperand;
        }

        private void EqualsPress()
        {
            if (StoredOperator == "")
            {
                StoredOperator = PreviousOperator;
            }

            switch (StoredOperator)
            {
                case "+":
                    Result = StoredNumber + float.Parse(DisplayOperand);
                    break;
                case "-":
                    Result = StoredNumber - float.Parse(DisplayOperand);
                    break;
                case "*":
                    Result = StoredNumber * float.Parse(DisplayOperand);
                    break;
                case "/":
                    Result = StoredNumber / float.Parse(DisplayOperand);
                    break;
            }

            NumberDisplay.Text = Result.ToString();

            PreviousOperator = StoredOperator;
            StoredOperator = "";
            OperatorDisplay.Text = "";

            StoredNumber = Result;
            DisplayClear = true;

            if (NumType == NumType.Binary)
            {
                ToBinary();
            }

            if (NumType == NumType.Locational)
            {
                ToLocational();
            }
        }

        private void OperationPress(string value)
        {
            if (StoredOperator != "" && DisplayOperand != "")
            {
                EqualsPress();
            }
            switch (value)
            {
                case "+":
                    StoredOperator = "+";
                    OperatorDisplay.Text = StoredOperator;
                    StoredNumber = float.Parse(NumberDisplay.Text);
                    break;
                case "-":
                    StoredOperator = "-";
                    OperatorDisplay.Text = StoredOperator;
                    StoredNumber = float.Parse(NumberDisplay.Text);
                    break;
                case "*":
                    StoredOperator = "*";
                    OperatorDisplay.Text = StoredOperator;
                    StoredNumber = float.Parse(NumberDisplay.Text);
                    break;
                case "/":
                    StoredOperator = "/";
                    OperatorDisplay.Text = StoredOperator;
                    StoredNumber = float.Parse(NumberDisplay.Text);
                    break;
            }

            DisplayClear = true;
        }

        private void TabChange(object sender, EventArgs e)
        {
            TabControl tabControl = (TabControl)sender;

            if (ErrorTooLarge.Visible)
            {
                ErrorTooLarge.Visible = false;
            }

            switch (tabControl.SelectedIndex)
            {
                case 0:
                    this.NumType = NumType.Decimal;
                    break;
                case 1:
                    ToBinary();
                    this.NumType = NumType.Binary;
                    break;
                case 2:
                    ToLocational();
                    this.NumType = NumType.Locational;
                    break;
            }
        }

        // Conversion

        private void ToBinary()
        {
            long dec = 0;
            string remainder = "";
            long quotient = 1;

            lblBinDisplay.Text = "0";

            if (DisplayOperand.Contains('.'))
            {
                DisplayOperand = Math.Round(decimal.Parse(DisplayOperand)).ToString();
            }

            if (DisplayOperand != "0" && DisplayOperand != "")
            {
                dec = long.Parse(DisplayOperand);
            }

            binDecDisplay.Text = dec.ToString();

            while (quotient != 0)
            {
                remainder += (dec % 2).ToString();
                quotient = dec / 2;
                dec /= 2;
            }

            char[] remainders = remainder.ToCharArray();

            Array.Reverse(remainders);

            string bin = new (remainders);

            lblBinDisplay.Text = bin;
        }

        private void ToLocational()
        {
            long dec = 0;
            List<int> values = new List<int>();

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            if (DisplayOperand.Length >= 9)
            {
                lblLocDecimalDisplay.Text = "";
                LocDisplay.Text = "";
                ErrorTooLarge.Visible = true;
                return;
            }

            if (DisplayOperand != "0" && DisplayOperand != "")
            {
                dec = long.Parse(DisplayOperand);
            }

            while (dec > 0)
            {
                double currentPowerTwo = 1;
                double nextPowerTwo = 2;

                while (nextPowerTwo < dec)
                {
                    currentPowerTwo = nextPowerTwo;
                    nextPowerTwo *= 2;
                }

                values.Add((int)currentPowerTwo);
                dec -= (int)currentPowerTwo;
            }

            StringBuilder sb = new StringBuilder();
            values.Reverse();

            foreach(int v in values)
            {
                if (Math.Log2(v) < letters.Length)
                {
                    sb.Append(letters[(int)Math.Log2(v)]);
                }
                else
                {
                    int half = v / 2;
                    int times = 2;
                    while ((int)Math.Log2(half) > 26)
                    {
                        half = v / 2;
                        times *= 2;
                    }
                    sb.Append(letters[(int)Math.Log2(half)], times);
                }
            }

            lblLocDecimalDisplay.Text = DisplayOperand;
            LocDisplay.Text = sb.ToString();

            if (DisplayOperand == "")
            {
                lblLocDecimalDisplay.Text = "0";
                LocDisplay.Text = "0";
            }
        }

        private void ToPowerTwo(object sender, EventArgs e)
        {
            Result = (int)Math.Pow(int.Parse(DisplayOperand), 2);

            NumberDisplay.Text = Result.ToString();

            PreviousOperator = StoredOperator;
            StoredOperator = "";
            OperatorDisplay.Text = "";

            StoredNumber = Result;
            DisplayOperand = Result.ToString();
            DisplayClear = true;

            if (NumType == NumType.Binary)
            {
                ToBinary();
            }

            if (NumType == NumType.Locational)
            {
                ToLocational();
            }
        }

        private void RemoveLastEntry(object sender, EventArgs e)
        {
            RemoveLastEntered();
        }
    }
}