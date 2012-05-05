using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LasVega.Entity
{
    public class Skill
    {
        /// <summary>
        /// Identificador único dessa skill no banco de dados.
        /// Sobreescrever na classe derivada, para representar a skill com os valores randomicos unicos 
        /// atribuídos à ela.
        /// </summary>
        protected virtual uint IdSkill { get; set; }

        /// <summary>
        /// Identificador da família da skill, pois alguns debuffs podem influenciar um tipo de skill, pouco importando 
        /// os valores dos atributos gerados.
        /// </summary>
        public uint IdSkillBase { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsOffensive { get; set; }

    }
}
