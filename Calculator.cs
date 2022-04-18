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
                case '.':
                    NumberPress(e.KeyChar.ToString());
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

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            DisplayOperand = "";
            NumberDisplay.Text = "0";
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
            }

            if (NumberDisplay.Text == "0" || NumberDisplay.Text.Length == 0)
            {
                NumberDisplay.Text = "0";
                DisplayOperand = "0";
                DisplayClear = true;
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

            if (btn == ".")
            {
                if (DisplayOperand != "0" && string.IsNullOrWhiteSpace(DisplayOperand))
                {
                    DisplayOperand = "0";
                    DisplayOperand.Append('.');
                }
            }

            DisplayOperand += btn;
            NumberDisplay.Text = DisplayOperand;

            if (NumType == NumType.Binary)
            {
                ToBinary();
            }

            if (NumType == NumType.Locational)
            {
                ToLocational();
            }
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
            int dec = 0;
            string remainder = "";
            int quotient = 1;

            lblBinDisplay.Text = "0";

            if (NumType == NumType.Locational)
            {
                //ToDecimal();
            }

            if (DisplayOperand != "0" && DisplayOperand != "")
            {
                dec = int.Parse(DisplayOperand);
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
            string result = "";
            int dec = 0;
            int quotient = 1;
            List<int> values = new List<int>();

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' };

            if(DisplayOperand != "0" && DisplayOperand != "")
            {
                dec = int.Parse(DisplayOperand);
            }

            if (DisplayOperand.Length > 7)
            {
                lblLocDecimalDisplay.Text = "";
                LocDisplay.Text = "";
                ErrorTooLarge.Visible = true;
                DisplayClear = true;
                return;
            }

            while (dec > 0)
            {
                double currentPowTwo = 1;
                double nextPowTwo = 2;

                while (nextPowTwo < dec)
                {
                    currentPowTwo = nextPowTwo;
                    nextPowTwo *= 2;
                }

                values.Add((int)currentPowTwo);
                dec -= (int)currentPowTwo;
            }

            StringBuilder sb = new StringBuilder();
            values.Reverse();

            foreach(int v in values)
            {
                if (v < letters.Length)
                {
                    sb.Append(letters[(int)Math.Log2(v)]);
                }
                else
                {
                    sb.Append(letters[(int)Math.Log2(v)]);
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