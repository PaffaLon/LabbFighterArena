using System;
using System.Collections.Generic;
using System.Text;
using LabbFightarena.Characters.Player;

namespace LabbFightarena.Combat
{
    public class Combat
    {
        object objPpayer = new object();
        Player player = new Player();

        

        private void Turn()
        {
            
        }

        private void DamagePlayer()
        {
            
        }

        private void DamageMonster()
        {

        }

        private void PrintCombat()
        {

        }

        private void CombatMenu()
        {
            string[] unselectedMenuItems = new string[2];
            unselectedMenuItems[0] = ("Attack");
            unselectedMenuItems[1] = ("Defend");

            string[] selectedMenuItems = new string[2];
            selectedMenuItems[0] = (">>Attack<<");
            selectedMenuItems[1] = (">>Defend<<");

            string[] combatWindow = new string[2];
            combatWindow[0] = ("|");
            combatWindow[1] = ("2");


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

