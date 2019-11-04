using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Menu
{
    class Menu
    {
        public int ActiveApplicationMenu { get; set; }
        public int MenuButton { get; set; }

        public List<string> menuElements = new List<string>();

        public enum ApplicationMenus
        {
            MainMenu,
            HeroMenu,
            CombatLog
        }

        public enum LoadHero
        {
            HeroItem,
            Exit
        }

        public enum CustomizeHero
        {
            HeroName,
            Health,
            MaxHealth,
            Strength,
        }
    }
}
