﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace LasVega.Entity.Collections
{
    public class ActiveSkillCollection : ReadOnlyCollection<ActiveSkill>
    {
        public ActiveSkillCollection(IList<ActiveSkill> skills)
            : base(skills)
        {

        }
    }
}
