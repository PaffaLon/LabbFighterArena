using System;
using LabbFightarena.Menu;

namespace LabbFightarena
{
    public class Program
    {
        static void Main()
        {
            MenuManager menuManager = new MenuManager();
            menuManager.DefaultValues();
            menuManager.LoadMenu();
        }
    }
}
