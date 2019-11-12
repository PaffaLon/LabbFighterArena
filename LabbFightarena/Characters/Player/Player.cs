using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Characters.Player
{
    public class Player : Character
    {
        public int ID { get; set; }
        private int _health = 100;
        private int _maxHealth = 100;


        public Player()
        {
            Health = _health;
            MaxHealth = _maxHealth;
        }

        public Player(int health, int damage, bool isInCombat)
        {

        }

        private int DamagePlayer(int attackDamage, int health)
        {
            this.Health = health - attackDamage;
            return Health;
        }

        //Compares the characters current health with minimum health requerd to be alive.
        private bool HealthCheck(int health)
        {
            if (health <= this.MinHealth)
                this.IsAlive = false;
            else
                this.IsAlive = true;

            return IsAlive;
        }
    }
}