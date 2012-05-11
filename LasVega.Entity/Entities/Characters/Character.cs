using LasVega.Entity.Collections;

namespace LasVega.Entity
{
    public class Character
    {
        public uint IdCharacter { get; set; }
        public string NickName { get; set; }
        
        public virtual Deck CurrentDeck { get; set; }
    }
}
