using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LasVega.Entity
{
    public class ActiveSkill : Skill
    {
        /// <summary>
        /// Quantidade de turnos que esta skill irá perdurar no target
        /// </summary>
        public uint TargetDuration { get; set; }

        /// <summary>
        /// Quantidade de turnos que esta skill ficará inativa, após sua utilização
        /// </summary>
        public uint CoolDown { get; set; }
    }
}
