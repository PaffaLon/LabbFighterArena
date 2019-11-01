using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Characters.NPC.Monsters
{
    class Monster
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }

        public void Bandit()
        {
            Name = "Bandit";
            MaxHealth = 100;
            Health = MaxHealth;
            //Strength = DiceRoll
        }

        public void Gladiator()
        {

        }
    }
}
