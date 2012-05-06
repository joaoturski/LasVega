using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LasVega.Entity
{
    public class BuffSkill : Skill
    {
        public BuffSkillType BuffType { get; private set; }
        
        /// <summary>
        /// Numero de turnos no qual o Buff estará ativo.
        /// 0 = Até o fim da partida
        /// </summary>
        public uint Duration { get; private set; }

        public uint MaximiumStacks { get; private set; }
    }
}
