using System.Collections.Generic;
using System;
namespace Game.Models
{
    public class Card
    {
        public string CardName;
        public int Attack;
        public int Health;
    

public Card(string CardName, int Attack, int Health)
    {
        _CardName = CardName;
        _Attack = Attack;
        _Health = Health;
    }

    public string ForceDraw()
    {
        return _CardName = CardName;
    }

    }
}