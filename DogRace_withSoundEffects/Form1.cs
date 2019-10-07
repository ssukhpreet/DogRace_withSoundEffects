using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace_withSoundEffects
{
    public partial class Form1 : Form
    {

        // object of the all classes that are used to call  the method of the class to move  the 
        Player1 p1_Object = new Player1();
        Player2 p2_Object = new Player2();
        Player3 p3_Object = new Player3();
        Player4 p4_Object = new Player4();
         //global variable of the program to pass the amount of the player
        int p1_amount = 78, p2_amount = 78, p3_amount = 78;

        //get the name of the player who is participating in the game
        String Player1 = "";
        //variable that are used to check the condition and  then pass the value 
        int chk1 = 0, chk2 = 0;

        public Form1()
        {
            InitializeComponent();
            //disable the button of the game to start the game 
            Fire.Enabled = false;
        }

        private void p1_Click(object sender, EventArgs e)
        {
            // if the player choose the first player then the mesage box will print 
            MessageBox.Show("Player Lakhsay is selected for  the bet \n now click on the dog to set the bet amount ");
            Player1 = "Lakshay has choosed the Dog ";
            chk1 = 1;
        }

        private void p2_Click(object sender, EventArgs e)
        {
            // if the player choose the 2nd player then the mesage box will print 
            MessageBox.Show("Player Dolly is selected for  the bet \n now click on the dog to set the bet amount ");
            Player1 = "Dolly has choosed the Dog ";
            chk1 = 1;
        }

        private void p3_Click(object sender, EventArgs e)
        {
            // if the player choose the 3rd player then the mesage box will print 
            MessageBox.Show("Player Gurinder is selected for  the bet \n now click on the dog to set the bet amount ");
            Player1 = "Gurinder has choosed the Dog ";
            chk1 = 1;
        }

        private void d1_Click(object sender, EventArgs e)
        {
            if (chk1 == 1)
            {
                // when the player choose the dog 1 then 
                MessageBox.Show("dog 1 is selected now fill the amount to bet ");
                Player1 = Player1 + "1 for the Bet of Dollar ";
                chk2 = 1;
            }
            else {
                MessageBox.Show("first select the player");
            }
            
        }

        private void d2_Click(object sender, EventArgs e)
        {
            if (chk1 == 1)
            {
                // when the player choose the dog 2 then 
                MessageBox.Show("dog 2 is selected now fill the amount to bet ");
                Player1 = Player1 + "2 for the Bet of Dollar ";
                chk2 = 1;
            }
            else {
                MessageBox.Show("first select the player");
            }
        }

        private void d3_Click(object sender, EventArgs e)
        {
            if (chk1 == 1)
            {
                // when the player choose the dog 3 then 
                MessageBox.Show("dog 3 is selected now fill the amount to bet ");
                Player1 = Player1 + "3 for the Bet of Dollar ";
                chk2 = 1;
            }
            else {
                MessageBox.Show("select the player first ");
            }
            
        }

        private void d4_Click(object sender, EventArgs e)
        {
            if (chk1 == 1)
            {
                // when the player choose the dog 4 then 
                MessageBox.Show("dog 4 is selected now fill the amount to bet ");
                Player1 = Player1 + "4 for the Bet of Dollar ";
                chk2 = 1;
            }
            else {
                MessageBox.Show("first select the player ");
            }
            
        }

        private void Fire_Click(object sender, EventArgs e)
        {
            // when we want to start  the game then the timer will start the working and move the dog from one place to another 
            timer1.Start();

        }

        public void winner() {
            int res = 0;
            
            //when the dog reach at the finishing line then the winner message  will automatically called by the timer and show the message of the winner or looser

            
            if (p1_Object.gameover(d1.Left, timer1) > 0)
            {
                res = p1_Object.gameover(d1.Left, timer1);
                MessageBox.Show("Dog " + res + " won the race ");
                timer1.Stop();
                result_Declare(res);
            }

            
            if (p2_Object.gameover(d2.Left, timer1) > 0)
            {
                res = p2_Object.gameover(d2.Left, timer1);
                MessageBox.Show("Dog " + res + " won the race ");
                timer1.Stop();

                result_Declare(res);

            }


            if (p3_Object.gameover(d3.Left, timer1) > 0)
            {
                res = p3_Object.gameover(d3.Left, timer1);
                MessageBox.Show("Dog " + res + " won the race ");
                timer1.Stop();
                result_Declare(res);
            }

            
            if (p4_Object.gameover(d4.Left, timer1) > 0)
            {
                res = p4_Object.gameover(d4.Left, timer1);
                MessageBox.Show("Dog " + res + " won the race ");
                timer1.Stop();
                result_Declare(res);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // this method is also used to increment or decrement the value from the account  of the player 
        public void result_Declare(int dog) {

            char sep = ' ';
            String[] t= stmt1.Text.ToString().Split(sep);
            if (t.Length > 10 && t[5].Equals(dog.ToString())) {
                 p1_amount = p1_amount + Convert.ToInt32(t[t.Length-1]);
                MessageBox.Show("Lakshay you win the game");
                label1.Text = "Lakshay has " + p1_amount + " Dollar";
            }
            else if (t.Length > 10 && ! t[5].Equals(dog.ToString()))
            {
                p1_amount = p1_amount - Convert.ToInt32(t[t.Length - 1]);
                MessageBox.Show("Lakshay you lose the game");
                label1.Text = "Lakshay has " + p1_amount + " Dollar";
            }

            String[] t2 = stmt2.Text.ToString().Split(sep);
            if (t2.Length > 10 && t2[5].Equals(dog.ToString()))
            {
                p2_amount = p2_amount + Convert.ToInt32(t2[t2.Length - 1]);
                MessageBox.Show("Dolly you win the game");
                label2.Text = "Dolly has " + p2_amount + " Dollar";
            }
            else if (t2.Length > 10 && !t2[5].Equals(dog.ToString()))
            {
                p2_amount = p2_amount - Convert.ToInt32(t2[t2.Length - 1]);
                MessageBox.Show("Dolly you lose the game");
                label2.Text = "Dolly has " + p2_amount + " Dollar";
            }

            String[] t3 = stmt3.Text.ToString().Split(sep);
            if (t3.Length > 10 && t3[5].Equals(dog.ToString()))
            {
                p3_amount = p3_amount + Convert.ToInt32(t3[t3.Length - 1]);
                MessageBox.Show("Gurinder you win the game");
                label3.Text = "Gurinder has " + p3_amount + " Dollar";
            }
            else if (t3.Length > 10 && !t3[5].Equals(dog.ToString()))
            {
                p3_amount = p3_amount - Convert.ToInt32(t3[t3.Length - 1]);
                MessageBox.Show("Gurinder you lose the game");
                label3.Text = "Gurinder has " + p3_amount + " Dollar";
            }


            chk1 = 0;
            chk2 = 0;
            stmt1.Text = "Lakshay has " + p1_amount + " DOllar";
            stmt2.Text = "Dolly has " + p2_amount + " DOllar";
            stmt3.Text = "Gurinder has " + p3_amount + " DOllar";

            d1.Left = 0;
            d2.Left = 0;
            d3.Left = 0;
            d4.Left = 0;

            Amount.Value = 1;
            Fire.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        
            //this code call the method of the class and move the dog from one step forward 
            d1.Left = d1.Left + p1_Object.jump();
            d2.Left = d2.Left + p1_Object.jump();
            d3.Left = d3.Left + p1_Object.jump();
            d4.Left = d4.Left + p1_Object.jump();

            winner();

        }

        private void setting_Click(object sender, EventArgs e)
        {
            //here we are setup the bet of the game that is used to start the game and pass to the pannel
            Fire.Enabled = true;

            if (chk1 == 1 && chk2 == 1)
            {
                String h = Player1.Substring(0, Player1.IndexOf(' '));
                if (h.Equals("Dolly") && Amount.Value <= p1_amount)
                {
                    stmt2.Text = Player1 + Amount.Value;
                }

                else if (h.Equals("Lakshay") && Amount.Value <= p2_amount)
                {
                    stmt1.Text = Player1 + Amount.Value;
                }
                
                else if (h.Equals("Gurinder") && Amount.Value <= p3_amount)
                {
                    stmt3.Text = Player1 + Amount.Value;
                }
                else
                {
                    MessageBox.Show("Value must be less than or equal to the balance ");
                }
                chk1 = 0;
                chk2 = 0;
            }
            else {
                MessageBox.Show("Select the  Player and Dog first to play the game ");
            }


        }
    }
}
