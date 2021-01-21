using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars_Task_1
{
    class JadenCase
    {
        public string ToJadenCase(string phrase)
        {
            char emtySign = ' ';
            string changedPhrase = null;
            char previousCharacter = ' ';
            for (int i = 0; i < phrase.Length; i++)
            {
                previousCharacter = previousCharacter == emtySign ? Char.ToUpper(Convert.ToChar(phrase[i])) : phrase[i];
                changedPhrase += previousCharacter;
            }
            return $"{new string('_', 100)}\nChanged Phrase:\n{changedPhrase}";
        }
    }
}
