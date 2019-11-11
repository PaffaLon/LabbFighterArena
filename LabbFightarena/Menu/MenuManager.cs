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

        public enum ApplicationMenus
        {
            MainMenu,
            HeroMenu,
            CombatLog
        }
        public int ActiveApplicationMenu { get; set; }


        //Ensuers the defalut value is set to the intended value.
        public void DefaultValues()
        {
            ActiveApplicationMenu = (int)Menu.ApplicationMenus.MainMenu;
            mainMenu. = (int)MainMenu.Buttons.Play;
        }

        //Loads the active menu for the user.
        public void LoadMenu()
        {
            if (Console.CursorVisible == true)
                Console.CursorVisible = false;
            
            if(menu.Elements != null)
                menu.Elements.Clear();

            if (menu.ActiveApplicationMenu == (int)Menu.ApplicationMenus.MainMenu)
            {
                if (menu.Button == (int)MainMenu.Buttons.Play)
                {
                    mainMenu.Content(menu.Button);
                    foreach (var item in mainMenu.getMenuItems)
                        menu.Elements.Add(item);
                }
                else if (menu.Button == (int)MainMenu.Buttons.ScoreBoard)
                {
                    mainMenu.Content(menu.Button);
                    foreach (var item in mainMenu.getMenuItems)
                        menu.Elements.Add(item);
                }
                else if (menu.Button == (int)MainMenu.Buttons.CombatLog)
                {
                    mainMenu.Content(menu.Button);
                    foreach (var item in mainMenu.getMenuItems)
                        menu.Elements.Add(item);
                }
                else if (menu.Button == (int)MainMenu.Buttons.Exit)
                {
                    mainMenu.Content(menu.Button);
                    foreach (var item in mainMenu.getMenuItems)
                        menu.Elements.Add(item);
                }
            }
            else if (menu.ActiveApplicationMenu == (int)Menu.ApplicationMenus.HeroMenu)
            {
                if (menu.Button == (int)HeroMenu.Buttons.NewHero)
                {
                    heroMenu.Content(menu.Button);
                    foreach (var item in heroMenu.getMenuItems)
                        menu.Elements.Add(item);
                }
                else if (menu.Button == (int)HeroMenu.Buttons.LoadHero)
                {
                    heroMenu.Content(menu.Button);
                    foreach (var item in heroMenu.getMenuItems)
                        menu.Elements.Add(item);
                }
                else if (menu.Button == (int)HeroMenu.Buttons.Exit)
                {
                    heroMenu.Content(menu.Button);
                    foreach (var item in heroMenu.getMenuItems)
                        menu.Elements.Add(item);
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
                        menu.Button -= 1;
                        if (menu.Button < 0)
                            menu.Button = 0;
                    }
                    else if (cki.Key.GetHashCode() == 40)
                    {
                        menu.Button += 1;
                        if (menu.Button > 2)
                            menu.Button = 2;
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.Button == (int)HeroMenu.Buttons.NewHero)
                    {
                        Console.Clear();
                        Console.WriteLine("You can soon generate a new hero.");
                        Thread.Sleep(1000);
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.Button == (int)HeroMenu.Buttons.LoadHero)
                    {
                        Console.Clear();
                        Console.WriteLine("The feature: Load hero, has not been implemented.");
                        Thread.Sleep(2500);
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.Button == (int)HeroMenu.Buttons.Exit)
                    {
                        menu.ActiveApplicationMenu = (int)Menu.ApplicationMenus.MainMenu;
                        menu.Button = (int)MainMenu.Buttons.Play;

                    }break;
                default:
                    if (cki.Key.GetHashCode() == 38)
                    {
                        menu.Button -= 1;
                            if(menu.Button < 0)
                                menu.Button = 0;
                    }
                    else if (cki.Key.GetHashCode() == 40)
                    {
                        menu.Button += 1;
                        if (menu.Button > 3)
                            menu.Button = 3;
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.Button == (int)MainMenu.Buttons.Play)
                    {
                        menu.ActiveApplicationMenu = (int)Menu.ApplicationMenus.HeroMenu;
                        menu.Button = (int)HeroMenu.Buttons.NewHero;
                        LoadMenu();
                        
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.Button == (int)MainMenu.Buttons.ScoreBoard)
                    {
                        Console.Clear();
                        Console.WriteLine("The Scoreboard has not jet been implemented.");
                        Thread.Sleep(1000);
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.Button == (int)MainMenu.Buttons.CombatLog)
                    {
                        Console.Clear();
                        Console.WriteLine("The View last combat log has not jet been implemnted.");
                        Thread.Sleep(1000);
                    }
                    else if (cki.Key.GetHashCode() == 13 && menu.Button == (int)MainMenu.Buttons.Exit)
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
            foreach (var item in menu.Elements)
            {
                Console.SetCursorPosition((Console.WindowWidth - item.Length) / 2, Console.CursorTop);
                Console.WriteLine(item + Environment.NewLine);
            }
        }
    }
}
