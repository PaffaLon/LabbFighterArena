using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Menu
{
    public class Menu
    {
        // Public enums
        public enum ApplicationMenus
        { 
            MainMenu, 
            HeroMenu, 
            CombatLog 
        }        

        //Public Feilds
        public List<string> menuElements = new List<string>();
        
        //Public Properies
        public int ActiveApplicationMenu { get; set; }
        public int MenuButton { get; set; }
    }
}