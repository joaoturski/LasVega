using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LasVega.Entity;

namespace LasVega.Controller
{
    public class BattleFactory
    {
        /// <summary>
        /// Obtém uma batalha.
        /// </summary>
        /// <param name="battleType">Tipo de batalha</param>
        /// <param name="user">Jogador atual</param>
        /// <returns>Uma batalha.</returns>
        public Battle GetBattle(BattleTypeEnum battleType, Player user)
        {
            switch (battleType)
            {
                case BattleTypeEnum.Practice:
                    return GetBattlePractice(user);

                case BattleTypeEnum.SinglePlayer:
                    return GetBattleSinglePlayer(user);

                case BattleTypeEnum.MultiPlayer:
                    return GetBattleMultiPlayer(user);

                default:
                    throw new NotImplementedException(string.Format("Tipo de batalha '{0}', não reconhecido.", battleType));
            }
        }

        private Battle GetBattlePractice(Player user)
        {
            var op = new OpponentFactory().GetOpponent(BattleTypeEnum.Practice, user);
            var result = new Battle(user, op);

            return result;
        }

        private Battle GetBattleSinglePlayer(Player user)
        {
            var op = new OpponentFactory().GetOpponent(BattleTypeEnum.SinglePlayer, user);

            //TODO
            throw new NotImplementedException();
        }

        private Battle GetBattleMultiPlayer(Player user)
        {
            var op = new OpponentFactory().GetOpponent(BattleTypeEnum.MultiPlayer, user);

            //TODO
            throw new NotImplementedException();
        }
    }
}
