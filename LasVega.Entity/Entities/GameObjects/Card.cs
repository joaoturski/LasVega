using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using LasVega.Entity.Collections;

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
        public ushort OriginalActionPoints { get; private set; }
        public short CurrentActionPoints { get; private set; }

        public ActiveSkillCollection ActiveSkills { get; private set; }
        public PassiveSkillCollection PassiveSkills { get; private set; }
        public BuffSkillCollection Buffs { get; private set; }
        public BuffSkillCollection Debuffs { get; private set; }
    }
}
