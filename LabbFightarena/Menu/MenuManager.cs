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
        readonly HeroMenu heroMenu = new HeroMenu();

        //Ensuers the defalut value is set to the intended value.
        public void DefaultValues()
        {
            menu.ActiveApplicationMenu = (int)Menu.ApplicationMenus.MainMenu;
            menu.MenuButton = (int)MainMenu.Buttons.Play;
        }

        //Loads the active menu for the user.
        public void LoadMenu()
        {
            if (Console.CursorVisible == true)
                Console.CursorVisible = false;
            
            if(menu.menuElements != null)
                menu.menuElements.Clear();

            if (menu.ActiveApplicationMenu == (int)Menu.ApplicationMenus.MainMenu)
            {
                if (menu.MenuButton == (int)MainMenu.Buttons.Play)
                {
                    mainMenu.Content(menu.MenuButton);
                    foreach (var item in mainMenu.getMenuItems)
                        menu.menuElements.Add(item);
                }
                else if (menu.MenuButton == (int)MainMenu.Buttons.ScoreBoard)
                {
                    mainMenu.Content(menu.MenuButton);
                    foreach (var item in mainMenu.getMenuItems)
                        menu.menuElements.Add(item);
                }
                else if (menu.MenuButton == (int)MainMenu.Buttons.CombatLog)
                {
                    mainMenu.Content(menu.MenuButton);
                    foreach (var item in mainMenu.getMenuItems)
                        menu.menuElements.Add(item);
                }
                else if (menu.MenuButton == (int)MainMenu.Buttons.Exit)
                {
                    mainMenu.Content(menu.MenuButton);
                    foreach (var item in mainMenu.getMenuItems)
                        menu.menuElements.Add(item);
                }
            }
            else if (menu.ActiveApplicationMenu == (int)Menu.ApplicationMenus.HeroMenu)
            {
                if (menu.MenuButton == (int)HeroMenu.Buttons.NewHero)
                {
                    heroMenu.Content(menu.MenuButton);
                    foreach (var item in heroMenu.getMenuItems)
                        menu.menuElements.Add(item);
                }
                else if (menu.MenuButton == (int)HeroMenu.Buttons.LoadHero)
                {
                    heroMenu.Content(menu.MenuButton);
                    foreach (var item in heroMenu.getMenuItems)
                        menu.menuElements.Add(item);
                }
                else if (menu.MenuButton == (int)HeroMenu.Buttons.Exit)
                {
                    heroMenu.Content(menu.MenuButton);
                    foreach (var item in heroMenu.getMenuItems)
                        menu.menuElements.Add(item);
                }
            }
            else if (menu.ActiveApplicationMenu == (int)Menu.ApplicationMenus.CombatLog)
            {

            }
            PrintMenuContent();
            MenuNaviagtion();
        }

        //Prints the active menu for the user.
        private void PrintMenuContent()
        {
            Console.Clear();
            switch (menu.ActiveApplicationMenu)
            {
                case (int)Menu.ApplicationMenus.HeroMenu:
                    CenterText();
                    break;
                case (int)Menu.ApplicationMenus.CombatLog:
                        //TO DO
                        // Print the combat log of the last player battle.
                        // A menu option to return to the main menu.
                    break;
                default:
                    CenterText();
                    break;
            }
        }

        //Makes it possible to navigate in the menu for the user.
        //Sets the values for loading a sub menu of user choise in the current active menu.
        private void MenuNaviagtion()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();

            switch (menu.ActiveApplicationMenu)
            {
                case (int)Menu.ApplicationMenus.CombatLog:
                    break;

                case (int)Menu.ApplicationMenus.HeroMenu:
                    if (cki.Key.GetHashCode() == 38)
                    {
                        menu.MenuButton -= 1;
                        if (menu.MenuButton < 0)
                            menu.MenuButton = 0;
                    }
                    else if (cki.Key.GetHashCode() == 40)
                    {
                        menu.MenuButton += 1;
                        if (menu.MenuButton > 2)
                            menu.MenuButton = 2;
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.MenuButton == (int)HeroMenu.Buttons.NewHero)
                    {
                        Console.Clear();
                        Console.WriteLine("You can soon generate a new hero.");
                        Thread.Sleep(1000);
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.MenuButton == (int)HeroMenu.Buttons.LoadHero)
                    {
                        Console.Clear();
                        Console.WriteLine("The feature: Load hero, has not been implemented.");
                        Thread.Sleep(2500);
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.MenuButton == (int)HeroMenu.Buttons.Exit)
                    {
                        menu.ActiveApplicationMenu = (int)Menu.ApplicationMenus.MainMenu;
                        menu.MenuButton = (int)MainMenu.Buttons.Play;

                    }break;
                default:
                    if (cki.Key.GetHashCode() == 38)
                    {
                        menu.MenuButton -= 1;
                            if(menu.MenuButton < 0)
                                menu.MenuButton = 0;
                    }
                    else if (cki.Key.GetHashCode() == 40)
                    {
                        menu.MenuButton += 1;
                        if (menu.MenuButton > 3)
                            menu.MenuButton = 3;
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.MenuButton == (int)MainMenu.Buttons.Play)
                    {
                        menu.ActiveApplicationMenu = (int)Menu.ApplicationMenus.HeroMenu;
                        menu.MenuButton = (int)HeroMenu.Buttons.NewHero;
                        LoadMenu();
                        
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.MenuButton == (int)MainMenu.Buttons.ScoreBoard)
                    {
                        Console.Clear();
                        Console.WriteLine("The Scoreboard has not jet been implemented.");
                        Thread.Sleep(1000);
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.MenuButton == (int)MainMenu.Buttons.CombatLog)
                    {
                        Console.Clear();
                        Console.WriteLine("The View last combat log has not jet been implemnted.");
                        Thread.Sleep(1000);
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.MenuButton == (int)MainMenu.Buttons.Exit)
                    {
                        Environment.Exit(0);
                    }
                    break;
            }        
            LoadMenu();
        }

        //Prints menu text in the center of the screen.
        private void CenterText()
        {
            foreach (var item in menu.menuElements)
            {
                Console.SetCursorPosition((Console.WindowWidth - item.Length) / 2, Console.CursorTop);
                Console.WriteLine(item + Environment.NewLine);
            }
        }
    }
}
