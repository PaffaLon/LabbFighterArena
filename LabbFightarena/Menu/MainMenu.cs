using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Menu
{
    public class MainMenu
    {
        public enum Buttons
        {
            Play,
            ScoreBoard,
            CombatLog,
            Exit
        }

        public void Content(int menuButton, out string[] getMenuItems)
        {
            string[] _getMenuItems = new string[4];
            string[] SelectedMenuItems = new string[4];
            string[] unselectedMenuItems = new string[4];

            SelectedMenuItems[0] = (">> Play <<");
            SelectedMenuItems[1] = (">> Scoreboard <<");
            SelectedMenuItems[2] = (">> Combatlog <<");
            SelectedMenuItems[3] = (">> Exit <<");

            unselectedMenuItems[0] = ("Play");
            unselectedMenuItems[1] = ("Scoreboard");
            unselectedMenuItems[2] = ("Combatlog");
            unselectedMenuItems[3] = ("Exit");

            getMenuItems = _getMenuItems;
            if (menuButton == 0)
            {
                _getMenuItems[0] = SelectedMenuItems[0];
                _getMenuItems[1] = unselectedMenuItems[1];
                _getMenuItems[2] = unselectedMenuItems[2];
                _getMenuItems[3] = unselectedMenuItems[3];
            }
            else if(menuButton == 1)
            {
                _getMenuItems[0] = unselectedMenuItems[0];
                _getMenuItems[1] = SelectedMenuItems[1];
                _getMenuItems[2] = unselectedMenuItems[2];
                _getMenuItems[3] = unselectedMenuItems[3];
            }
            else if (menuButton == 2)
            {
                _getMenuItems[0] = unselectedMenuItems[0];
                _getMenuItems[1] = unselectedMenuItems[1];
                _getMenuItems[2] = SelectedMenuItems[2];
                _getMenuItems[3] = unselectedMenuItems[3];
            }
            else if(menuButton == 3)
            {
                _getMenuItems[0] = unselectedMenuItems[0];
                _getMenuItems[1] = unselectedMenuItems[1];
                _getMenuItems[2] = unselectedMenuItems[2];
                _getMenuItems[3] = SelectedMenuItems[3];
            }
        }
    }
}
