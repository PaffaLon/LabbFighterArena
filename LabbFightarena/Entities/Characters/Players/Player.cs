using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Entities.Characters.Players
{
    sealed class Player : Character
    {
        public Player()
        {
            if (DefaultValuesSet == false)
                SetDefaultValues();
        }
        //Constructor Helper Methods
        /// <summary>
        /// Sets all the default values of a new player or object.
        /// </summary>
        private void SetDefaultValues()
        {
            DefaultValuesSet = true;
        }
        //Class Methods
        public void Resurect()
        {

        }
        public void HealthToPlayer()
        {

        }
        
        /// <summary>
        /// The player loses health points in combat or by a passive ability, attribute.
        /// </summary>
        public void DamageToPlayer()
        {

        }
        public void Attack()
        {

        }
        /// <summary>
        /// Intrease the players curent mana.
        /// </summary>
        public void ManaToPlayer()
        {

        }
        public void ManaMaxIncrement()
        {

        }
        public void ManaMinDecrement()
        {

        }
        

        public void CreateNewPlayer()
        {
            void NewPlayerName(string firstName, string lastName, string surName)
            {

            }
            void NewPlayerID()
            {
                void GenerateNewPlayerID()
                {

                }
            }
            
        }
    }
}
