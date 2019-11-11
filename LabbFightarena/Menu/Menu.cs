using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Menu
{
    public class Menu
    {
        //Public Properies
        public List<string> Elements { get; set; }
        public int Button { get; set; }

        public Menu()
        {
            Elements = new List<string>();
        }

    }
}