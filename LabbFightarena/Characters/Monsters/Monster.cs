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

        /// <summary>
        /// This method compares the monsters current health with,
        ///     with the minimum health value allowed.
        /// If the monsters health is less then 1, the player is consider not alive.
        /// </summary>
        /// <param name="health"></param>
        /// <returns>
        /// A booliean value that defines the monsters "alive/dead" state.
        /// </returns>
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
