using System;
using LabbFightarena.Menu;
using LabbFightarena.Combat;

namespace LabbFightarena
{
    public class Program
    {
        static void Main()
        {
            MenuManager menuManager = new MenuManager();
            menuManager.LoadMenu();
        }
    }
}
