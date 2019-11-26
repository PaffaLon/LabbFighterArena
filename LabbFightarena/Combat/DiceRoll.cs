using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LabbFightarena.Combat
{
    public class DiceRoll
    {
        public void RollTheDice()
        {
            var diceRoll = new Random();
            int playerRoll = diceRoll.Next(1, 7);
            int monsterRoll = diceRoll.Next(1, 7);

            Debug.Print($"Player roll: {playerRoll.ToString()}");
            Debug.Print($"Monster roll: {monsterRoll.ToString()}");
        }
    }
}
