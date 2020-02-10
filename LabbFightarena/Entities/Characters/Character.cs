using System;
using System.Collections.Generic;
using System.Text;

namespace LabbFightarena.Entities.Characters
{
    abstract class Character : Entity
    {
        public Int64 ID { get; set; }
        protected bool IsAlive { get; set; }
        protected bool DefaultValuesSet { get; set; }
        protected string Name { get; set; }

        //Active Attributes
#region Character Health Attributes
        /// <summary>
        /// The characters health pool.
        /// </summary>
        protected double Health { get; set; }
        /// <summary>
        /// The maximum amount of health a characters health pool can contain.
        /// </summary>
        protected double HealthMax { get; set; }
        /// <summary>
        /// The minimum amount of health a caracters health pool can contain.
        /// Is also used for checking if the player is alaive or not.
        /// </summary>
        protected double HealthMin { get; } = (0.01);
        /// <summary>
        /// The amount of health points a character regenerats at a given time.
        /// </summary>
        protected double HealthReg { get; set; }
        /// <summary>
        /// A set intervall for the health to regernerate.
        /// </summary>
        protected TimeSpan HealthRegInterval { get; set; }
        #endregion

#region Character Mana Attributes
        /// <summary>
        /// The characters mana pool
        /// </summary>
        protected double Mana { get; set; }
        /// <summary>
        /// The maximum amount of mana a characters mana pool can contain.
        /// </summary>
        protected double ManaMax { get; set; }
        /// <summary>
        /// The minimum amount of mana a characters mana pool can contain.
        /// </summary>
        protected double ManaMin { get; } = (0.01);
        protected double ManaReg { get; set; }
        protected TimeSpan ManaRegInterval { get; set; }
#endregion

        //Passive Attributes
        protected int Strength { get; set; }
        protected int Dexterity { get; set; }
        protected int Wisdome { get; set; }

    }
}
