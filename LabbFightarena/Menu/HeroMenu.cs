using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Menu
{
    public class HeroMenu
    {
        public enum Buttons
        {
            NewHero,
            LoadHero,
            Exit
        }
        public string[] getMenuItems = new string[3];

        public void Content(int menuButton)
        {
            string[] seletedMenuItems = new string[3];
            string[] unselectedMenuItems = new string[3];

            seletedMenuItems[0] = (">> New Hero <<");
            seletedMenuItems[1] = (">> Load Hero <<");
            seletedMenuItems[2] = (">> Exit <<");

            unselectedMenuItems[0] = ("New Hero");
            unselectedMenuItems[1] = ("Load Hero");
            unselectedMenuItems[2] = ("Exit");

            if(menuButton == 0)
            {
                getMenuItems[0] = seletedMenuItems[0];
                getMenuItems[1] = unselectedMenuItems[1];
                getMenuItems[2] = unselectedMenuItems[2];
            }
            else if(menuButton == 1)
            {
                getMenuItems[0] = unselectedMenuItems[0];
                getMenuItems[1] = seletedMenuItems[1];
                getMenuItems[2] = unselectedMenuItems[2];
            }
            else if(menuButton == 2)
            {
                getMenuItems[0] = unselectedMenuItems[0];
                getMenuItems[1] = unselectedMenuItems[1];
                getMenuItems[2] = seletedMenuItems[2];
            }
        }
    }
}
