using System.Collections.Generic;

namespace Game.Models
{
    public class Enemy
    {
        public string EnemyName;
        public int EnemyHealth;

     public Enemy(string EnemyName, int EnemyHealth)
    {
        _EnemyName = EnemyName;
        _EnemyHealth = EnemyHealth;
        
    }

    }
}