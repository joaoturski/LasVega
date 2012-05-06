using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LasVega.Entity
{
    public class FactionRelationship
    {
        public CardFaction Attacker { get; set; }
        public CardFaction Target { get; set; }

        /// <summary>
        /// Incremento sempre pro attacker
        /// </summary>
        public ushort AttackPointsIncreased { get; set; }
    }
}
