using System;
using LabbFightarena.Menu;

namespace LabbFightarena
{
    class Program
    {
        static void Main()
        {
            MenuManager menuManager = new MenuManager();
            menuManager.DefaultValues();
            menuManager.LoadMenu();
        }
    }
}
