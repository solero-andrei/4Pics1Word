using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syntax_Error___4Pics_1Word
{
    public class Gameboard
    {
        public static void Audio(string filename)
        {
            string path = Application.StartupPath + @"\Audio\" + filename;
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(path.ToString());
            audio.Play();   //Plays the audio when the button is clicked    
        }



    }
}
