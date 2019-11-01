using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Menu
{
    class Menu
    {
        public int ActiveApplicationMenu { get; set; }
        public int ActiveMenu { get; set; }

        public enum ApplicationMenu
        {
            MainMenu,
            HeroMenu,
            CombatLog
        }

        public enum MainMenu
        {
            Play,
            CombatLog,
            Exit
        }

        public enum HeroMenu
        {

        }
    }
}
