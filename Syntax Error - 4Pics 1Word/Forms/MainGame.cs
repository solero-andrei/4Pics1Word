using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Syntax_Error___4Pics_1Word
{
    public partial class MainGame : Form
    {
        public MainGame()
        {
            InitializeComponent();
        }
        
        int counter = 0;
        int tmp = 0;
               
        private void MainGame_Load(object sender, EventArgs e)
        {
            Tile.LoadImage(mainPanel);
            Tile.LoadRumbledWord(mainPanel);
        }

        private void btntext_Click(object sender, EventArgs e)
        {
            int tag = int.Parse(((Guna2Button)sender).Tag.ToString());

            Gameboard.Audio("removeLetters.wav");
            ((Guna2Button)sender).Text = "";
            counter = int.Parse(((Guna2Button)sender).Tag.ToString());

            if (counter == 0)
                tmp = int.Parse(((Guna2Button)sender).Tag.ToString());

        }
                
        private void btn_MouseClick(object sender, MouseEventArgs e)
        {
            Gameboard.Audio("selectLetters.wav");
            Guna2Button[] btn = { firstTextButton, secondTextButton, thirdTextButton, fourthTextButton, fifthTextButton, sixthTextButton };
            //int tag = int.Parse(btn[counter].Tag.ToString());
            ((Guna2GradientButton)sender).Visible = false;
            if (btn[counter].Text == "")
            {
                btn[counter].Text = ((Guna2GradientButton)sender).Text;
                counter++;
            }
            else
            {
                counter++;                
            }
            
        }

        private void HintButton_Click(object sender, EventArgs e)
        {
            //Gameboard.Audio("correct.wav");
            //bunifuTransition1.ShowSync(correctAnswer1);

            MessageBox.Show(DataAccesss.GetWord());
        }
    }   
}


