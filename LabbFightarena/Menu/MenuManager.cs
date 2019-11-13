using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LabbFightarena.Menu
{
    class MenuManager
    {
        readonly MainMenu mainMenu = new MainMenu();
        readonly HeroMenu heroMenu = new HeroMenu();
        readonly NewHeroMenu newHeroMenu = new NewHeroMenu();

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
            ActiveApplicationMenu = (int)ApplicationMenus.MainMenu;
            mainMenu.Button = (int)MainMenu.Buttons.Play;
        }

        //Loads the active menu for the user.
        public void LoadMenu()
        {
            ClearMenuElements();

            if (ActiveApplicationMenu == (int)ApplicationMenus.MainMenu)
            {
                    mainMenu.Content(mainMenu.Button);
                    foreach (var item in mainMenu.getMenuItems)
                       mainMenu.Elements.Add(item);   
            }
            else if (ActiveApplicationMenu == (int)ApplicationMenus.HeroMenu)
            {
                    heroMenu.Content(heroMenu.Button);
                    foreach (var item in heroMenu.getMenuItems)
                        heroMenu.Elements.Add(item);
            }
            else if (ActiveApplicationMenu == (int)ApplicationMenus.CombatLog)
            {
                
            }
            PrintMenuContent();
            MenuNaviagtion();
        }

        //Prints the active menu for the user.
        private void PrintMenuContent()
        {
            Console.Clear();
            switch (ActiveApplicationMenu)
            {
                case (int)ApplicationMenus.HeroMenu:
                    CenterText();
                    break;
                case (int)ApplicationMenus.CombatLog:
                        //TO DO
                        // Print the combat log of the last player battle.
                        // A menu option to return to the main menu.
                    break;
                default:
                    CenterText();
                    break;
            }
        }

        /// <summary>
        /// Makes it possible for the user to navigate in the menu,
        /// ith pressing the arrow buttons on the keyboard.
        /// The user can press enter to navigate access another part of the program.
        /// </summary>
        private void MenuNaviagtion()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();

            if(ActiveApplicationMenu == (int)ApplicationMenus.MainMenu)
            {
                if (cki.Key.GetHashCode() == 38)
                {
                    mainMenu.Button -= 1;
                    if (mainMenu.Button < 0)
                        mainMenu.Button = 0;
                }
                else if (cki.Key.GetHashCode() == 40)
                {
                    mainMenu.Button += 1;
                    if (mainMenu.Button > 3)
                        mainMenu.Button = 3;
                }
                else if (cki.Key.GetHashCode() == 13 && mainMenu.Button == (int)MainMenu.Buttons.Play)
                {
                    ActiveApplicationMenu = (int)ApplicationMenus.HeroMenu;
                    mainMenu.Button = (int)HeroMenu.Buttons.NewHero;
                    LoadMenu();

                }
                else if (cki.Key.GetHashCode() == 13 && mainMenu.Button == (int)MainMenu.Buttons.ScoreBoard)
                {
                    Console.Clear();
                    Console.WriteLine("The Scoreboard has not jet been implemented.");
                    Thread.Sleep(1000);
                }
                else if (cki.Key.GetHashCode() == 13 && mainMenu.Button == (int)MainMenu.Buttons.CombatLog)
                {
                    Console.Clear();
                    Console.WriteLine("The View last combat log has not jet been implemnted.");
                    Thread.Sleep(1000);
                }
                else if (cki.Key.GetHashCode() == 13 && mainMenu.Button == (int)MainMenu.Buttons.Exit)
                {
                    Environment.Exit(0);
                }
            }
            if (ActiveApplicationMenu == (int)ApplicationMenus.HeroMenu)
            {
                if (cki.Key.GetHashCode() == 38)
                {
                    heroMenu.Button -= 1;
                    if (heroMenu.Button < 0)
                        heroMenu.Button = 0;
                }
                else if (cki.Key.GetHashCode() == 40)
                {
                    heroMenu.Button += 1;
                    if (heroMenu.Button > 2)
                        heroMenu.Button = 2;
                }
                else if (cki.Key.GetHashCode() == 13 && heroMenu.Button == (int)HeroMenu.Buttons.NewHero)
                {
                    Console.Clear();
                    Console.WriteLine("You can soon generate a new hero.");
                    Thread.Sleep(1000);
                }
                else if (cki.Key.GetHashCode() == 13 && heroMenu.Button == (int)HeroMenu.Buttons.LoadHero)
                {
                    Console.Clear();
                    Console.WriteLine("The feature: Load hero, has not been implemented.");
                    Thread.Sleep(2500);
                }
                else if (cki.Key.GetHashCode() == 13 && heroMenu.Button == (int)HeroMenu.Buttons.Exit)
                {
                    ActiveApplicationMenu = (int)ApplicationMenus.MainMenu;
                    mainMenu.Button = (int)MainMenu.Buttons.Play;

                }
            }
            if (ActiveApplicationMenu == (int)ApplicationMenus.CombatLog)
            {
                
            }
            LoadMenu();
        }

        //Centers the text to print in the center of the console window.
        private void CenterText()
        {
            int col = Console.WindowHeight / Console.WindowHeight + 1;
            switch (ActiveApplicationMenu)
            {
                case (int)ApplicationMenus.HeroMenu:
                    foreach (var item in heroMenu.Elements)
                    {
                        Console.SetCursorPosition((Console.WindowWidth - item.Length) / 2, Console.WindowHeight / 2 - 6 + col++);
                        Console.WriteLine(item + Environment.NewLine);
                    }
                    break;
                default:
                    foreach (var item in mainMenu.Elements)
                    {
                        Console.SetCursorPosition((Console.WindowWidth - item.Length) / 2, Console.WindowHeight / 2 - 6 + col++);
                        Console.Write(item + Environment.NewLine);
                    }
                    break;
            }
        }
    
        //Empties the list that contains the order the menu items has to be printed.
        private void ClearMenuElements()
        {
            if (Console.CursorVisible == true)
                Console.CursorVisible = false;

            if (mainMenu.Elements != null)
                mainMenu.Elements.Clear();

            if (heroMenu.Elements != null)
                heroMenu.Elements.Clear();
        }
    }
}
