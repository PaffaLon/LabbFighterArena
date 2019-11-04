using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Menu
{
    class Menu
    {
        public int ActiveApplicationMenu { get; set; }
        public int MenuButton { get; set; }
        
        public string[] menuContent;

        public enum ApplicationMenus
        {
            MainMenu,
            HeroMenu,
            CombatLog
        }

        public enum NewHero
        {
            HeroName,
            Health,
            MaxHealth,
            Strength
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
