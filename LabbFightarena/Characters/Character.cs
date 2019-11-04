using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Characters
{
    public class Character
    {
        public object TypeOfCharacter { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int MinHealth { get; }
        public int Strength { get; set; }

        private enum CharacterType
        {
            Player,
            Monster
        }
    }
}
