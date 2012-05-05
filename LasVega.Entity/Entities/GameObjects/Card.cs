using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LasVega.Entity
{
    public class Card
    {
        public uint IdCard { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime CreationDate { get; private set; }
        public DateTime AcquisitionDate { get; private set; }
        public ushort OriginalAttackPoints { get; private set; }
        public short CurrentAttackPoints { get; private set; }

        // TODO: CRIAR UMA COLLECTION PROPRIA, PARA EVITAR PROBLEMAS FUTUROS DE
        // DESVIRTUAÇÃO DE RESPONSABILIDADES, POR PARTE DE FUTUROS NOVOS PROGRAMADORES DESAVISADOS...
        public IList<ActiveSkill> ActiveSkills { get; private set; }
        public IList<PassiveSkill> PassiveSkills { get; private set; }
        public IList<BuffSkill> Buffs { get; private set; }
        public IList<DebuffSkill> Debuffs { get; private set; }

    }
}
