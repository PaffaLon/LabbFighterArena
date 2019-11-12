using System;
using System.Collections.Generic;
using System.Text;
using LabbFightarena.Characters.Player;
using LabbFightarena.Characters.Monsters;

namespace LabbFightarena.Characters
{
    public class Character
    {
        //Private Enumes
        public enum CharacterType { Player, Monster }

        //Public Properies
        public string Name      { get; set; }
        public int Health       { get; set; }
        public int MaxHealth    { get; set; }
        public int MinHealth    { get;      }
        public int Strength     { get; set; }
        public bool IsInCombat  { get; set; }
        public bool IsAlive     { get; set; }

        //Private Properies
        private int ID { get; set; }

        public Character()
        {
            MinHealth = 0;
        }
    }
}
