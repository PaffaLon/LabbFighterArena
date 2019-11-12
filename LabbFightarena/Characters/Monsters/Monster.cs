using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Characters.Monsters
{
    public class Monster : Character
    {
        public int ID { get; set; }
        private int _health;
        private int _maxHealth;

        public Monster()
        {
            Health = _health;
            MaxHealth = _maxHealth;
        }

        public int DamageMonster(int attackDamage, int health)
        {
            this.Health = health - attackDamage;
            return Health;
        }

        public bool HealthCheck(int health)
        {
            if (health <= this.MinHealth)
                this.IsAlive = false;
            else
                this.IsAlive = false;

            return IsAlive;
        }
    }
}
