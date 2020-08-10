using System;
using System.IO;

namespace PokerHands
{

    class Hand
    {
        private Cards[] Card = new Cards[5];

        public void SetCards(string[] Str)
        {
            for (int i = 0; i < Card.Length; i++)
            {
                this.Card[i].SetValue(Str[i][0]);
                this.Card[i].SetColor(Str[i][1]);
            }
        }
        

    }
}