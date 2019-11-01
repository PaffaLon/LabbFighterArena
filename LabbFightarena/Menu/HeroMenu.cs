using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Menu
{
    public class HeroMenu
    {
        public void Content(int menuButton, out string[] getMenuItems)
        {
            string[] unselectedMenuItems = new string[3];
            string[] seletedMenuItems = new string[3];
            string[] _getMenuItems = new string[3];

            seletedMenuItems[0] = (">> New Hero <<");
            seletedMenuItems[1] = (">> Load Hero <<");
            seletedMenuItems[2] = (">> Exit <<");

            seletedMenuItems[0] = ("New Hero");
            seletedMenuItems[1] = ("Load Hero");
            seletedMenuItems[2] = ("Exit");

            getMenuItems = _getMenuItems;

            if(menuButton == 0)
            {
                _getMenuItems[0] = seletedMenuItems[0];
                _getMenuItems[1] = unselectedMenuItems[1];
                _getMenuItems[2] = unselectedMenuItems[2];
            }
            else if(menuButton == 1)
            {
                _getMenuItems[0] = unselectedMenuItems[0];
                _getMenuItems[1] = seletedMenuItems[1];
                _getMenuItems[2] = unselectedMenuItems[2];
            }
            else if(menuButton == 2)
            {
                _getMenuItems[0] = unselectedMenuItems[0];
                _getMenuItems[1] = unselectedMenuItems[1];
                _getMenuItems[2] = seletedMenuItems[2];
            }
        }
    }
}
