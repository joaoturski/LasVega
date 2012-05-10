using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace LasVega.Entity
{
    public class Card
    {
        public uint IdCard { get; private set; }
        public CardFaction Faction { get; private set; }
        public CardTypeEnum CardType { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime CreationDate { get; private set; }
        public DateTime AcquisitionDate { get; private set; }
        public ushort OriginalAttackPoints { get; private set; }
        public short CurrentAttackPoints { get; private set; }

        public ReadOnlyCollection<ActiveSkill> ActiveSkills { get; private set; }
        public ReadOnlyCollection<PassiveSkill> PassiveSkills { get; private set; }
        public ReadOnlyCollection<BuffSkill> Buffs { get; private set; }
        public ReadOnlyCollection<BuffSkill> Debuffs { get; private set; }
    }
}
