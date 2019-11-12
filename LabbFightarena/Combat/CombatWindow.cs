using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Combat
{
    public class CombatWindow
    {
        public void CombatMenu()
        {
            string[] unselectedMenuItems = new string[2];
            unselectedMenuItems[0] = ("Attack");
            unselectedMenuItems[1] = ("Defend");

            string[] selectedMenuItems = new string[2];
            selectedMenuItems[0] = (">>Attack<<");
            selectedMenuItems[1] = (">>Defend<<");

            string[] combatWindow = new string[2];
            combatWindow[0] = ("|");
            combatWindow[1] = ("-");



            /*
            |---------------------------------------------------|
            |   PlayerName                  |   Monster         |
            |   HP:     100                 |   HP:     100     |
            |   Str:    5                   |   str:    5       |
            |   Armor:  5                   |   Armor:  5       |
            |                               |                   |
            |   Attack  >>Defend<<          |                   |
            |---------------------------------------------------|
            */

        }
    }
}
