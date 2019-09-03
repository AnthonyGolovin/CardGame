using System.Collections.Generic;

namespace Game.Models
{
    public class Player
    {
        public string PlayerName;
        public int PlayerHealth;

     public Player(string PlayerName, int PlayerHealth)
    {
        _PlayerName = PlayerName;
        _PlayerHealth = PlayerHealth;
    }
    
    }
}