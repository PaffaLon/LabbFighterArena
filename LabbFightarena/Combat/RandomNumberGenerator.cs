﻿using System;
using System.Collections.Generic;
using System.Text;
using LabbFightarena.Characters.Player;
using LabbFightarena.Characters.NPC.Monsters;

namespace LabbFightarena.Combat
{
    class RandomNumberGenerator
    {
        Monster monster = new Monster();
        Player Player = new Player();
        Random rng = new Random();
        

        public void PlayerStrength()
        {
            Player.Strength = rng.Next(0, 33);
        }
        public void MonsterStrength()
        {
            monster.Strength = rng.Next(0, 33);
        }
    }
}