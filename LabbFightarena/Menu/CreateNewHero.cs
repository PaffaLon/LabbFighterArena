using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Menu
{
    public class CreateNewHero : Menu
    {
        public enum Buttons
        {
            SetName,
            Play,
            Exit
        }

        public string[] getMenuItems = new string[3];
        public string[] GetElelmets = new string[4];
        public void Content()
        {
            Buttons();
            Content();

            void Buttons()
            {
                string[] unselcetdMenuItems = new string[3];
                string[] selectedMenuItems = new string[3];

                unselcetdMenuItems[0] = ("Name :");
                unselcetdMenuItems[1] = ("Play");
                unselcetdMenuItems[2] = ("Exit");

                selectedMenuItems[0] = (">> Name :");
                selectedMenuItems[1] = (">> Play <<");
                selectedMenuItems[2] = (">> Exit <<");

            }

            void Content()
            {
                string[] playerDetails = new string[4];
                playerDetails[0] = ("Damage:       ");
                playerDetails[1] = ("Strength:     ");
                playerDetails[2] = ("Dexterity:    ");
                playerDetails[3] = ("Intelligence: ");

            }
        }
    }
}
