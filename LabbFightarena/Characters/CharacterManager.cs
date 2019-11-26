using System;
using System.Collections.Generic;
using System.Text;
using LabbFightarena.Characters.Players;
using LabbFightarena.Characters.Monsters;

namespace LabbFightarena.Characters
{
    //Managers the creation & usage of characters.
    public class CharacterManager
    {
        static public List<Player> Players { get; set; }
        static public List<Monster> Monsters { get; set; } 

        public CharacterManager()
        {
            Players = new List<Player>();
            Monsters = new List<Monster>();
        }

#region Player

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void GetPlayer()
        {
            
        }

        public void DeletePlayer()
        {

        }

        #endregion Player
#region Monster
        public void AddMonster(Monster monster)
        {
            Monsters.Add(monster);
        }

        public void GetMonster()
        {

        }

        public void DeleteMonster()
        {

        }

#endregion Monster
    }
}
