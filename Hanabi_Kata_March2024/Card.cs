﻿namespace Hanabi_Kata_March2024
{
    enum CardColors
    {
        RED,
        BLUE,
        WHITE,
        GREEN,
        YELLOW
    }

    // TODO : properties can be modified /!\
    internal class Card
    {
        public int value;
        public CardColors color;
        public Card(int value, CardColors color) { 
            this.value = value;
            this.color = color;
        }


    }
}