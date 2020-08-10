using System;

namespace PokerHands
{
    class Cards
    {
        private char Color;
        private char Value;
        public char GetColor()
        {
            return Color;
        }
        public void SetColor(char NewColor)
        {
            Color = NewColor;
        }
        public char GetValue()
        {
            return Value;
        }
        public void SetValue(char NewValue)
        {
            Value = NewValue;
        }

    }
}
