using System;
using System.Collections.Generic;
using System.Text;
using LabbFightarena.Characters.Players;
using LabbFightarena.Characters.Monsters;

namespace LabbFightarena.Combat
{
    /// <summary>
    /// Contains all code for combat between the player and a monst character.
    /// </summary>
    public class Combat
    {
        object objPpayer = new object();
        Player player = new Player();
        Monster monster = new Monster();

        bool _battlePhase;

        

        private void Turn()
        {
            _battlePhase = true;
            while (_battlePhase == true)
            {
                DamageMonster();
                //Update UI
                DamagePlayer();
                //Update UI
                CheckMosterHealth();
                CheckPlayerHealth();
            }
        }

        /// <summary>
        /// This method check if the player is alive or not.
        /// </summary>
        private void CheckPlayerHealth()
        {
            player.HealthCheck(player.Health);
        }

        /// <summary>
        /// Checks if the monster is alive or not.
        /// </summary>
        private void CheckMosterHealth()
        {
            monster.HealthCheck(monster.Health);
        }

        private void DamagePlayer()
        {
            player.DamagePlayer(monster.Strength, player.Health);
        }

        private void DamageMonster()
        {
            monster.DamageMonster(player.Strength, monster.Health);
        }

        /// <summary>
        /// Writes the ongoing combat to the console.
        /// </summary>
        private void PrintCombat()
        {

        }

        private void SaveLastTurnToCombatLog()
        {

        }
    }
}

