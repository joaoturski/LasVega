using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LasVega.Entity.Collections;

namespace LasVega.Entity.Test.Collections
{
    [TestClass]
    public class DeckTest
    {
        private IList<Card> GenerateCards()
        {
            return new List<Card> 
            { 
                new Card { CardType = CardTypeEnum.Soldier, IdCard = 1 },
                new Card { CardType = CardTypeEnum.Soldier, IdCard = 2 },
                new Card { CardType = CardTypeEnum.Soldier, IdCard = 3 },
                new Card { CardType = CardTypeEnum.General, IdCard = 4 },
                new Card { CardType = CardTypeEnum.Equipament, IdCard = 5 },
                new Card { CardType = CardTypeEnum.Soldier, IdCard = 6 },
                new Card { CardType = CardTypeEnum.Soldier, IdCard = 7 },
                new Card { CardType = CardTypeEnum.Soldier, IdCard = 8 },
            };
        }

        [TestMethod]
        public void CreationDeck()
        {
            var result = false;
            try
            {
                new Deck(GenerateCards());
                result = true;
                
            }
            catch (InvalidOperationException)
            {
                result = false;
            }

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CreationDeckWithoutGeneral()
        {
            var result = false;
            try
            {
                new Deck(GenerateCards().Where(x => x.CardType != CardTypeEnum.General).ToList());
                result = true;

            }
            catch (InvalidOperationException)
            {
                result = false;
            }

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CreationDeckWithoutMinimiunSoldiers()
        {
            var result = false;
            try
            {
                new Deck(GenerateCards().Where(x => x.CardType != CardTypeEnum.Soldier).ToList());
                result = true;

            }
            catch (InvalidOperationException)
            {
                result = false;
            }

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetCardsForBattle()
        {
            var result = false;
            try
            {
                var dec = new Deck(GenerateCards());
                var cards = dec.GetRandomizedCardsToBattle();

                if (cards.Any(x => x.CardType == CardTypeEnum.General))
                {
                    var soldiers = cards.Where(x => x.CardType == CardTypeEnum.Soldier).Select(x => x.IdCard);
                    var soldiersCount = soldiers.Count();
                    var soldiersRepeated = soldiers.Distinct().Count();

                    if (soldiersRepeated == soldiersCount)
                        result = true;
                }
            }
            catch (InvalidOperationException)
            {
                result = false;
            }

            Assert.IsTrue(result);
        }
    }
}
