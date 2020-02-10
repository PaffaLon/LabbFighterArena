using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Entities.Characters.Monsters
{
    interface IMonster
    {
        public void Load() { }
    }
    abstract class Monster : Character
    {
        public void Load() { }
        public void Save() { }
        public void ResiveDamage() { }

    }
}
