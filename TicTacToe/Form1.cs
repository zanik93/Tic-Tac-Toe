using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool Turn = true; // true = X's turn, false = O's turn
        int TurnCount = 0;
        static string Player1, Player2;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();

            label1.Text = Player1;
            label3.Text = Player2;
        }

        public static void SetPlayerNames(string playerOne, string playerTwo) //Setting the names of the players
        {
            Player1 = playerOne;
            Player2 = playerTwo;
        }

        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // Exiting the app.
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e) 
        {
            Button b = (Button)sender;
            if(Turn) 
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            Turn = !Turn; // After every press on the button we switch the bool statement around

            TurnCount++; 
        
            b.Enabled = false; // After the button is clicked we disable it.

            CheckForWinner();
        }

        private void CheckForWinner()
        {
            bool ThereIsAWinner = false;


            //Horizontal checks for a winner

            if ((A1btn.Text == A2btn.Text) && (A2btn.Text == A3btn.Text) && (!A1btn.Enabled))
                ThereIsAWinner = true;

            else if ((B1btn.Text == B2btn.Text) && (B2btn.Text == B3btn.Text) && (!B1btn.Enabled))
                ThereIsAWinner = true;

            else if ((C1btn.Text == C2btn.Text) && (C2btn.Text == C3btn.Text) && (!C1btn.Enabled))
                ThereIsAWinner = true;



            //Vertical checks for a winner

            else if ((A1btn.Text == B1btn.Text) && (B1btn.Text == C1btn.Text) && (!A1btn.Enabled))
                ThereIsAWinner = true;

            else if ((A2btn.Text == B2btn.Text) && (B2btn.Text == C2btn.Text) && (!A2btn.Enabled))
                ThereIsAWinner = true;

            else if ((A3btn.Text == B3btn.Text) && (B3btn.Text == C3btn.Text) && (!A3btn.Enabled))
                ThereIsAWinner = true;


            //Diagonal checks for a winner

            else if ((A1btn.Text == B2btn.Text) && (B2btn.Text == C3btn.Text) && (!A1btn.Enabled)) // with !A1btn.Enabled we check if the button has been pressed, otherwise every other button will be the same and it will always say X's winner
                ThereIsAWinner = true;

            else if ((A3btn.Text == B2btn.Text) && (B2btn.Text == C1btn.Text) && (!C1btn.Enabled))
                ThereIsAWinner = true;




            if (ThereIsAWinner)
            {
                DisableButtons();

                string Winner = "";

                if (Turn) // bool turn true is always X
                {
                    Winner = Player2; 
                    o_win_countlbl.Text = (int.Parse(o_win_countlbl.Text) + 1).ToString();
                }
                else
                {
                    Winner = Player1;
                    x_win_countlbl.Text = (int.Parse(x_win_countlbl.Text) + 1).ToString();
                }


                MessageBox.Show(Winner + " Wins!", "WINNER");
            }
            else
            {
                if(TurnCount == 9)
                {
                    MessageBox.Show("DRAW!", "BUMMER");
                    draw_countlbl.Text = (int.Parse(draw_countlbl.Text) + 1).ToString();
                }
            }

        }

        private void DisableButtons() // Disable all the buttons if theres a winner.
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Button)) // Getting only the buttons so we can avoid exception.
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
        }

        //private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Turn = true;
        //    TurnCount = 0;

        //    foreach (Control c in Controls)
        //    {
        //        if (c.GetType() == typeof(Button))
        //        {
        //            Button b = (Button)c;
        //            b.Enabled = true;
        //            b.Text = "";
        //        }
        //    }
        //}

        private void button_enter(object sender, EventArgs e) // Showing who's turn it is.
        {
            Button b = (Button) sender;
            if (b.Enabled) // Checking to see if the button is clicked.
            {
                if (Turn)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
            }
        }

        private void button_leave(object sender, EventArgs e) 
        {
            Button b = (Button)sender;
            if (b.Enabled) // Checking to see if the button is clicked.
            {
                b.Text = "";
            }
        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Turn = true;
            TurnCount = 0;

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
        }

        private void resetScoreboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_countlbl.Text = "0";
            x_win_countlbl.Text = "0";
            draw_countlbl.Text = "0";
        }


    }
}
