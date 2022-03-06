namespace calculadora
{
    public partial class Form1 : Form
    {
        int firstNumber = 0;
        string symbol = "";

        public Form1()
        {
            InitializeComponent();
            
        }

        public void CheckForCorrectInput(String input)
        {
            if (textResult.Text == "0")
            {
                textResult.Text = input;

            }
            else
            {
                textResult.Text = textResult.Text + input;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textResult.Text = "";
        }


        private void btnPercent_Click(object sender, EventArgs e)
        {
            if(textResult.Text != "0")
            {
                firstNumber = Convert.ToInt32(textResult.Text);
                symbol = "%";
                textResult.Text = "";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            CheckForCorrectInput(btnSeven.Text);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            CheckForCorrectInput(btnEight.Text);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            CheckForCorrectInput(btnNine.Text);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            CheckForCorrectInput(btnFour.Text);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            CheckForCorrectInput(btnFive.Text);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            CheckForCorrectInput(btnSix.Text);
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            CheckForCorrectInput(btnOne.Text);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            CheckForCorrectInput(btnTwo.Text);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            CheckForCorrectInput(btnThree.Text);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(textResult.Text != "0")
            {
                firstNumber = Convert.ToInt32(textResult.Text);
                symbol = "+";
                textResult.Text = "";
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            CheckForCorrectInput(btnZero.Text);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(textResult.Text != "0" && symbol != "" && firstNumber != 0 )
            {
                switch (symbol)
                {
                    case "+":
                        textResult.Text = Convert.ToString(firstNumber + Convert.ToInt32(textResult.Text));
                        break;
                    case "-":
                        textResult.Text = Convert.ToString(firstNumber - Convert.ToInt32(textResult.Text));
                        break;
                    case "*":
                        textResult.Text = Convert.ToString(firstNumber * Convert.ToInt32(textResult.Text));
                        break;
                    case "/":
                        textResult.Text = Convert.ToString(firstNumber / Convert.ToInt32(textResult.Text));
                        break;
                    default:
                        break;
                }
            }
        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            if(textResult.Text != "0")
            {
                firstNumber = Convert.ToInt32(textResult.Text);
                symbol = "*";
                textResult.Text = "";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "0")
            {
                firstNumber = Convert.ToInt32(textResult.Text);
                symbol = "/";
                textResult.Text = "";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "0")
            {
                firstNumber = Convert.ToInt32(textResult.Text);
                symbol = "-";
                textResult.Text = "";
            }
        }
    }
}