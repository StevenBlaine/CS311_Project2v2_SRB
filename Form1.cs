using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_Project2v2_SRB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int balance = 100;
        private int bet;
        private int point;
        public int dieTotal;
        private bool initialRoll = true;
        private bool gameOver;
        private void btnRoll_Click(object sender, EventArgs e)
        {
            while (!gameOver)
            {
                bet = int.Parse(txtBet.Text);
                if (balance >= bet)
                {
                    calculate_score();
                    if (initialRoll)
                    {
                        first_Roll();
                        return;
                    }
                    else
                    {
                        later_Roll();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("You do not have enough money to make that bet.");
                    return;
                }
            } // end gameOver-based processing
        } // end btnRoll_Click
        private void calculate_score()
        {
            Random rnd = new Random();
            int die1;
            int die2;
            die1 = rnd.Next(1, 6 + 1); // first die value
            die2 = rnd.Next(1, 6 + 1); // second die value
            lblDie1.Text = die1.ToString();
            switch (die1)
            {
                case 1:
                    picDie1.Image = Image.FromFile("..//..//Resources//Die1.png");
                    break;
                case 2:
                    picDie1.Image = Image.FromFile("..//..//Resources//Die2.png");
                    break;
                case 3:
                    picDie1.Image = Image.FromFile("..//..//Resources//Die3.png");
                    break;
                case 4:
                    picDie1.Image = Image.FromFile("..//..//Resources//Die4.png");
                    break;
                case 5:
                    picDie1.Image = Image.FromFile("..//..//Resources//Die5.png");
                    break;
                case 6:
                    picDie1.Image = Image.FromFile("..//..//Resources//Die5.png");
                    break;
            }
            lblDie2.Text = die2.ToString();
            switch (die2)
            {
                case 1:
                    picDie2.Image = Image.FromFile("..//..//Resources//Die1.png");
                    break;
                case 2:
                    picDie2.Image = Image.FromFile("..//..//Resources//Die2.png");
                    break;
                case 3:
                    picDie2.Image = Image.FromFile("..//..//Resources//Die3.png");
                    break;
                case 4:
                    picDie2.Image = Image.FromFile("..//..//Resources//Die4.png");
                    break;
                case 5:
                    picDie2.Image = Image.FromFile("..//..//Resources//Die5.png");
                    break;
                case 6:
                    picDie2.Image = Image.FromFile("..//..//Resources//Die6.png");
                    break;
             }
            dieTotal = die1 + die2; // dice roll total
        } // end calculate_score()
        private void first_Roll()
        {
            switch (dieTotal)
            {
                    case 7: // initial roll win
                    case 11: // initial roll win
                        lblOutcome.Text = "You win on the first roll!";
                        balance += bet;
                        lblBalance.Text = balance.ToString();
                        gameOver = true;
                        return;
                    case 2: // initial roll loss 
                    case 3: // initial roll loss 
                    case 12: // initial roll loss 
                        lblOutcome.Text = "You lose on the first roll!";
                        balance -= bet;
                        lblBalance.Text = balance.ToString();
                        gameOver = true;
                        return;
                    case 4:
                    case 5:
                    case 6:
                    case 8:
                    case 9:
                    case 10:
                        lblOutcome.Text = "Point is " + dieTotal + ".";
                        point = dieTotal;
                        initialRoll = false;
                        return;
             }
        } // end initialRoll outcomes
        private void later_Roll()
        {
            if (dieTotal == 7)
            {
                lblOutcome.Text = "You lose on a later roll!";
                balance -= bet;
                lblBalance.Text = balance.ToString();
                gameOver = true;
                return;
            }
            else
            {
               if (dieTotal != point) // point missed on roll after initial
               {
                    MessageBox.Show("Point not hit.");
                    initialRoll = false;
                    gameOver = false;
                    return;
               }
               else // win on what was not initial roll
               {
                    lblOutcome.Text = "You win on a later roll!";
                    balance += bet;
                    lblBalance.Text = balance.ToString();
                    gameOver = true;
                    return;
               }
            }
        }
    } // end form
} // end namespace