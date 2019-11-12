using System;
using System.Collections.Generic;
using System.Text;
using LabbFightarena.Characters.Player;
using LabbFightarena.Characters.Monsters;

namespace LabbFightarena.Combat
{
    public class Combat
    {
        object objPpayer = new object();
        Player player = new Player();
        Monster monster = new Monster();
        

        

        private void Turn()
        {
            for (player.Health || monster.Health < 0)
            {

            }

            for (int i = 0; i < length; i++)
            {

            }
        }

        private void DamagePlayer()
        {
            player.DamagePlayer(monster.Strength, player.Health);

            
        }

        private void DamageMonster()
        {
            monster.DamageMonster(player.Strength, monster.Health);
        }

        private void PrintCombat()
        {

        }
    }
}

