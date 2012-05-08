using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LasVega.Entity;

namespace LasVega.Controller
{
    public class OpponentFactory
    {
        /// <summary>
        /// Obtém um oponente
        /// </summary>
        /// <param name="battleType">Tipo de batalha</param>
        /// <param name="user">Será utilizado para buscar um oponente do mesmo nível do usuário atual.</param>
        /// <returns>Um oponente.</returns>
        public Opponent GetOpponent(BattleTypeEnum battleType, Player user)
        {
            switch (battleType)
            {
                case BattleTypeEnum.Practice:
                    return GetOpponetPractice(user);

                case BattleTypeEnum.SinglePlayer:
                    return GetOpponetSinglePlayer(user);

                case BattleTypeEnum.MultiPlayer:
                    return GetOpponetMultiPlayer(user);

                default:
                    throw new NotImplementedException(string.Format("Tipo de batalha '{0}', não reconhecido.", battleType));
            }
        }

        private Opponent GetOpponetPractice(Player user)
        {
            //TODO
            var op = new OpponentAI();
            throw new NotImplementedException();
        }

        private Opponent GetOpponetSinglePlayer(Player user)
        {
            //TODO
            var op = new OpponentAI();
            throw new NotImplementedException();
        }

        private Opponent GetOpponetMultiPlayer(Player user)
        {
            //TODO
            var op = new OpponentRemote();
            throw new NotImplementedException();
        }
    }
}
