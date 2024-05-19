using System;
using System.Windows.Forms;

namespace CalculatorAssignment
{
    public partial class frmCalculator : Form
    {
        #region Fields
        private bool historyOpen, number2, decimalOn;
        private decimal num1, num2;
        private string operation = "";
        #endregion

        #region InternalFunctions
        public frmCalculator()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(frmCalculator_KeyPress);
        }

        //function for solving equations
        private void Solve()
        {
            bool completed = true, err = false;
            decimal tmpF = 1;
            switch (operation)
            {
                case "SquareRoot":
                    if (num1 >= 0)
                    {
                        try
                        {
                            tmpF = (decimal)Math.Sqrt((double)num1);
                        }
                        catch (OverflowException)
                        {
                            err = true;
                            Error();
                        }
                    }
                    break;
                case "^":
                    try
                    {
                        tmpF = (decimal)Math.Pow((double)num1, (double)num2);
                    }
                    catch (OverflowException)
                    {
                        err = true;
                        Error();
                    }
                    break;
                case "Reciprocal":
                    try
                    {
                        if (num1 != 0)
                        {
                            tmpF = 1 / num1;
                        }
                        else
                        {
                            tmpF = 0;
                        }
                    }
                    catch (OverflowException)
                    {
                        err = true;
                        Error();
                    }
                    break;
                case "/":
                    try
                    {
                        if (num2 != 0)
                        {
                            tmpF = num1 / num2;
                        }
                        else
                        {
                            tmpF = 0;
                        }
                    }
                    catch (OverflowException)
                    {
                        err = true;
                        Error();
                    }
                    break;
                case "*":
                    try
                    {
                        tmpF = num1 * num2;
                    }
                    catch (OverflowException)
                    {
                        err = true;
                        Error();
                    }
                    break;
                case "-":
                    try
                    {
                        tmpF = num1 - num2;
                    }
                    catch (OverflowException)
                    {
                        err = true;
                        Error();
                    }
                    break;
                case "+":
                    try
                    {
                        tmpF = num1 + num2;
                    }
                    catch (OverflowException)
                    {
                        err = true;
                        Error();
                    }
                    break;
                default:
                    completed = false;
                    break;
            }

            if(completed && !err)
            {
                AddHistory(tmpF);
                operation = "";
                number2 = false;
                num1 = tmpF;
                UpdateText();
            }
        }

        private void AddNumber(int i)
        {
            bool err = false;
            if(i == 88)     //code for decimal button
            {
                if (number2)
                {
                    if(num2 % 1  == 0)
                    {
                        decimalOn = true;
                    }
                }else if(operation != "")
                {
                    decimalOn = true;
                }
                else
                {
                    if(num1 % 1 == 0)
                    {
                        decimalOn = true;
                    }
                }
            }
            else
            {
                if(number2)
                {
                    string tmp = num2.ToString();
                    if(decimalOn)
                    {
                        tmp = tmp + ".";
                        decimalOn = false;
                    }
                    tmp = tmp + i.ToString();
                    if(!decimal.TryParse(tmp, out num2))
                    {
                        err = true;
                        Error();
                    }
                }else if(operation != "")
                {
                    number2 = true;
                    if (decimalOn)
                    {
                        if(!decimal.TryParse("." + i.ToString(), out num2)){
                            err = true;
                            Error();
                        }
                    }
                    else
                    {
                        num2 = i;
                    }
                }
                else
                {
                    if(num1 == 0)
                    {
                        if (decimalOn)
                        {
                            if(!decimal.TryParse("0." + i.ToString(), out num1))
                            {
                                err = true;
                                Error();
                            }
                            decimalOn = false;
                        }
                        else
                        {
                            num1 = i;
                        }
                    }
                    else
                    {
                        string tmp = num1.ToString();
                        if (decimalOn)
                        {
                            tmp = tmp + ".";
                            decimalOn = false;
                        }
                        tmp = tmp + i.ToString();
                        if(!decimal.TryParse(tmp, out num1))
                        {
                            err = true;
                            Error();
                        }
                    }
                }
            }
            if (!err)
            {
                UpdateText();
            }
        }

        private void UpdateText()
        {
            string tmp = "";
            if (number2)
            {
                if (decimalOn)
                {
                    tmp = num1.ToString() + operation + num2.ToString() + ".";
                }
                else
                {
                    tmp = num1.ToString() + operation + num2.ToString();
                }
            }
            else if (operation != "")
            {
                if (decimalOn)
                {
                    tmp = num1.ToString() + operation + "0.";
                }
                else
                {
                    tmp = num1.ToString() + operation;
                }
            }
            else
            {
                if (decimalOn)
                {
                    tmp = num1.ToString() + ".";
                }
                else
                {
                    tmp = num1.ToString();
                }
            }
            if(tmp.Length > 19)
            {
                txtInputOutput.Text = tmp.Substring(tmp.Length - 19);
            }
            else
            {
                txtInputOutput.Text = tmp;
            }
        }

