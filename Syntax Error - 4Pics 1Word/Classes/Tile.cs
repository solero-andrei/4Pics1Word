using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;
using System.IO;

namespace Syntax_Error___4Pics_1Word
{
    public class Tile : Stage
    {
        
        private static string ImagePath = Application.StartupPath + @"\Images\Hard\" + GetWord() + @"\";
               
        public static void LoadImage(Panel panelname) //Loads all the image in pictureboxes
        {

            string[] images = Directory.GetFiles(ImagePath, "*.jpeg", SearchOption.AllDirectories);
            List<Guna2PictureBox> picturebox = panelname.Controls.OfType<Guna2PictureBox>().ToList();

            for(int i = 0; i < picturebox.Count; i++)
            {
                picturebox[i].Image = Image.FromFile(images[i]);
            }                    
            
        }

        public static void LoadRumbledWord(Panel panelname)
        {
            List<Guna2GradientButton> buttons = panelname.Controls.OfType<Guna2GradientButton>().ToList();
            var RandomizedWord = RandomWord();

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Text = RandomizedWord[i].ToString().ToUpper();
            }
        }
    }
}
