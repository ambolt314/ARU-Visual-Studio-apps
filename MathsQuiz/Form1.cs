using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsQuiz
{
    public partial class Form1 : Form
    {

        Random randomiser = new Random();

        int addend1;
        int addend2;

        int minuend;
        int subtrahend;

        int multiplicand;
        int multiplier;

        int dividend;
        int divisor;

        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

        public void StartTheQuiz()
        {
            //Addition
            addend1 = randomiser.Next(51);
            addend2 = randomiser.Next(51);

            lblPlusLeft.Text = addend1.ToString();
            lblPlusRight.Text = addend2.ToString();

            sum.Value = 0;

            //Subtraction
            minuend = randomiser.Next(1, 101);
            subtrahend = randomiser.Next(1, minuend);

            lblMinusLeft.Text = minuend.ToString();
            lblMinusRight.Text = subtrahend.ToString();

            difference.Value = 0;

            //Multiplication
            multiplicand = randomiser.Next(2, 11);
            multiplier = randomiser.Next(2, 11);

            lblMultiplyLeft.Text = multiplicand.ToString();
            lblMultiplyRight.Text = multiplier.ToString();

            product.Value = 0;

            //Division
            divisor = randomiser.Next(2, 11);
            int tempQuotient = randomiser.Next(2, 11);
            dividend = divisor * tempQuotient;

            lblDivideLeft.Text = dividend.ToString();
            lblDivideRight.Text = divisor.ToString();

            quotient.Value = 0;

            //Start the timer
            timeLeft = 30;
            lblTime.Text = "30 seconds";
            timer1.Start();
            lblTime.BackColor = Color.Empty;
        }

        private bool CheckTheAnswer()
        {
            return (addend1 + addend2 == sum.Value) && (minuend - subtrahend == difference.Value) && (multiplicand * multiplier == product.Value) && (dividend / divisor == quotient.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            btnStart.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timeLeft <= 6)
            {
                lblTime.BackColor = Color.Red;
            }
            else
            {
                lblTime.BackColor = Color.Empty;
            }

            if (CheckTheAnswer())
            {
                timer1.Stop();
                lblTime.BackColor = Color.Green;
                MessageBox.Show("You got all the answers right!",
                        "Congratulations!");
                btnStart.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                lblTime.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                lblTime.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time");

                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;

                btnStart.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
