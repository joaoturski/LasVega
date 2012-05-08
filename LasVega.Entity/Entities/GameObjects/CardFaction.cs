﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LasVega.Entity
{
    public class CardFaction
    {
        public uint IdCardFaction { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IList<FactionRelationship> Relationships { get; set; }
    }
}