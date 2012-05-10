using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace LasVega.Entity
{
    public class Character
    {
        public string NickName { get; set; }
        public ReadOnlyCollection<Card> CurrentDeck { get; set; }
    }
}
