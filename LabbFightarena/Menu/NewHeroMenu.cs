using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Menu
{
    public class NewHeroMenu
    {
        enum Buttons
        {
            SetName,
            Play,
            Exit
        }

        public void Content()
        {

            void Buttons()
            {
                string[] unselcetdMenuItems = new string[0];
                string[] selectedMenuItems = new string[0];

                selectedMenuItems[0] = ("Name :");
                selectedMenuItems[1] = ("Play");
                selectedMenuItems[2] = ("Exit");

            }

            void Content()
            {
                string[] playerDetails = new string[4];
                playerDetails[0] = ("Damage");
                playerDetails[1] = ("Strength");
                playerDetails[2] = ("Dexterity");
                playerDetails[3] = ("Intelligence");

            }
        }
    }
}
