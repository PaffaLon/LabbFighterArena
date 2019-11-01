using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Menu
{
    class MenuManager
    {
        readonly Menu menu = new Menu();
        readonly MainMenu mainMenu = new MainMenu();
        public void DefaultValues()
        {
            menu.ActiveApplicationMenu = (int)Menu.ApplicationMenus.MainMenu;
            menu.MenuButton = (int)Menu.MainMenu.Play;
        }

        public void LoadMenu()
        {
            if (menu.ActiveApplicationMenu == (int)Menu.ApplicationMenus.MainMenu)
            {
                if (menu.MenuButton == (int)Menu.MainMenu.Play)
                {

                }
                else if (menu.MenuButton == (int)Menu.MainMenu.CombatLog)
                {

                }
                else if (menu.MenuButton == (int)Menu.MainMenu.Exit)
                {

                }
            }
            else if (menu.ActiveApplicationMenu == (int)Menu.ApplicationMenus.HeroMenu)
            {

            }
            else if (menu.ActiveApplicationMenu == (int)Menu.ApplicationMenus.CombatLog)
            {

            }
        }

        private void PrintMenuContent()
        {

        }

        private void MenuNaviagtion()
        {

        }
    }
}
