using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Syntax_Error___4Pics_1Word
{
    public class Stage : DataAccesss
    {
        public static string[] RandomWord()
        {
            var word = GetWord();
            int upperBound = 12;
            if (word.Length > upperBound)
                throw new Exception("Character count cannot be more than the upper bound");
            var newWord = new string[upperBound];
            var letters = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z".Split(',');

            for (int i = 0; i < upperBound; i++)
            {
                try
                {
                    newWord[i] = word[i].ToString();
                }
                catch
                {
                    var random = new Random().Next(0, (letters.Length - 1));
                    newWord[i] = letters[random];
                }
            }

            return newWord
                .Select(w => new { Id = Guid.NewGuid(), letters = w, }).OrderBy(x => x.Id).Select(x => x.letters.ToUpper()).ToArray();
        }

    }
}
