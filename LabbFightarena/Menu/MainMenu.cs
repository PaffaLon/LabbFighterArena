using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Menu
{
    public class MainMenu : Menu
    {
        public enum Buttons
        {
            Play,
            ScoreBoard,
            CombatLog,
            Exit
        }
        public string[] getMenuItems = new string[4];

        public void Content(int menuButton)
        {            
            string[] SelectedMenuItems = new string[4];
            string[] unselectedMenuItems = new string[4];

            SelectedMenuItems[0] = (">>    Play    <<");
            SelectedMenuItems[1] = (">> Scoreboard <<");
            SelectedMenuItems[2] = (">> Combatlog <<");
            SelectedMenuItems[3] = (">>    Exit    <<");

            unselectedMenuItems[0] = ("Play");
            unselectedMenuItems[1] = ("Scoreboard");
            unselectedMenuItems[2] = ("Combatlog");
            unselectedMenuItems[3] = ("Exit");
            if (menuButton == 0)
            {
                getMenuItems[0] = SelectedMenuItems[0];
                getMenuItems[1] = unselectedMenuItems[1];
                getMenuItems[2] = unselectedMenuItems[2];
                getMenuItems[3] = unselectedMenuItems[3];
            }
            else if(menuButton == 1)
            {
                getMenuItems[0] = unselectedMenuItems[0];
                getMenuItems[1] = SelectedMenuItems[1];
                getMenuItems[2] = unselectedMenuItems[2];
                getMenuItems[3] = unselectedMenuItems[3];
            }
            else if (menuButton == 2)
            {
                getMenuItems[0] = unselectedMenuItems[0];
                getMenuItems[1] = unselectedMenuItems[1];
                getMenuItems[2] = SelectedMenuItems[2];
                getMenuItems[3] = unselectedMenuItems[3];
            }
            else if(menuButton == 3)
            {
                getMenuItems[0] = unselectedMenuItems[0];
                getMenuItems[1] = unselectedMenuItems[1];
                getMenuItems[2] = unselectedMenuItems[2];
                getMenuItems[3] = SelectedMenuItems[3];
            }
        }
    }
}
