using System.Collections.ObjectModel;

namespace LasVega.Entity
{
    public class CardFaction
    {
        public uint IdCardFaction { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public ReadOnlyCollection<FactionRelationship> Relationships { get; private set; }
    }
}