        private void AddHistory(decimal sol)
        {
            switch (operation)
            {
                case "SquareRoot":
                    listView1.Items.Insert(0, "Sqrt(" + num1.ToString() + ")=" + sol.ToString());
                    break;
                case "Reciprocal":
                    listView1.Items.Insert(0, "1/" + num1.ToString() + "=" + sol.ToString());
                    break;
                default:
                    listView1.Items.Insert(0, num1.ToString() + operation + num2.ToString() + "=" + sol.ToString());
                    break;
            }
        }

        private void Error()
        {
            txtInputOutput.Text = "Error";
            num1 = 0;
            operation = "";
            num2 = 0;
            number2 = false;
        }
        #endregion

        #region CalculatorButton/OperationFunctions
        private void btnHistoryToggle_Click(object sender, EventArgs e)
        {
            if (historyOpen)
            {
                Size = new System.Drawing.Size(342, 346);
                historyOpen = false;
            }
            else
            {
                Size = new System.Drawing.Size(520, 346);
                historyOpen = true;
            }
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            if(operation != "" && number2)
            {
                Solve();
            }
            operation = "SquareRoot";
            Solve();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (operation != "" && number2)
            {
                Solve();
            }
                operation = "^";
                num2 = 2;
                Solve();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (operation != "" && number2)
            {
                Solve();
            }
            operation = "^";
            number2 = false;
            UpdateText();
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (operation != "" && number2)
            {
                Solve();
            }
            operation = "Reciprocal";
            Solve();
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            num1 = 0;
            operation = "";
            num2 = 0;
            number2 = false;
            UpdateText();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            btnClearEntry_Click(sender, e);
            listView1.Items.Clear();
            UpdateText();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            bool err = false;
            if (number2)
            {

                string tmp = num2.ToString();
                tmp = tmp.Remove(tmp.Length - 1);
                if(tmp == "")
                {
                    num2 = 0;
                    number2 = false;
                }
                else
                {
                    if(!decimal.TryParse(tmp, out num2))
                    {
                        err = true;
                        Error();
                    }
                }
            }
            else if (operation != "")
            {
                operation = "";
            }
            else if(num1 != 0)
            {
                string tmp = num1.ToString();
                tmp = tmp.Remove(tmp.Length - 1);
                if(tmp == "")
                {
                    num1 = 0;
                }
                else
                {
                    if(!decimal.TryParse(tmp, out num1)){
                        err = true;
                        Error();
                    }
                }
            }
            if (!err)
            {
                UpdateText();
            }
            else
            {
                num1 = 0;
                operation = "";
                num2 = 0;
                number2 = false;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if(operation != "" && number2)
            {
                Solve();
            }
            operation = "/";
            UpdateText();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if(operation != "" && number2)
            {
                Solve();
            }
            operation = "*";
            UpdateText();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            if(operation != "" && number2)
            {
                Solve();
            }
            operation = "-";
            UpdateText();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if(operation != "" && number2)
            {
                Solve();
            }
            operation= "+";
            UpdateText();
        }

        private void btnSignSwitch_Click(object sender, EventArgs e)
        {
            if (number2)
            {
                num2 = num2 * -1;
            }else if(operation == "")
            {
                num1 = num1 * -1;
            }
            UpdateText();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (operation != "" && number2)
            {
                Solve();
            }
        }
        #endregion

        #region AddNumberFunctions
        private void btnSeven_Click(object sender, EventArgs e)
        {
            AddNumber(7);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            AddNumber(8);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            AddNumber(9);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            AddNumber(4);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            AddNumber(5);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            AddNumber(6);
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            AddNumber(1);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            AddNumber(2);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            AddNumber(3);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            AddNumber(0);
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            AddNumber(88);
        }
        #endregion

        #region KeyPressEventHandler
        //Connects keyboard presses to various button clicks.
        void frmCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tmp = (int)e.KeyChar;
            switch (tmp)
            {
                case 8:     // backspace
                    btnBackspace_Click(sender, e);
                    break;
                case 47:    //  /
                    btnDivide_Click(sender, e);
                    break;
                case 55:    //  7
                    btnSeven_Click(sender, e);
                    break;
                case 56:    //  8
                    btnEight_Click(sender, e);
                    break;
                case 57:    //  9
                    btnNine_Click(sender, e);
                    break;
                case 42:    //  *
                    btnMultiplication_Click(sender, e);
                    break;
                case 52:    //  4
                    btnFour_Click(sender, e);
                    break;
                case 53:    //  5
                    btnFive_Click(sender, e);
                    break;
                case 54:    //  6
                    btnSix_Click(sender, e);
                    break;
                case 45:    //  -
                    btnSubtraction_Click(sender, e);
                    break;
                case 49:    //  1
                    btnOne_Click(sender, e);
                    break;
                case 50:    //  2
                    btnTwo_Click(sender, e);
                    break;
                case 51:    //  3
                    btnThree_Click(sender, e);
                    break;
                case 43:    //  +
                    btnAddition_Click(sender, e);
                    break;
                case 48:    //  0
                    btnZero_Click(sender, e);
                    break;
                case 46:    //  .
                    btnDecimal_Click(sender, e);
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}