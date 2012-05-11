using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LasVega.Entity.Collections
{
    /// <summary>
    /// Collection que representa um Deck
    /// </summary>
    public class Deck : ReadOnlyCollection<Card>
    {
        private List<string> _errorMessages;

        public Deck(IList<Card> cards) : base(cards)
        {
            _errorMessages = new List<string>();

            if (!ValidateDeck())
                throw new InvalidOperationException(string.Join(" ", _errorMessages));
        }

        private bool ValidateDeck()
        {
            var result = true;

            if (!this.Any(x => x.CardType == CardTypeEnum.General))
            {
                result = false;
                _errorMessages.Add("O Deck deve possuir 1 carta General.");
            }

            if (this.Where(x => x.CardType == CardTypeEnum.Soldier).Count() < 3)
            {
                result = false;
                _errorMessages.Add("O Deck deve possuir, no mínimo,  3 cartas soldados.");
            }

            return result;
        }

        public virtual IList<Card> GetRandomizedCardsToBattle()
        {
            var result = new List<Card>();

            //apenas 1 general por deck
            result.Add(this.First(x => x.CardType == CardTypeEnum.General));

            //TODO: POR ENQUANTO É FIXO SEMPRE 3 SOLDADOS
            for (var x = 0; x < 3; x++)
            {
                result.Add(RandomizeSoldierCard(result));
            }

            //TODO: NÃO FOI DEFINIDO QUANTAS CARTAS DE APOIO POR PARTIDA

            return result;
        }

        private Card RandomizeSoldierCard(IEnumerable<Card> existing)
        {
            var rndList = this.Where(x => x.CardType == CardTypeEnum.Soldier).Except(existing).ToArray();
            var rndIdx = new Random(DateTime.Now.Millisecond).Next(0, rndList.Count() - 1);
            return rndList[rndIdx];
        }

        
    }
}
