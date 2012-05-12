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
        public uint IdCard { get; set; }
        public CardFaction Faction { get; set; }
        public CardTypeEnum CardType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public ushort OriginalActionPoints { get; set; }
        public short CurrentActionPoints { get; set; }

        public ActiveSkillCollection ActiveSkills { get; private set; }
        public PassiveSkillCollection PassiveSkills { get; private set; }
        public BuffSkillCollection Buffs { get; private set; }
        public BuffSkillCollection Debuffs { get; private set; }
    }
}
