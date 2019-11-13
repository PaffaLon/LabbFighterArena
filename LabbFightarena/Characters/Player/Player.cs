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

        /// <summary>
        /// This method removs the amount of health points from the monsters health pool,
        /// equal to the players attack damage.
        /// </summary>
        /// <param name="attackDamage"></param>
        /// <param name="health"></param>
        /// <returns>
        /// Returns the current monster health after the damage to the Combat Class.
        /// </returns>
        public int DamagePlayer(int attackDamage, int health)
        {
            this.Health = health - attackDamage;
            return Health;
        }

        /// <summary>
        /// This method compares the players current health with,
        ///     with the minimum health value allowed.
        /// If the player health is less then 1, the player is consider not alive.
        /// </summary>
        /// <param name="health"></param>
        /// <returns>
        /// A booliean value that defines the players "alive/dead" state.
        /// </returns>
        public bool HealthCheck(int health)
        {
            if (health <= this.MinHealth)
                this.IsAlive = false;
            else
                this.IsAlive = true;

            return IsAlive;
        }
    }
}