using System;
using LabbFightarena.Menu;
using LabbFightarena.Combat;

namespace LabbFightarena
{
    public class Program
    {
        static void Main()
        {
            Console.SetWindowSize(120, 35);
            CombatWindow combatWindow = new CombatWindow();
            combatWindow.CombatMenu();
            Console.ReadKey();
            /*

            MenuManager menuManager = new MenuManager();
            menuManager.LoadMenu();
            */
        }
    }
}
