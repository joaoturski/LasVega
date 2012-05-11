using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LasVega.Entity.Collections
{
    public class PassiveSkillCollection : ReadOnlyCollection<PassiveSkill>
    {
        public PassiveSkillCollection(IList<PassiveSkill> skills)
            : base(skills)
        {

        }
    }
}
