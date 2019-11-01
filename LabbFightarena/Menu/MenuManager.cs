using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
            Console.Clear();
            if (Console.CursorVisible == true)
                Console.CursorVisible = false;

            if (menu.ActiveApplicationMenu == (int)Menu.ApplicationMenus.MainMenu)
            {
                if (menu.MenuButton == (int)Menu.MainMenu.Play)
                {
                    mainMenu.Content(menu.MenuButton, out menu.menuContent);
                    PrintMenuContent();
                    MenuNaviagtion();
                }
                else if (menu.MenuButton == (int)Menu.MainMenu.ScoreBoard)
                {
                    mainMenu.Content(menu.MenuButton, out menu.menuContent);
                    PrintMenuContent();
                    MenuNaviagtion();
                }
                else if (menu.MenuButton == (int)Menu.MainMenu.CombatLog)
                {
                    mainMenu.Content(menu.MenuButton, out menu.menuContent);
                    PrintMenuContent();
                    MenuNaviagtion();
                }
                else if (menu.MenuButton == (int)Menu.MainMenu.Exit)
                {
                    mainMenu.Content(menu.MenuButton, out menu.menuContent);
                    PrintMenuContent();
                    MenuNaviagtion();
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
            switch (menu.ActiveApplicationMenu)
            {
                case (int)Menu.ApplicationMenus.HeroMenu:
                    break;
                case (int)Menu.ApplicationMenus.CombatLog:
                    break;
                default:
                    foreach (var item in menu.menuContent)
                    {
                        Console.SetCursorPosition((Console.WindowWidth - item.Length) / 2, Console.CursorTop);
                        Console.WriteLine(item + Environment.NewLine);
                    }
                    break;
            }
        }

        private void MenuNaviagtion()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();

            switch (menu.ActiveApplicationMenu)
            {
                case (int)Menu.ApplicationMenus.CombatLog:
                    break;

                case (int)Menu.ApplicationMenus.HeroMenu:
                    break;

                default:
                    if (cki.Key.GetHashCode() == 38)
                    {
                        menu.MenuButton -= 1;
                            if(menu.MenuButton < 0)
                                menu.MenuButton = 1;
                    }
                    else if (cki.Key.GetHashCode() == 40)
                    {
                        menu.MenuButton += 1;
                        if (menu.MenuButton > 4)
                            menu.MenuButton = 4;
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.MenuButton == (int)Menu.MainMenu.Play)
                    {
                        Console.Clear();
                        Console.WriteLine("The play menu has not jet been implemented.");
                        Thread.Sleep(1000);
                        
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.MenuButton == (int)Menu.MainMenu.ScoreBoard)
                    {
                        Console.Clear();
                        Console.WriteLine("The Scoreboard has not jet been implemented.");
                        Thread.Sleep(1000);
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.MenuButton == (int)Menu.MainMenu.CombatLog)
                    {
                        Console.Clear();
                        Console.WriteLine("The View last combat log has not jet been implemnted.");
                        Thread.Sleep(1000);
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.MenuButton == (int)Menu.MainMenu.Exit)
                    {
                        Environment.Exit(0);
                    }
                    break;
            }
                    LoadMenu();
        }
    }
}
