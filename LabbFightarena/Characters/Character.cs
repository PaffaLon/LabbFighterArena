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
        public object TypeOfCharacter { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int MinHealth { get; }
        public int Strength { get; set; }

        //Private Properies
        private int ID { get; set; }

    }
}
