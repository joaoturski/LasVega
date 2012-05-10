using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace LasVega.Entity
{
    public class Battle : IGameObject
    {
        #region Properties

        public Player CurrentPlayer { get; private set; }
        public Opponent CurrentOpponent { get; private set; }

        #endregion

        #region Fields

        private CombatEngine _combatEngine;
        
        #endregion

        #region Init

        public Battle(Player player, Opponent opponent)
        {
            CurrentPlayer = player;
            CurrentOpponent = opponent;
            _combatEngine = new CombatEngine();
        }

        #endregion

        #region IGameObject implementation

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void LoadContent()
        {
            throw new NotImplementedException();
        }

        public void UnloadContent()
        {
            throw new NotImplementedException();
        }

        public void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public void Draw(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
